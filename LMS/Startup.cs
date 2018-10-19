﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(LMS.Startup))]

namespace LMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
			app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
			ConfigureAuth(app);
        }
    }
}
