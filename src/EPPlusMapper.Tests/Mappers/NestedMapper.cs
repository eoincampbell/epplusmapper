using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EPPlusMapper.Core;
using EPPlusMapper.Tests.Models;

namespace EPPlusMapper.Tests.Mappers
{
    public class NestedMapper : Mapper<Nested>
    {
        public NestedMapper()
        {
            AddMember("Custom Id", x => x.Id);
            AddMember("Custom First Name", x => x.First.Name);
            AddMember("Custom Second Name", x => x.Second.Name);
        }
    }
}
