using baithuchanh1302.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using baithuchanh1302.Models.Process;

namespace baithuchanh1302.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult GBTTG() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult GBTTG(int heSoA,int heSoB,int heSoC) 
        {
            string thongbao="";
            int a, b, c, x, y, z;
            a = Convert.ToInt32(heSoA);
            b = Convert.ToInt32(heSoB);
            c= Convert.ToInt32(heSoC);
            x = a * a;
            y = b * b;
            z= c * c;
            if (a + b > c && b + c > a && c + a > b)
            {
                if (x == y || y == z || z == x)
                {
                    if (x == y && y == z) thongbao = "day la tam giac deu";
                    else
                    {
                        if (x == y + z || z == x + y || y == x + z) thongbao = "day la tam giac vuong can";
                        else thongbao = "day la tam giac can";
                    }
                }
                else
                {
                    if (x == y + z || y == x + z || z == x + y) thongbao = "tam giac vuong";
                    else thongbao = "tam giac thuong";
                }
            }
            else
                thongbao = "ba canh khong phai tam giac";
            ViewBag.message = thongbao;
            return View();
        }
    }
}