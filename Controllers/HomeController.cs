using MarketAppV1.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MarketAppV1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        //Método temporal mientras registramos roles
        //IServiceProvider _serviceProvider;
        
        //public HomeController(IServiceProvider serviceProvider)
        //{
        //    _serviceProvider = serviceProvider;
        //}

        //public async Task<IActionResult> Index()
        //{
        //    await CreateRolesAsync(_serviceProvider);
        //    return View();
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //Método para crear lor roles ::: Alejo Restrepo 23:04 11 de Dic2021
        private async Task CreateRolesAsync (IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            string[] rolesName = { "Administrador", "Usuario", "Cliente" };
            foreach (var item in rolesName)
            {
                var roleExist = await roleManager.RoleExistsAsync(item);
                if (!roleExist)
                {
                    await roleManager.CreateAsync(new IdentityRole(item));
                }
            }
        }
    }
}