using Microsoft.AspNetCore.Mvc;

namespace ArabaSatisi.Controllers
{
    public class MarkaController : Controller
    {
        public JsonResult Index()
        {
            return Json(new { 
            
            Id=1,
            Marka="Togg",
            Model="T10X"
            });
        }
    }
}
