using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using University.Data;
using University.Models;
using System.Text.Json;
using AutoMapper;

namespace University.Controllers
{
    public class StudentController : Controller
    {
        private UniversityDbContext _db;

        public StudentController(UniversityDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var Students = _db.Students.OrderByDescending(s=>s.Id).ToList();
            return View(Students);
        }

        [HttpGet]
        public IActionResult Upsert(int id=0)
        {
            if (id > 0)
            {
                var Student = _db.Students.Find(id);
                if (Student != null)
                {
                    return View(Student);
                }
                return NotFound();
            }
            else
            {
                Student student = new Student()
                {
                    Id=0,
                    FirstName=string.Empty,
                    LastName=string.Empty
                };
                return View(student);
            }
        }

        [HttpPost]
        public IActionResult Upsert(Student student)
        {
            //Update
            if (student.Id > 0)
            {
                var ExistingStudent = _db.Students.Find(student.Id);
                if (ExistingStudent != null)
                {
                    var config = new MapperConfiguration(c => c.CreateMap<Student, Student>());
                    var mapper = config.CreateMapper();
                    mapper.Map<Student, Student>(student, ExistingStudent);

                    _db.SaveChanges();
                    return Ok();
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                try
                {
                    _db.Students.Add(student);
                    _db.SaveChanges();
                    return Ok();
                }
                catch
                {
                    return BadRequest();
                }
            }
        }

        [HttpGet]
        public IActionResult FillGrid()
        {
            return PartialView("_StudentGrid",_db.Students.OrderByDescending(s => s.Id).ToList());
        }

        [HttpGet]
        public IActionResult Delete(int id=0)
        {
            if (id == 0) return NotFound();

            var student = _db.Students.Find(id);
            if(student!=null)
            {
                return View("Delete", student);
            }

            return NotFound();
        }

        [HttpPost]
        public IActionResult Delete(Student student)
        {
            if (student != null)
            {
                _db.Students.Remove(student);
                _db.SaveChanges();
                return Ok();
            }
            return NotFound();
        }
    }
}
