namespace ShikiImporter;

public static class Methods
{
    public static List<AnixartAnime> ParseAnimeList(string fileName)
    {
        var animeList = new List<AnixartAnime>();

        using var reader = new StreamReader(fileName);
        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine();
            var values = line.Split("/");

            var anime = new AnixartAnime
            {
                Id = int.Parse(values[0].Trim()),
                OriginalTitle = values[2].Trim()
            };
                
            animeList.Add(anime);
        }

        return animeList;
    }
}