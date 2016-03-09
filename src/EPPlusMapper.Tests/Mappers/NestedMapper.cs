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
            AddMember("Nested Id", x => x.Id);
            AddMember("Oldest Name", x =>
            
                x.First.DateOfBirth > x.Second.DateOfBirth
                    ? x.First.Name
                    : x.Second.Name
            );
            //AddMember("Oldest DOB", x => x.First.DateOfBirth);
            //AddMember("Second Name", x => x.Second.Name);
            //AddMember("Second DOB", x => x.Second.DateOfBirth);
        }
    }
}
