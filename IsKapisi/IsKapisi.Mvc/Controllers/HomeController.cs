using IsKapisi.Business.Abstract;
using IsKapisi.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IsKapisi.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IJobService _jobManager;

        public HomeController(IJobService jobManager)
        {
            _jobManager = jobManager;
        }

        public IActionResult Index()
        {
            var jobs = _jobManager.GetAll(true);
            return View(jobs);

        }


    }
}
