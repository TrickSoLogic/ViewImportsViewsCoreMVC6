using Microsoft.AspNetCore.Mvc;

namespace ViewImportsViewsCoreMVC6.Controllers
{
  public class ProductsController : Controller
  {
    [Route("products/all")]
    public IActionResult All()
    {
      return View();
    }
  }
}
