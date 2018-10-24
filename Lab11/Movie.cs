using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Movie
    {
        private string Title;
        private string Category;

        public Movie (string title, string category)
        {
            Title = title;
            Category = category;
        }

        public String returnCategory(Movie movie)
        {
            return movie.Category;
        }

        public String returnTitle(Movie movie)
        {
            return movie.Title;
        }

    }
}
