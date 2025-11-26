using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using P2FixAnAppDotNetCode.Models;
using P2FixAnAppDotNetCode.Models.Services;

namespace P2FixAnAppDotNetCode.Controllers
{
    public class OrderController : Controller
    {
        private readonly ICart _cart;
        private readonly IOrderService _orderService;
        private readonly IProductService _productService;
        private readonly IStringLocalizer<OrderController> _localizer;

        public OrderController(ICart pCart, IOrderService service, IProductService productService, IStringLocalizer<OrderController> localizer)
        {
            _cart = pCart;
            _orderService = service;
            _productService = productService;
            _localizer = localizer;
        }

        public ViewResult Index() => View(new Order());

        [HttpPost]
        public IActionResult Index(Order order)
        {
            if (!((Cart) _cart).Lines.Any())
            {
                ModelState.AddModelError("", _localizer["CartEmpty"]);
            }

            // Vérifier que le stock est suffisant pour chaque ligne
            if (ModelState.IsValid)
            {
                foreach (var line in ((Cart)_cart).Lines)
                {
                    Product product = _productService.GetProductById(line.Product.Id);
                    if (product == null || product.Stock < line.Quantity)
                    {
                        ModelState.AddModelError("", _localizer["InsufficientStock"]);
                        break;
                    }
                }
            }

            if (ModelState.IsValid)
            {
                order.Lines = (_cart as Cart)?.Lines.ToArray();
                _orderService.SaveOrder(order);
                return RedirectToAction(nameof(Completed));
            }
            else
            {
                return View(order);
            }
        }

        public ViewResult Completed()
        {
            _cart.Clear();
            return View();
        }
    }
}
