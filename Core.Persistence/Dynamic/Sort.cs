namespace Core.Persistence.Dynamic;

// Sort sınıfı, sıralama kriterlerini tanımlar.
public class Sort
{
    // Sıralanacak alan adı.
    public string Field { get; set; }

    // Sıralama yönü ("asc" veya "desc").
    public string Dir { get; set; }

    public Sort()
    {
        Field = string.Empty; // Varsayılan olarak boş bir alan adı.
        Dir = string.Empty; // Varsayılan olarak boş bir sıralama yönü.
    }

    public Sort(string field, string dir)
    {
        Field = field;
        Dir = dir;
    }
}
