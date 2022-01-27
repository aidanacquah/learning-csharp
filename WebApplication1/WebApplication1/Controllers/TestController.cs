using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class Customer
    {
        public Customer(string CustomerName, string Address)
        {
            this.CustomerName = CustomerName;
            this.Address = Address;
        }
        public string? CustomerName { get; set; }
        public string? Address { get; set; }

        public override string ToString()
        {
            return CustomerName + "|" + Address;
        }
    }



    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult HtmlPage()
        {
            return Content("<html><body>Ahoy.</body><label for=\"fname\">First name:</label><input type = \"text\" id = \"fname\" name = \"fname\"><br><br></html>", "text/html");
        }

        public string GetString()
        {
            return "Hello World is old now. It’s time for wassup bro ;)";
        }

        public string GetCustomer()
        {
            var c = new Customer("Customer 1", "Address1");

            return c.ToString();
        }

        [NonAction]
        public string SimpleMethod()
        {
            return "Hi, I am not action method";
        }
    }
}
