using System;
using System.Collections.Generic;
using System.Text;

namespace lnrSharp.Common
{
    public interface INativeDataAccessor
    {
        public void SetNativeDataPtr(IntPtr ptr);

        public IntPtr GetNativeDataPtr();
    }
}
