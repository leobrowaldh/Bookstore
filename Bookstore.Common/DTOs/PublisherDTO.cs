namespace Bookstore.Common;

public class PublisherBaseDTO
{
    public string Name { get; set; } = string.Empty;
}

public class PublisherMiniDTO : PublisherBaseDTO
{
    public int Id { get; set; } = 0;
}

public class PublisherDTO : PublisherMiniDTO
{
    public List<AuthorMiniDTO> Authors { get; set; } = new();
    public List<BookMiniDTO> Books { get; set; } = new();
}