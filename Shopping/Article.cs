using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Shopping
{
    public class Article
    {
        #region private attributes
        private int _id;
        private string _description = "";
        private float _price = 0f;
        #endregion private attributes

        #region public methods
        public Article(int id, string description, float price)
        {
            _id = id;
            _description = description;
            _price = price;
        }


        public int Id
        {
            get
            {
                return _id;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                char[] CharSpeciaux = { '!', '*', '+', '/' };
                foreach (char charUnAuthorized in CharSpeciaux)
                {
                    if (value.Contains(charUnAuthorized))
                    {
                        throw new SpecialCharInDescriptionException();
                    }
                }
                if (value.Length >= 50)
                {
                    throw new TooLongDescriptionException();
                }
                if (value.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length < 2)
                {
                    throw new TooShortDescriptionException();
                }
                _description = value;
            }
        }

        public float Price
        {
            get
            {
                return _price;
            }
        }
        #endregion public methods

        public class ArticleException : Exception { }
        public class TooShortDescriptionException : ArticleException { }
        public class SpecialCharInDescriptionException : ArticleException { }
        public class TooLongDescriptionException : ArticleException { }
    }
}
