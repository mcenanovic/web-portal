using System;

namespace WebPortal.Core.ArticleManagement.Entities
{
    public class Comment
    {
        public long CommentID { get; set; }

        public string Description { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public int UpVote { get; set; }

        public int DownVote { get; set; }

        public Comment ReplyComment { get; set; }

        public Article Article { get; set; }

        public User User { get; set; }
    }
}
