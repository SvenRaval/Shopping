using System;
using System.Collections.Generic;  // Add this for List<T>

namespace Shopping
{
    public class Cart : ICollectionOfArticles
    {
        #region private attributes
        private List<CartItem> _cartItems = new List<CartItem>();
        #endregion private attributes

        #region public methods
        public void Add(List<CartItem> cartItems)
        {
            _cartItems.AddRange(cartItems);  // Use the correct variable name
        }

        public List<CartItem> Remove(Boolean clearCart = false)
        {
            List<CartItem> cartItemsReadyToCheckout = new List<CartItem>();  // Change Article to CartItem
            if (clearCart)
            {
                cartItemsReadyToCheckout.AddRange(_cartItems);
                _cartItems = new List<CartItem>();  // Initialize as a new empty list
            }
            else
            {
                if (_cartItems.Count > 0)
                {
                    // Remove the last item from the cart
                    CartItem lastItem = _cartItems[_cartItems.Count - 1];
                    _cartItems.Remove(lastItem);
                    cartItemsReadyToCheckout.Add(lastItem);
                }
                else
                {
                    throw new InvalidOperationException("The cart is empty. Cannot remove an item.");
                }
            }

            return cartItemsReadyToCheckout;
        }

        public void Release()
        {
            throw new NotImplementedException();
        }

        public List<CartItem> CartItems  // Change Article to CartItem
        {
            get
            {
                return _cartItems;
            }
        }

        public float Price
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool? IsReleased { get; set; }
        #endregion public methods
    }
}
