using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_3
{
    class Author
    {
        public string Name { get; set; }
        public int BirthYear { get; set; }
        public Author(string name, int birthYear)
        {
            Name = name; BirthYear = birthYear;
        }
    }
}
