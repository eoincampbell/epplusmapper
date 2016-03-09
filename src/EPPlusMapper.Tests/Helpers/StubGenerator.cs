using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPPlusMapper.Tests.Models;

namespace EPPlusMapper.Tests.Helpers
{
    public static class StubGenerator
    {
        public static Simple CreateSimple()
        {
            return new Simple()
            {
                Id = 1,
                Name = "Eoin",
                DateOfBirth = new DateTime(1982, 1, 10)
            };
        }

        public static Simple CreateSimple2()
        {
            return new Simple()
            {
                Id = 2,
                Name = "John",
                DateOfBirth = new DateTime(1982, 1, 2)
            };
        }

        public static Simple CreateSimple3()
        {
            return new Simple()
            {
                Id = 3,
                Name = "Mary",
                DateOfBirth = new DateTime(1982, 1, 3)
            };
        }

        public static Nested CreateNested()
        {
            return new Nested()
            {
                Id = 1,
                First = CreateSimple(),
                Second = CreateSimple2()
            };
        }

        public static CollectionItem CreateCollectionItem()
        {
            return new CollectionItem()
            {
                Id = 1,
                Parent = CreateSimple(),
                Children = new List<Simple>()
                {
                    CreateSimple2(),
                    CreateSimple3()
                }
            };
        }
    }
}
