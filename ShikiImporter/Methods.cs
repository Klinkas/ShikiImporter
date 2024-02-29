using System.Text.Json;

namespace ShikiImporter;

public static class Methods
{
    public static void OutJson(string inputPath, string outputPath)
    {
        var anixartAnimeList = ParseAnimeList(inputPath);
        var shikimoriAnimeList = new List<ShikimoriAnime>();

        foreach (var anixartAnime in anixartAnimeList)
        {
            var shikimoriAnime = new ShikimoriAnime
            {
                target_title = anixartAnime.OriginalTitle,
                status = anixartAnime.Status.ShikimoriStatusConvert(),
                score = anixartAnime.Rating.ShikimoriScoreConvert(),
            };
            
            shikimoriAnimeList.Add(shikimoriAnime);
        }

        var outputJson = JsonSerializer.Serialize(shikimoriAnimeList);
        
        File.WriteAllText(outputPath, outputJson);
    }

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
                OriginalTitle = values[2].Replace("\"","").Trim(),
                Status = values[5].Trim().AnixartStatusConvert(),
                Rating = values[6].Trim(),
            };

            animeList.Add(anime);
        }

        return animeList;
    }

    private static string ShikimoriStatusConvert(this AnixartStatusEnum anixartStatus)
    {
        return anixartStatus switch
        {
            AnixartStatusEnum.NotWatching => "",
            AnixartStatusEnum.Watching => "watching",
            AnixartStatusEnum.Planned => "planned",
            AnixartStatusEnum.Watched => "completed",
            AnixartStatusEnum.Abandoned => "dropped",
            _ => ""
        };
    }

    private static AnixartStatusEnum AnixartStatusConvert(this string statusString)
    {
        return statusString switch
        {
            "Не смотрю" => AnixartStatusEnum.NotWatching,
            "Смотрю" => AnixartStatusEnum.Watching,
            "В планах" => AnixartStatusEnum.Planned,
            "Просмотрено" => AnixartStatusEnum.Watched,
            "Брошено" => AnixartStatusEnum.Abandoned,
            _ => AnixartStatusEnum.NotWatching
        };
    }

    private static int ShikimoriScoreConvert(this string rating)
    {
        return rating switch
        {
            "Не оценено" => 0,
            "1 из 5" => 1,
            "2 из 5" => 2,
            "3 из 5" => 3,
            "4 из 5" => 4,
            "5 из 5" => 5,
            _ => 0,
        };
    }
}