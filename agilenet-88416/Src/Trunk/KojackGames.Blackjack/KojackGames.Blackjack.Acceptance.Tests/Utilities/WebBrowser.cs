using System.IO;
using Cassini;
using TechTalk.SpecFlow;
using WatiN.Core;

namespace KojackGames.Blackjack.Acceptance.Tests.Utilities
{
    public class WebBrowser
    {        
        private const string RelativePath = @"KojackGames.Blackjack.UI.Web";
        public const int Port = 14387;
        protected static Server WebServer { get; private set; }
        
        public static Browser Current
        {
            get
            {
                if (!ScenarioContext.Current.ContainsKey("browser"))
                    ScenarioContext.Current["browser"] = new IE();
                return (Browser) ScenarioContext.Current["browser"];
            }

        }

        public static string GetPhysicalPath()
        {
            var dir = Directory.GetCurrentDirectory();

            var index = dir.LastIndexOf("KojackGames.Blackjack.Acceptance.Tests");

            dir = dir.Remove(index);

            return Path.Combine(dir, RelativePath);
        }

        public static void InitializeBrowser()
        {
            WebServer = new Server(Port, "/", GetPhysicalPath());
            WebServer.Start();
        }

        public static void ShutdownBrowser()
        {
            WebServer.Stop();
        }

        public static void Stop()
        {
            if (ScenarioContext.Current.ContainsKey("browser"))
                Current.Close();   
        }
        
    }
}
