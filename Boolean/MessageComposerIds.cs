using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boolean
{
    static class MessageComposerIds
    {
        //	_events[1] = com.sulake.habbo.communication.messages.incoming.handshake.SecretKeyEvent; 
        public const uint SecretKeyComposer = 1;

        // _events[277] = com.sulake.habbo.communication.messages.incoming.handshake.InitCryptoMessageEvent; 
        public const uint InitCryptoMessageComposer = 277;

        // _events[0x0101] = com.sulake.habbo.communication.messages.incoming.handshake.SessionParamsMessageEvent; 
        public const uint SessionParamsMessageComposer = 257; // 0x0101

        // _events[2] = com.sulake.habbo.communication.messages.incoming.handshake.UserRightsMessageEvent; 
        public const uint UserRightsMessageComposer = 2;

        // _events[3] = com.sulake.habbo.communication.messages.incoming.handshake.AuthenticationOKMessageEvent; 
        public const uint AuthenticationOKMessageComposer = 3;

        // _events[50] = com.sulake.habbo.communication.messages.incoming.handshake.PingMessageEvent; 
        public const uint PingMessageComposer = 50;

        // _events[5] = com.sulake.habbo.communication.messages.incoming.handshake.UserObjectEvent; 
        public const uint UserObjectComposer = 5;

        // _events[439] = com.sulake.habbo.communication.messages.incoming.handshake.UniqueMachineIDEvent; 
        public const uint UniqueMachineIDComposer = 439;

        // _events[33] = com.sulake.habbo.communication.messages.incoming.handshake.GenericErrorEvent; 
        public const uint GenericErrorComposer = 33;

        // _events[287] = com.sulake.habbo.communication.messages.incoming.handshake.DisconnectReasonEvent; 
        public const uint DisconnectReasonComposer = 287;

        // _events[626] = com.sulake.habbo.communication.messages.incoming.handshake.IdentityAccountsEvent; 
        public const uint IdentityAccountsComposer = 626;

        // _events[290] = com.sulake.habbo.communication.messages.incoming.availability.AvailabilityStatusMessageEvent; 
        public const uint AvailabilityStatusMessageComposer = 290;

        // _events[291] = com.sulake.habbo.communication.messages.incoming.availability.InfoHotelClosingMessageEvent; 
        public const uint InfoHotelClosingMessageComposer = 291;

        // _events[292] = com.sulake.habbo.communication.messages.incoming.availability.InfoHotelClosedMessageEvent; 
        public const uint InfoHotelClosedMessageComposer = 292;

        // _events[293] = com.sulake.habbo.communication.messages.incoming.availability.AvailabilityTimeMessageEvent; 
        public const uint AvailabilityTimeMessageComposer = 293;

        // _events[294] = com.sulake.habbo.communication.messages.incoming.availability.LoginFailedHotelClosedMessageEvent; 
        public const uint LoginFailedHotelClosedMessageComposer = 294;

        // _events[12] = com.sulake.habbo.communication.messages.incoming.friendlist.MessengerInitEvent; 
        public const uint MessengerInitComposer = 12;
        
        // _events[132] = com.sulake.habbo.communication.messages.incoming.friendlist.NewBuddyRequestEvent; 
        public const uint NewBuddyRequestComposer = 132;

        // _events[134] = com.sulake.habbo.communication.messages.incoming.friendlist.NewConsoleMessageEvent; 
        public const uint NewConsoleMessageComposer = 134;

        // _events[260] = com.sulake.habbo.communication.messages.incoming.friendlist.MessengerErrorEvent; 
        public const uint MessengerErrorComposer = 260;

        // _events[261] = com.sulake.habbo.communication.messages.incoming.friendlist.InstantMessageErrorEvent; 
        public const uint InstantMessageErrorComposer = 261;

        // _events[314] = com.sulake.habbo.communication.messages.incoming.friendlist.BuddyRequestsEvent; 
        public const uint BuddyRequestsComposer = 314;

        // _events[315] = com.sulake.habbo.communication.messages.incoming.friendlist.AcceptBuddyResultEvent; 
        public const uint AcceptBuddyResultComposer = 315;

        // _events[13] = com.sulake.habbo.communication.messages.incoming.friendlist.FriendListUpdateEvent; 
        public const uint FriendListUpdateComposer = 13;

        // _events[435] = com.sulake.habbo.communication.messages.incoming.friendlist.HabboSearchResultEvent; 
        public const uint HabboSearchResultComposer = 435;

        // _events[349] = com.sulake.habbo.communication.messages.incoming.friendlist.FollowFriendFailedEvent; 
        public const uint FollowFriendFailedComposer = 349;

        // _events[262] = com.sulake.habbo.communication.messages.incoming.friendlist.RoomInviteErrorEvent; 
        public const uint RoomInviteErrorComposer = 262;

        // _events[135] = com.sulake.habbo.communication.messages.incoming.friendlist.RoomInviteEvent; 
        public const uint RoomInviteComposer = 135;

        // _events[831] = com.sulake.habbo.communication.messages.incoming.friendlist.FindFriendsProcessResultEvent; 
        public const uint FindFriendsProcessResultComposer = 831;

        // _events[833] = com.sulake.habbo.communication.messages.incoming.friendlist.FriendNotificationEvent; 
        public const uint FriendNotificationComposer = 833;

        // _events[950] = com.sulake.habbo.communication.messages.incoming.friendlist.EventStreamEvent; 
        public const uint EventStreamComposer = 950;

        // _-2Pf[500] = com.sulake.habbo.communication.messages.outgoing.friendlist.GetEventStreamComposer; 
        public const uint GetEventStreamComposer = 500;

        // _-2Pf[501] = com.sulake.habbo.communication.messages.outgoing.friendlist.SetEventStreamingAllowedComposer; 
        public const uint SetEventStreamingAllowedComposer = 501;

        // _events[6] = com.sulake.habbo.communication.messages.incoming.inventory.purse.CreditBalanceEvent; 
        public const uint CreditBalanceComposer = 6;

        // _events[98] = com.sulake.habbo.communication.messages.incoming.inventory.furni.FurniListInsertEvent; 
        public const uint FurniListInsertComposer = 98;

        // _events[99] = com.sulake.habbo.communication.messages.incoming.inventory.furni.FurniListRemoveEvent; 
        public const uint FurniListRemoveComposer = 99;

        // _events[101] = com.sulake.habbo.communication.messages.incoming.inventory.furni.FurniListUpdateEvent; 
        public const uint FurniListUpdateComposer = 101;

        // _events[140] = com.sulake.habbo.communication.messages.incoming.inventory.furni.FurniListEvent; 
        public const uint FurniListComposer = 140;

        // _events[145] = com.sulake.habbo.communication.messages.incoming.inventory.furni.PostItPlacedEvent; 
        public const uint PostItPlacedComposer = 145;

        // _events[460] = com.sulake.habbo.communication.messages.incoming.inventory.avatareffect.AvatarEffectsMessageEvent; 
        public const uint AvatarEffectsMessageComposer = 460;

        // _events[461] = com.sulake.habbo.communication.messages.incoming.inventory.avatareffect.AvatarEffectAddedMessageEvent; 
        public const uint AvatarEffectAddedMessageComposer = 461;

        // _events[462] = com.sulake.habbo.communication.messages.incoming.inventory.avatareffect.AvatarEffectActivatedMessageEvent; 
        public const uint AvatarEffectActivatedMessageComposer = 462;

        // _events[463] = com.sulake.habbo.communication.messages.incoming.inventory.avatareffect.AvatarEffectExpiredMessageEvent; 
        public const uint AvatarEffectExpiredMessageComposer = 463;

        // _events[464] = com.sulake.habbo.communication.messages.incoming.inventory.avatareffect.AvatarEffectSelectedMessageEvent; 
        public const uint AvatarEffectSelectedMessageComposer = 464;

        // _events[229] = com.sulake.habbo.communication.messages.incoming.inventory.badges.BadgesEvent; 
        public const uint BadgesComposer = 229;

        // _events[627] = com.sulake.habbo.communication.messages.incoming.inventory.badges.BadgePointLimitsEvent; 
        public const uint BadgePointLimitsComposer = 627;

        // _events[436] = com.sulake.habbo.communication.messages.incoming.inventory.achievements.AchievementsEvent; 
        public const uint AchievementsComposer = 436;

        // _events[443] = com.sulake.habbo.communication.messages.incoming.inventory.achievements.AchievementsScoreEvent; 
        public const uint AchievementsScoreComposer = 443;

        // _events[913] = com.sulake.habbo.communication.messages.incoming.inventory.achievements.AchievementEvent; 
        public const uint AchievementComposer = 913;

        // _events[102] = com.sulake.habbo.communication.messages.incoming.inventory.trading.TradingYouAreNotAllowedEvent; 
        public const uint TradingYouAreNotAllowedComposer = 102;

        // _events[103] = com.sulake.habbo.communication.messages.incoming.inventory.trading.TradingOtherNotAllowedEvent; 
        public const uint TradingOtherNotAllowedComposer = 103;

        // _events[104] = com.sulake.habbo.communication.messages.incoming.inventory.trading.TradingOpenEvent; 
        public const uint TradingOpenComposer = 104;

        // _events[105] = com.sulake.habbo.communication.messages.incoming.inventory.trading.TradingAlreadyOpenEvent; 
        public const uint TradingAlreadyOpenComposer = 105;

        // _events[106] = com.sulake.habbo.communication.messages.incoming.inventory.trading.TradingNotOpenEvent; 
        public const uint TradingNotOpenComposer = 106;

        // _events[107] = com.sulake.habbo.communication.messages.incoming.inventory.trading.TradingNoSuchItemEvent; 
        public const uint TradingNoSuchItemComposer = 107;

        // _events[108] = com.sulake.habbo.communication.messages.incoming.inventory.trading.TradingItemListEvent; 
        public const uint TradingItemListComposer = 108;

        // _events[109] = com.sulake.habbo.communication.messages.incoming.inventory.trading.TradingAcceptEvent; 
        public const uint TradingAcceptComposer = 109;

        // _events[110] = com.sulake.habbo.communication.messages.incoming.inventory.trading.TradingCloseEvent; 
        public const uint TradingCloseComposer = 110;

        // _events[111] = com.sulake.habbo.communication.messages.incoming.inventory.trading.TradingConfirmationEvent; 
        public const uint TradingConfirmationComposer = 111;

        // _events[112] = com.sulake.habbo.communication.messages.incoming.inventory.trading.TradingCompletedEvent; 
        public const uint TradingCompletedComposer = 112;

        // _events[600] = com.sulake.habbo.communication.messages.incoming.inventory.pets.PetInventoryEvent; 
        public const uint PetInventoryComposer = 600;

        // _events[603] = com.sulake.habbo.communication.messages.incoming.inventory.pets.PetAddedToInventoryEvent; 
        public const uint PetAddedToInventoryComposer = 603;

        // _events[604] = com.sulake.habbo.communication.messages.incoming.inventory.pets.PetRemovedFromInventoryEvent; 
        public const uint PetRemovedFromInventoryComposer = 604;

        // _events[607] = com.sulake.habbo.communication.messages.incoming.inventory.pets.PetReceivedMessageEvent; 
        public const uint PetReceivedMessageComposer = 607;

        // _events[612] = com.sulake.habbo.communication.messages.incoming.marketplace.MarketplaceConfigurationEvent; 
        public const uint MarketplaceConfigurationComposer = 612;

        // _events[613] = com.sulake.habbo.communication.messages.incoming.marketplace.MarketplaceBuyOfferResultEvent; 
        public const uint MarketplaceBuyOfferResultComposer = 613;

        // _events[614] = com.sulake.habbo.communication.messages.incoming.marketplace.MarketplaceCancelOfferResultEvent; 
        public const uint MarketplaceCancelOfferResultComposer = 614;

        // _events[615] = com.sulake.habbo.communication.messages.incoming.marketplace.MarketPlaceOffersEvent; 
        public const uint MarketPlaceOffersComposer = 615;

        // _events[616] = com.sulake.habbo.communication.messages.incoming.marketplace.MarketPlaceOwnOffersEvent; 
        public const uint MarketPlaceOwnOffersComposer = 616;

        // _events[617] = com.sulake.habbo.communication.messages.incoming.marketplace.MarketplaceItemStatsEvent; 
        public const uint MarketplaceItemStatsComposer = 617;

        // _events[221] = com.sulake.habbo.communication.messages.incoming.navigator.UserFlatCatsEvent; 
        public const uint UserFlatCatsComposer = 221;

        // _events[222] = com.sulake.habbo.communication.messages.incoming.navigator.FlatCatEvent; 
        public const uint FlatCatComposer = 222;

        // _events[367] = com.sulake.habbo.communication.messages.incoming.navigator.CanCreateRoomEventEvent; 
        public const uint CanCreateRoomEventComposer = 367;

        // _events[370] = com.sulake.habbo.communication.messages.incoming.navigator.RoomEventEvent; 
        public const uint RoomEventComposer = 370;

        // _-2Pf[345] = com.sulake.habbo.communication.messages.outgoing.navigator.CanCreateEventMessageComposer; 
        public const uint CanCreateEventMessageComposer = 345;

        // _-2Pf[346] = com.sulake.habbo.communication.messages.outgoing.navigator.CreateEventMessageComposer; 
        public const uint CreateEventMessageComposer = 346;

        // _-2Pf[347] = com.sulake.habbo.communication.messages.outgoing.navigator.CancelEventMessageComposer; 
        public const uint CancelEventMessageComposer = 347;

        // _-2Pf[348] = com.sulake.habbo.communication.messages.outgoing.navigator.EditEventMessageComposer; 
        public const uint EditEventMessageComposer = 348;

        // _events[91] = com.sulake.habbo.communication.messages.incoming.navigator.DoorbellMessageEvent; 
        public const uint DoorbellMessageComposer = 91;

        // _events[131] = com.sulake.habbo.communication.messages.incoming.navigator.FlatAccessDeniedMessageEvent; 
        public const uint FlatAccessDeniedMessageComposer = 131;

        // _events[465] = com.sulake.habbo.communication.messages.incoming.roomsettings.RoomSettingsDataEvent; 
        public const uint RoomSettingsDataComposer = 465;

        // _events[466] = com.sulake.habbo.communication.messages.incoming.roomsettings.RoomSettingsErrorEvent; 
        public const uint RoomSettingsErrorComposer = 466;

        // _events[467] = com.sulake.habbo.communication.messages.incoming.roomsettings.RoomSettingsSavedEvent; 
        public const uint RoomSettingsSavedComposer = 467;

        // _events[468] = com.sulake.habbo.communication.messages.incoming.roomsettings.RoomSettingsSaveErrorEvent; 
        public const uint RoomSettingsSaveErrorComposer = 468;

        // _events[44] = com.sulake.habbo.communication.messages.incoming.roomsettings.NoSuchFlatEvent; 
        public const uint NoSuchFlatComposer = 44;

        // _events[450] = com.sulake.habbo.communication.messages.incoming.navigator.OfficialRoomsEvent; 
        public const uint OfficialRoomsComposer = 450;

        // _events[451] = com.sulake.habbo.communication.messages.incoming.navigator.GuestRoomSearchResultEvent; 
        public const uint GuestRoomSearchResultComposer = 451;

        // _events[452] = com.sulake.habbo.communication.messages.incoming.navigator.PopularRoomTagsResultEvent; 
        public const uint PopularRoomTagsResultComposer = 452;

        // _events[453] = com.sulake.habbo.communication.messages.incoming.navigator.PublicSpaceCastLibsEvent; 
        public const uint PublicSpaceCastLibsComposer = 453;

        // _events[454] = com.sulake.habbo.communication.messages.incoming.navigator.GetGuestRoomResultEvent; 
        public const uint GetGuestRoomResultComposer = 454;

        // _events[455] = com.sulake.habbo.communication.messages.incoming.navigator.NavigatorSettingsEvent; 
        public const uint NavigatorSettingsComposer = 455;

        // _events[456] = com.sulake.habbo.communication.messages.incoming.navigator.RoomInfoUpdatedEvent; 
        public const uint RoomInfoUpdatedComposer = 456;

        // _events[457] = com.sulake.habbo.communication.messages.incoming.navigator.RoomThumbnailUpdateResultEvent; 
        public const uint RoomThumbnailUpdateResultComposer = 457;

        // _events[458] = com.sulake.habbo.communication.messages.incoming.navigator.FavouritesEvent; 
        public const uint FavouritesComposer = 458;

        // _events[459] = com.sulake.habbo.communication.messages.incoming.navigator.FavouriteChangedEvent; 
        public const uint FavouriteChangedComposer = 459;

        // _events[59] = com.sulake.habbo.communication.messages.incoming.navigator.FlatCreatedEvent; 
        public const uint FlatCreatedComposer = 59;

        // _events[345] = com.sulake.habbo.communication.messages.incoming.navigator.RoomRatingEvent; 
        public const uint RoomRatingComposer = 345;

        // _events[510] = com.sulake.habbo.communication.messages.incoming.roomsettings.FlatControllerAddedEvent; 
        public const uint FlatControllerAddedComposer = 510;

        // _events[511] = com.sulake.habbo.communication.messages.incoming.roomsettings.FlatControllerRemovedEvent; 
        public const uint FlatControllerRemovedComposer = 511;

        // _events[0x0200] = com.sulake.habbo.communication.messages.incoming.navigator.CanCreateRoomEvent; 
        public const uint CanCreateRoomComposer = 0x0200;

        // _-2Pf[439] = com.sulake.habbo.communication.messages.outgoing.navigator.LatestEventsSearchMessageComposer; 
        public const uint LatestEventsSearchMessageComposer = 439;

        // _events[18] = com.sulake.habbo.communication.messages.incoming.room.session.CloseConnectionMessageEvent; 
        public const uint CloseConnectionMessageComposer = 18;

        // _events[19] = com.sulake.habbo.communication.messages.incoming.room.session.OpenConnectionMessageEvent; 
        public const uint OpenConnectionMessageComposer = 19;

        // _events[259] = com.sulake.habbo.communication.messages.incoming.room.session.RoomQueueStatusMessageEvent; 
        public const uint RoomQueueStatusMessageComposer = 259;

        // _events[286] = com.sulake.habbo.communication.messages.incoming.room.session.RoomForwardMessageEvent; 
        public const uint RoomForwardMessageComposer = 286;

        // _events[24] = com.sulake.habbo.communication.messages.incoming.room.chat.ChatMessageEvent; 
        public const uint ChatMessageComposer = 24;

        // _events[25] = com.sulake.habbo.communication.messages.incoming.room.chat.WhisperMessageEvent; 
        public const uint WhisperMessageComposer = 25;

        // _events[26] = com.sulake.habbo.communication.messages.incoming.room.chat.ShoutMessageEvent; 
        public const uint ShoutMessageComposer = 26;

        // _events[361] = com.sulake.habbo.communication.messages.incoming.room.chat.UserTypingMessageEvent; 
        public const uint UserTypingMessageComposer = 361;

        // _events[27] = com.sulake.habbo.communication.messages.incoming.room.chat.FloodControlMessageEvent; 
        public const uint FloodControlMessageComposer = 27;

        // _events[41] = com.sulake.habbo.communication.messages.incoming.room.session.FlatAccessibleMessageEvent; 
        public const uint FlatAccessibleMessageComposer = 41;

        // _events[69] = com.sulake.habbo.communication.messages.incoming.room.session.RoomReadyMessageEvent; 
        public const uint RoomReadyMessageComposer = 69;

        // _events[28] = com.sulake.habbo.communication.messages.incoming.room.engine.UsersMessageEvent; 
        public const uint UsersMessageComposer = 28;

        // _events[29] = com.sulake.habbo.communication.messages.incoming.room.engine.UserRemoveMessageEvent; 
        public const uint UserRemoveMessageComposer = 29;

        // _events[31] = com.sulake.habbo.communication.messages.incoming.room.engine.HeightMapMessageEvent; 
        public const uint HeightMapMessageComposer = 31;

        // _events[32] = com.sulake.habbo.communication.messages.incoming.room.engine.ObjectsMessageEvent; 
        public const uint ObjectsMessageComposer = 32;

        // _events[34] = com.sulake.habbo.communication.messages.incoming.room.engine.UserUpdateMessageEvent; 
        public const uint UserUpdateMessageComposer = 34;

        // _events[45] = com.sulake.habbo.communication.messages.incoming.room.engine.ItemsMessageEvent; 
        public const uint ItemsMessageComposer = 45;

        // _events[48] = com.sulake.habbo.communication.messages.incoming.room.engine.ItemDataUpdateMessageEvent; 
        public const uint ItemDataUpdateMessageComposer = 48;

        // _events[83] = com.sulake.habbo.communication.messages.incoming.room.engine.ItemAddMessageEvent; 
        public const uint ItemAddMessageComposer = 83;

        // _events[84] = com.sulake.habbo.communication.messages.incoming.room.engine.ItemRemoveMessageEvent; 
        public const uint ItemRemoveMessageComposer = 84;

        // _events[85] = com.sulake.habbo.communication.messages.incoming.room.engine.ItemUpdateMessageEvent; 
        public const uint ItemUpdateMessageComposer = 85;

        // _events[93] = com.sulake.habbo.communication.messages.incoming.room.engine.ObjectAddMessageEvent; 
        public const uint ObjectAddMessageComposer = 93;

        // _events[805] = com.sulake.habbo.communication.messages.incoming.room.engine.ViralTeaserActiveMessageEvent; 
        public const uint ViralTeaserActiveMessageComposer = 805;

        // _events[88] = com.sulake.habbo.communication.messages.incoming.room.engine.ObjectDataUpdateMessageEvent; 
        public const uint ObjectDataUpdateMessageComposer = 88;

        // _events[94] = com.sulake.habbo.communication.messages.incoming.room.engine.ObjectRemoveMessageEvent; 
        public const uint ObjectRemoveMessageComposer = 94;

        // _events[95] = com.sulake.habbo.communication.messages.incoming.room.engine.ObjectUpdateMessageEvent; 
        public const uint ObjectUpdateMessageComposer = 95;

        // _events[210] = com.sulake.habbo.communication.messages.incoming.room.pets.PetInfoMessageEvent; 
        public const uint PetInfoMessageComposer_ONE = 210;

        // _events[219] = com.sulake.habbo.communication.messages.incoming.room.engine.HeightMapUpdateMessageEvent; 
        public const uint HeightMapUpdateMessageComposer = 219;

        // _events[230] = com.sulake.habbo.communication.messages.incoming.room.engine.SlideObjectBundleMessageEvent; 
        public const uint SlideObjectBundleMessageComposer = 230;

        // _events[254] = com.sulake.habbo.communication.messages.incoming.room.session.YouAreSpectatorMessageEvent; 
        public const uint YouAreSpectatorMessageComposer = 254;

        // _events[266] = com.sulake.habbo.communication.messages.incoming.room.engine.UserChangeMessageEvent; 
        public const uint UserChangeMessageComposer = 266;

        // _events[365] = com.sulake.habbo.communication.messages.incoming.room.furniture.RoomDimmerPresetsMessageEvent; 
        public const uint RoomDimmerPresetsMessageComposer = 365;

        // _events[470] = com.sulake.habbo.communication.messages.incoming.room.engine.FloorHeightMapMessageEvent; 
        public const uint FloorHeightMapMessageComposer = 470;

        // _events[471] = com.sulake.habbo.communication.messages.incoming.room.engine.RoomEntryInfoMessageEvent; 
        public const uint RoomEntryInfoMessageComposer = 471;

        // _events[472] = com.sulake.habbo.communication.messages.incoming.room.engine.RoomVisualizationSettingsEvent; 
        public const uint RoomVisualizationSettingsComposer = 472;

        // _events[473] = com.sulake.habbo.communication.messages.incoming.room.engine.ObjectsDataUpdateMessageEvent; 
        public const uint ObjectsDataUpdateMessageComposer = 473;

        // _events[516] = com.sulake.habbo.communication.messages.incoming.room.engine.PlaceObjectErrorMessageEvent; 
        public const uint PlaceObjectErrorMessageComposer = 516;

        // _events[572] = com.sulake.habbo.communication.messages.incoming.users.UserNameChangedMessageEvent; 
        public const uint UserNameChangedMessageComposer = 572;

        // _events[806] = com.sulake.habbo.communication.messages.incoming.room.furniture.ViralFurniGiftReceivedEvent; 
        public const uint ViralFurniGiftReceivedComposer = 806;

        // _events[807] = com.sulake.habbo.communication.messages.incoming.room.furniture.ViralFurniStatusEvent; 
        public const uint ViralFurniStatusComposer = 807;

        // _events[808] = com.sulake.habbo.communication.messages.incoming.users.UserNotificationMessageEvent; 
        public const uint UserNotificationMessageComposer = 808;

        // _events[829] = com.sulake.habbo.communication.messages.incoming.room.furniture.WelcomeGiftStatusEvent; 
        public const uint WelcomeGiftStatusComposer = 829;

        // _events[297] = com.sulake.habbo.communication.messages.incoming.room.engine.FurnitureAliasesMessageEvent; 
        public const uint FurnitureAliasesMessageComposer = 297;

        // _events[46] = com.sulake.habbo.communication.messages.incoming.room.engine.RoomPropertyMessageEvent; 
        public const uint RoomPropertyMessageComposer = 46;

        // _events[42] = com.sulake.habbo.communication.messages.incoming.room.permissions.YouAreControllerMessageEvent; 
        public const uint YouAreControllerMessageComposer = 42;

        // _events[43] = com.sulake.habbo.communication.messages.incoming.room.permissions.YouAreNotControllerMessageEvent; 
        public const uint YouAreNotControllerMessageComposer = 43;

        // _events[47] = com.sulake.habbo.communication.messages.incoming.room.permissions.YouAreOwnerMessageEvent; 
        public const uint YouAreOwnerMessageComposer = 47;

        // _events[911] = com.sulake.habbo.communication.messages.incoming.room.furniture.RequestSpamWallPostItMessageEvent; 
        public const uint RequestSpamWallPostItMessageComposer = 911;

        // _events[912] = com.sulake.habbo.communication.messages.incoming.room.furniture.RoomMessageNotificationMessageEvent; 
        public const uint RoomMessageNotificationMessageComposer = 912;

        // _events[224] = com.sulake.habbo.communication.messages.incoming.room.session.CantConnectMessageEvent; 
        public const uint CantConnectMessageComposer = 224;

        // _events[601] = com.sulake.habbo.communication.messages.incoming.room.pets.PetInfoMessageEvent; 
        public const uint PetInfoMessageComposer_TWO = 601;

        // _events[605] = com.sulake.habbo.communication.messages.incoming.room.pets.PetCommandsMessageEvent; 
        public const uint PetCommandsMessageComposer = 605;

        // _events[608] = com.sulake.habbo.communication.messages.incoming.room.pets.PetPlacingErrorEvent; 
        public const uint PetPlacingErrorComposer = 608;

        // _events[609] = com.sulake.habbo.communication.messages.incoming.room.pets.PetExperienceEvent; 
        public const uint PetExperienceComposer = 609;

        // _events[621] = com.sulake.habbo.communication.messages.incoming.room.pets.PetRespectFailedEvent; 
        public const uint PetRespectFailedComposer = 621;

        // _events[480] = com.sulake.habbo.communication.messages.incoming.room.action.DanceMessageEvent; 
        public const uint DanceMessageComposer = 480;

        // _events[481] = com.sulake.habbo.communication.messages.incoming.room.action.WaveMessageEvent; 
        public const uint WaveMessageComposer = 481;

        // _events[482] = com.sulake.habbo.communication.messages.incoming.room.action.CarryObjectMessageEvent; 
        public const uint CarryObjectMessageComposer = 482;

        // _events[485] = com.sulake.habbo.communication.messages.incoming.room.action.AvatarEffectMessageEvent; 
        public const uint AvatarEffectMessageComposer = 485;

        // _events[486] = com.sulake.habbo.communication.messages.incoming.room.action.SleepMessageEvent; 
        public const uint SleepMessageComposer = 486;

        // _events[488] = com.sulake.habbo.communication.messages.incoming.room.action.UseObjectMessageEvent; 
        public const uint UseObjectMessageComposer = 488;

        // _events[90] = com.sulake.habbo.communication.messages.incoming.room.furniture.DiceValueMessageEvent; 
        public const uint DiceValueMessageComposer = 90;

        // _events[129] = com.sulake.habbo.communication.messages.incoming.room.furniture.PresentOpenedMessageEvent; 
        public const uint PresentOpenedMessageComposer = 129;

        // _events[825] = com.sulake.habbo.communication.messages.incoming.room.furniture.OpenPetPackageRequestedMessageEvent; 
        public const uint OpenPetPackageRequestedMessageComposer = 825;

        // _events[826] = com.sulake.habbo.communication.messages.incoming.room.furniture.OpenPetPackageResultMessageEvent; 
        public const uint OpenPetPackageResultMessageComposer = 826;

        // _events[312] = com.sulake.habbo.communication.messages.incoming.room.furniture.OneWayDoorStatusMessageEvent; 
        public const uint OneWayDoorStatusMessageComposer = 312;

        // _events[30] = com.sulake.habbo.communication.messages.incoming.room.engine.PublicRoomObjectsMessageEvent; 
        public const uint PublicRoomObjectsMessageComposer = 30;

        // _events[63] = com.sulake.habbo.communication.messages.incoming.room.furniture.DoorOtherEndDeletedMessageEvent; 
        public const uint DoorOtherEndDeletedMessageComposer = 63;

        // _events[64] = com.sulake.habbo.communication.messages.incoming.room.furniture.DoorNotInstalledMessageEvent; 
        public const uint DoorNotInstalledMessageComposer = 64;

        // _events[350] = com.sulake.habbo.communication.messages.incoming.users.UserTagsMessageEvent; 
        public const uint UserTagsMessageComposer = 350;

        // _events[228] = com.sulake.habbo.communication.messages.incoming.users.HabboUserBadgesMessageEvent; 
        public const uint HabboUserBadgesMessageComposer = 228;

        // _events[309] = com.sulake.habbo.communication.messages.incoming.users.HabboGroupBadgesMessageEvent; 
        public const uint HabboGroupBadgesMessageComposer = 309;

        // _events[311] = com.sulake.habbo.communication.messages.incoming.users.HabboGroupDetailsMessageEvent; 
        public const uint HabboGroupDetailsMessageComposer = 311;

        // _events[419] = com.sulake.habbo.communication.messages.incoming.users.IgnoreResultMessageEvent; 
        public const uint IgnoreResultMessageComposer = 419;

        // _events[420] = com.sulake.habbo.communication.messages.incoming.users.IgnoredUsersMessageEvent; 
        public const uint IgnoredUsersMessageComposer = 420;

        // _events[440] = com.sulake.habbo.communication.messages.incoming.users.RespectNotificationMessageEvent; 
        public const uint RespectNotificationMessageComposer = 440;

        // _events[606] = com.sulake.habbo.communication.messages.incoming.users.PetRespectNotificationEvent; 
        public const uint PetRespectNotificationComposer = 606;

        // _events[35] = com.sulake.habbo.communication.messages.incoming.moderation.UserBannedMessageEvent; 
        public const uint UserBannedMessageComposer = 35;

        // _events[161] = com.sulake.habbo.communication.messages.incoming.moderation.ModMessageEvent; 
        public const uint ModMessageComposer = 161;

        // _events[273] = com.sulake.habbo.communication.messages.incoming.moderation.IssueDeletedMessageEvent; 
        public const uint IssueDeletedMessageComposer = 273;

        // _events[530] = com.sulake.habbo.communication.messages.incoming.moderation.IssueInfoMessageEvent; 
        public const uint IssueInfoMessageComposer = 530;

        // _events[531] = com.sulake.habbo.communication.messages.incoming.moderation.ModeratorInitMessageEvent; 
        public const uint ModeratorInitMessageComposer = 531;

        // _events[532] = com.sulake.habbo.communication.messages.incoming.moderation.IssuePickFailedMessageEvent; 
        public const uint IssuePickFailedMessageComposer = 532;

        // _events[533] = com.sulake.habbo.communication.messages.incoming.moderation.ModeratorUserInfoEvent; 
        public const uint ModeratorUserInfoComposer = 533;

        // _events[534] = com.sulake.habbo.communication.messages.incoming.moderation.CfhChatlogEvent; 
        public const uint CfhChatlogComposer = 534;

        // _events[535] = com.sulake.habbo.communication.messages.incoming.moderation.RoomChatlogEvent; 
        public const uint RoomChatlogComposer = 535;

        // _events[536] = com.sulake.habbo.communication.messages.incoming.moderation.UserChatlogEvent; 
        public const uint UserChatlogComposer = 536;

        // _events[537] = com.sulake.habbo.communication.messages.incoming.moderation.RoomVisitsEvent; 
        public const uint RoomVisitsComposer = 537;

        // _events[538] = com.sulake.habbo.communication.messages.incoming.moderation.ModeratorRoomInfoEvent; 
        public const uint ModeratorRoomInfoComposer = 538;

        // _events[539] = com.sulake.habbo.communication.messages.incoming.moderation.ModeratorActionResultMessageEvent; 
        public const uint ModeratorActionResultMessageComposer = 539;

        // _events[274] = com.sulake.habbo.communication.messages.incoming.help.CallForHelpReplyMessageEvent; 
        public const uint CallForHelpReplyMessageComposer = 274;

        // _events[319] = com.sulake.habbo.communication.messages.incoming.help.CallForHelpPendingCallsMessageEvent; 
        public const uint CallForHelpPendingCallsMessageComposer = 319;

        // _events[320] = com.sulake.habbo.communication.messages.incoming.help.CallForHelpPendingCallsDeletedMessageEvent; 
        public const uint CallForHelpPendingCallsDeletedMessageComposer = 320;

        // _events[321] = com.sulake.habbo.communication.messages.incoming.help.CallForHelpResultMessageEvent; 
        public const uint CallForHelpResultMessageComposer = 321;

        // _events[518] = com.sulake.habbo.communication.messages.incoming.help.FaqClientFaqsMessageEvent; 
        public const uint FaqClientFaqsMessageComposer = 518;

        // _events[519] = com.sulake.habbo.communication.messages.incoming.help.FaqCategoriesMessageEvent; 
        public const uint FaqCategoriesMessageComposer = 519;

        // _events[520] = com.sulake.habbo.communication.messages.incoming.help.FaqTextMessageEvent; 
        public const uint FaqTextMessageComposer = 520;

        // _events[521] = com.sulake.habbo.communication.messages.incoming.help.FaqSearchResultsMessageEvent; 
        public const uint FaqSearchResultsMessageComposer = 521;

        // _events[522] = com.sulake.habbo.communication.messages.incoming.help.FaqCategoryMessageEvent; 
        public const uint FaqCategoryMessageComposer = 522;

        // _events[540] = com.sulake.habbo.communication.messages.incoming.help.IssueCloseNotificationMessageEvent; 
        public const uint IssueCloseNotificationMessageComposer = 540;

        // _events[575] = com.sulake.habbo.communication.messages.incoming.help.TutorialStatusMessageEvent; 
        public const uint TutorialStatusMessageComposer = 575;

        // _events[573] = com.sulake.habbo.communication.messages.incoming.help.HotelMergeNameChangeEvent; 
        public const uint HotelMergeNameChangeComposer = 573;

        // _events[299] = com.sulake.habbo.communication.messages.incoming.error.ErrorReportEvent; 
        public const uint ErrorReportComposer = 299;

        // _events[830] = com.sulake.habbo.communication.messages.incoming.users.ChangeEmailResultEvent; 
        public const uint ChangeEmailResultComposer = 830;

        // _events[7] = com.sulake.habbo.communication.messages.incoming.users.ScrSendUserInfoEvent; 
        public const uint ScrSendUserInfoComposer = 7;

        // _events[139] = com.sulake.habbo.communication.messages.incoming.notifications.HabboBroadcastMessageEvent; 
        public const uint HabboBroadcastMessageComposer = 139;

        // _events[280] = com.sulake.habbo.communication.messages.incoming.notifications.ClubGiftNotificationEvent; 
        public const uint ClubGiftNotificationComposer = 280;

        // _events[437] = com.sulake.habbo.communication.messages.incoming.notifications.HabboAchievementNotificationMessageEvent; 
        public const uint HabboAchievementNotificationMessageComposer = 437;

        // _events[445] = com.sulake.habbo.communication.messages.incoming.notifications.HabboAchievementBonusMessageEvent; 
        public const uint HabboAchievementBonusMessageComposer = 445;

        // _events[444] = com.sulake.habbo.communication.messages.incoming.notifications.HabboAchievementShareIdMessageEvent; 
        public const uint HabboAchievementShareIdMessageComposer = 444;

        // _events[438] = com.sulake.habbo.communication.messages.incoming.notifications.HabboActivityPointNotificationMessageEvent; 
        public const uint HabboActivityPointNotificationMessageComposer = 438;

        // _events[628] = com.sulake.habbo.communication.messages.incoming.notifications.ActivityPointsMessageEvent; 
        public const uint ActivityPointsMessageComposer = 628;

        // _events[517] = com.sulake.habbo.communication.messages.incoming.notifications.InfoFeedEnableMessageEvent; 
        public const uint InfoFeedEnableMessageComposer = 517;

        // _events[602] = com.sulake.habbo.communication.messages.incoming.notifications.PetLevelNotificationEvent; 
        public const uint PetLevelNotificationComposer = 602;

        // _events[810] = com.sulake.habbo.communication.messages.incoming.notifications.MOTDNotificationEvent; 
        public const uint MOTDNotificationComposer = 810;

        // _events[832] = com.sulake.habbo.communication.messages.incoming.notifications.UnseenItemsEvent; 
        public const uint UnseenItemsComposer = 832;

        // _events[126] = com.sulake.habbo.communication.messages.incoming.catalog.CatalogIndexMessageEvent; 
        public const uint CatalogIndexMessageComposer = 126;

        // _events[127] = com.sulake.habbo.communication.messages.incoming.catalog.CatalogPageMessageEvent; 
        public const uint CatalogPageMessageComposer = 127;

        // _events[65] = com.sulake.habbo.communication.messages.incoming.catalog.PurchaseErrorMessageEvent; 
        public const uint PurchaseErrorMessageComposer = 65;

        // _events[67] = com.sulake.habbo.communication.messages.incoming.catalog.PurchaseOKMessageEvent; 
        public const uint PurchaseOKMessageComposer = 67;

        // _events[68] = com.sulake.habbo.communication.messages.incoming.catalog.NotEnoughBalanceMessageEvent; 
        public const uint NotEnoughBalanceMessageComposer = 68;

        // _events[76] = com.sulake.habbo.communication.messages.incoming.catalog.GiftReceiverNotFoundEvent; 
        public const uint GiftReceiverNotFoundComposer = 76;

        // _events[296] = com.sulake.habbo.communication.messages.incoming.catalog.PurchaseNotAllowedMessageEvent; 
        public const uint PurchaseNotAllowedMessageComposer = 296;

        // _events[441] = com.sulake.habbo.communication.messages.incoming.catalog.CatalogPublishedMessageEvent; 
        public const uint CatalogPublishedMessageComposer = 441;

        // _events[212] = com.sulake.habbo.communication.messages.incoming.catalog.VoucherRedeemOkMessageEvent; 
        public const uint VoucherRedeemOkMessageComposer = 212;

        // _events[213] = com.sulake.habbo.communication.messages.incoming.catalog.VoucherRedeemErrorMessageEvent; 
        public const uint VoucherRedeemErrorMessageComposer = 213;

        // _events[620] = com.sulake.habbo.communication.messages.incoming.catalog.GiftWrappingConfigurationEvent; 
        public const uint GiftWrappingConfigurationComposer = 620;

        // _events[622] = com.sulake.habbo.communication.messages.incoming.catalog.IsOfferGiftableMessageEvent; 
        public const uint IsOfferGiftableMessageComposer = 622;

        // _events[623] = com.sulake.habbo.communication.messages.incoming.catalog.ClubGiftInfoEvent; 
        public const uint ClubGiftInfoComposer = 623;

        // _events[624] = com.sulake.habbo.communication.messages.incoming.catalog.ClubGiftSelectedEvent; 
        public const uint ClubGiftSelectedComposer = 624;

        // _events[625] = com.sulake.habbo.communication.messages.incoming.catalog.HabboClubOffersMessageEvent; 
        public const uint HabboClubOffersMessageComposer = 625;

        // _events[629] = com.sulake.habbo.communication.messages.incoming.catalog.ChargeInfoMessageEvent; 
        public const uint ChargeInfoMessageComposer = 629;

        // _events[827] = com.sulake.habbo.communication.messages.incoming.catalog.SellablePetBreedsMessageEvent; 
        public const uint SellablePetBreedsMessageComposer = 827;

        // _events[630] = com.sulake.habbo.communication.messages.incoming.catalog.HabboClubExtendOfferMessageEvent; 
        public const uint HabboClubExtendOfferMessageComposer = 630;

        // _events[506] = com.sulake.habbo.communication.messages.incoming.recycler.RecyclerPrizesMessageEvent; 
        public const uint RecyclerPrizesMessageComposer = 506;

        // _events[507] = com.sulake.habbo.communication.messages.incoming.recycler.RecyclerStatusMessageEvent; 
        public const uint RecyclerStatusMessageComposer = 507;

        // _events[508] = com.sulake.habbo.communication.messages.incoming.recycler.RecyclerFinishedMessageEvent; 
        public const uint RecyclerFinishedMessageComposer = 508;

        // _events[208] = com.sulake.habbo.communication.messages.incoming.advertisement.RoomAdMessageEvent; 
        public const uint RoomAdMessageComposer = 208;

        // _events[258] = com.sulake.habbo.communication.messages.incoming.advertisement.InterstitialMessageEvent; 
        public const uint InterstitialMessageComposer = 258;

        // _-2Pf[482] = com.sulake.habbo.communication.messages.outgoing.tracking.EventLogMessageComposer; 
        public const uint EventLogMessageComposer = 482;

        // _events[354] = com.sulake.habbo.communication.messages.incoming.tracking.LatencyPingResponseMessageEvent; 
        public const uint LatencyPingResponseMessageComposer = 354;

        // _events[79] = com.sulake.habbo.communication.messages.incoming.poll.VoteQuestionMessageEvent; 
        public const uint VoteQuestionMessageComposer = 79;

        // _events[80] = com.sulake.habbo.communication.messages.incoming.poll.VoteResultMessageEvent; 
        public const uint VoteResultMessageComposer = 80;

        // _events[316] = com.sulake.habbo.communication.messages.incoming.poll.PollOfferEvent; 
        public const uint PollOfferComposer = 316;

        // _events[317] = com.sulake.habbo.communication.messages.incoming.poll.PollContentsEvent; 
        public const uint PollContentsComposer = 317;

        // _events[318] = com.sulake.habbo.communication.messages.incoming.poll.PollErrorEvent; 
        public const uint PollErrorComposer = 318;

        // _events[81] = com.sulake.habbo.communication.messages.incoming.room.publicroom.ParkBusCannotEnterMessageEvent; 
        public const uint ParkBusCannotEnterMessageComposer = 81;

        // _events[503] = com.sulake.habbo.communication.messages.incoming.room.publicroom.ParkBusDoorMessageEvent; 
        public const uint ParkBusDoorMessageComposer = 503;

        // _events[96] = com.sulake.habbo.communication.messages.incoming.room.publicroom.OpenLockerRoomMessageEvent; 
        public const uint OpenLockerRoomMessageComposer = 96;

        // _events[36] = com.sulake.habbo.communication.messages.incoming.users.ApproveNameMessageEvent; 
        public const uint ApproveNameMessageComposer = 36;

        // _events[308] = com.sulake.habbo.communication.messages.incoming.sound.SoundSettingsEvent; 
        public const uint SoundSettingsComposer = 308;

        // _events[300] = com.sulake.habbo.communication.messages.incoming.sound.TraxSongInfoMessageEvent; 
        public const uint TraxSongInfoMessageComposer = 300;

        // _events[323] = com.sulake.habbo.communication.messages.incoming.sound.PlayListMessageEvent; 
        public const uint PlayListMessageComposer = 323;

        // _events[333] = com.sulake.habbo.communication.messages.incoming.sound.UserSongDisksInventoryMessageEvent; 
        public const uint UserSongDisksInventoryMessageComposer = 333;

        // _events[334] = com.sulake.habbo.communication.messages.incoming.sound.JukeboxSongDisksMessageEvent; 
        public const uint JukeboxSongDisksMessageComposer = 334;

        // _events[335] = com.sulake.habbo.communication.messages.incoming.sound.PlayListSongAddedMessageEvent; 
        public const uint PlayListSongAddedMessageComposer = 335;

        // _events[327] = com.sulake.habbo.communication.messages.incoming.sound.NowPlayingMessageEvent; 
        public const uint NowPlayingMessageComposer = 327;

        // _events[337] = com.sulake.habbo.communication.messages.incoming.sound.JukeboxPlayListFullMessageEvent; 
        public const uint JukeboxPlayListFullMessageComposer = 337;

        // _events[267] = com.sulake.habbo.communication.messages.incoming.avatar.WardrobeMessageEvent; 
        public const uint WardrobeMessageComposer = 267;

        // _events[570] = com.sulake.habbo.communication.messages.incoming.avatar.ChangeUserNameResultMessageEvent; 
        public const uint ChangeUserNameResultMessageComposer = 570;

        // _events[571] = com.sulake.habbo.communication.messages.incoming.avatar.CheckUserNameResultMessageEvent; 
        public const uint CheckUserNameResultMessageComposer = 571;

        // _events[650] = com.sulake.habbo.communication.messages.incoming.userdefinedroomevents.WiredFurniTriggerEvent; 
        public const uint WiredFurniTriggerComposer = 650;

        // _events[651] = com.sulake.habbo.communication.messages.incoming.userdefinedroomevents.WiredFurniActionEvent; 
        public const uint WiredFurniActionComposer = 651;

        // _events[652] = com.sulake.habbo.communication.messages.incoming.userdefinedroomevents.WiredFurniConditionEvent; 
        public const uint WiredFurniConditionComposer = 652;

        // _events[653] = com.sulake.habbo.communication.messages.incoming.userdefinedroomevents.OpenEvent; 
        public const uint OpenComposer = 653;

        // _events[700] = com.sulake.habbo.communication.messages.incoming.room.session.YouArePlayingGameMessageEvent; 
        public const uint YouArePlayingGameMessageComposer = 700;

        // _events[701] = com.sulake.habbo.communication.messages.incoming.room.session.GamePlayerValueMessageEvent; 
        public const uint GamePlayerValueMessageComposer = 701;

        // _events[800] = com.sulake.habbo.communication.messages.incoming.quest.QuestsMessageEvent; 
        public const uint QuestsMessageComposer = 800;

        // _events[801] = com.sulake.habbo.communication.messages.incoming.quest.QuestCompletedMessageEvent; 
        public const uint QuestCompletedMessageComposer = 801;

        // _events[802] = com.sulake.habbo.communication.messages.incoming.quest.QuestMessageEvent; 
        public const uint QuestMessageComposer = 802;

        // _events[803] = com.sulake.habbo.communication.messages.incoming.quest.QuestCancelledMessageEvent; 
        public const uint QuestCancelledMessageComposer = 803;

        // _events[901] = com.sulake.habbo.communication.messages.incoming.facebook.FaceBookAuthenticateEvent; 
        public const uint FaceBookAuthenticateComposer = 901;

        // _events[902] = com.sulake.habbo.communication.messages.incoming.facebook.FaceBookErrorEvent; 
        public const uint FaceBookErrorComposer = 902;

        // _events[910] = com.sulake.habbo.communication.messages.incoming.facebook.FaceBookAppRequestEvent; 
        public const uint FaceBookAppRequestComposer = 910;

        // _events[1000] = com.sulake.habbo.communication.messages.incoming.room.camera.CameraSnapshotMessageEvent;
        public const uint CameraSnapshotMessageComposer = 1000;
    }
}
