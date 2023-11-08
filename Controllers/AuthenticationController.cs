using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using T2210M_MVC1.Models;

namespace T2210M_MVC1.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly ILogger<AuthenticationController> _logger;
        public AuthenticationController(ILogger<AuthenticationController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
         public IActionResult Register() 
        {
            return View();
        }
        public IActionResult User()
        {
            List<UserRegisterModel> ls = new List<UserRegisterModel>();
            ls.Add(new UserRegisterModel
            {
                id = 1,
                Email = "abc@gmail.com",
                Fullname = "Abc",
                Telephone ="012312456"
            }); 
            ls.Add(new UserRegisterModel
            {
                id = 2,
                Email = "abcd@gmail.com",
                Fullname = "Abcd",
                Telephone ="012387808"
            });
            //ViewData["user"] =ls; c1
           // ViewBag.user = ls; c2
            return View(ls);    //c3
        }

        public IActionResult Product() {
            List<ProductModel> pd = new List<ProductModel>();
            pd.Add(new ProductModel {
                id = 1,
                Name = "Iphone 15",
                Price = "1900$",
                Thumbnail ="https://smartviets.com/template/plugins/timthumb.php?src=/upload/iPHONE15/iPHONE15PR-PRM/15PRM-white_titanium.jpg&w=770&h=770&q=80"


            });  
            pd.Add(new ProductModel {
                id = 2,
                Name = "Xiaomi 15",
                Price = "2000$",
                Thumbnail ="https://w0.peakpx.com/wallpaper/691/18/HD-wallpaper-xiaomi-mi-mix-2s-smartphone-mi-mix-2s-xiaomi.jpg"


            });   
            pd.Add(new ProductModel {
                id = 3,
                Name = "Samsung Galaxy s21",
                Price = "1200$",
                Thumbnail ="https://fdn2.gsmarena.com/vv/pics/samsung/samsung-galaxy-s21-ultra-5g-2.jpg"


            });

            return View(pd);    //c3
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    
    }
}
