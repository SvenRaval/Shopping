using Shopping;
using static Shopping.CartItem;

namespace TestShopping
{
    public class TestCartItem
    {
        #region private attributes
        private CartItem? _cartItem = null;
        private Article? _article = null;
        private float _price = 0f;
        private int _quantity = 0;
        #endregion private attributes

        [SetUp]
        public void Setup()
        {
            _price = 20.45f;
            _article = new Article(_price);
            _quantity = 1;
            _cartItem = new CartItem(_article, _quantity);
        }

        [Test]
        public void AllProperties_AfterInstantiation_Success()
        {
            //given
            //refer to Setup

            //when
            //Event will be triggered by constructor

            //then
            Assert.AreEqual(_cartItem.Article.Price, _price);
            Assert.AreEqual(_cartItem.Quantity, _quantity);
        }

        [Test]
        public void SetQuantity_CorrectValue_GetNewValue()
        {
            //given
            int expectedQuantity = 2;

            //when
            _cartItem.Quantity = expectedQuantity;

            //then
            Assert.AreEqual(_cartItem.Quantity, expectedQuantity);
        }

        [Test]
        public void SetQuantity_WrongValue_ThrowException()
        {
            //given
            int expectedQuantity = -2;

            //when
            Assert.Throws<WrongQuantityException>(() => _cartItem.Quantity = expectedQuantity);
            
            //then
            //throws exception
        }
    }
}