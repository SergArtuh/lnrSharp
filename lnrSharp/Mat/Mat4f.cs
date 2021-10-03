using System;
using System.Runtime.InteropServices;

namespace lnrSharp
{
    public class Mat4f : MatBase<float>
    {
        public Mat4f()
        {
            m_handlerPrt = CreateMatrix4f(null);
        }

        public Mat4f(float[] data)
        {
            m_handlerPrt = CreateMatrix4f(data);
        }

        //public Mat4f(IntPtr dataPtr, UInt64 offset)
        //{
        //    m_handlerPrt = CreateMatrixFromNativeData4f(IntPtr.Add(dataPtr, (Int32)offset));
        //}

        ~Mat4f()
        {
            DeleteMatrix4f(m_handlerPrt);
        }

        public override UInt32 N => 4;
        public override UInt32 SizeInByte => sizeof(float) * N * N;

        

        public Vec4f this[UInt32 key]
        {
            get => new Vec4f(GetVectorMatrix4f(m_handlerPrt, key));
        }

        public override float Get(UInt32 i, UInt32 j)
        {
            return GetMatrix4f(m_handlerPrt, i, j);
        }

        public override void Set(UInt32 i, UInt32 j, float value)
        {
            SetMatrix4f(m_handlerPrt, i, j, value);
        }

       

        [DllImport(Common.Config.LNR_NATIVE_LIP_PATH)]
        private static extern IntPtr CreateMatrix4f(float[] data);

        //[DllImport(Common.Config.LNR_NATIVE_LIP_PATH)]
        //private static extern IntPtr CreateMatrixFromNativeData4f(IntPtr ptr);

        [DllImport(Common.Config.LNR_NATIVE_LIP_PATH)]
        private static extern void DeleteMatrix4f(IntPtr vector);

        [DllImport(Common.Config.LNR_NATIVE_LIP_PATH)]
        private static extern float GetMatrix4f(IntPtr vector, UInt32 i, UInt32 j);

        [DllImport(Common.Config.LNR_NATIVE_LIP_PATH)]
        private static extern IntPtr GetVectorMatrix4f(IntPtr vector, UInt32 i);

        [DllImport(Common.Config.LNR_NATIVE_LIP_PATH)]
        private static extern void SetMatrix4f(IntPtr vector, UInt32 i, UInt32 j, float value);
    }
}
