# -*- coding: utf-8 -*-

# Copyright 2020 Google LLC
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
#


__all__ = (
    'AdImageAsset',
    'AdMediaBundleAsset',
    'AdScheduleInfo',
    'AdVideoAsset',
    'AddressInfo',
    'AffiliateLocationFeedItem',
    'AgeRangeInfo',
    'AppAdInfo',
    'AppEngagementAdInfo',
    'AppFeedItem',
    'AppPaymentModelInfo',
    'BasicUserListInfo',
    'BidModifierSimulationPoint',
    'BidModifierSimulationPointList',
    'BookOnGoogleAsset',
    'CallFeedItem',
    'CallOnlyAdInfo',
    'CalloutFeedItem',
    'CarrierInfo',
    'ClickLocation',
    'CombinedRuleUserListInfo',
    'Commission',
    'ContentLabelInfo',
    'CpcBidSimulationPoint',
    'CpcBidSimulationPointList',
    'CpvBidSimulationPoint',
    'CpvBidSimulationPointList',
    'CriterionCategoryAvailability',
    'CriterionCategoryChannelAvailability',
    'CriterionCategoryLocaleAvailability',
    'CrmBasedUserListInfo',
    'CustomAffinityInfo',
    'CustomIntentInfo',
    'CustomParameter',
    'CustomerMatchUserListMetadata',
    'DateRange',
    'DateSpecificRuleUserListInfo',
    'DeviceInfo',
    'DisplayCallToAction',
    'DisplayUploadAdInfo',
    'EnhancedCpc',
    'ExpandedDynamicSearchAdInfo',
    'ExpandedTextAdInfo',
    'ExplorerAutoOptimizerSetting',
    'ExpressionRuleUserListInfo',
    'FinalAppUrl',
    'FrequencyCapEntry',
    'FrequencyCapKey',
    'GenderInfo',
    'GeoPointInfo',
    'GmailAdInfo',
    'GmailTeaser',
    'HotelAdInfo',
    'HotelAdvanceBookingWindowInfo',
    'HotelCalloutFeedItem',
    'HotelCheckInDayInfo',
    'HotelCityInfo',
    'HotelClassInfo',
    'HotelCountryRegionInfo',
    'HotelDateSelectionTypeInfo',
    'HotelIdInfo',
    'HotelLengthOfStayInfo',
    'HotelStateInfo',
    'ImageAdInfo',
    'ImageAsset',
    'ImageDimension',
    'IncomeRangeInfo',
    'InteractionTypeInfo',
    'IpBlockInfo',
    'Keyword',
    'KeywordInfo',
    'KeywordPlanHistoricalMetrics',
    'LanguageInfo',
    'LegacyAppInstallAdInfo',
    'LegacyResponsiveDisplayAdInfo',
    'ListingDimensionInfo',
    'ListingGroupInfo',
    'ListingScopeInfo',
    'LocalAdInfo',
    'LocationFeedItem',
    'LocationGroupInfo',
    'LocationInfo',
    'LogicalUserListInfo',
    'LogicalUserListOperandInfo',
    'ManualCpc',
    'ManualCpm',
    'ManualCpv',
    'MatchingFunction',
    'MaximizeConversionValue',
    'MaximizeConversions',
    'MediaBundleAsset',
    'Metrics',
    'MobileAppCategoryInfo',
    'MobileApplicationInfo',
    'MobileDeviceInfo',
    'Money',
    'MonthlySearchVolume',
    'OfflineUserAddressInfo',
    'Operand',
    'OperatingSystemVersionInfo',
    'ParentalStatusInfo',
    'PercentCpc',
    'PlacementInfo',
    'PolicyTopicConstraint',
    'PolicyTopicEntry',
    'PolicyTopicEvidence',
    'PolicyValidationParameter',
    'PolicyViolationKey',
    'PreferredContentInfo',
    'PriceFeedItem',
    'PriceOffer',
    'ProductBiddingCategoryInfo',
    'ProductBrandInfo',
    'ProductChannelExclusivityInfo',
    'ProductChannelInfo',
    'ProductConditionInfo',
    'ProductCustomAttributeInfo',
    'ProductImage',
    'ProductItemIdInfo',
    'ProductTypeInfo',
    'ProductVideo',
    'PromotionFeedItem',
    'ProximityInfo',
    'RealTimeBiddingSetting',
    'ResponsiveDisplayAdInfo',
    'ResponsiveSearchAdInfo',
    'RuleBasedUserListInfo',
    'Segments',
    'ShoppingComparisonListingAdInfo',
    'ShoppingProductAdInfo',
    'ShoppingSmartAdInfo',
    'SimilarUserListInfo',
    'SitelinkFeedItem',
    'StoreAttribute',
    'StoreSalesMetadata',
    'StoreSalesThirdPartyMetadata',
    'StructuredSnippetFeedItem',
    'TagSnippet',
    'TargetCpa',
    'TargetCpaSimulationPoint',
    'TargetCpaSimulationPointList',
    'TargetCpm',
    'TargetImpressionShare',
    'TargetRestriction',
    'TargetRestrictionOperation',
    'TargetRoas',
    'TargetRoasSimulationPoint',
    'TargetRoasSimulationPointList',
    'TargetSpend',
    'TargetingSetting',
    'TextAdInfo',
    'TextAsset',
    'TextLabel',
    'TextMessageFeedItem',
    'TopicInfo',
    'TransactionAttribute',
    'UnknownListingDimensionInfo',
    'UrlCollection',
    'UserData',
    'UserIdentifier',
    'UserInterestInfo',
    'UserListActionInfo',
    'UserListDateRuleItemInfo',
    'UserListInfo',
    'UserListLogicalRuleInfo',
    'UserListNumberRuleItemInfo',
    'UserListRuleInfo',
    'UserListRuleItemGroupInfo',
    'UserListRuleItemInfo',
    'UserListStringRuleItemInfo',
    'Value',
    'VideoAdInfo',
    'VideoBumperInStreamAdInfo',
    'VideoNonSkippableInStreamAdInfo',
    'VideoOutstreamAdInfo',
    'VideoTrueViewDiscoveryAdInfo',
    'VideoTrueViewInStreamAdInfo',
    'WebpageConditionInfo',
    'WebpageInfo',
    'YouTubeChannelInfo',
    'YouTubeVideoInfo',
    'YoutubeVideoAsset',
'AdTextAsset',
)
