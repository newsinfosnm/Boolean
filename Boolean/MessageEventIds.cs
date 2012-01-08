using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boolean
{
    static class MessageEventIds
    {
        // _-2Pf[206] = com.sulake.habbo.communication.messages.outgoing.handshake.InitCryptoMessageComposer; 
        public const uint InitCryptoMessageEvent = 206;

        // _-2Pf[2002] = com.sulake.habbo.communication.messages.outgoing.handshake.GenerateSecretKeyMessageComposer; 
        public const uint GenerateSecretKeyMessageEvent = 2002;

        // _-2Pf[1170] = com.sulake.habbo.communication.messages.outgoing.handshake.VersionCheckMessageComposer; 
        public const uint VersionCheckMessageEvent = 1170;

        // _-2Pf[813] = com.sulake.habbo.communication.messages.outgoing.handshake.UniqueIDMessageComposer; 
        public const uint UniqueIDMessageEvent = 813;

        // _-2Pf[1817] = com.sulake.habbo.communication.messages.outgoing.handshake.GetSessionParametersMessageComposer; 
        public const uint GetSessionParametersMessageEvent = 1817;

        // _-2Pf[415] = com.sulake.habbo.communication.messages.outgoing.handshake.SSOTicketMessageComposer; 
        public const uint SSOTicketMessageEvent = 415;

        // _-2Pf[756] = com.sulake.habbo.communication.messages.outgoing.handshake.TryLoginMessageComposer; 
        public const uint TryLoginMessageEvent = 756;

        // _-2Pf[196] = com.sulake.habbo.communication.messages.outgoing.handshake.PongMessageComposer; 
        public const uint PongMessageEvent = 196;

        // _-2Pf[7] = com.sulake.habbo.communication.messages.outgoing.handshake.InfoRetrieveMessageComposer; 
        public const uint InfoRetrieveMessageEvent = 7;

        // _-2Pf[512] = com.sulake.habbo.communication.messages.outgoing.handshake.DisconnectMessageComposer; 
        public const uint DisconnectMessageEvent = 512;

        // _-2Pf[12] = com.sulake.habbo.communication.messages.outgoing.friendlist.MessengerInitMessageComposer; 
        public const uint MessengerInitMessageEvent = 12;

        // _-2Pf[15] = com.sulake.habbo.communication.messages.outgoing.friendlist.FriendListUpdateMessageComposer; 
        public const uint FriendListUpdateMessageEvent = 15;

        // _-2Pf[33] = com.sulake.habbo.communication.messages.outgoing.friendlist.SendMsgMessageComposer; 
        public const uint SendMsgMessageEvent = 33;

        // _-2Pf[37] = com.sulake.habbo.communication.messages.outgoing.friendlist.AcceptBuddyMessageComposer; 
        public const uint AcceptBuddyMessageEvent = 37;

        // _-2Pf[38] = com.sulake.habbo.communication.messages.outgoing.friendlist.DeclineBuddyMessageComposer; 
        public const uint DeclineBuddyMessageEvent = 38;

        // _-2Pf[39] = com.sulake.habbo.communication.messages.outgoing.friendlist.RequestBuddyMessageComposer; 
        public const uint RequestBuddyMessageEvent = 39;

        // _-2Pf[40] = com.sulake.habbo.communication.messages.outgoing.friendlist.RemoveBuddyMessageComposer; 
        public const uint RemoveBuddyMessageEvent = 40;

        // _-2Pf[41] = com.sulake.habbo.communication.messages.outgoing.friendlist.HabboSearchMessageComposer; 
        public const uint HabboSearchMessageEvent = 41;

        // _-2Pf[233] = com.sulake.habbo.communication.messages.outgoing.friendlist.GetBuddyRequestsMessageComposer; 
        public const uint GetBuddyRequestsMessageEvent = 233;

        // _-2Pf[262] = com.sulake.habbo.communication.messages.outgoing.friendlist.FollowFriendMessageComposer; 
        public const uint FollowFriendMessageEvent = 262;

        // _-2Pf[34] = com.sulake.habbo.communication.messages.outgoing.friendlist.SendRoomInviteMessageComposer; 
        public const uint SendRoomInviteMessageEvent = 34;

        // _-2Pf[490] = com.sulake.habbo.communication.messages.outgoing.friendlist.FindNewFriendsMessageComposer; 
        public const uint FindNewFriendsMessageEvent = 490;

        // _-2Pf[500] = com.sulake.habbo.communication.messages.outgoing.friendlist.GetEventStreamComposer; 
        public const uint GetEventStreamEvent = 500;

        // _-2Pf[501] = com.sulake.habbo.communication.messages.outgoing.friendlist.SetEventStreamingAllowedComposer; 
        public const uint SetEventStreamingAllowedEvent = 501;

        // _-2Pf[8] = com.sulake.habbo.communication.messages.outgoing.inventory.purse.GetCreditsInfoComposer; 
        public const uint GetCreditsInfoEvent = 8;

        // _-2Pf[404] = com.sulake.habbo.communication.messages.outgoing.inventory.furni.RequestFurniInventoryComposer; 
        public const uint RequestFurniInventoryEvent = 404;

        // _-2Pf[372] = com.sulake.habbo.communication.messages.outgoing.inventory.avatareffect.AvatarEffectSelectedComposer; 
        public const uint AvatarEffectSelectedEvent = 372;

        // _-2Pf[373] = com.sulake.habbo.communication.messages.outgoing.inventory.avatareffect.AvatarEffectActivatedComposer; 
        public const uint AvatarEffectActivatedEvent = 373;

        // _-2Pf[157] = com.sulake.habbo.communication.messages.outgoing.inventory.badges.GetBadgesComposer; 
        public const uint GetBadgesEvent = 157;

        // _-2Pf[158] = com.sulake.habbo.communication.messages.outgoing.inventory.badges.SetActivatedBadgesComposer; 
        public const uint SetActivatedBadgesEvent = 158;

        // _-2Pf[3032] = com.sulake.habbo.communication.messages.outgoing.inventory.badges.GetBadgePointLimitsComposer; 
        public const uint GetBadgePointLimitsEvent = 3032;

        // _-2Pf[370] = com.sulake.habbo.communication.messages.outgoing.inventory.achievements.GetAchievementsComposer; 
        public const uint GetAchievementsEvent = 370;

        // _-2Pf[68] = com.sulake.habbo.communication.messages.outgoing.inventory.trading.UnacceptTradingComposer; 
        public const uint UnacceptTradingEvent = 68;

        // _-2Pf[69] = com.sulake.habbo.communication.messages.outgoing.inventory.trading.AcceptTradingComposer; 
        public const uint AcceptTradingEvent = 69;

        // _-2Pf[70] = com.sulake.habbo.communication.messages.outgoing.inventory.trading.CloseTradingComposer; 
        public const uint CloseTradingEvent = 70;

        // _-2Pf[71] = com.sulake.habbo.communication.messages.outgoing.inventory.trading.OpenTradingComposer; 
        public const uint OpenTradingEvent = 71;

        // _-2Pf[72] = com.sulake.habbo.communication.messages.outgoing.inventory.trading.AddItemToTradeComposer; 
        public const uint AddItemToTradeEvent = 72;

        // _-2Pf[402] = com.sulake.habbo.communication.messages.outgoing.inventory.trading.ConfirmAcceptTradingComposer; 
        public const uint ConfirmAcceptTradingEvent = 402;

        // _-2Pf[403] = com.sulake.habbo.communication.messages.outgoing.inventory.trading.ConfirmDeclineTradingComposer; 
        public const uint ConfirmDeclineTradingEvent = 403;

        // _-2Pf[405] = com.sulake.habbo.communication.messages.outgoing.inventory.trading.RemoveItemFromTradeComposer; 
        public const uint RemoveItemFromTradeEvent = 405;

        // _-2Pf[3000] = com.sulake.habbo.communication.messages.outgoing.inventory.pets.GetPetInventoryComposer; 
        public const uint GetPetInventoryEvent = 3000;

        // _-2Pf[3010] = com.sulake.habbo.communication.messages.outgoing.marketplace.MakeOfferMessageComposer; 
        public const uint MakeOfferMessageEvent = 3010;

        // _-2Pf[3011] = com.sulake.habbo.communication.messages.outgoing.marketplace.GetMarketplaceConfigurationMessageComposer; 
        public const uint GetMarketplaceConfigurationMessageEvent = 3011;

        // _-2Pf[3012] = com.sulake.habbo.communication.messages.outgoing.marketplace.GetMarketplaceCanMakeOfferComposer; 
        public const uint GetMarketplaceCanMakeOfferEvent = 3012;

        // _-2Pf[3013] = com.sulake.habbo.communication.messages.outgoing.marketplace.BuyMarketplaceTokensMessageComposer; 
        public const uint BuyMarketplaceTokensMessageEvent = 3013;

        // _-2Pf[3014] = com.sulake.habbo.communication.messages.outgoing.marketplace.BuyOfferMessageComposer; 
        public const uint BuyOfferMessageEvent = 3014;

        // _-2Pf[3015] = com.sulake.habbo.communication.messages.outgoing.marketplace.CancelOfferMessageComposer; 
        public const uint CancelOfferMessageEvent = 3015;

        // _-2Pf[3016] = com.sulake.habbo.communication.messages.outgoing.marketplace.RedeemOfferCreditsMessageComposer; 
        public const uint RedeemOfferCreditsMessageEvent = 3016;

        // _-2Pf[3018] = com.sulake.habbo.communication.messages.outgoing.marketplace.GetOffersMessageComposer; 
        public const uint GetOffersMessageEvent = 3018;

        // _-2Pf[3019] = com.sulake.habbo.communication.messages.outgoing.marketplace.GetOwnOffersMessageComposer; 
        public const uint GetOwnOffersMessageEvent = 3019;

        // _-2Pf[3020] = com.sulake.habbo.communication.messages.outgoing.marketplace.GetMarketplaceItemStatsComposer; 
        public const uint GetMarketplaceItemStatsEvent = 3020;

        // _-2Pf[20] = com.sulake.habbo.communication.messages.outgoing.navigator.DeleteFavouriteRoomMessageComposer; 
        public const uint DeleteFavouriteRoomMessageEvent = 20;

        // _-2Pf[19] = com.sulake.habbo.communication.messages.outgoing.navigator.AddFavouriteRoomMessageComposer; 
        public const uint AddFavouriteRoomMessageEvent = 19;

        // _-2Pf[151] = com.sulake.habbo.communication.messages.outgoing.navigator.GetUserFlatCatsMessageComposer; 
        public const uint GetUserFlatCatsMessageEvent = 151;

        // _-2Pf[345] = com.sulake.habbo.communication.messages.outgoing.navigator.CanCreateEventMessageComposer; 
        public const uint CanCreateEventMessageEvent = 345;

        // _-2Pf[346] = com.sulake.habbo.communication.messages.outgoing.navigator.CreateEventMessageComposer; 
        public const uint CreateEventMessageEvent = 346;

        // _-2Pf[347] = com.sulake.habbo.communication.messages.outgoing.navigator.CancelEventMessageComposer; 
        public const uint CancelEventMessageEvent = 347;

        // _-2Pf[348] = com.sulake.habbo.communication.messages.outgoing.navigator.EditEventMessageComposer; 
        public const uint EditEventMessageEvent = 348;

        // _-2Pf[400] = com.sulake.habbo.communication.messages.outgoing.roomsettings.GetRoomSettingsMessageComposer; 
        public const uint GetRoomSettingsMessageEvent = 400;

        // _-2Pf[401] = com.sulake.habbo.communication.messages.outgoing.roomsettings.SaveRoomSettingsMessageComposer; 
        public const uint SaveRoomSettingsMessageEvent = 401;

        // _-2Pf[23] = com.sulake.habbo.communication.messages.outgoing.roomsettings.DeleteRoomMessageComposer; 
        public const uint DeleteRoomMessageEvent = 23;

        // _-2Pf[380] = com.sulake.habbo.communication.messages.outgoing.navigator.GetOfficialRoomsMessageComposer; 
        public const uint GetOfficialRoomsMessageEvent = 380;

        // _-2Pf[382] = com.sulake.habbo.communication.messages.outgoing.navigator.GetPopularRoomTagsMessageComposer; 
        public const uint GetPopularRoomTagsMessageEvent = 382;

        // _-2Pf[384] = com.sulake.habbo.communication.messages.outgoing.navigator.UpdateNavigatorSettingsMessageComposer; 
        public const uint UpdateNavigatorSettingsMessageEvent = 384;

        // _-2Pf[385] = com.sulake.habbo.communication.messages.outgoing.navigator.GetGuestRoomMessageComposer; 
        public const uint GetGuestRoomMessageEvent = 385;

        // _-2Pf[386] = com.sulake.habbo.communication.messages.outgoing.navigator.UpdateRoomThumbnailMessageComposer; 
        public const uint UpdateRoomThumbnailMessageEvent = 386;

        // _-2Pf[387] = com.sulake.habbo.communication.messages.outgoing.navigator.CanCreateRoomMessageComposer; 
        public const uint CanCreateRoomMessageEvent = 387;

        // _-2Pf[29] = com.sulake.habbo.communication.messages.outgoing.navigator.CreateFlatMessageComposer; 
        public const uint CreateFlatMessageEvent = 29;

        // _-2Pf[261] = com.sulake.habbo.communication.messages.outgoing.navigator.RateFlatMessageComposer; 
        public const uint RateFlatMessageEvent = 261;

        // _-2Pf[388] = com.sulake.habbo.communication.messages.outgoing.navigator.GetPublicSpaceCastLibsMessageComposer; 
        public const uint GetPublicSpaceCastLibsMessageEvent = 388;

        // _-2Pf[430] = com.sulake.habbo.communication.messages.outgoing.navigator.PopularRoomsSearchMessageComposer; 
        public const uint PopularRoomsSearchMessageEvent = 430;

        // _-2Pf[431] = com.sulake.habbo.communication.messages.outgoing.navigator.RoomsWithHighestScoreSearchMessageComposer; 
        public const uint RoomsWithHighestScoreSearchMessageEvent = 431;

        // _-2Pf[432] = com.sulake.habbo.communication.messages.outgoing.navigator.MyFriendsRoomsSearchMessageComposer; 
        public const uint MyFriendsRoomsSearchMessageEvent = 432;

        // _-2Pf[433] = com.sulake.habbo.communication.messages.outgoing.navigator.RoomsWhereMyFriendsAreSearchMessageComposer; 
        public const uint RoomsWhereMyFriendsAreSearchMessageEvent = 433;

        // _-2Pf[434] = com.sulake.habbo.communication.messages.outgoing.navigator.MyRoomsSearchMessageComposer; 
        public const uint MyRoomsSearchMessageEvent = 434;

        // _-2Pf[435] = com.sulake.habbo.communication.messages.outgoing.navigator.MyFavouriteRoomsSearchMessageComposer; 
        public const uint MyFavouriteRoomsSearchMessageEvent = 435;

        // _-2Pf[436] = com.sulake.habbo.communication.messages.outgoing.navigator.MyRoomHistorySearchMessageComposer; 
        public const uint MyRoomHistorySearchMessageEvent = 436;

        // _-2Pf[437] = com.sulake.habbo.communication.messages.outgoing.navigator.RoomTextSearchMessageComposer; 
        public const uint RoomTextSearchMessageEvent = 437;

        // _-2Pf[438] = com.sulake.habbo.communication.messages.outgoing.navigator.RoomTagSearchMessageComposer; 
        public const uint RoomTagSearchMessageEvent = 438;

        // _-2Pf[439] = com.sulake.habbo.communication.messages.outgoing.navigator.LatestEventsSearchMessageComposer; 
        public const uint LatestEventsSearchMessageEvent = 439;

        // _-2Pf[483] = com.sulake.habbo.communication.messages.outgoing.navigator.ToggleStaffPickMessageComposer; 
        public const uint ToggleStaffPickMessageEvent = 483;

        // _-2Pf[3004] = com.sulake.habbo.communication.messages.outgoing.room.engine.GetPetCommandsMessageComposer; 
        public const uint GetPetCommandsMessageEvent = 3004;

        // _-2Pf[2] = com.sulake.habbo.communication.messages.outgoing.room.session.OpenConnectionMessageComposer; 
        public const uint OpenConnectionMessageEvent = 2;

        // _-2Pf[391] = com.sulake.habbo.communication.messages.outgoing.room.session.OpenFlatConnectionMessageComposer; 
        public const uint OpenFlatConnectionMessageEvent = 391;

        // _-2Pf[52] = com.sulake.habbo.communication.messages.outgoing.room.chat.ChatMessageComposer; 
        public const uint ChatMessageEvent = 52;

        // _-2Pf[55] = com.sulake.habbo.communication.messages.outgoing.room.chat.ShoutMessageComposer; 
        public const uint ShoutMessageEvent = 55;

        // _-2Pf[56] = com.sulake.habbo.communication.messages.outgoing.room.chat.WhisperMessageComposer; 
        public const uint WhisperMessageEvent = 56;

        // _-2Pf[317] = com.sulake.habbo.communication.messages.outgoing.room.chat.StartTypingMessageComposer; 
        public const uint StartTypingMessageEvent = 317;

        // _-2Pf[318] = com.sulake.habbo.communication.messages.outgoing.room.chat.CancelTypingMessageComposer; 
        public const uint CancelTypingMessageEvent = 318;

        // _-2Pf[104] = com.sulake.habbo.communication.messages.outgoing.room.avatar.SignMessageComposer; 
        public const uint SignMessageEvent = 104;

        // _-2Pf[484] = com.sulake.habbo.communication.messages.outgoing.room.avatar.ChangeMottoMessageComposer; 
        public const uint ChangeMottoMessageEvent = 484;

        // _-2Pf[59] = com.sulake.habbo.communication.messages.outgoing.room.session.GoToFlatMessageComposer; 
        public const uint GoToFlatMessageEvent = 59;

        // _-2Pf[390] = com.sulake.habbo.communication.messages.outgoing.room.engine.GetRoomEntryDataMessageComposer; 
        public const uint GetRoomEntryDataMessageEvent = 390;

        // _-2Pf[392] = com.sulake.habbo.communication.messages.outgoing.room.engine.UseFurnitureMessageComposer; 
        public const uint UseFurnitureMessageEvent = 392;

        // _-2Pf[67] = com.sulake.habbo.communication.messages.outgoing.room.engine.PickupObjectMessageComposer; 
        public const uint PickupObjectMessageEvent = 67;

        // _-2Pf[73] = com.sulake.habbo.communication.messages.outgoing.room.engine.MoveObjectMessageComposer; 
        public const uint MoveObjectMessageEvent = 73;

        // _-2Pf[74] = com.sulake.habbo.communication.messages.outgoing.room.engine.SetObjectDataMessageComposer; 
        public const uint SetObjectDataMessageEvent = 74;

        // _-2Pf[75] = com.sulake.habbo.communication.messages.outgoing.room.engine.MoveAvatarMessageComposer; 
        public const uint MoveAvatarMessageEvent = 75;

        // _-2Pf[90] = com.sulake.habbo.communication.messages.outgoing.room.engine.PlaceObjectMessageComposer; 
        public const uint PlaceObjectMessageEvent = 90;

        // _-2Pf[91] = com.sulake.habbo.communication.messages.outgoing.room.engine.MoveWallItemMessageComposer; 
        public const uint MoveWallItemMessageEvent = 91;

        // _-2Pf[3002] = com.sulake.habbo.communication.messages.outgoing.room.engine.PlacePetMessageComposer; 
        public const uint PlacePetMessageEvent = 3002;

        // _-2Pf[3003] = com.sulake.habbo.communication.messages.outgoing.room.engine.RemovePetFromFlatMessageComposer; 
        public const uint RemovePetFromFlatMessageEvent = 3003;

        // _-2Pf[3103] = com.sulake.habbo.communication.messages.outgoing.room.engine.ViralTeaserFoundMessageComposer; 
        public const uint ViralTeaserFoundMessageEvent = 3103;

        // _-2Pf[3110] = com.sulake.habbo.communication.messages.outgoing.users.GetMOTDMessageComposer; 
        public const uint GetMOTDMessageEvent = 3110;

        // _-2Pf[3105] = com.sulake.habbo.communication.messages.outgoing.users.GetUserNotificationsMessageComposer; 
        public const uint GetUserNotificationsMessageEvent = 3105;

        // _-2Pf[211] = com.sulake.habbo.communication.messages.outgoing.room.session.ChangeQueueMessageComposer; 
        public const uint ChangeQueueMessageEvent = 211;

        // _-2Pf[341] = com.sulake.habbo.communication.messages.outgoing.room.furniture.RoomDimmerGetPresetsMessageComposer; 
        public const uint RoomDimmerGetPresetsMessageEvent = 341;

        // _-2Pf[342] = com.sulake.habbo.communication.messages.outgoing.room.furniture.RoomDimmerSavePresetMessageComposer; 
        public const uint RoomDimmerSavePresetMessageEvent = 342;

        // _-2Pf[343] = com.sulake.habbo.communication.messages.outgoing.room.furniture.RoomDimmerChangeStateMessageComposer; 
        public const uint RoomDimmerChangeStateMessageEvent = 343;

        // _-2Pf[393] = com.sulake.habbo.communication.messages.outgoing.room.engine.UseWallItemMessageComposer; 
        public const uint UseWallItemMessageEvent = 393;

        // _-2Pf[83] = com.sulake.habbo.communication.messages.outgoing.room.engine.GetItemDataMessageComposer; 
        public const uint GetItemDataMessageEvent = 83;

        // _-2Pf[84] = com.sulake.habbo.communication.messages.outgoing.room.engine.SetItemDataMessageComposer; 
        public const uint SetItemDataMessageEvent = 84;

        // _-2Pf[85] = com.sulake.habbo.communication.messages.outgoing.room.engine.RemoveItemMessageComposer; 
        public const uint RemoveItemMessageEvent = 85;

        // _-2Pf[3104] = com.sulake.habbo.communication.messages.outgoing.room.furniture.ViralFurniStatusMessageComposer; 
        public const uint ViralFurniStatusMessageEvent = 3104;

        // _-2Pf[3001] = com.sulake.habbo.communication.messages.outgoing.room.pets.GetPetInfoMessageComposer; 
        public const uint GetPetInfoMessageEvent = 3001;

        // _-2Pf[215] = com.sulake.habbo.communication.messages.outgoing.room.engine.GetFurnitureAliasesMessageComposer; 
        public const uint GetFurnitureAliasesMessageEvent = 215;

        // _-2Pf[53] = com.sulake.habbo.communication.messages.outgoing.room.session.QuitMessageComposer; 
        public const uint QuitMessageEvent = 53;

        // _-2Pf[3254] = com.sulake.habbo.communication.messages.outgoing.room.furniture.PlacePostItMessageComposer; 
        public const uint PlacePostItMessageEvent = 3254;

        // _-2Pf[3255] = com.sulake.habbo.communication.messages.outgoing.room.furniture.AddSpamWallPostItMessageComposer; 
        public const uint AddSpamWallPostItMessageEvent = 3255;

        // _-2Pf[93] = com.sulake.habbo.communication.messages.outgoing.room.avatar.DanceMessageComposer; 
        public const uint DanceMessageEvent = 93;

        // _-2Pf[94] = com.sulake.habbo.communication.messages.outgoing.room.avatar.WaveMessageComposer; 
        public const uint WaveMessageEvent = 94;

        // _-2Pf[79] = com.sulake.habbo.communication.messages.outgoing.room.avatar.LookToMessageComposer; 
        public const uint LookToMessageEvent = 79;

        // _-2Pf[76] = com.sulake.habbo.communication.messages.outgoing.room.furniture.ThrowDiceMessageComposer; 
        public const uint ThrowDiceMessageEvent = 76;

        // _-2Pf[77] = com.sulake.habbo.communication.messages.outgoing.room.furniture.DiceOffMessageComposer; 
        public const uint DiceOffMessageEvent = 77;

        // _-2Pf[78] = com.sulake.habbo.communication.messages.outgoing.room.furniture.PresentOpenMessageComposer; 
        public const uint PresentOpenMessageEvent = 78;

        // _-2Pf[183] = com.sulake.habbo.communication.messages.outgoing.room.furniture.CreditFurniRedeemMessageComposer; 
        public const uint CreditFurniRedeemMessageEvent = 183;

        // _-2Pf[232] = com.sulake.habbo.communication.messages.outgoing.room.furniture.EnterOneWayDoorMessageComposer; 
        public const uint EnterOneWayDoorMessageEvent = 232;

        // _-2Pf[247] = com.sulake.habbo.communication.messages.outgoing.room.furniture.SpinWheelOfFortuneMessageComposer; 
        public const uint SpinWheelOfFortuneMessageEvent = 247;

        // _-2Pf[314] = com.sulake.habbo.communication.messages.outgoing.room.furniture.SetRandomStateMessageComposer; 
        public const uint SetRandomStateMessageEvent = 314;

        // _-2Pf[480] = com.sulake.habbo.communication.messages.outgoing.room.engine.SetClothingChangeDataMessageComposer; 
        public const uint SetClothingChangeDataMessageEvent = 480;

        // _-2Pf[3100] = com.sulake.habbo.communication.messages.outgoing.room.furniture.QuestVendingWallItemMessageComposer; 
        public const uint QuestVendingWallItemMessageEvent = 3100;

        // _-2Pf[3006] = com.sulake.habbo.communication.messages.outgoing.room.furniture.OpenPetPackageMessageComposer; 
        public const uint OpenPetPackageMessageEvent = 3006;

        // _-2Pf[3252] = com.sulake.habbo.communication.messages.outgoing.room.furniture.OpenWelcomeGiftComposer; 
        public const uint OpenWelcomeGiftEvent = 3252;

        // _-2Pf[95] = com.sulake.habbo.communication.messages.outgoing.room.action.KickUserMessageComposer; 
        public const uint KickUserMessageEvent = 95;

        // _-2Pf[96] = com.sulake.habbo.communication.messages.outgoing.room.action.AssignRightsMessageComposer; 
        public const uint AssignRightsMessageEvent = 96;

        // _-2Pf[97] = com.sulake.habbo.communication.messages.outgoing.room.action.RemoveRightsMessageComposer; 
        public const uint RemoveRightsMessageEvent = 97;

        // _-2Pf[98] = com.sulake.habbo.communication.messages.outgoing.room.action.LetUserInMessageComposer; 
        public const uint LetUserInMessageEvent = 98;

        // _-2Pf[155] = com.sulake.habbo.communication.messages.outgoing.room.action.RemoveAllRightsMessageComposer; 
        public const uint RemoveAllRightsMessageEvent = 155;

        // _-2Pf[320] = com.sulake.habbo.communication.messages.outgoing.room.action.BanUserMessageComposer; 
        public const uint BanUserMessageEvent = 320;

        // _-2Pf[440] = com.sulake.habbo.communication.messages.outgoing.room.action.CallGuideBotMessageComposer; 
        public const uint CallGuideBotMessageEvent = 440;

        // _-2Pf[441] = com.sulake.habbo.communication.messages.outgoing.room.action.KickBotMessageComposer; 
        public const uint KickBotMessageEvent = 441;

        // _-2Pf[263] = com.sulake.habbo.communication.messages.outgoing.users.GetUserTagsMessageComposer; 
        public const uint GetUserTagsMessageEvent = 263;

        // _-2Pf[159] = com.sulake.habbo.communication.messages.outgoing.users.GetSelectedBadgesMessageComposer; 
        public const uint GetSelectedBadgesMessageEvent = 159;

        // _-2Pf[215] = com.sulake.habbo.communication.messages.outgoing.users.GetHabboGroupBadgesMessageComposer; 
        public const uint GetHabboGroupBadgesMessageEvent = 230;

        // _-2Pf[231] = com.sulake.habbo.communication.messages.outgoing.users.GetHabboGroupDetailsMessageComposer; 
        public const uint GetHabboGroupDetailsMessageEvent = 231;

        // _-2Pf[319] = com.sulake.habbo.communication.messages.outgoing.users.IgnoreUserMessageComposer; 
        public const uint IgnoreUserMessageEvent = 319;

        // _-2Pf[321] = com.sulake.habbo.communication.messages.outgoing.users.GetIgnoredUsersMessageComposer; 
        public const uint GetIgnoredUsersMessageEvent = 321;

        // _-2Pf[322] = com.sulake.habbo.communication.messages.outgoing.users.UnignoreUserMessageComposer; 
        public const uint UnignoreUserMessageEvent = 322;

        // _-2Pf[371] = com.sulake.habbo.communication.messages.outgoing.users.RespectUserMessageComposer; 
        public const uint RespectUserMessageEvent = 371;

        // _-2Pf[3005] = com.sulake.habbo.communication.messages.outgoing.room.pets.RespectPetMessageComposer; 
        public const uint RespectPetMessageEvent = 3005;

        // _-2Pf[450] = com.sulake.habbo.communication.messages.outgoing.moderator.PickIssuesMessageComposer; 
        public const uint PickIssuesMessageEvent = 450;

        // _-2Pf[451] = com.sulake.habbo.communication.messages.outgoing.moderator.ReleaseIssuesMessageComposer; 
        public const uint ReleaseIssuesMessageEvent = 451;

        // _-2Pf[452] = com.sulake.habbo.communication.messages.outgoing.moderator.CloseIssuesMessageComposer; 
        public const uint CloseIssuesMessageEvent = 452;

        // _-2Pf[454] = com.sulake.habbo.communication.messages.outgoing.moderator.GetModeratorUserInfoMessageComposer; 
        public const uint GetModeratorUserInfoMessageEvent = 454;

        // _-2Pf[455] = com.sulake.habbo.communication.messages.outgoing.moderator.GetUserChatlogMessageComposer; 
        public const uint GetUserChatlogMessageEvent = 455;

        // _-2Pf[456] = com.sulake.habbo.communication.messages.outgoing.moderator.GetRoomChatlogMessageComposer; 
        public const uint GetRoomChatlogMessageEvent = 456;

        // _-2Pf[457] = com.sulake.habbo.communication.messages.outgoing.moderator.GetCfhChatlogMessageComposer; 
        public const uint GetCfhChatlogMessageEvent = 457;

        // _-2Pf[458] = com.sulake.habbo.communication.messages.outgoing.moderator.GetRoomVisitsMessageComposer; 
        public const uint GetRoomVisitsMessageEvent = 458;

        // _-2Pf[459] = com.sulake.habbo.communication.messages.outgoing.moderator.GetModeratorRoomInfoMessageComposer; 
        public const uint GetModeratorRoomInfoMessageEvent = 459;

        // _-2Pf[460] = com.sulake.habbo.communication.messages.outgoing.moderator.ModerateRoomMessageComposer; 
        public const uint ModerateRoomMessageEvent = 460;

        // _-2Pf[461] = com.sulake.habbo.communication.messages.outgoing.moderator.ModAlertMessageComposer; 
        public const uint ModAlertMessageEvent = 461;

        // _-2Pf[462] = com.sulake.habbo.communication.messages.outgoing.moderator.ModMessageMessageComposer; 
        public const uint ModMessageMessageEvent = 462;

        // _-2Pf[463] = com.sulake.habbo.communication.messages.outgoing.moderator.ModKickMessageComposer; 
        public const uint ModKickMessageEvent = 463;

        // _-2Pf[464] = com.sulake.habbo.communication.messages.outgoing.moderator.ModBanMessageComposer; 
        public const uint ModBanMessageEvent = 464;

        // _-2Pf[200] = com.sulake.habbo.communication.messages.outgoing.moderator.ModeratorActionMessageComposer; 
        public const uint ModeratorActionMessageEvent = 200;

        // _-2Pf[453] = com.sulake.habbo.communication.messages.outgoing.help.CallForHelpMessageComposer; 
        public const uint CallForHelpMessageEvent = 453;

        // _-2Pf[237] = com.sulake.habbo.communication.messages.outgoing.help.GetPendingCallsForHelpMessageComposer; 
        public const uint GetPendingCallsForHelpMessageEvent = 237;

        // _-2Pf[238] = com.sulake.habbo.communication.messages.outgoing.help.DeletePendingCallsForHelpMessageComposer; 
        public const uint DeletePendingCallsForHelpMessageEvent = 238;

        // _-2Pf[416] = com.sulake.habbo.communication.messages.outgoing.help.GetClientFaqsMessageComposer; 
        public const uint GetClientFaqsMessageEvent = 416;

        // _-2Pf[417] = com.sulake.habbo.communication.messages.outgoing.help.GetFaqCategoriesMessageComposer; 
        public const uint GetFaqCategoriesMessageEvent = 417;

        // _-2Pf[418] = com.sulake.habbo.communication.messages.outgoing.help.GetFaqTextMessageComposer; 
        public const uint GetFaqTextMessageEvent = 418;

        // _-2Pf[419] = com.sulake.habbo.communication.messages.outgoing.help.SearchFaqsMessageComposer; 
        public const uint SearchFaqsMessageEvent = 419;

        // _-2Pf[420] = com.sulake.habbo.communication.messages.outgoing.help.GetFaqCategoryMessageComposer; 
        public const uint GetFaqCategoryMessageEvent = 420;

        // _-2Pf[3253] = com.sulake.habbo.communication.messages.outgoing.users.ChangeEmailComposer; 
        public const uint ChangeEmailEvent = 3253;

        // _-2Pf[26] = com.sulake.habbo.communication.messages.outgoing.users.ScrGetUserInfoMessageComposer; 
        public const uint ScrGetUserInfoMessageEvent = 26;

        // _-2Pf[481] = com.sulake.habbo.communication.messages.outgoing.users.GetAchievementShareIdComposer; 
        public const uint GetAchievementShareIdEvent = 481;

        // _-2Pf[3111] = com.sulake.habbo.communication.messages.outgoing.notifications.ResetUnseenItemsComposer; 
        public const uint ResetUnseenItemsEvent = 3111;

        // _-2Pf[100] = com.sulake.habbo.communication.messages.outgoing.catalog.PurchaseFromCatalogComposer; 
        public const uint PurchaseFromCatalogEvent = 100;

        // _-2Pf[472] = com.sulake.habbo.communication.messages.outgoing.catalog.PurchaseFromCatalogAsGiftComposer; 
        public const uint PurchaseFromCatalogAsGiftEvent = 472;

        // _-2Pf[473] = com.sulake.habbo.communication.messages.outgoing.catalog.GetGiftWrappingConfigurationComposer; 
        public const uint GetGiftWrappingConfigurationEvent = 473;

        // _-2Pf[475] = com.sulake.habbo.communication.messages.outgoing.catalog.SelectClubGiftComposer; 
        public const uint SelectClubGiftEvent = 475;

        // _-2Pf[101] = com.sulake.habbo.communication.messages.outgoing.catalog.GetCatalogIndexComposer; 
        public const uint GetCatalogIndexEvent = 101;

        // _-2Pf[102] = com.sulake.habbo.communication.messages.outgoing.catalog.GetCatalogPageComposer; 
        public const uint GetCatalogPageEvent = 102;

        // _-2Pf[129] = com.sulake.habbo.communication.messages.outgoing.catalog.RedeemVoucherMessageComposer; 
        public const uint RedeemVoucherMessageEvent = 129;

        // _-2Pf[3030] = com.sulake.habbo.communication.messages.outgoing.catalog.GetIsOfferGiftableComposer; 
        public const uint GetIsOfferGiftableEvent = 3030;

        // _-2Pf[3031] = com.sulake.habbo.communication.messages.outgoing.catalog.GetClubOffersMessageComposer; 
        public const uint GetClubOffersMessageEvent = 3031;

        // _-2Pf[3007] = com.sulake.habbo.communication.messages.outgoing.catalog.GetSellablePetBreedsComposer; 
        public const uint GetSellablePetBreedsEvent = 3007;

        // _-2Pf[3034] = com.sulake.habbo.communication.messages.outgoing.catalog.MarkCatalogNewAdditionsPageOpenedComposer; 
        public const uint MarkCatalogNewAdditionsPageOpenedEvent = 3034;

        // _-2Pf[3035] = com.sulake.habbo.communication.messages.outgoing.catalog.GetHabboClubExtendOfferMessageComposer; 
        public const uint GetHabboClubExtendOfferMessageEvent = 3035;

        // _-2Pf[3036] = com.sulake.habbo.communication.messages.outgoing.catalog.PurchaseVipMembershipExtensionComposer; 
        public const uint PurchaseVipMembershipExtensionEvent = 3036;

        // _-2Pf[3037] = com.sulake.habbo.communication.messages.outgoing.catalog.PurchaseBasicMembershipExtensionComposer; 
        public const uint PurchaseBasicMembershipExtensionEvent = 3037;

        // _-2Pf[3038] = com.sulake.habbo.communication.messages.outgoing.catalog.GetHabboBasicMembershipExtendOfferComposer; 
        public const uint GetHabboBasicMembershipExtendOfferEvent = 3038;

        // _-2Pf[412] = com.sulake.habbo.communication.messages.outgoing.recycler.GetRecyclerPrizesMessageComposer; 
        public const uint GetRecyclerPrizesMessageEvent = 412;

        // _-2Pf[413] = com.sulake.habbo.communication.messages.outgoing.recycler.GetRecyclerStatusMessageComposer; 
        public const uint GetRecyclerStatusMessageEvent = 413;

        // _-2Pf[414] = com.sulake.habbo.communication.messages.outgoing.recycler.RecycleItemsMessageComposer; 
        public const uint RecycleItemsMessageEvent = 414;

        // _-2Pf[126] = com.sulake.habbo.communication.messages.outgoing.advertisement.GetRoomAdMessageComposer; 
        public const uint GetRoomAdMessageEvent = 126;

        // _-2Pf[182] = com.sulake.habbo.communication.messages.outgoing.advertisement.GetInterstitialMessageComposer; 
        public const uint GetInterstitialMessageEvent = 182;

        // _-2Pf[315] = com.sulake.habbo.communication.messages.outgoing.tracking.LatencyPingRequestMessageComposer; 
        public const uint LatencyPingRequestMessageEvent = 315;

        // _-2Pf[316] = com.sulake.habbo.communication.messages.outgoing.tracking.LatencyPingReportMessageComposer; 
        public const uint LatencyPingReportMessageEvent = 316;

        // _-2Pf[421] = com.sulake.habbo.communication.messages.outgoing.tracking.PerformanceLogMessageComposer; 
        public const uint PerformanceLogMessageEvent = 421;

        // _-2Pf[422] = com.sulake.habbo.communication.messages.outgoing.tracking.LagWarningReportMessageComposer; 
        public const uint LagWarningReportMessageEvent = 422;

        // _-2Pf[482] = com.sulake.habbo.communication.messages.outgoing.tracking.EventLogMessageComposer; 
        public const uint EventLogMessageEvent = 482;

        // _-2Pf[112] = com.sulake.habbo.communication.messages.outgoing.poll.VoteAnswerMessageComposer; 
        public const uint VoteAnswerMessageEvent = 112;

        // _-2Pf[235] = com.sulake.habbo.communication.messages.outgoing.poll.PollRejectComposer; 
        public const uint PollRejectEvent = 235;

        // _-2Pf[234] = com.sulake.habbo.communication.messages.outgoing.poll.PollStartComposer; 
        public const uint PollStartEvent = 234;

        // _-2Pf[236] = com.sulake.habbo.communication.messages.outgoing.poll.PollAnswerComposer; 
        public const uint PollAnswerEvent = 236;

        // _-2Pf[108] = com.sulake.habbo.communication.messages.outgoing.room.publicroom.ExitLockerRoomMessageComposer; 
        public const uint ExitLockerRoomMessageEvent = 108;

        // _-2Pf[111] = com.sulake.habbo.communication.messages.outgoing.room.publicroom.ChangeRoomMessageComposer; 
        public const uint ChangeRoomMessageEvent = 111;

        // _-2Pf[113] = com.sulake.habbo.communication.messages.outgoing.room.publicroom.TryBusMessageComposer; 
        public const uint TryBusMessageEvent = 113;

        // _-2Pf[42] = com.sulake.habbo.communication.messages.outgoing.users.ApproveNameMessageComposer; 
        public const uint ApproveNameMessageEvent = 42;

        // _-2Pf[245] = com.sulake.habbo.communication.messages.outgoing.sound.GetSoundMachinePlayListMessageComposer; 
        public const uint GetSoundMachinePlayListMessageEvent = 245;

        // _-2Pf[249] = com.sulake.habbo.communication.messages.outgoing.sound.GetNowPlayingMessageComposer; 
        public const uint GetNowPlayingMessageEvent = 249;

        // _-2Pf[221] = com.sulake.habbo.communication.messages.outgoing.sound.GetSongInfoMessageComposer; 
        public const uint GetSongInfoMessageEvent = 221;

        // _-2Pf[228] = com.sulake.habbo.communication.messages.outgoing.sound.GetSoundSettingsComposer; 
        public const uint GetSoundSettingsEvent = 228;

        // _-2Pf[229] = com.sulake.habbo.communication.messages.outgoing.sound.SetSoundSettingsComposer; 
        public const uint SetSoundSettingsEvent = 229;

        // _-2Pf[0xFF] = com.sulake.habbo.communication.messages.outgoing.sound.AddJukeboxDiskComposer; 
        public const uint AddJukeboxDiskEvent = 0xFF;

        // _-2Pf[0x0100] = com.sulake.habbo.communication.messages.outgoing.sound.RemoveJukeboxDiskComposer; 
        public const uint RemoveJukeboxDiskEvent = 0x0100;

        // _-2Pf[258] = com.sulake.habbo.communication.messages.outgoing.sound.GetJukeboxPlayListMessageComposer; 
        public const uint GetJukeboxPlayListMessageEvent = 258;

        // _-2Pf[259] = com.sulake.habbo.communication.messages.outgoing.sound.GetUserSongDisksMessageComposer; 
        public const uint GetUserSongDisksMessageEvent = 259;

        // _-2Pf[375] = com.sulake.habbo.communication.messages.outgoing.avatar.GetWardrobeMessageComposer; 
        public const uint GetWardrobeMessageEvent = 375;

        // _-2Pf[376] = com.sulake.habbo.communication.messages.outgoing.avatar.SaveWardrobeOutfitMessageComposer; 
        public const uint SaveWardrobeOutfitMessageEvent = 376;

        // _-2Pf[470] = com.sulake.habbo.communication.messages.outgoing.avatar.ChangeUserNameMessageComposer; 
        public const uint ChangeUserNameMessageEvent = 470;

        // _-2Pf[471] = com.sulake.habbo.communication.messages.outgoing.avatar.CheckUserNameMessageComposer; 
        public const uint CheckUserNameMessageEvent = 471;

        // _-2Pf[44] = com.sulake.habbo.communication.messages.outgoing.register.UpdateFigureDataMessageComposer; 
        public const uint UpdateFigureDataMessageEvent = 44;

        // _-2Pf[3050] = com.sulake.habbo.communication.messages.outgoing.userdefinedroomevents.UpdateTriggerMessageComposer; 
        public const uint UpdateTriggerMessageEvent = 3050;

        // _-2Pf[3051] = com.sulake.habbo.communication.messages.outgoing.userdefinedroomevents.UpdateActionMessageComposer; 
        public const uint UpdateActionMessageEvent = 3051;

        // _-2Pf[3052] = com.sulake.habbo.communication.messages.outgoing.userdefinedroomevents.UpdateConditionMessageComposer; 
        public const uint UpdateConditionMessageEvent = 3052;

        // _-2Pf[3053] = com.sulake.habbo.communication.messages.outgoing.userdefinedroomevents.OpenMessageComposer; 
        public const uint OpenMessageEvent = 3053;

        // _-2Pf[3054] = com.sulake.habbo.communication.messages.outgoing.userdefinedroomevents.ApplySnapshotMessageComposer; 
        public const uint ApplySnapshotMessageEvent = 3054;

        // _-2Pf[3101] = com.sulake.habbo.communication.messages.outgoing.quest.GetQuestsMessageComposer; 
        public const uint GetQuestsMessageEvent = 3101;

        // _-2Pf[3102] = com.sulake.habbo.communication.messages.outgoing.quest.AcceptQuestMessageComposer; 
        public const uint AcceptQuestMessageEvent = 3102;

        // _-2Pf[3106] = com.sulake.habbo.communication.messages.outgoing.quest.RejectQuestMessageComposer; 
        public const uint RejectQuestMessageEvent = 3106;

        // _-2Pf[3107] = com.sulake.habbo.communication.messages.outgoing.quest.OpenQuestTrackerMessageComposer; 
        public const uint OpenQuestTrackerMessageEvent = 3107;

        // _-2Pf[3108] = com.sulake.habbo.communication.messages.outgoing.quest.StartCampaignMessageComposer; 
        public const uint StartCampaignMessageEvent = 3108;

        // _-2Pf[3210] = com.sulake.habbo.communication.messages.outgoing.quest.FriendRequestQuestCompleteMessageComposer; 
        public const uint FriendRequestQuestCompleteMessageEvent = 3210;

        // _-2Pf[3300] = com.sulake.habbo.communication.messages.outgoing.facebook.FaceBookIsLoggedOnMessageComposer; 
        public const uint FaceBookIsLoggedOnMessageEvent = 3300;

        // _-2Pf[3301] = com.sulake.habbo.communication.messages.outgoing.facebook.FaceBookIsLoggedOffMessageComposer; 
        public const uint FaceBookIsLoggedOffMessageEvent = 3301;

        // _-2Pf[3311] = com.sulake.habbo.communication.messages.outgoing.facebook.FaceBookInitiateAddFriendsMessageComposer; 
        public const uint FaceBookInitiateAddFriendsMessageEvent = 3311;
    }
}
