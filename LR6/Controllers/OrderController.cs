using Microsoft.AspNetCore.Mvc;

public class OrderController : Controller
{
    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(User user)
    {
        if (user.Age > 16)
        {
            return RedirectToAction("ProductQuantity");
        }
        else
        {
            return RedirectToAction("UnderAge");
        }
    }

    [HttpGet]
    public IActionResult ProductQuantity()
    {
        return View();
    }

    [HttpPost]
    public IActionResult ProductQuantity(int quantity)
    {
        ViewBag.Quantity = quantity;
        return View("ProductOrder");
    }

    [HttpPost]
    public IActionResult Order(List<Product> products)
    {
        
        return View("OrderConfirmation", products);
    }

    public IActionResult UnderAge()
    {
        return View();
    }
}
