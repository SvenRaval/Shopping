using System;
using System.Collections.Generic;  // Add this for List<T>

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
                throw new NotImplementedException();
            }
        }

        public bool? IsReleased { get; set; }
        #endregion public methods
    }
}
