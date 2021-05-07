using System.Collections.Generic;

namespace WebPortal.Infrastructure.Ef.Entities
{
    internal class Role
    {
        public short RoleID { get; set; }

        public string Name { get; set; }

        public List<User> Users { get; set; }
    }
}
