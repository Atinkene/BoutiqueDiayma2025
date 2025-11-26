using System;
using System.Linq;
using P2FixAnAppDotNetCode.Models.Repositories;

namespace P2FixAnAppDotNetCode.Models.Services
{
    /// <summary>
    /// Provides services to manage an order
    /// </summary>
    public class OrderService : IOrderService
    {
       private readonly ICart _cart;
       private readonly IOrderRepository _repository;
       private readonly IProductService _productService;

        public OrderService(ICart cart, IOrderRepository orderRepo, IProductService productService)
        {
            _repository = orderRepo;
            _cart = cart;
            _productService = productService;
        }

        /// <summary>
        /// Saves an order
        /// </summary>
        public void SaveOrder(Order order)
        {
            order.Date = DateTime.Now;
            order.Lines = ((Cart)_cart).Lines.ToArray();
            
            // Vérifier et mettre à jour le stock AVANT de sauvegarder la commande
            if (ValidateStockAvailability((Cart)_cart))
            {
                _repository.Save(order);
                UpdateInventory();
            }
        }

        /// <summary>
        /// Validates that sufficient stock is available for all items in the cart
        /// </summary>
        private bool ValidateStockAvailability(Cart cart)
        {
            foreach (var line in cart.Lines)
            {
                Product product = _productService.GetProductById(line.Product.Id);
                if (product == null || product.Stock < line.Quantity)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Update the product quantities inventory and clears the cart
        /// </summary>
        private void UpdateInventory()
        {
            _productService.UpdateProductQuantities((Cart)_cart);
            _cart.Clear();
        }
    }
}
