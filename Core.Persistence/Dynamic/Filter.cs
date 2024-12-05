namespace Core.Persistence.Dynamic;

// Filter sınıfı, bir sorgu filtresini tanımlar.
public class Filter
{
    // Filtrelenecek alan adı.
    public string Field { get; set; }

    // Filtreleme için kullanılacak değer (isteğe bağlı).
    public string? Value { get; set; }

    // Operatör (ör. "eq", "contains", "lt", vb.).
    public string Operator { get; set; }

    // Mantıksal operatör (ör. "and", "or") (isteğe bağlı).
    public string? Logic { get; set; }

    // İç içe filtreler (isteğe bağlı).
    public IEnumerable<Filter>? Filters { get; set; }

    public Filter()
    {
        Field = string.Empty; // Varsayılan olarak boş bir alan adı.
        Operator = string.Empty; // Varsayılan olarak boş bir operatör.
    }

    public Filter(string field, string @operator)
    {
        Field = field;
        Operator = @operator;
    }
}
