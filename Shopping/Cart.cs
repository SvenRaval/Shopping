using System.Net.Http.Headers;

namespace Shopping
{
    public class Cart : ICollectionOfArticles
    {
        #region private attributes
        private List<Article> _articles = new List<Article>();
        #endregion private attributes

        #region public methods
        public void Add(List<Article> articles)
        {
            _articles = articles;
        }

        public List<Article> Remove(Boolean clearCart = false)
        {
            List<Article> articlesReadyToCheckout = new List<Article>();
            if (clearCart)
            {
                articlesReadyToCheckout.AddRange(_articles);
                _articles = new List<Article>(); // Initialize as a new empty list
            }
            else
            {
                if (_articles.Count > 0)
                {
                    // Remove the last article from the cart
                    Article lastArticle = _articles[_articles.Count - 1];
                    _articles.Remove(lastArticle);
                    articlesReadyToCheckout.Add(lastArticle);
                }
                else
                {
                    throw new InvalidOperationException("The cart is empty. Cannot remove an article.");
                }
            }

            return articlesReadyToCheckout;
        }


        public void Release()
        {
            throw new NotImplementedException();
        }

        public List<Article> Articles
        {
            get
            {
                return _articles;
            }
        }

        public bool? IsReleased { get; set; }
        #endregion public methods
    }
}
