using ApiProject.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProject.Models
{
    public class ResponseListModel<T>:IResponseListModel<T>
    {
        public bool Success { get; set; }
        public string ErrorDetail { get; set; }
        public IList<T> Response { get; set; }
    }
}
