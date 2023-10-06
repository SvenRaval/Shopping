namespace Shopping
{
    public class ShoppingBag
    {
        #region private attributes
        private List<Article> articles = new List<Article>();

        public List<Article> Articles => throw new NotImplementedException();

        public void Add(List<Article> articles)
        {
            throw new NotImplementedException();
        }

        public List<Article> Remove(bool empty = false)
        {
            throw new NotImplementedException();
        }
        #endregion private attributes
    }
}
