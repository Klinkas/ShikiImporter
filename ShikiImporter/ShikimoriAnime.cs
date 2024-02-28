namespace ShikiImporter;

/// <summary>
/// Модель аниме из Shikimori
/// </summary>
public class ShikimoriAnime
{
    /// <summary>
    /// Навзание аниме
    /// </summary>
    public string TargetTitle { get; set; }
    
    /// <summary>
    /// ID аниме
    /// </summary>
    public int TargetId { get; set; }

    /// <summary>
    /// Тип импорта (по умолчанию аниме)
    /// </summary>
    public string TargetType => "Anime";

    /// <summary>
    /// Оценка (по умолчанию 0)
    /// </summary>
    public int Score { get; set; } = 0;

    /// <summary>
    /// Пересмотрено (по умолчанию 0)
    /// </summary>
    public int ReWatches { get; set; } = 0;
    
    /// <summary>
    /// Эпизоды (по умолчанию 0)
    /// </summary>
    public int Episodes { get; set; } = 0;
}