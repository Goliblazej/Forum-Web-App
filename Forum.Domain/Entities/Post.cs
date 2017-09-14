
namespace Forum.Domain.Entities
{
    public class Post
    {
        public int PostID { get; set; }
        public string PostBody { get; set; }
        public string PostDate { get; set; }
        public int PostTopicUserID { get; set; }
        public int PostAuthorUserID { get; set; }
    }
}
