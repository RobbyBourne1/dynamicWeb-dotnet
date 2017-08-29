using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dynamicWeb_dotnet.Models;
using System.IO;

namespace dynamicWeb_dotnet.Models
{
    public class ReferenceModel
    {
        public string Message { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string PostDate { get; set; } = DateTime.Now.ToString();

        public async Task<IEnumerable<ReferenceModel>> Builder()
        {
            

            using (var reader = new StreamReader(System.IO.File.Open("comments.csv", FileMode.Open)))
               {
                    var user = await reader.ReadToEndAsync();
                    return user.Split('\n').Where(w => !String.IsNullOrEmpty(w)).Select(s => {
                        var _data = s.Split(',');
                        Console.WriteLine(s);
                        return new ReferenceModel
                        {Message = _data[0], 
                        Name = _data[1],
                        Email = _data[2],
                        Website = _data[3],
                        PostDate = _data[4]
                        };
                    });
                }
           
        }
    }
}