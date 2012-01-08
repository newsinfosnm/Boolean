using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Boolean.Adapter;

namespace Boolean.Network.Messages.Types
{
    class InMessage
    {
        public readonly int Id;
        public readonly int Length;
        public readonly byte[] Context;

        private int PointerLength;

        private int GetLength()
        {
            return Length - PointerLength;
        }

        public InMessage(int Id, byte[] Context)
        {
            this.Id = Id;
            this.Length = Context.Length;
            this.Context = Context;
            this.PointerLength = new int();
        }

        public string GetString()
        {
            try
            {
                var Length = Base64Encoding.DecodeInt32(GetBytes(2));

                if (Length > 0)
                {
                    PointerLength += 2;

                    var Result = Encoding.ASCII.GetString(GetBytes(Length)).Replace((char)1, ' ');

                    PointerLength += Length;

                    return Result;
                }
                else return string.Empty;
            }
            catch { return string.Empty; }
        }

        public int GetInt32()
        {
            try
            {
                var Bytes = GetBytes(WireEncoding.MAX_INTEGER_BYTE_AMOUNT);
                var Length = new int();

                var Result = WireEncoding.DecodeInt32(Bytes, out Length);

                PointerLength += Length;

                return Result;
            }
            catch { return 0; }
        }

        public bool GetBoolean()
        {
            return GetInt32() > 0;
        }

        private byte[] GetBytes(int Length)
        {
            if (Length > GetLength())
            {
                Length = GetLength();
            }

            var Result = new byte[Length];

            Array.Copy(Context, PointerLength, Result, 0,Length);

            return Result;
        }
    }
}
