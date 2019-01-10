using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XTest.SystematicCode.VarshamovaCode
{
    public class VarshamoveData
    {
        public Dictionary<string[], string[]> Form1CodecData { get; } = new Dictionary<string[], string[]>() {
            {
                new string[]{"6","6"},
                new string[]{"6","2","1","5"}
            },

        };

        public Dictionary<string[], string[]> Form1DeCodecData { get; } = new Dictionary<string[], string[]>()
        {
            {
            new string[]{"1","3"}, new string[]{
                "1","0","0","0","0","0","0","0","1","1",
                "0","1","0","0","0","0","0","1","0","1",
                "0","0","1","0","0","0","1","0","0","1",
                "0","0","0","1","0","0","0","1","1","0",
                "0","0","0","0","1","0","1","0","1","0",
                "0","0","0","0","0","1","1","1","0","0"
                }
            },

        };
    }
}
