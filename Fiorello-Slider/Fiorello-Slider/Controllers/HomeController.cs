
using Fiorello_Slider.Data;
using Fiorello_Slider.Models;
using Fiorello_Slider.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello_Slider.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            SliderDetail sliderDetail = _context.SliderDetails.FirstOrDefault();

            HomeVM model = new HomeVM
            {
                Sliders = sliders,
                SliderDetail = sliderDetail
            };

            return View(model);
        }
    }
}
