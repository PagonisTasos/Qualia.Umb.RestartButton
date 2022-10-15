using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.BackOffice.Controllers;

namespace Qualia.Umb.RestartButton
{
    public class StopApplicationController : UmbracoAuthorizedApiController
    {
        private readonly IHostApplicationLifetime _hostApplicationLifetime;
        private readonly ILogger<StopApplicationController> _logger;

        public StopApplicationController(IHostApplicationLifetime hostApplicationLifetime, ILogger<StopApplicationController> logger)
        {
            _hostApplicationLifetime = hostApplicationLifetime;
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Execute()
        {
            _logger.LogInformation($"Stop Application triggered from {nameof(StopApplicationController)}");
            _hostApplicationLifetime.StopApplication();
            return NoContent();
        }
    }
}
