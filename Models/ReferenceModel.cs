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

        public async Task<List<ReferenceModel>> Builder()
        {
            var commentList = new List<ReferenceModel>();

            using (var reader = new StreamReader(System.IO.File.Open("comments.csv", FileMode.Open)))
                while (reader.Peek() >= 0)
                {
                    var user = await reader.ReadLineAsync();
                    var data = user.Split(',');

                    var newComment = new ReferenceModel();
                    newComment.Message = data[0];
                    newComment.Name = data[1];
                    newComment.Email = data[2];
                    newComment.Website = data[3];
                    newComment.PostDate = data[4];
                    commentList.Add(newComment);
                }
            return commentList;
        }
    }
}