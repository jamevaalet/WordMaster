﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WordMaster.Startup))]
namespace WordMaster
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
