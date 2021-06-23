using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
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

        public IActionResult Index(int? page)
        {
            var Courses = _db.Courses.OrderByDescending(s => s.Id).AsEnumerable().ToPagedList(page ?? 1,10);
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
        public IActionResult Upsert(Course course)
        {
            //Update
            if (course.Id > 0)
            {
                var ExistingCourse = _db.Courses.AsNoTracking().SingleOrDefault(c=>c.Id == course.Id);
                if (ExistingCourse != null)
                {
                    _db.Entry(course).State = EntityState.Modified;

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
                    _db.Courses.Add(course);
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
