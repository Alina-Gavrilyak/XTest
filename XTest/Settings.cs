using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XTest
{
    public static class Settings
    {
        public static MyTheme Theme { get; set; } = MyTheme.White;
    }
    public enum MyTheme
    {
        White, 
        Black
    }

}
