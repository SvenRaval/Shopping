using Shopping;

namespace TestShopping
{
    public class TestArticle
    {
        #region private attributes
        private Article? _article = null;
        private int _id;
        private string _description;
        private float _price = 0f;
        #endregion private attributes

        [SetUp]
        public void Setup()
        {
            _id = 1;
            _description = "product description";
            _price = 20.45f;
            _article = new Article(_id, _description, _price);
        }

        [Test]
        public void AllProperties_AfterInstantiation_Success()
        {
            //given
            //refer to Setup

            //when
            //Event will be triggered by constructor

            //then
            Assert.AreEqual(_id, _article.Id);
            Assert.AreEqual(_description, _article.Description);
            Assert.AreEqual(_price, _article.Price);
        }
    }
}