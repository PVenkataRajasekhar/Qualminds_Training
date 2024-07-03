using Microsoft.AspNetCore.Mvc.Filters;
using System.ComponentModel.DataAnnotations;

namespace WebApplication_Security.Filters
{
    public class LogTrackAttribute : ValidationAttribute,IActionFilter  // ActionFilter
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
