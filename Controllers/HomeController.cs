using Dogs.Models;
using Microsoft.AspNetCore.Mvc; //MVC-mönstret
using Newtonsoft.Json;

namespace Dogs.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
         
            var JsonStr = System.IO.File.ReadAllText("dogs.json");
            var JsonObj = JsonConvert.DeserializeObject<List<DogModel>>(JsonStr);
            return View(JsonObj);
        }
        [Route("/om")]
        public IActionResult About()
        {
            //Skicka en text-sträng med viewbag till sidan about
            string welcome = "Välkommen till Adopt don't shop - Där du kan adoptera en hund";
            ViewBag.text = welcome;
            return View();
        }
        [Route("/hundar")]
        public IActionResult Dogs()
        {
            return View();
        }
        [HttpPost("/hundar")]
        public IActionResult Dogs(DogModel model)
        {
            //kontroll om formuläret är korrekt ifyllt
            if (ModelState.IsValid)
            {
                //formuläret är ifyllt
                var JsonStr = System.IO.File.ReadAllText("dogs.json");
                var JsonObj = JsonConvert.DeserializeObject<List<DogModel>>(JsonStr);
                if (JsonObj != null)
                {
                    JsonObj.Add(model);
                    System.IO.File.WriteAllText("dogs.json", JsonConvert.SerializeObject(JsonObj, Formatting.Indented));

                    ModelState.Clear();
                    return RedirectToAction("Index", "Home");
                }

            }

            return View();
        }
    }
}