using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    public class ProcessesController : ApiController
    {
        public ProcessCollectionState Get(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return new ProcessCollectionState
            {
                Processes = Process.GetProcessesByName(name)
                                .Select(p => new ProcessState(p))
            };
        }
    }

}

