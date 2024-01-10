using System;

class Genre
{
    public int GenreId { get; set; }
    public string Title { get; set; }

    public override string ToString()
    { 
        return $"Genre ID: {GenreId}\nTitle: {Title}\n";
    }
}
