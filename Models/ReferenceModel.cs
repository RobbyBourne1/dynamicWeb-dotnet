using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dynamicWeb_dotnet.Models;

namespace dynamicWeb_dotnet.Models
{
    public class ReferenceModel
    {
        public string Message { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
    }
}