using System;

namespace Model
{
    public class Replay
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime date { get; set; }
        public string message { get; set; }
        public int CommentId { get; set; }
        public int PostId { get; set; }
    }
}