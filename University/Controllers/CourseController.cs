using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using University.Data;
using University.Models;

namespace University.Controllers
{
    public class CourseController : Controller
    {
        private UniversityDbContext _db;

        public CourseController(UniversityDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var Courses = _db.Courses.OrderByDescending(s => s.Id).ToList();
            return View(Courses);
        }

        [HttpGet]
        public IActionResult Upsert(int id = 0)
        {
            if (id > 0)
            {
                var Course = _db.Courses.Find(id);
                if (Course != null)
                {
                    return View(Course);
                }
                return NotFound();
            }
            else
            {
                Course Course = new Course()
                {
                    Id = 0,
                    Title = string.Empty
                };
                return View(Course);
            }
        }

        [HttpPost]
        public IActionResult Upsert(Course Course)
        {
            //Update
            if (Course.Id > 0)
            {
                var ExistingCourse = _db.Courses.Find(Course.Id);
                if (ExistingCourse != null)
                {
                    var config = new MapperConfiguration(c => c.CreateMap<Course, Course>());
                    var mapper = config.CreateMapper();
                    mapper.Map<Course, Course>(Course, ExistingCourse);

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
                    _db.Courses.Add(Course);
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
            return PartialView("_CourseGrid", _db.Courses.OrderByDescending(s => s.Id).ToList());
        }

        [HttpGet]
        public IActionResult Delete(int id = 0)
        {
            if (id == 0) return NotFound();

            var Course = _db.Courses.Find(id);
            if (Course != null)
            {
                return View("Delete", Course);
            }

            return NotFound();
        }

        [HttpPost]
        public IActionResult Delete(Course Course)
        {
            if (Course != null)
            {
                _db.Courses.Remove(Course);
                _db.SaveChanges();
                return Ok();
            }
            return NotFound();
        }
    }
}
