﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Models.Sqlite
{
    public class Class
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Teacher { get; set; }
    }
}