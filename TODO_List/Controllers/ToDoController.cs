using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TODO_List.Models;
using LiteDB;

namespace TODO_List.Controllers
{
    public class ToDoController : Controller
    {
        private LiteDatabase _db = new LiteDatabase(@"C:\Users\alaci\Documents\GitHub\TODO_List\Data.db");
        public ActionResult Index()
        {
            var items = _db.GetCollection<ToDoItem>("ToDoItems").FindAll();
            return View(items);
        }

        // Zobrazení detailů úkolu
        public ActionResult Details(int id)
        {
            var item = _db.GetCollection<ToDoItem>("ToDoItems").FindById(id);
            return View(item);
        }

        // Vytvoření nového úkolu - GET
        public ActionResult Create()
        {
            return View();
        }

        // Vytvoření nového úkolu - POST
        [HttpPost]
        public ActionResult Create(ToDoItem item)
        {
            if (ModelState.IsValid)
            {
                _db.GetCollection<ToDoItem>("ToDoItems").Insert(item);
                return RedirectToAction("Index");
            }
            return View(item);
        }

        // Editace úkolu - GET
        public ActionResult Edit(int id)
        {
            var item = _db.GetCollection<ToDoItem>("ToDoItems").FindById(id);
            return View(item);
        }

        // Editace úkolu - POST
        [HttpPost]
        public ActionResult Edit(ToDoItem item)
        {
            if (ModelState.IsValid)
            {
                _db.GetCollection<ToDoItem>("ToDoItems").Update(item);
                return RedirectToAction("Index");
            }
            return View(item);
        }

        // Mazání úkolu - GET
        public ActionResult Delete(int id)
        {
            var item = _db.GetCollection<ToDoItem>("ToDoItems").FindById(id);
            return View(item);
        }

        // Mazání úkolu - POST
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            _db.GetCollection<ToDoItem>("ToDoItems").Delete(id);
            return RedirectToAction("Index");
        }

        // Zavření databáze při zavření kontroleru
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }

        // GET: ToDo
        //public ActionResult Index()
        //{
        //    return View();
        //}
        //public ActionResult Add()
        //{
        //    return View();
        //}
        //public ActionResult Edit()
        //{
        //    return View();
        //}
        //public ActionResult Delete()
        //{
        //    return View();
        //}
        //public ActionResult Details()
        //{
        //    return View();
        //}
        //public ActionResult List()
        //{
        //    //var tasks = Models.ToDoService.GetToDoList();
        //    return View(/*tasks*/);
        //}
        //public ActionResult Modify()
        //{
        //    return View();
        //}
        //public ActionResult addTask()
        //{
        //    //ToDoModel newTask= new ToDoModel();
        //    //newTask.Title = "Novy";
        //    //newTask.Description = "";
        //    //newTask.DueDate = DateTime.Now;
        //    //newTask.Priority = 1;
        //    //Models.ToDoService.AddTask(newTask);
        //    return View();
        //}
    }
}