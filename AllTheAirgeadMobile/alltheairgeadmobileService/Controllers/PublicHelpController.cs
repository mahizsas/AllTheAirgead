﻿using System.Web.Http;
using Microsoft.WindowsAzure.Mobile.Service.Security;
using Microsoft.WindowsAzure.Mobile.Service.Controllers;

namespace alltheairgeadmobileService.Controllers
{
    // Allow the help site to be shown in the browser
    [AuthorizeLevel(AuthorizationLevel.Anonymous)]
    public class PublicHelpController : HelpController
    {
        [HttpGet]
        [Route("help")]
        public new IHttpActionResult Index()
        {
            return base.Index();
        }

        [HttpGet]
        [Route("help/api/{apiId}")]
        public new IHttpActionResult Api(string apiId)
        {
            return base.Api(apiId);
        }
    }
}
