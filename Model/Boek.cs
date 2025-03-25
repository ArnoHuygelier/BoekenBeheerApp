using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoekenBeheerApp.Model
{
    public class Boek
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
        public string Genre { get; set; }
    }
}
