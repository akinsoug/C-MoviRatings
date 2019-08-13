using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRating
{
    class Movie
    {
        int cstar;
        string ctitle;

        public Movie()
        {
            this.cstar = 0;
            this.ctitle = "";
        }
        public Movie(int star, string title)
        {
            this.cstar = star;
            this.ctitle = title;
        }

        public int Cstar { get => cstar; set => cstar = value;}
        public string Ctitle { get => ctitle; set => ctitle = value;}
    }
}
