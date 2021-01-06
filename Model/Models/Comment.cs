using System;
using System.Collections.Generic;

namespace Model
{
    public class Comment
    {
        public int Id { get; set; }
        public string message { get; set; }
        public string Name { get; set; }
        public DateTime date { get; set; }
        public string emailAddress { get; set; }
        public int PostId { get; set; }
        public List<Replay> Replays { get; set; }
    }
}