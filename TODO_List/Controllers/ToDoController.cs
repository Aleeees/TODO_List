using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TODO_List.Controllers
{
    public class ToDoController : Controller
    {
        // GET: ToDo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Add()
        {
            return View();
        }
        public ActionResult Edit()
        {
            return View();
        }
        public ActionResult Delete()
        {
            return View();
        }
        public ActionResult Details()
        {
            return View();
        }
        public ActionResult List()
        {
            var tasks = Models.ToDoService.GetToDoList();
            return View(tasks);
        }
        public ActionResult Modify()
        {
            return View();
        }
        public ActionResult addTask()
        {
            return View();
        }
    }
}