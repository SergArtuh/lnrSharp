using System;
using Xunit;

namespace lnrSharp.Tests.Mat
{
    public class Mat_Init
    {
        [Fact]
        public void Mat2fInit() {

            float[] mat2Data = new float[] { 1, 2, 3, 4 };
            Mat2f m = new Mat2f(mat2Data);

            bool result = MatCheck(m, mat2Data);
            Assert.True(result, "Mat2f initialization fail");
        }

        [Fact]
        public void Mat3fInit()
        {

            float[] mat3Data = new float[] { 
                1, 2, 3,
                4, 5, 6,
                7, 8, 9 
            };

            Mat3f m = new Mat3f(mat3Data);

            bool result = MatCheck(m, mat3Data);
            Assert.True(result, "Mat3f initialization fail");
        }


        [Fact]
        public void Mat4fInit()
        {

            float[] mat4Data = new float[] {
                1, 2, 3, 4,
                5, 6, 7, 8,
                9, 10, 11, 12,
                13, 14, 15, 16
            };

            Mat4f m = new Mat4f(mat4Data);

            bool result = MatCheck(m, mat4Data);
            Assert.True(result, "Mat4f initialization fail");
        }


        private bool MatCheck<T>(MatBase<T> m, T[] array) {
            for (uint i = 0; i < m.N; i++) {
                for (uint j = 0; j < m.N; j++)
                {
                    T checkValue = array[i * m.N + j];
                    if (!m.Get(i, j).Equals(checkValue)) {
                        return false;
                    }
                }
            }
            return true;
        }

    }
}
