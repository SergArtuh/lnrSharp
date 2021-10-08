using lnrSharp.Common;
using System;
using System.Text;

namespace lnrSharp
{
    abstract public class MatBase<T> : Common.NativeHandler, Common.INativeDataAccessor
    {
        public abstract UInt32 N { get; }
        public abstract UInt32 SizeInByte { get; }
        public abstract T Get(UInt32 i, UInt32 j);
        public abstract IntPtr GetNativeDataPtr();
        public abstract void Set(UInt32 i, UInt32 j, float value);
        public abstract void SetNativeDataPtr(IntPtr ptr);

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n");
            for (UInt32 i = 0; i < N; i++) {
                sb.Append("[");
                for (UInt32 j = 0; j < N; j++)
                {
                    sb.Append(Get(i, j));
                    if (j < N - 1) {
                        sb.Append(", ");
                    }
                }
                sb.Append("]\n");
            }
            sb.Append("\n");
            return sb.ToString();
        }

    }
}
