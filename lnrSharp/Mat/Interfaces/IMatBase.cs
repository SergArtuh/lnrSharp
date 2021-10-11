using lnrSharp.Common;
using System;
using System.Text;

namespace lnrSharp
{
    public interface IMatBase<T>
    {
        public  UInt32 N { get; }
        public  UInt32 SizeInByte { get; }
        public  T Get(UInt32 i, UInt32 j);
        public  void Set(UInt32 i, UInt32 j, T value);
        public string ToString();

    }
}
