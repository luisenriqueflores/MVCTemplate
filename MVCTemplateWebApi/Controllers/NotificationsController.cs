using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace MVCTemplateWebApi.Controllers
{
    public class NotificationsController : ApiController
    {
        public List<string> Get()
        {
            return new List<string>() { "Notification 1", "Notification 2" };
        }
    }
}
