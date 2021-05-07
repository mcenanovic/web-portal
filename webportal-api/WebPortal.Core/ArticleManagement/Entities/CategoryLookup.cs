using System.Collections.Generic;

namespace WebPortal.Core.ArticleManagement.Entities
{
    public class CategoryLookup
    {
        public short CategoryLookupID { get; set; }

        public string Name { get; set; }

        public List<Article> Articles { get; set; }
    }
}
