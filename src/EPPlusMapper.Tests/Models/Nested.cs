using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPPlusMapper.Tests.Models
{
    public class Nested
    {
        public int Id { get; set; }

        public Simple First { get; set; }

        public Simple Second { get; set; }
    }
}
