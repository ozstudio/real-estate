using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Data;
using realEstate.Models;
using realEstate.DATA;
using realEstate.ViewModels;
using System.IO;
using CsvHelper;
using System.Globalization;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

namespace realEstate.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RealEstateDbContext _context;
        AllRealEstateViewModel allRealEstateViewModel = new AllRealEstateViewModel();


        public HomeController(RealEstateDbContext rd)
        {
            _context = rd;
        }


        //public  HomeController(ILogger<HomeController> logger)
        //{
           
            
        //    _logger = logger;
        //}
      

        public IActionResult Index()
        {
            

            var t = _context.realEstateModels.ToList();
            var g = new AllRealEstateViewModel();
            g.realEstateModels = t;
            return View(g);
        }


        
        public IActionResult Privacy()
        {
            return View();
        }

        
        public IActionResult New()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Create(SellingAgent sellingAgent)
        {
            
            _context.Agents.Add(sellingAgent);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }


        
        public ActionResult PopulateDb()
        {
            using (var reader = new StreamReader("wwwroot/csv/real-estate-items-tableCSV.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                
                
                var records = csv.GetRecords<RealEstateModel>();
                foreach (var item in records)
                {
                    _context.realEstateModels.Add(item);
                   


                }
                _context.SaveChanges();


            }


            return RedirectToAction("Privacy", "Home");
        }

        public IActionResult Edit(int id)
        {
            var agents = _context.Agents;
            var agent = agents.SingleOrDefault(c => c.SellingAgentId == id);

            //SellingAgent sellingAgent = new SellingAgent()
            //{
            //    SellingAgentId = agent.SellingAgentId,
            //    SellingAgentName = agent.SellingAgentName,
            //    AgentPhoto = agent.AgentPhoto
            

            //};
            
            return View("New");
        }

       

      
        public IActionResult FindSutable(string status,int rooms,string city)
        {
            
            var t = _context.realEstateModels.ToList();
            List<RealEstateModel> l = new List<RealEstateModel>();
            
            foreach (var item in t)
            {
                if (item.Rooms == rooms && item.PropertyStatus == status && item.City == city)
                {
                    // l.Add(item);
                    allRealEstateViewModel.realEstateModels.Add(item);
                }
                


            }

            //System.Diagnostics.Debug.WriteLine(status);
            System.Diagnostics.Debug.WriteLine(status);
            return View("Index",allRealEstateViewModel);
        }
        public IActionResult AllTelAviv()
        {

            var t = _context.realEstateModels.ToList();
            List<RealEstateModel> l = new List<RealEstateModel>();

            foreach (var item in t)
            {
                if (item.City == "Tel Aviv")
                {
                    // l.Add(item);
                    allRealEstateViewModel.realEstateModels.Add(item);
                }



            }

            return View("Index", allRealEstateViewModel);
        }
        public IActionResult AllHerzliya()
        {

            var t = _context.realEstateModels.ToList();
            List<RealEstateModel> l = new List<RealEstateModel>();

            foreach (var item in t)
            {
                if (item.City == "Herzliya")
                {
                    // l.Add(item);
                    allRealEstateViewModel.realEstateModels.Add(item);
                }



            }

            return View("Index", allRealEstateViewModel);
        }

        public ActionResult Filtered()
        {
            System.Diagnostics.Debug.WriteLine(allRealEstateViewModel.realEstateModels.Count());
            return View("Filtered",allRealEstateViewModel);

        }


        public IActionResult Delete(int id)
        {
            var agents = _context.Agents;
            var agent = agents.SingleOrDefault(c => c.SellingAgentId == id);
            _context.Agents.Remove(agent);
            _context.SaveChanges();


            return RedirectToAction("Index", "Home");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
