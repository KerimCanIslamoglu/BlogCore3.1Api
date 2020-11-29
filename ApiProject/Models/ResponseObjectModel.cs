using ApiProject.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProject.Models
{
    public class ResponseObjectModel<T>:IResponseObjectModel<T>
    {
        public bool Success { get; set; }
        public string ErrorDetail { get; set; }
        public T Response { get; set; }
    }
}
