using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAndCourse.Models;
using StudentAndCourse.Repository;

namespace StudentAndCourse.Controllers
{
    public class studentController : Controller
    {
        public IStudentRepository StudentRepository;
        public studentController(IStudentRepository _StudentRepository)
        {
            this.StudentRepository = _StudentRepository;
        }

        // GET: studentController
        public ActionResult Index()
        {
            return View(StudentRepository.getAllStudent());
        }

        // GET: studentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: studentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: studentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: studentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: studentController/Edit/5
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

        // GET: studentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: studentController/Delete/5
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
