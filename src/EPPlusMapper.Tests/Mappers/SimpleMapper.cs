using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPPlusMapper.Core;
using EPPlusMapper.Tests.Models;

namespace EPPlusMapper.Tests.Mappers
{
    public class SimpleMapper : Mapper<Simple>
    {
        public SimpleMapper() : base()
        {
            AddMember("Custom Id", x => x.Id);
            AddMember("Custom Name", x => x.Name);
        }
    }
}
