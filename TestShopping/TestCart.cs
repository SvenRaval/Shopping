using Shopping;

namespace TestShopping
{
    public class TestCart
    {
        #region private attributes
        private Cart? _cart = null;
        #endregion private attributes

        [SetUp]
        public void Setup()
        {
            _cart = new Cart();
        }

        [Test]
        public void Add_FirstSingleCartItem_Success()
        {
            //given
            //refer to Setup
            float expectedArticlePrice = 4.5f;
            Article expectedArticle = new Article(expectedArticlePrice);
            int expectedQuantity = 1;
            CartItem expectedCartItem = new CartItem(expectedArticle, expectedQuantity);
            List<CartItem> expectedCartItems = new List<CartItem> { expectedCartItem };
            Assert.That(_cart.CartItems.Count(), Is.EqualTo(0));

            //when
            _cart.Add(expectedCartItems);

            //then
            Assert.That(_cart.CartItems.Count(), Is.EqualTo(expectedQuantity));
            Assert.That(_cart.Price, Is.EqualTo(expectedArticlePrice));
        }

        [Test]
        public void Add_MultipleSingleCartItems_Success()
        {
            //given
            //refer to Setup
            //TODO must be generated automatically
            float expectedArticlePrice1 = 4.5f;
            Article expectedArticle1 = new Article(expectedArticlePrice1);
            int expectedQuantity1 = 1;
            CartItem expectedCartItem1 = new CartItem(expectedArticle1, expectedQuantity1);

            float expectedArticlePrice2 = 5.0f;
            Article expectedArticle2 = new Article(expectedArticlePrice2);
            int expectedQuantity2 = 1;
            CartItem expectedCartItem2 = new CartItem(expectedArticle2, expectedQuantity2);

            List<CartItem> expectedCartItems = new List<CartItem> { expectedCartItem1, expectedCartItem2 };
            Assert.That(_cart.CartItems.Count(), Is.EqualTo(0));

            //when
            _cart.Add(expectedCartItems);

            //then
            Assert.That(_cart.CartItems.Count(), Is.EqualTo(expectedQuantity1 + expectedQuantity2));
            Assert.That(_cart.Price, Is.EqualTo(expectedArticlePrice1 + expectedArticlePrice2));
        }

        [Test]
        public void Add_OneMultipleCartItems_Success()
        {
            //given
            //refer to Setup
            //TODO must be generated automatically
            float expectedArticlePriced = 4.5f;
            Article expectedArticle = new Article(expectedArticlePriced);
            int expectedQuantity = 2;
            CartItem expectedCartItem = new CartItem(expectedArticle, expectedQuantity);

            List<CartItem> expectedCartItems = new List<CartItem> { expectedCartItem };
            Assert.That(_cart.CartItems.Count(), Is.EqualTo(0));

            //when
            _cart.Add(expectedCartItems);

            //then
            Assert.That(_cart.CartItems.Count(), Is.EqualTo(expectedQuantity));
            Assert.That(_cart.Price, Is.EqualTo(expectedArticlePriced * expectedQuantity));
        }
    }
}