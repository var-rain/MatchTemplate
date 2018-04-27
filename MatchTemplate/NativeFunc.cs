using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MatchTemplate
{
    class NativeFunc
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct MatchResult
        {
            [MarshalAs(UnmanagedType.LPStr)]
            public string source;
            [MarshalAs(UnmanagedType.LPStr)]
            public string target;
            public bool isMatch;
            public int x;
            public int y;
            public int width;
            public int height;
        }

        [DllImport("MatchNative.dll", EntryPoint = "MatchImage", CharSet = CharSet.Ansi)]
        public static extern int match(ref MatchResult result);
    }
}
