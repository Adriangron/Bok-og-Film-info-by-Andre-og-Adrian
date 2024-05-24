using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bok_og_Film_info
{
    internal class Movie
    {
        private string type;
        private string title;
        private int year;
        private string description;
        private string creator;
        private List<string> actors;

        public Movie(string Type, string Title, int Year, string Description, string Creator, List<string> Actors)
        {
            type = Type;
            title = Title;
            year = Year;
            description = Description;
            creator = Creator;
            actors = Actors;
        }

        public string Type() { return type; }
        public string Title() { return title; }
        public int Year() { return year; }
        public string Description() { return description; }
        public string Creator() { return creator; }
        public List<string> Actors() {  return actors; }
    }
}
