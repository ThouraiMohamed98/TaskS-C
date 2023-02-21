using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAndCourse.Models;
using StudentAndCourse.Repository;

namespace StudentAndCourse.Controllers
{
    public class courseController : Controller
    {
        public  ICourseRepository courseRepository;
        public courseController(ICourseRepository _courseRepository)
        {
            this.courseRepository = _courseRepository;
        }

        // GET: courseController
        public ActionResult Index()
        {
            return View(courseRepository.GetCourse());
        }

        // GET: courseController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: courseController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: courseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(course c)
        {
            try
            {
                courseRepository.AddCourse(c);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: courseController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: courseController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: courseController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: courseController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
