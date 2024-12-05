namespace Core.Persistence.Dynamic;

// DynamicQuery sınıfı dinamik sorgulamalar için kullanılır. 
// Sıralama ve filtreleme bilgilerini taşır.
public class DynamicQuery
{
    // Sıralama kriterlerini içeren koleksiyon (isteğe bağlı).
    public IEnumerable<Sort>? Sort { get; set; }

    // Filtreleme kriterlerini temsil eden nesne (isteğe bağlı).
    public Filter? Filter { get; set; }

    // Parametresiz yapıcı metot.
    public DynamicQuery()
    {
    }

    // Parametre alan yapıcı metot.
    // sort: sıralama kriterlerini içeren koleksiyon.
    // filter: filtreleme kriterlerini temsil eden nesne.
    public DynamicQuery(IEnumerable<Sort>? sort, Filter? filter)
    {
        Sort = sort;
        Filter = filter;
    }
}
