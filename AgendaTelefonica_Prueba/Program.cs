using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace AgendaTelefonica_Prueba
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuiltWebHost(args).Run();
        }

        public static IWebHost BuiltWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>().Build();
    }
}
