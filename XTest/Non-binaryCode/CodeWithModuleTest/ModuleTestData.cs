using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XTest.Non_binaryCode.CodeWithModuleTest
{
    class ModuleTestData
    {
        public Dictionary<string, string> CodecData { get; } = new Dictionary<string, string>() {
        {"13,96A2C2B5572798","96A2C2B55727989"},
        {"23,44EEJADLHBADH" ,"44EEJADLHBADHH" },
        {"16,EC241FF0A652"  ,"EC241FF0A652A"  },
        {"9,167185"         ,"1671858"        },
        {"18,C0E88G5H"      ,"C0E88G5HA"      },
        {"20,CD8C008"       ,"CD8C0087"       },
        {"7,310164015"      ,"3101640150"     },
        {"5,431142430"      ,"4311424303"     },
        {"17,4F1B54"        ,"4F1B54B"        },
        {"4,3332323"        ,"33323231"       },
        {"5,41112214341114" ,"411122143411140"},
        {"14,B17039708703"  ,"B170397087030"  },
        {"21,B05BHJ"        ,"B05BHJ0"        },
        {"12,54B21A0963"    ,"54B21A09639"    },
        {"9,5063734"        ,"50637348"       },
        {"10,44087196340186","440871963401869"},
        {"8,23316"          ,"233161"         },
        {"17,535G9"         ,"535G9D"         },
        {"9,63132163865487" ,"631321638654870"},
        {"21,F04JEBJ0"      ,"F04JEBJ02"      },
        {"16,80CD8ED"       ,"80CD8EDC"       },
        {"20,4928J048CD6H9B","4928J048CD6H9BI"},
        {"9,76642123"       ,"766421235"      },
        {"9,6037222507271"  ,"60372225072711" },
        {"22,3C0K72G"       ,"3C0K72G6" }      ,

        };

        public Dictionary<string, bool> DeCodecData { get; } = new Dictionary<string, bool>()
        {
            {"6 ,25503131112"    ,true},
            {"21,01E9D0B6HHG9553",true},
            {"23,FL565495M"      ,true},
            {"18,H30F495HE07EG5" ,true},
            {"9 ,418428"         ,true},
            {"8 ,266200"         ,true},
            {"5 ,4324331"        ,true},
            {"5 ,1254241434"     ,false},
            {"21,AIB4J1C042HI"   ,false},
            {"5 ,32212301131321" ,true},
            {"11,005719"         ,true},
            {"10,34389315"       ,false},
            {"4 ,303221513"      ,false},
            {"10,879771602261"   ,false},
            {"17,1F315GC3EGG"    ,true},
            {"6 ,53005201341"    ,true},
            {"15,8E2A38"         ,true},
            {"3 ,022110001101"   ,true},
            {"11,622AA4913482"   ,false},
            {"11,A099A458"       ,true},
            {"19,F554H2554A9522" ,false},
            {"4 ,3320127131212"  ,false},
            {"15,9DC7E5395B"     ,false},
            {"7 ,224852"         ,false},
            {"14,420C12"         ,false},
        };
    }
}
