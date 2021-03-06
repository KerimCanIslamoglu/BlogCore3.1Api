﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProject.Models.Interfaces
{
    public interface IResponseListModel<T>
    {
        bool Success { get; set; }
        string ErrorDetail { get; set; }
        IList<T> Response { get; set; }
    }
}
