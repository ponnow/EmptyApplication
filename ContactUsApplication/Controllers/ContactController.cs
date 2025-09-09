using ContactUsApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactUsApplication.Controllers
{
    public class ContactController : Controller
    {
        //File Download Example
        public FileResult FileExample()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files", "Nazmul Hasan_CVS.pdf");
            var fileBytes = System.IO.File.ReadAllBytes(filePath);
            var fileName = "Nazmul Hasan_CVS.pdf";
            return File(fileBytes, "application/pdf", fileName);

        }
        //Json Data Example
        public JsonResult JsonExample()
        {
            ModelContact modelcontact = GetModelContact();
            return Json(modelcontact);
            //return Json(new { Name = "John Doe", Email = "john@yahoo.com" });
        }

        //Redirection Example
        public IActionResult RedirecExample()
        {
            //return Redirect("https://google.com");
            //return RedirectToAction("Viewcontact");
            return RedirectToAction("Index","Home");
        }

        //This Routing(TestAction) support only String or Int or others Type data what I Declared in the method parameter
        public string TestAction()
        {
            return "This is a test action method.";
        }

        //IActionResult support both String,Int and others Type data Dynamically

        //Custom Routing
        //[Route("SM/Index")]
        public IActionResult Viewcontact()
        {
            ModelContact modelcontact = GetModelContact();
            return View(modelcontact);
        }

        //Custom Routing with parameters
        //[Route("SM/Details/{id}/{category}")]
        public IActionResult Details(int id,string category)
        {
            ModelContact modelcontact = GetModelContact();

            return Content($"My Contact ID: {id}; Contact Type: {category}");
        }

        private ModelContact GetModelContact()
        {
            return new ModelContact
            {
                Name = "John Doe",
                Email = "jhon@yahoo.com",
                Subject = "Test Subject",
                Message = "This is a test message."
            };
        }
    }
}
