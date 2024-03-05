using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmoviZaglaviq
{
    public class Movie
    {
        private string rejisior;
        private string country;
        private string title;
        private string company;
        private string genre;
        private string isOkforminors;
        private bool isallEntered;

      
        public string Rejisior
        {
            get { return rejisior; }
            set { rejisior = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Company
        {
            get { return company; }
            set { company = value; }
        }
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        public string IsOkforminors
        {
            get { return isOkforminors; }
            set { isOkforminors = value; }
        }

        public Movie(string rejisior,string country, string title,string company,string genre,string isOkminor)
        {
            Rejisior= rejisior;
            Country= country;
            Title= title;
            Company= company;
            Genre= genre;
            IsOkforminors=isOkminor;
        }
        public Movie()
        {

        }
        

    }
}
