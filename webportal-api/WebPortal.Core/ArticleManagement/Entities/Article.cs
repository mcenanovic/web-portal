using System;
using System.Collections.Generic;

namespace WebPortal.Core.ArticleManagement.Entities
{
    public class Article
    {
        public int ArticleID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Header { get; set; }

        public string ImageURL { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public DateTime UpdatedDateTime { get; set; }

        public int SharedCount { get; set; }

        public User User { get; set; }

        public CategoryLookup CategoryLookup { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
