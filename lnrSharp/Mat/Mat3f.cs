using System;
using System.Runtime.InteropServices;

namespace lnrSharp
{
    public class Mat3f : MatBase<float>
    {
        public Mat3f()
        {
            m_handlerPrt = CreateMatrix3f(null);
        }

        public Mat3f(float[] data)
        {
            m_handlerPrt = CreateMatrix3f(data);
        }

        ~Mat3f()
        {
            DeleteMatrix3f(m_handlerPrt);
        }

        public override UInt32 N => 3;
        public override UInt32 SizeInByte => sizeof(float) * N * N;


        public Vec3f this[UInt32 key]
        {
            get => new Vec3f(GetVectorMatrix3f(m_handlerPrt, key));
        }

        public override float Get(UInt32 i, UInt32 j)
        {
            return GetMatrix3f(m_handlerPrt, i, j);
        }

        public override void Set(UInt32 i, UInt32 j, float value)
        {
            SetMatrix3f(m_handlerPrt, i, j, value);
        }

        [DllImport(Common.Config.LNR_NATIVE_LIP_PATH)]
        private static extern IntPtr CreateMatrix3f(float[] data);

        [DllImport(Common.Config.LNR_NATIVE_LIP_PATH)]
        private static extern void DeleteMatrix3f(IntPtr vector);

        [DllImport(Common.Config.LNR_NATIVE_LIP_PATH)]
        private static extern float GetMatrix3f(IntPtr vector, UInt32 i, UInt32 j);

        [DllImport(Common.Config.LNR_NATIVE_LIP_PATH)]
        private static extern IntPtr GetVectorMatrix3f(IntPtr vector, UInt32 i);

        [DllImport(Common.Config.LNR_NATIVE_LIP_PATH)]
        private static extern void SetMatrix3f(IntPtr vector, UInt32 i, UInt32 j, float value);
    }
}
