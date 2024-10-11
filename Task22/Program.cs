using Task22.Models;
using Task22.Packages;

Console.WriteLine("Select operation: I - Insert, D - Delete, U - Update, G - Get");
var operation = Console.ReadLine().ToUpper();
while (operation != "I" && operation != "D" && operation != "U" && operation != "G")
{
    Console.WriteLine("Select correct operation: I - Insert, D - Delete, U - Update, G - Get");
    operation = Console.ReadLine().ToUpper();
}

PKG_MOVIES package = new PKG_MOVIES();

switch (operation)
{
    case "I":
        {
            Movie movie = new Movie();
            Console.Write("Enter movie name: ");
            movie.Name = Console.ReadLine();
            Console.Write("Enter release date (yyyy-mm-dd): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime releaseDate))
            {
                movie.ReleaseDate = releaseDate; 
                package.save_movie(movie);
            }
            else
            {
                Console.WriteLine("Invalid date format. Please enter a date in the format yyyy-mm-dd.");
            }
            break;
         
        }
    case "G":
        {
            Console.WriteLine("Enter movie ID: ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int movieId))
                {
                    var movie = package.GetMovieById(movieId);
                    if (movie != null)
                    {
                        Console.WriteLine($"{movie.Name} ({movie.ReleaseDate.Year})");
                    }
                    else Console.WriteLine("No movie with such ID found");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid ID format. Please enter a numeric ID.");
                }
            }
            break;
        }
    case "U":
        {
            Console.WriteLine("Enter movie ID: ");
            bool haveNotEnteredIdWithCorrectFormat = true;
            while (haveNotEnteredIdWithCorrectFormat)
            {
                if (int.TryParse(Console.ReadLine(), out int movieId))
                {
                    haveNotEnteredIdWithCorrectFormat = false;
                    Movie movie = new Movie();
                    Console.Write("Enter updated movie name: ");
                    movie.Name = Console.ReadLine();
                    bool haveNotEnteredDateWithCorrectFormat = true;
                    while (haveNotEnteredDateWithCorrectFormat)
                    {
                        Console.Write("Enter updated release date (yyyy-mm-dd): ");
                        if (DateTime.TryParse(Console.ReadLine(), out DateTime releaseDate))
                        {
                            haveNotEnteredDateWithCorrectFormat = false;
                            movie.ReleaseDate = releaseDate;
                            if(!package.update_movie(movieId, movie))
                                Console.WriteLine("No movie with such id found");
                        }
                        else
                        {
                            Console.WriteLine("Invalid date format. Please enter a date in the format yyyy-mm-dd.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid ID format. Please enter a numeric ID.");
                }
            }
            break;
        }
    case "D": {
            Console.WriteLine("Enter movie ID: ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int movieId))
                {
                    if (package.DeleteMovie(movieId))
                    {
                        Console.WriteLine("Movie was deleted");
                    }
                    else Console.WriteLine("No movie with such ID found");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid ID format. Please enter a numeric ID.");
                }
            }
            break;
        }
}