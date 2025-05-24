using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Poteri_Davleniya.Models;
using Poteri_Davleniya.Data;
using Poteri_Davleniya.Migrations;

namespace Poteri_Davleniya.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PoteriContext _context;

        public HomeController(ILogger<HomeController> logger, PoteriContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var variants = _context.Variants.ToList();
            return View(variants);
        }

        public IActionResult Delete(int id)
        {
            var variant = _context.Variants.FirstOrDefault(x => x.ID == id);

            if (variant != null)
            { 
                _context.Variants.Remove(variant);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Calc(int id)
        {
            var variant = _context.Variants.FirstOrDefault(x => x.ID == id);
            var viewModel = new HomeCalcViewModel();

            if (variant != null) 
            {
                viewModel.pipe_lenght = variant.pipe_lenght;
                viewModel.pipe_quantity = variant.pipe_quantity;
                viewModel.rows_along = variant.rows_along;
                viewModel.rows_across = variant.rows_across;
                viewModel.step_along = variant.step_along;
                viewModel.step_across = variant.step_across;
                viewModel.pipe_diameter = variant.pipe_diameter;
                viewModel.pipe_thickness = variant.pipe_thickness;
                viewModel.smoke_temp = variant.smoke_temp;
                viewModel.smoke_temp_2 = variant.smoke_temp_2;
                viewModel.heating_air_temp = variant.heating_air_temp;
                viewModel.air_temp = variant.air_temp;
                viewModel.heating_air_outgo = variant.heating_air_outgo;
                viewModel.space_air_pass = variant.space_air_pass;
                viewModel.smoke_outgo = variant.smoke_outgo;
            }

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Calc(CalcModel model)
        {

            var viewModel = new HomeCalcViewModel()
            {
            };

            _context.Variants.Add(new Variant
            {
                pipe_lenght = model.pipe_lenght,
                pipe_quantity = model.pipe_quantity,
                rows_along = model.rows_along,
                rows_across = model.rows_across,
                step_along = model.step_along,
                step_across = model.step_across,
                pipe_diameter = model.pipe_diameter,
                pipe_thickness = model.pipe_thickness,
                smoke_temp = model.smoke_temp,
                smoke_temp_2 = model.smoke_temp_2,
                heating_air_temp = model.heating_air_temp,
                air_temp = model.air_temp,
                heating_air_outgo = model.heating_air_outgo,
                space_air_pass = model.space_air_pass,
                smoke_outgo = model.smoke_outgo,
            });
            _context.SaveChanges();

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Results(int id)
        {

            var variant = _context.Variants.FirstOrDefault(x => x.ID == id);
            if (variant == null) return NotFound();

            return View(new HomeCalcViewModel
            {
                ID = id,
                pipe_lenght = variant.pipe_lenght,
                pipe_quantity = variant.pipe_quantity,
                rows_along = variant.rows_along,
                rows_across = variant.rows_across,
                step_along = variant.step_along,
                step_across = variant.step_across,
                pipe_diameter = variant.pipe_diameter,
                pipe_thickness = variant.pipe_thickness,
                smoke_temp = variant.smoke_temp,
                smoke_temp_2 = variant.smoke_temp_2,
                heating_air_temp = variant.heating_air_temp,
                air_temp = variant.air_temp,
                heating_air_outgo = variant.heating_air_outgo,
                space_air_pass = variant.space_air_pass,
                smoke_outgo = variant.smoke_outgo
            });
        }

        [HttpPost]
        public IActionResult Results(int id, HomeCalcViewModel model)
        {
            var variant = _context.Variants.FirstOrDefault(x => x.ID == id);
            model.ID = id;
            model.pipe_lenght = variant.pipe_lenght;
            model.pipe_quantity = variant.pipe_quantity;
            model.rows_along = variant.rows_along;
            model.rows_across = variant.rows_across;
            model.step_along = variant.step_along;
            model.step_across = variant.step_across;
            model.pipe_diameter = variant.pipe_diameter;
            model.pipe_thickness = variant.pipe_thickness;
            model.smoke_temp = variant.smoke_temp;
            model.smoke_temp_2 = variant.smoke_temp_2;
            model.heating_air_temp = variant.heating_air_temp;
            model.air_temp = variant.air_temp;
            model.heating_air_outgo = variant.heating_air_outgo;
            model.space_air_pass = variant.space_air_pass;
            model.smoke_outgo = variant.smoke_outgo;
            return View(model);
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
