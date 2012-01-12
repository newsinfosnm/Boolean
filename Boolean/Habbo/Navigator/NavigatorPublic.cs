using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Boolean.Adapters;
using Boolean.Network.Messages.Types;

namespace Boolean.Habbo.Navigator
{
    class NavigatorPublic
    {
        public int Id;
        public int ParentId;
        public string Caption;
        public string Description;
        public int Type;
        public string ImageSrc;
        public bool ImagePlace;
        public string SearchTags;
        public int RoomId;
        public string CCTs;
        public bool Focus;
        public int OrderId;

        public NavigatorPublic(DataRow Row)
        {
            this.Id = (int)Row["id"];
            this.ParentId = (int)Row["parent_id"];
            this.Caption = (string)Row["caption"];
            this.Description = (string)Row["description"];
            this.Type = int.Parse(Row["type"].ToString());
            this.ImageSrc = (string)Row["image_src"];
            this.ImagePlace = StringAdapter.GetBoolean(Row["image_place"]);
            this.SearchTags = (string)Row["search_tags"];
            this.RoomId = (int)Row["room_id"];
            this.CCTs = (string)Row["ccts"];
            this.Focus = StringAdapter.GetBoolean(Row["focus"]);
            this.OrderId = (int)Row["order_id"];
        }

        public void GetResponse(OutMessage Message)
        {
            Message.Append(Id);
            Message.Append(Caption); // TODO: Room name
            Message.Append(Description); // TODO: Room description
            Message.Append(ImagePlace);
            Message.Append(Caption); // TODO: Room name

            if (Type >= 2 && Type <= 3)
            {
                Message.Append(ImageSrc.Contains('/') ? ImageSrc : string.Empty);
            }
            else Message.Append(ImageSrc);
            
            Message.Append(ParentId);
            Message.Append(0); // TODO: RoomUnitsAmount
            Message.Append(Type);

            switch (Type)
            {
                case 1:
                    Message.Append(SearchTags);
                    break;
                case 2:
                case 3:
                    Message.Append(!ImageSrc.Contains('/') ? ImageSrc : string.Empty);
                    Message.Append(0);
                    Message.Append(0);
                    Message.Append(CCTs);
                    Message.Append(25); // TODO: LimitUsers
                    break;
                case 4:
                    Message.Append(Focus);
                    break;
            }
        }
    }
}
