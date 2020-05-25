using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilterTest.Filter
{
    /// <summary>
    /// 方法前后执行过滤器
    /// </summary>
    public class ActionFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("action执行之后");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("action执行之前");
            //不往下执行方法
            //context.Result = new EmptyResult();
            //不往下执行方法，跳转
            //context.Result = new RedirectResult("/admin/login/");
        }
    }
}
