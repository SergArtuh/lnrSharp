using System;
using System.Runtime.InteropServices;

namespace lnrSharp
{
    public class Mat2f : MatBase<float>
    {
        public Mat2f()
        {
            m_handlerPrt = CreateMatrix2f(null);
        }

        public Mat2f(float[] data)
        {
            m_handlerPrt = CreateMatrix2f(data);
        }

        ~Mat2f()
        {
            DeleteMatrix2f(m_handlerPrt);
        }

        public override UInt32 N => 2;
        public override UInt32 SizeInByte => sizeof(float) * N * N;


        public Vec2f this[UInt32 key]
        {
            get => new Vec2f(GetVectorMatrix2f(m_handlerPrt, key));
        }

        public override float Get(UInt32 i, UInt32 j)
        {
            return GetMatrix2f(m_handlerPrt, i, j);
        }

        public override void Set(UInt32 i, UInt32 j, float value)
        {
            SetMatrix2f(m_handlerPrt, i, j, value);
        }
       

        [DllImport(Common.Config.LNR_NATIVE_LIP_PATH)]
        private static extern IntPtr CreateMatrix2f(float[] data);

        [DllImport(Common.Config.LNR_NATIVE_LIP_PATH)]
        private static extern void DeleteMatrix2f(IntPtr vector);

        [DllImport(Common.Config.LNR_NATIVE_LIP_PATH)]
        private static extern float GetMatrix2f(IntPtr vector, UInt32 i, UInt32 j);

        [DllImport(Common.Config.LNR_NATIVE_LIP_PATH)]
        private static extern IntPtr GetVectorMatrix2f(IntPtr vector, UInt32 i);

        [DllImport(Common.Config.LNR_NATIVE_LIP_PATH)]
        private static extern void SetMatrix2f(IntPtr vector, UInt32 i, UInt32 j, float value);
    }
}
