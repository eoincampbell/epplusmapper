using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPPlusMapper.Tests.Models
{
    public class CollectionItem
    {
        public CollectionItem()
        {
            Children = new List<Simple>();
        }

        public int Id { get; set; }

        public Simple Parent { get; set; }

        public IList<Simple> Children{ get; set; } 
    }
}
