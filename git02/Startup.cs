﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(git02.Startup))]
namespace git02
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
