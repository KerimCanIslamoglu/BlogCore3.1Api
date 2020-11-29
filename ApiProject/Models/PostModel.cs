using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProject.Models
{
    public class PostModel
    {
        public int Id { get; set; }
        public string BlogHeader { get; set; }
        public string BlogBody { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? CreatedDay { get; set; }
        public string CreatedMonth { get; set; }
    }
}
