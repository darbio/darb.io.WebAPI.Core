﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NSWRFS.Base.Api.Exceptions
{
    public class BusinessException : Exception
    {
        public BusinessException(string message) : base(message) { }

        public string Code { get; set; }
    }
}