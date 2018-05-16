using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using LeitnerProject.Core;
using LeitnerProject.Infrastructure;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace LeitnerProject.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
            InsertQuestion();
        }

        private static void InsertQuestion()
        {
            var question = new Question { Title = "What does AWS stand for?" };
            using (var context = new QuestionContext())
            {
                context.GetService<ILoggerFactory>().AddProvider(new MyLoggingProvider());
                context.Questions.Add(question);
                context.SaveChanges();
            }
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
