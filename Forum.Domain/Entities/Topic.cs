
namespace Forum.Domain.Entities
{
    public class Topic
    {
        public int TopicID { get; set; }
        public string TopicName { get; set; }
        public string TopicDate { get; set; }
        public int TopicAuthorUserID { get; set; }
        public string TopicCategory { get; set; }
    }
}
