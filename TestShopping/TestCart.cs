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
        public void Add_FirstArticle_Success()
        {
            //given
            //refer to Setup
            Assert.That(_cart.Articles.Count(), Is.EqualTo(0));

            //when
            _cart.Add(ArticleGenerator.Generate(1));

            //then
            Assert.That(_cart.Articles.Count(), Is.EqualTo(1));
        }

        [Test]
        public void Remove_OneArticleFromCartWithArticles_Success()
        {
            //given
            //refer to Setup
            int amountOfArticlesToAdd = 10;
            List<Article> expectedArticles = ArticleGenerator.Generate(amountOfArticlesToAdd);
            List<Article> articlesReadyToCheckout = new List<Article>();

            _cart.Add(expectedArticles);
            Assert.AreEqual(expectedArticles.Count(), _cart.Articles.Count());

            //when
            articlesReadyToCheckout = _cart.Remove();

            //then
            Assert.AreEqual(amountOfArticlesToAdd-1, _cart.Articles.Count());
            Assert.AreEqual(1, articlesReadyToCheckout.Count());
        }

        [Test]
        public void Remove_AllProductsFromCartWithArticles_Success()
        {
            //given
            //refer to Setup
            int amountOfArticlesToAdd = 10;
            List<Article> expectedArticles = ArticleGenerator.Generate(amountOfArticlesToAdd);
            List<Article> articlesReadyToCheckout = new List<Article>();
            
            _cart.Add(expectedArticles);
            Assert.AreEqual(expectedArticles.Count(), _cart.Articles.Count());

            //when
            articlesReadyToCheckout = _cart.Remove(true);

            //then
            Assert.AreEqual(0, _cart.Articles.Count());
            Assert.AreEqual(expectedArticles.Count(), articlesReadyToCheckout.Count());

        }
    }
}