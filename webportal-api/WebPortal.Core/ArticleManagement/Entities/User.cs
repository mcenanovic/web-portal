using System.Collections.Generic;

namespace WebPortal.Core.ArticleManagement.Entities
{
    public class User
    {
        public int UserID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public Role Role { get; set; }

        public List<Article> Articles { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
