using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dynamicWeb_dotnet.Models;

namespace dynamicWeb_dotnet.Models
{
    public class PriceListModel
    {
        public string Service { get; set; }
        public string Info { get; set; }
        public string Price { get; set; }
         
    } 
}
