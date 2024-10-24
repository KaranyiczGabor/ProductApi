namespace BlogAPI.Models
{
    public class DTO
    {
        public record CreateUserDTO(string Title, string Description, DateTime CreatedTime, DateTime LastUpdated);
        public record UpdateUserDTO(string Title, string Description, DateTime CreatedTime, DateTime LastUpdated);

    }
}
