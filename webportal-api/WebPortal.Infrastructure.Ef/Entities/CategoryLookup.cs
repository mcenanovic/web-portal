using System;
using System.Collections.Generic;

namespace WebPortal.Infrastructure.Ef.Entities
{
    internal class CategoryLookup
    {
        public short CategoryLookupID { get; set; }

        public string Name { get; set; }

        public List<Article> Articles { get; set; }
    }
}
