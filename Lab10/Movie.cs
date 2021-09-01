using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10
{
    public class Movie
    {
        private string _title;
        private string _category;

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }

        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
            }
        }

        public Movie (string title, string category)
        {
            Setup(title, category);
        }

        private void Setup(string title, string category)
        {
            _title = title;
            _category = category;
        }
    }
}
