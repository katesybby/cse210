using System;

namespace library_demo
{
    public class PictureBook : Book   //tells it that it inherits from Book class
    {
        private string _illustrator = "";

        public PictureBook() : base()
        {

        }

        public PictureBook(string author, string title, string illustrator) : base(author, title)   //calls base class constructor
        {
            // _author = author;
            // _title = title;   //inherits from Book class

            _illustrator = illustrator;
        }

        public string GetIllustrator()
        {
            return _illustrator;
        }
        public void SetIllustrator(string illustrator)
        {
            _illustrator = illustrator;
        }

        public string GetPictureBookInfo()
        {
            return $"{_title} by: {_author}, illustrated by: {_illustrator}";
        }
    }
}

