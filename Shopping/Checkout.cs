namespace Shopping
{
    public class Checkout : ICollectionOfArticles
    {
        #region private attributes
        private List<Article> _articles = new List<Article>();
        private float _balance = 0f;
        private float _updateBalance = 0f;
        #endregion private attributes

        #region public methods
        public void Add(List<Article> articles)
        {
            Articles.AddRange(articles);
            _balance += articles.Count;
            UpdateBalance();
        }

        public List<Article> Remove(Boolean empty = false)
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

        public float Balance
        {
            get
            {
                return _balance;
                UpdateBalance();
            }
        }

        public void StartCashingProcess()
        {
            throw new NotImplementedException();
        }
        #endregion public methods

        #region private methods
        private void UpdateBalance()
        {
            {
                _updateBalance = _balance;
            }
        }
        #endregion private methods
    }
}
