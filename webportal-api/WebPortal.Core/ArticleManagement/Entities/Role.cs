using System.Collections.Generic;

namespace WebPortal.Core.ArticleManagement.Entities
{
    public class Role
    {
        public short RoleID { get; set; }

        public string Name { get; set; }

        public List<User> Users { get; set; }
    }
}
