using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterTryParse
{

    class Program
    {

        static void Main(string[] args)
        {
            Debug.Assert(TryParseAsInt("89898") == 89898, "Failed to parse int");
            Debug.Assert(TryParseAsInt("I am not a number") == null, "String is not an int");
            Debug.Assert(TryParseAsInt("6.5") == null, "Doubles aren't ints");
        }
        public static int? TryParseAsInt(string val)
        {
            int result;
            if (int.TryParse(val, out result))
            {
                return result;
            }
            return null;
            }
        }
    }

