using Serilog;
using Serilog.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerilogConsoleSink
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File(@"C:\Users\JaydeepGodase\Desktop\SinkLog.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
            Log.Information("Information");

            try
            {
                Log.Information("Information");
                Log.Error("This is our Error log");
                Log.Verbose("Information is our  Verbose log");
                Log.Warning("This is our Warning log");
                Log.Debug("This is our Debug log");
                Log.Fatal("This is our Fatal log ");

                var a = 0;
                Log.Information(Convert.ToString(a));

                var b = 1 / a;
                Log.Information(Convert.ToString(b));
            }
            catch (Exception ex)
            {
                Log.Error(ex, "This is our Error log");
            }
            finally
            {
                Log.Information("Log Closing Things");
            }
        }
    }
}
