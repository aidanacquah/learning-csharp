using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{

    public class Customer
    {
        public string? CustomerName { get; set; }
        public string? Address { get; set; }

        public override string ToString()
        {
            return this.CustomerName + "|" + this.Address;
        }
    }

    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string GetString()
        {
            return "Hello World is old now. It's wime for wassup bro ;)";
        }

        //public Customer GetCustomer()
        //{
        //    Customer c = new Customer();
        //    c.CustomerName = "Customer 1";
        //    c.Address = "Address1";
        //    return c;
        //}

        public string GetCustomer()
        {
            Customer c = new()
            {
                CustomerName = "Customer 1",
                Address = "Address1"
            };
            return c.ToString(); 
            
            
        }

        public ActionResult HtmlPage()
        {
            return Content("<html><body>Ahoy.</body><label for=\"fname\">First name:</label><input type = \"text\" id = \"fname\" name = \"fname\" ><br><br></html>", "text/html");
        }

        [NonAction]
        public string SimpleMethod()
        {
            return "Hi, I am not action method";
        }


    }
}
