using System;
using System.Collections.Generic;
using System.Text;

namespace ResfulApi.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int UserId { get; set; }
        public string Body { get; set; }   
        
        public string NameUser { get; set; }
    }
}
