using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LiteDB.Engine;

namespace TODO_List.Models
{
    public class ToDoModel
    {
        int id;
        string title;
        string description;
        DateTime dueDate;
        int priority;
        bool isDone;

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public DateTime DueDate { get => dueDate; set => dueDate = value; }
        public int Priority { get => priority; set => priority = value; }
        public bool IsDone { get => isDone; set => isDone = value; }
    }
}