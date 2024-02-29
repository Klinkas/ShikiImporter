namespace ShikiImporter;

/// <summary>
/// Модель аниме из Shikimori
/// </summary>
public class ShikimoriAnime
{
    /// <summary>
    /// Навзание аниме
    /// </summary>
    public string target_title { get; set; }

    /// <summary>
    /// ID аниме
    /// </summary>
    public int? target_id { get; set; } = null;

    /// <summary>
    /// Тип импорта (по умолчанию аниме)
    /// </summary>
    public string target_type => "Anime";

    /// <summary>
    /// Оценка (по умолчанию 0)
    /// </summary>
    public int score { get; set; } = 0;

    /// <summary>
    /// Статус просмотра
    /// </summary>
    public string status { get; set; }
    
    /// <summary>
    /// Пересмотрено (по умолчанию 0)
    /// </summary>
    public int? rewatches { get; set; } = null;
    
    /// <summary>
    /// Эпизоды (по умолчанию 0)
    /// </summary>
    public int? episodes { get; set; } = null;
}