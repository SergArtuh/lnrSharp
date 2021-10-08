using System;
using System.Text;

namespace lnrSharp
{
    abstract public class VecBase<T> : Common.NativeHandler, Common.INativeDataAccessor
    {
        public virtual UInt32 N { get; }
        public virtual UInt32 SizeInByte { get; }
        public abstract T Get(UInt32 i);
        public abstract IntPtr GetNativeDataPtr();
        public abstract void Set(UInt32 i, float value);
        public abstract void SetNativeDataPtr(IntPtr ptr);

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n[");
            for (UInt32 i = 0; i < N; i++)
            {
                sb.Append(Get(i));
                if (i < N - 1)
                {
                    sb.Append(", ");
                }
            }
            sb.Append("]\n");
            return sb.ToString();
        }

    }
}

