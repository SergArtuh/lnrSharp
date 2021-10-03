using System;
using System.Runtime.InteropServices;

namespace lnrSharp
{
    public class Vec4f : VecBase<float>
    {
        public Vec4f()
        {
            m_handlerPrt = CreateVector4f(null);
        }

        public Vec4f(float[] data)
        {
            m_handlerPrt = CreateVector4f(data);
        }

        internal Vec4f(IntPtr vecPtr)
        {
            m_handlerPrt = vecPtr;
        }

        ~Vec4f()
        {
            DeleteVector4f(m_handlerPrt);
        }

        public override UInt32 N => 4;
        public override UInt32 SizeInByte => sizeof(float) * N;

        public override float Get(UInt32 i)
        {
            return GetVector4f(m_handlerPrt, i);
        }

        public override void Set(UInt32 i, float value)
        {
            SetVector4f(m_handlerPrt, i, value);
        }


        public float this[UInt32 key]
        {
            get => GetVector4f(m_handlerPrt, key);
            set => SetVector4f(m_handlerPrt, key, value);
        }

        public float X
        {
            get => GetVector4f(m_handlerPrt, 0);
            set => SetVector4f(m_handlerPrt, 0, value);
        }

        public float Y
        {
            get => GetVector4f(m_handlerPrt, 1);
            set => SetVector4f(m_handlerPrt, 1, value);
        }

        public float Z
        {
            get => GetVector4f(m_handlerPrt, 2);
            set => SetVector4f(m_handlerPrt, 2, value);
        }

        public float W
        {
            get => GetVector4f(m_handlerPrt, 3);
            set => SetVector4f(m_handlerPrt, 3, value);
        }

        [DllImport(Common.Config.LNR_NATIVE_LIP_PATH)]
        private static extern IntPtr CreateVector4f(float[] data);

        [DllImport(Common.Config.LNR_NATIVE_LIP_PATH)]
        private static extern void DeleteVector4f(IntPtr vector);

        [DllImport(Common.Config.LNR_NATIVE_LIP_PATH)]
        private static extern float GetVector4f(IntPtr vector, UInt32 id);

        [DllImport(Common.Config.LNR_NATIVE_LIP_PATH)]
        private static extern void SetVector4f(IntPtr vector, UInt32 id, float value);
    }
}

