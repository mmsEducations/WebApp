using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class CountryController : Controller
    {
        public IActionResult Index()
        {
            List<Country> countries = new List<Country>()
            {
               new Country{ Name = "Fransa" ,
                            Description = "Sömürgeci fransa afrika kıtasını sömürdü" },

               new Country{ Name = "İngiltere" ,
                            Description = "Yılanın başı olan ingilitere yıllarca mısır'ı sömürdü" },

               new Country{ Name = "Italya" ,
                            Description = "Kendi payına düştüğü yerleri sömürdü" },

               new Country{ Name = "Israil" ,
                            Description = "Kuran'ı kerimde Allah'ın bir çok ayette kötü şekilde " +
                            "bahsettiği yahudiler peygamberleri öldürmüş ve şuanda da hiç bir kanun " +
                            "ve yasa dinlemeden sivil asker demeden binlerce çocucğu katletti" },
            };

            MyModel m1 = new MyModel() { Contries = countries, Data = "Barbar avrupa ülkeleri" };

            return View(m1);
        }
    }


}
