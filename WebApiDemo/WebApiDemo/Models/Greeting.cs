﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiDemo.Models
{
    [Serializable]
    public class Greeting
    {
        public string Name { get; set; }
        public string Message { get; set; }
    }
}