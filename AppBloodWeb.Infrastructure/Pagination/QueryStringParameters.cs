namespace AppBloodWeb.Infrastructure.Pagination;

// 1.
public class QueryStringParameters
{
    const int maxPageSize = 50;
    public int pageNumber { get; set; } = 1;

    private int _pageSize = maxPageSize;
    public int pageSize

    {
        get { return _pageSize; }



        set { _pageSize = (value > maxPageSize) ? maxPageSize : value; }

    }
}
