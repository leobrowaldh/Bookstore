namespace Bookstore.Common;

public class PublisherAuthorDTO
{
    public int AuthorId { get; set; } = 0;
    public int PublisherId { get; set; } = 0;
    public PublisherAuthorDTO(int authorId, int publisherId)
    {
        AuthorId = authorId;
        PublisherId = publisherId;
    }
}
