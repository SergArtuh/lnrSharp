using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace lnrSharp.Helper
{
    public static class Identity
    {
        public static void fff(float f ) { 
        
        }
        public static void Make<T>(MatBase<T> m) 
        {

            for (uint i = 0; i < m.N; i++) {
                for (uint j = 0; j < m.N; j++)
                {
                    m.Set(i, j, (T)Convert.ChangeType((i == j) ? 1 : 0, typeof(T)));
                }
            }
        }

    }
}
