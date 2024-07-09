using System.Xml;

namespace benchmark_analysis;

public class FileManagement
{
    public string filePathMovies { get; set; }
    public string filePathRating { get; set; }

    public FileManagement()
    {
        filePathMovies = @"C:\www\Files\movies.csv";
        filePathRating = @"C:\www\Files\ratings.csv";
    }

    public List<string> Run1()
    {
        var genres = new List<string>();
        var lines = File.ReadAllLines(filePathMovies);

        foreach (var line in lines)
        {
            var separated = line.Split(",");

            if (!separated[2].Contains("genres"))
            {
                genres.Add(separated[2]);
            }
        }

        return genres;
    }

    public decimal RunRating()
    {
        var lines = File.ReadAllLines(filePathRating);
        int quantity = 0;
        decimal sum = 0;

        foreach (var line in lines)
        {
            var separated = line.Split(",");

            if (int.TryParse(separated[1], out int movieId) && movieId == 111)
            {
                sum += decimal.Parse(separated[2]);
                quantity++;
            }
        }

        return sum / quantity;
    }

    public decimal RunRating2()
    {
        int quantity = 0;
        decimal sum = 0;

        using (var stream = new StreamReader(filePathRating))
        {
            var line = string.Empty;

            while((line = stream.ReadLine()) != null)
            {
                var separated = line.Split(",");
                if (int.TryParse(separated[1], out int movieId) && movieId == 111)
                {
                    sum += decimal.Parse(separated[2]);
                    quantity++;
                }
            }
        }

        return sum / quantity;
    }
}