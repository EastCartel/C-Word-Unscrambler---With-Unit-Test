using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unscrambler.Data
{
    public struct MatchedWord
    {
        public string ScrambledWord { get; set; }
        public string Word { get; set; }
    }
}
//change class to struct -- struct are value types
