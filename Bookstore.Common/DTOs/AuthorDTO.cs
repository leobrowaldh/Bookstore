namespace Bookstore.Common;

public class AuthorBaseDTO
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
}

public class AuthorMiniDTO : AuthorBaseDTO
{
    public int Id { get; set; } = 0;
}

public class AuthorDTO : AuthorMiniDTO
{
    public List<PublisherMiniDTO> Publishers { get; set; } = new();
    public List<BookMiniDTO> Books { get; set; } = new();
}