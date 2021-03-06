﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XTest.ElseCodeAndLabs.Shenona_FanoCode
{
    class ShenonaFanoData
    {
        public Dictionary<string[], string[]> CoDecData { get; } = new Dictionary<string[], string[]>()
        {
                {
                    new string [] { "0.26" , "0.20" , "0.17" , "0.11" , "0.07" , "0.07" , "0.06" , "0.03", "0.02", "0.01" },
                    new string [] { "00 " , "01" , "100" , "101", "1100", "1101" , "1110 ", "11110" , "111110 ", "111111"}
                },
                {
                    new string [] { "0.22" , "0.22" , "0.21", " 0.21" , "0.06" , "0.06" , "0.02" },
                    new string [] { "00" , "01", "10" , "110" , "1110" , "11110" , "11111" }
                },
                {
                    new string [] { "0.25" , "0.24", "0.13" , "0.13" , "0.13"  , "0.08" , "0.03" , "0.01"},
                    new string [] { "00" , "01", "100" , "101" , "110" , "1110" , "11110" , "11111"}
                },
                {
                    new string [] { "0.44" , "0.22", "0.14" , "0.13" , "0.04" , "0.03"  },
                    new string [] { "0" , "10", "110" , "1110" , "11110" , "11111"  }
                },
                {
                    new string [] {"0.23", "0.23" , "0.18" , "0.10" , "0.08" , "0.08", "0.04" , "0.04" , "0.01" , "0.01"},
                    new string [] {"00", "01" , "100" , "1100" , "1100" , "1101", "1110" , "11110" , "111110" , "111111"}
                },
                {
                    new string [] {"0.39", "0.27" , "0.18" , "0.09" , "0.05" , "0.02"},
                    new string [] {"0", "10" , "110" , "1110" , "11110" , "11111"}
                },
                {
                    new string [] {"0.30", "0.25" , "0.22" , "0.14" , "0.05" , "0.03", "0.01"},
                    new string [] {"00", "01" , "10" , "110" , "1110" , "11110", "111111"}
                }, 
                {
                    new string [] {"0.24", "0.23" , "0.18" , "0.14" , "0.08" , "0.08", "0.03" , "0.02"},
                    new string [] {"00", "01" , "100" , "101" , "110" , "1110", "11110" , "11111"}
                }, 
                {
                    new string [] {"0.27", "0.25" , "0.25" , "0.19" , "0.03" , "0.01"},
                    new string [] {"00", "01" , "10" , "110" , "1110" , "1111"}
                }, 
                {
                    new string [] {"0.28", "0.26" , "0.07" , "0.04" , "0.03" , "0.02", "0.02" },
                    new string [] {"00", "01" , "10" , "110" , "1110" , "11110", "111110" ,"111111"}
                }, 
                {
                    new string [] {"0.20", "0.18" , "0.17" , "0.15" , "0.11" , "0.10", "0.04" , "0.03" , "0.01" , "0.01"},
                    new string [] {"00", "010" , "011" , "100" , "101" , "110", "1110", "11110" , "111110" , "111111"}
                }, 
                {
                    new string [] {"0.31" ,"0.29" , "0.20" , "0.16" , "0.03" , "0.01" },
                    new string [] { "00" , "01" , "10" , "110" , "1110" , "1111"  }
                }, 
                {
                    new string [] { "0.22" , "0.19" , "0.17" , "0.16" , "0.11" , "0.11" ,"0.03" , "0.01" },
                    new string [] { "00" , "010" , "011" , "10" , "110" , "1110" ,"11110" , "11111" }
                }, 
                {
                    new string [] { "0.28" , "0.28" , "0.18" , "0.17" , "0.08" , "0.01"  },
                    new string [] { "00" , "01" , "10" , "110" , "1110" , "1111" }
                }, 
                {
                    new string [] { "0.19" , "0.18" , "0.14" , "0.13" , "0.13" , "0.10" ,"0.05" , "0.04" , "0.03" , "0.01"},
                    new string [] { "00" , "010" , "011" , "100" , "101" , "110" ,"1110" , "11110", "111110" , "111111" }
                }, 
                {
                    new string [] { "0.21" , "0.19" , "0.16" , "0.15" , "0.15" , "0.11" ,"0.03"  },
                    new string [] { "00" , "010" , "011" , "10" , "110" , "1110" ,"1111" }
                }, 
                {
                    new string [] { "0.24" , "0.23" , "0.22" , "0.17" , "0.08" , "0.03" ,"0.03" },
                    new string [] { "00" , "01" , "10" , "110" , "1110" , "11110" ,"11111" }
                }, 
                {
                    new string [] { "0.20" , "0.17" , "0.17" , "0.15" , "0.13" , "0.10" ,"0.05" , "0.02"  , "0.01"},
                    new string [] { "00" , "010" , "011" , "100" , "101" , "110" ,"1110" , "11110"  , "11111" }
                }, 
                {
                    new string [] { "0.17" , "0.17" , "0.16" , "0.15" , "0.14" , "0.10" ,"0.05" , "0.04"  , "0.02"},
                    new string [] { "00" , "010" , "011" , "100" , "101" , "110" ,"1110" , "11110" , "11111"}
                }, 
                {
                    new string [] { "0.24" , "0.24" , "0.16" , "0.05" , "0.04" , "0.04" ,"0.03" , "0.03" , "0.03" , "0.01" },
                    new string [] { "00" , "01" , "100" , "101" , "1100" , "1101" ,"1110" , "11110" , "111110" , "111111" }
                }, 
                //{
                //    new string [] { "0.22" , "0.22" , "0.20" , "0.14" , "0.08" , "0.06" ,"0.02" , "0.02", "" ,"" },
                //    new string [] { "00" , "01" , "100" , "101" , "110" , "1110" ,"111100" , "111101" , "111110" , "111111" }
                //}, 
                {
                    new string [] { "0.19" , "0.17" , "0.17" , "0.13" , "0.11" , "0.08" ,"0.06" , "0.06" , "0.3" },
                    new string [] { "00" , "010" , "011" , "100" , "101" , "1100" ,"1101" , "1110"  , "1111" }
                }, 
                {
                    new string [] { "0.33" , "0.27" , "0.23" , "0.15" , "0.01" , "0.1" },
                    new string [] { "00" , "01" , "10" , "110" , "1110" , "1111"}
                }, 
                {
                    new string [] { "0.33" , "0.29" , "0.19" , "0.14" , "0.02" , "0.02" ,"0.01" },
                    new string [] { "00" , "01" , "10" , "110" , "1110" , "11110" ,"11111"  }
                }, 
                {
                    new string [] { "0.17" , "0.16" , "0.15" , "0.13" , "0.12" , "0.12" ,"0.07" , "0.05" , "0.03" },
                    new string [] { "00" , "010" , "011" , "100" , "101" , "110" ,"1110" , "11110" , "11111" }}

        };
    }
}
