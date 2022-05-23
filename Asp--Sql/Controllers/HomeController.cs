using Asp__Sql.Entities;
using Asp__Sql.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Asp__Sql.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(FormData formData)
        {

            string name = formData.Name;

            LuciferContext context = new LuciferContext();
            List<GetStudentsResult>
                studentsResults = context.Set<GetStudentsResult>()
                                        .FromSqlRaw("EXECUTE dbo.GetStudentsWithClassNames '"+ name + "'")
                                        .ToList();
            
            IndexViewModel viewModel = new IndexViewModel();
            viewModel.Students = studentsResults;

            return View("Index", viewModel);
        }

        public IActionResult GetList(FormData formData)
        {

            string name = formData.Name;
            LuciferContext context = new LuciferContext();
            List<GetStudentsResult>
                studentsResults = context.Set<GetStudentsResult>()
                                        .FromSqlRaw("EXECUTE dbo.GetStudentsWithClassNames '" + name + "'")
                                        .ToList();
            return Json(new { 
                list = studentsResults
            });
           
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

}