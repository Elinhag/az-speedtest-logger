using System;
using SpeedTest;
using SpeedTest.Models;
using System.Globalization;
using System.Linq;
using SpeedTestLogger.Models;

namespace SpeedTestLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello SpeedTestLogger!");

          //  var location = new RegionInfo("nb-NO");
            var config = new LoggerConfiguration();

            var runner = new SpeedTestRunner(config.LoggerLocation);
            //runner.RunSpeedTest();

            var testData = runner.RunSpeedTest();
            var results = new TestResult
            {
                SessionId = new Guid(),
                User = config.UserId,
                Device = config.LoggerId,
                Timestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds(),
                Data = testData
            };



            // var client = new SpeedTestClient();
            // var settings = client.GetSettings();

            // Console.WriteLine("Finding best test servers");

            // var location = new RegionInfo("nb-NO");
            // var tenLocalServers = settings.Servers
            //     .Where(s => s.Country.Equals(location.EnglishName))
            //     .Take(10);
            
            // var serversOrdersByLatency = tenLocalServers.Select(s =>
            // {
            //     try
            //     {
            //         s.Latency = client.TestServerLatency(s);
            //     }
            //     catch (System.Exception ex)
            //     {
            //         //Console.WriteLine(ex);
            //         s.Latency = int.MaxValue;
            //     }
            //     return s;
            // })
            // .OrderBy(s => s.Latency);

            // var server = serversOrdersByLatency.First();

            // Console.WriteLine("Testing dowload speed");
            // var downloadSpeed = client.TestDownloadSpeed(server, settings.Download.ThreadsPerUrl);
            // Console.WriteLine("Download speed was: {0} Mbps", Math.Round(downloadSpeed / 1024, 2));

            // Console.WriteLine("Testing upload speed");
            // var uploadSpeed = client.TestUploadSpeed(server, settings.Upload.ThreadsPerUrl);
            // Console.WriteLine("Upload speed was: {0} Mbps", Math.Round(uploadSpeed /1024, 2));


        }
    }
}
