using System;
using Xunit;

namespace lnrSharp.Tests.Vec
{
    public class Vec_Init
    {
        [Fact]
        public void Vec2fInit() {

            float[] vec2Data = new float[] { 1, 2 };
            Vec2f v = new Vec2f(vec2Data);

            bool result = VecCheck(v, vec2Data);
            Assert.True(result, "Vec2f initialization fail");
        }

        [Fact]
        public void Vec3fInit()
        {

            float[] vec3Data = new float[] { 1, 2, 3 };

            Vec3f v = new Vec3f(vec3Data);

            bool result = VecCheck(v, vec3Data);
            Assert.True(result, "Vec3f initialization fail");
        }


        [Fact]
        public void Vec4fInit()
        {

            float[] vec4Data = new float[] { 1, 2, 3, 4 };

            Vec4f v = new Vec4f(vec4Data);

            bool result = VecCheck(v, vec4Data);
            Assert.True(result, "Vec4f initialization fail");
        }


        private bool VecCheck<T>(VecBase<T> v, T[] array) {
            for (uint i = 0; i < v.N; i++) {
                T checkValue = array[i];
                if (!v.Get(i).Equals(checkValue)) {
                    return false;
                }
            }
            return true;
        }

    }
}
