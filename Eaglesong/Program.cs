using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eaglesong
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                throw new ArgumentException("usage: <path-to-replay.dem>");
            }
            LinkedList<object> messages = DemParser.Read(args[0]);
            Console.WriteLine("{0} messages parsed", messages.Count);

            dota2.CDemoFileInfo f = (dota2.CDemoFileInfo)messages.Last.Value;
            Console.WriteLine("Parsed match id: {0}", f.game_info.dota.match_id);
        }
    }
}
