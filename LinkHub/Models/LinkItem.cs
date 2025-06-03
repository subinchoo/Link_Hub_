// LinkItem.cs
// Represents a bookmark or link item in the application
namespace LinkHubApp.Models
{
    public class LinkItem
    {
        // The title or name of the bookmark
        public string Title { get; set; }
        // The URL of the bookmark
        public string Url { get; set; }
        // The category this bookmark belongs to
        public string Category { get; set; }
        // The user ID of the owner of this bookmark
        public string UserId { get; set; }
    }
}
