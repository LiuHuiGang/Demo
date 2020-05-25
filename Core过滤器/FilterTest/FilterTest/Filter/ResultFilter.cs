using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilterTest.Filter
{
    public class ResultFilter : IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext context)
        {
            Console.WriteLine("结果过滤器之后");
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            Console.WriteLine("结果过滤器之前");
        }
    }
}
