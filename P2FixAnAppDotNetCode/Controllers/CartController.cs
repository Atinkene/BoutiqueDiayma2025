using System.Linq;
using Microsoft.AspNetCore.Mvc;
using P2FixAnAppDotNetCode.Models;
using P2FixAnAppDotNetCode.Models.Services;

namespace P2FixAnAppDotNetCode.Controllers
{
    public class CartController : Controller
    {
        private readonly ICart _cart;
        private readonly IProductService _productService;

        public CartController(ICart pCart, IProductService productService)
        {
            _cart = pCart;
            _productService = productService;
        }

        public ViewResult Index()
        {
            return View(_cart as Cart);
        }

        [HttpPost]
        public IActionResult AddToCart(int id)
        {
            Product product = _productService.GetProductById(id);

            if (product != null)
            {
                int quantityInCart = ((Cart)_cart).Lines
                    .Where(l => l.Product.Id == id)
                    .Sum(l => l.Quantity);

                if (product.Stock > quantityInCart)
                {
                    _cart.AddItem(product, 1);
                    TempData["SuccessMessage"] = $"✓ {product.Name} ajouté au panier";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["ErrorMessage"] = $"✗ Stock insuffisant pour {product.Name}. Disponible: {product.Stock}";
                    return RedirectToAction("Index", "Product");
                }
            }
            else
            {
                TempData["ErrorMessage"] = "✗ Produit non trouvé";
                return RedirectToAction("Index", "Product");
            }
        }

        public RedirectToActionResult RemoveFromCart(int id)
        {
            Product product = _productService.GetAllProducts()
                .FirstOrDefault(p => p.Id == id);

            if (product != null)
            {
                _cart.RemoveLine(product);
                TempData["SuccessMessage"] = $"✓ {product.Name} supprimé du panier";
            }
            return RedirectToAction("Index");
        }
    }
}
