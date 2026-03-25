using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberAwernessBot
{
    public class CyberBot
    {
        public void Start()
        {
            DisplayLogo();
            Console.WriteLine("Welcome to the Cyber Awarness Bot!");
        }
        public void DisplayLogo()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@"
  _____            ____  
 / ____|    /\    |  _ \ 
| |        /  \   | |_) |
| |       / /\ \  |  _ < 
| |____  / ____ \ | |_) |
 \_____|/_/    \_\|____/");
            Console.ResetColor();
        }
    }
}
