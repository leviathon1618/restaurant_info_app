﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace resturant_app.models
{
    public class Notes
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Title { get; set; }
        public string CreatedBy { get; set; }
        public string Ingredients { get; set; }
        public string Steps { get; set; }
        public DateTime Date { get; set; }
    }
}
