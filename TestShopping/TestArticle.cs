using Shopping;

namespace TestShopping
{
    public class TestArticle
    {
        #region private attributes
        private Article? _article = null;
        private float _price = 0f;
        #endregion private attributes

        [SetUp]
        public void Setup()
        {
            _price = 20.45f;
            _article = new Article(_price);
        }

        [Test]
        public void Price_AfterInstantiation_Success()
        {
            //given
            //refer to Setup

            //when
            //Event will be triggered by constructor

            //then
            Assert.AreEqual(_price, _article.Price);
        }
    }
}