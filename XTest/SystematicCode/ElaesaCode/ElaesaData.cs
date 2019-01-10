﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XTest.SystematicCode.ElaesaCode
{
    class ElaesaData
    {
        public Dictionary<string[], string[]> CodecData { get; } = new Dictionary<string[], string[]>() {
        {new string[]{
            "0","1","0","1","1",
            "1","1","1","1","0",
            "0","1","1","0","0",
            "1","1","0","0","1",
            "1","1","1","1","1",},
                new string[]{
                "1","0","0","1","0",
                "1","1","1","1","0"
                }
            },

            {new string[]{
            "0","0","0","1","1",
            "0","1","0","1","1",
            "0","1","0","0","1",
            "1","1","0","1","0",
            "1","1","0","0","0"},
                new string[]{
                "0","1","0","1","0",
                "0","0","0","1","0"
                }
            },

            {new string[]{
            "1","1","0","0","0",
            "1","0","1","1","0",
            "0","0","0","1","0",
            "0","0","0","0","1",
            "0","0","0","1","1"},
                new string[]{
                "0","1","1","1","0",
                "0","1","1","1","0"
                }
            },

            {new string[]{
            "0","0","0","0","0",
            "0","0","0","1","0",
            "1","1","1","0","1",
            "1","0","0","1","0",
            "1","1","0","0","1"},

            new string[]{
            "0","1","0","0","1",
            "1","0","1","0","0"
            }
            },

            {new string[]{
            "0","0","1","0","0",
            "1","0","1","1","1",
            "0","1","0","1","0",
            "1","0","1","0","1",
            "1","1","0","1","1"},

            new string[]{
            "1","0","0","1","0",
            "1","0","1","1","1"
            }
            },

            {new string[]{
            "0","1","0","1","1",
            "0","0","1","1","1",
            "0","1","0","1","1",
            "1","1","0","0","0",
            "1","1","0","0","1"},

            new string[]{
            "1","1","1","0","1",
            "0","0","1","1","0"
            }
            },

            {new string[]{
            "1","0","0","1","0",
            "1","0","0","1","0",
            "0","0","0","0","0",
            "0","0","1","1","1",
            "1","0","0","1","1"},

            new string[]{
            "0","0","0","1","1",
            "1","0","1","0","0"
            }
            },

            {new string[]{
            "1","0","1","0","0",
            "0","1","1","1","0",
            "1","1","1","1","1",
            "1","0","1","1","0",
            "1","0","0","1","0"},

            new string[]{
            "0","1","1","1","0",
            "0","0","0","0","1"
            }
            },
            };
        public Dictionary<string[], string[]> DeCodecData { get; } = new Dictionary<string[], string[]>() {
        {new string[]{
            "1","1","1","0","1",
            "1","0","1","0","0",
            "0","0","1","0","0",
            "0","0","0","0","0",
            "1","1","1","1","0"},
            new string[]{
            "1","1","1","0","1",
            "1","1","1","0","0",
            "0","0","1","0","0",
            "0","0","0","0","0",
            "1","1","0","1","0",
            "0","0","1","0","0",
            "1","0","0","1","1"
            }
            },

            {new string[]{
            "0","0","0","1","0",
            "0","0","1","1","0",
            "0","0","1","0","0",
            "0","0","1","1","1",
            "1","0","1","0","0"},
            new string[]{
            "0","0","0","1","0",
            "0","0","1","1","0",
            "0","0","0","0","0",
            "0","0","1","1","1",
            "1","0","1","0","1",
            "1","0","1","1","0",
            "1","0","0","1","1"
            }
            },

            {new string[]{
            "1","1","1","0","1",
            "1","0","0","1","0",
            "1","1","0","0","0",
            "1","1","1","1","1",
            "0","0","0","1","1"},
            new string[]{
            "1","1","1","0","1",
            "1","0","0","1","0",
            "1","1","0","0","0",
            "1","0","1","1","1",
            "0","0","0","1","0",
            "0","0","0","1","0",
            "0","1","0","1","1"
            }
            },

            {new string[]{
            "1","0","0","1","0",
            "1","1","1","1","1",
            "1","0","1","1","0",
            "1","0","0","1","1",
            "0","1","1","1","0"},
            new string[]{
            "1","0","0","1","0",
            "1","1","0","1","1",
            "1","0","1","1","0",
            "1","1","0","1","1",
            "0","1","1","1","1",
            "0","1","1","1","1",
            "0","0","1","1","0"
            }
            },

            {new string[]{
            "0","1","1","0","1",
            "0","0","1","1","0",
            "1","0","1","0","1",
            "0","0","1","0","1",
            "0","1","1","1","0"},
            new string[]{
            "0","1","1","0","0",
            "0","0","1","1","0",
            "1","0","1","0","0",
            "0","0","0","0","1",
            "0","1","1","1","0",
            "1","0","1","0","1",
            "1","0","1","0","1"
            }
            },

            {new string[]{
            "0","1","1","1","0",
            "1","1","1","0","0",
            "1","0","1","1","0",
            "0","1","1","1","1",
            "0","1","0","1","1"},
            new string[]{
            "0","1","1","1","0",
            "1","0","1","0","0",
            "1","0","1","1","0",
            "0","1","0","1","1",
            "0","1","0","1","1",
            "1","1","1","0","1",
            "0","0","0","0","0"
            }
            },

            {new string[]{
            "0","0","1","0","1",
            "1","0","0","1","0",
            "0","0","0","1","0",
            "1","0","0","1","0",
            "1","0","1","0","1"},
            new string[]{
            "0","0","0","0","1",
            "1","0","0","1","0",
            "0","0","0","1","0",
            "1","0","0","1","0",
            "1","0","1","1","1",
            "0","0","1","0","1",
            "1","0","0","1","0"
            }
            },

            {new string[]{
            "1","1","0","1","1",
            "0","1","0","1","0",
            "1","1","1","0","1",
            "1","0","0","0","0",
            "0","1","1","0","0"},
            new string[]{
            "1","1","0","1","1",
            "0","1","0","1","0",
            "1","1","0","0","1",
            "1","0","0","0","0",
            "0","1","1","0","1",
            "0","0","0","1","0",
            "1","0","0","0","0"
            }
            },
            };
    }
}
