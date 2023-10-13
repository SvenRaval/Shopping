using System;
using System.Net.Http.Headers;

namespace Shopping
{
    public class Cart
    {
        #region private attributes
        private List<CartItem> _cartItems = new List<CartItem>();
        #endregion private attributes

        #region public methods
        public void Add(List<CartItem> cartItems)
        {
            _cartItems.AddRange(cartItems);  // Use the correct variable name
        }

        public void Remove(List<CartItem> cartItemsToRemove = null)
        {
            throw new NotImplementedException();
        }

        public List<CartItem> CartItems
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
                float totalPrice = 0f;
                foreach (var cartItem in _cartItems)
                {
                    totalPrice += cartItem.Article.Price * cartItem.Quantity;
                }
                return totalPrice;
            }
        }

        public int Cheapest()
        {
            throw new NotImplementedException();
        }
        #endregion public methods
        public class CartException : Exception { }
    }
}
