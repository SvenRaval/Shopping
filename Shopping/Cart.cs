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

        public void Remove(List<CartItem> cartItemsToRemove)
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
                float totalPrice = 0.00f;

                foreach (CartItem cartItem in _cartItems)
                {
                    totalPrice += cartItem.Article.Price * cartItem.Quantity;
                }

                return totalPrice;
            }
        }
        #endregion public methods
    }   
}
