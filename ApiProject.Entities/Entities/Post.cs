using System;
using System.Collections.Generic;
using System.Text;

namespace ApiProject.Entities.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string BlogHeader { get; set; }
        public string BlogBody { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
