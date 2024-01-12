using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LiteDB.Engine;

namespace TODO_List.Models
{
    public class ToDoItem
    {   

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public int Priority { get; set; }
        public bool IsDone { get; set; }
    }
}