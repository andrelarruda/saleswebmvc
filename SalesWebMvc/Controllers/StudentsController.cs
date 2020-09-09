using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class StudentsController : Controller
    {

        private readonly StudentService _studentService;

        public StudentsController(StudentService studentService)
        {
            _studentService = studentService;
        }

        public IActionResult Index()
        {
            var allStudents = _studentService.findAll();

            return View(allStudents);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Create(Student obj)
        {
            _studentService.Insert(obj);
            return RedirectToAction("Index");
        }
    }
}
