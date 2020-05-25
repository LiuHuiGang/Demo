using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilterTest.Filter
{
    public class ResourceFilter : IResourceFilter
    {
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            Console.WriteLine("资源过滤器之后");
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            Console.WriteLine("资源过滤器之前");
        }
    }
}
