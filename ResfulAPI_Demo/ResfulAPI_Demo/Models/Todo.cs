﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ResfulAPI_Demo.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int UserId { get; set; }
        public bool Completed { get; set; }
        public Color ColorTitle
        {
            get
            {
                return Completed ? Color.Green : Color.Black;
            }
        }
    }
}
