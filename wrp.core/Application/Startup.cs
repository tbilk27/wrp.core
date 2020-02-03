using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using wrp.core.Database;

namespace wrp.core.Application
{
    public class Startup : IStartup
    {
        private readonly WrpContext _db;
        private readonly IConfigurationRoot _configuration;

        public Startup(
            WrpContext context,
            IConfigurationRoot configuration)
        {
            _db = context;
            _configuration = configuration;
        }

        public void Run()
        {
            Console.WriteLine("Running");
        }
    }
}
