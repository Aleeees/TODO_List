using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TODO_List.Models
{
    public class ToDoService
    {
        public static List<ToDoModel> GetToDoList()
        {
            using (var db = new LiteDatabase(@"\Data\ToDo.db"))
            {
                var toDoCollection = db.GetCollection<ToDoModel>("ToDo");
                return toDoCollection.FindAll().ToList();
            }
        }
        public static void AddTask(ToDoModel toDo)
        {
            using (var db = new LiteDatabase(@"\Data\ToDo.db"))
            {
                var toDoCollection = db.GetCollection<ToDoModel>("ToDo");
                toDoCollection.Insert(toDo);
            }
        }
        public static void DeleteTask(int id)
        {
            using (var db = new LiteDatabase(@"\Data\ToDo.db"))
            {
                var toDoCollection = db.GetCollection<ToDoModel>("ToDo");
                toDoCollection.Delete(id);
            }
        }
        public static void EditTask(ToDoModel toDo)
        {
            using (var db = new LiteDatabase(@"\Data\ToDo.db"))
            {
                var toDoCollection = db.GetCollection<ToDoModel>("ToDo");
                toDoCollection.Update(toDo);
            }
        }
        public static ToDoModel GetTask(int id)
        {
            using (var db = new LiteDatabase(@"\Data\ToDo.db"))
            {
                var toDoCollection = db.GetCollection<ToDoModel>("ToDo");
                return toDoCollection.FindById(id);
            }
        }
    }
}