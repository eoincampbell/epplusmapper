using System.Linq;
using EPPlusMapper.Core;
using EPPlusMapper.Tests.Models;

namespace EPPlusMapper.Tests.Mappers
{
    public class CollectionItemMapper : Mapper<CollectionItem>
    {
        public CollectionItemMapper() 
        {
            AddMember("Id", x => x.Id);
            AddMember("Parent Name", x => x.Parent.Name);
            AddMember("Child Names", x => string.Join(",", x.Children.Select(y => y.Name)));
        }
    }
}