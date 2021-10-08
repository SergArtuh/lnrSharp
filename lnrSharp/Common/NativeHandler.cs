using System;
using System.Collections.Generic;
using System.Text;

namespace lnrSharp.Common
{
    public class NativeHandler : INativeHandler
    {

        public IntPtr GetNativePtr()
        {
            return m_handlerPrt;
        }

        protected IntPtr m_handlerPrt = IntPtr.Zero;
    }
}


