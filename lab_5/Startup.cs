﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab_5.Startup))]
namespace lab_5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
