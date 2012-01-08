using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Boolean.Adapter;

namespace Boolean.Network.Messages.Types
{
    class OutMessage
    {
        public const byte END_CHARACTER = 1;
        public const byte STRING_CHARACTER = 2;

        public readonly int Id;
        private readonly List<byte> Content;

        public byte[] Result
        {
            get
            {
                this.Content.Add(END_CHARACTER);
                return Content.ToArray();
            }
        }

        public OutMessage(int Id)
        {
            this.Id = Id;
            this.Content = new List<byte>();
            this.Content.AddRange(Base64Encoding.EncodeInt32(Id, 2));
        }

        public void Append(object Item)
        {
            var Type = Item.GetType();

            if (Type == typeof(int))
            {
                this.Content.AddRange(WireEncoding.EncodeInt32((int)Item));
            }
            else if (Type == typeof(string))
            {
                this.Content.AddRange(Encoding.ASCII.GetBytes(Item as string));
                this.Content.Add(STRING_CHARACTER);
            }
            else if (Type == typeof(bool))
            {
                this.Content.AddRange(WireEncoding.EncodeInt32((bool)Item ? 1 : 0));
            }
        }
    }
}
