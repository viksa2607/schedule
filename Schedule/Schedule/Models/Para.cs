namespace Schedule.Models
{
    public class Para : Base
    {
        public Cabinet Cabinet { get; set; }
        public Group Group { get; set; }
        public Item Item { get; set; }
        public int Order { get; set; }
    }
}