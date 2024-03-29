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
'AdAssetPolicySummary',
'AdImageAsset',
'AdMediaBundleAsset',
'AdScheduleInfo',
'AdTextAsset',
'AdVideoAsset',
'AddressInfo',
'AffiliateLocationFeedItem',
'AgeRangeInfo',
'AppAdInfo',
'AppEngagementAdInfo',
'AppFeedItem',
'AppPaymentModelInfo',
'AppPreRegistrationAdInfo',
'AssetInteractionTarget',
'BasicUserListInfo',
'BidModifierSimulationPoint',
'BidModifierSimulationPointList',
'BookOnGoogleAsset',
'BudgetCampaignAssociationStatus',
'BudgetSimulationPoint',
'BudgetSimulationPointList',
'BusinessNameFilter',
'CallAdInfo',
'CallAsset',
'CallFeedItem',
'CallToActionAsset',
'CalloutAsset',
'CalloutFeedItem',
'CarrierInfo',
'ClickLocation',
'CombinedAudienceInfo',
'CombinedRuleUserListInfo',
'Commission',
'ConceptGroup',
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
'CustomAudienceInfo',
'CustomIntentInfo',
'CustomParameter',
'CustomerMatchUserListMetadata',
'CustomizerValue',
'DateRange',
'DateSpecificRuleUserListInfo',
'DeviceInfo',
'DisplayCallToAction',
'DisplayUploadAdInfo',
'DynamicAffiliateLocationSetFilter',
'DynamicEducationAsset',
'DynamicLocationSetFilter',
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
'HistoricalMetricsOptions',
'HotelAdInfo',
'HotelAdvanceBookingWindowInfo',
'HotelCalloutAsset',
'HotelCalloutFeedItem',
'HotelCheckInDateRangeInfo',
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
'ImageFeedItem',
'IncomeRangeInfo',
'InteractionTypeInfo',
'IpBlockInfo',
'ItemAttribute',
'Keyword',
'KeywordAnnotations',
'KeywordConcept',
'KeywordInfo',
'KeywordPlanAggregateMetricResults',
'KeywordPlanAggregateMetrics',
'KeywordPlanDeviceSearches',
'KeywordPlanHistoricalMetrics',
'KeywordThemeInfo',
'LanguageInfo',
'LeadFormAsset',
'LeadFormDeliveryMethod',
'LeadFormField',
'LeadFormSingleChoiceAnswers',
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
'MobileAppAsset',
'MobileAppCategoryInfo',
'MobileApplicationInfo',
'MobileDeviceInfo',
'Money',
'MonthlySearchVolume',
'OfflineUserAddressInfo',
'Operand',
'OperatingSystemVersionInfo',
'PageFeedAsset',
'ParentalStatusInfo',
'PercentCpc',
'PercentCpcBidSimulationPoint',
'PercentCpcBidSimulationPointList',
'PlacementInfo',
'PolicySummary',
'PolicyTopicConstraint',
'PolicyTopicEntry',
'PolicyTopicEvidence',
'PolicyValidationParameter',
'PolicyViolationKey',
'PreferredContentInfo',
'PriceAsset',
'PriceFeedItem',
'PriceOffer',
'PriceOffering',
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
'PromotionAsset',
'PromotionFeedItem',
'ProximityInfo',
'RealTimeBiddingSetting',
'ResponsiveDisplayAdControlSpec',
'ResponsiveDisplayAdInfo',
'ResponsiveSearchAdInfo',
'RuleBasedUserListInfo',
'Segments',
'ShoppingComparisonListingAdInfo',
'ShoppingLoyalty',
'ShoppingProductAdInfo',
'ShoppingSmartAdInfo',
'SimilarUserListInfo',
'SitelinkAsset',
'SitelinkFeedItem',
'SmartCampaignAdInfo',
'StoreAttribute',
'StoreSalesMetadata',
'StoreSalesThirdPartyMetadata',
'StructuredSnippetAsset',
'StructuredSnippetFeedItem',
'TagSnippet',
'TargetCpa',
'TargetCpaSimulationPoint',
'TargetCpaSimulationPointList',
'TargetCpm',
'TargetImpressionShare',
'TargetImpressionShareSimulationPoint',
'TargetImpressionShareSimulationPointList',
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
'UserAttribute',
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
'VideoResponsiveAdInfo',
'VideoTrueViewDiscoveryAdInfo',
'VideoTrueViewInStreamAdInfo',
'WebhookDelivery',
'WebpageConditionInfo',
'WebpageInfo',
'WebpageSampleInfo',
'YearMonth',
'YearMonthRange',
'YouTubeChannelInfo',
'YouTubeVideoInfo',
'YoutubeVideoAsset',
)
