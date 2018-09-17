//using System;
using SQLite;

namespace Todo.Models
{
    public class Item
    {
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
		public bool Done { get; set; }
    }
}