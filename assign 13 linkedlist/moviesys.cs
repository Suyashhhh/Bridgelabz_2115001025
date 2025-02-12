
//doubly ll
using System;
class MovieNode
{
    public string Title;
    public string Director;
    public int Year;
    public double Rating;
    public MovieNode Prev;
    public MovieNode Next;

    public MovieNode(string title, string director, int year, double rating)
    {
        Title = title;
        Director = director;
        Year = year;
        Rating = rating;
        Prev = null;
        Next = null;
    }
}

class MovieList
{
    private MovieNode head;
    private MovieNode tail;

    public void AddMovieAtBeginning(string title, string director, int year, double rating)
    {
        MovieNode newMovie = new MovieNode(title, director, year, rating);
        if (head == null)
        {
            head = newMovie;
            tail = newMovie;
        }
        else
        {
            newMovie.Next = head;
            head.Prev = newMovie;
            head = newMovie;
        }
    }
    public void AddMovieAtEnd(string title, string director, int year, double rating)
    {
        MovieNode newMovie = new MovieNode(title, director, year, rating);
        if (tail == null)
        {
            head = newMovie;
            tail = newMovie;
        }
        else
        {
            tail.Next = newMovie;//tail is curr movie and to link it to newmovie we write tail.next = newmovie
            newMovie.Prev = tail;
            tail = newMovie;
        }
    }
    public void RemoveMovie(string title)
    {
        if (head == null) return;
        if (head.Title == title)
        {
            head = head.Next;
            if (head != null) head.Prev = null;
            else tail = null;
            return;
        }
        MovieNode current = head;
        while (current != null && current.Title != title)
        {
            current = current.Next;
        }
        if (current == null) return;
        if (current.Next != null) current.Next.Prev = current.Prev;
        if (current.Prev != null) current.Prev.Next = current.Next;
        if (current == tail) tail = current.Prev;
    }
    public void SearchMovie(string query)
    {
        MovieNode current = head;
        while (current != null)
        {
            if (current.Director == query || Math.Round(current.Rating, 2) == Math.Round(double.Parse(query), 2))
            {
                Console.WriteLine(current.Title + "\t" + current.Director + "\t" + current.Year + "\t" + Math.Round(current.Rating, 2));
                return;
            }
            current = current.Next;
        }
        Console.WriteLine("movie not found");
    }
    public void UpdateMovieRating(string title, double newRating)
    {
        MovieNode current = head;
        while (current != null)
        {
            if (current.Title == title)
            {
                current.Rating = newRating;
                return;
            }
            current = current.Next;
        }
    }
    public void DisplayMovies()
    {
        MovieNode current = head;
        while (current != null)
        {
            Console.WriteLine(current.Title + "\t" + current.Director + "\t" + current.Year + "\t" + Math.Round(current.Rating, 2));
            current = current.Next;
        }
    }

    public void DisplayMoviesReverse()
    {
        MovieNode current = tail;
        while (current != null)
        {
            Console.WriteLine(current.Title + "\t" + current.Director + "\t" + current.Year + "\t" + Math.Round(current.Rating, 2));
            current = current.Prev;
        }
    }
}
class Program
{
    static void Main()
    {
        MovieList movies = new MovieList();
        movies.AddMovieAtEnd("Nosferatu", "F.W. Murnau", 1922, 8.0);
        movies.AddMovieAtEnd("Hereditary", "Ari Aster", 2018, 7.3);

        Console.WriteLine("movies in forward order:");
        movies.DisplayMovies();

        Console.WriteLine("movies in reverse order:");
        movies.DisplayMoviesReverse();

        movies.UpdateMovieRating("Hereditary", 7.5);
        Console.WriteLine("after updating rating:");
        movies.DisplayMovies();

        movies.RemoveMovie("Nosferatu");
        Console.WriteLine("after removing movie:");
        movies.DisplayMovies();

        movies.SearchMovie("Ari Aster");
        movies.SearchMovie("7.5");
    }
}

