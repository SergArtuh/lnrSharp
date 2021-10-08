using System;
using System.Runtime.InteropServices;

namespace lnrSharp
{
    public class Vec2f : VecBase<float>
    {
        public Vec2f()
        {
            m_handlerPrt = CreateVector2f(null);
        }

        public Vec2f(float[] data)
        {
            m_handlerPrt = CreateVector2f(data);
        }

        internal Vec2f(IntPtr ptr)
        {
            m_handlerPrt = ptr;
        }

        ~Vec2f()
        {
            DeleteVector2f(m_handlerPrt);
        }

        public override UInt32 N => 2;
        public override UInt32 SizeInByte => sizeof(float) * N;

        public override float Get(UInt32 i)
        {
            return GetVector2f(m_handlerPrt, i);
        }

        public override IntPtr GetNativeDataPtr()
        {
            throw new NotImplementedException();
        }

        public override void Set(UInt32 i, float value)
        {
            SetVector2f(m_handlerPrt, i, value);
        }

        public override void SetNativeDataPtr(IntPtr ptr)
        {
            throw new NotImplementedException();
        }

        public float this[UInt32 key]
        {
            get => GetVector2f(m_handlerPrt, key);
            set => SetVector2f(m_handlerPrt, key, value);
        }

        public float X
        {
            get => GetVector2f(m_handlerPrt, 0);
            set => SetVector2f(m_handlerPrt, 0, value);
        }

        public float Y
        {
            get => GetVector2f(m_handlerPrt, 1);
            set => SetVector2f(m_handlerPrt, 1, value);
        }

        [DllImport(Common.Config.LNR_NATIVE_LIP_PATH)]
        private static extern IntPtr CreateVector2f(float[] data);

        [DllImport(Common.Config.LNR_NATIVE_LIP_PATH)]
        private static extern void DeleteVector2f(IntPtr vector);

        [DllImport(Common.Config.LNR_NATIVE_LIP_PATH)]
        private static extern float GetVector2f(IntPtr vector, UInt32 id);

        [DllImport(Common.Config.LNR_NATIVE_LIP_PATH)]
        private static extern void SetVector2f(IntPtr vector, UInt32 id, float value);
    }
}

