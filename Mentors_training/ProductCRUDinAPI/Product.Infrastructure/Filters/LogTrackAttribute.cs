using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Filters;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Infrastructure.Filters
{
    public class LogTrackAttribute : ValidationAttribute, IActionFilter  // ActionFilter
    {
        private readonly ILogger<LogTrackAttribute> _logger;

        public LogTrackAttribute(ILogger<LogTrackAttribute> logger)
        {
            _logger = logger;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogInformation("Action {ActionName} executing at {DateTime}",
                context.ActionDescriptor.DisplayName, DateTime.UtcNow);
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            _logger.LogInformation("Action {ActionName} executed at {DateTime}",
                context.ActionDescriptor.DisplayName, DateTime.UtcNow);
        }
    }
}
