namespace ShikiImporter;

/// <summary>
/// Модель аниме из Anixart
/// </summary>
public class AnixartAnime
{
    /// <summary>
    /// Индекс списка
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Название на русском языке
    /// </summary>
    public string RussianTitle { get; set; }
    
    /// <summary>
    /// Оригинальное название
    /// </summary>
    public string OriginalTitle { get; set; }
    
    /// <summary>
    /// В избранном
    /// </summary>
    public bool IsFavorite  => false;
    
    /// <summary>
    /// Статус просмотра
    /// </summary>
    public AnixartStatusEnum Status { get; set; }
    
    /// <summary>
    /// Оценка
    /// </summary>
    public string Rating { get; set; }
}