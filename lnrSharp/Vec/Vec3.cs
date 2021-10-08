using System;
using System.Runtime.InteropServices;

namespace lnrSharp
{
    public class Vec3f : VecBase<float>
    {
        public Vec3f()
        {
            m_handlerPrt = CreateVector3f(null);
        }

        public Vec3f(float[] data)
        {
            m_handlerPrt = CreateVector3f(data);
        }

        internal Vec3f(IntPtr ptr)
        {
            m_handlerPrt = ptr;
        }

        ~Vec3f()
        {
            DeleteVector3f(m_handlerPrt);
        }


        public override UInt32 N => 3;
        public override UInt32 SizeInByte => sizeof(float) * N;

        public override float Get(UInt32 i)
        {
            return GetVector3f(m_handlerPrt, i);
        }
        public override IntPtr GetNativeDataPtr()
        {
            throw new NotImplementedException();
        }

        public override void Set(UInt32 i, float value)
        {
            SetVector3f(m_handlerPrt, i, value);
        }

        public override void SetNativeDataPtr(IntPtr ptr)
        {
            throw new NotImplementedException();
        }

        public float this[UInt32 key]
        {
            get => GetVector3f(m_handlerPrt, key);
            set => SetVector3f(m_handlerPrt, key, value);
        }

        public float X
        {
            get => GetVector3f(m_handlerPrt, 0);
            set => SetVector3f(m_handlerPrt, 0, value);
        }

        public float Y
        {
            get => GetVector3f(m_handlerPrt, 1);
            set => SetVector3f(m_handlerPrt, 1, value);
        }

        public float Z
        {
            get => GetVector3f(m_handlerPrt, 2);
            set => SetVector3f(m_handlerPrt, 2, value);
        }

        [DllImport(Common.Config.LNR_NATIVE_LIP_PATH)]
        private static extern IntPtr CreateVector3f(float[] data);

        [DllImport(Common.Config.LNR_NATIVE_LIP_PATH)]
        private static extern void DeleteVector3f(IntPtr vector);

        [DllImport(Common.Config.LNR_NATIVE_LIP_PATH)]
        private static extern float GetVector3f(IntPtr vector, UInt32 id);

        [DllImport(Common.Config.LNR_NATIVE_LIP_PATH)]
        private static extern void SetVector3f(IntPtr vector, UInt32 id, float value);
    }
}

