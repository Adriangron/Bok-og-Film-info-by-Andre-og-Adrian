using Microsoft.VisualBasic;

namespace Bok_og_Film_info
{
    internal class Program
    {



        static void Main(string[] args)
        { 
            List <Movie> movies = new List <Movie> ();
            

            new Run().run(movies);
        }
        
    }

    class Run
    {
        public void run(List<Movie> movieList)
        {
            var gameOn = true;
                
                while (gameOn)
                {
                    Console.WriteLine("Is this a book or a movie: ");
                    var inputType = Convert.ToString(Console.ReadLine());

                    Console.Clear();

                    Console.Write("title ");
                    var inputTitle = Convert.ToString(Console.ReadLine());

                    Console.Clear();

                    Console.Write("releasedate: ");
                    var inputReleasedate = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();

                    Console.Write("Description: ");
                    var inputDescription = Convert.ToString(Console.ReadLine());

                    Console.Clear();

                    Console.Write("Director/Author: ");
                    var inputDirectorAuthor = Convert.ToString(Console.ReadLine());

                    Console.Clear();

                    List<string> actorsList = new List<string>();
                    if (inputType == "movie")
                    {
                        Console.WriteLine("Type in actors (Type done when finished): ");
                        while (true)
                        {
                            var item = Console.ReadLine();
                            if (item.ToLower() == "done") break;  
                            else actorsList.Add(item);
                        }
                    }
                    movieList.Add(new Movie(inputType, inputTitle, inputReleasedate, inputDescription, inputDirectorAuthor, actorsList));
                    Console.WriteLine(@$"--- Your Product ---");
                    for (var i = 0; i < movieList.Count; i++)
                    {
                    Console.WriteLine($"Movie number {i + 1}");
                    Console.WriteLine($"Type: {movieList[i].Type()}");
                    Console.WriteLine($"Title: {movieList[i].Title()}");
                    Console.WriteLine($"Release date: {movieList[i].Year()}");
                    Console.WriteLine($"Description: {movieList[i].Description()}");
                    Console.WriteLine($"Director/Author: {movieList[i].Creator()}");
                    if (movieList[i].Type() == "movie")
                    {
                        Console.WriteLine("Actors:");
                        foreach (var actor in movieList[i].Actors())Console.WriteLine($"{actor}");
                    }
                    Console.WriteLine(" ");
                    }
                }
        }
    }
}
