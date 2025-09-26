﻿using Microsoft.AspNetCore.Mvc;
using MyFirstApplication.Data;
using MyFirstApplication.Models;

namespace MyFirstApplication.Controllers
{
    public class StudentController : Controller
    {


        private readonly ApplicationDbContext _db;

        public StudentController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Student> objStudentList = _db.Students;
            //var objStudentList = _db.Students.ToList();
            return View(objStudentList);

        }

        //GET
        public IActionResult Create()
        {
            return View();
        }


        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student obj)
        {
            if (ModelState.IsValid)
            {
                _db.Students.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Category created successfully";
                return RedirectToAction("Index");
            }
            TempData["Error"] = "User Update Failed";
            return View(obj);
        }


        //GET
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)

            {
                return NotFound();
            }
            var student = _db.Students.Find(id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Student student)
        {

            if (ModelState.IsValid)
            {
                _db.Students.Update(student);
                _db.SaveChanges();
                TempData["success"] = "Student updated successfully";
                return RedirectToAction("Index");
            }
            TempData["Error"] = "User Update Failed";
            return View(student);
        }

    }
}




