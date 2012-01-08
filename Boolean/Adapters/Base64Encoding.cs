using System;

using System.Linq;
using System.Text;

namespace Boolean.Adapter
{
    class Base64Encoding
    {
        #region Fields
        public const byte NEGATIVE = 64;
        public const byte POSITIVE = 65;
        #endregion

        #region Methods

        public static byte[] EncodeInt32(Int32 i, int numBytes)
        {
            byte[] bzRes = new byte[numBytes];

            for (int j = 1; j <= numBytes; j++)
            {
                int k = ((numBytes - j) * 6);

                bzRes[j - 1] = Convert.ToByte(0x40 + ((i >> k) & 0x3f));
            }

            return bzRes;
        }

        public static Int32 DecodeInt32(byte[] bzData)
        {
            int i = 0;
            int j = 0;

            for (int k = bzData.Length - 1; k >= 0; k--)
            {
                int x = bzData[k] - 0x40;

                if (j > 0)
                {
                    x *= (int)Math.Pow(64.0, Convert.ToDouble(j));
                }

                i += x;
                j++;
            }

            return i;
        }

        #endregion
    }
}
