using System;
using System.Net;

namespace library_demo
{
    public class Book
    {
        protected string _author = "";   //in between private and public. available to this class and derived classes (i.e. PictureBook)
        protected string _title = "";

        //constructors
        public Book()
        {
            _author = "Anonymous";
            _title = "Unknown";
        }
        public Book(string author, string title)
        {
            _author = author;
            _title = title;
        }

        public string GetAuthor()
        {
            return _author;
        }

        public void SetAuthor(string author)
        {
            _author = author;
        }

        public string GetTitle()
        {
            return _title;
        }

        public void SetTitle(string title)
        {
            _title = title;
        }

        public string GetBookInfo()
        {
            return $"{_title} by: {_author}";
        }
    }
}