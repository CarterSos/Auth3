using Auth3.Models;
using Auth3.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Auth3.Controllers
{
    public class HomeController : Controller
    {
        private IMummyRepository repo;
        private readonly ILogger<HomeController> _logger;

        public HomeController(IMummyRepository temp, ILogger<HomeController> logger)
        {
            repo = temp;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Records(int pageNum = 1)
        {
            int pageSize = 100;

            var BurialData = new BurialViewModel
            {

                masterburialsummary3 = repo.masterburialsummary3 
                    .OrderBy(d => d.id)
                    .Skip((pageNum - 1) * pageSize)
                    .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalNumBurials = repo.masterburialsummary3.Count(),
                    BurialsPerPage = pageSize,
                    CurrentPage = pageNum
                },
            };

            return View(BurialData);
        }

        [HttpPost]
        public IActionResult Records(string BurialID, string Sex, string TextileColor, string AgeAtDeath, string HeadDirection,
            string HairColor, string TextileStructure, string TextileFunction, float EstimateStature, string Area, string Femur, int pageNum = 1) // POST
        {

            int pageSize = 100;

            var BurialData = new BurialViewModel
            {

                masterburialsummary3 = repo.masterburialsummary3 
                    .OrderBy(d => d.id)
                     .Where(d => (Sex == null || d.sex == Sex) && (BurialID == null || d.burialid == BurialID) &&
                        (TextileColor == null || d.color == TextileColor) &&
                        (AgeAtDeath == null || d.ageatdeath == AgeAtDeath) &&
                        (HeadDirection == null || d.headdirection == HeadDirection) &&
                        (HairColor == null || d.haircolor == HairColor) &&
                        (TextileStructure == null || d.structure == TextileStructure) &&
                        (TextileFunction == null || d.textilefunction == TextileFunction) &&
                        (Area == null || d.area == Area) &&
                        (Femur == null || d.femur == Femur))
                    .Skip((pageNum - 1) * pageSize)
                    .Take(pageSize),



                PageInfo = new PageInfo
                {
                    TotalNumBurials = (BurialID == null && Sex == null && TextileColor == null && AgeAtDeath == null && HeadDirection == null && HairColor == null
                    && TextileStructure == null && TextileFunction == null && Area == null && Femur == null ? repo.masterburialsummary3.Count() //most RECENT one
                       : repo.masterburialsummary3.Where(x => (Sex == null || x.sex == Sex) &&
                                           (TextileColor == null || x.color == TextileColor) &&
                                           (AgeAtDeath == null || x.ageatdeath == AgeAtDeath) &&
                                           (HeadDirection == null || x.headdirection == HeadDirection) &&
                                           (HairColor == null || x.haircolor == HairColor) &&
                                           (TextileStructure == null || x.structure == TextileStructure) &&
                                           (TextileFunction == null || x.textilefunction == TextileFunction) &&
                                           (Area == null || x.area == Area) &&
                                           (Femur == null || x.femur == Femur)).Count()),

                    BurialsPerPage = pageSize,
                    CurrentPage = pageNum
                },


            };
            return View(BurialData);
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
