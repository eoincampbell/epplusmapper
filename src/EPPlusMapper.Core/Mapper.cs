using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EPPlusMapper.Core
{
    public interface IMapper
    {
        
    }

    public abstract class Mapper<T> where T : new()
    {
        private readonly Dictionary<
            string, 
            Expression<Func<T, object>>> mappingInfo;

        
        protected Mapper()
        {
            mappingInfo = new Dictionary<string, Expression<Func<T, object>>>();
        }

        protected void AddMember(string header, Expression<Func<T, object>> memberExpression)
        {
            //Debug.WriteLine($"{memberExpression.Name} - {memberExpression.Body}");
            mappingInfo.Add(header, memberExpression);
        }

        public List<dynamic> GenerateOutput(List<T> inputs)
        {
            var results = new List<dynamic>();

            foreach (var input in inputs)
            {
                dynamic obj = new ExpandoObject();

                foreach (var inf in mappingInfo)
                {
                    var compiled = inf.Value.Compile();
                    ((IDictionary<string, object>)obj).Add(inf.Key, compiled(input));
                }

                results.Add(obj);
            }

            return results;
        } 
    }
}
