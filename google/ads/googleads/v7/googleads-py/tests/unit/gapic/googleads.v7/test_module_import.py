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
 import pytest


def test_module_level_imports():
    expected_names = []

    # Message types
    from google.ads.googleads import PolicyTopicEntryTypeEnum
    expected_names.append(PolicyTopicEntryTypeEnum.__name__)
    from google.ads.googleads import PolicyTopicEvidenceDestinationMismatchUrlTypeEnum
    expected_names.append(PolicyTopicEvidenceDestinationMismatchUrlTypeEnum.__name__)
    from google.ads.googleads import PolicyTopicEvidenceDestinationNotWorkingDeviceEnum
    expected_names.append(PolicyTopicEvidenceDestinationNotWorkingDeviceEnum.__name__)
    from google.ads.googleads import PolicyTopicEvidenceDestinationNotWorkingDnsErrorTypeEnum
    expected_names.append(PolicyTopicEvidenceDestinationNotWorkingDnsErrorTypeEnum.__name__)
    from google.ads.googleads import PolicyViolationKey
    expected_names.append(PolicyViolationKey.__name__)
    from google.ads.googleads import PolicyValidationParameter
    expected_names.append(PolicyValidationParameter.__name__)
    from google.ads.googleads import PolicyTopicEntry
    expected_names.append(PolicyTopicEntry.__name__)
    from google.ads.googleads import PolicyTopicEvidence
    expected_names.append(PolicyTopicEvidence.__name__)
    from google.ads.googleads import PolicyTopicConstraint
    expected_names.append(PolicyTopicConstraint.__name__)
    from google.ads.googleads import PolicyApprovalStatusEnum
    expected_names.append(PolicyApprovalStatusEnum.__name__)
    from google.ads.googleads import PolicyReviewStatusEnum
    expected_names.append(PolicyReviewStatusEnum.__name__)
    from google.ads.googleads import AdAssetPolicySummary
    expected_names.append(AdAssetPolicySummary.__name__)
    from google.ads.googleads import AssetPerformanceLabelEnum
    expected_names.append(AssetPerformanceLabelEnum.__name__)
    from google.ads.googleads import ServedAssetFieldTypeEnum
    expected_names.append(ServedAssetFieldTypeEnum.__name__)
    from google.ads.googleads import AdTextAsset
    expected_names.append(AdTextAsset.__name__)
    from google.ads.googleads import AdImageAsset
    expected_names.append(AdImageAsset.__name__)
    from google.ads.googleads import AdVideoAsset
    expected_names.append(AdVideoAsset.__name__)
    from google.ads.googleads import AdMediaBundleAsset
    expected_names.append(AdMediaBundleAsset.__name__)
    from google.ads.googleads import CallConversionReportingStateEnum
    expected_names.append(CallConversionReportingStateEnum.__name__)
    from google.ads.googleads import DisplayAdFormatSettingEnum
    expected_names.append(DisplayAdFormatSettingEnum.__name__)
    from google.ads.googleads import DisplayUploadProductTypeEnum
    expected_names.append(DisplayUploadProductTypeEnum.__name__)
    from google.ads.googleads import LegacyAppInstallAdAppStoreEnum
    expected_names.append(LegacyAppInstallAdAppStoreEnum.__name__)
    from google.ads.googleads import MimeTypeEnum
    expected_names.append(MimeTypeEnum.__name__)
    from google.ads.googleads import TextAdInfo
    expected_names.append(TextAdInfo.__name__)
    from google.ads.googleads import ExpandedTextAdInfo
    expected_names.append(ExpandedTextAdInfo.__name__)
    from google.ads.googleads import CallOnlyAdInfo
    expected_names.append(CallOnlyAdInfo.__name__)
    from google.ads.googleads import ExpandedDynamicSearchAdInfo
    expected_names.append(ExpandedDynamicSearchAdInfo.__name__)
    from google.ads.googleads import HotelAdInfo
    expected_names.append(HotelAdInfo.__name__)
    from google.ads.googleads import ShoppingSmartAdInfo
    expected_names.append(ShoppingSmartAdInfo.__name__)
    from google.ads.googleads import ShoppingProductAdInfo
    expected_names.append(ShoppingProductAdInfo.__name__)
    from google.ads.googleads import ShoppingComparisonListingAdInfo
    expected_names.append(ShoppingComparisonListingAdInfo.__name__)
    from google.ads.googleads import GmailAdInfo
    expected_names.append(GmailAdInfo.__name__)
    from google.ads.googleads import GmailTeaser
    expected_names.append(GmailTeaser.__name__)
    from google.ads.googleads import DisplayCallToAction
    expected_names.append(DisplayCallToAction.__name__)
    from google.ads.googleads import ProductImage
    expected_names.append(ProductImage.__name__)
    from google.ads.googleads import ProductVideo
    expected_names.append(ProductVideo.__name__)
    from google.ads.googleads import ImageAdInfo
    expected_names.append(ImageAdInfo.__name__)
    from google.ads.googleads import VideoBumperInStreamAdInfo
    expected_names.append(VideoBumperInStreamAdInfo.__name__)
    from google.ads.googleads import VideoNonSkippableInStreamAdInfo
    expected_names.append(VideoNonSkippableInStreamAdInfo.__name__)
    from google.ads.googleads import VideoTrueViewInStreamAdInfo
    expected_names.append(VideoTrueViewInStreamAdInfo.__name__)
    from google.ads.googleads import VideoOutstreamAdInfo
    expected_names.append(VideoOutstreamAdInfo.__name__)
    from google.ads.googleads import VideoTrueViewDiscoveryAdInfo
    expected_names.append(VideoTrueViewDiscoveryAdInfo.__name__)
    from google.ads.googleads import VideoAdInfo
    expected_names.append(VideoAdInfo.__name__)
    from google.ads.googleads import VideoResponsiveAdInfo
    expected_names.append(VideoResponsiveAdInfo.__name__)
    from google.ads.googleads import ResponsiveSearchAdInfo
    expected_names.append(ResponsiveSearchAdInfo.__name__)
    from google.ads.googleads import LegacyResponsiveDisplayAdInfo
    expected_names.append(LegacyResponsiveDisplayAdInfo.__name__)
    from google.ads.googleads import AppAdInfo
    expected_names.append(AppAdInfo.__name__)
    from google.ads.googleads import AppEngagementAdInfo
    expected_names.append(AppEngagementAdInfo.__name__)
    from google.ads.googleads import LegacyAppInstallAdInfo
    expected_names.append(LegacyAppInstallAdInfo.__name__)
    from google.ads.googleads import ResponsiveDisplayAdInfo
    expected_names.append(ResponsiveDisplayAdInfo.__name__)
    from google.ads.googleads import LocalAdInfo
    expected_names.append(LocalAdInfo.__name__)
    from google.ads.googleads import DisplayUploadAdInfo
    expected_names.append(DisplayUploadAdInfo.__name__)
    from google.ads.googleads import ResponsiveDisplayAdControlSpec
    expected_names.append(ResponsiveDisplayAdControlSpec.__name__)
    from google.ads.googleads import AgeRangeTypeEnum
    expected_names.append(AgeRangeTypeEnum.__name__)
    from google.ads.googleads import AppPaymentModelTypeEnum
    expected_names.append(AppPaymentModelTypeEnum.__name__)
    from google.ads.googleads import ContentLabelTypeEnum
    expected_names.append(ContentLabelTypeEnum.__name__)
    from google.ads.googleads import DayOfWeekEnum
    expected_names.append(DayOfWeekEnum.__name__)
    from google.ads.googleads import DeviceEnum
    expected_names.append(DeviceEnum.__name__)
    from google.ads.googleads import GenderTypeEnum
    expected_names.append(GenderTypeEnum.__name__)
    from google.ads.googleads import HotelDateSelectionTypeEnum
    expected_names.append(HotelDateSelectionTypeEnum.__name__)
    from google.ads.googleads import IncomeRangeTypeEnum
    expected_names.append(IncomeRangeTypeEnum.__name__)
    from google.ads.googleads import InteractionTypeEnum
    expected_names.append(InteractionTypeEnum.__name__)
    from google.ads.googleads import KeywordMatchTypeEnum
    expected_names.append(KeywordMatchTypeEnum.__name__)
    from google.ads.googleads import ListingGroupTypeEnum
    expected_names.append(ListingGroupTypeEnum.__name__)
    from google.ads.googleads import LocationGroupRadiusUnitsEnum
    expected_names.append(LocationGroupRadiusUnitsEnum.__name__)
    from google.ads.googleads import MinuteOfHourEnum
    expected_names.append(MinuteOfHourEnum.__name__)
    from google.ads.googleads import ParentalStatusTypeEnum
    expected_names.append(ParentalStatusTypeEnum.__name__)
    from google.ads.googleads import PreferredContentTypeEnum
    expected_names.append(PreferredContentTypeEnum.__name__)
    from google.ads.googleads import ProductBiddingCategoryLevelEnum
    expected_names.append(ProductBiddingCategoryLevelEnum.__name__)
    from google.ads.googleads import ProductChannelEnum
    expected_names.append(ProductChannelEnum.__name__)
    from google.ads.googleads import ProductChannelExclusivityEnum
    expected_names.append(ProductChannelExclusivityEnum.__name__)
    from google.ads.googleads import ProductConditionEnum
    expected_names.append(ProductConditionEnum.__name__)
    from google.ads.googleads import ProductCustomAttributeIndexEnum
    expected_names.append(ProductCustomAttributeIndexEnum.__name__)
    from google.ads.googleads import ProductTypeLevelEnum
    expected_names.append(ProductTypeLevelEnum.__name__)
    from google.ads.googleads import ProximityRadiusUnitsEnum
    expected_names.append(ProximityRadiusUnitsEnum.__name__)
    from google.ads.googleads import WebpageConditionOperandEnum
    expected_names.append(WebpageConditionOperandEnum.__name__)
    from google.ads.googleads import WebpageConditionOperatorEnum
    expected_names.append(WebpageConditionOperatorEnum.__name__)
    from google.ads.googleads import KeywordInfo
    expected_names.append(KeywordInfo.__name__)
    from google.ads.googleads import PlacementInfo
    expected_names.append(PlacementInfo.__name__)
    from google.ads.googleads import MobileAppCategoryInfo
    expected_names.append(MobileAppCategoryInfo.__name__)
    from google.ads.googleads import MobileApplicationInfo
    expected_names.append(MobileApplicationInfo.__name__)
    from google.ads.googleads import LocationInfo
    expected_names.append(LocationInfo.__name__)
    from google.ads.googleads import DeviceInfo
    expected_names.append(DeviceInfo.__name__)
    from google.ads.googleads import PreferredContentInfo
    expected_names.append(PreferredContentInfo.__name__)
    from google.ads.googleads import ListingGroupInfo
    expected_names.append(ListingGroupInfo.__name__)
    from google.ads.googleads import ListingScopeInfo
    expected_names.append(ListingScopeInfo.__name__)
    from google.ads.googleads import ListingDimensionInfo
    expected_names.append(ListingDimensionInfo.__name__)
    from google.ads.googleads import HotelIdInfo
    expected_names.append(HotelIdInfo.__name__)
    from google.ads.googleads import HotelClassInfo
    expected_names.append(HotelClassInfo.__name__)
    from google.ads.googleads import HotelCountryRegionInfo
    expected_names.append(HotelCountryRegionInfo.__name__)
    from google.ads.googleads import HotelStateInfo
    expected_names.append(HotelStateInfo.__name__)
    from google.ads.googleads import HotelCityInfo
    expected_names.append(HotelCityInfo.__name__)
    from google.ads.googleads import ProductBiddingCategoryInfo
    expected_names.append(ProductBiddingCategoryInfo.__name__)
    from google.ads.googleads import ProductBrandInfo
    expected_names.append(ProductBrandInfo.__name__)
    from google.ads.googleads import ProductChannelInfo
    expected_names.append(ProductChannelInfo.__name__)
    from google.ads.googleads import ProductChannelExclusivityInfo
    expected_names.append(ProductChannelExclusivityInfo.__name__)
    from google.ads.googleads import ProductConditionInfo
    expected_names.append(ProductConditionInfo.__name__)
    from google.ads.googleads import ProductCustomAttributeInfo
    expected_names.append(ProductCustomAttributeInfo.__name__)
    from google.ads.googleads import ProductItemIdInfo
    expected_names.append(ProductItemIdInfo.__name__)
    from google.ads.googleads import ProductTypeInfo
    expected_names.append(ProductTypeInfo.__name__)
    from google.ads.googleads import UnknownListingDimensionInfo
    expected_names.append(UnknownListingDimensionInfo.__name__)
    from google.ads.googleads import HotelDateSelectionTypeInfo
    expected_names.append(HotelDateSelectionTypeInfo.__name__)
    from google.ads.googleads import HotelAdvanceBookingWindowInfo
    expected_names.append(HotelAdvanceBookingWindowInfo.__name__)
    from google.ads.googleads import HotelLengthOfStayInfo
    expected_names.append(HotelLengthOfStayInfo.__name__)
    from google.ads.googleads import HotelCheckInDateRangeInfo
    expected_names.append(HotelCheckInDateRangeInfo.__name__)
    from google.ads.googleads import HotelCheckInDayInfo
    expected_names.append(HotelCheckInDayInfo.__name__)
    from google.ads.googleads import InteractionTypeInfo
    expected_names.append(InteractionTypeInfo.__name__)
    from google.ads.googleads import AdScheduleInfo
    expected_names.append(AdScheduleInfo.__name__)
    from google.ads.googleads import AgeRangeInfo
    expected_names.append(AgeRangeInfo.__name__)
    from google.ads.googleads import GenderInfo
    expected_names.append(GenderInfo.__name__)
    from google.ads.googleads import IncomeRangeInfo
    expected_names.append(IncomeRangeInfo.__name__)
    from google.ads.googleads import ParentalStatusInfo
    expected_names.append(ParentalStatusInfo.__name__)
    from google.ads.googleads import YouTubeVideoInfo
    expected_names.append(YouTubeVideoInfo.__name__)
    from google.ads.googleads import YouTubeChannelInfo
    expected_names.append(YouTubeChannelInfo.__name__)
    from google.ads.googleads import UserListInfo
    expected_names.append(UserListInfo.__name__)
    from google.ads.googleads import ProximityInfo
    expected_names.append(ProximityInfo.__name__)
    from google.ads.googleads import GeoPointInfo
    expected_names.append(GeoPointInfo.__name__)
    from google.ads.googleads import AddressInfo
    expected_names.append(AddressInfo.__name__)
    from google.ads.googleads import TopicInfo
    expected_names.append(TopicInfo.__name__)
    from google.ads.googleads import LanguageInfo
    expected_names.append(LanguageInfo.__name__)
    from google.ads.googleads import IpBlockInfo
    expected_names.append(IpBlockInfo.__name__)
    from google.ads.googleads import ContentLabelInfo
    expected_names.append(ContentLabelInfo.__name__)
    from google.ads.googleads import CarrierInfo
    expected_names.append(CarrierInfo.__name__)
    from google.ads.googleads import UserInterestInfo
    expected_names.append(UserInterestInfo.__name__)
    from google.ads.googleads import WebpageInfo
    expected_names.append(WebpageInfo.__name__)
    from google.ads.googleads import WebpageConditionInfo
    expected_names.append(WebpageConditionInfo.__name__)
    from google.ads.googleads import WebpageSampleInfo
    expected_names.append(WebpageSampleInfo.__name__)
    from google.ads.googleads import OperatingSystemVersionInfo
    expected_names.append(OperatingSystemVersionInfo.__name__)
    from google.ads.googleads import AppPaymentModelInfo
    expected_names.append(AppPaymentModelInfo.__name__)
    from google.ads.googleads import MobileDeviceInfo
    expected_names.append(MobileDeviceInfo.__name__)
    from google.ads.googleads import CustomAffinityInfo
    expected_names.append(CustomAffinityInfo.__name__)
    from google.ads.googleads import CustomIntentInfo
    expected_names.append(CustomIntentInfo.__name__)
    from google.ads.googleads import LocationGroupInfo
    expected_names.append(LocationGroupInfo.__name__)
    from google.ads.googleads import CustomAudienceInfo
    expected_names.append(CustomAudienceInfo.__name__)
    from google.ads.googleads import CombinedAudienceInfo
    expected_names.append(CombinedAudienceInfo.__name__)
    from google.ads.googleads import Money
    expected_names.append(Money.__name__)
    from google.ads.googleads import LeadFormCallToActionTypeEnum
    expected_names.append(LeadFormCallToActionTypeEnum.__name__)
    from google.ads.googleads import LeadFormDesiredIntentEnum
    expected_names.append(LeadFormDesiredIntentEnum.__name__)
    from google.ads.googleads import LeadFormFieldUserInputTypeEnum
    expected_names.append(LeadFormFieldUserInputTypeEnum.__name__)
    from google.ads.googleads import LeadFormPostSubmitCallToActionTypeEnum
    expected_names.append(LeadFormPostSubmitCallToActionTypeEnum.__name__)
    from google.ads.googleads import PromotionExtensionDiscountModifierEnum
    expected_names.append(PromotionExtensionDiscountModifierEnum.__name__)
    from google.ads.googleads import PromotionExtensionOccasionEnum
    expected_names.append(PromotionExtensionOccasionEnum.__name__)
    from google.ads.googleads import YoutubeVideoAsset
    expected_names.append(YoutubeVideoAsset.__name__)
    from google.ads.googleads import MediaBundleAsset
    expected_names.append(MediaBundleAsset.__name__)
    from google.ads.googleads import ImageAsset
    expected_names.append(ImageAsset.__name__)
    from google.ads.googleads import ImageDimension
    expected_names.append(ImageDimension.__name__)
    from google.ads.googleads import TextAsset
    expected_names.append(TextAsset.__name__)
    from google.ads.googleads import LeadFormAsset
    expected_names.append(LeadFormAsset.__name__)
    from google.ads.googleads import LeadFormField
    expected_names.append(LeadFormField.__name__)
    from google.ads.googleads import LeadFormSingleChoiceAnswers
    expected_names.append(LeadFormSingleChoiceAnswers.__name__)
    from google.ads.googleads import LeadFormDeliveryMethod
    expected_names.append(LeadFormDeliveryMethod.__name__)
    from google.ads.googleads import WebhookDelivery
    expected_names.append(WebhookDelivery.__name__)
    from google.ads.googleads import BookOnGoogleAsset
    expected_names.append(BookOnGoogleAsset.__name__)
    from google.ads.googleads import PromotionAsset
    expected_names.append(PromotionAsset.__name__)
    from google.ads.googleads import CalloutAsset
    expected_names.append(CalloutAsset.__name__)
    from google.ads.googleads import StructuredSnippetAsset
    expected_names.append(StructuredSnippetAsset.__name__)
    from google.ads.googleads import SitelinkAsset
    expected_names.append(SitelinkAsset.__name__)
    from google.ads.googleads import TargetImpressionShareLocationEnum
    expected_names.append(TargetImpressionShareLocationEnum.__name__)
    from google.ads.googleads import Commission
    expected_names.append(Commission.__name__)
    from google.ads.googleads import EnhancedCpc
    expected_names.append(EnhancedCpc.__name__)
    from google.ads.googleads import ManualCpc
    expected_names.append(ManualCpc.__name__)
    from google.ads.googleads import ManualCpm
    expected_names.append(ManualCpm.__name__)
    from google.ads.googleads import ManualCpv
    expected_names.append(ManualCpv.__name__)
    from google.ads.googleads import MaximizeConversions
    expected_names.append(MaximizeConversions.__name__)
    from google.ads.googleads import MaximizeConversionValue
    expected_names.append(MaximizeConversionValue.__name__)
    from google.ads.googleads import TargetCpa
    expected_names.append(TargetCpa.__name__)
    from google.ads.googleads import TargetCpm
    expected_names.append(TargetCpm.__name__)
    from google.ads.googleads import TargetImpressionShare
    expected_names.append(TargetImpressionShare.__name__)
    from google.ads.googleads import TargetRoas
    expected_names.append(TargetRoas.__name__)
    from google.ads.googleads import TargetSpend
    expected_names.append(TargetSpend.__name__)
    from google.ads.googleads import PercentCpc
    expected_names.append(PercentCpc.__name__)
    from google.ads.googleads import ClickLocation
    expected_names.append(ClickLocation.__name__)
    from google.ads.googleads import AdvertisingChannelSubTypeEnum
    expected_names.append(AdvertisingChannelSubTypeEnum.__name__)
    from google.ads.googleads import AdvertisingChannelTypeEnum
    expected_names.append(AdvertisingChannelTypeEnum.__name__)
    from google.ads.googleads import CriterionCategoryChannelAvailabilityModeEnum
    expected_names.append(CriterionCategoryChannelAvailabilityModeEnum.__name__)
    from google.ads.googleads import CriterionCategoryLocaleAvailabilityModeEnum
    expected_names.append(CriterionCategoryLocaleAvailabilityModeEnum.__name__)
    from google.ads.googleads import CriterionCategoryAvailability
    expected_names.append(CriterionCategoryAvailability.__name__)
    from google.ads.googleads import CriterionCategoryChannelAvailability
    expected_names.append(CriterionCategoryChannelAvailability.__name__)
    from google.ads.googleads import CriterionCategoryLocaleAvailability
    expected_names.append(CriterionCategoryLocaleAvailability.__name__)
    from google.ads.googleads import CustomParameter
    expected_names.append(CustomParameter.__name__)
    from google.ads.googleads import MonthOfYearEnum
    expected_names.append(MonthOfYearEnum.__name__)
    from google.ads.googleads import DateRange
    expected_names.append(DateRange.__name__)
    from google.ads.googleads import YearMonthRange
    expected_names.append(YearMonthRange.__name__)
    from google.ads.googleads import YearMonth
    expected_names.append(YearMonth.__name__)
    from google.ads.googleads import ExplorerAutoOptimizerSetting
    expected_names.append(ExplorerAutoOptimizerSetting.__name__)
    from google.ads.googleads import AppStoreEnum
    expected_names.append(AppStoreEnum.__name__)
    from google.ads.googleads import PriceExtensionPriceQualifierEnum
    expected_names.append(PriceExtensionPriceQualifierEnum.__name__)
    from google.ads.googleads import PriceExtensionPriceUnitEnum
    expected_names.append(PriceExtensionPriceUnitEnum.__name__)
    from google.ads.googleads import PriceExtensionTypeEnum
    expected_names.append(PriceExtensionTypeEnum.__name__)
    from google.ads.googleads import AppFeedItem
    expected_names.append(AppFeedItem.__name__)
    from google.ads.googleads import CallFeedItem
    expected_names.append(CallFeedItem.__name__)
    from google.ads.googleads import CalloutFeedItem
    expected_names.append(CalloutFeedItem.__name__)
    from google.ads.googleads import LocationFeedItem
    expected_names.append(LocationFeedItem.__name__)
    from google.ads.googleads import AffiliateLocationFeedItem
    expected_names.append(AffiliateLocationFeedItem.__name__)
    from google.ads.googleads import TextMessageFeedItem
    expected_names.append(TextMessageFeedItem.__name__)
    from google.ads.googleads import PriceFeedItem
    expected_names.append(PriceFeedItem.__name__)
    from google.ads.googleads import PriceOffer
    expected_names.append(PriceOffer.__name__)
    from google.ads.googleads import PromotionFeedItem
    expected_names.append(PromotionFeedItem.__name__)
    from google.ads.googleads import StructuredSnippetFeedItem
    expected_names.append(StructuredSnippetFeedItem.__name__)
    from google.ads.googleads import SitelinkFeedItem
    expected_names.append(SitelinkFeedItem.__name__)
    from google.ads.googleads import HotelCalloutFeedItem
    expected_names.append(HotelCalloutFeedItem.__name__)
    from google.ads.googleads import ImageFeedItem
    expected_names.append(ImageFeedItem.__name__)
    from google.ads.googleads import FeedItemSetStringFilterTypeEnum
    expected_names.append(FeedItemSetStringFilterTypeEnum.__name__)
    from google.ads.googleads import DynamicLocationSetFilter
    expected_names.append(DynamicLocationSetFilter.__name__)
    from google.ads.googleads import BusinessNameFilter
    expected_names.append(BusinessNameFilter.__name__)
    from google.ads.googleads import DynamicAffiliateLocationSetFilter
    expected_names.append(DynamicAffiliateLocationSetFilter.__name__)
    from google.ads.googleads import AppUrlOperatingSystemTypeEnum
    expected_names.append(AppUrlOperatingSystemTypeEnum.__name__)
    from google.ads.googleads import FinalAppUrl
    expected_names.append(FinalAppUrl.__name__)
    from google.ads.googleads import FrequencyCapEventTypeEnum
    expected_names.append(FrequencyCapEventTypeEnum.__name__)
    from google.ads.googleads import FrequencyCapLevelEnum
    expected_names.append(FrequencyCapLevelEnum.__name__)
    from google.ads.googleads import FrequencyCapTimeUnitEnum
    expected_names.append(FrequencyCapTimeUnitEnum.__name__)
    from google.ads.googleads import FrequencyCapEntry
    expected_names.append(FrequencyCapEntry.__name__)
    from google.ads.googleads import FrequencyCapKey
    expected_names.append(FrequencyCapKey.__name__)
    from google.ads.googleads import KeywordPlanAggregateMetricTypeEnum
    expected_names.append(KeywordPlanAggregateMetricTypeEnum.__name__)
    from google.ads.googleads import KeywordPlanCompetitionLevelEnum
    expected_names.append(KeywordPlanCompetitionLevelEnum.__name__)
    from google.ads.googleads import KeywordPlanConceptGroupTypeEnum
    expected_names.append(KeywordPlanConceptGroupTypeEnum.__name__)
    from google.ads.googleads import KeywordPlanHistoricalMetrics
    expected_names.append(KeywordPlanHistoricalMetrics.__name__)
    from google.ads.googleads import HistoricalMetricsOptions
    expected_names.append(HistoricalMetricsOptions.__name__)
    from google.ads.googleads import MonthlySearchVolume
    expected_names.append(MonthlySearchVolume.__name__)
    from google.ads.googleads import KeywordPlanAggregateMetrics
    expected_names.append(KeywordPlanAggregateMetrics.__name__)
    from google.ads.googleads import KeywordPlanAggregateMetricResults
    expected_names.append(KeywordPlanAggregateMetricResults.__name__)
    from google.ads.googleads import KeywordPlanDeviceSearches
    expected_names.append(KeywordPlanDeviceSearches.__name__)
    from google.ads.googleads import KeywordAnnotations
    expected_names.append(KeywordAnnotations.__name__)
    from google.ads.googleads import KeywordConcept
    expected_names.append(KeywordConcept.__name__)
    from google.ads.googleads import ConceptGroup
    expected_names.append(ConceptGroup.__name__)
    from google.ads.googleads import MatchingFunctionContextTypeEnum
    expected_names.append(MatchingFunctionContextTypeEnum.__name__)
    from google.ads.googleads import MatchingFunctionOperatorEnum
    expected_names.append(MatchingFunctionOperatorEnum.__name__)
    from google.ads.googleads import MatchingFunction
    expected_names.append(MatchingFunction.__name__)
    from google.ads.googleads import Operand
    expected_names.append(Operand.__name__)
    from google.ads.googleads import InteractionEventTypeEnum
    expected_names.append(InteractionEventTypeEnum.__name__)
    from google.ads.googleads import QualityScoreBucketEnum
    expected_names.append(QualityScoreBucketEnum.__name__)
    from google.ads.googleads import Metrics
    expected_names.append(Metrics.__name__)
    from google.ads.googleads import UserIdentifierSourceEnum
    expected_names.append(UserIdentifierSourceEnum.__name__)
    from google.ads.googleads import OfflineUserAddressInfo
    expected_names.append(OfflineUserAddressInfo.__name__)
    from google.ads.googleads import UserIdentifier
    expected_names.append(UserIdentifier.__name__)
    from google.ads.googleads import TransactionAttribute
    expected_names.append(TransactionAttribute.__name__)
    from google.ads.googleads import StoreAttribute
    expected_names.append(StoreAttribute.__name__)
    from google.ads.googleads import UserData
    expected_names.append(UserData.__name__)
    from google.ads.googleads import UserAttribute
    expected_names.append(UserAttribute.__name__)
    from google.ads.googleads import CustomerMatchUserListMetadata
    expected_names.append(CustomerMatchUserListMetadata.__name__)
    from google.ads.googleads import StoreSalesMetadata
    expected_names.append(StoreSalesMetadata.__name__)
    from google.ads.googleads import StoreSalesThirdPartyMetadata
    expected_names.append(StoreSalesThirdPartyMetadata.__name__)
    from google.ads.googleads import RealTimeBiddingSetting
    expected_names.append(RealTimeBiddingSetting.__name__)
    from google.ads.googleads import AdDestinationTypeEnum
    expected_names.append(AdDestinationTypeEnum.__name__)
    from google.ads.googleads import AdNetworkTypeEnum
    expected_names.append(AdNetworkTypeEnum.__name__)
    from google.ads.googleads import BudgetCampaignAssociationStatusEnum
    expected_names.append(BudgetCampaignAssociationStatusEnum.__name__)
    from google.ads.googleads import ClickTypeEnum
    expected_names.append(ClickTypeEnum.__name__)
    from google.ads.googleads import ConversionActionCategoryEnum
    expected_names.append(ConversionActionCategoryEnum.__name__)
    from google.ads.googleads import ConversionAttributionEventTypeEnum
    expected_names.append(ConversionAttributionEventTypeEnum.__name__)
    from google.ads.googleads import ConversionLagBucketEnum
    expected_names.append(ConversionLagBucketEnum.__name__)
    from google.ads.googleads import ConversionOrAdjustmentLagBucketEnum
    expected_names.append(ConversionOrAdjustmentLagBucketEnum.__name__)
    from google.ads.googleads import ExternalConversionSourceEnum
    expected_names.append(ExternalConversionSourceEnum.__name__)
    from google.ads.googleads import HotelPriceBucketEnum
    expected_names.append(HotelPriceBucketEnum.__name__)
    from google.ads.googleads import HotelRateTypeEnum
    expected_names.append(HotelRateTypeEnum.__name__)
    from google.ads.googleads import PlaceholderTypeEnum
    expected_names.append(PlaceholderTypeEnum.__name__)
    from google.ads.googleads import SearchEngineResultsPageTypeEnum
    expected_names.append(SearchEngineResultsPageTypeEnum.__name__)
    from google.ads.googleads import SearchTermMatchTypeEnum
    expected_names.append(SearchTermMatchTypeEnum.__name__)
    from google.ads.googleads import SlotEnum
    expected_names.append(SlotEnum.__name__)
    from google.ads.googleads import Segments
    expected_names.append(Segments.__name__)
    from google.ads.googleads import Keyword
    expected_names.append(Keyword.__name__)
    from google.ads.googleads import BudgetCampaignAssociationStatus
    expected_names.append(BudgetCampaignAssociationStatus.__name__)
    from google.ads.googleads import BidModifierSimulationPointList
    expected_names.append(BidModifierSimulationPointList.__name__)
    from google.ads.googleads import CpcBidSimulationPointList
    expected_names.append(CpcBidSimulationPointList.__name__)
    from google.ads.googleads import CpvBidSimulationPointList
    expected_names.append(CpvBidSimulationPointList.__name__)
    from google.ads.googleads import TargetCpaSimulationPointList
    expected_names.append(TargetCpaSimulationPointList.__name__)
    from google.ads.googleads import TargetRoasSimulationPointList
    expected_names.append(TargetRoasSimulationPointList.__name__)
    from google.ads.googleads import PercentCpcBidSimulationPointList
    expected_names.append(PercentCpcBidSimulationPointList.__name__)
    from google.ads.googleads import BudgetSimulationPointList
    expected_names.append(BudgetSimulationPointList.__name__)
    from google.ads.googleads import TargetImpressionShareSimulationPointList
    expected_names.append(TargetImpressionShareSimulationPointList.__name__)
    from google.ads.googleads import BidModifierSimulationPoint
    expected_names.append(BidModifierSimulationPoint.__name__)
    from google.ads.googleads import CpcBidSimulationPoint
    expected_names.append(CpcBidSimulationPoint.__name__)
    from google.ads.googleads import CpvBidSimulationPoint
    expected_names.append(CpvBidSimulationPoint.__name__)
    from google.ads.googleads import TargetCpaSimulationPoint
    expected_names.append(TargetCpaSimulationPoint.__name__)
    from google.ads.googleads import TargetRoasSimulationPoint
    expected_names.append(TargetRoasSimulationPoint.__name__)
    from google.ads.googleads import PercentCpcBidSimulationPoint
    expected_names.append(PercentCpcBidSimulationPoint.__name__)
    from google.ads.googleads import BudgetSimulationPoint
    expected_names.append(BudgetSimulationPoint.__name__)
    from google.ads.googleads import TargetImpressionShareSimulationPoint
    expected_names.append(TargetImpressionShareSimulationPoint.__name__)
    from google.ads.googleads import TrackingCodePageFormatEnum
    expected_names.append(TrackingCodePageFormatEnum.__name__)
    from google.ads.googleads import TrackingCodeTypeEnum
    expected_names.append(TrackingCodeTypeEnum.__name__)
    from google.ads.googleads import TagSnippet
    expected_names.append(TagSnippet.__name__)
    from google.ads.googleads import TargetingDimensionEnum
    expected_names.append(TargetingDimensionEnum.__name__)
    from google.ads.googleads import TargetingSetting
    expected_names.append(TargetingSetting.__name__)
    from google.ads.googleads import TargetRestriction
    expected_names.append(TargetRestriction.__name__)
    from google.ads.googleads import TargetRestrictionOperation
    expected_names.append(TargetRestrictionOperation.__name__)
    from google.ads.googleads import TextLabel
    expected_names.append(TextLabel.__name__)
    from google.ads.googleads import UrlCollection
    expected_names.append(UrlCollection.__name__)
    from google.ads.googleads import CustomerMatchUploadKeyTypeEnum
    expected_names.append(CustomerMatchUploadKeyTypeEnum.__name__)
    from google.ads.googleads import UserListCombinedRuleOperatorEnum
    expected_names.append(UserListCombinedRuleOperatorEnum.__name__)
    from google.ads.googleads import UserListCrmDataSourceTypeEnum
    expected_names.append(UserListCrmDataSourceTypeEnum.__name__)
    from google.ads.googleads import UserListDateRuleItemOperatorEnum
    expected_names.append(UserListDateRuleItemOperatorEnum.__name__)
    from google.ads.googleads import UserListLogicalRuleOperatorEnum
    expected_names.append(UserListLogicalRuleOperatorEnum.__name__)
    from google.ads.googleads import UserListNumberRuleItemOperatorEnum
    expected_names.append(UserListNumberRuleItemOperatorEnum.__name__)
    from google.ads.googleads import UserListPrepopulationStatusEnum
    expected_names.append(UserListPrepopulationStatusEnum.__name__)
    from google.ads.googleads import UserListRuleTypeEnum
    expected_names.append(UserListRuleTypeEnum.__name__)
    from google.ads.googleads import UserListStringRuleItemOperatorEnum
    expected_names.append(UserListStringRuleItemOperatorEnum.__name__)
    from google.ads.googleads import SimilarUserListInfo
    expected_names.append(SimilarUserListInfo.__name__)
    from google.ads.googleads import CrmBasedUserListInfo
    expected_names.append(CrmBasedUserListInfo.__name__)
    from google.ads.googleads import UserListRuleInfo
    expected_names.append(UserListRuleInfo.__name__)
    from google.ads.googleads import UserListRuleItemGroupInfo
    expected_names.append(UserListRuleItemGroupInfo.__name__)
    from google.ads.googleads import UserListRuleItemInfo
    expected_names.append(UserListRuleItemInfo.__name__)
    from google.ads.googleads import UserListDateRuleItemInfo
    expected_names.append(UserListDateRuleItemInfo.__name__)
    from google.ads.googleads import UserListNumberRuleItemInfo
    expected_names.append(UserListNumberRuleItemInfo.__name__)
    from google.ads.googleads import UserListStringRuleItemInfo
    expected_names.append(UserListStringRuleItemInfo.__name__)
    from google.ads.googleads import CombinedRuleUserListInfo
    expected_names.append(CombinedRuleUserListInfo.__name__)
    from google.ads.googleads import DateSpecificRuleUserListInfo
    expected_names.append(DateSpecificRuleUserListInfo.__name__)
    from google.ads.googleads import ExpressionRuleUserListInfo
    expected_names.append(ExpressionRuleUserListInfo.__name__)
    from google.ads.googleads import RuleBasedUserListInfo
    expected_names.append(RuleBasedUserListInfo.__name__)
    from google.ads.googleads import LogicalUserListInfo
    expected_names.append(LogicalUserListInfo.__name__)
    from google.ads.googleads import UserListLogicalRuleInfo
    expected_names.append(UserListLogicalRuleInfo.__name__)
    from google.ads.googleads import LogicalUserListOperandInfo
    expected_names.append(LogicalUserListOperandInfo.__name__)
    from google.ads.googleads import BasicUserListInfo
    expected_names.append(BasicUserListInfo.__name__)
    from google.ads.googleads import UserListActionInfo
    expected_names.append(UserListActionInfo.__name__)
    from google.ads.googleads import Value
    expected_names.append(Value.__name__)
    from google.ads.googleads import AccessInvitationStatusEnum
    expected_names.append(AccessInvitationStatusEnum.__name__)
    from google.ads.googleads import AccessReasonEnum
    expected_names.append(AccessReasonEnum.__name__)
    from google.ads.googleads import AccessRoleEnum
    expected_names.append(AccessRoleEnum.__name__)
    from google.ads.googleads import AccountBudgetProposalStatusEnum
    expected_names.append(AccountBudgetProposalStatusEnum.__name__)
    from google.ads.googleads import AccountBudgetProposalTypeEnum
    expected_names.append(AccountBudgetProposalTypeEnum.__name__)
    from google.ads.googleads import AccountBudgetStatusEnum
    expected_names.append(AccountBudgetStatusEnum.__name__)
    from google.ads.googleads import AccountLinkStatusEnum
    expected_names.append(AccountLinkStatusEnum.__name__)
    from google.ads.googleads import AdCustomizerPlaceholderFieldEnum
    expected_names.append(AdCustomizerPlaceholderFieldEnum.__name__)
    from google.ads.googleads import AdGroupAdRotationModeEnum
    expected_names.append(AdGroupAdRotationModeEnum.__name__)
    from google.ads.googleads import AdGroupAdStatusEnum
    expected_names.append(AdGroupAdStatusEnum.__name__)
    from google.ads.googleads import AdGroupCriterionApprovalStatusEnum
    expected_names.append(AdGroupCriterionApprovalStatusEnum.__name__)
    from google.ads.googleads import AdGroupCriterionStatusEnum
    expected_names.append(AdGroupCriterionStatusEnum.__name__)
    from google.ads.googleads import AdGroupStatusEnum
    expected_names.append(AdGroupStatusEnum.__name__)
    from google.ads.googleads import AdGroupTypeEnum
    expected_names.append(AdGroupTypeEnum.__name__)
    from google.ads.googleads import AdServingOptimizationStatusEnum
    expected_names.append(AdServingOptimizationStatusEnum.__name__)
    from google.ads.googleads import AdStrengthEnum
    expected_names.append(AdStrengthEnum.__name__)
    from google.ads.googleads import AdTypeEnum
    expected_names.append(AdTypeEnum.__name__)
    from google.ads.googleads import AffiliateLocationFeedRelationshipTypeEnum
    expected_names.append(AffiliateLocationFeedRelationshipTypeEnum.__name__)
    from google.ads.googleads import AffiliateLocationPlaceholderFieldEnum
    expected_names.append(AffiliateLocationPlaceholderFieldEnum.__name__)
    from google.ads.googleads import AppCampaignAppStoreEnum
    expected_names.append(AppCampaignAppStoreEnum.__name__)
    from google.ads.googleads import AppCampaignBiddingStrategyGoalTypeEnum
    expected_names.append(AppCampaignBiddingStrategyGoalTypeEnum.__name__)
    from google.ads.googleads import AppPlaceholderFieldEnum
    expected_names.append(AppPlaceholderFieldEnum.__name__)
    from google.ads.googleads import AssetFieldTypeEnum
    expected_names.append(AssetFieldTypeEnum.__name__)
    from google.ads.googleads import AssetLinkStatusEnum
    expected_names.append(AssetLinkStatusEnum.__name__)
    from google.ads.googleads import AssetTypeEnum
    expected_names.append(AssetTypeEnum.__name__)
    from google.ads.googleads import AttributionModelEnum
    expected_names.append(AttributionModelEnum.__name__)
    from google.ads.googleads import BatchJobStatusEnum
    expected_names.append(BatchJobStatusEnum.__name__)
    from google.ads.googleads import BidModifierSourceEnum
    expected_names.append(BidModifierSourceEnum.__name__)
    from google.ads.googleads import BiddingSourceEnum
    expected_names.append(BiddingSourceEnum.__name__)
    from google.ads.googleads import BiddingStrategyStatusEnum
    expected_names.append(BiddingStrategyStatusEnum.__name__)
    from google.ads.googleads import BiddingStrategyTypeEnum
    expected_names.append(BiddingStrategyTypeEnum.__name__)
    from google.ads.googleads import BillingSetupStatusEnum
    expected_names.append(BillingSetupStatusEnum.__name__)
    from google.ads.googleads import BrandSafetySuitabilityEnum
    expected_names.append(BrandSafetySuitabilityEnum.__name__)
    from google.ads.googleads import BudgetDeliveryMethodEnum
    expected_names.append(BudgetDeliveryMethodEnum.__name__)
    from google.ads.googleads import BudgetPeriodEnum
    expected_names.append(BudgetPeriodEnum.__name__)
    from google.ads.googleads import BudgetStatusEnum
    expected_names.append(BudgetStatusEnum.__name__)
    from google.ads.googleads import BudgetTypeEnum
    expected_names.append(BudgetTypeEnum.__name__)
    from google.ads.googleads import CallPlaceholderFieldEnum
    expected_names.append(CallPlaceholderFieldEnum.__name__)
    from google.ads.googleads import CallTrackingDisplayLocationEnum
    expected_names.append(CallTrackingDisplayLocationEnum.__name__)
    from google.ads.googleads import CallTypeEnum
    expected_names.append(CallTypeEnum.__name__)
    from google.ads.googleads import CalloutPlaceholderFieldEnum
    expected_names.append(CalloutPlaceholderFieldEnum.__name__)
    from google.ads.googleads import CampaignCriterionStatusEnum
    expected_names.append(CampaignCriterionStatusEnum.__name__)
    from google.ads.googleads import CampaignDraftStatusEnum
    expected_names.append(CampaignDraftStatusEnum.__name__)
    from google.ads.googleads import CampaignExperimentStatusEnum
    expected_names.append(CampaignExperimentStatusEnum.__name__)
    from google.ads.googleads import CampaignExperimentTrafficSplitTypeEnum
    expected_names.append(CampaignExperimentTrafficSplitTypeEnum.__name__)
    from google.ads.googleads import CampaignExperimentTypeEnum
    expected_names.append(CampaignExperimentTypeEnum.__name__)
    from google.ads.googleads import CampaignServingStatusEnum
    expected_names.append(CampaignServingStatusEnum.__name__)
    from google.ads.googleads import CampaignSharedSetStatusEnum
    expected_names.append(CampaignSharedSetStatusEnum.__name__)
    from google.ads.googleads import CampaignStatusEnum
    expected_names.append(CampaignStatusEnum.__name__)
    from google.ads.googleads import ChangeClientTypeEnum
    expected_names.append(ChangeClientTypeEnum.__name__)
    from google.ads.googleads import ChangeEventResourceTypeEnum
    expected_names.append(ChangeEventResourceTypeEnum.__name__)
    from google.ads.googleads import ChangeStatusOperationEnum
    expected_names.append(ChangeStatusOperationEnum.__name__)
    from google.ads.googleads import ChangeStatusResourceTypeEnum
    expected_names.append(ChangeStatusResourceTypeEnum.__name__)
    from google.ads.googleads import CombinedAudienceStatusEnum
    expected_names.append(CombinedAudienceStatusEnum.__name__)
    from google.ads.googleads import ConversionActionCountingTypeEnum
    expected_names.append(ConversionActionCountingTypeEnum.__name__)
    from google.ads.googleads import ConversionActionStatusEnum
    expected_names.append(ConversionActionStatusEnum.__name__)
    from google.ads.googleads import ConversionActionTypeEnum
    expected_names.append(ConversionActionTypeEnum.__name__)
    from google.ads.googleads import ConversionAdjustmentTypeEnum
    expected_names.append(ConversionAdjustmentTypeEnum.__name__)
    from google.ads.googleads import ConversionCustomVariableStatusEnum
    expected_names.append(ConversionCustomVariableStatusEnum.__name__)
    from google.ads.googleads import CriterionSystemServingStatusEnum
    expected_names.append(CriterionSystemServingStatusEnum.__name__)
    from google.ads.googleads import CriterionTypeEnum
    expected_names.append(CriterionTypeEnum.__name__)
    from google.ads.googleads import CustomAudienceMemberTypeEnum
    expected_names.append(CustomAudienceMemberTypeEnum.__name__)
    from google.ads.googleads import CustomAudienceStatusEnum
    expected_names.append(CustomAudienceStatusEnum.__name__)
    from google.ads.googleads import CustomAudienceTypeEnum
    expected_names.append(CustomAudienceTypeEnum.__name__)
    from google.ads.googleads import CustomInterestMemberTypeEnum
    expected_names.append(CustomInterestMemberTypeEnum.__name__)
    from google.ads.googleads import CustomInterestStatusEnum
    expected_names.append(CustomInterestStatusEnum.__name__)
    from google.ads.googleads import CustomInterestTypeEnum
    expected_names.append(CustomInterestTypeEnum.__name__)
    from google.ads.googleads import CustomPlaceholderFieldEnum
    expected_names.append(CustomPlaceholderFieldEnum.__name__)
    from google.ads.googleads import CustomerPayPerConversionEligibilityFailureReasonEnum
    expected_names.append(CustomerPayPerConversionEligibilityFailureReasonEnum.__name__)
    from google.ads.googleads import DataDrivenModelStatusEnum
    expected_names.append(DataDrivenModelStatusEnum.__name__)
    from google.ads.googleads import DistanceBucketEnum
    expected_names.append(DistanceBucketEnum.__name__)
    from google.ads.googleads import DsaPageFeedCriterionFieldEnum
    expected_names.append(DsaPageFeedCriterionFieldEnum.__name__)
    from google.ads.googleads import EducationPlaceholderFieldEnum
    expected_names.append(EducationPlaceholderFieldEnum.__name__)
    from google.ads.googleads import ExtensionSettingDeviceEnum
    expected_names.append(ExtensionSettingDeviceEnum.__name__)
    from google.ads.googleads import ExtensionTypeEnum
    expected_names.append(ExtensionTypeEnum.__name__)
    from google.ads.googleads import FeedAttributeTypeEnum
    expected_names.append(FeedAttributeTypeEnum.__name__)
    from google.ads.googleads import FeedItemQualityApprovalStatusEnum
    expected_names.append(FeedItemQualityApprovalStatusEnum.__name__)
    from google.ads.googleads import FeedItemQualityDisapprovalReasonEnum
    expected_names.append(FeedItemQualityDisapprovalReasonEnum.__name__)
    from google.ads.googleads import FeedItemSetStatusEnum
    expected_names.append(FeedItemSetStatusEnum.__name__)
    from google.ads.googleads import FeedItemStatusEnum
    expected_names.append(FeedItemStatusEnum.__name__)
    from google.ads.googleads import FeedItemTargetDeviceEnum
    expected_names.append(FeedItemTargetDeviceEnum.__name__)
    from google.ads.googleads import FeedItemTargetStatusEnum
    expected_names.append(FeedItemTargetStatusEnum.__name__)
    from google.ads.googleads import FeedItemTargetTypeEnum
    expected_names.append(FeedItemTargetTypeEnum.__name__)
    from google.ads.googleads import FeedItemValidationStatusEnum
    expected_names.append(FeedItemValidationStatusEnum.__name__)
    from google.ads.googleads import FeedLinkStatusEnum
    expected_names.append(FeedLinkStatusEnum.__name__)
    from google.ads.googleads import FeedMappingCriterionTypeEnum
    expected_names.append(FeedMappingCriterionTypeEnum.__name__)
    from google.ads.googleads import FeedMappingStatusEnum
    expected_names.append(FeedMappingStatusEnum.__name__)
    from google.ads.googleads import FeedOriginEnum
    expected_names.append(FeedOriginEnum.__name__)
    from google.ads.googleads import FeedStatusEnum
    expected_names.append(FeedStatusEnum.__name__)
    from google.ads.googleads import FlightPlaceholderFieldEnum
    expected_names.append(FlightPlaceholderFieldEnum.__name__)
    from google.ads.googleads import GeoTargetConstantStatusEnum
    expected_names.append(GeoTargetConstantStatusEnum.__name__)
    from google.ads.googleads import GeoTargetingRestrictionEnum
    expected_names.append(GeoTargetingRestrictionEnum.__name__)
    from google.ads.googleads import GeoTargetingTypeEnum
    expected_names.append(GeoTargetingTypeEnum.__name__)
    from google.ads.googleads import GoogleAdsFieldCategoryEnum
    expected_names.append(GoogleAdsFieldCategoryEnum.__name__)
    from google.ads.googleads import GoogleAdsFieldDataTypeEnum
    expected_names.append(GoogleAdsFieldDataTypeEnum.__name__)
    from google.ads.googleads import GoogleVoiceCallStatusEnum
    expected_names.append(GoogleVoiceCallStatusEnum.__name__)
    from google.ads.googleads import HotelPlaceholderFieldEnum
    expected_names.append(HotelPlaceholderFieldEnum.__name__)
    from google.ads.googleads import ImagePlaceholderFieldEnum
    expected_names.append(ImagePlaceholderFieldEnum.__name__)
    from google.ads.googleads import InvoiceTypeEnum
    expected_names.append(InvoiceTypeEnum.__name__)
    from google.ads.googleads import JobPlaceholderFieldEnum
    expected_names.append(JobPlaceholderFieldEnum.__name__)
    from google.ads.googleads import KeywordPlanForecastIntervalEnum
    expected_names.append(KeywordPlanForecastIntervalEnum.__name__)
    from google.ads.googleads import KeywordPlanKeywordAnnotationEnum
    expected_names.append(KeywordPlanKeywordAnnotationEnum.__name__)
    from google.ads.googleads import KeywordPlanNetworkEnum
    expected_names.append(KeywordPlanNetworkEnum.__name__)
    from google.ads.googleads import LabelStatusEnum
    expected_names.append(LabelStatusEnum.__name__)
    from google.ads.googleads import LinkedAccountTypeEnum
    expected_names.append(LinkedAccountTypeEnum.__name__)
    from google.ads.googleads import LocalPlaceholderFieldEnum
    expected_names.append(LocalPlaceholderFieldEnum.__name__)
    from google.ads.googleads import LocationExtensionTargetingCriterionFieldEnum
    expected_names.append(LocationExtensionTargetingCriterionFieldEnum.__name__)
    from google.ads.googleads import LocationPlaceholderFieldEnum
    expected_names.append(LocationPlaceholderFieldEnum.__name__)
    from google.ads.googleads import LocationSourceTypeEnum
    expected_names.append(LocationSourceTypeEnum.__name__)
    from google.ads.googleads import ManagerLinkStatusEnum
    expected_names.append(ManagerLinkStatusEnum.__name__)
    from google.ads.googleads import MediaTypeEnum
    expected_names.append(MediaTypeEnum.__name__)
    from google.ads.googleads import MerchantCenterLinkStatusEnum
    expected_names.append(MerchantCenterLinkStatusEnum.__name__)
    from google.ads.googleads import MessagePlaceholderFieldEnum
    expected_names.append(MessagePlaceholderFieldEnum.__name__)
    from google.ads.googleads import MobileAppVendorEnum
    expected_names.append(MobileAppVendorEnum.__name__)
    from google.ads.googleads import MobileDeviceTypeEnum
    expected_names.append(MobileDeviceTypeEnum.__name__)
    from google.ads.googleads import NegativeGeoTargetTypeEnum
    expected_names.append(NegativeGeoTargetTypeEnum.__name__)
    from google.ads.googleads import OfflineUserDataJobFailureReasonEnum
    expected_names.append(OfflineUserDataJobFailureReasonEnum.__name__)
    from google.ads.googleads import OfflineUserDataJobStatusEnum
    expected_names.append(OfflineUserDataJobStatusEnum.__name__)
    from google.ads.googleads import OfflineUserDataJobTypeEnum
    expected_names.append(OfflineUserDataJobTypeEnum.__name__)
    from google.ads.googleads import OperatingSystemVersionOperatorTypeEnum
    expected_names.append(OperatingSystemVersionOperatorTypeEnum.__name__)
    from google.ads.googleads import OptimizationGoalTypeEnum
    expected_names.append(OptimizationGoalTypeEnum.__name__)
    from google.ads.googleads import PaymentModeEnum
    expected_names.append(PaymentModeEnum.__name__)
    from google.ads.googleads import PlacementTypeEnum
    expected_names.append(PlacementTypeEnum.__name__)
    from google.ads.googleads import PositiveGeoTargetTypeEnum
    expected_names.append(PositiveGeoTargetTypeEnum.__name__)
    from google.ads.googleads import PricePlaceholderFieldEnum
    expected_names.append(PricePlaceholderFieldEnum.__name__)
    from google.ads.googleads import ProductBiddingCategoryStatusEnum
    expected_names.append(ProductBiddingCategoryStatusEnum.__name__)
    from google.ads.googleads import PromotionPlaceholderFieldEnum
    expected_names.append(PromotionPlaceholderFieldEnum.__name__)
    from google.ads.googleads import ReachPlanAdLengthEnum
    expected_names.append(ReachPlanAdLengthEnum.__name__)
    from google.ads.googleads import ReachPlanAgeRangeEnum
    expected_names.append(ReachPlanAgeRangeEnum.__name__)
    from google.ads.googleads import ReachPlanNetworkEnum
    expected_names.append(ReachPlanNetworkEnum.__name__)
    from google.ads.googleads import RealEstatePlaceholderFieldEnum
    expected_names.append(RealEstatePlaceholderFieldEnum.__name__)
    from google.ads.googleads import RecommendationTypeEnum
    expected_names.append(RecommendationTypeEnum.__name__)
    from google.ads.googleads import ResourceChangeOperationEnum
    expected_names.append(ResourceChangeOperationEnum.__name__)
    from google.ads.googleads import ResourceLimitTypeEnum
    expected_names.append(ResourceLimitTypeEnum.__name__)
    from google.ads.googleads import ResponseContentTypeEnum
    expected_names.append(ResponseContentTypeEnum.__name__)
    from google.ads.googleads import SearchTermTargetingStatusEnum
    expected_names.append(SearchTermTargetingStatusEnum.__name__)
    from google.ads.googleads import SharedSetStatusEnum
    expected_names.append(SharedSetStatusEnum.__name__)
    from google.ads.googleads import SharedSetTypeEnum
    expected_names.append(SharedSetTypeEnum.__name__)
    from google.ads.googleads import SimulationModificationMethodEnum
    expected_names.append(SimulationModificationMethodEnum.__name__)
    from google.ads.googleads import SimulationTypeEnum
    expected_names.append(SimulationTypeEnum.__name__)
    from google.ads.googleads import SitelinkPlaceholderFieldEnum
    expected_names.append(SitelinkPlaceholderFieldEnum.__name__)
    from google.ads.googleads import SpendingLimitTypeEnum
    expected_names.append(SpendingLimitTypeEnum.__name__)
    from google.ads.googleads import StructuredSnippetPlaceholderFieldEnum
    expected_names.append(StructuredSnippetPlaceholderFieldEnum.__name__)
    from google.ads.googleads import SummaryRowSettingEnum
    expected_names.append(SummaryRowSettingEnum.__name__)
    from google.ads.googleads import SystemManagedResourceSourceEnum
    expected_names.append(SystemManagedResourceSourceEnum.__name__)
    from google.ads.googleads import TargetCpaOptInRecommendationGoalEnum
    expected_names.append(TargetCpaOptInRecommendationGoalEnum.__name__)
    from google.ads.googleads import TimeTypeEnum
    expected_names.append(TimeTypeEnum.__name__)
    from google.ads.googleads import TravelPlaceholderFieldEnum
    expected_names.append(TravelPlaceholderFieldEnum.__name__)
    from google.ads.googleads import UserInterestTaxonomyTypeEnum
    expected_names.append(UserInterestTaxonomyTypeEnum.__name__)
    from google.ads.googleads import UserListAccessStatusEnum
    expected_names.append(UserListAccessStatusEnum.__name__)
    from google.ads.googleads import UserListClosingReasonEnum
    expected_names.append(UserListClosingReasonEnum.__name__)
    from google.ads.googleads import UserListMembershipStatusEnum
    expected_names.append(UserListMembershipStatusEnum.__name__)
    from google.ads.googleads import UserListSizeRangeEnum
    expected_names.append(UserListSizeRangeEnum.__name__)
    from google.ads.googleads import UserListTypeEnum
    expected_names.append(UserListTypeEnum.__name__)
    from google.ads.googleads import VanityPharmaDisplayUrlModeEnum
    expected_names.append(VanityPharmaDisplayUrlModeEnum.__name__)
    from google.ads.googleads import VanityPharmaTextEnum
    expected_names.append(VanityPharmaTextEnum.__name__)
    from google.ads.googleads import AccessInvitationErrorEnum
    expected_names.append(AccessInvitationErrorEnum.__name__)
    from google.ads.googleads import AccountBudgetProposalErrorEnum
    expected_names.append(AccountBudgetProposalErrorEnum.__name__)
    from google.ads.googleads import AccountLinkErrorEnum
    expected_names.append(AccountLinkErrorEnum.__name__)
    from google.ads.googleads import AdCustomizerErrorEnum
    expected_names.append(AdCustomizerErrorEnum.__name__)
    from google.ads.googleads import AdErrorEnum
    expected_names.append(AdErrorEnum.__name__)
    from google.ads.googleads import AdGroupAdErrorEnum
    expected_names.append(AdGroupAdErrorEnum.__name__)
    from google.ads.googleads import AdGroupBidModifierErrorEnum
    expected_names.append(AdGroupBidModifierErrorEnum.__name__)
    from google.ads.googleads import AdGroupCriterionErrorEnum
    expected_names.append(AdGroupCriterionErrorEnum.__name__)
    from google.ads.googleads import AdGroupErrorEnum
    expected_names.append(AdGroupErrorEnum.__name__)
    from google.ads.googleads import AdGroupFeedErrorEnum
    expected_names.append(AdGroupFeedErrorEnum.__name__)
    from google.ads.googleads import AdParameterErrorEnum
    expected_names.append(AdParameterErrorEnum.__name__)
    from google.ads.googleads import AdSharingErrorEnum
    expected_names.append(AdSharingErrorEnum.__name__)
    from google.ads.googleads import AdxErrorEnum
    expected_names.append(AdxErrorEnum.__name__)
    from google.ads.googleads import AssetErrorEnum
    expected_names.append(AssetErrorEnum.__name__)
    from google.ads.googleads import AssetLinkErrorEnum
    expected_names.append(AssetLinkErrorEnum.__name__)
    from google.ads.googleads import AuthenticationErrorEnum
    expected_names.append(AuthenticationErrorEnum.__name__)
    from google.ads.googleads import AuthorizationErrorEnum
    expected_names.append(AuthorizationErrorEnum.__name__)
    from google.ads.googleads import BatchJobErrorEnum
    expected_names.append(BatchJobErrorEnum.__name__)
    from google.ads.googleads import BiddingErrorEnum
    expected_names.append(BiddingErrorEnum.__name__)
    from google.ads.googleads import BiddingStrategyErrorEnum
    expected_names.append(BiddingStrategyErrorEnum.__name__)
    from google.ads.googleads import BillingSetupErrorEnum
    expected_names.append(BillingSetupErrorEnum.__name__)
    from google.ads.googleads import CampaignBudgetErrorEnum
    expected_names.append(CampaignBudgetErrorEnum.__name__)
    from google.ads.googleads import CampaignCriterionErrorEnum
    expected_names.append(CampaignCriterionErrorEnum.__name__)
    from google.ads.googleads import CampaignDraftErrorEnum
    expected_names.append(CampaignDraftErrorEnum.__name__)
    from google.ads.googleads import CampaignErrorEnum
    expected_names.append(CampaignErrorEnum.__name__)
    from google.ads.googleads import CampaignExperimentErrorEnum
    expected_names.append(CampaignExperimentErrorEnum.__name__)
    from google.ads.googleads import CampaignFeedErrorEnum
    expected_names.append(CampaignFeedErrorEnum.__name__)
    from google.ads.googleads import CampaignSharedSetErrorEnum
    expected_names.append(CampaignSharedSetErrorEnum.__name__)
    from google.ads.googleads import ChangeEventErrorEnum
    expected_names.append(ChangeEventErrorEnum.__name__)
    from google.ads.googleads import ChangeStatusErrorEnum
    expected_names.append(ChangeStatusErrorEnum.__name__)
    from google.ads.googleads import CollectionSizeErrorEnum
    expected_names.append(CollectionSizeErrorEnum.__name__)
    from google.ads.googleads import ContextErrorEnum
    expected_names.append(ContextErrorEnum.__name__)
    from google.ads.googleads import ConversionActionErrorEnum
    expected_names.append(ConversionActionErrorEnum.__name__)
    from google.ads.googleads import ConversionAdjustmentUploadErrorEnum
    expected_names.append(ConversionAdjustmentUploadErrorEnum.__name__)
    from google.ads.googleads import ConversionCustomVariableErrorEnum
    expected_names.append(ConversionCustomVariableErrorEnum.__name__)
    from google.ads.googleads import ConversionUploadErrorEnum
    expected_names.append(ConversionUploadErrorEnum.__name__)
    from google.ads.googleads import CountryCodeErrorEnum
    expected_names.append(CountryCodeErrorEnum.__name__)
    from google.ads.googleads import CriterionErrorEnum
    expected_names.append(CriterionErrorEnum.__name__)
    from google.ads.googleads import CurrencyCodeErrorEnum
    expected_names.append(CurrencyCodeErrorEnum.__name__)
    from google.ads.googleads import CustomAudienceErrorEnum
    expected_names.append(CustomAudienceErrorEnum.__name__)
    from google.ads.googleads import CustomInterestErrorEnum
    expected_names.append(CustomInterestErrorEnum.__name__)
    from google.ads.googleads import CustomerClientLinkErrorEnum
    expected_names.append(CustomerClientLinkErrorEnum.__name__)
    from google.ads.googleads import CustomerErrorEnum
    expected_names.append(CustomerErrorEnum.__name__)
    from google.ads.googleads import CustomerFeedErrorEnum
    expected_names.append(CustomerFeedErrorEnum.__name__)
    from google.ads.googleads import CustomerManagerLinkErrorEnum
    expected_names.append(CustomerManagerLinkErrorEnum.__name__)
    from google.ads.googleads import CustomerUserAccessErrorEnum
    expected_names.append(CustomerUserAccessErrorEnum.__name__)
    from google.ads.googleads import DatabaseErrorEnum
    expected_names.append(DatabaseErrorEnum.__name__)
    from google.ads.googleads import DateErrorEnum
    expected_names.append(DateErrorEnum.__name__)
    from google.ads.googleads import DateRangeErrorEnum
    expected_names.append(DateRangeErrorEnum.__name__)
    from google.ads.googleads import DistinctErrorEnum
    expected_names.append(DistinctErrorEnum.__name__)
    from google.ads.googleads import EnumErrorEnum
    expected_names.append(EnumErrorEnum.__name__)
    from google.ads.googleads import ExtensionFeedItemErrorEnum
    expected_names.append(ExtensionFeedItemErrorEnum.__name__)
    from google.ads.googleads import ExtensionSettingErrorEnum
    expected_names.append(ExtensionSettingErrorEnum.__name__)
    from google.ads.googleads import FeedAttributeReferenceErrorEnum
    expected_names.append(FeedAttributeReferenceErrorEnum.__name__)
    from google.ads.googleads import FeedErrorEnum
    expected_names.append(FeedErrorEnum.__name__)
    from google.ads.googleads import FeedItemErrorEnum
    expected_names.append(FeedItemErrorEnum.__name__)
    from google.ads.googleads import FeedItemSetErrorEnum
    expected_names.append(FeedItemSetErrorEnum.__name__)
    from google.ads.googleads import FeedItemSetLinkErrorEnum
    expected_names.append(FeedItemSetLinkErrorEnum.__name__)
    from google.ads.googleads import FeedItemTargetErrorEnum
    expected_names.append(FeedItemTargetErrorEnum.__name__)
    from google.ads.googleads import FeedItemValidationErrorEnum
    expected_names.append(FeedItemValidationErrorEnum.__name__)
    from google.ads.googleads import FeedMappingErrorEnum
    expected_names.append(FeedMappingErrorEnum.__name__)
    from google.ads.googleads import FieldErrorEnum
    expected_names.append(FieldErrorEnum.__name__)
    from google.ads.googleads import FieldMaskErrorEnum
    expected_names.append(FieldMaskErrorEnum.__name__)
    from google.ads.googleads import FunctionErrorEnum
    expected_names.append(FunctionErrorEnum.__name__)
    from google.ads.googleads import FunctionParsingErrorEnum
    expected_names.append(FunctionParsingErrorEnum.__name__)
    from google.ads.googleads import GeoTargetConstantSuggestionErrorEnum
    expected_names.append(GeoTargetConstantSuggestionErrorEnum.__name__)
    from google.ads.googleads import HeaderErrorEnum
    expected_names.append(HeaderErrorEnum.__name__)
    from google.ads.googleads import IdErrorEnum
    expected_names.append(IdErrorEnum.__name__)
    from google.ads.googleads import ImageErrorEnum
    expected_names.append(ImageErrorEnum.__name__)
    from google.ads.googleads import InternalErrorEnum
    expected_names.append(InternalErrorEnum.__name__)
    from google.ads.googleads import InvoiceErrorEnum
    expected_names.append(InvoiceErrorEnum.__name__)
    from google.ads.googleads import KeywordPlanAdGroupErrorEnum
    expected_names.append(KeywordPlanAdGroupErrorEnum.__name__)
    from google.ads.googleads import KeywordPlanAdGroupKeywordErrorEnum
    expected_names.append(KeywordPlanAdGroupKeywordErrorEnum.__name__)
    from google.ads.googleads import KeywordPlanCampaignErrorEnum
    expected_names.append(KeywordPlanCampaignErrorEnum.__name__)
    from google.ads.googleads import KeywordPlanCampaignKeywordErrorEnum
    expected_names.append(KeywordPlanCampaignKeywordErrorEnum.__name__)
    from google.ads.googleads import KeywordPlanErrorEnum
    expected_names.append(KeywordPlanErrorEnum.__name__)
    from google.ads.googleads import KeywordPlanIdeaErrorEnum
    expected_names.append(KeywordPlanIdeaErrorEnum.__name__)
    from google.ads.googleads import LabelErrorEnum
    expected_names.append(LabelErrorEnum.__name__)
    from google.ads.googleads import LanguageCodeErrorEnum
    expected_names.append(LanguageCodeErrorEnum.__name__)
    from google.ads.googleads import ListOperationErrorEnum
    expected_names.append(ListOperationErrorEnum.__name__)
    from google.ads.googleads import ManagerLinkErrorEnum
    expected_names.append(ManagerLinkErrorEnum.__name__)
    from google.ads.googleads import MediaBundleErrorEnum
    expected_names.append(MediaBundleErrorEnum.__name__)
    from google.ads.googleads import MediaFileErrorEnum
    expected_names.append(MediaFileErrorEnum.__name__)
    from google.ads.googleads import MediaUploadErrorEnum
    expected_names.append(MediaUploadErrorEnum.__name__)
    from google.ads.googleads import MultiplierErrorEnum
    expected_names.append(MultiplierErrorEnum.__name__)
    from google.ads.googleads import MutateErrorEnum
    expected_names.append(MutateErrorEnum.__name__)
    from google.ads.googleads import NewResourceCreationErrorEnum
    expected_names.append(NewResourceCreationErrorEnum.__name__)
    from google.ads.googleads import NotAllowlistedErrorEnum
    expected_names.append(NotAllowlistedErrorEnum.__name__)
    from google.ads.googleads import NotEmptyErrorEnum
    expected_names.append(NotEmptyErrorEnum.__name__)
    from google.ads.googleads import NullErrorEnum
    expected_names.append(NullErrorEnum.__name__)
    from google.ads.googleads import OfflineUserDataJobErrorEnum
    expected_names.append(OfflineUserDataJobErrorEnum.__name__)
    from google.ads.googleads import OperationAccessDeniedErrorEnum
    expected_names.append(OperationAccessDeniedErrorEnum.__name__)
    from google.ads.googleads import OperatorErrorEnum
    expected_names.append(OperatorErrorEnum.__name__)
    from google.ads.googleads import PartialFailureErrorEnum
    expected_names.append(PartialFailureErrorEnum.__name__)
    from google.ads.googleads import PaymentsAccountErrorEnum
    expected_names.append(PaymentsAccountErrorEnum.__name__)
    from google.ads.googleads import PolicyFindingErrorEnum
    expected_names.append(PolicyFindingErrorEnum.__name__)
    from google.ads.googleads import PolicyValidationParameterErrorEnum
    expected_names.append(PolicyValidationParameterErrorEnum.__name__)
    from google.ads.googleads import PolicyViolationErrorEnum
    expected_names.append(PolicyViolationErrorEnum.__name__)
    from google.ads.googleads import QueryErrorEnum
    expected_names.append(QueryErrorEnum.__name__)
    from google.ads.googleads import QuotaErrorEnum
    expected_names.append(QuotaErrorEnum.__name__)
    from google.ads.googleads import RangeErrorEnum
    expected_names.append(RangeErrorEnum.__name__)
    from google.ads.googleads import ReachPlanErrorEnum
    expected_names.append(ReachPlanErrorEnum.__name__)
    from google.ads.googleads import RecommendationErrorEnum
    expected_names.append(RecommendationErrorEnum.__name__)
    from google.ads.googleads import RegionCodeErrorEnum
    expected_names.append(RegionCodeErrorEnum.__name__)
    from google.ads.googleads import RequestErrorEnum
    expected_names.append(RequestErrorEnum.__name__)
    from google.ads.googleads import ResourceAccessDeniedErrorEnum
    expected_names.append(ResourceAccessDeniedErrorEnum.__name__)
    from google.ads.googleads import ResourceCountLimitExceededErrorEnum
    expected_names.append(ResourceCountLimitExceededErrorEnum.__name__)
    from google.ads.googleads import SettingErrorEnum
    expected_names.append(SettingErrorEnum.__name__)
    from google.ads.googleads import SharedCriterionErrorEnum
    expected_names.append(SharedCriterionErrorEnum.__name__)
    from google.ads.googleads import SharedSetErrorEnum
    expected_names.append(SharedSetErrorEnum.__name__)
    from google.ads.googleads import SizeLimitErrorEnum
    expected_names.append(SizeLimitErrorEnum.__name__)
    from google.ads.googleads import StringFormatErrorEnum
    expected_names.append(StringFormatErrorEnum.__name__)
    from google.ads.googleads import StringLengthErrorEnum
    expected_names.append(StringLengthErrorEnum.__name__)
    from google.ads.googleads import ThirdPartyAppAnalyticsLinkErrorEnum
    expected_names.append(ThirdPartyAppAnalyticsLinkErrorEnum.__name__)
    from google.ads.googleads import TimeZoneErrorEnum
    expected_names.append(TimeZoneErrorEnum.__name__)
    from google.ads.googleads import UrlFieldErrorEnum
    expected_names.append(UrlFieldErrorEnum.__name__)
    from google.ads.googleads import UserDataErrorEnum
    expected_names.append(UserDataErrorEnum.__name__)
    from google.ads.googleads import UserListErrorEnum
    expected_names.append(UserListErrorEnum.__name__)
    from google.ads.googleads import YoutubeVideoRegistrationErrorEnum
    expected_names.append(YoutubeVideoRegistrationErrorEnum.__name__)
    from google.ads.googleads import GoogleAdsFailure
    expected_names.append(GoogleAdsFailure.__name__)
    from google.ads.googleads import GoogleAdsError
    expected_names.append(GoogleAdsError.__name__)
    from google.ads.googleads import ErrorCode
    expected_names.append(ErrorCode.__name__)
    from google.ads.googleads import ErrorLocation
    expected_names.append(ErrorLocation.__name__)
    from google.ads.googleads import ErrorDetails
    expected_names.append(ErrorDetails.__name__)
    from google.ads.googleads import PolicyViolationDetails
    expected_names.append(PolicyViolationDetails.__name__)
    from google.ads.googleads import PolicyFindingDetails
    expected_names.append(PolicyFindingDetails.__name__)
    from google.ads.googleads import QuotaErrorDetails
    expected_names.append(QuotaErrorDetails.__name__)
    from google.ads.googleads import ResourceCountDetails
    expected_names.append(ResourceCountDetails.__name__)
    from google.ads.googleads import AccountBudget
    expected_names.append(AccountBudget.__name__)
    from google.ads.googleads import AccountBudgetProposal
    expected_names.append(AccountBudgetProposal.__name__)
    from google.ads.googleads import AccountLink
    expected_names.append(AccountLink.__name__)
    from google.ads.googleads import ThirdPartyAppAnalyticsLinkIdentifier
    expected_names.append(ThirdPartyAppAnalyticsLinkIdentifier.__name__)
    from google.ads.googleads import DataPartnerLinkIdentifier
    expected_names.append(DataPartnerLinkIdentifier.__name__)
    from google.ads.googleads import GoogleAdsLinkIdentifier
    expected_names.append(GoogleAdsLinkIdentifier.__name__)
    from google.ads.googleads import Ad
    expected_names.append(Ad.__name__)
    from google.ads.googleads import AdGroup
    expected_names.append(AdGroup.__name__)
    from google.ads.googleads import AdGroupAd
    expected_names.append(AdGroupAd.__name__)
    from google.ads.googleads import AdGroupAdPolicySummary
    expected_names.append(AdGroupAdPolicySummary.__name__)
    from google.ads.googleads import AdGroupAdAssetView
    expected_names.append(AdGroupAdAssetView.__name__)
    from google.ads.googleads import AdGroupAdAssetPolicySummary
    expected_names.append(AdGroupAdAssetPolicySummary.__name__)
    from google.ads.googleads import AdGroupAdLabel
    expected_names.append(AdGroupAdLabel.__name__)
    from google.ads.googleads import AdGroupAsset
    expected_names.append(AdGroupAsset.__name__)
    from google.ads.googleads import AdGroupAudienceView
    expected_names.append(AdGroupAudienceView.__name__)
    from google.ads.googleads import AdGroupBidModifier
    expected_names.append(AdGroupBidModifier.__name__)
    from google.ads.googleads import AdGroupCriterion
    expected_names.append(AdGroupCriterion.__name__)
    from google.ads.googleads import AdGroupCriterionLabel
    expected_names.append(AdGroupCriterionLabel.__name__)
    from google.ads.googleads import AdGroupCriterionSimulation
    expected_names.append(AdGroupCriterionSimulation.__name__)
    from google.ads.googleads import AdGroupExtensionSetting
    expected_names.append(AdGroupExtensionSetting.__name__)
    from google.ads.googleads import AdGroupFeed
    expected_names.append(AdGroupFeed.__name__)
    from google.ads.googleads import AdGroupLabel
    expected_names.append(AdGroupLabel.__name__)
    from google.ads.googleads import AdGroupSimulation
    expected_names.append(AdGroupSimulation.__name__)
    from google.ads.googleads import AdParameter
    expected_names.append(AdParameter.__name__)
    from google.ads.googleads import AdScheduleView
    expected_names.append(AdScheduleView.__name__)
    from google.ads.googleads import AgeRangeView
    expected_names.append(AgeRangeView.__name__)
    from google.ads.googleads import Asset
    expected_names.append(Asset.__name__)
    from google.ads.googleads import AssetPolicySummary
    expected_names.append(AssetPolicySummary.__name__)
    from google.ads.googleads import BatchJob
    expected_names.append(BatchJob.__name__)
    from google.ads.googleads import BiddingStrategy
    expected_names.append(BiddingStrategy.__name__)
    from google.ads.googleads import BiddingStrategySimulation
    expected_names.append(BiddingStrategySimulation.__name__)
    from google.ads.googleads import BillingSetup
    expected_names.append(BillingSetup.__name__)
    from google.ads.googleads import CallView
    expected_names.append(CallView.__name__)
    from google.ads.googleads import Campaign
    expected_names.append(Campaign.__name__)
    from google.ads.googleads import CampaignAsset
    expected_names.append(CampaignAsset.__name__)
    from google.ads.googleads import CampaignAudienceView
    expected_names.append(CampaignAudienceView.__name__)
    from google.ads.googleads import CampaignBidModifier
    expected_names.append(CampaignBidModifier.__name__)
    from google.ads.googleads import CampaignBudget
    expected_names.append(CampaignBudget.__name__)
    from google.ads.googleads import CampaignCriterion
    expected_names.append(CampaignCriterion.__name__)
    from google.ads.googleads import CampaignCriterionSimulation
    expected_names.append(CampaignCriterionSimulation.__name__)
    from google.ads.googleads import CampaignDraft
    expected_names.append(CampaignDraft.__name__)
    from google.ads.googleads import CampaignExperiment
    expected_names.append(CampaignExperiment.__name__)
    from google.ads.googleads import CampaignExtensionSetting
    expected_names.append(CampaignExtensionSetting.__name__)
    from google.ads.googleads import CampaignFeed
    expected_names.append(CampaignFeed.__name__)
    from google.ads.googleads import CampaignLabel
    expected_names.append(CampaignLabel.__name__)
    from google.ads.googleads import CampaignSharedSet
    expected_names.append(CampaignSharedSet.__name__)
    from google.ads.googleads import CampaignSimulation
    expected_names.append(CampaignSimulation.__name__)
    from google.ads.googleads import CarrierConstant
    expected_names.append(CarrierConstant.__name__)
    from google.ads.googleads import Feed
    expected_names.append(Feed.__name__)
    from google.ads.googleads import FeedAttribute
    expected_names.append(FeedAttribute.__name__)
    from google.ads.googleads import FeedAttributeOperation
    expected_names.append(FeedAttributeOperation.__name__)
    from google.ads.googleads import FeedItem
    expected_names.append(FeedItem.__name__)
    from google.ads.googleads import FeedItemAttributeValue
    expected_names.append(FeedItemAttributeValue.__name__)
    from google.ads.googleads import FeedItemPlaceholderPolicyInfo
    expected_names.append(FeedItemPlaceholderPolicyInfo.__name__)
    from google.ads.googleads import FeedItemValidationError
    expected_names.append(FeedItemValidationError.__name__)
    from google.ads.googleads import ChangeEvent
    expected_names.append(ChangeEvent.__name__)
    from google.ads.googleads import ChangeStatus
    expected_names.append(ChangeStatus.__name__)
    from google.ads.googleads import ClickView
    expected_names.append(ClickView.__name__)
    from google.ads.googleads import CombinedAudience
    expected_names.append(CombinedAudience.__name__)
    from google.ads.googleads import ConversionAction
    expected_names.append(ConversionAction.__name__)
    from google.ads.googleads import ConversionCustomVariable
    expected_names.append(ConversionCustomVariable.__name__)
    from google.ads.googleads import CurrencyConstant
    expected_names.append(CurrencyConstant.__name__)
    from google.ads.googleads import CustomAudience
    expected_names.append(CustomAudience.__name__)
    from google.ads.googleads import CustomAudienceMember
    expected_names.append(CustomAudienceMember.__name__)
    from google.ads.googleads import CustomInterest
    expected_names.append(CustomInterest.__name__)
    from google.ads.googleads import CustomInterestMember
    expected_names.append(CustomInterestMember.__name__)
    from google.ads.googleads import Customer
    expected_names.append(Customer.__name__)
    from google.ads.googleads import CallReportingSetting
    expected_names.append(CallReportingSetting.__name__)
    from google.ads.googleads import ConversionTrackingSetting
    expected_names.append(ConversionTrackingSetting.__name__)
    from google.ads.googleads import RemarketingSetting
    expected_names.append(RemarketingSetting.__name__)
    from google.ads.googleads import CustomerAsset
    expected_names.append(CustomerAsset.__name__)
    from google.ads.googleads import CustomerClient
    expected_names.append(CustomerClient.__name__)
    from google.ads.googleads import CustomerClientLink
    expected_names.append(CustomerClientLink.__name__)
    from google.ads.googleads import CustomerExtensionSetting
    expected_names.append(CustomerExtensionSetting.__name__)
    from google.ads.googleads import CustomerFeed
    expected_names.append(CustomerFeed.__name__)
    from google.ads.googleads import CustomerLabel
    expected_names.append(CustomerLabel.__name__)
    from google.ads.googleads import CustomerManagerLink
    expected_names.append(CustomerManagerLink.__name__)
    from google.ads.googleads import CustomerNegativeCriterion
    expected_names.append(CustomerNegativeCriterion.__name__)
    from google.ads.googleads import CustomerUserAccess
    expected_names.append(CustomerUserAccess.__name__)
    from google.ads.googleads import CustomerUserAccessInvitation
    expected_names.append(CustomerUserAccessInvitation.__name__)
    from google.ads.googleads import DetailPlacementView
    expected_names.append(DetailPlacementView.__name__)
    from google.ads.googleads import DisplayKeywordView
    expected_names.append(DisplayKeywordView.__name__)
    from google.ads.googleads import DistanceView
    expected_names.append(DistanceView.__name__)
    from google.ads.googleads import DomainCategory
    expected_names.append(DomainCategory.__name__)
    from google.ads.googleads import DynamicSearchAdsSearchTermView
    expected_names.append(DynamicSearchAdsSearchTermView.__name__)
    from google.ads.googleads import ExpandedLandingPageView
    expected_names.append(ExpandedLandingPageView.__name__)
    from google.ads.googleads import ExtensionFeedItem
    expected_names.append(ExtensionFeedItem.__name__)
    from google.ads.googleads import FeedItemSet
    expected_names.append(FeedItemSet.__name__)
    from google.ads.googleads import FeedItemSetLink
    expected_names.append(FeedItemSetLink.__name__)
    from google.ads.googleads import FeedItemTarget
    expected_names.append(FeedItemTarget.__name__)
    from google.ads.googleads import FeedMapping
    expected_names.append(FeedMapping.__name__)
    from google.ads.googleads import AttributeFieldMapping
    expected_names.append(AttributeFieldMapping.__name__)
    from google.ads.googleads import FeedPlaceholderView
    expected_names.append(FeedPlaceholderView.__name__)
    from google.ads.googleads import GenderView
    expected_names.append(GenderView.__name__)
    from google.ads.googleads import GeoTargetConstant
    expected_names.append(GeoTargetConstant.__name__)
    from google.ads.googleads import GeographicView
    expected_names.append(GeographicView.__name__)
    from google.ads.googleads import GoogleAdsField
    expected_names.append(GoogleAdsField.__name__)
    from google.ads.googleads import GroupPlacementView
    expected_names.append(GroupPlacementView.__name__)
    from google.ads.googleads import HotelGroupView
    expected_names.append(HotelGroupView.__name__)
    from google.ads.googleads import HotelPerformanceView
    expected_names.append(HotelPerformanceView.__name__)
    from google.ads.googleads import IncomeRangeView
    expected_names.append(IncomeRangeView.__name__)
    from google.ads.googleads import Invoice
    expected_names.append(Invoice.__name__)
    from google.ads.googleads import KeywordPlan
    expected_names.append(KeywordPlan.__name__)
    from google.ads.googleads import KeywordPlanForecastPeriod
    expected_names.append(KeywordPlanForecastPeriod.__name__)
    from google.ads.googleads import KeywordPlanAdGroup
    expected_names.append(KeywordPlanAdGroup.__name__)
    from google.ads.googleads import KeywordPlanAdGroupKeyword
    expected_names.append(KeywordPlanAdGroupKeyword.__name__)
    from google.ads.googleads import KeywordPlanCampaign
    expected_names.append(KeywordPlanCampaign.__name__)
    from google.ads.googleads import KeywordPlanGeoTarget
    expected_names.append(KeywordPlanGeoTarget.__name__)
    from google.ads.googleads import KeywordPlanCampaignKeyword
    expected_names.append(KeywordPlanCampaignKeyword.__name__)
    from google.ads.googleads import KeywordView
    expected_names.append(KeywordView.__name__)
    from google.ads.googleads import Label
    expected_names.append(Label.__name__)
    from google.ads.googleads import LandingPageView
    expected_names.append(LandingPageView.__name__)
    from google.ads.googleads import LanguageConstant
    expected_names.append(LanguageConstant.__name__)
    from google.ads.googleads import LifeEvent
    expected_names.append(LifeEvent.__name__)
    from google.ads.googleads import LocationView
    expected_names.append(LocationView.__name__)
    from google.ads.googleads import ManagedPlacementView
    expected_names.append(ManagedPlacementView.__name__)
    from google.ads.googleads import MediaFile
    expected_names.append(MediaFile.__name__)
    from google.ads.googleads import MediaImage
    expected_names.append(MediaImage.__name__)
    from google.ads.googleads import MediaBundle
    expected_names.append(MediaBundle.__name__)
    from google.ads.googleads import MediaAudio
    expected_names.append(MediaAudio.__name__)
    from google.ads.googleads import MediaVideo
    expected_names.append(MediaVideo.__name__)
    from google.ads.googleads import MerchantCenterLink
    expected_names.append(MerchantCenterLink.__name__)
    from google.ads.googleads import MobileAppCategoryConstant
    expected_names.append(MobileAppCategoryConstant.__name__)
    from google.ads.googleads import MobileDeviceConstant
    expected_names.append(MobileDeviceConstant.__name__)
    from google.ads.googleads import OfflineUserDataJob
    expected_names.append(OfflineUserDataJob.__name__)
    from google.ads.googleads import OperatingSystemVersionConstant
    expected_names.append(OperatingSystemVersionConstant.__name__)
    from google.ads.googleads import PaidOrganicSearchTermView
    expected_names.append(PaidOrganicSearchTermView.__name__)
    from google.ads.googleads import ParentalStatusView
    expected_names.append(ParentalStatusView.__name__)
    from google.ads.googleads import PaymentsAccount
    expected_names.append(PaymentsAccount.__name__)
    from google.ads.googleads import ProductBiddingCategoryConstant
    expected_names.append(ProductBiddingCategoryConstant.__name__)
    from google.ads.googleads import ProductGroupView
    expected_names.append(ProductGroupView.__name__)
    from google.ads.googleads import Recommendation
    expected_names.append(Recommendation.__name__)
    from google.ads.googleads import RemarketingAction
    expected_names.append(RemarketingAction.__name__)
    from google.ads.googleads import SearchTermView
    expected_names.append(SearchTermView.__name__)
    from google.ads.googleads import SharedCriterion
    expected_names.append(SharedCriterion.__name__)
    from google.ads.googleads import SharedSet
    expected_names.append(SharedSet.__name__)
    from google.ads.googleads import ShoppingPerformanceView
    expected_names.append(ShoppingPerformanceView.__name__)
    from google.ads.googleads import ThirdPartyAppAnalyticsLink
    expected_names.append(ThirdPartyAppAnalyticsLink.__name__)
    from google.ads.googleads import TopicConstant
    expected_names.append(TopicConstant.__name__)
    from google.ads.googleads import TopicView
    expected_names.append(TopicView.__name__)
    from google.ads.googleads import UserInterest
    expected_names.append(UserInterest.__name__)
    from google.ads.googleads import UserList
    expected_names.append(UserList.__name__)
    from google.ads.googleads import UserLocationView
    expected_names.append(UserLocationView.__name__)
    from google.ads.googleads import Video
    expected_names.append(Video.__name__)
    from google.ads.googleads import WebpageView
    expected_names.append(WebpageView.__name__)
    from google.ads.googleads import GetAccountBudgetProposalRequest
    expected_names.append(GetAccountBudgetProposalRequest.__name__)
    from google.ads.googleads import MutateAccountBudgetProposalRequest
    expected_names.append(MutateAccountBudgetProposalRequest.__name__)
    from google.ads.googleads import AccountBudgetProposalOperation
    expected_names.append(AccountBudgetProposalOperation.__name__)
    from google.ads.googleads import MutateAccountBudgetProposalResponse
    expected_names.append(MutateAccountBudgetProposalResponse.__name__)
    from google.ads.googleads import MutateAccountBudgetProposalResult
    expected_names.append(MutateAccountBudgetProposalResult.__name__)
    from google.ads.googleads import GetAccountBudgetRequest
    expected_names.append(GetAccountBudgetRequest.__name__)
    from google.ads.googleads import GetAccountLinkRequest
    expected_names.append(GetAccountLinkRequest.__name__)
    from google.ads.googleads import CreateAccountLinkRequest
    expected_names.append(CreateAccountLinkRequest.__name__)
    from google.ads.googleads import CreateAccountLinkResponse
    expected_names.append(CreateAccountLinkResponse.__name__)
    from google.ads.googleads import MutateAccountLinkRequest
    expected_names.append(MutateAccountLinkRequest.__name__)
    from google.ads.googleads import AccountLinkOperation
    expected_names.append(AccountLinkOperation.__name__)
    from google.ads.googleads import MutateAccountLinkResponse
    expected_names.append(MutateAccountLinkResponse.__name__)
    from google.ads.googleads import MutateAccountLinkResult
    expected_names.append(MutateAccountLinkResult.__name__)
    from google.ads.googleads import GetAdGroupAdAssetViewRequest
    expected_names.append(GetAdGroupAdAssetViewRequest.__name__)
    from google.ads.googleads import GetAdGroupAdLabelRequest
    expected_names.append(GetAdGroupAdLabelRequest.__name__)
    from google.ads.googleads import MutateAdGroupAdLabelsRequest
    expected_names.append(MutateAdGroupAdLabelsRequest.__name__)
    from google.ads.googleads import AdGroupAdLabelOperation
    expected_names.append(AdGroupAdLabelOperation.__name__)
    from google.ads.googleads import MutateAdGroupAdLabelsResponse
    expected_names.append(MutateAdGroupAdLabelsResponse.__name__)
    from google.ads.googleads import MutateAdGroupAdLabelResult
    expected_names.append(MutateAdGroupAdLabelResult.__name__)
    from google.ads.googleads import GetAdGroupAdRequest
    expected_names.append(GetAdGroupAdRequest.__name__)
    from google.ads.googleads import MutateAdGroupAdsRequest
    expected_names.append(MutateAdGroupAdsRequest.__name__)
    from google.ads.googleads import AdGroupAdOperation
    expected_names.append(AdGroupAdOperation.__name__)
    from google.ads.googleads import MutateAdGroupAdsResponse
    expected_names.append(MutateAdGroupAdsResponse.__name__)
    from google.ads.googleads import MutateAdGroupAdResult
    expected_names.append(MutateAdGroupAdResult.__name__)
    from google.ads.googleads import GetAdGroupAssetRequest
    expected_names.append(GetAdGroupAssetRequest.__name__)
    from google.ads.googleads import MutateAdGroupAssetsRequest
    expected_names.append(MutateAdGroupAssetsRequest.__name__)
    from google.ads.googleads import AdGroupAssetOperation
    expected_names.append(AdGroupAssetOperation.__name__)
    from google.ads.googleads import MutateAdGroupAssetsResponse
    expected_names.append(MutateAdGroupAssetsResponse.__name__)
    from google.ads.googleads import MutateAdGroupAssetResult
    expected_names.append(MutateAdGroupAssetResult.__name__)
    from google.ads.googleads import GetAdGroupAudienceViewRequest
    expected_names.append(GetAdGroupAudienceViewRequest.__name__)
    from google.ads.googleads import GetAdGroupBidModifierRequest
    expected_names.append(GetAdGroupBidModifierRequest.__name__)
    from google.ads.googleads import MutateAdGroupBidModifiersRequest
    expected_names.append(MutateAdGroupBidModifiersRequest.__name__)
    from google.ads.googleads import AdGroupBidModifierOperation
    expected_names.append(AdGroupBidModifierOperation.__name__)
    from google.ads.googleads import MutateAdGroupBidModifiersResponse
    expected_names.append(MutateAdGroupBidModifiersResponse.__name__)
    from google.ads.googleads import MutateAdGroupBidModifierResult
    expected_names.append(MutateAdGroupBidModifierResult.__name__)
    from google.ads.googleads import GetAdGroupCriterionLabelRequest
    expected_names.append(GetAdGroupCriterionLabelRequest.__name__)
    from google.ads.googleads import MutateAdGroupCriterionLabelsRequest
    expected_names.append(MutateAdGroupCriterionLabelsRequest.__name__)
    from google.ads.googleads import AdGroupCriterionLabelOperation
    expected_names.append(AdGroupCriterionLabelOperation.__name__)
    from google.ads.googleads import MutateAdGroupCriterionLabelsResponse
    expected_names.append(MutateAdGroupCriterionLabelsResponse.__name__)
    from google.ads.googleads import MutateAdGroupCriterionLabelResult
    expected_names.append(MutateAdGroupCriterionLabelResult.__name__)
    from google.ads.googleads import GetAdGroupCriterionRequest
    expected_names.append(GetAdGroupCriterionRequest.__name__)
    from google.ads.googleads import MutateAdGroupCriteriaRequest
    expected_names.append(MutateAdGroupCriteriaRequest.__name__)
    from google.ads.googleads import AdGroupCriterionOperation
    expected_names.append(AdGroupCriterionOperation.__name__)
    from google.ads.googleads import MutateAdGroupCriteriaResponse
    expected_names.append(MutateAdGroupCriteriaResponse.__name__)
    from google.ads.googleads import MutateAdGroupCriterionResult
    expected_names.append(MutateAdGroupCriterionResult.__name__)
    from google.ads.googleads import GetAdGroupCriterionSimulationRequest
    expected_names.append(GetAdGroupCriterionSimulationRequest.__name__)
    from google.ads.googleads import GetAdGroupExtensionSettingRequest
    expected_names.append(GetAdGroupExtensionSettingRequest.__name__)
    from google.ads.googleads import MutateAdGroupExtensionSettingsRequest
    expected_names.append(MutateAdGroupExtensionSettingsRequest.__name__)
    from google.ads.googleads import AdGroupExtensionSettingOperation
    expected_names.append(AdGroupExtensionSettingOperation.__name__)
    from google.ads.googleads import MutateAdGroupExtensionSettingsResponse
    expected_names.append(MutateAdGroupExtensionSettingsResponse.__name__)
    from google.ads.googleads import MutateAdGroupExtensionSettingResult
    expected_names.append(MutateAdGroupExtensionSettingResult.__name__)
    from google.ads.googleads import GetAdGroupFeedRequest
    expected_names.append(GetAdGroupFeedRequest.__name__)
    from google.ads.googleads import MutateAdGroupFeedsRequest
    expected_names.append(MutateAdGroupFeedsRequest.__name__)
    from google.ads.googleads import AdGroupFeedOperation
    expected_names.append(AdGroupFeedOperation.__name__)
    from google.ads.googleads import MutateAdGroupFeedsResponse
    expected_names.append(MutateAdGroupFeedsResponse.__name__)
    from google.ads.googleads import MutateAdGroupFeedResult
    expected_names.append(MutateAdGroupFeedResult.__name__)
    from google.ads.googleads import GetAdGroupLabelRequest
    expected_names.append(GetAdGroupLabelRequest.__name__)
    from google.ads.googleads import MutateAdGroupLabelsRequest
    expected_names.append(MutateAdGroupLabelsRequest.__name__)
    from google.ads.googleads import AdGroupLabelOperation
    expected_names.append(AdGroupLabelOperation.__name__)
    from google.ads.googleads import MutateAdGroupLabelsResponse
    expected_names.append(MutateAdGroupLabelsResponse.__name__)
    from google.ads.googleads import MutateAdGroupLabelResult
    expected_names.append(MutateAdGroupLabelResult.__name__)
    from google.ads.googleads import GetAdGroupRequest
    expected_names.append(GetAdGroupRequest.__name__)
    from google.ads.googleads import MutateAdGroupsRequest
    expected_names.append(MutateAdGroupsRequest.__name__)
    from google.ads.googleads import AdGroupOperation
    expected_names.append(AdGroupOperation.__name__)
    from google.ads.googleads import MutateAdGroupsResponse
    expected_names.append(MutateAdGroupsResponse.__name__)
    from google.ads.googleads import MutateAdGroupResult
    expected_names.append(MutateAdGroupResult.__name__)
    from google.ads.googleads import GetAdGroupSimulationRequest
    expected_names.append(GetAdGroupSimulationRequest.__name__)
    from google.ads.googleads import GetAdParameterRequest
    expected_names.append(GetAdParameterRequest.__name__)
    from google.ads.googleads import MutateAdParametersRequest
    expected_names.append(MutateAdParametersRequest.__name__)
    from google.ads.googleads import AdParameterOperation
    expected_names.append(AdParameterOperation.__name__)
    from google.ads.googleads import MutateAdParametersResponse
    expected_names.append(MutateAdParametersResponse.__name__)
    from google.ads.googleads import MutateAdParameterResult
    expected_names.append(MutateAdParameterResult.__name__)
    from google.ads.googleads import GetAdScheduleViewRequest
    expected_names.append(GetAdScheduleViewRequest.__name__)
    from google.ads.googleads import GetAdRequest
    expected_names.append(GetAdRequest.__name__)
    from google.ads.googleads import MutateAdsRequest
    expected_names.append(MutateAdsRequest.__name__)
    from google.ads.googleads import AdOperation
    expected_names.append(AdOperation.__name__)
    from google.ads.googleads import MutateAdsResponse
    expected_names.append(MutateAdsResponse.__name__)
    from google.ads.googleads import MutateAdResult
    expected_names.append(MutateAdResult.__name__)
    from google.ads.googleads import GetAgeRangeViewRequest
    expected_names.append(GetAgeRangeViewRequest.__name__)
    from google.ads.googleads import GetAssetRequest
    expected_names.append(GetAssetRequest.__name__)
    from google.ads.googleads import MutateAssetsRequest
    expected_names.append(MutateAssetsRequest.__name__)
    from google.ads.googleads import AssetOperation
    expected_names.append(AssetOperation.__name__)
    from google.ads.googleads import MutateAssetsResponse
    expected_names.append(MutateAssetsResponse.__name__)
    from google.ads.googleads import MutateAssetResult
    expected_names.append(MutateAssetResult.__name__)
    from google.ads.googleads import GetBiddingStrategyRequest
    expected_names.append(GetBiddingStrategyRequest.__name__)
    from google.ads.googleads import MutateBiddingStrategiesRequest
    expected_names.append(MutateBiddingStrategiesRequest.__name__)
    from google.ads.googleads import BiddingStrategyOperation
    expected_names.append(BiddingStrategyOperation.__name__)
    from google.ads.googleads import MutateBiddingStrategiesResponse
    expected_names.append(MutateBiddingStrategiesResponse.__name__)
    from google.ads.googleads import MutateBiddingStrategyResult
    expected_names.append(MutateBiddingStrategyResult.__name__)
    from google.ads.googleads import GetCampaignAssetRequest
    expected_names.append(GetCampaignAssetRequest.__name__)
    from google.ads.googleads import MutateCampaignAssetsRequest
    expected_names.append(MutateCampaignAssetsRequest.__name__)
    from google.ads.googleads import CampaignAssetOperation
    expected_names.append(CampaignAssetOperation.__name__)
    from google.ads.googleads import MutateCampaignAssetsResponse
    expected_names.append(MutateCampaignAssetsResponse.__name__)
    from google.ads.googleads import MutateCampaignAssetResult
    expected_names.append(MutateCampaignAssetResult.__name__)
    from google.ads.googleads import GetCampaignBidModifierRequest
    expected_names.append(GetCampaignBidModifierRequest.__name__)
    from google.ads.googleads import MutateCampaignBidModifiersRequest
    expected_names.append(MutateCampaignBidModifiersRequest.__name__)
    from google.ads.googleads import CampaignBidModifierOperation
    expected_names.append(CampaignBidModifierOperation.__name__)
    from google.ads.googleads import MutateCampaignBidModifiersResponse
    expected_names.append(MutateCampaignBidModifiersResponse.__name__)
    from google.ads.googleads import MutateCampaignBidModifierResult
    expected_names.append(MutateCampaignBidModifierResult.__name__)
    from google.ads.googleads import GetCampaignBudgetRequest
    expected_names.append(GetCampaignBudgetRequest.__name__)
    from google.ads.googleads import MutateCampaignBudgetsRequest
    expected_names.append(MutateCampaignBudgetsRequest.__name__)
    from google.ads.googleads import CampaignBudgetOperation
    expected_names.append(CampaignBudgetOperation.__name__)
    from google.ads.googleads import MutateCampaignBudgetsResponse
    expected_names.append(MutateCampaignBudgetsResponse.__name__)
    from google.ads.googleads import MutateCampaignBudgetResult
    expected_names.append(MutateCampaignBudgetResult.__name__)
    from google.ads.googleads import GetCampaignCriterionRequest
    expected_names.append(GetCampaignCriterionRequest.__name__)
    from google.ads.googleads import MutateCampaignCriteriaRequest
    expected_names.append(MutateCampaignCriteriaRequest.__name__)
    from google.ads.googleads import CampaignCriterionOperation
    expected_names.append(CampaignCriterionOperation.__name__)
    from google.ads.googleads import MutateCampaignCriteriaResponse
    expected_names.append(MutateCampaignCriteriaResponse.__name__)
    from google.ads.googleads import MutateCampaignCriterionResult
    expected_names.append(MutateCampaignCriterionResult.__name__)
    from google.ads.googleads import GetCampaignDraftRequest
    expected_names.append(GetCampaignDraftRequest.__name__)
    from google.ads.googleads import MutateCampaignDraftsRequest
    expected_names.append(MutateCampaignDraftsRequest.__name__)
    from google.ads.googleads import PromoteCampaignDraftRequest
    expected_names.append(PromoteCampaignDraftRequest.__name__)
    from google.ads.googleads import CampaignDraftOperation
    expected_names.append(CampaignDraftOperation.__name__)
    from google.ads.googleads import MutateCampaignDraftsResponse
    expected_names.append(MutateCampaignDraftsResponse.__name__)
    from google.ads.googleads import MutateCampaignDraftResult
    expected_names.append(MutateCampaignDraftResult.__name__)
    from google.ads.googleads import ListCampaignDraftAsyncErrorsRequest
    expected_names.append(ListCampaignDraftAsyncErrorsRequest.__name__)
    from google.ads.googleads import ListCampaignDraftAsyncErrorsResponse
    expected_names.append(ListCampaignDraftAsyncErrorsResponse.__name__)
    from google.ads.googleads import GetCampaignExperimentRequest
    expected_names.append(GetCampaignExperimentRequest.__name__)
    from google.ads.googleads import MutateCampaignExperimentsRequest
    expected_names.append(MutateCampaignExperimentsRequest.__name__)
    from google.ads.googleads import CampaignExperimentOperation
    expected_names.append(CampaignExperimentOperation.__name__)
    from google.ads.googleads import MutateCampaignExperimentsResponse
    expected_names.append(MutateCampaignExperimentsResponse.__name__)
    from google.ads.googleads import MutateCampaignExperimentResult
    expected_names.append(MutateCampaignExperimentResult.__name__)
    from google.ads.googleads import CreateCampaignExperimentRequest
    expected_names.append(CreateCampaignExperimentRequest.__name__)
    from google.ads.googleads import CreateCampaignExperimentMetadata
    expected_names.append(CreateCampaignExperimentMetadata.__name__)
    from google.ads.googleads import GraduateCampaignExperimentRequest
    expected_names.append(GraduateCampaignExperimentRequest.__name__)
    from google.ads.googleads import GraduateCampaignExperimentResponse
    expected_names.append(GraduateCampaignExperimentResponse.__name__)
    from google.ads.googleads import PromoteCampaignExperimentRequest
    expected_names.append(PromoteCampaignExperimentRequest.__name__)
    from google.ads.googleads import EndCampaignExperimentRequest
    expected_names.append(EndCampaignExperimentRequest.__name__)
    from google.ads.googleads import ListCampaignExperimentAsyncErrorsRequest
    expected_names.append(ListCampaignExperimentAsyncErrorsRequest.__name__)
    from google.ads.googleads import ListCampaignExperimentAsyncErrorsResponse
    expected_names.append(ListCampaignExperimentAsyncErrorsResponse.__name__)
    from google.ads.googleads import GetCampaignExtensionSettingRequest
    expected_names.append(GetCampaignExtensionSettingRequest.__name__)
    from google.ads.googleads import MutateCampaignExtensionSettingsRequest
    expected_names.append(MutateCampaignExtensionSettingsRequest.__name__)
    from google.ads.googleads import CampaignExtensionSettingOperation
    expected_names.append(CampaignExtensionSettingOperation.__name__)
    from google.ads.googleads import MutateCampaignExtensionSettingsResponse
    expected_names.append(MutateCampaignExtensionSettingsResponse.__name__)
    from google.ads.googleads import MutateCampaignExtensionSettingResult
    expected_names.append(MutateCampaignExtensionSettingResult.__name__)
    from google.ads.googleads import GetCampaignFeedRequest
    expected_names.append(GetCampaignFeedRequest.__name__)
    from google.ads.googleads import MutateCampaignFeedsRequest
    expected_names.append(MutateCampaignFeedsRequest.__name__)
    from google.ads.googleads import CampaignFeedOperation
    expected_names.append(CampaignFeedOperation.__name__)
    from google.ads.googleads import MutateCampaignFeedsResponse
    expected_names.append(MutateCampaignFeedsResponse.__name__)
    from google.ads.googleads import MutateCampaignFeedResult
    expected_names.append(MutateCampaignFeedResult.__name__)
    from google.ads.googleads import GetCampaignLabelRequest
    expected_names.append(GetCampaignLabelRequest.__name__)
    from google.ads.googleads import MutateCampaignLabelsRequest
    expected_names.append(MutateCampaignLabelsRequest.__name__)
    from google.ads.googleads import CampaignLabelOperation
    expected_names.append(CampaignLabelOperation.__name__)
    from google.ads.googleads import MutateCampaignLabelsResponse
    expected_names.append(MutateCampaignLabelsResponse.__name__)
    from google.ads.googleads import MutateCampaignLabelResult
    expected_names.append(MutateCampaignLabelResult.__name__)
    from google.ads.googleads import GetCampaignRequest
    expected_names.append(GetCampaignRequest.__name__)
    from google.ads.googleads import MutateCampaignsRequest
    expected_names.append(MutateCampaignsRequest.__name__)
    from google.ads.googleads import CampaignOperation
    expected_names.append(CampaignOperation.__name__)
    from google.ads.googleads import MutateCampaignsResponse
    expected_names.append(MutateCampaignsResponse.__name__)
    from google.ads.googleads import MutateCampaignResult
    expected_names.append(MutateCampaignResult.__name__)
    from google.ads.googleads import GetCampaignSharedSetRequest
    expected_names.append(GetCampaignSharedSetRequest.__name__)
    from google.ads.googleads import MutateCampaignSharedSetsRequest
    expected_names.append(MutateCampaignSharedSetsRequest.__name__)
    from google.ads.googleads import CampaignSharedSetOperation
    expected_names.append(CampaignSharedSetOperation.__name__)
    from google.ads.googleads import MutateCampaignSharedSetsResponse
    expected_names.append(MutateCampaignSharedSetsResponse.__name__)
    from google.ads.googleads import MutateCampaignSharedSetResult
    expected_names.append(MutateCampaignSharedSetResult.__name__)
    from google.ads.googleads import GetConversionActionRequest
    expected_names.append(GetConversionActionRequest.__name__)
    from google.ads.googleads import MutateConversionActionsRequest
    expected_names.append(MutateConversionActionsRequest.__name__)
    from google.ads.googleads import ConversionActionOperation
    expected_names.append(ConversionActionOperation.__name__)
    from google.ads.googleads import MutateConversionActionsResponse
    expected_names.append(MutateConversionActionsResponse.__name__)
    from google.ads.googleads import MutateConversionActionResult
    expected_names.append(MutateConversionActionResult.__name__)
    from google.ads.googleads import GetConversionCustomVariableRequest
    expected_names.append(GetConversionCustomVariableRequest.__name__)
    from google.ads.googleads import MutateConversionCustomVariablesRequest
    expected_names.append(MutateConversionCustomVariablesRequest.__name__)
    from google.ads.googleads import ConversionCustomVariableOperation
    expected_names.append(ConversionCustomVariableOperation.__name__)
    from google.ads.googleads import MutateConversionCustomVariablesResponse
    expected_names.append(MutateConversionCustomVariablesResponse.__name__)
    from google.ads.googleads import MutateConversionCustomVariableResult
    expected_names.append(MutateConversionCustomVariableResult.__name__)
    from google.ads.googleads import GetCustomerAssetRequest
    expected_names.append(GetCustomerAssetRequest.__name__)
    from google.ads.googleads import MutateCustomerAssetsRequest
    expected_names.append(MutateCustomerAssetsRequest.__name__)
    from google.ads.googleads import CustomerAssetOperation
    expected_names.append(CustomerAssetOperation.__name__)
    from google.ads.googleads import MutateCustomerAssetsResponse
    expected_names.append(MutateCustomerAssetsResponse.__name__)
    from google.ads.googleads import MutateCustomerAssetResult
    expected_names.append(MutateCustomerAssetResult.__name__)
    from google.ads.googleads import GetCustomerExtensionSettingRequest
    expected_names.append(GetCustomerExtensionSettingRequest.__name__)
    from google.ads.googleads import MutateCustomerExtensionSettingsRequest
    expected_names.append(MutateCustomerExtensionSettingsRequest.__name__)
    from google.ads.googleads import CustomerExtensionSettingOperation
    expected_names.append(CustomerExtensionSettingOperation.__name__)
    from google.ads.googleads import MutateCustomerExtensionSettingsResponse
    expected_names.append(MutateCustomerExtensionSettingsResponse.__name__)
    from google.ads.googleads import MutateCustomerExtensionSettingResult
    expected_names.append(MutateCustomerExtensionSettingResult.__name__)
    from google.ads.googleads import GetCustomerFeedRequest
    expected_names.append(GetCustomerFeedRequest.__name__)
    from google.ads.googleads import MutateCustomerFeedsRequest
    expected_names.append(MutateCustomerFeedsRequest.__name__)
    from google.ads.googleads import CustomerFeedOperation
    expected_names.append(CustomerFeedOperation.__name__)
    from google.ads.googleads import MutateCustomerFeedsResponse
    expected_names.append(MutateCustomerFeedsResponse.__name__)
    from google.ads.googleads import MutateCustomerFeedResult
    expected_names.append(MutateCustomerFeedResult.__name__)
    from google.ads.googleads import GetCustomerLabelRequest
    expected_names.append(GetCustomerLabelRequest.__name__)
    from google.ads.googleads import MutateCustomerLabelsRequest
    expected_names.append(MutateCustomerLabelsRequest.__name__)
    from google.ads.googleads import CustomerLabelOperation
    expected_names.append(CustomerLabelOperation.__name__)
    from google.ads.googleads import MutateCustomerLabelsResponse
    expected_names.append(MutateCustomerLabelsResponse.__name__)
    from google.ads.googleads import MutateCustomerLabelResult
    expected_names.append(MutateCustomerLabelResult.__name__)
    from google.ads.googleads import GetCustomerNegativeCriterionRequest
    expected_names.append(GetCustomerNegativeCriterionRequest.__name__)
    from google.ads.googleads import MutateCustomerNegativeCriteriaRequest
    expected_names.append(MutateCustomerNegativeCriteriaRequest.__name__)
    from google.ads.googleads import CustomerNegativeCriterionOperation
    expected_names.append(CustomerNegativeCriterionOperation.__name__)
    from google.ads.googleads import MutateCustomerNegativeCriteriaResponse
    expected_names.append(MutateCustomerNegativeCriteriaResponse.__name__)
    from google.ads.googleads import MutateCustomerNegativeCriteriaResult
    expected_names.append(MutateCustomerNegativeCriteriaResult.__name__)
    from google.ads.googleads import GetCustomerRequest
    expected_names.append(GetCustomerRequest.__name__)
    from google.ads.googleads import MutateCustomerRequest
    expected_names.append(MutateCustomerRequest.__name__)
    from google.ads.googleads import CreateCustomerClientRequest
    expected_names.append(CreateCustomerClientRequest.__name__)
    from google.ads.googleads import CustomerOperation
    expected_names.append(CustomerOperation.__name__)
    from google.ads.googleads import CreateCustomerClientResponse
    expected_names.append(CreateCustomerClientResponse.__name__)
    from google.ads.googleads import MutateCustomerResponse
    expected_names.append(MutateCustomerResponse.__name__)
    from google.ads.googleads import MutateCustomerResult
    expected_names.append(MutateCustomerResult.__name__)
    from google.ads.googleads import ListAccessibleCustomersRequest
    expected_names.append(ListAccessibleCustomersRequest.__name__)
    from google.ads.googleads import ListAccessibleCustomersResponse
    expected_names.append(ListAccessibleCustomersResponse.__name__)
    from google.ads.googleads import GetExtensionFeedItemRequest
    expected_names.append(GetExtensionFeedItemRequest.__name__)
    from google.ads.googleads import MutateExtensionFeedItemsRequest
    expected_names.append(MutateExtensionFeedItemsRequest.__name__)
    from google.ads.googleads import ExtensionFeedItemOperation
    expected_names.append(ExtensionFeedItemOperation.__name__)
    from google.ads.googleads import MutateExtensionFeedItemsResponse
    expected_names.append(MutateExtensionFeedItemsResponse.__name__)
    from google.ads.googleads import MutateExtensionFeedItemResult
    expected_names.append(MutateExtensionFeedItemResult.__name__)
    from google.ads.googleads import GetFeedItemRequest
    expected_names.append(GetFeedItemRequest.__name__)
    from google.ads.googleads import MutateFeedItemsRequest
    expected_names.append(MutateFeedItemsRequest.__name__)
    from google.ads.googleads import FeedItemOperation
    expected_names.append(FeedItemOperation.__name__)
    from google.ads.googleads import MutateFeedItemsResponse
    expected_names.append(MutateFeedItemsResponse.__name__)
    from google.ads.googleads import MutateFeedItemResult
    expected_names.append(MutateFeedItemResult.__name__)
    from google.ads.googleads import GetFeedItemSetLinkRequest
    expected_names.append(GetFeedItemSetLinkRequest.__name__)
    from google.ads.googleads import MutateFeedItemSetLinksRequest
    expected_names.append(MutateFeedItemSetLinksRequest.__name__)
    from google.ads.googleads import FeedItemSetLinkOperation
    expected_names.append(FeedItemSetLinkOperation.__name__)
    from google.ads.googleads import MutateFeedItemSetLinksResponse
    expected_names.append(MutateFeedItemSetLinksResponse.__name__)
    from google.ads.googleads import MutateFeedItemSetLinkResult
    expected_names.append(MutateFeedItemSetLinkResult.__name__)
    from google.ads.googleads import GetFeedItemSetRequest
    expected_names.append(GetFeedItemSetRequest.__name__)
    from google.ads.googleads import MutateFeedItemSetsRequest
    expected_names.append(MutateFeedItemSetsRequest.__name__)
    from google.ads.googleads import FeedItemSetOperation
    expected_names.append(FeedItemSetOperation.__name__)
    from google.ads.googleads import MutateFeedItemSetsResponse
    expected_names.append(MutateFeedItemSetsResponse.__name__)
    from google.ads.googleads import MutateFeedItemSetResult
    expected_names.append(MutateFeedItemSetResult.__name__)
    from google.ads.googleads import GetFeedItemTargetRequest
    expected_names.append(GetFeedItemTargetRequest.__name__)
    from google.ads.googleads import MutateFeedItemTargetsRequest
    expected_names.append(MutateFeedItemTargetsRequest.__name__)
    from google.ads.googleads import FeedItemTargetOperation
    expected_names.append(FeedItemTargetOperation.__name__)
    from google.ads.googleads import MutateFeedItemTargetsResponse
    expected_names.append(MutateFeedItemTargetsResponse.__name__)
    from google.ads.googleads import MutateFeedItemTargetResult
    expected_names.append(MutateFeedItemTargetResult.__name__)
    from google.ads.googleads import GetFeedMappingRequest
    expected_names.append(GetFeedMappingRequest.__name__)
    from google.ads.googleads import MutateFeedMappingsRequest
    expected_names.append(MutateFeedMappingsRequest.__name__)
    from google.ads.googleads import FeedMappingOperation
    expected_names.append(FeedMappingOperation.__name__)
    from google.ads.googleads import MutateFeedMappingsResponse
    expected_names.append(MutateFeedMappingsResponse.__name__)
    from google.ads.googleads import MutateFeedMappingResult
    expected_names.append(MutateFeedMappingResult.__name__)
    from google.ads.googleads import GetFeedRequest
    expected_names.append(GetFeedRequest.__name__)
    from google.ads.googleads import MutateFeedsRequest
    expected_names.append(MutateFeedsRequest.__name__)
    from google.ads.googleads import FeedOperation
    expected_names.append(FeedOperation.__name__)
    from google.ads.googleads import MutateFeedsResponse
    expected_names.append(MutateFeedsResponse.__name__)
    from google.ads.googleads import MutateFeedResult
    expected_names.append(MutateFeedResult.__name__)
    from google.ads.googleads import GetKeywordPlanAdGroupKeywordRequest
    expected_names.append(GetKeywordPlanAdGroupKeywordRequest.__name__)
    from google.ads.googleads import MutateKeywordPlanAdGroupKeywordsRequest
    expected_names.append(MutateKeywordPlanAdGroupKeywordsRequest.__name__)
    from google.ads.googleads import KeywordPlanAdGroupKeywordOperation
    expected_names.append(KeywordPlanAdGroupKeywordOperation.__name__)
    from google.ads.googleads import MutateKeywordPlanAdGroupKeywordsResponse
    expected_names.append(MutateKeywordPlanAdGroupKeywordsResponse.__name__)
    from google.ads.googleads import MutateKeywordPlanAdGroupKeywordResult
    expected_names.append(MutateKeywordPlanAdGroupKeywordResult.__name__)
    from google.ads.googleads import GetKeywordPlanAdGroupRequest
    expected_names.append(GetKeywordPlanAdGroupRequest.__name__)
    from google.ads.googleads import MutateKeywordPlanAdGroupsRequest
    expected_names.append(MutateKeywordPlanAdGroupsRequest.__name__)
    from google.ads.googleads import KeywordPlanAdGroupOperation
    expected_names.append(KeywordPlanAdGroupOperation.__name__)
    from google.ads.googleads import MutateKeywordPlanAdGroupsResponse
    expected_names.append(MutateKeywordPlanAdGroupsResponse.__name__)
    from google.ads.googleads import MutateKeywordPlanAdGroupResult
    expected_names.append(MutateKeywordPlanAdGroupResult.__name__)
    from google.ads.googleads import GetKeywordPlanCampaignKeywordRequest
    expected_names.append(GetKeywordPlanCampaignKeywordRequest.__name__)
    from google.ads.googleads import MutateKeywordPlanCampaignKeywordsRequest
    expected_names.append(MutateKeywordPlanCampaignKeywordsRequest.__name__)
    from google.ads.googleads import KeywordPlanCampaignKeywordOperation
    expected_names.append(KeywordPlanCampaignKeywordOperation.__name__)
    from google.ads.googleads import MutateKeywordPlanCampaignKeywordsResponse
    expected_names.append(MutateKeywordPlanCampaignKeywordsResponse.__name__)
    from google.ads.googleads import MutateKeywordPlanCampaignKeywordResult
    expected_names.append(MutateKeywordPlanCampaignKeywordResult.__name__)
    from google.ads.googleads import GetKeywordPlanCampaignRequest
    expected_names.append(GetKeywordPlanCampaignRequest.__name__)
    from google.ads.googleads import MutateKeywordPlanCampaignsRequest
    expected_names.append(MutateKeywordPlanCampaignsRequest.__name__)
    from google.ads.googleads import KeywordPlanCampaignOperation
    expected_names.append(KeywordPlanCampaignOperation.__name__)
    from google.ads.googleads import MutateKeywordPlanCampaignsResponse
    expected_names.append(MutateKeywordPlanCampaignsResponse.__name__)
    from google.ads.googleads import MutateKeywordPlanCampaignResult
    expected_names.append(MutateKeywordPlanCampaignResult.__name__)
    from google.ads.googleads import GetKeywordPlanRequest
    expected_names.append(GetKeywordPlanRequest.__name__)
    from google.ads.googleads import MutateKeywordPlansRequest
    expected_names.append(MutateKeywordPlansRequest.__name__)
    from google.ads.googleads import KeywordPlanOperation
    expected_names.append(KeywordPlanOperation.__name__)
    from google.ads.googleads import MutateKeywordPlansResponse
    expected_names.append(MutateKeywordPlansResponse.__name__)
    from google.ads.googleads import MutateKeywordPlansResult
    expected_names.append(MutateKeywordPlansResult.__name__)
    from google.ads.googleads import GenerateForecastCurveRequest
    expected_names.append(GenerateForecastCurveRequest.__name__)
    from google.ads.googleads import GenerateForecastCurveResponse
    expected_names.append(GenerateForecastCurveResponse.__name__)
    from google.ads.googleads import GenerateForecastTimeSeriesRequest
    expected_names.append(GenerateForecastTimeSeriesRequest.__name__)
    from google.ads.googleads import GenerateForecastTimeSeriesResponse
    expected_names.append(GenerateForecastTimeSeriesResponse.__name__)
    from google.ads.googleads import GenerateForecastMetricsRequest
    expected_names.append(GenerateForecastMetricsRequest.__name__)
    from google.ads.googleads import GenerateForecastMetricsResponse
    expected_names.append(GenerateForecastMetricsResponse.__name__)
    from google.ads.googleads import KeywordPlanCampaignForecast
    expected_names.append(KeywordPlanCampaignForecast.__name__)
    from google.ads.googleads import KeywordPlanAdGroupForecast
    expected_names.append(KeywordPlanAdGroupForecast.__name__)
    from google.ads.googleads import KeywordPlanKeywordForecast
    expected_names.append(KeywordPlanKeywordForecast.__name__)
    from google.ads.googleads import KeywordPlanCampaignForecastCurve
    expected_names.append(KeywordPlanCampaignForecastCurve.__name__)
    from google.ads.googleads import KeywordPlanMaxCpcBidForecastCurve
    expected_names.append(KeywordPlanMaxCpcBidForecastCurve.__name__)
    from google.ads.googleads import KeywordPlanMaxCpcBidForecast
    expected_names.append(KeywordPlanMaxCpcBidForecast.__name__)
    from google.ads.googleads import KeywordPlanWeeklyTimeSeriesForecast
    expected_names.append(KeywordPlanWeeklyTimeSeriesForecast.__name__)
    from google.ads.googleads import KeywordPlanWeeklyForecast
    expected_names.append(KeywordPlanWeeklyForecast.__name__)
    from google.ads.googleads import ForecastMetrics
    expected_names.append(ForecastMetrics.__name__)
    from google.ads.googleads import GenerateHistoricalMetricsRequest
    expected_names.append(GenerateHistoricalMetricsRequest.__name__)
    from google.ads.googleads import GenerateHistoricalMetricsResponse
    expected_names.append(GenerateHistoricalMetricsResponse.__name__)
    from google.ads.googleads import KeywordPlanKeywordHistoricalMetrics
    expected_names.append(KeywordPlanKeywordHistoricalMetrics.__name__)
    from google.ads.googleads import GetLabelRequest
    expected_names.append(GetLabelRequest.__name__)
    from google.ads.googleads import MutateLabelsRequest
    expected_names.append(MutateLabelsRequest.__name__)
    from google.ads.googleads import LabelOperation
    expected_names.append(LabelOperation.__name__)
    from google.ads.googleads import MutateLabelsResponse
    expected_names.append(MutateLabelsResponse.__name__)
    from google.ads.googleads import MutateLabelResult
    expected_names.append(MutateLabelResult.__name__)
    from google.ads.googleads import GetMediaFileRequest
    expected_names.append(GetMediaFileRequest.__name__)
    from google.ads.googleads import MutateMediaFilesRequest
    expected_names.append(MutateMediaFilesRequest.__name__)
    from google.ads.googleads import MediaFileOperation
    expected_names.append(MediaFileOperation.__name__)
    from google.ads.googleads import MutateMediaFilesResponse
    expected_names.append(MutateMediaFilesResponse.__name__)
    from google.ads.googleads import MutateMediaFileResult
    expected_names.append(MutateMediaFileResult.__name__)
    from google.ads.googleads import GetRemarketingActionRequest
    expected_names.append(GetRemarketingActionRequest.__name__)
    from google.ads.googleads import MutateRemarketingActionsRequest
    expected_names.append(MutateRemarketingActionsRequest.__name__)
    from google.ads.googleads import RemarketingActionOperation
    expected_names.append(RemarketingActionOperation.__name__)
    from google.ads.googleads import MutateRemarketingActionsResponse
    expected_names.append(MutateRemarketingActionsResponse.__name__)
    from google.ads.googleads import MutateRemarketingActionResult
    expected_names.append(MutateRemarketingActionResult.__name__)
    from google.ads.googleads import GetSharedCriterionRequest
    expected_names.append(GetSharedCriterionRequest.__name__)
    from google.ads.googleads import MutateSharedCriteriaRequest
    expected_names.append(MutateSharedCriteriaRequest.__name__)
    from google.ads.googleads import SharedCriterionOperation
    expected_names.append(SharedCriterionOperation.__name__)
    from google.ads.googleads import MutateSharedCriteriaResponse
    expected_names.append(MutateSharedCriteriaResponse.__name__)
    from google.ads.googleads import MutateSharedCriterionResult
    expected_names.append(MutateSharedCriterionResult.__name__)
    from google.ads.googleads import GetSharedSetRequest
    expected_names.append(GetSharedSetRequest.__name__)
    from google.ads.googleads import MutateSharedSetsRequest
    expected_names.append(MutateSharedSetsRequest.__name__)
    from google.ads.googleads import SharedSetOperation
    expected_names.append(SharedSetOperation.__name__)
    from google.ads.googleads import MutateSharedSetsResponse
    expected_names.append(MutateSharedSetsResponse.__name__)
    from google.ads.googleads import MutateSharedSetResult
    expected_names.append(MutateSharedSetResult.__name__)
    from google.ads.googleads import GetUserListRequest
    expected_names.append(GetUserListRequest.__name__)
    from google.ads.googleads import MutateUserListsRequest
    expected_names.append(MutateUserListsRequest.__name__)
    from google.ads.googleads import UserListOperation
    expected_names.append(UserListOperation.__name__)
    from google.ads.googleads import MutateUserListsResponse
    expected_names.append(MutateUserListsResponse.__name__)
    from google.ads.googleads import MutateUserListResult
    expected_names.append(MutateUserListResult.__name__)
    from google.ads.googleads import SearchGoogleAdsRequest
    expected_names.append(SearchGoogleAdsRequest.__name__)
    from google.ads.googleads import SearchGoogleAdsResponse
    expected_names.append(SearchGoogleAdsResponse.__name__)
    from google.ads.googleads import SearchGoogleAdsStreamRequest
    expected_names.append(SearchGoogleAdsStreamRequest.__name__)
    from google.ads.googleads import SearchGoogleAdsStreamResponse
    expected_names.append(SearchGoogleAdsStreamResponse.__name__)
    from google.ads.googleads import GoogleAdsRow
    expected_names.append(GoogleAdsRow.__name__)
    from google.ads.googleads import MutateGoogleAdsRequest
    expected_names.append(MutateGoogleAdsRequest.__name__)
    from google.ads.googleads import MutateGoogleAdsResponse
    expected_names.append(MutateGoogleAdsResponse.__name__)
    from google.ads.googleads import MutateOperation
    expected_names.append(MutateOperation.__name__)
    from google.ads.googleads import MutateOperationResponse
    expected_names.append(MutateOperationResponse.__name__)
    from google.ads.googleads import MutateBatchJobRequest
    expected_names.append(MutateBatchJobRequest.__name__)
    from google.ads.googleads import BatchJobOperation
    expected_names.append(BatchJobOperation.__name__)
    from google.ads.googleads import MutateBatchJobResponse
    expected_names.append(MutateBatchJobResponse.__name__)
    from google.ads.googleads import MutateBatchJobResult
    expected_names.append(MutateBatchJobResult.__name__)
    from google.ads.googleads import GetBatchJobRequest
    expected_names.append(GetBatchJobRequest.__name__)
    from google.ads.googleads import RunBatchJobRequest
    expected_names.append(RunBatchJobRequest.__name__)
    from google.ads.googleads import AddBatchJobOperationsRequest
    expected_names.append(AddBatchJobOperationsRequest.__name__)
    from google.ads.googleads import AddBatchJobOperationsResponse
    expected_names.append(AddBatchJobOperationsResponse.__name__)
    from google.ads.googleads import ListBatchJobResultsRequest
    expected_names.append(ListBatchJobResultsRequest.__name__)
    from google.ads.googleads import ListBatchJobResultsResponse
    expected_names.append(ListBatchJobResultsResponse.__name__)
    from google.ads.googleads import BatchJobResult
    expected_names.append(BatchJobResult.__name__)
    from google.ads.googleads import GetBiddingStrategySimulationRequest
    expected_names.append(GetBiddingStrategySimulationRequest.__name__)
    from google.ads.googleads import GetBillingSetupRequest
    expected_names.append(GetBillingSetupRequest.__name__)
    from google.ads.googleads import MutateBillingSetupRequest
    expected_names.append(MutateBillingSetupRequest.__name__)
    from google.ads.googleads import BillingSetupOperation
    expected_names.append(BillingSetupOperation.__name__)
    from google.ads.googleads import MutateBillingSetupResponse
    expected_names.append(MutateBillingSetupResponse.__name__)
    from google.ads.googleads import MutateBillingSetupResult
    expected_names.append(MutateBillingSetupResult.__name__)
    from google.ads.googleads import GetCampaignAudienceViewRequest
    expected_names.append(GetCampaignAudienceViewRequest.__name__)
    from google.ads.googleads import GetCampaignCriterionSimulationRequest
    expected_names.append(GetCampaignCriterionSimulationRequest.__name__)
    from google.ads.googleads import GetCampaignSimulationRequest
    expected_names.append(GetCampaignSimulationRequest.__name__)
    from google.ads.googleads import GetCarrierConstantRequest
    expected_names.append(GetCarrierConstantRequest.__name__)
    from google.ads.googleads import GetChangeStatusRequest
    expected_names.append(GetChangeStatusRequest.__name__)
    from google.ads.googleads import GetClickViewRequest
    expected_names.append(GetClickViewRequest.__name__)
    from google.ads.googleads import GetCombinedAudienceRequest
    expected_names.append(GetCombinedAudienceRequest.__name__)
    from google.ads.googleads import UploadConversionAdjustmentsRequest
    expected_names.append(UploadConversionAdjustmentsRequest.__name__)
    from google.ads.googleads import UploadConversionAdjustmentsResponse
    expected_names.append(UploadConversionAdjustmentsResponse.__name__)
    from google.ads.googleads import ConversionAdjustment
    expected_names.append(ConversionAdjustment.__name__)
    from google.ads.googleads import RestatementValue
    expected_names.append(RestatementValue.__name__)
    from google.ads.googleads import GclidDateTimePair
    expected_names.append(GclidDateTimePair.__name__)
    from google.ads.googleads import ConversionAdjustmentResult
    expected_names.append(ConversionAdjustmentResult.__name__)
    from google.ads.googleads import UploadClickConversionsRequest
    expected_names.append(UploadClickConversionsRequest.__name__)
    from google.ads.googleads import UploadClickConversionsResponse
    expected_names.append(UploadClickConversionsResponse.__name__)
    from google.ads.googleads import UploadCallConversionsRequest
    expected_names.append(UploadCallConversionsRequest.__name__)
    from google.ads.googleads import UploadCallConversionsResponse
    expected_names.append(UploadCallConversionsResponse.__name__)
    from google.ads.googleads import ClickConversion
    expected_names.append(ClickConversion.__name__)
    from google.ads.googleads import CallConversion
    expected_names.append(CallConversion.__name__)
    from google.ads.googleads import ExternalAttributionData
    expected_names.append(ExternalAttributionData.__name__)
    from google.ads.googleads import ClickConversionResult
    expected_names.append(ClickConversionResult.__name__)
    from google.ads.googleads import CallConversionResult
    expected_names.append(CallConversionResult.__name__)
    from google.ads.googleads import CustomVariable
    expected_names.append(CustomVariable.__name__)
    from google.ads.googleads import GetCurrencyConstantRequest
    expected_names.append(GetCurrencyConstantRequest.__name__)
    from google.ads.googleads import GetCustomAudienceRequest
    expected_names.append(GetCustomAudienceRequest.__name__)
    from google.ads.googleads import MutateCustomAudiencesRequest
    expected_names.append(MutateCustomAudiencesRequest.__name__)
    from google.ads.googleads import CustomAudienceOperation
    expected_names.append(CustomAudienceOperation.__name__)
    from google.ads.googleads import MutateCustomAudiencesResponse
    expected_names.append(MutateCustomAudiencesResponse.__name__)
    from google.ads.googleads import MutateCustomAudienceResult
    expected_names.append(MutateCustomAudienceResult.__name__)
    from google.ads.googleads import GetCustomInterestRequest
    expected_names.append(GetCustomInterestRequest.__name__)
    from google.ads.googleads import MutateCustomInterestsRequest
    expected_names.append(MutateCustomInterestsRequest.__name__)
    from google.ads.googleads import CustomInterestOperation
    expected_names.append(CustomInterestOperation.__name__)
    from google.ads.googleads import MutateCustomInterestsResponse
    expected_names.append(MutateCustomInterestsResponse.__name__)
    from google.ads.googleads import MutateCustomInterestResult
    expected_names.append(MutateCustomInterestResult.__name__)
    from google.ads.googleads import GetCustomerClientLinkRequest
    expected_names.append(GetCustomerClientLinkRequest.__name__)
    from google.ads.googleads import MutateCustomerClientLinkRequest
    expected_names.append(MutateCustomerClientLinkRequest.__name__)
    from google.ads.googleads import CustomerClientLinkOperation
    expected_names.append(CustomerClientLinkOperation.__name__)
    from google.ads.googleads import MutateCustomerClientLinkResponse
    expected_names.append(MutateCustomerClientLinkResponse.__name__)
    from google.ads.googleads import MutateCustomerClientLinkResult
    expected_names.append(MutateCustomerClientLinkResult.__name__)
    from google.ads.googleads import GetCustomerClientRequest
    expected_names.append(GetCustomerClientRequest.__name__)
    from google.ads.googleads import GetCustomerManagerLinkRequest
    expected_names.append(GetCustomerManagerLinkRequest.__name__)
    from google.ads.googleads import MutateCustomerManagerLinkRequest
    expected_names.append(MutateCustomerManagerLinkRequest.__name__)
    from google.ads.googleads import MoveManagerLinkRequest
    expected_names.append(MoveManagerLinkRequest.__name__)
    from google.ads.googleads import CustomerManagerLinkOperation
    expected_names.append(CustomerManagerLinkOperation.__name__)
    from google.ads.googleads import MutateCustomerManagerLinkResponse
    expected_names.append(MutateCustomerManagerLinkResponse.__name__)
    from google.ads.googleads import MoveManagerLinkResponse
    expected_names.append(MoveManagerLinkResponse.__name__)
    from google.ads.googleads import MutateCustomerManagerLinkResult
    expected_names.append(MutateCustomerManagerLinkResult.__name__)
    from google.ads.googleads import GetCustomerUserAccessInvitationRequest
    expected_names.append(GetCustomerUserAccessInvitationRequest.__name__)
    from google.ads.googleads import MutateCustomerUserAccessInvitationRequest
    expected_names.append(MutateCustomerUserAccessInvitationRequest.__name__)
    from google.ads.googleads import CustomerUserAccessInvitationOperation
    expected_names.append(CustomerUserAccessInvitationOperation.__name__)
    from google.ads.googleads import MutateCustomerUserAccessInvitationResponse
    expected_names.append(MutateCustomerUserAccessInvitationResponse.__name__)
    from google.ads.googleads import MutateCustomerUserAccessInvitationResult
    expected_names.append(MutateCustomerUserAccessInvitationResult.__name__)
    from google.ads.googleads import GetCustomerUserAccessRequest
    expected_names.append(GetCustomerUserAccessRequest.__name__)
    from google.ads.googleads import MutateCustomerUserAccessRequest
    expected_names.append(MutateCustomerUserAccessRequest.__name__)
    from google.ads.googleads import CustomerUserAccessOperation
    expected_names.append(CustomerUserAccessOperation.__name__)
    from google.ads.googleads import MutateCustomerUserAccessResponse
    expected_names.append(MutateCustomerUserAccessResponse.__name__)
    from google.ads.googleads import MutateCustomerUserAccessResult
    expected_names.append(MutateCustomerUserAccessResult.__name__)
    from google.ads.googleads import GetDetailPlacementViewRequest
    expected_names.append(GetDetailPlacementViewRequest.__name__)
    from google.ads.googleads import GetDisplayKeywordViewRequest
    expected_names.append(GetDisplayKeywordViewRequest.__name__)
    from google.ads.googleads import GetDistanceViewRequest
    expected_names.append(GetDistanceViewRequest.__name__)
    from google.ads.googleads import GetDomainCategoryRequest
    expected_names.append(GetDomainCategoryRequest.__name__)
    from google.ads.googleads import GetDynamicSearchAdsSearchTermViewRequest
    expected_names.append(GetDynamicSearchAdsSearchTermViewRequest.__name__)
    from google.ads.googleads import GetExpandedLandingPageViewRequest
    expected_names.append(GetExpandedLandingPageViewRequest.__name__)
    from google.ads.googleads import GetFeedPlaceholderViewRequest
    expected_names.append(GetFeedPlaceholderViewRequest.__name__)
    from google.ads.googleads import GetGenderViewRequest
    expected_names.append(GetGenderViewRequest.__name__)
    from google.ads.googleads import GetGeoTargetConstantRequest
    expected_names.append(GetGeoTargetConstantRequest.__name__)
    from google.ads.googleads import SuggestGeoTargetConstantsRequest
    expected_names.append(SuggestGeoTargetConstantsRequest.__name__)
    from google.ads.googleads import SuggestGeoTargetConstantsResponse
    expected_names.append(SuggestGeoTargetConstantsResponse.__name__)
    from google.ads.googleads import GeoTargetConstantSuggestion
    expected_names.append(GeoTargetConstantSuggestion.__name__)
    from google.ads.googleads import GetGeographicViewRequest
    expected_names.append(GetGeographicViewRequest.__name__)
    from google.ads.googleads import GetGoogleAdsFieldRequest
    expected_names.append(GetGoogleAdsFieldRequest.__name__)
    from google.ads.googleads import SearchGoogleAdsFieldsRequest
    expected_names.append(SearchGoogleAdsFieldsRequest.__name__)
    from google.ads.googleads import SearchGoogleAdsFieldsResponse
    expected_names.append(SearchGoogleAdsFieldsResponse.__name__)
    from google.ads.googleads import GetGroupPlacementViewRequest
    expected_names.append(GetGroupPlacementViewRequest.__name__)
    from google.ads.googleads import GetHotelGroupViewRequest
    expected_names.append(GetHotelGroupViewRequest.__name__)
    from google.ads.googleads import GetHotelPerformanceViewRequest
    expected_names.append(GetHotelPerformanceViewRequest.__name__)
    from google.ads.googleads import GetIncomeRangeViewRequest
    expected_names.append(GetIncomeRangeViewRequest.__name__)
    from google.ads.googleads import ListInvoicesRequest
    expected_names.append(ListInvoicesRequest.__name__)
    from google.ads.googleads import ListInvoicesResponse
    expected_names.append(ListInvoicesResponse.__name__)
    from google.ads.googleads import GenerateKeywordIdeasRequest
    expected_names.append(GenerateKeywordIdeasRequest.__name__)
    from google.ads.googleads import KeywordAndUrlSeed
    expected_names.append(KeywordAndUrlSeed.__name__)
    from google.ads.googleads import KeywordSeed
    expected_names.append(KeywordSeed.__name__)
    from google.ads.googleads import SiteSeed
    expected_names.append(SiteSeed.__name__)
    from google.ads.googleads import UrlSeed
    expected_names.append(UrlSeed.__name__)
    from google.ads.googleads import GenerateKeywordIdeaResponse
    expected_names.append(GenerateKeywordIdeaResponse.__name__)
    from google.ads.googleads import GenerateKeywordIdeaResult
    expected_names.append(GenerateKeywordIdeaResult.__name__)
    from google.ads.googleads import GetKeywordViewRequest
    expected_names.append(GetKeywordViewRequest.__name__)
    from google.ads.googleads import GetLandingPageViewRequest
    expected_names.append(GetLandingPageViewRequest.__name__)
    from google.ads.googleads import GetLanguageConstantRequest
    expected_names.append(GetLanguageConstantRequest.__name__)
    from google.ads.googleads import GetLifeEventRequest
    expected_names.append(GetLifeEventRequest.__name__)
    from google.ads.googleads import GetLocationViewRequest
    expected_names.append(GetLocationViewRequest.__name__)
    from google.ads.googleads import GetManagedPlacementViewRequest
    expected_names.append(GetManagedPlacementViewRequest.__name__)
    from google.ads.googleads import ListMerchantCenterLinksRequest
    expected_names.append(ListMerchantCenterLinksRequest.__name__)
    from google.ads.googleads import ListMerchantCenterLinksResponse
    expected_names.append(ListMerchantCenterLinksResponse.__name__)
    from google.ads.googleads import GetMerchantCenterLinkRequest
    expected_names.append(GetMerchantCenterLinkRequest.__name__)
    from google.ads.googleads import MutateMerchantCenterLinkRequest
    expected_names.append(MutateMerchantCenterLinkRequest.__name__)
    from google.ads.googleads import MerchantCenterLinkOperation
    expected_names.append(MerchantCenterLinkOperation.__name__)
    from google.ads.googleads import MutateMerchantCenterLinkResponse
    expected_names.append(MutateMerchantCenterLinkResponse.__name__)
    from google.ads.googleads import MutateMerchantCenterLinkResult
    expected_names.append(MutateMerchantCenterLinkResult.__name__)
    from google.ads.googleads import GetMobileAppCategoryConstantRequest
    expected_names.append(GetMobileAppCategoryConstantRequest.__name__)
    from google.ads.googleads import GetMobileDeviceConstantRequest
    expected_names.append(GetMobileDeviceConstantRequest.__name__)
    from google.ads.googleads import CreateOfflineUserDataJobRequest
    expected_names.append(CreateOfflineUserDataJobRequest.__name__)
    from google.ads.googleads import CreateOfflineUserDataJobResponse
    expected_names.append(CreateOfflineUserDataJobResponse.__name__)
    from google.ads.googleads import GetOfflineUserDataJobRequest
    expected_names.append(GetOfflineUserDataJobRequest.__name__)
    from google.ads.googleads import RunOfflineUserDataJobRequest
    expected_names.append(RunOfflineUserDataJobRequest.__name__)
    from google.ads.googleads import AddOfflineUserDataJobOperationsRequest
    expected_names.append(AddOfflineUserDataJobOperationsRequest.__name__)
    from google.ads.googleads import OfflineUserDataJobOperation
    expected_names.append(OfflineUserDataJobOperation.__name__)
    from google.ads.googleads import AddOfflineUserDataJobOperationsResponse
    expected_names.append(AddOfflineUserDataJobOperationsResponse.__name__)
    from google.ads.googleads import GetOperatingSystemVersionConstantRequest
    expected_names.append(GetOperatingSystemVersionConstantRequest.__name__)
    from google.ads.googleads import GetPaidOrganicSearchTermViewRequest
    expected_names.append(GetPaidOrganicSearchTermViewRequest.__name__)
    from google.ads.googleads import GetParentalStatusViewRequest
    expected_names.append(GetParentalStatusViewRequest.__name__)
    from google.ads.googleads import ListPaymentsAccountsRequest
    expected_names.append(ListPaymentsAccountsRequest.__name__)
    from google.ads.googleads import ListPaymentsAccountsResponse
    expected_names.append(ListPaymentsAccountsResponse.__name__)
    from google.ads.googleads import GetProductBiddingCategoryConstantRequest
    expected_names.append(GetProductBiddingCategoryConstantRequest.__name__)
    from google.ads.googleads import GetProductGroupViewRequest
    expected_names.append(GetProductGroupViewRequest.__name__)
    from google.ads.googleads import ListPlannableLocationsRequest
    expected_names.append(ListPlannableLocationsRequest.__name__)
    from google.ads.googleads import ListPlannableLocationsResponse
    expected_names.append(ListPlannableLocationsResponse.__name__)
    from google.ads.googleads import PlannableLocation
    expected_names.append(PlannableLocation.__name__)
    from google.ads.googleads import ListPlannableProductsRequest
    expected_names.append(ListPlannableProductsRequest.__name__)
    from google.ads.googleads import ListPlannableProductsResponse
    expected_names.append(ListPlannableProductsResponse.__name__)
    from google.ads.googleads import ProductMetadata
    expected_names.append(ProductMetadata.__name__)
    from google.ads.googleads import PlannableTargeting
    expected_names.append(PlannableTargeting.__name__)
    from google.ads.googleads import GenerateProductMixIdeasRequest
    expected_names.append(GenerateProductMixIdeasRequest.__name__)
    from google.ads.googleads import Preferences
    expected_names.append(Preferences.__name__)
    from google.ads.googleads import GenerateProductMixIdeasResponse
    expected_names.append(GenerateProductMixIdeasResponse.__name__)
    from google.ads.googleads import ProductAllocation
    expected_names.append(ProductAllocation.__name__)
    from google.ads.googleads import GenerateReachForecastRequest
    expected_names.append(GenerateReachForecastRequest.__name__)
    from google.ads.googleads import FrequencyCap
    expected_names.append(FrequencyCap.__name__)
    from google.ads.googleads import Targeting
    expected_names.append(Targeting.__name__)
    from google.ads.googleads import CampaignDuration
    expected_names.append(CampaignDuration.__name__)
    from google.ads.googleads import PlannedProduct
    expected_names.append(PlannedProduct.__name__)
    from google.ads.googleads import GenerateReachForecastResponse
    expected_names.append(GenerateReachForecastResponse.__name__)
    from google.ads.googleads import ReachCurve
    expected_names.append(ReachCurve.__name__)
    from google.ads.googleads import ReachForecast
    expected_names.append(ReachForecast.__name__)
    from google.ads.googleads import Forecast
    expected_names.append(Forecast.__name__)
    from google.ads.googleads import PlannedProductReachForecast
    expected_names.append(PlannedProductReachForecast.__name__)
    from google.ads.googleads import PlannedProductForecast
    expected_names.append(PlannedProductForecast.__name__)
    from google.ads.googleads import OnTargetAudienceMetrics
    expected_names.append(OnTargetAudienceMetrics.__name__)
    from google.ads.googleads import GetRecommendationRequest
    expected_names.append(GetRecommendationRequest.__name__)
    from google.ads.googleads import ApplyRecommendationRequest
    expected_names.append(ApplyRecommendationRequest.__name__)
    from google.ads.googleads import ApplyRecommendationOperation
    expected_names.append(ApplyRecommendationOperation.__name__)
    from google.ads.googleads import ApplyRecommendationResponse
    expected_names.append(ApplyRecommendationResponse.__name__)
    from google.ads.googleads import ApplyRecommendationResult
    expected_names.append(ApplyRecommendationResult.__name__)
    from google.ads.googleads import DismissRecommendationRequest
    expected_names.append(DismissRecommendationRequest.__name__)
    from google.ads.googleads import DismissRecommendationResponse
    expected_names.append(DismissRecommendationResponse.__name__)
    from google.ads.googleads import GetSearchTermViewRequest
    expected_names.append(GetSearchTermViewRequest.__name__)
    from google.ads.googleads import GetShoppingPerformanceViewRequest
    expected_names.append(GetShoppingPerformanceViewRequest.__name__)
    from google.ads.googleads import GetThirdPartyAppAnalyticsLinkRequest
    expected_names.append(GetThirdPartyAppAnalyticsLinkRequest.__name__)
    from google.ads.googleads import RegenerateShareableLinkIdRequest
    expected_names.append(RegenerateShareableLinkIdRequest.__name__)
    from google.ads.googleads import RegenerateShareableLinkIdResponse
    expected_names.append(RegenerateShareableLinkIdResponse.__name__)
    from google.ads.googleads import GetTopicConstantRequest
    expected_names.append(GetTopicConstantRequest.__name__)
    from google.ads.googleads import GetTopicViewRequest
    expected_names.append(GetTopicViewRequest.__name__)
    from google.ads.googleads import UploadUserDataRequest
    expected_names.append(UploadUserDataRequest.__name__)
    from google.ads.googleads import UserDataOperation
    expected_names.append(UserDataOperation.__name__)
    from google.ads.googleads import UploadUserDataResponse
    expected_names.append(UploadUserDataResponse.__name__)
    from google.ads.googleads import GetUserInterestRequest
    expected_names.append(GetUserInterestRequest.__name__)
    from google.ads.googleads import GetUserLocationViewRequest
    expected_names.append(GetUserLocationViewRequest.__name__)
    from google.ads.googleads import GetVideoRequest
    expected_names.append(GetVideoRequest.__name__)
    from google.ads.googleads import GetWebpageViewRequest
    expected_names.append(GetWebpageViewRequest.__name__)

    # Client and transport classes
    from google.ads.googleads import WebpageViewServiceClient
    expected_names.append(WebpageViewServiceClient.__name__)
    from google.ads.googleads import WebpageViewServiceTransport
    expected_names.append(WebpageViewServiceTransport.__name__)
    from google.ads.googleads import WebpageViewServiceGrpcTransport
    expected_names.append(WebpageViewServiceGrpcTransport.__name__)
    from google.ads.googleads import VideoServiceClient
    expected_names.append(VideoServiceClient.__name__)
    from google.ads.googleads import VideoServiceTransport
    expected_names.append(VideoServiceTransport.__name__)
    from google.ads.googleads import VideoServiceGrpcTransport
    expected_names.append(VideoServiceGrpcTransport.__name__)
    from google.ads.googleads import UserLocationViewServiceClient
    expected_names.append(UserLocationViewServiceClient.__name__)
    from google.ads.googleads import UserLocationViewServiceTransport
    expected_names.append(UserLocationViewServiceTransport.__name__)
    from google.ads.googleads import UserLocationViewServiceGrpcTransport
    expected_names.append(UserLocationViewServiceGrpcTransport.__name__)
    from google.ads.googleads import UserInterestServiceClient
    expected_names.append(UserInterestServiceClient.__name__)
    from google.ads.googleads import UserInterestServiceTransport
    expected_names.append(UserInterestServiceTransport.__name__)
    from google.ads.googleads import UserInterestServiceGrpcTransport
    expected_names.append(UserInterestServiceGrpcTransport.__name__)
    from google.ads.googleads import UserDataServiceClient
    expected_names.append(UserDataServiceClient.__name__)
    from google.ads.googleads import UserDataServiceTransport
    expected_names.append(UserDataServiceTransport.__name__)
    from google.ads.googleads import UserDataServiceGrpcTransport
    expected_names.append(UserDataServiceGrpcTransport.__name__)
    from google.ads.googleads import TopicViewServiceClient
    expected_names.append(TopicViewServiceClient.__name__)
    from google.ads.googleads import TopicViewServiceTransport
    expected_names.append(TopicViewServiceTransport.__name__)
    from google.ads.googleads import TopicViewServiceGrpcTransport
    expected_names.append(TopicViewServiceGrpcTransport.__name__)
    from google.ads.googleads import TopicConstantServiceClient
    expected_names.append(TopicConstantServiceClient.__name__)
    from google.ads.googleads import TopicConstantServiceTransport
    expected_names.append(TopicConstantServiceTransport.__name__)
    from google.ads.googleads import TopicConstantServiceGrpcTransport
    expected_names.append(TopicConstantServiceGrpcTransport.__name__)
    from google.ads.googleads import ThirdPartyAppAnalyticsLinkServiceClient
    expected_names.append(ThirdPartyAppAnalyticsLinkServiceClient.__name__)
    from google.ads.googleads import ThirdPartyAppAnalyticsLinkServiceTransport
    expected_names.append(ThirdPartyAppAnalyticsLinkServiceTransport.__name__)
    from google.ads.googleads import ThirdPartyAppAnalyticsLinkServiceGrpcTransport
    expected_names.append(ThirdPartyAppAnalyticsLinkServiceGrpcTransport.__name__)
    from google.ads.googleads import ShoppingPerformanceViewServiceClient
    expected_names.append(ShoppingPerformanceViewServiceClient.__name__)
    from google.ads.googleads import ShoppingPerformanceViewServiceTransport
    expected_names.append(ShoppingPerformanceViewServiceTransport.__name__)
    from google.ads.googleads import ShoppingPerformanceViewServiceGrpcTransport
    expected_names.append(ShoppingPerformanceViewServiceGrpcTransport.__name__)
    from google.ads.googleads import SearchTermViewServiceClient
    expected_names.append(SearchTermViewServiceClient.__name__)
    from google.ads.googleads import SearchTermViewServiceTransport
    expected_names.append(SearchTermViewServiceTransport.__name__)
    from google.ads.googleads import SearchTermViewServiceGrpcTransport
    expected_names.append(SearchTermViewServiceGrpcTransport.__name__)
    from google.ads.googleads import RecommendationServiceClient
    expected_names.append(RecommendationServiceClient.__name__)
    from google.ads.googleads import RecommendationServiceTransport
    expected_names.append(RecommendationServiceTransport.__name__)
    from google.ads.googleads import RecommendationServiceGrpcTransport
    expected_names.append(RecommendationServiceGrpcTransport.__name__)
    from google.ads.googleads import ReachPlanServiceClient
    expected_names.append(ReachPlanServiceClient.__name__)
    from google.ads.googleads import ReachPlanServiceTransport
    expected_names.append(ReachPlanServiceTransport.__name__)
    from google.ads.googleads import ReachPlanServiceGrpcTransport
    expected_names.append(ReachPlanServiceGrpcTransport.__name__)
    from google.ads.googleads import ProductGroupViewServiceClient
    expected_names.append(ProductGroupViewServiceClient.__name__)
    from google.ads.googleads import ProductGroupViewServiceTransport
    expected_names.append(ProductGroupViewServiceTransport.__name__)
    from google.ads.googleads import ProductGroupViewServiceGrpcTransport
    expected_names.append(ProductGroupViewServiceGrpcTransport.__name__)
    from google.ads.googleads import ProductBiddingCategoryConstantServiceClient
    expected_names.append(ProductBiddingCategoryConstantServiceClient.__name__)
    from google.ads.googleads import ProductBiddingCategoryConstantServiceTransport
    expected_names.append(ProductBiddingCategoryConstantServiceTransport.__name__)
    from google.ads.googleads import ProductBiddingCategoryConstantServiceGrpcTransport
    expected_names.append(ProductBiddingCategoryConstantServiceGrpcTransport.__name__)
    from google.ads.googleads import PaymentsAccountServiceClient
    expected_names.append(PaymentsAccountServiceClient.__name__)
    from google.ads.googleads import PaymentsAccountServiceTransport
    expected_names.append(PaymentsAccountServiceTransport.__name__)
    from google.ads.googleads import PaymentsAccountServiceGrpcTransport
    expected_names.append(PaymentsAccountServiceGrpcTransport.__name__)
    from google.ads.googleads import ParentalStatusViewServiceClient
    expected_names.append(ParentalStatusViewServiceClient.__name__)
    from google.ads.googleads import ParentalStatusViewServiceTransport
    expected_names.append(ParentalStatusViewServiceTransport.__name__)
    from google.ads.googleads import ParentalStatusViewServiceGrpcTransport
    expected_names.append(ParentalStatusViewServiceGrpcTransport.__name__)
    from google.ads.googleads import PaidOrganicSearchTermViewServiceClient
    expected_names.append(PaidOrganicSearchTermViewServiceClient.__name__)
    from google.ads.googleads import PaidOrganicSearchTermViewServiceTransport
    expected_names.append(PaidOrganicSearchTermViewServiceTransport.__name__)
    from google.ads.googleads import PaidOrganicSearchTermViewServiceGrpcTransport
    expected_names.append(PaidOrganicSearchTermViewServiceGrpcTransport.__name__)
    from google.ads.googleads import OperatingSystemVersionConstantServiceClient
    expected_names.append(OperatingSystemVersionConstantServiceClient.__name__)
    from google.ads.googleads import OperatingSystemVersionConstantServiceTransport
    expected_names.append(OperatingSystemVersionConstantServiceTransport.__name__)
    from google.ads.googleads import OperatingSystemVersionConstantServiceGrpcTransport
    expected_names.append(OperatingSystemVersionConstantServiceGrpcTransport.__name__)
    from google.ads.googleads import OfflineUserDataJobServiceClient
    expected_names.append(OfflineUserDataJobServiceClient.__name__)
    from google.ads.googleads import OfflineUserDataJobServiceTransport
    expected_names.append(OfflineUserDataJobServiceTransport.__name__)
    from google.ads.googleads import OfflineUserDataJobServiceGrpcTransport
    expected_names.append(OfflineUserDataJobServiceGrpcTransport.__name__)
    from google.ads.googleads import MobileDeviceConstantServiceClient
    expected_names.append(MobileDeviceConstantServiceClient.__name__)
    from google.ads.googleads import MobileDeviceConstantServiceTransport
    expected_names.append(MobileDeviceConstantServiceTransport.__name__)
    from google.ads.googleads import MobileDeviceConstantServiceGrpcTransport
    expected_names.append(MobileDeviceConstantServiceGrpcTransport.__name__)
    from google.ads.googleads import MobileAppCategoryConstantServiceClient
    expected_names.append(MobileAppCategoryConstantServiceClient.__name__)
    from google.ads.googleads import MobileAppCategoryConstantServiceTransport
    expected_names.append(MobileAppCategoryConstantServiceTransport.__name__)
    from google.ads.googleads import MobileAppCategoryConstantServiceGrpcTransport
    expected_names.append(MobileAppCategoryConstantServiceGrpcTransport.__name__)
    from google.ads.googleads import MerchantCenterLinkServiceClient
    expected_names.append(MerchantCenterLinkServiceClient.__name__)
    from google.ads.googleads import MerchantCenterLinkServiceTransport
    expected_names.append(MerchantCenterLinkServiceTransport.__name__)
    from google.ads.googleads import MerchantCenterLinkServiceGrpcTransport
    expected_names.append(MerchantCenterLinkServiceGrpcTransport.__name__)
    from google.ads.googleads import ManagedPlacementViewServiceClient
    expected_names.append(ManagedPlacementViewServiceClient.__name__)
    from google.ads.googleads import ManagedPlacementViewServiceTransport
    expected_names.append(ManagedPlacementViewServiceTransport.__name__)
    from google.ads.googleads import ManagedPlacementViewServiceGrpcTransport
    expected_names.append(ManagedPlacementViewServiceGrpcTransport.__name__)
    from google.ads.googleads import LocationViewServiceClient
    expected_names.append(LocationViewServiceClient.__name__)
    from google.ads.googleads import LocationViewServiceTransport
    expected_names.append(LocationViewServiceTransport.__name__)
    from google.ads.googleads import LocationViewServiceGrpcTransport
    expected_names.append(LocationViewServiceGrpcTransport.__name__)
    from google.ads.googleads import LifeEventServiceClient
    expected_names.append(LifeEventServiceClient.__name__)
    from google.ads.googleads import LifeEventServiceTransport
    expected_names.append(LifeEventServiceTransport.__name__)
    from google.ads.googleads import LifeEventServiceGrpcTransport
    expected_names.append(LifeEventServiceGrpcTransport.__name__)
    from google.ads.googleads import LanguageConstantServiceClient
    expected_names.append(LanguageConstantServiceClient.__name__)
    from google.ads.googleads import LanguageConstantServiceTransport
    expected_names.append(LanguageConstantServiceTransport.__name__)
    from google.ads.googleads import LanguageConstantServiceGrpcTransport
    expected_names.append(LanguageConstantServiceGrpcTransport.__name__)
    from google.ads.googleads import LandingPageViewServiceClient
    expected_names.append(LandingPageViewServiceClient.__name__)
    from google.ads.googleads import LandingPageViewServiceTransport
    expected_names.append(LandingPageViewServiceTransport.__name__)
    from google.ads.googleads import LandingPageViewServiceGrpcTransport
    expected_names.append(LandingPageViewServiceGrpcTransport.__name__)
    from google.ads.googleads import KeywordViewServiceClient
    expected_names.append(KeywordViewServiceClient.__name__)
    from google.ads.googleads import KeywordViewServiceTransport
    expected_names.append(KeywordViewServiceTransport.__name__)
    from google.ads.googleads import KeywordViewServiceGrpcTransport
    expected_names.append(KeywordViewServiceGrpcTransport.__name__)
    from google.ads.googleads import KeywordPlanIdeaServiceClient
    expected_names.append(KeywordPlanIdeaServiceClient.__name__)
    from google.ads.googleads import KeywordPlanIdeaServiceTransport
    expected_names.append(KeywordPlanIdeaServiceTransport.__name__)
    from google.ads.googleads import KeywordPlanIdeaServiceGrpcTransport
    expected_names.append(KeywordPlanIdeaServiceGrpcTransport.__name__)
    from google.ads.googleads import InvoiceServiceClient
    expected_names.append(InvoiceServiceClient.__name__)
    from google.ads.googleads import InvoiceServiceTransport
    expected_names.append(InvoiceServiceTransport.__name__)
    from google.ads.googleads import InvoiceServiceGrpcTransport
    expected_names.append(InvoiceServiceGrpcTransport.__name__)
    from google.ads.googleads import IncomeRangeViewServiceClient
    expected_names.append(IncomeRangeViewServiceClient.__name__)
    from google.ads.googleads import IncomeRangeViewServiceTransport
    expected_names.append(IncomeRangeViewServiceTransport.__name__)
    from google.ads.googleads import IncomeRangeViewServiceGrpcTransport
    expected_names.append(IncomeRangeViewServiceGrpcTransport.__name__)
    from google.ads.googleads import HotelPerformanceViewServiceClient
    expected_names.append(HotelPerformanceViewServiceClient.__name__)
    from google.ads.googleads import HotelPerformanceViewServiceTransport
    expected_names.append(HotelPerformanceViewServiceTransport.__name__)
    from google.ads.googleads import HotelPerformanceViewServiceGrpcTransport
    expected_names.append(HotelPerformanceViewServiceGrpcTransport.__name__)
    from google.ads.googleads import HotelGroupViewServiceClient
    expected_names.append(HotelGroupViewServiceClient.__name__)
    from google.ads.googleads import HotelGroupViewServiceTransport
    expected_names.append(HotelGroupViewServiceTransport.__name__)
    from google.ads.googleads import HotelGroupViewServiceGrpcTransport
    expected_names.append(HotelGroupViewServiceGrpcTransport.__name__)
    from google.ads.googleads import GroupPlacementViewServiceClient
    expected_names.append(GroupPlacementViewServiceClient.__name__)
    from google.ads.googleads import GroupPlacementViewServiceTransport
    expected_names.append(GroupPlacementViewServiceTransport.__name__)
    from google.ads.googleads import GroupPlacementViewServiceGrpcTransport
    expected_names.append(GroupPlacementViewServiceGrpcTransport.__name__)
    from google.ads.googleads import GoogleAdsFieldServiceClient
    expected_names.append(GoogleAdsFieldServiceClient.__name__)
    from google.ads.googleads import GoogleAdsFieldServiceTransport
    expected_names.append(GoogleAdsFieldServiceTransport.__name__)
    from google.ads.googleads import GoogleAdsFieldServiceGrpcTransport
    expected_names.append(GoogleAdsFieldServiceGrpcTransport.__name__)
    from google.ads.googleads import GeographicViewServiceClient
    expected_names.append(GeographicViewServiceClient.__name__)
    from google.ads.googleads import GeographicViewServiceTransport
    expected_names.append(GeographicViewServiceTransport.__name__)
    from google.ads.googleads import GeographicViewServiceGrpcTransport
    expected_names.append(GeographicViewServiceGrpcTransport.__name__)
    from google.ads.googleads import GeoTargetConstantServiceClient
    expected_names.append(GeoTargetConstantServiceClient.__name__)
    from google.ads.googleads import GeoTargetConstantServiceTransport
    expected_names.append(GeoTargetConstantServiceTransport.__name__)
    from google.ads.googleads import GeoTargetConstantServiceGrpcTransport
    expected_names.append(GeoTargetConstantServiceGrpcTransport.__name__)
    from google.ads.googleads import GenderViewServiceClient
    expected_names.append(GenderViewServiceClient.__name__)
    from google.ads.googleads import GenderViewServiceTransport
    expected_names.append(GenderViewServiceTransport.__name__)
    from google.ads.googleads import GenderViewServiceGrpcTransport
    expected_names.append(GenderViewServiceGrpcTransport.__name__)
    from google.ads.googleads import FeedPlaceholderViewServiceClient
    expected_names.append(FeedPlaceholderViewServiceClient.__name__)
    from google.ads.googleads import FeedPlaceholderViewServiceTransport
    expected_names.append(FeedPlaceholderViewServiceTransport.__name__)
    from google.ads.googleads import FeedPlaceholderViewServiceGrpcTransport
    expected_names.append(FeedPlaceholderViewServiceGrpcTransport.__name__)
    from google.ads.googleads import ExpandedLandingPageViewServiceClient
    expected_names.append(ExpandedLandingPageViewServiceClient.__name__)
    from google.ads.googleads import ExpandedLandingPageViewServiceTransport
    expected_names.append(ExpandedLandingPageViewServiceTransport.__name__)
    from google.ads.googleads import ExpandedLandingPageViewServiceGrpcTransport
    expected_names.append(ExpandedLandingPageViewServiceGrpcTransport.__name__)
    from google.ads.googleads import DynamicSearchAdsSearchTermViewServiceClient
    expected_names.append(DynamicSearchAdsSearchTermViewServiceClient.__name__)
    from google.ads.googleads import DynamicSearchAdsSearchTermViewServiceTransport
    expected_names.append(DynamicSearchAdsSearchTermViewServiceTransport.__name__)
    from google.ads.googleads import DynamicSearchAdsSearchTermViewServiceGrpcTransport
    expected_names.append(DynamicSearchAdsSearchTermViewServiceGrpcTransport.__name__)
    from google.ads.googleads import DomainCategoryServiceClient
    expected_names.append(DomainCategoryServiceClient.__name__)
    from google.ads.googleads import DomainCategoryServiceTransport
    expected_names.append(DomainCategoryServiceTransport.__name__)
    from google.ads.googleads import DomainCategoryServiceGrpcTransport
    expected_names.append(DomainCategoryServiceGrpcTransport.__name__)
    from google.ads.googleads import DistanceViewServiceClient
    expected_names.append(DistanceViewServiceClient.__name__)
    from google.ads.googleads import DistanceViewServiceTransport
    expected_names.append(DistanceViewServiceTransport.__name__)
    from google.ads.googleads import DistanceViewServiceGrpcTransport
    expected_names.append(DistanceViewServiceGrpcTransport.__name__)
    from google.ads.googleads import DisplayKeywordViewServiceClient
    expected_names.append(DisplayKeywordViewServiceClient.__name__)
    from google.ads.googleads import DisplayKeywordViewServiceTransport
    expected_names.append(DisplayKeywordViewServiceTransport.__name__)
    from google.ads.googleads import DisplayKeywordViewServiceGrpcTransport
    expected_names.append(DisplayKeywordViewServiceGrpcTransport.__name__)
    from google.ads.googleads import DetailPlacementViewServiceClient
    expected_names.append(DetailPlacementViewServiceClient.__name__)
    from google.ads.googleads import DetailPlacementViewServiceTransport
    expected_names.append(DetailPlacementViewServiceTransport.__name__)
    from google.ads.googleads import DetailPlacementViewServiceGrpcTransport
    expected_names.append(DetailPlacementViewServiceGrpcTransport.__name__)
    from google.ads.googleads import CustomerUserAccessServiceClient
    expected_names.append(CustomerUserAccessServiceClient.__name__)
    from google.ads.googleads import CustomerUserAccessServiceTransport
    expected_names.append(CustomerUserAccessServiceTransport.__name__)
    from google.ads.googleads import CustomerUserAccessServiceGrpcTransport
    expected_names.append(CustomerUserAccessServiceGrpcTransport.__name__)
    from google.ads.googleads import CustomerUserAccessInvitationServiceClient
    expected_names.append(CustomerUserAccessInvitationServiceClient.__name__)
    from google.ads.googleads import CustomerUserAccessInvitationServiceTransport
    expected_names.append(CustomerUserAccessInvitationServiceTransport.__name__)
    from google.ads.googleads import CustomerUserAccessInvitationServiceGrpcTransport
    expected_names.append(CustomerUserAccessInvitationServiceGrpcTransport.__name__)
    from google.ads.googleads import CustomerManagerLinkServiceClient
    expected_names.append(CustomerManagerLinkServiceClient.__name__)
    from google.ads.googleads import CustomerManagerLinkServiceTransport
    expected_names.append(CustomerManagerLinkServiceTransport.__name__)
    from google.ads.googleads import CustomerManagerLinkServiceGrpcTransport
    expected_names.append(CustomerManagerLinkServiceGrpcTransport.__name__)
    from google.ads.googleads import CustomerClientServiceClient
    expected_names.append(CustomerClientServiceClient.__name__)
    from google.ads.googleads import CustomerClientServiceTransport
    expected_names.append(CustomerClientServiceTransport.__name__)
    from google.ads.googleads import CustomerClientServiceGrpcTransport
    expected_names.append(CustomerClientServiceGrpcTransport.__name__)
    from google.ads.googleads import CustomerClientLinkServiceClient
    expected_names.append(CustomerClientLinkServiceClient.__name__)
    from google.ads.googleads import CustomerClientLinkServiceTransport
    expected_names.append(CustomerClientLinkServiceTransport.__name__)
    from google.ads.googleads import CustomerClientLinkServiceGrpcTransport
    expected_names.append(CustomerClientLinkServiceGrpcTransport.__name__)
    from google.ads.googleads import CustomInterestServiceClient
    expected_names.append(CustomInterestServiceClient.__name__)
    from google.ads.googleads import CustomInterestServiceTransport
    expected_names.append(CustomInterestServiceTransport.__name__)
    from google.ads.googleads import CustomInterestServiceGrpcTransport
    expected_names.append(CustomInterestServiceGrpcTransport.__name__)
    from google.ads.googleads import CustomAudienceServiceClient
    expected_names.append(CustomAudienceServiceClient.__name__)
    from google.ads.googleads import CustomAudienceServiceTransport
    expected_names.append(CustomAudienceServiceTransport.__name__)
    from google.ads.googleads import CustomAudienceServiceGrpcTransport
    expected_names.append(CustomAudienceServiceGrpcTransport.__name__)
    from google.ads.googleads import CurrencyConstantServiceClient
    expected_names.append(CurrencyConstantServiceClient.__name__)
    from google.ads.googleads import CurrencyConstantServiceTransport
    expected_names.append(CurrencyConstantServiceTransport.__name__)
    from google.ads.googleads import CurrencyConstantServiceGrpcTransport
    expected_names.append(CurrencyConstantServiceGrpcTransport.__name__)
    from google.ads.googleads import ConversionUploadServiceClient
    expected_names.append(ConversionUploadServiceClient.__name__)
    from google.ads.googleads import ConversionUploadServiceTransport
    expected_names.append(ConversionUploadServiceTransport.__name__)
    from google.ads.googleads import ConversionUploadServiceGrpcTransport
    expected_names.append(ConversionUploadServiceGrpcTransport.__name__)
    from google.ads.googleads import ConversionAdjustmentUploadServiceClient
    expected_names.append(ConversionAdjustmentUploadServiceClient.__name__)
    from google.ads.googleads import ConversionAdjustmentUploadServiceTransport
    expected_names.append(ConversionAdjustmentUploadServiceTransport.__name__)
    from google.ads.googleads import ConversionAdjustmentUploadServiceGrpcTransport
    expected_names.append(ConversionAdjustmentUploadServiceGrpcTransport.__name__)
    from google.ads.googleads import CombinedAudienceServiceClient
    expected_names.append(CombinedAudienceServiceClient.__name__)
    from google.ads.googleads import CombinedAudienceServiceTransport
    expected_names.append(CombinedAudienceServiceTransport.__name__)
    from google.ads.googleads import CombinedAudienceServiceGrpcTransport
    expected_names.append(CombinedAudienceServiceGrpcTransport.__name__)
    from google.ads.googleads import ClickViewServiceClient
    expected_names.append(ClickViewServiceClient.__name__)
    from google.ads.googleads import ClickViewServiceTransport
    expected_names.append(ClickViewServiceTransport.__name__)
    from google.ads.googleads import ClickViewServiceGrpcTransport
    expected_names.append(ClickViewServiceGrpcTransport.__name__)
    from google.ads.googleads import ChangeStatusServiceClient
    expected_names.append(ChangeStatusServiceClient.__name__)
    from google.ads.googleads import ChangeStatusServiceTransport
    expected_names.append(ChangeStatusServiceTransport.__name__)
    from google.ads.googleads import ChangeStatusServiceGrpcTransport
    expected_names.append(ChangeStatusServiceGrpcTransport.__name__)
    from google.ads.googleads import CarrierConstantServiceClient
    expected_names.append(CarrierConstantServiceClient.__name__)
    from google.ads.googleads import CarrierConstantServiceTransport
    expected_names.append(CarrierConstantServiceTransport.__name__)
    from google.ads.googleads import CarrierConstantServiceGrpcTransport
    expected_names.append(CarrierConstantServiceGrpcTransport.__name__)
    from google.ads.googleads import CampaignSimulationServiceClient
    expected_names.append(CampaignSimulationServiceClient.__name__)
    from google.ads.googleads import CampaignSimulationServiceTransport
    expected_names.append(CampaignSimulationServiceTransport.__name__)
    from google.ads.googleads import CampaignSimulationServiceGrpcTransport
    expected_names.append(CampaignSimulationServiceGrpcTransport.__name__)
    from google.ads.googleads import CampaignCriterionSimulationServiceClient
    expected_names.append(CampaignCriterionSimulationServiceClient.__name__)
    from google.ads.googleads import CampaignCriterionSimulationServiceTransport
    expected_names.append(CampaignCriterionSimulationServiceTransport.__name__)
    from google.ads.googleads import CampaignCriterionSimulationServiceGrpcTransport
    expected_names.append(CampaignCriterionSimulationServiceGrpcTransport.__name__)
    from google.ads.googleads import CampaignAudienceViewServiceClient
    expected_names.append(CampaignAudienceViewServiceClient.__name__)
    from google.ads.googleads import CampaignAudienceViewServiceTransport
    expected_names.append(CampaignAudienceViewServiceTransport.__name__)
    from google.ads.googleads import CampaignAudienceViewServiceGrpcTransport
    expected_names.append(CampaignAudienceViewServiceGrpcTransport.__name__)
    from google.ads.googleads import BillingSetupServiceClient
    expected_names.append(BillingSetupServiceClient.__name__)
    from google.ads.googleads import BillingSetupServiceTransport
    expected_names.append(BillingSetupServiceTransport.__name__)
    from google.ads.googleads import BillingSetupServiceGrpcTransport
    expected_names.append(BillingSetupServiceGrpcTransport.__name__)
    from google.ads.googleads import BiddingStrategySimulationServiceClient
    expected_names.append(BiddingStrategySimulationServiceClient.__name__)
    from google.ads.googleads import BiddingStrategySimulationServiceTransport
    expected_names.append(BiddingStrategySimulationServiceTransport.__name__)
    from google.ads.googleads import BiddingStrategySimulationServiceGrpcTransport
    expected_names.append(BiddingStrategySimulationServiceGrpcTransport.__name__)
    from google.ads.googleads import BatchJobServiceClient
    expected_names.append(BatchJobServiceClient.__name__)
    from google.ads.googleads import BatchJobServiceTransport
    expected_names.append(BatchJobServiceTransport.__name__)
    from google.ads.googleads import BatchJobServiceGrpcTransport
    expected_names.append(BatchJobServiceGrpcTransport.__name__)
    from google.ads.googleads import GoogleAdsServiceClient
    expected_names.append(GoogleAdsServiceClient.__name__)
    from google.ads.googleads import GoogleAdsServiceTransport
    expected_names.append(GoogleAdsServiceTransport.__name__)
    from google.ads.googleads import GoogleAdsServiceGrpcTransport
    expected_names.append(GoogleAdsServiceGrpcTransport.__name__)
    from google.ads.googleads import UserListServiceClient
    expected_names.append(UserListServiceClient.__name__)
    from google.ads.googleads import UserListServiceTransport
    expected_names.append(UserListServiceTransport.__name__)
    from google.ads.googleads import UserListServiceGrpcTransport
    expected_names.append(UserListServiceGrpcTransport.__name__)
    from google.ads.googleads import SharedSetServiceClient
    expected_names.append(SharedSetServiceClient.__name__)
    from google.ads.googleads import SharedSetServiceTransport
    expected_names.append(SharedSetServiceTransport.__name__)
    from google.ads.googleads import SharedSetServiceGrpcTransport
    expected_names.append(SharedSetServiceGrpcTransport.__name__)
    from google.ads.googleads import SharedCriterionServiceClient
    expected_names.append(SharedCriterionServiceClient.__name__)
    from google.ads.googleads import SharedCriterionServiceTransport
    expected_names.append(SharedCriterionServiceTransport.__name__)
    from google.ads.googleads import SharedCriterionServiceGrpcTransport
    expected_names.append(SharedCriterionServiceGrpcTransport.__name__)
    from google.ads.googleads import RemarketingActionServiceClient
    expected_names.append(RemarketingActionServiceClient.__name__)
    from google.ads.googleads import RemarketingActionServiceTransport
    expected_names.append(RemarketingActionServiceTransport.__name__)
    from google.ads.googleads import RemarketingActionServiceGrpcTransport
    expected_names.append(RemarketingActionServiceGrpcTransport.__name__)
    from google.ads.googleads import MediaFileServiceClient
    expected_names.append(MediaFileServiceClient.__name__)
    from google.ads.googleads import MediaFileServiceTransport
    expected_names.append(MediaFileServiceTransport.__name__)
    from google.ads.googleads import MediaFileServiceGrpcTransport
    expected_names.append(MediaFileServiceGrpcTransport.__name__)
    from google.ads.googleads import LabelServiceClient
    expected_names.append(LabelServiceClient.__name__)
    from google.ads.googleads import LabelServiceTransport
    expected_names.append(LabelServiceTransport.__name__)
    from google.ads.googleads import LabelServiceGrpcTransport
    expected_names.append(LabelServiceGrpcTransport.__name__)
    from google.ads.googleads import KeywordPlanServiceClient
    expected_names.append(KeywordPlanServiceClient.__name__)
    from google.ads.googleads import KeywordPlanServiceTransport
    expected_names.append(KeywordPlanServiceTransport.__name__)
    from google.ads.googleads import KeywordPlanServiceGrpcTransport
    expected_names.append(KeywordPlanServiceGrpcTransport.__name__)
    from google.ads.googleads import KeywordPlanCampaignServiceClient
    expected_names.append(KeywordPlanCampaignServiceClient.__name__)
    from google.ads.googleads import KeywordPlanCampaignServiceTransport
    expected_names.append(KeywordPlanCampaignServiceTransport.__name__)
    from google.ads.googleads import KeywordPlanCampaignServiceGrpcTransport
    expected_names.append(KeywordPlanCampaignServiceGrpcTransport.__name__)
    from google.ads.googleads import KeywordPlanCampaignKeywordServiceClient
    expected_names.append(KeywordPlanCampaignKeywordServiceClient.__name__)
    from google.ads.googleads import KeywordPlanCampaignKeywordServiceTransport
    expected_names.append(KeywordPlanCampaignKeywordServiceTransport.__name__)
    from google.ads.googleads import KeywordPlanCampaignKeywordServiceGrpcTransport
    expected_names.append(KeywordPlanCampaignKeywordServiceGrpcTransport.__name__)
    from google.ads.googleads import KeywordPlanAdGroupServiceClient
    expected_names.append(KeywordPlanAdGroupServiceClient.__name__)
    from google.ads.googleads import KeywordPlanAdGroupServiceTransport
    expected_names.append(KeywordPlanAdGroupServiceTransport.__name__)
    from google.ads.googleads import KeywordPlanAdGroupServiceGrpcTransport
    expected_names.append(KeywordPlanAdGroupServiceGrpcTransport.__name__)
    from google.ads.googleads import KeywordPlanAdGroupKeywordServiceClient
    expected_names.append(KeywordPlanAdGroupKeywordServiceClient.__name__)
    from google.ads.googleads import KeywordPlanAdGroupKeywordServiceTransport
    expected_names.append(KeywordPlanAdGroupKeywordServiceTransport.__name__)
    from google.ads.googleads import KeywordPlanAdGroupKeywordServiceGrpcTransport
    expected_names.append(KeywordPlanAdGroupKeywordServiceGrpcTransport.__name__)
    from google.ads.googleads import FeedServiceClient
    expected_names.append(FeedServiceClient.__name__)
    from google.ads.googleads import FeedServiceTransport
    expected_names.append(FeedServiceTransport.__name__)
    from google.ads.googleads import FeedServiceGrpcTransport
    expected_names.append(FeedServiceGrpcTransport.__name__)
    from google.ads.googleads import FeedMappingServiceClient
    expected_names.append(FeedMappingServiceClient.__name__)
    from google.ads.googleads import FeedMappingServiceTransport
    expected_names.append(FeedMappingServiceTransport.__name__)
    from google.ads.googleads import FeedMappingServiceGrpcTransport
    expected_names.append(FeedMappingServiceGrpcTransport.__name__)
    from google.ads.googleads import FeedItemTargetServiceClient
    expected_names.append(FeedItemTargetServiceClient.__name__)
    from google.ads.googleads import FeedItemTargetServiceTransport
    expected_names.append(FeedItemTargetServiceTransport.__name__)
    from google.ads.googleads import FeedItemTargetServiceGrpcTransport
    expected_names.append(FeedItemTargetServiceGrpcTransport.__name__)
    from google.ads.googleads import FeedItemSetServiceClient
    expected_names.append(FeedItemSetServiceClient.__name__)
    from google.ads.googleads import FeedItemSetServiceTransport
    expected_names.append(FeedItemSetServiceTransport.__name__)
    from google.ads.googleads import FeedItemSetServiceGrpcTransport
    expected_names.append(FeedItemSetServiceGrpcTransport.__name__)
    from google.ads.googleads import FeedItemSetLinkServiceClient
    expected_names.append(FeedItemSetLinkServiceClient.__name__)
    from google.ads.googleads import FeedItemSetLinkServiceTransport
    expected_names.append(FeedItemSetLinkServiceTransport.__name__)
    from google.ads.googleads import FeedItemSetLinkServiceGrpcTransport
    expected_names.append(FeedItemSetLinkServiceGrpcTransport.__name__)
    from google.ads.googleads import FeedItemServiceClient
    expected_names.append(FeedItemServiceClient.__name__)
    from google.ads.googleads import FeedItemServiceTransport
    expected_names.append(FeedItemServiceTransport.__name__)
    from google.ads.googleads import FeedItemServiceGrpcTransport
    expected_names.append(FeedItemServiceGrpcTransport.__name__)
    from google.ads.googleads import ExtensionFeedItemServiceClient
    expected_names.append(ExtensionFeedItemServiceClient.__name__)
    from google.ads.googleads import ExtensionFeedItemServiceTransport
    expected_names.append(ExtensionFeedItemServiceTransport.__name__)
    from google.ads.googleads import ExtensionFeedItemServiceGrpcTransport
    expected_names.append(ExtensionFeedItemServiceGrpcTransport.__name__)
    from google.ads.googleads import CustomerServiceClient
    expected_names.append(CustomerServiceClient.__name__)
    from google.ads.googleads import CustomerServiceTransport
    expected_names.append(CustomerServiceTransport.__name__)
    from google.ads.googleads import CustomerServiceGrpcTransport
    expected_names.append(CustomerServiceGrpcTransport.__name__)
    from google.ads.googleads import CustomerNegativeCriterionServiceClient
    expected_names.append(CustomerNegativeCriterionServiceClient.__name__)
    from google.ads.googleads import CustomerNegativeCriterionServiceTransport
    expected_names.append(CustomerNegativeCriterionServiceTransport.__name__)
    from google.ads.googleads import CustomerNegativeCriterionServiceGrpcTransport
    expected_names.append(CustomerNegativeCriterionServiceGrpcTransport.__name__)
    from google.ads.googleads import CustomerLabelServiceClient
    expected_names.append(CustomerLabelServiceClient.__name__)
    from google.ads.googleads import CustomerLabelServiceTransport
    expected_names.append(CustomerLabelServiceTransport.__name__)
    from google.ads.googleads import CustomerLabelServiceGrpcTransport
    expected_names.append(CustomerLabelServiceGrpcTransport.__name__)
    from google.ads.googleads import CustomerFeedServiceClient
    expected_names.append(CustomerFeedServiceClient.__name__)
    from google.ads.googleads import CustomerFeedServiceTransport
    expected_names.append(CustomerFeedServiceTransport.__name__)
    from google.ads.googleads import CustomerFeedServiceGrpcTransport
    expected_names.append(CustomerFeedServiceGrpcTransport.__name__)
    from google.ads.googleads import CustomerExtensionSettingServiceClient
    expected_names.append(CustomerExtensionSettingServiceClient.__name__)
    from google.ads.googleads import CustomerExtensionSettingServiceTransport
    expected_names.append(CustomerExtensionSettingServiceTransport.__name__)
    from google.ads.googleads import CustomerExtensionSettingServiceGrpcTransport
    expected_names.append(CustomerExtensionSettingServiceGrpcTransport.__name__)
    from google.ads.googleads import CustomerAssetServiceClient
    expected_names.append(CustomerAssetServiceClient.__name__)
    from google.ads.googleads import CustomerAssetServiceTransport
    expected_names.append(CustomerAssetServiceTransport.__name__)
    from google.ads.googleads import CustomerAssetServiceGrpcTransport
    expected_names.append(CustomerAssetServiceGrpcTransport.__name__)
    from google.ads.googleads import ConversionCustomVariableServiceClient
    expected_names.append(ConversionCustomVariableServiceClient.__name__)
    from google.ads.googleads import ConversionCustomVariableServiceTransport
    expected_names.append(ConversionCustomVariableServiceTransport.__name__)
    from google.ads.googleads import ConversionCustomVariableServiceGrpcTransport
    expected_names.append(ConversionCustomVariableServiceGrpcTransport.__name__)
    from google.ads.googleads import ConversionActionServiceClient
    expected_names.append(ConversionActionServiceClient.__name__)
    from google.ads.googleads import ConversionActionServiceTransport
    expected_names.append(ConversionActionServiceTransport.__name__)
    from google.ads.googleads import ConversionActionServiceGrpcTransport
    expected_names.append(ConversionActionServiceGrpcTransport.__name__)
    from google.ads.googleads import CampaignSharedSetServiceClient
    expected_names.append(CampaignSharedSetServiceClient.__name__)
    from google.ads.googleads import CampaignSharedSetServiceTransport
    expected_names.append(CampaignSharedSetServiceTransport.__name__)
    from google.ads.googleads import CampaignSharedSetServiceGrpcTransport
    expected_names.append(CampaignSharedSetServiceGrpcTransport.__name__)
    from google.ads.googleads import CampaignServiceClient
    expected_names.append(CampaignServiceClient.__name__)
    from google.ads.googleads import CampaignServiceTransport
    expected_names.append(CampaignServiceTransport.__name__)
    from google.ads.googleads import CampaignServiceGrpcTransport
    expected_names.append(CampaignServiceGrpcTransport.__name__)
    from google.ads.googleads import CampaignLabelServiceClient
    expected_names.append(CampaignLabelServiceClient.__name__)
    from google.ads.googleads import CampaignLabelServiceTransport
    expected_names.append(CampaignLabelServiceTransport.__name__)
    from google.ads.googleads import CampaignLabelServiceGrpcTransport
    expected_names.append(CampaignLabelServiceGrpcTransport.__name__)
    from google.ads.googleads import CampaignFeedServiceClient
    expected_names.append(CampaignFeedServiceClient.__name__)
    from google.ads.googleads import CampaignFeedServiceTransport
    expected_names.append(CampaignFeedServiceTransport.__name__)
    from google.ads.googleads import CampaignFeedServiceGrpcTransport
    expected_names.append(CampaignFeedServiceGrpcTransport.__name__)
    from google.ads.googleads import CampaignExtensionSettingServiceClient
    expected_names.append(CampaignExtensionSettingServiceClient.__name__)
    from google.ads.googleads import CampaignExtensionSettingServiceTransport
    expected_names.append(CampaignExtensionSettingServiceTransport.__name__)
    from google.ads.googleads import CampaignExtensionSettingServiceGrpcTransport
    expected_names.append(CampaignExtensionSettingServiceGrpcTransport.__name__)
    from google.ads.googleads import CampaignExperimentServiceClient
    expected_names.append(CampaignExperimentServiceClient.__name__)
    from google.ads.googleads import CampaignExperimentServiceTransport
    expected_names.append(CampaignExperimentServiceTransport.__name__)
    from google.ads.googleads import CampaignExperimentServiceGrpcTransport
    expected_names.append(CampaignExperimentServiceGrpcTransport.__name__)
    from google.ads.googleads import CampaignDraftServiceClient
    expected_names.append(CampaignDraftServiceClient.__name__)
    from google.ads.googleads import CampaignDraftServiceTransport
    expected_names.append(CampaignDraftServiceTransport.__name__)
    from google.ads.googleads import CampaignDraftServiceGrpcTransport
    expected_names.append(CampaignDraftServiceGrpcTransport.__name__)
    from google.ads.googleads import CampaignCriterionServiceClient
    expected_names.append(CampaignCriterionServiceClient.__name__)
    from google.ads.googleads import CampaignCriterionServiceTransport
    expected_names.append(CampaignCriterionServiceTransport.__name__)
    from google.ads.googleads import CampaignCriterionServiceGrpcTransport
    expected_names.append(CampaignCriterionServiceGrpcTransport.__name__)
    from google.ads.googleads import CampaignBudgetServiceClient
    expected_names.append(CampaignBudgetServiceClient.__name__)
    from google.ads.googleads import CampaignBudgetServiceTransport
    expected_names.append(CampaignBudgetServiceTransport.__name__)
    from google.ads.googleads import CampaignBudgetServiceGrpcTransport
    expected_names.append(CampaignBudgetServiceGrpcTransport.__name__)
    from google.ads.googleads import CampaignBidModifierServiceClient
    expected_names.append(CampaignBidModifierServiceClient.__name__)
    from google.ads.googleads import CampaignBidModifierServiceTransport
    expected_names.append(CampaignBidModifierServiceTransport.__name__)
    from google.ads.googleads import CampaignBidModifierServiceGrpcTransport
    expected_names.append(CampaignBidModifierServiceGrpcTransport.__name__)
    from google.ads.googleads import CampaignAssetServiceClient
    expected_names.append(CampaignAssetServiceClient.__name__)
    from google.ads.googleads import CampaignAssetServiceTransport
    expected_names.append(CampaignAssetServiceTransport.__name__)
    from google.ads.googleads import CampaignAssetServiceGrpcTransport
    expected_names.append(CampaignAssetServiceGrpcTransport.__name__)
    from google.ads.googleads import BiddingStrategyServiceClient
    expected_names.append(BiddingStrategyServiceClient.__name__)
    from google.ads.googleads import BiddingStrategyServiceTransport
    expected_names.append(BiddingStrategyServiceTransport.__name__)
    from google.ads.googleads import BiddingStrategyServiceGrpcTransport
    expected_names.append(BiddingStrategyServiceGrpcTransport.__name__)
    from google.ads.googleads import AssetServiceClient
    expected_names.append(AssetServiceClient.__name__)
    from google.ads.googleads import AssetServiceTransport
    expected_names.append(AssetServiceTransport.__name__)
    from google.ads.googleads import AssetServiceGrpcTransport
    expected_names.append(AssetServiceGrpcTransport.__name__)
    from google.ads.googleads import AgeRangeViewServiceClient
    expected_names.append(AgeRangeViewServiceClient.__name__)
    from google.ads.googleads import AgeRangeViewServiceTransport
    expected_names.append(AgeRangeViewServiceTransport.__name__)
    from google.ads.googleads import AgeRangeViewServiceGrpcTransport
    expected_names.append(AgeRangeViewServiceGrpcTransport.__name__)
    from google.ads.googleads import AdServiceClient
    expected_names.append(AdServiceClient.__name__)
    from google.ads.googleads import AdServiceTransport
    expected_names.append(AdServiceTransport.__name__)
    from google.ads.googleads import AdServiceGrpcTransport
    expected_names.append(AdServiceGrpcTransport.__name__)
    from google.ads.googleads import AdScheduleViewServiceClient
    expected_names.append(AdScheduleViewServiceClient.__name__)
    from google.ads.googleads import AdScheduleViewServiceTransport
    expected_names.append(AdScheduleViewServiceTransport.__name__)
    from google.ads.googleads import AdScheduleViewServiceGrpcTransport
    expected_names.append(AdScheduleViewServiceGrpcTransport.__name__)
    from google.ads.googleads import AdParameterServiceClient
    expected_names.append(AdParameterServiceClient.__name__)
    from google.ads.googleads import AdParameterServiceTransport
    expected_names.append(AdParameterServiceTransport.__name__)
    from google.ads.googleads import AdParameterServiceGrpcTransport
    expected_names.append(AdParameterServiceGrpcTransport.__name__)
    from google.ads.googleads import AdGroupSimulationServiceClient
    expected_names.append(AdGroupSimulationServiceClient.__name__)
    from google.ads.googleads import AdGroupSimulationServiceTransport
    expected_names.append(AdGroupSimulationServiceTransport.__name__)
    from google.ads.googleads import AdGroupSimulationServiceGrpcTransport
    expected_names.append(AdGroupSimulationServiceGrpcTransport.__name__)
    from google.ads.googleads import AdGroupServiceClient
    expected_names.append(AdGroupServiceClient.__name__)
    from google.ads.googleads import AdGroupServiceTransport
    expected_names.append(AdGroupServiceTransport.__name__)
    from google.ads.googleads import AdGroupServiceGrpcTransport
    expected_names.append(AdGroupServiceGrpcTransport.__name__)
    from google.ads.googleads import AdGroupLabelServiceClient
    expected_names.append(AdGroupLabelServiceClient.__name__)
    from google.ads.googleads import AdGroupLabelServiceTransport
    expected_names.append(AdGroupLabelServiceTransport.__name__)
    from google.ads.googleads import AdGroupLabelServiceGrpcTransport
    expected_names.append(AdGroupLabelServiceGrpcTransport.__name__)
    from google.ads.googleads import AdGroupFeedServiceClient
    expected_names.append(AdGroupFeedServiceClient.__name__)
    from google.ads.googleads import AdGroupFeedServiceTransport
    expected_names.append(AdGroupFeedServiceTransport.__name__)
    from google.ads.googleads import AdGroupFeedServiceGrpcTransport
    expected_names.append(AdGroupFeedServiceGrpcTransport.__name__)
    from google.ads.googleads import AdGroupExtensionSettingServiceClient
    expected_names.append(AdGroupExtensionSettingServiceClient.__name__)
    from google.ads.googleads import AdGroupExtensionSettingServiceTransport
    expected_names.append(AdGroupExtensionSettingServiceTransport.__name__)
    from google.ads.googleads import AdGroupExtensionSettingServiceGrpcTransport
    expected_names.append(AdGroupExtensionSettingServiceGrpcTransport.__name__)
    from google.ads.googleads import AdGroupCriterionSimulationServiceClient
    expected_names.append(AdGroupCriterionSimulationServiceClient.__name__)
    from google.ads.googleads import AdGroupCriterionSimulationServiceTransport
    expected_names.append(AdGroupCriterionSimulationServiceTransport.__name__)
    from google.ads.googleads import AdGroupCriterionSimulationServiceGrpcTransport
    expected_names.append(AdGroupCriterionSimulationServiceGrpcTransport.__name__)
    from google.ads.googleads import AdGroupCriterionServiceClient
    expected_names.append(AdGroupCriterionServiceClient.__name__)
    from google.ads.googleads import AdGroupCriterionServiceTransport
    expected_names.append(AdGroupCriterionServiceTransport.__name__)
    from google.ads.googleads import AdGroupCriterionServiceGrpcTransport
    expected_names.append(AdGroupCriterionServiceGrpcTransport.__name__)
    from google.ads.googleads import AdGroupCriterionLabelServiceClient
    expected_names.append(AdGroupCriterionLabelServiceClient.__name__)
    from google.ads.googleads import AdGroupCriterionLabelServiceTransport
    expected_names.append(AdGroupCriterionLabelServiceTransport.__name__)
    from google.ads.googleads import AdGroupCriterionLabelServiceGrpcTransport
    expected_names.append(AdGroupCriterionLabelServiceGrpcTransport.__name__)
    from google.ads.googleads import AdGroupBidModifierServiceClient
    expected_names.append(AdGroupBidModifierServiceClient.__name__)
    from google.ads.googleads import AdGroupBidModifierServiceTransport
    expected_names.append(AdGroupBidModifierServiceTransport.__name__)
    from google.ads.googleads import AdGroupBidModifierServiceGrpcTransport
    expected_names.append(AdGroupBidModifierServiceGrpcTransport.__name__)
    from google.ads.googleads import AdGroupAudienceViewServiceClient
    expected_names.append(AdGroupAudienceViewServiceClient.__name__)
    from google.ads.googleads import AdGroupAudienceViewServiceTransport
    expected_names.append(AdGroupAudienceViewServiceTransport.__name__)
    from google.ads.googleads import AdGroupAudienceViewServiceGrpcTransport
    expected_names.append(AdGroupAudienceViewServiceGrpcTransport.__name__)
    from google.ads.googleads import AdGroupAssetServiceClient
    expected_names.append(AdGroupAssetServiceClient.__name__)
    from google.ads.googleads import AdGroupAssetServiceTransport
    expected_names.append(AdGroupAssetServiceTransport.__name__)
    from google.ads.googleads import AdGroupAssetServiceGrpcTransport
    expected_names.append(AdGroupAssetServiceGrpcTransport.__name__)
    from google.ads.googleads import AdGroupAdServiceClient
    expected_names.append(AdGroupAdServiceClient.__name__)
    from google.ads.googleads import AdGroupAdServiceTransport
    expected_names.append(AdGroupAdServiceTransport.__name__)
    from google.ads.googleads import AdGroupAdServiceGrpcTransport
    expected_names.append(AdGroupAdServiceGrpcTransport.__name__)
    from google.ads.googleads import AdGroupAdLabelServiceClient
    expected_names.append(AdGroupAdLabelServiceClient.__name__)
    from google.ads.googleads import AdGroupAdLabelServiceTransport
    expected_names.append(AdGroupAdLabelServiceTransport.__name__)
    from google.ads.googleads import AdGroupAdLabelServiceGrpcTransport
    expected_names.append(AdGroupAdLabelServiceGrpcTransport.__name__)
    from google.ads.googleads import AdGroupAdAssetViewServiceClient
    expected_names.append(AdGroupAdAssetViewServiceClient.__name__)
    from google.ads.googleads import AdGroupAdAssetViewServiceTransport
    expected_names.append(AdGroupAdAssetViewServiceTransport.__name__)
    from google.ads.googleads import AdGroupAdAssetViewServiceGrpcTransport
    expected_names.append(AdGroupAdAssetViewServiceGrpcTransport.__name__)
    from google.ads.googleads import AccountLinkServiceClient
    expected_names.append(AccountLinkServiceClient.__name__)
    from google.ads.googleads import AccountLinkServiceTransport
    expected_names.append(AccountLinkServiceTransport.__name__)
    from google.ads.googleads import AccountLinkServiceGrpcTransport
    expected_names.append(AccountLinkServiceGrpcTransport.__name__)
    from google.ads.googleads import AccountBudgetServiceClient
    expected_names.append(AccountBudgetServiceClient.__name__)
    from google.ads.googleads import AccountBudgetServiceTransport
    expected_names.append(AccountBudgetServiceTransport.__name__)
    from google.ads.googleads import AccountBudgetServiceGrpcTransport
    expected_names.append(AccountBudgetServiceGrpcTransport.__name__)
    from google.ads.googleads import AccountBudgetProposalServiceClient
    expected_names.append(AccountBudgetProposalServiceClient.__name__)
    from google.ads.googleads import AccountBudgetProposalServiceTransport
    expected_names.append(AccountBudgetProposalServiceTransport.__name__)
    from google.ads.googleads import AccountBudgetProposalServiceGrpcTransport
    expected_names.append(AccountBudgetProposalServiceGrpcTransport.__name__)

    expected_names.sort()
    from google.ads import googleads
    actual_names = dir(googleads)
    assert expected_names == actual_names

    # Verify the logic for handling non-existant names
    with pytest.raises(ImportError):
        from google.ads.googleads import GiantSquid


def test_versionsed_module_level_imports():
    expected_names = []

    # Message types
    from google.ads.googleads.v7 import PolicyTopicEntryTypeEnum
    expected_names.append(PolicyTopicEntryTypeEnum.__name__)
    from google.ads.googleads.v7 import PolicyTopicEvidenceDestinationMismatchUrlTypeEnum
    expected_names.append(PolicyTopicEvidenceDestinationMismatchUrlTypeEnum.__name__)
    from google.ads.googleads.v7 import PolicyTopicEvidenceDestinationNotWorkingDeviceEnum
    expected_names.append(PolicyTopicEvidenceDestinationNotWorkingDeviceEnum.__name__)
    from google.ads.googleads.v7 import PolicyTopicEvidenceDestinationNotWorkingDnsErrorTypeEnum
    expected_names.append(PolicyTopicEvidenceDestinationNotWorkingDnsErrorTypeEnum.__name__)
    from google.ads.googleads.v7 import PolicyViolationKey
    expected_names.append(PolicyViolationKey.__name__)
    from google.ads.googleads.v7 import PolicyValidationParameter
    expected_names.append(PolicyValidationParameter.__name__)
    from google.ads.googleads.v7 import PolicyTopicEntry
    expected_names.append(PolicyTopicEntry.__name__)
    from google.ads.googleads.v7 import PolicyTopicEvidence
    expected_names.append(PolicyTopicEvidence.__name__)
    from google.ads.googleads.v7 import PolicyTopicConstraint
    expected_names.append(PolicyTopicConstraint.__name__)
    from google.ads.googleads.v7 import PolicyApprovalStatusEnum
    expected_names.append(PolicyApprovalStatusEnum.__name__)
    from google.ads.googleads.v7 import PolicyReviewStatusEnum
    expected_names.append(PolicyReviewStatusEnum.__name__)
    from google.ads.googleads.v7 import AdAssetPolicySummary
    expected_names.append(AdAssetPolicySummary.__name__)
    from google.ads.googleads.v7 import AssetPerformanceLabelEnum
    expected_names.append(AssetPerformanceLabelEnum.__name__)
    from google.ads.googleads.v7 import ServedAssetFieldTypeEnum
    expected_names.append(ServedAssetFieldTypeEnum.__name__)
    from google.ads.googleads.v7 import AdTextAsset
    expected_names.append(AdTextAsset.__name__)
    from google.ads.googleads.v7 import AdImageAsset
    expected_names.append(AdImageAsset.__name__)
    from google.ads.googleads.v7 import AdVideoAsset
    expected_names.append(AdVideoAsset.__name__)
    from google.ads.googleads.v7 import AdMediaBundleAsset
    expected_names.append(AdMediaBundleAsset.__name__)
    from google.ads.googleads.v7 import CallConversionReportingStateEnum
    expected_names.append(CallConversionReportingStateEnum.__name__)
    from google.ads.googleads.v7 import DisplayAdFormatSettingEnum
    expected_names.append(DisplayAdFormatSettingEnum.__name__)
    from google.ads.googleads.v7 import DisplayUploadProductTypeEnum
    expected_names.append(DisplayUploadProductTypeEnum.__name__)
    from google.ads.googleads.v7 import LegacyAppInstallAdAppStoreEnum
    expected_names.append(LegacyAppInstallAdAppStoreEnum.__name__)
    from google.ads.googleads.v7 import MimeTypeEnum
    expected_names.append(MimeTypeEnum.__name__)
    from google.ads.googleads.v7 import TextAdInfo
    expected_names.append(TextAdInfo.__name__)
    from google.ads.googleads.v7 import ExpandedTextAdInfo
    expected_names.append(ExpandedTextAdInfo.__name__)
    from google.ads.googleads.v7 import CallOnlyAdInfo
    expected_names.append(CallOnlyAdInfo.__name__)
    from google.ads.googleads.v7 import ExpandedDynamicSearchAdInfo
    expected_names.append(ExpandedDynamicSearchAdInfo.__name__)
    from google.ads.googleads.v7 import HotelAdInfo
    expected_names.append(HotelAdInfo.__name__)
    from google.ads.googleads.v7 import ShoppingSmartAdInfo
    expected_names.append(ShoppingSmartAdInfo.__name__)
    from google.ads.googleads.v7 import ShoppingProductAdInfo
    expected_names.append(ShoppingProductAdInfo.__name__)
    from google.ads.googleads.v7 import ShoppingComparisonListingAdInfo
    expected_names.append(ShoppingComparisonListingAdInfo.__name__)
    from google.ads.googleads.v7 import GmailAdInfo
    expected_names.append(GmailAdInfo.__name__)
    from google.ads.googleads.v7 import GmailTeaser
    expected_names.append(GmailTeaser.__name__)
    from google.ads.googleads.v7 import DisplayCallToAction
    expected_names.append(DisplayCallToAction.__name__)
    from google.ads.googleads.v7 import ProductImage
    expected_names.append(ProductImage.__name__)
    from google.ads.googleads.v7 import ProductVideo
    expected_names.append(ProductVideo.__name__)
    from google.ads.googleads.v7 import ImageAdInfo
    expected_names.append(ImageAdInfo.__name__)
    from google.ads.googleads.v7 import VideoBumperInStreamAdInfo
    expected_names.append(VideoBumperInStreamAdInfo.__name__)
    from google.ads.googleads.v7 import VideoNonSkippableInStreamAdInfo
    expected_names.append(VideoNonSkippableInStreamAdInfo.__name__)
    from google.ads.googleads.v7 import VideoTrueViewInStreamAdInfo
    expected_names.append(VideoTrueViewInStreamAdInfo.__name__)
    from google.ads.googleads.v7 import VideoOutstreamAdInfo
    expected_names.append(VideoOutstreamAdInfo.__name__)
    from google.ads.googleads.v7 import VideoTrueViewDiscoveryAdInfo
    expected_names.append(VideoTrueViewDiscoveryAdInfo.__name__)
    from google.ads.googleads.v7 import VideoAdInfo
    expected_names.append(VideoAdInfo.__name__)
    from google.ads.googleads.v7 import VideoResponsiveAdInfo
    expected_names.append(VideoResponsiveAdInfo.__name__)
    from google.ads.googleads.v7 import ResponsiveSearchAdInfo
    expected_names.append(ResponsiveSearchAdInfo.__name__)
    from google.ads.googleads.v7 import LegacyResponsiveDisplayAdInfo
    expected_names.append(LegacyResponsiveDisplayAdInfo.__name__)
    from google.ads.googleads.v7 import AppAdInfo
    expected_names.append(AppAdInfo.__name__)
    from google.ads.googleads.v7 import AppEngagementAdInfo
    expected_names.append(AppEngagementAdInfo.__name__)
    from google.ads.googleads.v7 import LegacyAppInstallAdInfo
    expected_names.append(LegacyAppInstallAdInfo.__name__)
    from google.ads.googleads.v7 import ResponsiveDisplayAdInfo
    expected_names.append(ResponsiveDisplayAdInfo.__name__)
    from google.ads.googleads.v7 import LocalAdInfo
    expected_names.append(LocalAdInfo.__name__)
    from google.ads.googleads.v7 import DisplayUploadAdInfo
    expected_names.append(DisplayUploadAdInfo.__name__)
    from google.ads.googleads.v7 import ResponsiveDisplayAdControlSpec
    expected_names.append(ResponsiveDisplayAdControlSpec.__name__)
    from google.ads.googleads.v7 import AgeRangeTypeEnum
    expected_names.append(AgeRangeTypeEnum.__name__)
    from google.ads.googleads.v7 import AppPaymentModelTypeEnum
    expected_names.append(AppPaymentModelTypeEnum.__name__)
    from google.ads.googleads.v7 import ContentLabelTypeEnum
    expected_names.append(ContentLabelTypeEnum.__name__)
    from google.ads.googleads.v7 import DayOfWeekEnum
    expected_names.append(DayOfWeekEnum.__name__)
    from google.ads.googleads.v7 import DeviceEnum
    expected_names.append(DeviceEnum.__name__)
    from google.ads.googleads.v7 import GenderTypeEnum
    expected_names.append(GenderTypeEnum.__name__)
    from google.ads.googleads.v7 import HotelDateSelectionTypeEnum
    expected_names.append(HotelDateSelectionTypeEnum.__name__)
    from google.ads.googleads.v7 import IncomeRangeTypeEnum
    expected_names.append(IncomeRangeTypeEnum.__name__)
    from google.ads.googleads.v7 import InteractionTypeEnum
    expected_names.append(InteractionTypeEnum.__name__)
    from google.ads.googleads.v7 import KeywordMatchTypeEnum
    expected_names.append(KeywordMatchTypeEnum.__name__)
    from google.ads.googleads.v7 import ListingGroupTypeEnum
    expected_names.append(ListingGroupTypeEnum.__name__)
    from google.ads.googleads.v7 import LocationGroupRadiusUnitsEnum
    expected_names.append(LocationGroupRadiusUnitsEnum.__name__)
    from google.ads.googleads.v7 import MinuteOfHourEnum
    expected_names.append(MinuteOfHourEnum.__name__)
    from google.ads.googleads.v7 import ParentalStatusTypeEnum
    expected_names.append(ParentalStatusTypeEnum.__name__)
    from google.ads.googleads.v7 import PreferredContentTypeEnum
    expected_names.append(PreferredContentTypeEnum.__name__)
    from google.ads.googleads.v7 import ProductBiddingCategoryLevelEnum
    expected_names.append(ProductBiddingCategoryLevelEnum.__name__)
    from google.ads.googleads.v7 import ProductChannelEnum
    expected_names.append(ProductChannelEnum.__name__)
    from google.ads.googleads.v7 import ProductChannelExclusivityEnum
    expected_names.append(ProductChannelExclusivityEnum.__name__)
    from google.ads.googleads.v7 import ProductConditionEnum
    expected_names.append(ProductConditionEnum.__name__)
    from google.ads.googleads.v7 import ProductCustomAttributeIndexEnum
    expected_names.append(ProductCustomAttributeIndexEnum.__name__)
    from google.ads.googleads.v7 import ProductTypeLevelEnum
    expected_names.append(ProductTypeLevelEnum.__name__)
    from google.ads.googleads.v7 import ProximityRadiusUnitsEnum
    expected_names.append(ProximityRadiusUnitsEnum.__name__)
    from google.ads.googleads.v7 import WebpageConditionOperandEnum
    expected_names.append(WebpageConditionOperandEnum.__name__)
    from google.ads.googleads.v7 import WebpageConditionOperatorEnum
    expected_names.append(WebpageConditionOperatorEnum.__name__)
    from google.ads.googleads.v7 import KeywordInfo
    expected_names.append(KeywordInfo.__name__)
    from google.ads.googleads.v7 import PlacementInfo
    expected_names.append(PlacementInfo.__name__)
    from google.ads.googleads.v7 import MobileAppCategoryInfo
    expected_names.append(MobileAppCategoryInfo.__name__)
    from google.ads.googleads.v7 import MobileApplicationInfo
    expected_names.append(MobileApplicationInfo.__name__)
    from google.ads.googleads.v7 import LocationInfo
    expected_names.append(LocationInfo.__name__)
    from google.ads.googleads.v7 import DeviceInfo
    expected_names.append(DeviceInfo.__name__)
    from google.ads.googleads.v7 import PreferredContentInfo
    expected_names.append(PreferredContentInfo.__name__)
    from google.ads.googleads.v7 import ListingGroupInfo
    expected_names.append(ListingGroupInfo.__name__)
    from google.ads.googleads.v7 import ListingScopeInfo
    expected_names.append(ListingScopeInfo.__name__)
    from google.ads.googleads.v7 import ListingDimensionInfo
    expected_names.append(ListingDimensionInfo.__name__)
    from google.ads.googleads.v7 import HotelIdInfo
    expected_names.append(HotelIdInfo.__name__)
    from google.ads.googleads.v7 import HotelClassInfo
    expected_names.append(HotelClassInfo.__name__)
    from google.ads.googleads.v7 import HotelCountryRegionInfo
    expected_names.append(HotelCountryRegionInfo.__name__)
    from google.ads.googleads.v7 import HotelStateInfo
    expected_names.append(HotelStateInfo.__name__)
    from google.ads.googleads.v7 import HotelCityInfo
    expected_names.append(HotelCityInfo.__name__)
    from google.ads.googleads.v7 import ProductBiddingCategoryInfo
    expected_names.append(ProductBiddingCategoryInfo.__name__)
    from google.ads.googleads.v7 import ProductBrandInfo
    expected_names.append(ProductBrandInfo.__name__)
    from google.ads.googleads.v7 import ProductChannelInfo
    expected_names.append(ProductChannelInfo.__name__)
    from google.ads.googleads.v7 import ProductChannelExclusivityInfo
    expected_names.append(ProductChannelExclusivityInfo.__name__)
    from google.ads.googleads.v7 import ProductConditionInfo
    expected_names.append(ProductConditionInfo.__name__)
    from google.ads.googleads.v7 import ProductCustomAttributeInfo
    expected_names.append(ProductCustomAttributeInfo.__name__)
    from google.ads.googleads.v7 import ProductItemIdInfo
    expected_names.append(ProductItemIdInfo.__name__)
    from google.ads.googleads.v7 import ProductTypeInfo
    expected_names.append(ProductTypeInfo.__name__)
    from google.ads.googleads.v7 import UnknownListingDimensionInfo
    expected_names.append(UnknownListingDimensionInfo.__name__)
    from google.ads.googleads.v7 import HotelDateSelectionTypeInfo
    expected_names.append(HotelDateSelectionTypeInfo.__name__)
    from google.ads.googleads.v7 import HotelAdvanceBookingWindowInfo
    expected_names.append(HotelAdvanceBookingWindowInfo.__name__)
    from google.ads.googleads.v7 import HotelLengthOfStayInfo
    expected_names.append(HotelLengthOfStayInfo.__name__)
    from google.ads.googleads.v7 import HotelCheckInDateRangeInfo
    expected_names.append(HotelCheckInDateRangeInfo.__name__)
    from google.ads.googleads.v7 import HotelCheckInDayInfo
    expected_names.append(HotelCheckInDayInfo.__name__)
    from google.ads.googleads.v7 import InteractionTypeInfo
    expected_names.append(InteractionTypeInfo.__name__)
    from google.ads.googleads.v7 import AdScheduleInfo
    expected_names.append(AdScheduleInfo.__name__)
    from google.ads.googleads.v7 import AgeRangeInfo
    expected_names.append(AgeRangeInfo.__name__)
    from google.ads.googleads.v7 import GenderInfo
    expected_names.append(GenderInfo.__name__)
    from google.ads.googleads.v7 import IncomeRangeInfo
    expected_names.append(IncomeRangeInfo.__name__)
    from google.ads.googleads.v7 import ParentalStatusInfo
    expected_names.append(ParentalStatusInfo.__name__)
    from google.ads.googleads.v7 import YouTubeVideoInfo
    expected_names.append(YouTubeVideoInfo.__name__)
    from google.ads.googleads.v7 import YouTubeChannelInfo
    expected_names.append(YouTubeChannelInfo.__name__)
    from google.ads.googleads.v7 import UserListInfo
    expected_names.append(UserListInfo.__name__)
    from google.ads.googleads.v7 import ProximityInfo
    expected_names.append(ProximityInfo.__name__)
    from google.ads.googleads.v7 import GeoPointInfo
    expected_names.append(GeoPointInfo.__name__)
    from google.ads.googleads.v7 import AddressInfo
    expected_names.append(AddressInfo.__name__)
    from google.ads.googleads.v7 import TopicInfo
    expected_names.append(TopicInfo.__name__)
    from google.ads.googleads.v7 import LanguageInfo
    expected_names.append(LanguageInfo.__name__)
    from google.ads.googleads.v7 import IpBlockInfo
    expected_names.append(IpBlockInfo.__name__)
    from google.ads.googleads.v7 import ContentLabelInfo
    expected_names.append(ContentLabelInfo.__name__)
    from google.ads.googleads.v7 import CarrierInfo
    expected_names.append(CarrierInfo.__name__)
    from google.ads.googleads.v7 import UserInterestInfo
    expected_names.append(UserInterestInfo.__name__)
    from google.ads.googleads.v7 import WebpageInfo
    expected_names.append(WebpageInfo.__name__)
    from google.ads.googleads.v7 import WebpageConditionInfo
    expected_names.append(WebpageConditionInfo.__name__)
    from google.ads.googleads.v7 import WebpageSampleInfo
    expected_names.append(WebpageSampleInfo.__name__)
    from google.ads.googleads.v7 import OperatingSystemVersionInfo
    expected_names.append(OperatingSystemVersionInfo.__name__)
    from google.ads.googleads.v7 import AppPaymentModelInfo
    expected_names.append(AppPaymentModelInfo.__name__)
    from google.ads.googleads.v7 import MobileDeviceInfo
    expected_names.append(MobileDeviceInfo.__name__)
    from google.ads.googleads.v7 import CustomAffinityInfo
    expected_names.append(CustomAffinityInfo.__name__)
    from google.ads.googleads.v7 import CustomIntentInfo
    expected_names.append(CustomIntentInfo.__name__)
    from google.ads.googleads.v7 import LocationGroupInfo
    expected_names.append(LocationGroupInfo.__name__)
    from google.ads.googleads.v7 import CustomAudienceInfo
    expected_names.append(CustomAudienceInfo.__name__)
    from google.ads.googleads.v7 import CombinedAudienceInfo
    expected_names.append(CombinedAudienceInfo.__name__)
    from google.ads.googleads.v7 import Money
    expected_names.append(Money.__name__)
    from google.ads.googleads.v7 import LeadFormCallToActionTypeEnum
    expected_names.append(LeadFormCallToActionTypeEnum.__name__)
    from google.ads.googleads.v7 import LeadFormDesiredIntentEnum
    expected_names.append(LeadFormDesiredIntentEnum.__name__)
    from google.ads.googleads.v7 import LeadFormFieldUserInputTypeEnum
    expected_names.append(LeadFormFieldUserInputTypeEnum.__name__)
    from google.ads.googleads.v7 import LeadFormPostSubmitCallToActionTypeEnum
    expected_names.append(LeadFormPostSubmitCallToActionTypeEnum.__name__)
    from google.ads.googleads.v7 import PromotionExtensionDiscountModifierEnum
    expected_names.append(PromotionExtensionDiscountModifierEnum.__name__)
    from google.ads.googleads.v7 import PromotionExtensionOccasionEnum
    expected_names.append(PromotionExtensionOccasionEnum.__name__)
    from google.ads.googleads.v7 import YoutubeVideoAsset
    expected_names.append(YoutubeVideoAsset.__name__)
    from google.ads.googleads.v7 import MediaBundleAsset
    expected_names.append(MediaBundleAsset.__name__)
    from google.ads.googleads.v7 import ImageAsset
    expected_names.append(ImageAsset.__name__)
    from google.ads.googleads.v7 import ImageDimension
    expected_names.append(ImageDimension.__name__)
    from google.ads.googleads.v7 import TextAsset
    expected_names.append(TextAsset.__name__)
    from google.ads.googleads.v7 import LeadFormAsset
    expected_names.append(LeadFormAsset.__name__)
    from google.ads.googleads.v7 import LeadFormField
    expected_names.append(LeadFormField.__name__)
    from google.ads.googleads.v7 import LeadFormSingleChoiceAnswers
    expected_names.append(LeadFormSingleChoiceAnswers.__name__)
    from google.ads.googleads.v7 import LeadFormDeliveryMethod
    expected_names.append(LeadFormDeliveryMethod.__name__)
    from google.ads.googleads.v7 import WebhookDelivery
    expected_names.append(WebhookDelivery.__name__)
    from google.ads.googleads.v7 import BookOnGoogleAsset
    expected_names.append(BookOnGoogleAsset.__name__)
    from google.ads.googleads.v7 import PromotionAsset
    expected_names.append(PromotionAsset.__name__)
    from google.ads.googleads.v7 import CalloutAsset
    expected_names.append(CalloutAsset.__name__)
    from google.ads.googleads.v7 import StructuredSnippetAsset
    expected_names.append(StructuredSnippetAsset.__name__)
    from google.ads.googleads.v7 import SitelinkAsset
    expected_names.append(SitelinkAsset.__name__)
    from google.ads.googleads.v7 import TargetImpressionShareLocationEnum
    expected_names.append(TargetImpressionShareLocationEnum.__name__)
    from google.ads.googleads.v7 import Commission
    expected_names.append(Commission.__name__)
    from google.ads.googleads.v7 import EnhancedCpc
    expected_names.append(EnhancedCpc.__name__)
    from google.ads.googleads.v7 import ManualCpc
    expected_names.append(ManualCpc.__name__)
    from google.ads.googleads.v7 import ManualCpm
    expected_names.append(ManualCpm.__name__)
    from google.ads.googleads.v7 import ManualCpv
    expected_names.append(ManualCpv.__name__)
    from google.ads.googleads.v7 import MaximizeConversions
    expected_names.append(MaximizeConversions.__name__)
    from google.ads.googleads.v7 import MaximizeConversionValue
    expected_names.append(MaximizeConversionValue.__name__)
    from google.ads.googleads.v7 import TargetCpa
    expected_names.append(TargetCpa.__name__)
    from google.ads.googleads.v7 import TargetCpm
    expected_names.append(TargetCpm.__name__)
    from google.ads.googleads.v7 import TargetImpressionShare
    expected_names.append(TargetImpressionShare.__name__)
    from google.ads.googleads.v7 import TargetRoas
    expected_names.append(TargetRoas.__name__)
    from google.ads.googleads.v7 import TargetSpend
    expected_names.append(TargetSpend.__name__)
    from google.ads.googleads.v7 import PercentCpc
    expected_names.append(PercentCpc.__name__)
    from google.ads.googleads.v7 import ClickLocation
    expected_names.append(ClickLocation.__name__)
    from google.ads.googleads.v7 import AdvertisingChannelSubTypeEnum
    expected_names.append(AdvertisingChannelSubTypeEnum.__name__)
    from google.ads.googleads.v7 import AdvertisingChannelTypeEnum
    expected_names.append(AdvertisingChannelTypeEnum.__name__)
    from google.ads.googleads.v7 import CriterionCategoryChannelAvailabilityModeEnum
    expected_names.append(CriterionCategoryChannelAvailabilityModeEnum.__name__)
    from google.ads.googleads.v7 import CriterionCategoryLocaleAvailabilityModeEnum
    expected_names.append(CriterionCategoryLocaleAvailabilityModeEnum.__name__)
    from google.ads.googleads.v7 import CriterionCategoryAvailability
    expected_names.append(CriterionCategoryAvailability.__name__)
    from google.ads.googleads.v7 import CriterionCategoryChannelAvailability
    expected_names.append(CriterionCategoryChannelAvailability.__name__)
    from google.ads.googleads.v7 import CriterionCategoryLocaleAvailability
    expected_names.append(CriterionCategoryLocaleAvailability.__name__)
    from google.ads.googleads.v7 import CustomParameter
    expected_names.append(CustomParameter.__name__)
    from google.ads.googleads.v7 import MonthOfYearEnum
    expected_names.append(MonthOfYearEnum.__name__)
    from google.ads.googleads.v7 import DateRange
    expected_names.append(DateRange.__name__)
    from google.ads.googleads.v7 import YearMonthRange
    expected_names.append(YearMonthRange.__name__)
    from google.ads.googleads.v7 import YearMonth
    expected_names.append(YearMonth.__name__)
    from google.ads.googleads.v7 import ExplorerAutoOptimizerSetting
    expected_names.append(ExplorerAutoOptimizerSetting.__name__)
    from google.ads.googleads.v7 import AppStoreEnum
    expected_names.append(AppStoreEnum.__name__)
    from google.ads.googleads.v7 import PriceExtensionPriceQualifierEnum
    expected_names.append(PriceExtensionPriceQualifierEnum.__name__)
    from google.ads.googleads.v7 import PriceExtensionPriceUnitEnum
    expected_names.append(PriceExtensionPriceUnitEnum.__name__)
    from google.ads.googleads.v7 import PriceExtensionTypeEnum
    expected_names.append(PriceExtensionTypeEnum.__name__)
    from google.ads.googleads.v7 import AppFeedItem
    expected_names.append(AppFeedItem.__name__)
    from google.ads.googleads.v7 import CallFeedItem
    expected_names.append(CallFeedItem.__name__)
    from google.ads.googleads.v7 import CalloutFeedItem
    expected_names.append(CalloutFeedItem.__name__)
    from google.ads.googleads.v7 import LocationFeedItem
    expected_names.append(LocationFeedItem.__name__)
    from google.ads.googleads.v7 import AffiliateLocationFeedItem
    expected_names.append(AffiliateLocationFeedItem.__name__)
    from google.ads.googleads.v7 import TextMessageFeedItem
    expected_names.append(TextMessageFeedItem.__name__)
    from google.ads.googleads.v7 import PriceFeedItem
    expected_names.append(PriceFeedItem.__name__)
    from google.ads.googleads.v7 import PriceOffer
    expected_names.append(PriceOffer.__name__)
    from google.ads.googleads.v7 import PromotionFeedItem
    expected_names.append(PromotionFeedItem.__name__)
    from google.ads.googleads.v7 import StructuredSnippetFeedItem
    expected_names.append(StructuredSnippetFeedItem.__name__)
    from google.ads.googleads.v7 import SitelinkFeedItem
    expected_names.append(SitelinkFeedItem.__name__)
    from google.ads.googleads.v7 import HotelCalloutFeedItem
    expected_names.append(HotelCalloutFeedItem.__name__)
    from google.ads.googleads.v7 import ImageFeedItem
    expected_names.append(ImageFeedItem.__name__)
    from google.ads.googleads.v7 import FeedItemSetStringFilterTypeEnum
    expected_names.append(FeedItemSetStringFilterTypeEnum.__name__)
    from google.ads.googleads.v7 import DynamicLocationSetFilter
    expected_names.append(DynamicLocationSetFilter.__name__)
    from google.ads.googleads.v7 import BusinessNameFilter
    expected_names.append(BusinessNameFilter.__name__)
    from google.ads.googleads.v7 import DynamicAffiliateLocationSetFilter
    expected_names.append(DynamicAffiliateLocationSetFilter.__name__)
    from google.ads.googleads.v7 import AppUrlOperatingSystemTypeEnum
    expected_names.append(AppUrlOperatingSystemTypeEnum.__name__)
    from google.ads.googleads.v7 import FinalAppUrl
    expected_names.append(FinalAppUrl.__name__)
    from google.ads.googleads.v7 import FrequencyCapEventTypeEnum
    expected_names.append(FrequencyCapEventTypeEnum.__name__)
    from google.ads.googleads.v7 import FrequencyCapLevelEnum
    expected_names.append(FrequencyCapLevelEnum.__name__)
    from google.ads.googleads.v7 import FrequencyCapTimeUnitEnum
    expected_names.append(FrequencyCapTimeUnitEnum.__name__)
    from google.ads.googleads.v7 import FrequencyCapEntry
    expected_names.append(FrequencyCapEntry.__name__)
    from google.ads.googleads.v7 import FrequencyCapKey
    expected_names.append(FrequencyCapKey.__name__)
    from google.ads.googleads.v7 import KeywordPlanAggregateMetricTypeEnum
    expected_names.append(KeywordPlanAggregateMetricTypeEnum.__name__)
    from google.ads.googleads.v7 import KeywordPlanCompetitionLevelEnum
    expected_names.append(KeywordPlanCompetitionLevelEnum.__name__)
    from google.ads.googleads.v7 import KeywordPlanConceptGroupTypeEnum
    expected_names.append(KeywordPlanConceptGroupTypeEnum.__name__)
    from google.ads.googleads.v7 import KeywordPlanHistoricalMetrics
    expected_names.append(KeywordPlanHistoricalMetrics.__name__)
    from google.ads.googleads.v7 import HistoricalMetricsOptions
    expected_names.append(HistoricalMetricsOptions.__name__)
    from google.ads.googleads.v7 import MonthlySearchVolume
    expected_names.append(MonthlySearchVolume.__name__)
    from google.ads.googleads.v7 import KeywordPlanAggregateMetrics
    expected_names.append(KeywordPlanAggregateMetrics.__name__)
    from google.ads.googleads.v7 import KeywordPlanAggregateMetricResults
    expected_names.append(KeywordPlanAggregateMetricResults.__name__)
    from google.ads.googleads.v7 import KeywordPlanDeviceSearches
    expected_names.append(KeywordPlanDeviceSearches.__name__)
    from google.ads.googleads.v7 import KeywordAnnotations
    expected_names.append(KeywordAnnotations.__name__)
    from google.ads.googleads.v7 import KeywordConcept
    expected_names.append(KeywordConcept.__name__)
    from google.ads.googleads.v7 import ConceptGroup
    expected_names.append(ConceptGroup.__name__)
    from google.ads.googleads.v7 import MatchingFunctionContextTypeEnum
    expected_names.append(MatchingFunctionContextTypeEnum.__name__)
    from google.ads.googleads.v7 import MatchingFunctionOperatorEnum
    expected_names.append(MatchingFunctionOperatorEnum.__name__)
    from google.ads.googleads.v7 import MatchingFunction
    expected_names.append(MatchingFunction.__name__)
    from google.ads.googleads.v7 import Operand
    expected_names.append(Operand.__name__)
    from google.ads.googleads.v7 import InteractionEventTypeEnum
    expected_names.append(InteractionEventTypeEnum.__name__)
    from google.ads.googleads.v7 import QualityScoreBucketEnum
    expected_names.append(QualityScoreBucketEnum.__name__)
    from google.ads.googleads.v7 import Metrics
    expected_names.append(Metrics.__name__)
    from google.ads.googleads.v7 import UserIdentifierSourceEnum
    expected_names.append(UserIdentifierSourceEnum.__name__)
    from google.ads.googleads.v7 import OfflineUserAddressInfo
    expected_names.append(OfflineUserAddressInfo.__name__)
    from google.ads.googleads.v7 import UserIdentifier
    expected_names.append(UserIdentifier.__name__)
    from google.ads.googleads.v7 import TransactionAttribute
    expected_names.append(TransactionAttribute.__name__)
    from google.ads.googleads.v7 import StoreAttribute
    expected_names.append(StoreAttribute.__name__)
    from google.ads.googleads.v7 import UserData
    expected_names.append(UserData.__name__)
    from google.ads.googleads.v7 import UserAttribute
    expected_names.append(UserAttribute.__name__)
    from google.ads.googleads.v7 import CustomerMatchUserListMetadata
    expected_names.append(CustomerMatchUserListMetadata.__name__)
    from google.ads.googleads.v7 import StoreSalesMetadata
    expected_names.append(StoreSalesMetadata.__name__)
    from google.ads.googleads.v7 import StoreSalesThirdPartyMetadata
    expected_names.append(StoreSalesThirdPartyMetadata.__name__)
    from google.ads.googleads.v7 import RealTimeBiddingSetting
    expected_names.append(RealTimeBiddingSetting.__name__)
    from google.ads.googleads.v7 import AdDestinationTypeEnum
    expected_names.append(AdDestinationTypeEnum.__name__)
    from google.ads.googleads.v7 import AdNetworkTypeEnum
    expected_names.append(AdNetworkTypeEnum.__name__)
    from google.ads.googleads.v7 import BudgetCampaignAssociationStatusEnum
    expected_names.append(BudgetCampaignAssociationStatusEnum.__name__)
    from google.ads.googleads.v7 import ClickTypeEnum
    expected_names.append(ClickTypeEnum.__name__)
    from google.ads.googleads.v7 import ConversionActionCategoryEnum
    expected_names.append(ConversionActionCategoryEnum.__name__)
    from google.ads.googleads.v7 import ConversionAttributionEventTypeEnum
    expected_names.append(ConversionAttributionEventTypeEnum.__name__)
    from google.ads.googleads.v7 import ConversionLagBucketEnum
    expected_names.append(ConversionLagBucketEnum.__name__)
    from google.ads.googleads.v7 import ConversionOrAdjustmentLagBucketEnum
    expected_names.append(ConversionOrAdjustmentLagBucketEnum.__name__)
    from google.ads.googleads.v7 import ExternalConversionSourceEnum
    expected_names.append(ExternalConversionSourceEnum.__name__)
    from google.ads.googleads.v7 import HotelPriceBucketEnum
    expected_names.append(HotelPriceBucketEnum.__name__)
    from google.ads.googleads.v7 import HotelRateTypeEnum
    expected_names.append(HotelRateTypeEnum.__name__)
    from google.ads.googleads.v7 import PlaceholderTypeEnum
    expected_names.append(PlaceholderTypeEnum.__name__)
    from google.ads.googleads.v7 import SearchEngineResultsPageTypeEnum
    expected_names.append(SearchEngineResultsPageTypeEnum.__name__)
    from google.ads.googleads.v7 import SearchTermMatchTypeEnum
    expected_names.append(SearchTermMatchTypeEnum.__name__)
    from google.ads.googleads.v7 import SlotEnum
    expected_names.append(SlotEnum.__name__)
    from google.ads.googleads.v7 import Segments
    expected_names.append(Segments.__name__)
    from google.ads.googleads.v7 import Keyword
    expected_names.append(Keyword.__name__)
    from google.ads.googleads.v7 import BudgetCampaignAssociationStatus
    expected_names.append(BudgetCampaignAssociationStatus.__name__)
    from google.ads.googleads.v7 import BidModifierSimulationPointList
    expected_names.append(BidModifierSimulationPointList.__name__)
    from google.ads.googleads.v7 import CpcBidSimulationPointList
    expected_names.append(CpcBidSimulationPointList.__name__)
    from google.ads.googleads.v7 import CpvBidSimulationPointList
    expected_names.append(CpvBidSimulationPointList.__name__)
    from google.ads.googleads.v7 import TargetCpaSimulationPointList
    expected_names.append(TargetCpaSimulationPointList.__name__)
    from google.ads.googleads.v7 import TargetRoasSimulationPointList
    expected_names.append(TargetRoasSimulationPointList.__name__)
    from google.ads.googleads.v7 import PercentCpcBidSimulationPointList
    expected_names.append(PercentCpcBidSimulationPointList.__name__)
    from google.ads.googleads.v7 import BudgetSimulationPointList
    expected_names.append(BudgetSimulationPointList.__name__)
    from google.ads.googleads.v7 import TargetImpressionShareSimulationPointList
    expected_names.append(TargetImpressionShareSimulationPointList.__name__)
    from google.ads.googleads.v7 import BidModifierSimulationPoint
    expected_names.append(BidModifierSimulationPoint.__name__)
    from google.ads.googleads.v7 import CpcBidSimulationPoint
    expected_names.append(CpcBidSimulationPoint.__name__)
    from google.ads.googleads.v7 import CpvBidSimulationPoint
    expected_names.append(CpvBidSimulationPoint.__name__)
    from google.ads.googleads.v7 import TargetCpaSimulationPoint
    expected_names.append(TargetCpaSimulationPoint.__name__)
    from google.ads.googleads.v7 import TargetRoasSimulationPoint
    expected_names.append(TargetRoasSimulationPoint.__name__)
    from google.ads.googleads.v7 import PercentCpcBidSimulationPoint
    expected_names.append(PercentCpcBidSimulationPoint.__name__)
    from google.ads.googleads.v7 import BudgetSimulationPoint
    expected_names.append(BudgetSimulationPoint.__name__)
    from google.ads.googleads.v7 import TargetImpressionShareSimulationPoint
    expected_names.append(TargetImpressionShareSimulationPoint.__name__)
    from google.ads.googleads.v7 import TrackingCodePageFormatEnum
    expected_names.append(TrackingCodePageFormatEnum.__name__)
    from google.ads.googleads.v7 import TrackingCodeTypeEnum
    expected_names.append(TrackingCodeTypeEnum.__name__)
    from google.ads.googleads.v7 import TagSnippet
    expected_names.append(TagSnippet.__name__)
    from google.ads.googleads.v7 import TargetingDimensionEnum
    expected_names.append(TargetingDimensionEnum.__name__)
    from google.ads.googleads.v7 import TargetingSetting
    expected_names.append(TargetingSetting.__name__)
    from google.ads.googleads.v7 import TargetRestriction
    expected_names.append(TargetRestriction.__name__)
    from google.ads.googleads.v7 import TargetRestrictionOperation
    expected_names.append(TargetRestrictionOperation.__name__)
    from google.ads.googleads.v7 import TextLabel
    expected_names.append(TextLabel.__name__)
    from google.ads.googleads.v7 import UrlCollection
    expected_names.append(UrlCollection.__name__)
    from google.ads.googleads.v7 import CustomerMatchUploadKeyTypeEnum
    expected_names.append(CustomerMatchUploadKeyTypeEnum.__name__)
    from google.ads.googleads.v7 import UserListCombinedRuleOperatorEnum
    expected_names.append(UserListCombinedRuleOperatorEnum.__name__)
    from google.ads.googleads.v7 import UserListCrmDataSourceTypeEnum
    expected_names.append(UserListCrmDataSourceTypeEnum.__name__)
    from google.ads.googleads.v7 import UserListDateRuleItemOperatorEnum
    expected_names.append(UserListDateRuleItemOperatorEnum.__name__)
    from google.ads.googleads.v7 import UserListLogicalRuleOperatorEnum
    expected_names.append(UserListLogicalRuleOperatorEnum.__name__)
    from google.ads.googleads.v7 import UserListNumberRuleItemOperatorEnum
    expected_names.append(UserListNumberRuleItemOperatorEnum.__name__)
    from google.ads.googleads.v7 import UserListPrepopulationStatusEnum
    expected_names.append(UserListPrepopulationStatusEnum.__name__)
    from google.ads.googleads.v7 import UserListRuleTypeEnum
    expected_names.append(UserListRuleTypeEnum.__name__)
    from google.ads.googleads.v7 import UserListStringRuleItemOperatorEnum
    expected_names.append(UserListStringRuleItemOperatorEnum.__name__)
    from google.ads.googleads.v7 import SimilarUserListInfo
    expected_names.append(SimilarUserListInfo.__name__)
    from google.ads.googleads.v7 import CrmBasedUserListInfo
    expected_names.append(CrmBasedUserListInfo.__name__)
    from google.ads.googleads.v7 import UserListRuleInfo
    expected_names.append(UserListRuleInfo.__name__)
    from google.ads.googleads.v7 import UserListRuleItemGroupInfo
    expected_names.append(UserListRuleItemGroupInfo.__name__)
    from google.ads.googleads.v7 import UserListRuleItemInfo
    expected_names.append(UserListRuleItemInfo.__name__)
    from google.ads.googleads.v7 import UserListDateRuleItemInfo
    expected_names.append(UserListDateRuleItemInfo.__name__)
    from google.ads.googleads.v7 import UserListNumberRuleItemInfo
    expected_names.append(UserListNumberRuleItemInfo.__name__)
    from google.ads.googleads.v7 import UserListStringRuleItemInfo
    expected_names.append(UserListStringRuleItemInfo.__name__)
    from google.ads.googleads.v7 import CombinedRuleUserListInfo
    expected_names.append(CombinedRuleUserListInfo.__name__)
    from google.ads.googleads.v7 import DateSpecificRuleUserListInfo
    expected_names.append(DateSpecificRuleUserListInfo.__name__)
    from google.ads.googleads.v7 import ExpressionRuleUserListInfo
    expected_names.append(ExpressionRuleUserListInfo.__name__)
    from google.ads.googleads.v7 import RuleBasedUserListInfo
    expected_names.append(RuleBasedUserListInfo.__name__)
    from google.ads.googleads.v7 import LogicalUserListInfo
    expected_names.append(LogicalUserListInfo.__name__)
    from google.ads.googleads.v7 import UserListLogicalRuleInfo
    expected_names.append(UserListLogicalRuleInfo.__name__)
    from google.ads.googleads.v7 import LogicalUserListOperandInfo
    expected_names.append(LogicalUserListOperandInfo.__name__)
    from google.ads.googleads.v7 import BasicUserListInfo
    expected_names.append(BasicUserListInfo.__name__)
    from google.ads.googleads.v7 import UserListActionInfo
    expected_names.append(UserListActionInfo.__name__)
    from google.ads.googleads.v7 import Value
    expected_names.append(Value.__name__)
    from google.ads.googleads.v7 import AccessInvitationStatusEnum
    expected_names.append(AccessInvitationStatusEnum.__name__)
    from google.ads.googleads.v7 import AccessReasonEnum
    expected_names.append(AccessReasonEnum.__name__)
    from google.ads.googleads.v7 import AccessRoleEnum
    expected_names.append(AccessRoleEnum.__name__)
    from google.ads.googleads.v7 import AccountBudgetProposalStatusEnum
    expected_names.append(AccountBudgetProposalStatusEnum.__name__)
    from google.ads.googleads.v7 import AccountBudgetProposalTypeEnum
    expected_names.append(AccountBudgetProposalTypeEnum.__name__)
    from google.ads.googleads.v7 import AccountBudgetStatusEnum
    expected_names.append(AccountBudgetStatusEnum.__name__)
    from google.ads.googleads.v7 import AccountLinkStatusEnum
    expected_names.append(AccountLinkStatusEnum.__name__)
    from google.ads.googleads.v7 import AdCustomizerPlaceholderFieldEnum
    expected_names.append(AdCustomizerPlaceholderFieldEnum.__name__)
    from google.ads.googleads.v7 import AdGroupAdRotationModeEnum
    expected_names.append(AdGroupAdRotationModeEnum.__name__)
    from google.ads.googleads.v7 import AdGroupAdStatusEnum
    expected_names.append(AdGroupAdStatusEnum.__name__)
    from google.ads.googleads.v7 import AdGroupCriterionApprovalStatusEnum
    expected_names.append(AdGroupCriterionApprovalStatusEnum.__name__)
    from google.ads.googleads.v7 import AdGroupCriterionStatusEnum
    expected_names.append(AdGroupCriterionStatusEnum.__name__)
    from google.ads.googleads.v7 import AdGroupStatusEnum
    expected_names.append(AdGroupStatusEnum.__name__)
    from google.ads.googleads.v7 import AdGroupTypeEnum
    expected_names.append(AdGroupTypeEnum.__name__)
    from google.ads.googleads.v7 import AdServingOptimizationStatusEnum
    expected_names.append(AdServingOptimizationStatusEnum.__name__)
    from google.ads.googleads.v7 import AdStrengthEnum
    expected_names.append(AdStrengthEnum.__name__)
    from google.ads.googleads.v7 import AdTypeEnum
    expected_names.append(AdTypeEnum.__name__)
    from google.ads.googleads.v7 import AffiliateLocationFeedRelationshipTypeEnum
    expected_names.append(AffiliateLocationFeedRelationshipTypeEnum.__name__)
    from google.ads.googleads.v7 import AffiliateLocationPlaceholderFieldEnum
    expected_names.append(AffiliateLocationPlaceholderFieldEnum.__name__)
    from google.ads.googleads.v7 import AppCampaignAppStoreEnum
    expected_names.append(AppCampaignAppStoreEnum.__name__)
    from google.ads.googleads.v7 import AppCampaignBiddingStrategyGoalTypeEnum
    expected_names.append(AppCampaignBiddingStrategyGoalTypeEnum.__name__)
    from google.ads.googleads.v7 import AppPlaceholderFieldEnum
    expected_names.append(AppPlaceholderFieldEnum.__name__)
    from google.ads.googleads.v7 import AssetFieldTypeEnum
    expected_names.append(AssetFieldTypeEnum.__name__)
    from google.ads.googleads.v7 import AssetLinkStatusEnum
    expected_names.append(AssetLinkStatusEnum.__name__)
    from google.ads.googleads.v7 import AssetTypeEnum
    expected_names.append(AssetTypeEnum.__name__)
    from google.ads.googleads.v7 import AttributionModelEnum
    expected_names.append(AttributionModelEnum.__name__)
    from google.ads.googleads.v7 import BatchJobStatusEnum
    expected_names.append(BatchJobStatusEnum.__name__)
    from google.ads.googleads.v7 import BidModifierSourceEnum
    expected_names.append(BidModifierSourceEnum.__name__)
    from google.ads.googleads.v7 import BiddingSourceEnum
    expected_names.append(BiddingSourceEnum.__name__)
    from google.ads.googleads.v7 import BiddingStrategyStatusEnum
    expected_names.append(BiddingStrategyStatusEnum.__name__)
    from google.ads.googleads.v7 import BiddingStrategyTypeEnum
    expected_names.append(BiddingStrategyTypeEnum.__name__)
    from google.ads.googleads.v7 import BillingSetupStatusEnum
    expected_names.append(BillingSetupStatusEnum.__name__)
    from google.ads.googleads.v7 import BrandSafetySuitabilityEnum
    expected_names.append(BrandSafetySuitabilityEnum.__name__)
    from google.ads.googleads.v7 import BudgetDeliveryMethodEnum
    expected_names.append(BudgetDeliveryMethodEnum.__name__)
    from google.ads.googleads.v7 import BudgetPeriodEnum
    expected_names.append(BudgetPeriodEnum.__name__)
    from google.ads.googleads.v7 import BudgetStatusEnum
    expected_names.append(BudgetStatusEnum.__name__)
    from google.ads.googleads.v7 import BudgetTypeEnum
    expected_names.append(BudgetTypeEnum.__name__)
    from google.ads.googleads.v7 import CallPlaceholderFieldEnum
    expected_names.append(CallPlaceholderFieldEnum.__name__)
    from google.ads.googleads.v7 import CallTrackingDisplayLocationEnum
    expected_names.append(CallTrackingDisplayLocationEnum.__name__)
    from google.ads.googleads.v7 import CallTypeEnum
    expected_names.append(CallTypeEnum.__name__)
    from google.ads.googleads.v7 import CalloutPlaceholderFieldEnum
    expected_names.append(CalloutPlaceholderFieldEnum.__name__)
    from google.ads.googleads.v7 import CampaignCriterionStatusEnum
    expected_names.append(CampaignCriterionStatusEnum.__name__)
    from google.ads.googleads.v7 import CampaignDraftStatusEnum
    expected_names.append(CampaignDraftStatusEnum.__name__)
    from google.ads.googleads.v7 import CampaignExperimentStatusEnum
    expected_names.append(CampaignExperimentStatusEnum.__name__)
    from google.ads.googleads.v7 import CampaignExperimentTrafficSplitTypeEnum
    expected_names.append(CampaignExperimentTrafficSplitTypeEnum.__name__)
    from google.ads.googleads.v7 import CampaignExperimentTypeEnum
    expected_names.append(CampaignExperimentTypeEnum.__name__)
    from google.ads.googleads.v7 import CampaignServingStatusEnum
    expected_names.append(CampaignServingStatusEnum.__name__)
    from google.ads.googleads.v7 import CampaignSharedSetStatusEnum
    expected_names.append(CampaignSharedSetStatusEnum.__name__)
    from google.ads.googleads.v7 import CampaignStatusEnum
    expected_names.append(CampaignStatusEnum.__name__)
    from google.ads.googleads.v7 import ChangeClientTypeEnum
    expected_names.append(ChangeClientTypeEnum.__name__)
    from google.ads.googleads.v7 import ChangeEventResourceTypeEnum
    expected_names.append(ChangeEventResourceTypeEnum.__name__)
    from google.ads.googleads.v7 import ChangeStatusOperationEnum
    expected_names.append(ChangeStatusOperationEnum.__name__)
    from google.ads.googleads.v7 import ChangeStatusResourceTypeEnum
    expected_names.append(ChangeStatusResourceTypeEnum.__name__)
    from google.ads.googleads.v7 import CombinedAudienceStatusEnum
    expected_names.append(CombinedAudienceStatusEnum.__name__)
    from google.ads.googleads.v7 import ConversionActionCountingTypeEnum
    expected_names.append(ConversionActionCountingTypeEnum.__name__)
    from google.ads.googleads.v7 import ConversionActionStatusEnum
    expected_names.append(ConversionActionStatusEnum.__name__)
    from google.ads.googleads.v7 import ConversionActionTypeEnum
    expected_names.append(ConversionActionTypeEnum.__name__)
    from google.ads.googleads.v7 import ConversionAdjustmentTypeEnum
    expected_names.append(ConversionAdjustmentTypeEnum.__name__)
    from google.ads.googleads.v7 import ConversionCustomVariableStatusEnum
    expected_names.append(ConversionCustomVariableStatusEnum.__name__)
    from google.ads.googleads.v7 import CriterionSystemServingStatusEnum
    expected_names.append(CriterionSystemServingStatusEnum.__name__)
    from google.ads.googleads.v7 import CriterionTypeEnum
    expected_names.append(CriterionTypeEnum.__name__)
    from google.ads.googleads.v7 import CustomAudienceMemberTypeEnum
    expected_names.append(CustomAudienceMemberTypeEnum.__name__)
    from google.ads.googleads.v7 import CustomAudienceStatusEnum
    expected_names.append(CustomAudienceStatusEnum.__name__)
    from google.ads.googleads.v7 import CustomAudienceTypeEnum
    expected_names.append(CustomAudienceTypeEnum.__name__)
    from google.ads.googleads.v7 import CustomInterestMemberTypeEnum
    expected_names.append(CustomInterestMemberTypeEnum.__name__)
    from google.ads.googleads.v7 import CustomInterestStatusEnum
    expected_names.append(CustomInterestStatusEnum.__name__)
    from google.ads.googleads.v7 import CustomInterestTypeEnum
    expected_names.append(CustomInterestTypeEnum.__name__)
    from google.ads.googleads.v7 import CustomPlaceholderFieldEnum
    expected_names.append(CustomPlaceholderFieldEnum.__name__)
    from google.ads.googleads.v7 import CustomerPayPerConversionEligibilityFailureReasonEnum
    expected_names.append(CustomerPayPerConversionEligibilityFailureReasonEnum.__name__)
    from google.ads.googleads.v7 import DataDrivenModelStatusEnum
    expected_names.append(DataDrivenModelStatusEnum.__name__)
    from google.ads.googleads.v7 import DistanceBucketEnum
    expected_names.append(DistanceBucketEnum.__name__)
    from google.ads.googleads.v7 import DsaPageFeedCriterionFieldEnum
    expected_names.append(DsaPageFeedCriterionFieldEnum.__name__)
    from google.ads.googleads.v7 import EducationPlaceholderFieldEnum
    expected_names.append(EducationPlaceholderFieldEnum.__name__)
    from google.ads.googleads.v7 import ExtensionSettingDeviceEnum
    expected_names.append(ExtensionSettingDeviceEnum.__name__)
    from google.ads.googleads.v7 import ExtensionTypeEnum
    expected_names.append(ExtensionTypeEnum.__name__)
    from google.ads.googleads.v7 import FeedAttributeTypeEnum
    expected_names.append(FeedAttributeTypeEnum.__name__)
    from google.ads.googleads.v7 import FeedItemQualityApprovalStatusEnum
    expected_names.append(FeedItemQualityApprovalStatusEnum.__name__)
    from google.ads.googleads.v7 import FeedItemQualityDisapprovalReasonEnum
    expected_names.append(FeedItemQualityDisapprovalReasonEnum.__name__)
    from google.ads.googleads.v7 import FeedItemSetStatusEnum
    expected_names.append(FeedItemSetStatusEnum.__name__)
    from google.ads.googleads.v7 import FeedItemStatusEnum
    expected_names.append(FeedItemStatusEnum.__name__)
    from google.ads.googleads.v7 import FeedItemTargetDeviceEnum
    expected_names.append(FeedItemTargetDeviceEnum.__name__)
    from google.ads.googleads.v7 import FeedItemTargetStatusEnum
    expected_names.append(FeedItemTargetStatusEnum.__name__)
    from google.ads.googleads.v7 import FeedItemTargetTypeEnum
    expected_names.append(FeedItemTargetTypeEnum.__name__)
    from google.ads.googleads.v7 import FeedItemValidationStatusEnum
    expected_names.append(FeedItemValidationStatusEnum.__name__)
    from google.ads.googleads.v7 import FeedLinkStatusEnum
    expected_names.append(FeedLinkStatusEnum.__name__)
    from google.ads.googleads.v7 import FeedMappingCriterionTypeEnum
    expected_names.append(FeedMappingCriterionTypeEnum.__name__)
    from google.ads.googleads.v7 import FeedMappingStatusEnum
    expected_names.append(FeedMappingStatusEnum.__name__)
    from google.ads.googleads.v7 import FeedOriginEnum
    expected_names.append(FeedOriginEnum.__name__)
    from google.ads.googleads.v7 import FeedStatusEnum
    expected_names.append(FeedStatusEnum.__name__)
    from google.ads.googleads.v7 import FlightPlaceholderFieldEnum
    expected_names.append(FlightPlaceholderFieldEnum.__name__)
    from google.ads.googleads.v7 import GeoTargetConstantStatusEnum
    expected_names.append(GeoTargetConstantStatusEnum.__name__)
    from google.ads.googleads.v7 import GeoTargetingRestrictionEnum
    expected_names.append(GeoTargetingRestrictionEnum.__name__)
    from google.ads.googleads.v7 import GeoTargetingTypeEnum
    expected_names.append(GeoTargetingTypeEnum.__name__)
    from google.ads.googleads.v7 import GoogleAdsFieldCategoryEnum
    expected_names.append(GoogleAdsFieldCategoryEnum.__name__)
    from google.ads.googleads.v7 import GoogleAdsFieldDataTypeEnum
    expected_names.append(GoogleAdsFieldDataTypeEnum.__name__)
    from google.ads.googleads.v7 import GoogleVoiceCallStatusEnum
    expected_names.append(GoogleVoiceCallStatusEnum.__name__)
    from google.ads.googleads.v7 import HotelPlaceholderFieldEnum
    expected_names.append(HotelPlaceholderFieldEnum.__name__)
    from google.ads.googleads.v7 import ImagePlaceholderFieldEnum
    expected_names.append(ImagePlaceholderFieldEnum.__name__)
    from google.ads.googleads.v7 import InvoiceTypeEnum
    expected_names.append(InvoiceTypeEnum.__name__)
    from google.ads.googleads.v7 import JobPlaceholderFieldEnum
    expected_names.append(JobPlaceholderFieldEnum.__name__)
    from google.ads.googleads.v7 import KeywordPlanForecastIntervalEnum
    expected_names.append(KeywordPlanForecastIntervalEnum.__name__)
    from google.ads.googleads.v7 import KeywordPlanKeywordAnnotationEnum
    expected_names.append(KeywordPlanKeywordAnnotationEnum.__name__)
    from google.ads.googleads.v7 import KeywordPlanNetworkEnum
    expected_names.append(KeywordPlanNetworkEnum.__name__)
    from google.ads.googleads.v7 import LabelStatusEnum
    expected_names.append(LabelStatusEnum.__name__)
    from google.ads.googleads.v7 import LinkedAccountTypeEnum
    expected_names.append(LinkedAccountTypeEnum.__name__)
    from google.ads.googleads.v7 import LocalPlaceholderFieldEnum
    expected_names.append(LocalPlaceholderFieldEnum.__name__)
    from google.ads.googleads.v7 import LocationExtensionTargetingCriterionFieldEnum
    expected_names.append(LocationExtensionTargetingCriterionFieldEnum.__name__)
    from google.ads.googleads.v7 import LocationPlaceholderFieldEnum
    expected_names.append(LocationPlaceholderFieldEnum.__name__)
    from google.ads.googleads.v7 import LocationSourceTypeEnum
    expected_names.append(LocationSourceTypeEnum.__name__)
    from google.ads.googleads.v7 import ManagerLinkStatusEnum
    expected_names.append(ManagerLinkStatusEnum.__name__)
    from google.ads.googleads.v7 import MediaTypeEnum
    expected_names.append(MediaTypeEnum.__name__)
    from google.ads.googleads.v7 import MerchantCenterLinkStatusEnum
    expected_names.append(MerchantCenterLinkStatusEnum.__name__)
    from google.ads.googleads.v7 import MessagePlaceholderFieldEnum
    expected_names.append(MessagePlaceholderFieldEnum.__name__)
    from google.ads.googleads.v7 import MobileAppVendorEnum
    expected_names.append(MobileAppVendorEnum.__name__)
    from google.ads.googleads.v7 import MobileDeviceTypeEnum
    expected_names.append(MobileDeviceTypeEnum.__name__)
    from google.ads.googleads.v7 import NegativeGeoTargetTypeEnum
    expected_names.append(NegativeGeoTargetTypeEnum.__name__)
    from google.ads.googleads.v7 import OfflineUserDataJobFailureReasonEnum
    expected_names.append(OfflineUserDataJobFailureReasonEnum.__name__)
    from google.ads.googleads.v7 import OfflineUserDataJobStatusEnum
    expected_names.append(OfflineUserDataJobStatusEnum.__name__)
    from google.ads.googleads.v7 import OfflineUserDataJobTypeEnum
    expected_names.append(OfflineUserDataJobTypeEnum.__name__)
    from google.ads.googleads.v7 import OperatingSystemVersionOperatorTypeEnum
    expected_names.append(OperatingSystemVersionOperatorTypeEnum.__name__)
    from google.ads.googleads.v7 import OptimizationGoalTypeEnum
    expected_names.append(OptimizationGoalTypeEnum.__name__)
    from google.ads.googleads.v7 import PaymentModeEnum
    expected_names.append(PaymentModeEnum.__name__)
    from google.ads.googleads.v7 import PlacementTypeEnum
    expected_names.append(PlacementTypeEnum.__name__)
    from google.ads.googleads.v7 import PositiveGeoTargetTypeEnum
    expected_names.append(PositiveGeoTargetTypeEnum.__name__)
    from google.ads.googleads.v7 import PricePlaceholderFieldEnum
    expected_names.append(PricePlaceholderFieldEnum.__name__)
    from google.ads.googleads.v7 import ProductBiddingCategoryStatusEnum
    expected_names.append(ProductBiddingCategoryStatusEnum.__name__)
    from google.ads.googleads.v7 import PromotionPlaceholderFieldEnum
    expected_names.append(PromotionPlaceholderFieldEnum.__name__)
    from google.ads.googleads.v7 import ReachPlanAdLengthEnum
    expected_names.append(ReachPlanAdLengthEnum.__name__)
    from google.ads.googleads.v7 import ReachPlanAgeRangeEnum
    expected_names.append(ReachPlanAgeRangeEnum.__name__)
    from google.ads.googleads.v7 import ReachPlanNetworkEnum
    expected_names.append(ReachPlanNetworkEnum.__name__)
    from google.ads.googleads.v7 import RealEstatePlaceholderFieldEnum
    expected_names.append(RealEstatePlaceholderFieldEnum.__name__)
    from google.ads.googleads.v7 import RecommendationTypeEnum
    expected_names.append(RecommendationTypeEnum.__name__)
    from google.ads.googleads.v7 import ResourceChangeOperationEnum
    expected_names.append(ResourceChangeOperationEnum.__name__)
    from google.ads.googleads.v7 import ResourceLimitTypeEnum
    expected_names.append(ResourceLimitTypeEnum.__name__)
    from google.ads.googleads.v7 import ResponseContentTypeEnum
    expected_names.append(ResponseContentTypeEnum.__name__)
    from google.ads.googleads.v7 import SearchTermTargetingStatusEnum
    expected_names.append(SearchTermTargetingStatusEnum.__name__)
    from google.ads.googleads.v7 import SharedSetStatusEnum
    expected_names.append(SharedSetStatusEnum.__name__)
    from google.ads.googleads.v7 import SharedSetTypeEnum
    expected_names.append(SharedSetTypeEnum.__name__)
    from google.ads.googleads.v7 import SimulationModificationMethodEnum
    expected_names.append(SimulationModificationMethodEnum.__name__)
    from google.ads.googleads.v7 import SimulationTypeEnum
    expected_names.append(SimulationTypeEnum.__name__)
    from google.ads.googleads.v7 import SitelinkPlaceholderFieldEnum
    expected_names.append(SitelinkPlaceholderFieldEnum.__name__)
    from google.ads.googleads.v7 import SpendingLimitTypeEnum
    expected_names.append(SpendingLimitTypeEnum.__name__)
    from google.ads.googleads.v7 import StructuredSnippetPlaceholderFieldEnum
    expected_names.append(StructuredSnippetPlaceholderFieldEnum.__name__)
    from google.ads.googleads.v7 import SummaryRowSettingEnum
    expected_names.append(SummaryRowSettingEnum.__name__)
    from google.ads.googleads.v7 import SystemManagedResourceSourceEnum
    expected_names.append(SystemManagedResourceSourceEnum.__name__)
    from google.ads.googleads.v7 import TargetCpaOptInRecommendationGoalEnum
    expected_names.append(TargetCpaOptInRecommendationGoalEnum.__name__)
    from google.ads.googleads.v7 import TimeTypeEnum
    expected_names.append(TimeTypeEnum.__name__)
    from google.ads.googleads.v7 import TravelPlaceholderFieldEnum
    expected_names.append(TravelPlaceholderFieldEnum.__name__)
    from google.ads.googleads.v7 import UserInterestTaxonomyTypeEnum
    expected_names.append(UserInterestTaxonomyTypeEnum.__name__)
    from google.ads.googleads.v7 import UserListAccessStatusEnum
    expected_names.append(UserListAccessStatusEnum.__name__)
    from google.ads.googleads.v7 import UserListClosingReasonEnum
    expected_names.append(UserListClosingReasonEnum.__name__)
    from google.ads.googleads.v7 import UserListMembershipStatusEnum
    expected_names.append(UserListMembershipStatusEnum.__name__)
    from google.ads.googleads.v7 import UserListSizeRangeEnum
    expected_names.append(UserListSizeRangeEnum.__name__)
    from google.ads.googleads.v7 import UserListTypeEnum
    expected_names.append(UserListTypeEnum.__name__)
    from google.ads.googleads.v7 import VanityPharmaDisplayUrlModeEnum
    expected_names.append(VanityPharmaDisplayUrlModeEnum.__name__)
    from google.ads.googleads.v7 import VanityPharmaTextEnum
    expected_names.append(VanityPharmaTextEnum.__name__)
    from google.ads.googleads.v7 import AccessInvitationErrorEnum
    expected_names.append(AccessInvitationErrorEnum.__name__)
    from google.ads.googleads.v7 import AccountBudgetProposalErrorEnum
    expected_names.append(AccountBudgetProposalErrorEnum.__name__)
    from google.ads.googleads.v7 import AccountLinkErrorEnum
    expected_names.append(AccountLinkErrorEnum.__name__)
    from google.ads.googleads.v7 import AdCustomizerErrorEnum
    expected_names.append(AdCustomizerErrorEnum.__name__)
    from google.ads.googleads.v7 import AdErrorEnum
    expected_names.append(AdErrorEnum.__name__)
    from google.ads.googleads.v7 import AdGroupAdErrorEnum
    expected_names.append(AdGroupAdErrorEnum.__name__)
    from google.ads.googleads.v7 import AdGroupBidModifierErrorEnum
    expected_names.append(AdGroupBidModifierErrorEnum.__name__)
    from google.ads.googleads.v7 import AdGroupCriterionErrorEnum
    expected_names.append(AdGroupCriterionErrorEnum.__name__)
    from google.ads.googleads.v7 import AdGroupErrorEnum
    expected_names.append(AdGroupErrorEnum.__name__)
    from google.ads.googleads.v7 import AdGroupFeedErrorEnum
    expected_names.append(AdGroupFeedErrorEnum.__name__)
    from google.ads.googleads.v7 import AdParameterErrorEnum
    expected_names.append(AdParameterErrorEnum.__name__)
    from google.ads.googleads.v7 import AdSharingErrorEnum
    expected_names.append(AdSharingErrorEnum.__name__)
    from google.ads.googleads.v7 import AdxErrorEnum
    expected_names.append(AdxErrorEnum.__name__)
    from google.ads.googleads.v7 import AssetErrorEnum
    expected_names.append(AssetErrorEnum.__name__)
    from google.ads.googleads.v7 import AssetLinkErrorEnum
    expected_names.append(AssetLinkErrorEnum.__name__)
    from google.ads.googleads.v7 import AuthenticationErrorEnum
    expected_names.append(AuthenticationErrorEnum.__name__)
    from google.ads.googleads.v7 import AuthorizationErrorEnum
    expected_names.append(AuthorizationErrorEnum.__name__)
    from google.ads.googleads.v7 import BatchJobErrorEnum
    expected_names.append(BatchJobErrorEnum.__name__)
    from google.ads.googleads.v7 import BiddingErrorEnum
    expected_names.append(BiddingErrorEnum.__name__)
    from google.ads.googleads.v7 import BiddingStrategyErrorEnum
    expected_names.append(BiddingStrategyErrorEnum.__name__)
    from google.ads.googleads.v7 import BillingSetupErrorEnum
    expected_names.append(BillingSetupErrorEnum.__name__)
    from google.ads.googleads.v7 import CampaignBudgetErrorEnum
    expected_names.append(CampaignBudgetErrorEnum.__name__)
    from google.ads.googleads.v7 import CampaignCriterionErrorEnum
    expected_names.append(CampaignCriterionErrorEnum.__name__)
    from google.ads.googleads.v7 import CampaignDraftErrorEnum
    expected_names.append(CampaignDraftErrorEnum.__name__)
    from google.ads.googleads.v7 import CampaignErrorEnum
    expected_names.append(CampaignErrorEnum.__name__)
    from google.ads.googleads.v7 import CampaignExperimentErrorEnum
    expected_names.append(CampaignExperimentErrorEnum.__name__)
    from google.ads.googleads.v7 import CampaignFeedErrorEnum
    expected_names.append(CampaignFeedErrorEnum.__name__)
    from google.ads.googleads.v7 import CampaignSharedSetErrorEnum
    expected_names.append(CampaignSharedSetErrorEnum.__name__)
    from google.ads.googleads.v7 import ChangeEventErrorEnum
    expected_names.append(ChangeEventErrorEnum.__name__)
    from google.ads.googleads.v7 import ChangeStatusErrorEnum
    expected_names.append(ChangeStatusErrorEnum.__name__)
    from google.ads.googleads.v7 import CollectionSizeErrorEnum
    expected_names.append(CollectionSizeErrorEnum.__name__)
    from google.ads.googleads.v7 import ContextErrorEnum
    expected_names.append(ContextErrorEnum.__name__)
    from google.ads.googleads.v7 import ConversionActionErrorEnum
    expected_names.append(ConversionActionErrorEnum.__name__)
    from google.ads.googleads.v7 import ConversionAdjustmentUploadErrorEnum
    expected_names.append(ConversionAdjustmentUploadErrorEnum.__name__)
    from google.ads.googleads.v7 import ConversionCustomVariableErrorEnum
    expected_names.append(ConversionCustomVariableErrorEnum.__name__)
    from google.ads.googleads.v7 import ConversionUploadErrorEnum
    expected_names.append(ConversionUploadErrorEnum.__name__)
    from google.ads.googleads.v7 import CountryCodeErrorEnum
    expected_names.append(CountryCodeErrorEnum.__name__)
    from google.ads.googleads.v7 import CriterionErrorEnum
    expected_names.append(CriterionErrorEnum.__name__)
    from google.ads.googleads.v7 import CurrencyCodeErrorEnum
    expected_names.append(CurrencyCodeErrorEnum.__name__)
    from google.ads.googleads.v7 import CustomAudienceErrorEnum
    expected_names.append(CustomAudienceErrorEnum.__name__)
    from google.ads.googleads.v7 import CustomInterestErrorEnum
    expected_names.append(CustomInterestErrorEnum.__name__)
    from google.ads.googleads.v7 import CustomerClientLinkErrorEnum
    expected_names.append(CustomerClientLinkErrorEnum.__name__)
    from google.ads.googleads.v7 import CustomerErrorEnum
    expected_names.append(CustomerErrorEnum.__name__)
    from google.ads.googleads.v7 import CustomerFeedErrorEnum
    expected_names.append(CustomerFeedErrorEnum.__name__)
    from google.ads.googleads.v7 import CustomerManagerLinkErrorEnum
    expected_names.append(CustomerManagerLinkErrorEnum.__name__)
    from google.ads.googleads.v7 import CustomerUserAccessErrorEnum
    expected_names.append(CustomerUserAccessErrorEnum.__name__)
    from google.ads.googleads.v7 import DatabaseErrorEnum
    expected_names.append(DatabaseErrorEnum.__name__)
    from google.ads.googleads.v7 import DateErrorEnum
    expected_names.append(DateErrorEnum.__name__)
    from google.ads.googleads.v7 import DateRangeErrorEnum
    expected_names.append(DateRangeErrorEnum.__name__)
    from google.ads.googleads.v7 import DistinctErrorEnum
    expected_names.append(DistinctErrorEnum.__name__)
    from google.ads.googleads.v7 import EnumErrorEnum
    expected_names.append(EnumErrorEnum.__name__)
    from google.ads.googleads.v7 import ExtensionFeedItemErrorEnum
    expected_names.append(ExtensionFeedItemErrorEnum.__name__)
    from google.ads.googleads.v7 import ExtensionSettingErrorEnum
    expected_names.append(ExtensionSettingErrorEnum.__name__)
    from google.ads.googleads.v7 import FeedAttributeReferenceErrorEnum
    expected_names.append(FeedAttributeReferenceErrorEnum.__name__)
    from google.ads.googleads.v7 import FeedErrorEnum
    expected_names.append(FeedErrorEnum.__name__)
    from google.ads.googleads.v7 import FeedItemErrorEnum
    expected_names.append(FeedItemErrorEnum.__name__)
    from google.ads.googleads.v7 import FeedItemSetErrorEnum
    expected_names.append(FeedItemSetErrorEnum.__name__)
    from google.ads.googleads.v7 import FeedItemSetLinkErrorEnum
    expected_names.append(FeedItemSetLinkErrorEnum.__name__)
    from google.ads.googleads.v7 import FeedItemTargetErrorEnum
    expected_names.append(FeedItemTargetErrorEnum.__name__)
    from google.ads.googleads.v7 import FeedItemValidationErrorEnum
    expected_names.append(FeedItemValidationErrorEnum.__name__)
    from google.ads.googleads.v7 import FeedMappingErrorEnum
    expected_names.append(FeedMappingErrorEnum.__name__)
    from google.ads.googleads.v7 import FieldErrorEnum
    expected_names.append(FieldErrorEnum.__name__)
    from google.ads.googleads.v7 import FieldMaskErrorEnum
    expected_names.append(FieldMaskErrorEnum.__name__)
    from google.ads.googleads.v7 import FunctionErrorEnum
    expected_names.append(FunctionErrorEnum.__name__)
    from google.ads.googleads.v7 import FunctionParsingErrorEnum
    expected_names.append(FunctionParsingErrorEnum.__name__)
    from google.ads.googleads.v7 import GeoTargetConstantSuggestionErrorEnum
    expected_names.append(GeoTargetConstantSuggestionErrorEnum.__name__)
    from google.ads.googleads.v7 import HeaderErrorEnum
    expected_names.append(HeaderErrorEnum.__name__)
    from google.ads.googleads.v7 import IdErrorEnum
    expected_names.append(IdErrorEnum.__name__)
    from google.ads.googleads.v7 import ImageErrorEnum
    expected_names.append(ImageErrorEnum.__name__)
    from google.ads.googleads.v7 import InternalErrorEnum
    expected_names.append(InternalErrorEnum.__name__)
    from google.ads.googleads.v7 import InvoiceErrorEnum
    expected_names.append(InvoiceErrorEnum.__name__)
    from google.ads.googleads.v7 import KeywordPlanAdGroupErrorEnum
    expected_names.append(KeywordPlanAdGroupErrorEnum.__name__)
    from google.ads.googleads.v7 import KeywordPlanAdGroupKeywordErrorEnum
    expected_names.append(KeywordPlanAdGroupKeywordErrorEnum.__name__)
    from google.ads.googleads.v7 import KeywordPlanCampaignErrorEnum
    expected_names.append(KeywordPlanCampaignErrorEnum.__name__)
    from google.ads.googleads.v7 import KeywordPlanCampaignKeywordErrorEnum
    expected_names.append(KeywordPlanCampaignKeywordErrorEnum.__name__)
    from google.ads.googleads.v7 import KeywordPlanErrorEnum
    expected_names.append(KeywordPlanErrorEnum.__name__)
    from google.ads.googleads.v7 import KeywordPlanIdeaErrorEnum
    expected_names.append(KeywordPlanIdeaErrorEnum.__name__)
    from google.ads.googleads.v7 import LabelErrorEnum
    expected_names.append(LabelErrorEnum.__name__)
    from google.ads.googleads.v7 import LanguageCodeErrorEnum
    expected_names.append(LanguageCodeErrorEnum.__name__)
    from google.ads.googleads.v7 import ListOperationErrorEnum
    expected_names.append(ListOperationErrorEnum.__name__)
    from google.ads.googleads.v7 import ManagerLinkErrorEnum
    expected_names.append(ManagerLinkErrorEnum.__name__)
    from google.ads.googleads.v7 import MediaBundleErrorEnum
    expected_names.append(MediaBundleErrorEnum.__name__)
    from google.ads.googleads.v7 import MediaFileErrorEnum
    expected_names.append(MediaFileErrorEnum.__name__)
    from google.ads.googleads.v7 import MediaUploadErrorEnum
    expected_names.append(MediaUploadErrorEnum.__name__)
    from google.ads.googleads.v7 import MultiplierErrorEnum
    expected_names.append(MultiplierErrorEnum.__name__)
    from google.ads.googleads.v7 import MutateErrorEnum
    expected_names.append(MutateErrorEnum.__name__)
    from google.ads.googleads.v7 import NewResourceCreationErrorEnum
    expected_names.append(NewResourceCreationErrorEnum.__name__)
    from google.ads.googleads.v7 import NotAllowlistedErrorEnum
    expected_names.append(NotAllowlistedErrorEnum.__name__)
    from google.ads.googleads.v7 import NotEmptyErrorEnum
    expected_names.append(NotEmptyErrorEnum.__name__)
    from google.ads.googleads.v7 import NullErrorEnum
    expected_names.append(NullErrorEnum.__name__)
    from google.ads.googleads.v7 import OfflineUserDataJobErrorEnum
    expected_names.append(OfflineUserDataJobErrorEnum.__name__)
    from google.ads.googleads.v7 import OperationAccessDeniedErrorEnum
    expected_names.append(OperationAccessDeniedErrorEnum.__name__)
    from google.ads.googleads.v7 import OperatorErrorEnum
    expected_names.append(OperatorErrorEnum.__name__)
    from google.ads.googleads.v7 import PartialFailureErrorEnum
    expected_names.append(PartialFailureErrorEnum.__name__)
    from google.ads.googleads.v7 import PaymentsAccountErrorEnum
    expected_names.append(PaymentsAccountErrorEnum.__name__)
    from google.ads.googleads.v7 import PolicyFindingErrorEnum
    expected_names.append(PolicyFindingErrorEnum.__name__)
    from google.ads.googleads.v7 import PolicyValidationParameterErrorEnum
    expected_names.append(PolicyValidationParameterErrorEnum.__name__)
    from google.ads.googleads.v7 import PolicyViolationErrorEnum
    expected_names.append(PolicyViolationErrorEnum.__name__)
    from google.ads.googleads.v7 import QueryErrorEnum
    expected_names.append(QueryErrorEnum.__name__)
    from google.ads.googleads.v7 import QuotaErrorEnum
    expected_names.append(QuotaErrorEnum.__name__)
    from google.ads.googleads.v7 import RangeErrorEnum
    expected_names.append(RangeErrorEnum.__name__)
    from google.ads.googleads.v7 import ReachPlanErrorEnum
    expected_names.append(ReachPlanErrorEnum.__name__)
    from google.ads.googleads.v7 import RecommendationErrorEnum
    expected_names.append(RecommendationErrorEnum.__name__)
    from google.ads.googleads.v7 import RegionCodeErrorEnum
    expected_names.append(RegionCodeErrorEnum.__name__)
    from google.ads.googleads.v7 import RequestErrorEnum
    expected_names.append(RequestErrorEnum.__name__)
    from google.ads.googleads.v7 import ResourceAccessDeniedErrorEnum
    expected_names.append(ResourceAccessDeniedErrorEnum.__name__)
    from google.ads.googleads.v7 import ResourceCountLimitExceededErrorEnum
    expected_names.append(ResourceCountLimitExceededErrorEnum.__name__)
    from google.ads.googleads.v7 import SettingErrorEnum
    expected_names.append(SettingErrorEnum.__name__)
    from google.ads.googleads.v7 import SharedCriterionErrorEnum
    expected_names.append(SharedCriterionErrorEnum.__name__)
    from google.ads.googleads.v7 import SharedSetErrorEnum
    expected_names.append(SharedSetErrorEnum.__name__)
    from google.ads.googleads.v7 import SizeLimitErrorEnum
    expected_names.append(SizeLimitErrorEnum.__name__)
    from google.ads.googleads.v7 import StringFormatErrorEnum
    expected_names.append(StringFormatErrorEnum.__name__)
    from google.ads.googleads.v7 import StringLengthErrorEnum
    expected_names.append(StringLengthErrorEnum.__name__)
    from google.ads.googleads.v7 import ThirdPartyAppAnalyticsLinkErrorEnum
    expected_names.append(ThirdPartyAppAnalyticsLinkErrorEnum.__name__)
    from google.ads.googleads.v7 import TimeZoneErrorEnum
    expected_names.append(TimeZoneErrorEnum.__name__)
    from google.ads.googleads.v7 import UrlFieldErrorEnum
    expected_names.append(UrlFieldErrorEnum.__name__)
    from google.ads.googleads.v7 import UserDataErrorEnum
    expected_names.append(UserDataErrorEnum.__name__)
    from google.ads.googleads.v7 import UserListErrorEnum
    expected_names.append(UserListErrorEnum.__name__)
    from google.ads.googleads.v7 import YoutubeVideoRegistrationErrorEnum
    expected_names.append(YoutubeVideoRegistrationErrorEnum.__name__)
    from google.ads.googleads.v7 import GoogleAdsFailure
    expected_names.append(GoogleAdsFailure.__name__)
    from google.ads.googleads.v7 import GoogleAdsError
    expected_names.append(GoogleAdsError.__name__)
    from google.ads.googleads.v7 import ErrorCode
    expected_names.append(ErrorCode.__name__)
    from google.ads.googleads.v7 import ErrorLocation
    expected_names.append(ErrorLocation.__name__)
    from google.ads.googleads.v7 import ErrorDetails
    expected_names.append(ErrorDetails.__name__)
    from google.ads.googleads.v7 import PolicyViolationDetails
    expected_names.append(PolicyViolationDetails.__name__)
    from google.ads.googleads.v7 import PolicyFindingDetails
    expected_names.append(PolicyFindingDetails.__name__)
    from google.ads.googleads.v7 import QuotaErrorDetails
    expected_names.append(QuotaErrorDetails.__name__)
    from google.ads.googleads.v7 import ResourceCountDetails
    expected_names.append(ResourceCountDetails.__name__)
    from google.ads.googleads.v7 import AccountBudget
    expected_names.append(AccountBudget.__name__)
    from google.ads.googleads.v7 import AccountBudgetProposal
    expected_names.append(AccountBudgetProposal.__name__)
    from google.ads.googleads.v7 import AccountLink
    expected_names.append(AccountLink.__name__)
    from google.ads.googleads.v7 import ThirdPartyAppAnalyticsLinkIdentifier
    expected_names.append(ThirdPartyAppAnalyticsLinkIdentifier.__name__)
    from google.ads.googleads.v7 import DataPartnerLinkIdentifier
    expected_names.append(DataPartnerLinkIdentifier.__name__)
    from google.ads.googleads.v7 import GoogleAdsLinkIdentifier
    expected_names.append(GoogleAdsLinkIdentifier.__name__)
    from google.ads.googleads.v7 import Ad
    expected_names.append(Ad.__name__)
    from google.ads.googleads.v7 import AdGroup
    expected_names.append(AdGroup.__name__)
    from google.ads.googleads.v7 import AdGroupAd
    expected_names.append(AdGroupAd.__name__)
    from google.ads.googleads.v7 import AdGroupAdPolicySummary
    expected_names.append(AdGroupAdPolicySummary.__name__)
    from google.ads.googleads.v7 import AdGroupAdAssetView
    expected_names.append(AdGroupAdAssetView.__name__)
    from google.ads.googleads.v7 import AdGroupAdAssetPolicySummary
    expected_names.append(AdGroupAdAssetPolicySummary.__name__)
    from google.ads.googleads.v7 import AdGroupAdLabel
    expected_names.append(AdGroupAdLabel.__name__)
    from google.ads.googleads.v7 import AdGroupAsset
    expected_names.append(AdGroupAsset.__name__)
    from google.ads.googleads.v7 import AdGroupAudienceView
    expected_names.append(AdGroupAudienceView.__name__)
    from google.ads.googleads.v7 import AdGroupBidModifier
    expected_names.append(AdGroupBidModifier.__name__)
    from google.ads.googleads.v7 import AdGroupCriterion
    expected_names.append(AdGroupCriterion.__name__)
    from google.ads.googleads.v7 import AdGroupCriterionLabel
    expected_names.append(AdGroupCriterionLabel.__name__)
    from google.ads.googleads.v7 import AdGroupCriterionSimulation
    expected_names.append(AdGroupCriterionSimulation.__name__)
    from google.ads.googleads.v7 import AdGroupExtensionSetting
    expected_names.append(AdGroupExtensionSetting.__name__)
    from google.ads.googleads.v7 import AdGroupFeed
    expected_names.append(AdGroupFeed.__name__)
    from google.ads.googleads.v7 import AdGroupLabel
    expected_names.append(AdGroupLabel.__name__)
    from google.ads.googleads.v7 import AdGroupSimulation
    expected_names.append(AdGroupSimulation.__name__)
    from google.ads.googleads.v7 import AdParameter
    expected_names.append(AdParameter.__name__)
    from google.ads.googleads.v7 import AdScheduleView
    expected_names.append(AdScheduleView.__name__)
    from google.ads.googleads.v7 import AgeRangeView
    expected_names.append(AgeRangeView.__name__)
    from google.ads.googleads.v7 import Asset
    expected_names.append(Asset.__name__)
    from google.ads.googleads.v7 import AssetPolicySummary
    expected_names.append(AssetPolicySummary.__name__)
    from google.ads.googleads.v7 import BatchJob
    expected_names.append(BatchJob.__name__)
    from google.ads.googleads.v7 import BiddingStrategy
    expected_names.append(BiddingStrategy.__name__)
    from google.ads.googleads.v7 import BiddingStrategySimulation
    expected_names.append(BiddingStrategySimulation.__name__)
    from google.ads.googleads.v7 import BillingSetup
    expected_names.append(BillingSetup.__name__)
    from google.ads.googleads.v7 import CallView
    expected_names.append(CallView.__name__)
    from google.ads.googleads.v7 import Campaign
    expected_names.append(Campaign.__name__)
    from google.ads.googleads.v7 import CampaignAsset
    expected_names.append(CampaignAsset.__name__)
    from google.ads.googleads.v7 import CampaignAudienceView
    expected_names.append(CampaignAudienceView.__name__)
    from google.ads.googleads.v7 import CampaignBidModifier
    expected_names.append(CampaignBidModifier.__name__)
    from google.ads.googleads.v7 import CampaignBudget
    expected_names.append(CampaignBudget.__name__)
    from google.ads.googleads.v7 import CampaignCriterion
    expected_names.append(CampaignCriterion.__name__)
    from google.ads.googleads.v7 import CampaignCriterionSimulation
    expected_names.append(CampaignCriterionSimulation.__name__)
    from google.ads.googleads.v7 import CampaignDraft
    expected_names.append(CampaignDraft.__name__)
    from google.ads.googleads.v7 import CampaignExperiment
    expected_names.append(CampaignExperiment.__name__)
    from google.ads.googleads.v7 import CampaignExtensionSetting
    expected_names.append(CampaignExtensionSetting.__name__)
    from google.ads.googleads.v7 import CampaignFeed
    expected_names.append(CampaignFeed.__name__)
    from google.ads.googleads.v7 import CampaignLabel
    expected_names.append(CampaignLabel.__name__)
    from google.ads.googleads.v7 import CampaignSharedSet
    expected_names.append(CampaignSharedSet.__name__)
    from google.ads.googleads.v7 import CampaignSimulation
    expected_names.append(CampaignSimulation.__name__)
    from google.ads.googleads.v7 import CarrierConstant
    expected_names.append(CarrierConstant.__name__)
    from google.ads.googleads.v7 import Feed
    expected_names.append(Feed.__name__)
    from google.ads.googleads.v7 import FeedAttribute
    expected_names.append(FeedAttribute.__name__)
    from google.ads.googleads.v7 import FeedAttributeOperation
    expected_names.append(FeedAttributeOperation.__name__)
    from google.ads.googleads.v7 import FeedItem
    expected_names.append(FeedItem.__name__)
    from google.ads.googleads.v7 import FeedItemAttributeValue
    expected_names.append(FeedItemAttributeValue.__name__)
    from google.ads.googleads.v7 import FeedItemPlaceholderPolicyInfo
    expected_names.append(FeedItemPlaceholderPolicyInfo.__name__)
    from google.ads.googleads.v7 import FeedItemValidationError
    expected_names.append(FeedItemValidationError.__name__)
    from google.ads.googleads.v7 import ChangeEvent
    expected_names.append(ChangeEvent.__name__)
    from google.ads.googleads.v7 import ChangeStatus
    expected_names.append(ChangeStatus.__name__)
    from google.ads.googleads.v7 import ClickView
    expected_names.append(ClickView.__name__)
    from google.ads.googleads.v7 import CombinedAudience
    expected_names.append(CombinedAudience.__name__)
    from google.ads.googleads.v7 import ConversionAction
    expected_names.append(ConversionAction.__name__)
    from google.ads.googleads.v7 import ConversionCustomVariable
    expected_names.append(ConversionCustomVariable.__name__)
    from google.ads.googleads.v7 import CurrencyConstant
    expected_names.append(CurrencyConstant.__name__)
    from google.ads.googleads.v7 import CustomAudience
    expected_names.append(CustomAudience.__name__)
    from google.ads.googleads.v7 import CustomAudienceMember
    expected_names.append(CustomAudienceMember.__name__)
    from google.ads.googleads.v7 import CustomInterest
    expected_names.append(CustomInterest.__name__)
    from google.ads.googleads.v7 import CustomInterestMember
    expected_names.append(CustomInterestMember.__name__)
    from google.ads.googleads.v7 import Customer
    expected_names.append(Customer.__name__)
    from google.ads.googleads.v7 import CallReportingSetting
    expected_names.append(CallReportingSetting.__name__)
    from google.ads.googleads.v7 import ConversionTrackingSetting
    expected_names.append(ConversionTrackingSetting.__name__)
    from google.ads.googleads.v7 import RemarketingSetting
    expected_names.append(RemarketingSetting.__name__)
    from google.ads.googleads.v7 import CustomerAsset
    expected_names.append(CustomerAsset.__name__)
    from google.ads.googleads.v7 import CustomerClient
    expected_names.append(CustomerClient.__name__)
    from google.ads.googleads.v7 import CustomerClientLink
    expected_names.append(CustomerClientLink.__name__)
    from google.ads.googleads.v7 import CustomerExtensionSetting
    expected_names.append(CustomerExtensionSetting.__name__)
    from google.ads.googleads.v7 import CustomerFeed
    expected_names.append(CustomerFeed.__name__)
    from google.ads.googleads.v7 import CustomerLabel
    expected_names.append(CustomerLabel.__name__)
    from google.ads.googleads.v7 import CustomerManagerLink
    expected_names.append(CustomerManagerLink.__name__)
    from google.ads.googleads.v7 import CustomerNegativeCriterion
    expected_names.append(CustomerNegativeCriterion.__name__)
    from google.ads.googleads.v7 import CustomerUserAccess
    expected_names.append(CustomerUserAccess.__name__)
    from google.ads.googleads.v7 import CustomerUserAccessInvitation
    expected_names.append(CustomerUserAccessInvitation.__name__)
    from google.ads.googleads.v7 import DetailPlacementView
    expected_names.append(DetailPlacementView.__name__)
    from google.ads.googleads.v7 import DisplayKeywordView
    expected_names.append(DisplayKeywordView.__name__)
    from google.ads.googleads.v7 import DistanceView
    expected_names.append(DistanceView.__name__)
    from google.ads.googleads.v7 import DomainCategory
    expected_names.append(DomainCategory.__name__)
    from google.ads.googleads.v7 import DynamicSearchAdsSearchTermView
    expected_names.append(DynamicSearchAdsSearchTermView.__name__)
    from google.ads.googleads.v7 import ExpandedLandingPageView
    expected_names.append(ExpandedLandingPageView.__name__)
    from google.ads.googleads.v7 import ExtensionFeedItem
    expected_names.append(ExtensionFeedItem.__name__)
    from google.ads.googleads.v7 import FeedItemSet
    expected_names.append(FeedItemSet.__name__)
    from google.ads.googleads.v7 import FeedItemSetLink
    expected_names.append(FeedItemSetLink.__name__)
    from google.ads.googleads.v7 import FeedItemTarget
    expected_names.append(FeedItemTarget.__name__)
    from google.ads.googleads.v7 import FeedMapping
    expected_names.append(FeedMapping.__name__)
    from google.ads.googleads.v7 import AttributeFieldMapping
    expected_names.append(AttributeFieldMapping.__name__)
    from google.ads.googleads.v7 import FeedPlaceholderView
    expected_names.append(FeedPlaceholderView.__name__)
    from google.ads.googleads.v7 import GenderView
    expected_names.append(GenderView.__name__)
    from google.ads.googleads.v7 import GeoTargetConstant
    expected_names.append(GeoTargetConstant.__name__)
    from google.ads.googleads.v7 import GeographicView
    expected_names.append(GeographicView.__name__)
    from google.ads.googleads.v7 import GoogleAdsField
    expected_names.append(GoogleAdsField.__name__)
    from google.ads.googleads.v7 import GroupPlacementView
    expected_names.append(GroupPlacementView.__name__)
    from google.ads.googleads.v7 import HotelGroupView
    expected_names.append(HotelGroupView.__name__)
    from google.ads.googleads.v7 import HotelPerformanceView
    expected_names.append(HotelPerformanceView.__name__)
    from google.ads.googleads.v7 import IncomeRangeView
    expected_names.append(IncomeRangeView.__name__)
    from google.ads.googleads.v7 import Invoice
    expected_names.append(Invoice.__name__)
    from google.ads.googleads.v7 import KeywordPlan
    expected_names.append(KeywordPlan.__name__)
    from google.ads.googleads.v7 import KeywordPlanForecastPeriod
    expected_names.append(KeywordPlanForecastPeriod.__name__)
    from google.ads.googleads.v7 import KeywordPlanAdGroup
    expected_names.append(KeywordPlanAdGroup.__name__)
    from google.ads.googleads.v7 import KeywordPlanAdGroupKeyword
    expected_names.append(KeywordPlanAdGroupKeyword.__name__)
    from google.ads.googleads.v7 import KeywordPlanCampaign
    expected_names.append(KeywordPlanCampaign.__name__)
    from google.ads.googleads.v7 import KeywordPlanGeoTarget
    expected_names.append(KeywordPlanGeoTarget.__name__)
    from google.ads.googleads.v7 import KeywordPlanCampaignKeyword
    expected_names.append(KeywordPlanCampaignKeyword.__name__)
    from google.ads.googleads.v7 import KeywordView
    expected_names.append(KeywordView.__name__)
    from google.ads.googleads.v7 import Label
    expected_names.append(Label.__name__)
    from google.ads.googleads.v7 import LandingPageView
    expected_names.append(LandingPageView.__name__)
    from google.ads.googleads.v7 import LanguageConstant
    expected_names.append(LanguageConstant.__name__)
    from google.ads.googleads.v7 import LifeEvent
    expected_names.append(LifeEvent.__name__)
    from google.ads.googleads.v7 import LocationView
    expected_names.append(LocationView.__name__)
    from google.ads.googleads.v7 import ManagedPlacementView
    expected_names.append(ManagedPlacementView.__name__)
    from google.ads.googleads.v7 import MediaFile
    expected_names.append(MediaFile.__name__)
    from google.ads.googleads.v7 import MediaImage
    expected_names.append(MediaImage.__name__)
    from google.ads.googleads.v7 import MediaBundle
    expected_names.append(MediaBundle.__name__)
    from google.ads.googleads.v7 import MediaAudio
    expected_names.append(MediaAudio.__name__)
    from google.ads.googleads.v7 import MediaVideo
    expected_names.append(MediaVideo.__name__)
    from google.ads.googleads.v7 import MerchantCenterLink
    expected_names.append(MerchantCenterLink.__name__)
    from google.ads.googleads.v7 import MobileAppCategoryConstant
    expected_names.append(MobileAppCategoryConstant.__name__)
    from google.ads.googleads.v7 import MobileDeviceConstant
    expected_names.append(MobileDeviceConstant.__name__)
    from google.ads.googleads.v7 import OfflineUserDataJob
    expected_names.append(OfflineUserDataJob.__name__)
    from google.ads.googleads.v7 import OperatingSystemVersionConstant
    expected_names.append(OperatingSystemVersionConstant.__name__)
    from google.ads.googleads.v7 import PaidOrganicSearchTermView
    expected_names.append(PaidOrganicSearchTermView.__name__)
    from google.ads.googleads.v7 import ParentalStatusView
    expected_names.append(ParentalStatusView.__name__)
    from google.ads.googleads.v7 import PaymentsAccount
    expected_names.append(PaymentsAccount.__name__)
    from google.ads.googleads.v7 import ProductBiddingCategoryConstant
    expected_names.append(ProductBiddingCategoryConstant.__name__)
    from google.ads.googleads.v7 import ProductGroupView
    expected_names.append(ProductGroupView.__name__)
    from google.ads.googleads.v7 import Recommendation
    expected_names.append(Recommendation.__name__)
    from google.ads.googleads.v7 import RemarketingAction
    expected_names.append(RemarketingAction.__name__)
    from google.ads.googleads.v7 import SearchTermView
    expected_names.append(SearchTermView.__name__)
    from google.ads.googleads.v7 import SharedCriterion
    expected_names.append(SharedCriterion.__name__)
    from google.ads.googleads.v7 import SharedSet
    expected_names.append(SharedSet.__name__)
    from google.ads.googleads.v7 import ShoppingPerformanceView
    expected_names.append(ShoppingPerformanceView.__name__)
    from google.ads.googleads.v7 import ThirdPartyAppAnalyticsLink
    expected_names.append(ThirdPartyAppAnalyticsLink.__name__)
    from google.ads.googleads.v7 import TopicConstant
    expected_names.append(TopicConstant.__name__)
    from google.ads.googleads.v7 import TopicView
    expected_names.append(TopicView.__name__)
    from google.ads.googleads.v7 import UserInterest
    expected_names.append(UserInterest.__name__)
    from google.ads.googleads.v7 import UserList
    expected_names.append(UserList.__name__)
    from google.ads.googleads.v7 import UserLocationView
    expected_names.append(UserLocationView.__name__)
    from google.ads.googleads.v7 import Video
    expected_names.append(Video.__name__)
    from google.ads.googleads.v7 import WebpageView
    expected_names.append(WebpageView.__name__)
    from google.ads.googleads.v7 import GetAccountBudgetProposalRequest
    expected_names.append(GetAccountBudgetProposalRequest.__name__)
    from google.ads.googleads.v7 import MutateAccountBudgetProposalRequest
    expected_names.append(MutateAccountBudgetProposalRequest.__name__)
    from google.ads.googleads.v7 import AccountBudgetProposalOperation
    expected_names.append(AccountBudgetProposalOperation.__name__)
    from google.ads.googleads.v7 import MutateAccountBudgetProposalResponse
    expected_names.append(MutateAccountBudgetProposalResponse.__name__)
    from google.ads.googleads.v7 import MutateAccountBudgetProposalResult
    expected_names.append(MutateAccountBudgetProposalResult.__name__)
    from google.ads.googleads.v7 import GetAccountBudgetRequest
    expected_names.append(GetAccountBudgetRequest.__name__)
    from google.ads.googleads.v7 import GetAccountLinkRequest
    expected_names.append(GetAccountLinkRequest.__name__)
    from google.ads.googleads.v7 import CreateAccountLinkRequest
    expected_names.append(CreateAccountLinkRequest.__name__)
    from google.ads.googleads.v7 import CreateAccountLinkResponse
    expected_names.append(CreateAccountLinkResponse.__name__)
    from google.ads.googleads.v7 import MutateAccountLinkRequest
    expected_names.append(MutateAccountLinkRequest.__name__)
    from google.ads.googleads.v7 import AccountLinkOperation
    expected_names.append(AccountLinkOperation.__name__)
    from google.ads.googleads.v7 import MutateAccountLinkResponse
    expected_names.append(MutateAccountLinkResponse.__name__)
    from google.ads.googleads.v7 import MutateAccountLinkResult
    expected_names.append(MutateAccountLinkResult.__name__)
    from google.ads.googleads.v7 import GetAdGroupAdAssetViewRequest
    expected_names.append(GetAdGroupAdAssetViewRequest.__name__)
    from google.ads.googleads.v7 import GetAdGroupAdLabelRequest
    expected_names.append(GetAdGroupAdLabelRequest.__name__)
    from google.ads.googleads.v7 import MutateAdGroupAdLabelsRequest
    expected_names.append(MutateAdGroupAdLabelsRequest.__name__)
    from google.ads.googleads.v7 import AdGroupAdLabelOperation
    expected_names.append(AdGroupAdLabelOperation.__name__)
    from google.ads.googleads.v7 import MutateAdGroupAdLabelsResponse
    expected_names.append(MutateAdGroupAdLabelsResponse.__name__)
    from google.ads.googleads.v7 import MutateAdGroupAdLabelResult
    expected_names.append(MutateAdGroupAdLabelResult.__name__)
    from google.ads.googleads.v7 import GetAdGroupAdRequest
    expected_names.append(GetAdGroupAdRequest.__name__)
    from google.ads.googleads.v7 import MutateAdGroupAdsRequest
    expected_names.append(MutateAdGroupAdsRequest.__name__)
    from google.ads.googleads.v7 import AdGroupAdOperation
    expected_names.append(AdGroupAdOperation.__name__)
    from google.ads.googleads.v7 import MutateAdGroupAdsResponse
    expected_names.append(MutateAdGroupAdsResponse.__name__)
    from google.ads.googleads.v7 import MutateAdGroupAdResult
    expected_names.append(MutateAdGroupAdResult.__name__)
    from google.ads.googleads.v7 import GetAdGroupAssetRequest
    expected_names.append(GetAdGroupAssetRequest.__name__)
    from google.ads.googleads.v7 import MutateAdGroupAssetsRequest
    expected_names.append(MutateAdGroupAssetsRequest.__name__)
    from google.ads.googleads.v7 import AdGroupAssetOperation
    expected_names.append(AdGroupAssetOperation.__name__)
    from google.ads.googleads.v7 import MutateAdGroupAssetsResponse
    expected_names.append(MutateAdGroupAssetsResponse.__name__)
    from google.ads.googleads.v7 import MutateAdGroupAssetResult
    expected_names.append(MutateAdGroupAssetResult.__name__)
    from google.ads.googleads.v7 import GetAdGroupAudienceViewRequest
    expected_names.append(GetAdGroupAudienceViewRequest.__name__)
    from google.ads.googleads.v7 import GetAdGroupBidModifierRequest
    expected_names.append(GetAdGroupBidModifierRequest.__name__)
    from google.ads.googleads.v7 import MutateAdGroupBidModifiersRequest
    expected_names.append(MutateAdGroupBidModifiersRequest.__name__)
    from google.ads.googleads.v7 import AdGroupBidModifierOperation
    expected_names.append(AdGroupBidModifierOperation.__name__)
    from google.ads.googleads.v7 import MutateAdGroupBidModifiersResponse
    expected_names.append(MutateAdGroupBidModifiersResponse.__name__)
    from google.ads.googleads.v7 import MutateAdGroupBidModifierResult
    expected_names.append(MutateAdGroupBidModifierResult.__name__)
    from google.ads.googleads.v7 import GetAdGroupCriterionLabelRequest
    expected_names.append(GetAdGroupCriterionLabelRequest.__name__)
    from google.ads.googleads.v7 import MutateAdGroupCriterionLabelsRequest
    expected_names.append(MutateAdGroupCriterionLabelsRequest.__name__)
    from google.ads.googleads.v7 import AdGroupCriterionLabelOperation
    expected_names.append(AdGroupCriterionLabelOperation.__name__)
    from google.ads.googleads.v7 import MutateAdGroupCriterionLabelsResponse
    expected_names.append(MutateAdGroupCriterionLabelsResponse.__name__)
    from google.ads.googleads.v7 import MutateAdGroupCriterionLabelResult
    expected_names.append(MutateAdGroupCriterionLabelResult.__name__)
    from google.ads.googleads.v7 import GetAdGroupCriterionRequest
    expected_names.append(GetAdGroupCriterionRequest.__name__)
    from google.ads.googleads.v7 import MutateAdGroupCriteriaRequest
    expected_names.append(MutateAdGroupCriteriaRequest.__name__)
    from google.ads.googleads.v7 import AdGroupCriterionOperation
    expected_names.append(AdGroupCriterionOperation.__name__)
    from google.ads.googleads.v7 import MutateAdGroupCriteriaResponse
    expected_names.append(MutateAdGroupCriteriaResponse.__name__)
    from google.ads.googleads.v7 import MutateAdGroupCriterionResult
    expected_names.append(MutateAdGroupCriterionResult.__name__)
    from google.ads.googleads.v7 import GetAdGroupCriterionSimulationRequest
    expected_names.append(GetAdGroupCriterionSimulationRequest.__name__)
    from google.ads.googleads.v7 import GetAdGroupExtensionSettingRequest
    expected_names.append(GetAdGroupExtensionSettingRequest.__name__)
    from google.ads.googleads.v7 import MutateAdGroupExtensionSettingsRequest
    expected_names.append(MutateAdGroupExtensionSettingsRequest.__name__)
    from google.ads.googleads.v7 import AdGroupExtensionSettingOperation
    expected_names.append(AdGroupExtensionSettingOperation.__name__)
    from google.ads.googleads.v7 import MutateAdGroupExtensionSettingsResponse
    expected_names.append(MutateAdGroupExtensionSettingsResponse.__name__)
    from google.ads.googleads.v7 import MutateAdGroupExtensionSettingResult
    expected_names.append(MutateAdGroupExtensionSettingResult.__name__)
    from google.ads.googleads.v7 import GetAdGroupFeedRequest
    expected_names.append(GetAdGroupFeedRequest.__name__)
    from google.ads.googleads.v7 import MutateAdGroupFeedsRequest
    expected_names.append(MutateAdGroupFeedsRequest.__name__)
    from google.ads.googleads.v7 import AdGroupFeedOperation
    expected_names.append(AdGroupFeedOperation.__name__)
    from google.ads.googleads.v7 import MutateAdGroupFeedsResponse
    expected_names.append(MutateAdGroupFeedsResponse.__name__)
    from google.ads.googleads.v7 import MutateAdGroupFeedResult
    expected_names.append(MutateAdGroupFeedResult.__name__)
    from google.ads.googleads.v7 import GetAdGroupLabelRequest
    expected_names.append(GetAdGroupLabelRequest.__name__)
    from google.ads.googleads.v7 import MutateAdGroupLabelsRequest
    expected_names.append(MutateAdGroupLabelsRequest.__name__)
    from google.ads.googleads.v7 import AdGroupLabelOperation
    expected_names.append(AdGroupLabelOperation.__name__)
    from google.ads.googleads.v7 import MutateAdGroupLabelsResponse
    expected_names.append(MutateAdGroupLabelsResponse.__name__)
    from google.ads.googleads.v7 import MutateAdGroupLabelResult
    expected_names.append(MutateAdGroupLabelResult.__name__)
    from google.ads.googleads.v7 import GetAdGroupRequest
    expected_names.append(GetAdGroupRequest.__name__)
    from google.ads.googleads.v7 import MutateAdGroupsRequest
    expected_names.append(MutateAdGroupsRequest.__name__)
    from google.ads.googleads.v7 import AdGroupOperation
    expected_names.append(AdGroupOperation.__name__)
    from google.ads.googleads.v7 import MutateAdGroupsResponse
    expected_names.append(MutateAdGroupsResponse.__name__)
    from google.ads.googleads.v7 import MutateAdGroupResult
    expected_names.append(MutateAdGroupResult.__name__)
    from google.ads.googleads.v7 import GetAdGroupSimulationRequest
    expected_names.append(GetAdGroupSimulationRequest.__name__)
    from google.ads.googleads.v7 import GetAdParameterRequest
    expected_names.append(GetAdParameterRequest.__name__)
    from google.ads.googleads.v7 import MutateAdParametersRequest
    expected_names.append(MutateAdParametersRequest.__name__)
    from google.ads.googleads.v7 import AdParameterOperation
    expected_names.append(AdParameterOperation.__name__)
    from google.ads.googleads.v7 import MutateAdParametersResponse
    expected_names.append(MutateAdParametersResponse.__name__)
    from google.ads.googleads.v7 import MutateAdParameterResult
    expected_names.append(MutateAdParameterResult.__name__)
    from google.ads.googleads.v7 import GetAdScheduleViewRequest
    expected_names.append(GetAdScheduleViewRequest.__name__)
    from google.ads.googleads.v7 import GetAdRequest
    expected_names.append(GetAdRequest.__name__)
    from google.ads.googleads.v7 import MutateAdsRequest
    expected_names.append(MutateAdsRequest.__name__)
    from google.ads.googleads.v7 import AdOperation
    expected_names.append(AdOperation.__name__)
    from google.ads.googleads.v7 import MutateAdsResponse
    expected_names.append(MutateAdsResponse.__name__)
    from google.ads.googleads.v7 import MutateAdResult
    expected_names.append(MutateAdResult.__name__)
    from google.ads.googleads.v7 import GetAgeRangeViewRequest
    expected_names.append(GetAgeRangeViewRequest.__name__)
    from google.ads.googleads.v7 import GetAssetRequest
    expected_names.append(GetAssetRequest.__name__)
    from google.ads.googleads.v7 import MutateAssetsRequest
    expected_names.append(MutateAssetsRequest.__name__)
    from google.ads.googleads.v7 import AssetOperation
    expected_names.append(AssetOperation.__name__)
    from google.ads.googleads.v7 import MutateAssetsResponse
    expected_names.append(MutateAssetsResponse.__name__)
    from google.ads.googleads.v7 import MutateAssetResult
    expected_names.append(MutateAssetResult.__name__)
    from google.ads.googleads.v7 import GetBiddingStrategyRequest
    expected_names.append(GetBiddingStrategyRequest.__name__)
    from google.ads.googleads.v7 import MutateBiddingStrategiesRequest
    expected_names.append(MutateBiddingStrategiesRequest.__name__)
    from google.ads.googleads.v7 import BiddingStrategyOperation
    expected_names.append(BiddingStrategyOperation.__name__)
    from google.ads.googleads.v7 import MutateBiddingStrategiesResponse
    expected_names.append(MutateBiddingStrategiesResponse.__name__)
    from google.ads.googleads.v7 import MutateBiddingStrategyResult
    expected_names.append(MutateBiddingStrategyResult.__name__)
    from google.ads.googleads.v7 import GetCampaignAssetRequest
    expected_names.append(GetCampaignAssetRequest.__name__)
    from google.ads.googleads.v7 import MutateCampaignAssetsRequest
    expected_names.append(MutateCampaignAssetsRequest.__name__)
    from google.ads.googleads.v7 import CampaignAssetOperation
    expected_names.append(CampaignAssetOperation.__name__)
    from google.ads.googleads.v7 import MutateCampaignAssetsResponse
    expected_names.append(MutateCampaignAssetsResponse.__name__)
    from google.ads.googleads.v7 import MutateCampaignAssetResult
    expected_names.append(MutateCampaignAssetResult.__name__)
    from google.ads.googleads.v7 import GetCampaignBidModifierRequest
    expected_names.append(GetCampaignBidModifierRequest.__name__)
    from google.ads.googleads.v7 import MutateCampaignBidModifiersRequest
    expected_names.append(MutateCampaignBidModifiersRequest.__name__)
    from google.ads.googleads.v7 import CampaignBidModifierOperation
    expected_names.append(CampaignBidModifierOperation.__name__)
    from google.ads.googleads.v7 import MutateCampaignBidModifiersResponse
    expected_names.append(MutateCampaignBidModifiersResponse.__name__)
    from google.ads.googleads.v7 import MutateCampaignBidModifierResult
    expected_names.append(MutateCampaignBidModifierResult.__name__)
    from google.ads.googleads.v7 import GetCampaignBudgetRequest
    expected_names.append(GetCampaignBudgetRequest.__name__)
    from google.ads.googleads.v7 import MutateCampaignBudgetsRequest
    expected_names.append(MutateCampaignBudgetsRequest.__name__)
    from google.ads.googleads.v7 import CampaignBudgetOperation
    expected_names.append(CampaignBudgetOperation.__name__)
    from google.ads.googleads.v7 import MutateCampaignBudgetsResponse
    expected_names.append(MutateCampaignBudgetsResponse.__name__)
    from google.ads.googleads.v7 import MutateCampaignBudgetResult
    expected_names.append(MutateCampaignBudgetResult.__name__)
    from google.ads.googleads.v7 import GetCampaignCriterionRequest
    expected_names.append(GetCampaignCriterionRequest.__name__)
    from google.ads.googleads.v7 import MutateCampaignCriteriaRequest
    expected_names.append(MutateCampaignCriteriaRequest.__name__)
    from google.ads.googleads.v7 import CampaignCriterionOperation
    expected_names.append(CampaignCriterionOperation.__name__)
    from google.ads.googleads.v7 import MutateCampaignCriteriaResponse
    expected_names.append(MutateCampaignCriteriaResponse.__name__)
    from google.ads.googleads.v7 import MutateCampaignCriterionResult
    expected_names.append(MutateCampaignCriterionResult.__name__)
    from google.ads.googleads.v7 import GetCampaignDraftRequest
    expected_names.append(GetCampaignDraftRequest.__name__)
    from google.ads.googleads.v7 import MutateCampaignDraftsRequest
    expected_names.append(MutateCampaignDraftsRequest.__name__)
    from google.ads.googleads.v7 import PromoteCampaignDraftRequest
    expected_names.append(PromoteCampaignDraftRequest.__name__)
    from google.ads.googleads.v7 import CampaignDraftOperation
    expected_names.append(CampaignDraftOperation.__name__)
    from google.ads.googleads.v7 import MutateCampaignDraftsResponse
    expected_names.append(MutateCampaignDraftsResponse.__name__)
    from google.ads.googleads.v7 import MutateCampaignDraftResult
    expected_names.append(MutateCampaignDraftResult.__name__)
    from google.ads.googleads.v7 import ListCampaignDraftAsyncErrorsRequest
    expected_names.append(ListCampaignDraftAsyncErrorsRequest.__name__)
    from google.ads.googleads.v7 import ListCampaignDraftAsyncErrorsResponse
    expected_names.append(ListCampaignDraftAsyncErrorsResponse.__name__)
    from google.ads.googleads.v7 import GetCampaignExperimentRequest
    expected_names.append(GetCampaignExperimentRequest.__name__)
    from google.ads.googleads.v7 import MutateCampaignExperimentsRequest
    expected_names.append(MutateCampaignExperimentsRequest.__name__)
    from google.ads.googleads.v7 import CampaignExperimentOperation
    expected_names.append(CampaignExperimentOperation.__name__)
    from google.ads.googleads.v7 import MutateCampaignExperimentsResponse
    expected_names.append(MutateCampaignExperimentsResponse.__name__)
    from google.ads.googleads.v7 import MutateCampaignExperimentResult
    expected_names.append(MutateCampaignExperimentResult.__name__)
    from google.ads.googleads.v7 import CreateCampaignExperimentRequest
    expected_names.append(CreateCampaignExperimentRequest.__name__)
    from google.ads.googleads.v7 import CreateCampaignExperimentMetadata
    expected_names.append(CreateCampaignExperimentMetadata.__name__)
    from google.ads.googleads.v7 import GraduateCampaignExperimentRequest
    expected_names.append(GraduateCampaignExperimentRequest.__name__)
    from google.ads.googleads.v7 import GraduateCampaignExperimentResponse
    expected_names.append(GraduateCampaignExperimentResponse.__name__)
    from google.ads.googleads.v7 import PromoteCampaignExperimentRequest
    expected_names.append(PromoteCampaignExperimentRequest.__name__)
    from google.ads.googleads.v7 import EndCampaignExperimentRequest
    expected_names.append(EndCampaignExperimentRequest.__name__)
    from google.ads.googleads.v7 import ListCampaignExperimentAsyncErrorsRequest
    expected_names.append(ListCampaignExperimentAsyncErrorsRequest.__name__)
    from google.ads.googleads.v7 import ListCampaignExperimentAsyncErrorsResponse
    expected_names.append(ListCampaignExperimentAsyncErrorsResponse.__name__)
    from google.ads.googleads.v7 import GetCampaignExtensionSettingRequest
    expected_names.append(GetCampaignExtensionSettingRequest.__name__)
    from google.ads.googleads.v7 import MutateCampaignExtensionSettingsRequest
    expected_names.append(MutateCampaignExtensionSettingsRequest.__name__)
    from google.ads.googleads.v7 import CampaignExtensionSettingOperation
    expected_names.append(CampaignExtensionSettingOperation.__name__)
    from google.ads.googleads.v7 import MutateCampaignExtensionSettingsResponse
    expected_names.append(MutateCampaignExtensionSettingsResponse.__name__)
    from google.ads.googleads.v7 import MutateCampaignExtensionSettingResult
    expected_names.append(MutateCampaignExtensionSettingResult.__name__)
    from google.ads.googleads.v7 import GetCampaignFeedRequest
    expected_names.append(GetCampaignFeedRequest.__name__)
    from google.ads.googleads.v7 import MutateCampaignFeedsRequest
    expected_names.append(MutateCampaignFeedsRequest.__name__)
    from google.ads.googleads.v7 import CampaignFeedOperation
    expected_names.append(CampaignFeedOperation.__name__)
    from google.ads.googleads.v7 import MutateCampaignFeedsResponse
    expected_names.append(MutateCampaignFeedsResponse.__name__)
    from google.ads.googleads.v7 import MutateCampaignFeedResult
    expected_names.append(MutateCampaignFeedResult.__name__)
    from google.ads.googleads.v7 import GetCampaignLabelRequest
    expected_names.append(GetCampaignLabelRequest.__name__)
    from google.ads.googleads.v7 import MutateCampaignLabelsRequest
    expected_names.append(MutateCampaignLabelsRequest.__name__)
    from google.ads.googleads.v7 import CampaignLabelOperation
    expected_names.append(CampaignLabelOperation.__name__)
    from google.ads.googleads.v7 import MutateCampaignLabelsResponse
    expected_names.append(MutateCampaignLabelsResponse.__name__)
    from google.ads.googleads.v7 import MutateCampaignLabelResult
    expected_names.append(MutateCampaignLabelResult.__name__)
    from google.ads.googleads.v7 import GetCampaignRequest
    expected_names.append(GetCampaignRequest.__name__)
    from google.ads.googleads.v7 import MutateCampaignsRequest
    expected_names.append(MutateCampaignsRequest.__name__)
    from google.ads.googleads.v7 import CampaignOperation
    expected_names.append(CampaignOperation.__name__)
    from google.ads.googleads.v7 import MutateCampaignsResponse
    expected_names.append(MutateCampaignsResponse.__name__)
    from google.ads.googleads.v7 import MutateCampaignResult
    expected_names.append(MutateCampaignResult.__name__)
    from google.ads.googleads.v7 import GetCampaignSharedSetRequest
    expected_names.append(GetCampaignSharedSetRequest.__name__)
    from google.ads.googleads.v7 import MutateCampaignSharedSetsRequest
    expected_names.append(MutateCampaignSharedSetsRequest.__name__)
    from google.ads.googleads.v7 import CampaignSharedSetOperation
    expected_names.append(CampaignSharedSetOperation.__name__)
    from google.ads.googleads.v7 import MutateCampaignSharedSetsResponse
    expected_names.append(MutateCampaignSharedSetsResponse.__name__)
    from google.ads.googleads.v7 import MutateCampaignSharedSetResult
    expected_names.append(MutateCampaignSharedSetResult.__name__)
    from google.ads.googleads.v7 import GetConversionActionRequest
    expected_names.append(GetConversionActionRequest.__name__)
    from google.ads.googleads.v7 import MutateConversionActionsRequest
    expected_names.append(MutateConversionActionsRequest.__name__)
    from google.ads.googleads.v7 import ConversionActionOperation
    expected_names.append(ConversionActionOperation.__name__)
    from google.ads.googleads.v7 import MutateConversionActionsResponse
    expected_names.append(MutateConversionActionsResponse.__name__)
    from google.ads.googleads.v7 import MutateConversionActionResult
    expected_names.append(MutateConversionActionResult.__name__)
    from google.ads.googleads.v7 import GetConversionCustomVariableRequest
    expected_names.append(GetConversionCustomVariableRequest.__name__)
    from google.ads.googleads.v7 import MutateConversionCustomVariablesRequest
    expected_names.append(MutateConversionCustomVariablesRequest.__name__)
    from google.ads.googleads.v7 import ConversionCustomVariableOperation
    expected_names.append(ConversionCustomVariableOperation.__name__)
    from google.ads.googleads.v7 import MutateConversionCustomVariablesResponse
    expected_names.append(MutateConversionCustomVariablesResponse.__name__)
    from google.ads.googleads.v7 import MutateConversionCustomVariableResult
    expected_names.append(MutateConversionCustomVariableResult.__name__)
    from google.ads.googleads.v7 import GetCustomerAssetRequest
    expected_names.append(GetCustomerAssetRequest.__name__)
    from google.ads.googleads.v7 import MutateCustomerAssetsRequest
    expected_names.append(MutateCustomerAssetsRequest.__name__)
    from google.ads.googleads.v7 import CustomerAssetOperation
    expected_names.append(CustomerAssetOperation.__name__)
    from google.ads.googleads.v7 import MutateCustomerAssetsResponse
    expected_names.append(MutateCustomerAssetsResponse.__name__)
    from google.ads.googleads.v7 import MutateCustomerAssetResult
    expected_names.append(MutateCustomerAssetResult.__name__)
    from google.ads.googleads.v7 import GetCustomerExtensionSettingRequest
    expected_names.append(GetCustomerExtensionSettingRequest.__name__)
    from google.ads.googleads.v7 import MutateCustomerExtensionSettingsRequest
    expected_names.append(MutateCustomerExtensionSettingsRequest.__name__)
    from google.ads.googleads.v7 import CustomerExtensionSettingOperation
    expected_names.append(CustomerExtensionSettingOperation.__name__)
    from google.ads.googleads.v7 import MutateCustomerExtensionSettingsResponse
    expected_names.append(MutateCustomerExtensionSettingsResponse.__name__)
    from google.ads.googleads.v7 import MutateCustomerExtensionSettingResult
    expected_names.append(MutateCustomerExtensionSettingResult.__name__)
    from google.ads.googleads.v7 import GetCustomerFeedRequest
    expected_names.append(GetCustomerFeedRequest.__name__)
    from google.ads.googleads.v7 import MutateCustomerFeedsRequest
    expected_names.append(MutateCustomerFeedsRequest.__name__)
    from google.ads.googleads.v7 import CustomerFeedOperation
    expected_names.append(CustomerFeedOperation.__name__)
    from google.ads.googleads.v7 import MutateCustomerFeedsResponse
    expected_names.append(MutateCustomerFeedsResponse.__name__)
    from google.ads.googleads.v7 import MutateCustomerFeedResult
    expected_names.append(MutateCustomerFeedResult.__name__)
    from google.ads.googleads.v7 import GetCustomerLabelRequest
    expected_names.append(GetCustomerLabelRequest.__name__)
    from google.ads.googleads.v7 import MutateCustomerLabelsRequest
    expected_names.append(MutateCustomerLabelsRequest.__name__)
    from google.ads.googleads.v7 import CustomerLabelOperation
    expected_names.append(CustomerLabelOperation.__name__)
    from google.ads.googleads.v7 import MutateCustomerLabelsResponse
    expected_names.append(MutateCustomerLabelsResponse.__name__)
    from google.ads.googleads.v7 import MutateCustomerLabelResult
    expected_names.append(MutateCustomerLabelResult.__name__)
    from google.ads.googleads.v7 import GetCustomerNegativeCriterionRequest
    expected_names.append(GetCustomerNegativeCriterionRequest.__name__)
    from google.ads.googleads.v7 import MutateCustomerNegativeCriteriaRequest
    expected_names.append(MutateCustomerNegativeCriteriaRequest.__name__)
    from google.ads.googleads.v7 import CustomerNegativeCriterionOperation
    expected_names.append(CustomerNegativeCriterionOperation.__name__)
    from google.ads.googleads.v7 import MutateCustomerNegativeCriteriaResponse
    expected_names.append(MutateCustomerNegativeCriteriaResponse.__name__)
    from google.ads.googleads.v7 import MutateCustomerNegativeCriteriaResult
    expected_names.append(MutateCustomerNegativeCriteriaResult.__name__)
    from google.ads.googleads.v7 import GetCustomerRequest
    expected_names.append(GetCustomerRequest.__name__)
    from google.ads.googleads.v7 import MutateCustomerRequest
    expected_names.append(MutateCustomerRequest.__name__)
    from google.ads.googleads.v7 import CreateCustomerClientRequest
    expected_names.append(CreateCustomerClientRequest.__name__)
    from google.ads.googleads.v7 import CustomerOperation
    expected_names.append(CustomerOperation.__name__)
    from google.ads.googleads.v7 import CreateCustomerClientResponse
    expected_names.append(CreateCustomerClientResponse.__name__)
    from google.ads.googleads.v7 import MutateCustomerResponse
    expected_names.append(MutateCustomerResponse.__name__)
    from google.ads.googleads.v7 import MutateCustomerResult
    expected_names.append(MutateCustomerResult.__name__)
    from google.ads.googleads.v7 import ListAccessibleCustomersRequest
    expected_names.append(ListAccessibleCustomersRequest.__name__)
    from google.ads.googleads.v7 import ListAccessibleCustomersResponse
    expected_names.append(ListAccessibleCustomersResponse.__name__)
    from google.ads.googleads.v7 import GetExtensionFeedItemRequest
    expected_names.append(GetExtensionFeedItemRequest.__name__)
    from google.ads.googleads.v7 import MutateExtensionFeedItemsRequest
    expected_names.append(MutateExtensionFeedItemsRequest.__name__)
    from google.ads.googleads.v7 import ExtensionFeedItemOperation
    expected_names.append(ExtensionFeedItemOperation.__name__)
    from google.ads.googleads.v7 import MutateExtensionFeedItemsResponse
    expected_names.append(MutateExtensionFeedItemsResponse.__name__)
    from google.ads.googleads.v7 import MutateExtensionFeedItemResult
    expected_names.append(MutateExtensionFeedItemResult.__name__)
    from google.ads.googleads.v7 import GetFeedItemRequest
    expected_names.append(GetFeedItemRequest.__name__)
    from google.ads.googleads.v7 import MutateFeedItemsRequest
    expected_names.append(MutateFeedItemsRequest.__name__)
    from google.ads.googleads.v7 import FeedItemOperation
    expected_names.append(FeedItemOperation.__name__)
    from google.ads.googleads.v7 import MutateFeedItemsResponse
    expected_names.append(MutateFeedItemsResponse.__name__)
    from google.ads.googleads.v7 import MutateFeedItemResult
    expected_names.append(MutateFeedItemResult.__name__)
    from google.ads.googleads.v7 import GetFeedItemSetLinkRequest
    expected_names.append(GetFeedItemSetLinkRequest.__name__)
    from google.ads.googleads.v7 import MutateFeedItemSetLinksRequest
    expected_names.append(MutateFeedItemSetLinksRequest.__name__)
    from google.ads.googleads.v7 import FeedItemSetLinkOperation
    expected_names.append(FeedItemSetLinkOperation.__name__)
    from google.ads.googleads.v7 import MutateFeedItemSetLinksResponse
    expected_names.append(MutateFeedItemSetLinksResponse.__name__)
    from google.ads.googleads.v7 import MutateFeedItemSetLinkResult
    expected_names.append(MutateFeedItemSetLinkResult.__name__)
    from google.ads.googleads.v7 import GetFeedItemSetRequest
    expected_names.append(GetFeedItemSetRequest.__name__)
    from google.ads.googleads.v7 import MutateFeedItemSetsRequest
    expected_names.append(MutateFeedItemSetsRequest.__name__)
    from google.ads.googleads.v7 import FeedItemSetOperation
    expected_names.append(FeedItemSetOperation.__name__)
    from google.ads.googleads.v7 import MutateFeedItemSetsResponse
    expected_names.append(MutateFeedItemSetsResponse.__name__)
    from google.ads.googleads.v7 import MutateFeedItemSetResult
    expected_names.append(MutateFeedItemSetResult.__name__)
    from google.ads.googleads.v7 import GetFeedItemTargetRequest
    expected_names.append(GetFeedItemTargetRequest.__name__)
    from google.ads.googleads.v7 import MutateFeedItemTargetsRequest
    expected_names.append(MutateFeedItemTargetsRequest.__name__)
    from google.ads.googleads.v7 import FeedItemTargetOperation
    expected_names.append(FeedItemTargetOperation.__name__)
    from google.ads.googleads.v7 import MutateFeedItemTargetsResponse
    expected_names.append(MutateFeedItemTargetsResponse.__name__)
    from google.ads.googleads.v7 import MutateFeedItemTargetResult
    expected_names.append(MutateFeedItemTargetResult.__name__)
    from google.ads.googleads.v7 import GetFeedMappingRequest
    expected_names.append(GetFeedMappingRequest.__name__)
    from google.ads.googleads.v7 import MutateFeedMappingsRequest
    expected_names.append(MutateFeedMappingsRequest.__name__)
    from google.ads.googleads.v7 import FeedMappingOperation
    expected_names.append(FeedMappingOperation.__name__)
    from google.ads.googleads.v7 import MutateFeedMappingsResponse
    expected_names.append(MutateFeedMappingsResponse.__name__)
    from google.ads.googleads.v7 import MutateFeedMappingResult
    expected_names.append(MutateFeedMappingResult.__name__)
    from google.ads.googleads.v7 import GetFeedRequest
    expected_names.append(GetFeedRequest.__name__)
    from google.ads.googleads.v7 import MutateFeedsRequest
    expected_names.append(MutateFeedsRequest.__name__)
    from google.ads.googleads.v7 import FeedOperation
    expected_names.append(FeedOperation.__name__)
    from google.ads.googleads.v7 import MutateFeedsResponse
    expected_names.append(MutateFeedsResponse.__name__)
    from google.ads.googleads.v7 import MutateFeedResult
    expected_names.append(MutateFeedResult.__name__)
    from google.ads.googleads.v7 import GetKeywordPlanAdGroupKeywordRequest
    expected_names.append(GetKeywordPlanAdGroupKeywordRequest.__name__)
    from google.ads.googleads.v7 import MutateKeywordPlanAdGroupKeywordsRequest
    expected_names.append(MutateKeywordPlanAdGroupKeywordsRequest.__name__)
    from google.ads.googleads.v7 import KeywordPlanAdGroupKeywordOperation
    expected_names.append(KeywordPlanAdGroupKeywordOperation.__name__)
    from google.ads.googleads.v7 import MutateKeywordPlanAdGroupKeywordsResponse
    expected_names.append(MutateKeywordPlanAdGroupKeywordsResponse.__name__)
    from google.ads.googleads.v7 import MutateKeywordPlanAdGroupKeywordResult
    expected_names.append(MutateKeywordPlanAdGroupKeywordResult.__name__)
    from google.ads.googleads.v7 import GetKeywordPlanAdGroupRequest
    expected_names.append(GetKeywordPlanAdGroupRequest.__name__)
    from google.ads.googleads.v7 import MutateKeywordPlanAdGroupsRequest
    expected_names.append(MutateKeywordPlanAdGroupsRequest.__name__)
    from google.ads.googleads.v7 import KeywordPlanAdGroupOperation
    expected_names.append(KeywordPlanAdGroupOperation.__name__)
    from google.ads.googleads.v7 import MutateKeywordPlanAdGroupsResponse
    expected_names.append(MutateKeywordPlanAdGroupsResponse.__name__)
    from google.ads.googleads.v7 import MutateKeywordPlanAdGroupResult
    expected_names.append(MutateKeywordPlanAdGroupResult.__name__)
    from google.ads.googleads.v7 import GetKeywordPlanCampaignKeywordRequest
    expected_names.append(GetKeywordPlanCampaignKeywordRequest.__name__)
    from google.ads.googleads.v7 import MutateKeywordPlanCampaignKeywordsRequest
    expected_names.append(MutateKeywordPlanCampaignKeywordsRequest.__name__)
    from google.ads.googleads.v7 import KeywordPlanCampaignKeywordOperation
    expected_names.append(KeywordPlanCampaignKeywordOperation.__name__)
    from google.ads.googleads.v7 import MutateKeywordPlanCampaignKeywordsResponse
    expected_names.append(MutateKeywordPlanCampaignKeywordsResponse.__name__)
    from google.ads.googleads.v7 import MutateKeywordPlanCampaignKeywordResult
    expected_names.append(MutateKeywordPlanCampaignKeywordResult.__name__)
    from google.ads.googleads.v7 import GetKeywordPlanCampaignRequest
    expected_names.append(GetKeywordPlanCampaignRequest.__name__)
    from google.ads.googleads.v7 import MutateKeywordPlanCampaignsRequest
    expected_names.append(MutateKeywordPlanCampaignsRequest.__name__)
    from google.ads.googleads.v7 import KeywordPlanCampaignOperation
    expected_names.append(KeywordPlanCampaignOperation.__name__)
    from google.ads.googleads.v7 import MutateKeywordPlanCampaignsResponse
    expected_names.append(MutateKeywordPlanCampaignsResponse.__name__)
    from google.ads.googleads.v7 import MutateKeywordPlanCampaignResult
    expected_names.append(MutateKeywordPlanCampaignResult.__name__)
    from google.ads.googleads.v7 import GetKeywordPlanRequest
    expected_names.append(GetKeywordPlanRequest.__name__)
    from google.ads.googleads.v7 import MutateKeywordPlansRequest
    expected_names.append(MutateKeywordPlansRequest.__name__)
    from google.ads.googleads.v7 import KeywordPlanOperation
    expected_names.append(KeywordPlanOperation.__name__)
    from google.ads.googleads.v7 import MutateKeywordPlansResponse
    expected_names.append(MutateKeywordPlansResponse.__name__)
    from google.ads.googleads.v7 import MutateKeywordPlansResult
    expected_names.append(MutateKeywordPlansResult.__name__)
    from google.ads.googleads.v7 import GenerateForecastCurveRequest
    expected_names.append(GenerateForecastCurveRequest.__name__)
    from google.ads.googleads.v7 import GenerateForecastCurveResponse
    expected_names.append(GenerateForecastCurveResponse.__name__)
    from google.ads.googleads.v7 import GenerateForecastTimeSeriesRequest
    expected_names.append(GenerateForecastTimeSeriesRequest.__name__)
    from google.ads.googleads.v7 import GenerateForecastTimeSeriesResponse
    expected_names.append(GenerateForecastTimeSeriesResponse.__name__)
    from google.ads.googleads.v7 import GenerateForecastMetricsRequest
    expected_names.append(GenerateForecastMetricsRequest.__name__)
    from google.ads.googleads.v7 import GenerateForecastMetricsResponse
    expected_names.append(GenerateForecastMetricsResponse.__name__)
    from google.ads.googleads.v7 import KeywordPlanCampaignForecast
    expected_names.append(KeywordPlanCampaignForecast.__name__)
    from google.ads.googleads.v7 import KeywordPlanAdGroupForecast
    expected_names.append(KeywordPlanAdGroupForecast.__name__)
    from google.ads.googleads.v7 import KeywordPlanKeywordForecast
    expected_names.append(KeywordPlanKeywordForecast.__name__)
    from google.ads.googleads.v7 import KeywordPlanCampaignForecastCurve
    expected_names.append(KeywordPlanCampaignForecastCurve.__name__)
    from google.ads.googleads.v7 import KeywordPlanMaxCpcBidForecastCurve
    expected_names.append(KeywordPlanMaxCpcBidForecastCurve.__name__)
    from google.ads.googleads.v7 import KeywordPlanMaxCpcBidForecast
    expected_names.append(KeywordPlanMaxCpcBidForecast.__name__)
    from google.ads.googleads.v7 import KeywordPlanWeeklyTimeSeriesForecast
    expected_names.append(KeywordPlanWeeklyTimeSeriesForecast.__name__)
    from google.ads.googleads.v7 import KeywordPlanWeeklyForecast
    expected_names.append(KeywordPlanWeeklyForecast.__name__)
    from google.ads.googleads.v7 import ForecastMetrics
    expected_names.append(ForecastMetrics.__name__)
    from google.ads.googleads.v7 import GenerateHistoricalMetricsRequest
    expected_names.append(GenerateHistoricalMetricsRequest.__name__)
    from google.ads.googleads.v7 import GenerateHistoricalMetricsResponse
    expected_names.append(GenerateHistoricalMetricsResponse.__name__)
    from google.ads.googleads.v7 import KeywordPlanKeywordHistoricalMetrics
    expected_names.append(KeywordPlanKeywordHistoricalMetrics.__name__)
    from google.ads.googleads.v7 import GetLabelRequest
    expected_names.append(GetLabelRequest.__name__)
    from google.ads.googleads.v7 import MutateLabelsRequest
    expected_names.append(MutateLabelsRequest.__name__)
    from google.ads.googleads.v7 import LabelOperation
    expected_names.append(LabelOperation.__name__)
    from google.ads.googleads.v7 import MutateLabelsResponse
    expected_names.append(MutateLabelsResponse.__name__)
    from google.ads.googleads.v7 import MutateLabelResult
    expected_names.append(MutateLabelResult.__name__)
    from google.ads.googleads.v7 import GetMediaFileRequest
    expected_names.append(GetMediaFileRequest.__name__)
    from google.ads.googleads.v7 import MutateMediaFilesRequest
    expected_names.append(MutateMediaFilesRequest.__name__)
    from google.ads.googleads.v7 import MediaFileOperation
    expected_names.append(MediaFileOperation.__name__)
    from google.ads.googleads.v7 import MutateMediaFilesResponse
    expected_names.append(MutateMediaFilesResponse.__name__)
    from google.ads.googleads.v7 import MutateMediaFileResult
    expected_names.append(MutateMediaFileResult.__name__)
    from google.ads.googleads.v7 import GetRemarketingActionRequest
    expected_names.append(GetRemarketingActionRequest.__name__)
    from google.ads.googleads.v7 import MutateRemarketingActionsRequest
    expected_names.append(MutateRemarketingActionsRequest.__name__)
    from google.ads.googleads.v7 import RemarketingActionOperation
    expected_names.append(RemarketingActionOperation.__name__)
    from google.ads.googleads.v7 import MutateRemarketingActionsResponse
    expected_names.append(MutateRemarketingActionsResponse.__name__)
    from google.ads.googleads.v7 import MutateRemarketingActionResult
    expected_names.append(MutateRemarketingActionResult.__name__)
    from google.ads.googleads.v7 import GetSharedCriterionRequest
    expected_names.append(GetSharedCriterionRequest.__name__)
    from google.ads.googleads.v7 import MutateSharedCriteriaRequest
    expected_names.append(MutateSharedCriteriaRequest.__name__)
    from google.ads.googleads.v7 import SharedCriterionOperation
    expected_names.append(SharedCriterionOperation.__name__)
    from google.ads.googleads.v7 import MutateSharedCriteriaResponse
    expected_names.append(MutateSharedCriteriaResponse.__name__)
    from google.ads.googleads.v7 import MutateSharedCriterionResult
    expected_names.append(MutateSharedCriterionResult.__name__)
    from google.ads.googleads.v7 import GetSharedSetRequest
    expected_names.append(GetSharedSetRequest.__name__)
    from google.ads.googleads.v7 import MutateSharedSetsRequest
    expected_names.append(MutateSharedSetsRequest.__name__)
    from google.ads.googleads.v7 import SharedSetOperation
    expected_names.append(SharedSetOperation.__name__)
    from google.ads.googleads.v7 import MutateSharedSetsResponse
    expected_names.append(MutateSharedSetsResponse.__name__)
    from google.ads.googleads.v7 import MutateSharedSetResult
    expected_names.append(MutateSharedSetResult.__name__)
    from google.ads.googleads.v7 import GetUserListRequest
    expected_names.append(GetUserListRequest.__name__)
    from google.ads.googleads.v7 import MutateUserListsRequest
    expected_names.append(MutateUserListsRequest.__name__)
    from google.ads.googleads.v7 import UserListOperation
    expected_names.append(UserListOperation.__name__)
    from google.ads.googleads.v7 import MutateUserListsResponse
    expected_names.append(MutateUserListsResponse.__name__)
    from google.ads.googleads.v7 import MutateUserListResult
    expected_names.append(MutateUserListResult.__name__)
    from google.ads.googleads.v7 import SearchGoogleAdsRequest
    expected_names.append(SearchGoogleAdsRequest.__name__)
    from google.ads.googleads.v7 import SearchGoogleAdsResponse
    expected_names.append(SearchGoogleAdsResponse.__name__)
    from google.ads.googleads.v7 import SearchGoogleAdsStreamRequest
    expected_names.append(SearchGoogleAdsStreamRequest.__name__)
    from google.ads.googleads.v7 import SearchGoogleAdsStreamResponse
    expected_names.append(SearchGoogleAdsStreamResponse.__name__)
    from google.ads.googleads.v7 import GoogleAdsRow
    expected_names.append(GoogleAdsRow.__name__)
    from google.ads.googleads.v7 import MutateGoogleAdsRequest
    expected_names.append(MutateGoogleAdsRequest.__name__)
    from google.ads.googleads.v7 import MutateGoogleAdsResponse
    expected_names.append(MutateGoogleAdsResponse.__name__)
    from google.ads.googleads.v7 import MutateOperation
    expected_names.append(MutateOperation.__name__)
    from google.ads.googleads.v7 import MutateOperationResponse
    expected_names.append(MutateOperationResponse.__name__)
    from google.ads.googleads.v7 import MutateBatchJobRequest
    expected_names.append(MutateBatchJobRequest.__name__)
    from google.ads.googleads.v7 import BatchJobOperation
    expected_names.append(BatchJobOperation.__name__)
    from google.ads.googleads.v7 import MutateBatchJobResponse
    expected_names.append(MutateBatchJobResponse.__name__)
    from google.ads.googleads.v7 import MutateBatchJobResult
    expected_names.append(MutateBatchJobResult.__name__)
    from google.ads.googleads.v7 import GetBatchJobRequest
    expected_names.append(GetBatchJobRequest.__name__)
    from google.ads.googleads.v7 import RunBatchJobRequest
    expected_names.append(RunBatchJobRequest.__name__)
    from google.ads.googleads.v7 import AddBatchJobOperationsRequest
    expected_names.append(AddBatchJobOperationsRequest.__name__)
    from google.ads.googleads.v7 import AddBatchJobOperationsResponse
    expected_names.append(AddBatchJobOperationsResponse.__name__)
    from google.ads.googleads.v7 import ListBatchJobResultsRequest
    expected_names.append(ListBatchJobResultsRequest.__name__)
    from google.ads.googleads.v7 import ListBatchJobResultsResponse
    expected_names.append(ListBatchJobResultsResponse.__name__)
    from google.ads.googleads.v7 import BatchJobResult
    expected_names.append(BatchJobResult.__name__)
    from google.ads.googleads.v7 import GetBiddingStrategySimulationRequest
    expected_names.append(GetBiddingStrategySimulationRequest.__name__)
    from google.ads.googleads.v7 import GetBillingSetupRequest
    expected_names.append(GetBillingSetupRequest.__name__)
    from google.ads.googleads.v7 import MutateBillingSetupRequest
    expected_names.append(MutateBillingSetupRequest.__name__)
    from google.ads.googleads.v7 import BillingSetupOperation
    expected_names.append(BillingSetupOperation.__name__)
    from google.ads.googleads.v7 import MutateBillingSetupResponse
    expected_names.append(MutateBillingSetupResponse.__name__)
    from google.ads.googleads.v7 import MutateBillingSetupResult
    expected_names.append(MutateBillingSetupResult.__name__)
    from google.ads.googleads.v7 import GetCampaignAudienceViewRequest
    expected_names.append(GetCampaignAudienceViewRequest.__name__)
    from google.ads.googleads.v7 import GetCampaignCriterionSimulationRequest
    expected_names.append(GetCampaignCriterionSimulationRequest.__name__)
    from google.ads.googleads.v7 import GetCampaignSimulationRequest
    expected_names.append(GetCampaignSimulationRequest.__name__)
    from google.ads.googleads.v7 import GetCarrierConstantRequest
    expected_names.append(GetCarrierConstantRequest.__name__)
    from google.ads.googleads.v7 import GetChangeStatusRequest
    expected_names.append(GetChangeStatusRequest.__name__)
    from google.ads.googleads.v7 import GetClickViewRequest
    expected_names.append(GetClickViewRequest.__name__)
    from google.ads.googleads.v7 import GetCombinedAudienceRequest
    expected_names.append(GetCombinedAudienceRequest.__name__)
    from google.ads.googleads.v7 import UploadConversionAdjustmentsRequest
    expected_names.append(UploadConversionAdjustmentsRequest.__name__)
    from google.ads.googleads.v7 import UploadConversionAdjustmentsResponse
    expected_names.append(UploadConversionAdjustmentsResponse.__name__)
    from google.ads.googleads.v7 import ConversionAdjustment
    expected_names.append(ConversionAdjustment.__name__)
    from google.ads.googleads.v7 import RestatementValue
    expected_names.append(RestatementValue.__name__)
    from google.ads.googleads.v7 import GclidDateTimePair
    expected_names.append(GclidDateTimePair.__name__)
    from google.ads.googleads.v7 import ConversionAdjustmentResult
    expected_names.append(ConversionAdjustmentResult.__name__)
    from google.ads.googleads.v7 import UploadClickConversionsRequest
    expected_names.append(UploadClickConversionsRequest.__name__)
    from google.ads.googleads.v7 import UploadClickConversionsResponse
    expected_names.append(UploadClickConversionsResponse.__name__)
    from google.ads.googleads.v7 import UploadCallConversionsRequest
    expected_names.append(UploadCallConversionsRequest.__name__)
    from google.ads.googleads.v7 import UploadCallConversionsResponse
    expected_names.append(UploadCallConversionsResponse.__name__)
    from google.ads.googleads.v7 import ClickConversion
    expected_names.append(ClickConversion.__name__)
    from google.ads.googleads.v7 import CallConversion
    expected_names.append(CallConversion.__name__)
    from google.ads.googleads.v7 import ExternalAttributionData
    expected_names.append(ExternalAttributionData.__name__)
    from google.ads.googleads.v7 import ClickConversionResult
    expected_names.append(ClickConversionResult.__name__)
    from google.ads.googleads.v7 import CallConversionResult
    expected_names.append(CallConversionResult.__name__)
    from google.ads.googleads.v7 import CustomVariable
    expected_names.append(CustomVariable.__name__)
    from google.ads.googleads.v7 import GetCurrencyConstantRequest
    expected_names.append(GetCurrencyConstantRequest.__name__)
    from google.ads.googleads.v7 import GetCustomAudienceRequest
    expected_names.append(GetCustomAudienceRequest.__name__)
    from google.ads.googleads.v7 import MutateCustomAudiencesRequest
    expected_names.append(MutateCustomAudiencesRequest.__name__)
    from google.ads.googleads.v7 import CustomAudienceOperation
    expected_names.append(CustomAudienceOperation.__name__)
    from google.ads.googleads.v7 import MutateCustomAudiencesResponse
    expected_names.append(MutateCustomAudiencesResponse.__name__)
    from google.ads.googleads.v7 import MutateCustomAudienceResult
    expected_names.append(MutateCustomAudienceResult.__name__)
    from google.ads.googleads.v7 import GetCustomInterestRequest
    expected_names.append(GetCustomInterestRequest.__name__)
    from google.ads.googleads.v7 import MutateCustomInterestsRequest
    expected_names.append(MutateCustomInterestsRequest.__name__)
    from google.ads.googleads.v7 import CustomInterestOperation
    expected_names.append(CustomInterestOperation.__name__)
    from google.ads.googleads.v7 import MutateCustomInterestsResponse
    expected_names.append(MutateCustomInterestsResponse.__name__)
    from google.ads.googleads.v7 import MutateCustomInterestResult
    expected_names.append(MutateCustomInterestResult.__name__)
    from google.ads.googleads.v7 import GetCustomerClientLinkRequest
    expected_names.append(GetCustomerClientLinkRequest.__name__)
    from google.ads.googleads.v7 import MutateCustomerClientLinkRequest
    expected_names.append(MutateCustomerClientLinkRequest.__name__)
    from google.ads.googleads.v7 import CustomerClientLinkOperation
    expected_names.append(CustomerClientLinkOperation.__name__)
    from google.ads.googleads.v7 import MutateCustomerClientLinkResponse
    expected_names.append(MutateCustomerClientLinkResponse.__name__)
    from google.ads.googleads.v7 import MutateCustomerClientLinkResult
    expected_names.append(MutateCustomerClientLinkResult.__name__)
    from google.ads.googleads.v7 import GetCustomerClientRequest
    expected_names.append(GetCustomerClientRequest.__name__)
    from google.ads.googleads.v7 import GetCustomerManagerLinkRequest
    expected_names.append(GetCustomerManagerLinkRequest.__name__)
    from google.ads.googleads.v7 import MutateCustomerManagerLinkRequest
    expected_names.append(MutateCustomerManagerLinkRequest.__name__)
    from google.ads.googleads.v7 import MoveManagerLinkRequest
    expected_names.append(MoveManagerLinkRequest.__name__)
    from google.ads.googleads.v7 import CustomerManagerLinkOperation
    expected_names.append(CustomerManagerLinkOperation.__name__)
    from google.ads.googleads.v7 import MutateCustomerManagerLinkResponse
    expected_names.append(MutateCustomerManagerLinkResponse.__name__)
    from google.ads.googleads.v7 import MoveManagerLinkResponse
    expected_names.append(MoveManagerLinkResponse.__name__)
    from google.ads.googleads.v7 import MutateCustomerManagerLinkResult
    expected_names.append(MutateCustomerManagerLinkResult.__name__)
    from google.ads.googleads.v7 import GetCustomerUserAccessInvitationRequest
    expected_names.append(GetCustomerUserAccessInvitationRequest.__name__)
    from google.ads.googleads.v7 import MutateCustomerUserAccessInvitationRequest
    expected_names.append(MutateCustomerUserAccessInvitationRequest.__name__)
    from google.ads.googleads.v7 import CustomerUserAccessInvitationOperation
    expected_names.append(CustomerUserAccessInvitationOperation.__name__)
    from google.ads.googleads.v7 import MutateCustomerUserAccessInvitationResponse
    expected_names.append(MutateCustomerUserAccessInvitationResponse.__name__)
    from google.ads.googleads.v7 import MutateCustomerUserAccessInvitationResult
    expected_names.append(MutateCustomerUserAccessInvitationResult.__name__)
    from google.ads.googleads.v7 import GetCustomerUserAccessRequest
    expected_names.append(GetCustomerUserAccessRequest.__name__)
    from google.ads.googleads.v7 import MutateCustomerUserAccessRequest
    expected_names.append(MutateCustomerUserAccessRequest.__name__)
    from google.ads.googleads.v7 import CustomerUserAccessOperation
    expected_names.append(CustomerUserAccessOperation.__name__)
    from google.ads.googleads.v7 import MutateCustomerUserAccessResponse
    expected_names.append(MutateCustomerUserAccessResponse.__name__)
    from google.ads.googleads.v7 import MutateCustomerUserAccessResult
    expected_names.append(MutateCustomerUserAccessResult.__name__)
    from google.ads.googleads.v7 import GetDetailPlacementViewRequest
    expected_names.append(GetDetailPlacementViewRequest.__name__)
    from google.ads.googleads.v7 import GetDisplayKeywordViewRequest
    expected_names.append(GetDisplayKeywordViewRequest.__name__)
    from google.ads.googleads.v7 import GetDistanceViewRequest
    expected_names.append(GetDistanceViewRequest.__name__)
    from google.ads.googleads.v7 import GetDomainCategoryRequest
    expected_names.append(GetDomainCategoryRequest.__name__)
    from google.ads.googleads.v7 import GetDynamicSearchAdsSearchTermViewRequest
    expected_names.append(GetDynamicSearchAdsSearchTermViewRequest.__name__)
    from google.ads.googleads.v7 import GetExpandedLandingPageViewRequest
    expected_names.append(GetExpandedLandingPageViewRequest.__name__)
    from google.ads.googleads.v7 import GetFeedPlaceholderViewRequest
    expected_names.append(GetFeedPlaceholderViewRequest.__name__)
    from google.ads.googleads.v7 import GetGenderViewRequest
    expected_names.append(GetGenderViewRequest.__name__)
    from google.ads.googleads.v7 import GetGeoTargetConstantRequest
    expected_names.append(GetGeoTargetConstantRequest.__name__)
    from google.ads.googleads.v7 import SuggestGeoTargetConstantsRequest
    expected_names.append(SuggestGeoTargetConstantsRequest.__name__)
    from google.ads.googleads.v7 import SuggestGeoTargetConstantsResponse
    expected_names.append(SuggestGeoTargetConstantsResponse.__name__)
    from google.ads.googleads.v7 import GeoTargetConstantSuggestion
    expected_names.append(GeoTargetConstantSuggestion.__name__)
    from google.ads.googleads.v7 import GetGeographicViewRequest
    expected_names.append(GetGeographicViewRequest.__name__)
    from google.ads.googleads.v7 import GetGoogleAdsFieldRequest
    expected_names.append(GetGoogleAdsFieldRequest.__name__)
    from google.ads.googleads.v7 import SearchGoogleAdsFieldsRequest
    expected_names.append(SearchGoogleAdsFieldsRequest.__name__)
    from google.ads.googleads.v7 import SearchGoogleAdsFieldsResponse
    expected_names.append(SearchGoogleAdsFieldsResponse.__name__)
    from google.ads.googleads.v7 import GetGroupPlacementViewRequest
    expected_names.append(GetGroupPlacementViewRequest.__name__)
    from google.ads.googleads.v7 import GetHotelGroupViewRequest
    expected_names.append(GetHotelGroupViewRequest.__name__)
    from google.ads.googleads.v7 import GetHotelPerformanceViewRequest
    expected_names.append(GetHotelPerformanceViewRequest.__name__)
    from google.ads.googleads.v7 import GetIncomeRangeViewRequest
    expected_names.append(GetIncomeRangeViewRequest.__name__)
    from google.ads.googleads.v7 import ListInvoicesRequest
    expected_names.append(ListInvoicesRequest.__name__)
    from google.ads.googleads.v7 import ListInvoicesResponse
    expected_names.append(ListInvoicesResponse.__name__)
    from google.ads.googleads.v7 import GenerateKeywordIdeasRequest
    expected_names.append(GenerateKeywordIdeasRequest.__name__)
    from google.ads.googleads.v7 import KeywordAndUrlSeed
    expected_names.append(KeywordAndUrlSeed.__name__)
    from google.ads.googleads.v7 import KeywordSeed
    expected_names.append(KeywordSeed.__name__)
    from google.ads.googleads.v7 import SiteSeed
    expected_names.append(SiteSeed.__name__)
    from google.ads.googleads.v7 import UrlSeed
    expected_names.append(UrlSeed.__name__)
    from google.ads.googleads.v7 import GenerateKeywordIdeaResponse
    expected_names.append(GenerateKeywordIdeaResponse.__name__)
    from google.ads.googleads.v7 import GenerateKeywordIdeaResult
    expected_names.append(GenerateKeywordIdeaResult.__name__)
    from google.ads.googleads.v7 import GetKeywordViewRequest
    expected_names.append(GetKeywordViewRequest.__name__)
    from google.ads.googleads.v7 import GetLandingPageViewRequest
    expected_names.append(GetLandingPageViewRequest.__name__)
    from google.ads.googleads.v7 import GetLanguageConstantRequest
    expected_names.append(GetLanguageConstantRequest.__name__)
    from google.ads.googleads.v7 import GetLifeEventRequest
    expected_names.append(GetLifeEventRequest.__name__)
    from google.ads.googleads.v7 import GetLocationViewRequest
    expected_names.append(GetLocationViewRequest.__name__)
    from google.ads.googleads.v7 import GetManagedPlacementViewRequest
    expected_names.append(GetManagedPlacementViewRequest.__name__)
    from google.ads.googleads.v7 import ListMerchantCenterLinksRequest
    expected_names.append(ListMerchantCenterLinksRequest.__name__)
    from google.ads.googleads.v7 import ListMerchantCenterLinksResponse
    expected_names.append(ListMerchantCenterLinksResponse.__name__)
    from google.ads.googleads.v7 import GetMerchantCenterLinkRequest
    expected_names.append(GetMerchantCenterLinkRequest.__name__)
    from google.ads.googleads.v7 import MutateMerchantCenterLinkRequest
    expected_names.append(MutateMerchantCenterLinkRequest.__name__)
    from google.ads.googleads.v7 import MerchantCenterLinkOperation
    expected_names.append(MerchantCenterLinkOperation.__name__)
    from google.ads.googleads.v7 import MutateMerchantCenterLinkResponse
    expected_names.append(MutateMerchantCenterLinkResponse.__name__)
    from google.ads.googleads.v7 import MutateMerchantCenterLinkResult
    expected_names.append(MutateMerchantCenterLinkResult.__name__)
    from google.ads.googleads.v7 import GetMobileAppCategoryConstantRequest
    expected_names.append(GetMobileAppCategoryConstantRequest.__name__)
    from google.ads.googleads.v7 import GetMobileDeviceConstantRequest
    expected_names.append(GetMobileDeviceConstantRequest.__name__)
    from google.ads.googleads.v7 import CreateOfflineUserDataJobRequest
    expected_names.append(CreateOfflineUserDataJobRequest.__name__)
    from google.ads.googleads.v7 import CreateOfflineUserDataJobResponse
    expected_names.append(CreateOfflineUserDataJobResponse.__name__)
    from google.ads.googleads.v7 import GetOfflineUserDataJobRequest
    expected_names.append(GetOfflineUserDataJobRequest.__name__)
    from google.ads.googleads.v7 import RunOfflineUserDataJobRequest
    expected_names.append(RunOfflineUserDataJobRequest.__name__)
    from google.ads.googleads.v7 import AddOfflineUserDataJobOperationsRequest
    expected_names.append(AddOfflineUserDataJobOperationsRequest.__name__)
    from google.ads.googleads.v7 import OfflineUserDataJobOperation
    expected_names.append(OfflineUserDataJobOperation.__name__)
    from google.ads.googleads.v7 import AddOfflineUserDataJobOperationsResponse
    expected_names.append(AddOfflineUserDataJobOperationsResponse.__name__)
    from google.ads.googleads.v7 import GetOperatingSystemVersionConstantRequest
    expected_names.append(GetOperatingSystemVersionConstantRequest.__name__)
    from google.ads.googleads.v7 import GetPaidOrganicSearchTermViewRequest
    expected_names.append(GetPaidOrganicSearchTermViewRequest.__name__)
    from google.ads.googleads.v7 import GetParentalStatusViewRequest
    expected_names.append(GetParentalStatusViewRequest.__name__)
    from google.ads.googleads.v7 import ListPaymentsAccountsRequest
    expected_names.append(ListPaymentsAccountsRequest.__name__)
    from google.ads.googleads.v7 import ListPaymentsAccountsResponse
    expected_names.append(ListPaymentsAccountsResponse.__name__)
    from google.ads.googleads.v7 import GetProductBiddingCategoryConstantRequest
    expected_names.append(GetProductBiddingCategoryConstantRequest.__name__)
    from google.ads.googleads.v7 import GetProductGroupViewRequest
    expected_names.append(GetProductGroupViewRequest.__name__)
    from google.ads.googleads.v7 import ListPlannableLocationsRequest
    expected_names.append(ListPlannableLocationsRequest.__name__)
    from google.ads.googleads.v7 import ListPlannableLocationsResponse
    expected_names.append(ListPlannableLocationsResponse.__name__)
    from google.ads.googleads.v7 import PlannableLocation
    expected_names.append(PlannableLocation.__name__)
    from google.ads.googleads.v7 import ListPlannableProductsRequest
    expected_names.append(ListPlannableProductsRequest.__name__)
    from google.ads.googleads.v7 import ListPlannableProductsResponse
    expected_names.append(ListPlannableProductsResponse.__name__)
    from google.ads.googleads.v7 import ProductMetadata
    expected_names.append(ProductMetadata.__name__)
    from google.ads.googleads.v7 import PlannableTargeting
    expected_names.append(PlannableTargeting.__name__)
    from google.ads.googleads.v7 import GenerateProductMixIdeasRequest
    expected_names.append(GenerateProductMixIdeasRequest.__name__)
    from google.ads.googleads.v7 import Preferences
    expected_names.append(Preferences.__name__)
    from google.ads.googleads.v7 import GenerateProductMixIdeasResponse
    expected_names.append(GenerateProductMixIdeasResponse.__name__)
    from google.ads.googleads.v7 import ProductAllocation
    expected_names.append(ProductAllocation.__name__)
    from google.ads.googleads.v7 import GenerateReachForecastRequest
    expected_names.append(GenerateReachForecastRequest.__name__)
    from google.ads.googleads.v7 import FrequencyCap
    expected_names.append(FrequencyCap.__name__)
    from google.ads.googleads.v7 import Targeting
    expected_names.append(Targeting.__name__)
    from google.ads.googleads.v7 import CampaignDuration
    expected_names.append(CampaignDuration.__name__)
    from google.ads.googleads.v7 import PlannedProduct
    expected_names.append(PlannedProduct.__name__)
    from google.ads.googleads.v7 import GenerateReachForecastResponse
    expected_names.append(GenerateReachForecastResponse.__name__)
    from google.ads.googleads.v7 import ReachCurve
    expected_names.append(ReachCurve.__name__)
    from google.ads.googleads.v7 import ReachForecast
    expected_names.append(ReachForecast.__name__)
    from google.ads.googleads.v7 import Forecast
    expected_names.append(Forecast.__name__)
    from google.ads.googleads.v7 import PlannedProductReachForecast
    expected_names.append(PlannedProductReachForecast.__name__)
    from google.ads.googleads.v7 import PlannedProductForecast
    expected_names.append(PlannedProductForecast.__name__)
    from google.ads.googleads.v7 import OnTargetAudienceMetrics
    expected_names.append(OnTargetAudienceMetrics.__name__)
    from google.ads.googleads.v7 import GetRecommendationRequest
    expected_names.append(GetRecommendationRequest.__name__)
    from google.ads.googleads.v7 import ApplyRecommendationRequest
    expected_names.append(ApplyRecommendationRequest.__name__)
    from google.ads.googleads.v7 import ApplyRecommendationOperation
    expected_names.append(ApplyRecommendationOperation.__name__)
    from google.ads.googleads.v7 import ApplyRecommendationResponse
    expected_names.append(ApplyRecommendationResponse.__name__)
    from google.ads.googleads.v7 import ApplyRecommendationResult
    expected_names.append(ApplyRecommendationResult.__name__)
    from google.ads.googleads.v7 import DismissRecommendationRequest
    expected_names.append(DismissRecommendationRequest.__name__)
    from google.ads.googleads.v7 import DismissRecommendationResponse
    expected_names.append(DismissRecommendationResponse.__name__)
    from google.ads.googleads.v7 import GetSearchTermViewRequest
    expected_names.append(GetSearchTermViewRequest.__name__)
    from google.ads.googleads.v7 import GetShoppingPerformanceViewRequest
    expected_names.append(GetShoppingPerformanceViewRequest.__name__)
    from google.ads.googleads.v7 import GetThirdPartyAppAnalyticsLinkRequest
    expected_names.append(GetThirdPartyAppAnalyticsLinkRequest.__name__)
    from google.ads.googleads.v7 import RegenerateShareableLinkIdRequest
    expected_names.append(RegenerateShareableLinkIdRequest.__name__)
    from google.ads.googleads.v7 import RegenerateShareableLinkIdResponse
    expected_names.append(RegenerateShareableLinkIdResponse.__name__)
    from google.ads.googleads.v7 import GetTopicConstantRequest
    expected_names.append(GetTopicConstantRequest.__name__)
    from google.ads.googleads.v7 import GetTopicViewRequest
    expected_names.append(GetTopicViewRequest.__name__)
    from google.ads.googleads.v7 import UploadUserDataRequest
    expected_names.append(UploadUserDataRequest.__name__)
    from google.ads.googleads.v7 import UserDataOperation
    expected_names.append(UserDataOperation.__name__)
    from google.ads.googleads.v7 import UploadUserDataResponse
    expected_names.append(UploadUserDataResponse.__name__)
    from google.ads.googleads.v7 import GetUserInterestRequest
    expected_names.append(GetUserInterestRequest.__name__)
    from google.ads.googleads.v7 import GetUserLocationViewRequest
    expected_names.append(GetUserLocationViewRequest.__name__)
    from google.ads.googleads.v7 import GetVideoRequest
    expected_names.append(GetVideoRequest.__name__)
    from google.ads.googleads.v7 import GetWebpageViewRequest
    expected_names.append(GetWebpageViewRequest.__name__)

    # Client and transport classes
    from google.ads.googleads.v7 import WebpageViewServiceClient
    expected_names.append(WebpageViewServiceClient.__name__)
    from google.ads.googleads.v7 import WebpageViewServiceTransport
    expected_names.append(WebpageViewServiceTransport.__name__)
    from google.ads.googleads.v7 import WebpageViewServiceGrpcTransport
    expected_names.append(WebpageViewServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import VideoServiceClient
    expected_names.append(VideoServiceClient.__name__)
    from google.ads.googleads.v7 import VideoServiceTransport
    expected_names.append(VideoServiceTransport.__name__)
    from google.ads.googleads.v7 import VideoServiceGrpcTransport
    expected_names.append(VideoServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import UserLocationViewServiceClient
    expected_names.append(UserLocationViewServiceClient.__name__)
    from google.ads.googleads.v7 import UserLocationViewServiceTransport
    expected_names.append(UserLocationViewServiceTransport.__name__)
    from google.ads.googleads.v7 import UserLocationViewServiceGrpcTransport
    expected_names.append(UserLocationViewServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import UserInterestServiceClient
    expected_names.append(UserInterestServiceClient.__name__)
    from google.ads.googleads.v7 import UserInterestServiceTransport
    expected_names.append(UserInterestServiceTransport.__name__)
    from google.ads.googleads.v7 import UserInterestServiceGrpcTransport
    expected_names.append(UserInterestServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import UserDataServiceClient
    expected_names.append(UserDataServiceClient.__name__)
    from google.ads.googleads.v7 import UserDataServiceTransport
    expected_names.append(UserDataServiceTransport.__name__)
    from google.ads.googleads.v7 import UserDataServiceGrpcTransport
    expected_names.append(UserDataServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import TopicViewServiceClient
    expected_names.append(TopicViewServiceClient.__name__)
    from google.ads.googleads.v7 import TopicViewServiceTransport
    expected_names.append(TopicViewServiceTransport.__name__)
    from google.ads.googleads.v7 import TopicViewServiceGrpcTransport
    expected_names.append(TopicViewServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import TopicConstantServiceClient
    expected_names.append(TopicConstantServiceClient.__name__)
    from google.ads.googleads.v7 import TopicConstantServiceTransport
    expected_names.append(TopicConstantServiceTransport.__name__)
    from google.ads.googleads.v7 import TopicConstantServiceGrpcTransport
    expected_names.append(TopicConstantServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import ThirdPartyAppAnalyticsLinkServiceClient
    expected_names.append(ThirdPartyAppAnalyticsLinkServiceClient.__name__)
    from google.ads.googleads.v7 import ThirdPartyAppAnalyticsLinkServiceTransport
    expected_names.append(ThirdPartyAppAnalyticsLinkServiceTransport.__name__)
    from google.ads.googleads.v7 import ThirdPartyAppAnalyticsLinkServiceGrpcTransport
    expected_names.append(ThirdPartyAppAnalyticsLinkServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import ShoppingPerformanceViewServiceClient
    expected_names.append(ShoppingPerformanceViewServiceClient.__name__)
    from google.ads.googleads.v7 import ShoppingPerformanceViewServiceTransport
    expected_names.append(ShoppingPerformanceViewServiceTransport.__name__)
    from google.ads.googleads.v7 import ShoppingPerformanceViewServiceGrpcTransport
    expected_names.append(ShoppingPerformanceViewServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import SearchTermViewServiceClient
    expected_names.append(SearchTermViewServiceClient.__name__)
    from google.ads.googleads.v7 import SearchTermViewServiceTransport
    expected_names.append(SearchTermViewServiceTransport.__name__)
    from google.ads.googleads.v7 import SearchTermViewServiceGrpcTransport
    expected_names.append(SearchTermViewServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import RecommendationServiceClient
    expected_names.append(RecommendationServiceClient.__name__)
    from google.ads.googleads.v7 import RecommendationServiceTransport
    expected_names.append(RecommendationServiceTransport.__name__)
    from google.ads.googleads.v7 import RecommendationServiceGrpcTransport
    expected_names.append(RecommendationServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import ReachPlanServiceClient
    expected_names.append(ReachPlanServiceClient.__name__)
    from google.ads.googleads.v7 import ReachPlanServiceTransport
    expected_names.append(ReachPlanServiceTransport.__name__)
    from google.ads.googleads.v7 import ReachPlanServiceGrpcTransport
    expected_names.append(ReachPlanServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import ProductGroupViewServiceClient
    expected_names.append(ProductGroupViewServiceClient.__name__)
    from google.ads.googleads.v7 import ProductGroupViewServiceTransport
    expected_names.append(ProductGroupViewServiceTransport.__name__)
    from google.ads.googleads.v7 import ProductGroupViewServiceGrpcTransport
    expected_names.append(ProductGroupViewServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import ProductBiddingCategoryConstantServiceClient
    expected_names.append(ProductBiddingCategoryConstantServiceClient.__name__)
    from google.ads.googleads.v7 import ProductBiddingCategoryConstantServiceTransport
    expected_names.append(ProductBiddingCategoryConstantServiceTransport.__name__)
    from google.ads.googleads.v7 import ProductBiddingCategoryConstantServiceGrpcTransport
    expected_names.append(ProductBiddingCategoryConstantServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import PaymentsAccountServiceClient
    expected_names.append(PaymentsAccountServiceClient.__name__)
    from google.ads.googleads.v7 import PaymentsAccountServiceTransport
    expected_names.append(PaymentsAccountServiceTransport.__name__)
    from google.ads.googleads.v7 import PaymentsAccountServiceGrpcTransport
    expected_names.append(PaymentsAccountServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import ParentalStatusViewServiceClient
    expected_names.append(ParentalStatusViewServiceClient.__name__)
    from google.ads.googleads.v7 import ParentalStatusViewServiceTransport
    expected_names.append(ParentalStatusViewServiceTransport.__name__)
    from google.ads.googleads.v7 import ParentalStatusViewServiceGrpcTransport
    expected_names.append(ParentalStatusViewServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import PaidOrganicSearchTermViewServiceClient
    expected_names.append(PaidOrganicSearchTermViewServiceClient.__name__)
    from google.ads.googleads.v7 import PaidOrganicSearchTermViewServiceTransport
    expected_names.append(PaidOrganicSearchTermViewServiceTransport.__name__)
    from google.ads.googleads.v7 import PaidOrganicSearchTermViewServiceGrpcTransport
    expected_names.append(PaidOrganicSearchTermViewServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import OperatingSystemVersionConstantServiceClient
    expected_names.append(OperatingSystemVersionConstantServiceClient.__name__)
    from google.ads.googleads.v7 import OperatingSystemVersionConstantServiceTransport
    expected_names.append(OperatingSystemVersionConstantServiceTransport.__name__)
    from google.ads.googleads.v7 import OperatingSystemVersionConstantServiceGrpcTransport
    expected_names.append(OperatingSystemVersionConstantServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import OfflineUserDataJobServiceClient
    expected_names.append(OfflineUserDataJobServiceClient.__name__)
    from google.ads.googleads.v7 import OfflineUserDataJobServiceTransport
    expected_names.append(OfflineUserDataJobServiceTransport.__name__)
    from google.ads.googleads.v7 import OfflineUserDataJobServiceGrpcTransport
    expected_names.append(OfflineUserDataJobServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import MobileDeviceConstantServiceClient
    expected_names.append(MobileDeviceConstantServiceClient.__name__)
    from google.ads.googleads.v7 import MobileDeviceConstantServiceTransport
    expected_names.append(MobileDeviceConstantServiceTransport.__name__)
    from google.ads.googleads.v7 import MobileDeviceConstantServiceGrpcTransport
    expected_names.append(MobileDeviceConstantServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import MobileAppCategoryConstantServiceClient
    expected_names.append(MobileAppCategoryConstantServiceClient.__name__)
    from google.ads.googleads.v7 import MobileAppCategoryConstantServiceTransport
    expected_names.append(MobileAppCategoryConstantServiceTransport.__name__)
    from google.ads.googleads.v7 import MobileAppCategoryConstantServiceGrpcTransport
    expected_names.append(MobileAppCategoryConstantServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import MerchantCenterLinkServiceClient
    expected_names.append(MerchantCenterLinkServiceClient.__name__)
    from google.ads.googleads.v7 import MerchantCenterLinkServiceTransport
    expected_names.append(MerchantCenterLinkServiceTransport.__name__)
    from google.ads.googleads.v7 import MerchantCenterLinkServiceGrpcTransport
    expected_names.append(MerchantCenterLinkServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import ManagedPlacementViewServiceClient
    expected_names.append(ManagedPlacementViewServiceClient.__name__)
    from google.ads.googleads.v7 import ManagedPlacementViewServiceTransport
    expected_names.append(ManagedPlacementViewServiceTransport.__name__)
    from google.ads.googleads.v7 import ManagedPlacementViewServiceGrpcTransport
    expected_names.append(ManagedPlacementViewServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import LocationViewServiceClient
    expected_names.append(LocationViewServiceClient.__name__)
    from google.ads.googleads.v7 import LocationViewServiceTransport
    expected_names.append(LocationViewServiceTransport.__name__)
    from google.ads.googleads.v7 import LocationViewServiceGrpcTransport
    expected_names.append(LocationViewServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import LifeEventServiceClient
    expected_names.append(LifeEventServiceClient.__name__)
    from google.ads.googleads.v7 import LifeEventServiceTransport
    expected_names.append(LifeEventServiceTransport.__name__)
    from google.ads.googleads.v7 import LifeEventServiceGrpcTransport
    expected_names.append(LifeEventServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import LanguageConstantServiceClient
    expected_names.append(LanguageConstantServiceClient.__name__)
    from google.ads.googleads.v7 import LanguageConstantServiceTransport
    expected_names.append(LanguageConstantServiceTransport.__name__)
    from google.ads.googleads.v7 import LanguageConstantServiceGrpcTransport
    expected_names.append(LanguageConstantServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import LandingPageViewServiceClient
    expected_names.append(LandingPageViewServiceClient.__name__)
    from google.ads.googleads.v7 import LandingPageViewServiceTransport
    expected_names.append(LandingPageViewServiceTransport.__name__)
    from google.ads.googleads.v7 import LandingPageViewServiceGrpcTransport
    expected_names.append(LandingPageViewServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import KeywordViewServiceClient
    expected_names.append(KeywordViewServiceClient.__name__)
    from google.ads.googleads.v7 import KeywordViewServiceTransport
    expected_names.append(KeywordViewServiceTransport.__name__)
    from google.ads.googleads.v7 import KeywordViewServiceGrpcTransport
    expected_names.append(KeywordViewServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import KeywordPlanIdeaServiceClient
    expected_names.append(KeywordPlanIdeaServiceClient.__name__)
    from google.ads.googleads.v7 import KeywordPlanIdeaServiceTransport
    expected_names.append(KeywordPlanIdeaServiceTransport.__name__)
    from google.ads.googleads.v7 import KeywordPlanIdeaServiceGrpcTransport
    expected_names.append(KeywordPlanIdeaServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import InvoiceServiceClient
    expected_names.append(InvoiceServiceClient.__name__)
    from google.ads.googleads.v7 import InvoiceServiceTransport
    expected_names.append(InvoiceServiceTransport.__name__)
    from google.ads.googleads.v7 import InvoiceServiceGrpcTransport
    expected_names.append(InvoiceServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import IncomeRangeViewServiceClient
    expected_names.append(IncomeRangeViewServiceClient.__name__)
    from google.ads.googleads.v7 import IncomeRangeViewServiceTransport
    expected_names.append(IncomeRangeViewServiceTransport.__name__)
    from google.ads.googleads.v7 import IncomeRangeViewServiceGrpcTransport
    expected_names.append(IncomeRangeViewServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import HotelPerformanceViewServiceClient
    expected_names.append(HotelPerformanceViewServiceClient.__name__)
    from google.ads.googleads.v7 import HotelPerformanceViewServiceTransport
    expected_names.append(HotelPerformanceViewServiceTransport.__name__)
    from google.ads.googleads.v7 import HotelPerformanceViewServiceGrpcTransport
    expected_names.append(HotelPerformanceViewServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import HotelGroupViewServiceClient
    expected_names.append(HotelGroupViewServiceClient.__name__)
    from google.ads.googleads.v7 import HotelGroupViewServiceTransport
    expected_names.append(HotelGroupViewServiceTransport.__name__)
    from google.ads.googleads.v7 import HotelGroupViewServiceGrpcTransport
    expected_names.append(HotelGroupViewServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import GroupPlacementViewServiceClient
    expected_names.append(GroupPlacementViewServiceClient.__name__)
    from google.ads.googleads.v7 import GroupPlacementViewServiceTransport
    expected_names.append(GroupPlacementViewServiceTransport.__name__)
    from google.ads.googleads.v7 import GroupPlacementViewServiceGrpcTransport
    expected_names.append(GroupPlacementViewServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import GoogleAdsFieldServiceClient
    expected_names.append(GoogleAdsFieldServiceClient.__name__)
    from google.ads.googleads.v7 import GoogleAdsFieldServiceTransport
    expected_names.append(GoogleAdsFieldServiceTransport.__name__)
    from google.ads.googleads.v7 import GoogleAdsFieldServiceGrpcTransport
    expected_names.append(GoogleAdsFieldServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import GeographicViewServiceClient
    expected_names.append(GeographicViewServiceClient.__name__)
    from google.ads.googleads.v7 import GeographicViewServiceTransport
    expected_names.append(GeographicViewServiceTransport.__name__)
    from google.ads.googleads.v7 import GeographicViewServiceGrpcTransport
    expected_names.append(GeographicViewServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import GeoTargetConstantServiceClient
    expected_names.append(GeoTargetConstantServiceClient.__name__)
    from google.ads.googleads.v7 import GeoTargetConstantServiceTransport
    expected_names.append(GeoTargetConstantServiceTransport.__name__)
    from google.ads.googleads.v7 import GeoTargetConstantServiceGrpcTransport
    expected_names.append(GeoTargetConstantServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import GenderViewServiceClient
    expected_names.append(GenderViewServiceClient.__name__)
    from google.ads.googleads.v7 import GenderViewServiceTransport
    expected_names.append(GenderViewServiceTransport.__name__)
    from google.ads.googleads.v7 import GenderViewServiceGrpcTransport
    expected_names.append(GenderViewServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import FeedPlaceholderViewServiceClient
    expected_names.append(FeedPlaceholderViewServiceClient.__name__)
    from google.ads.googleads.v7 import FeedPlaceholderViewServiceTransport
    expected_names.append(FeedPlaceholderViewServiceTransport.__name__)
    from google.ads.googleads.v7 import FeedPlaceholderViewServiceGrpcTransport
    expected_names.append(FeedPlaceholderViewServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import ExpandedLandingPageViewServiceClient
    expected_names.append(ExpandedLandingPageViewServiceClient.__name__)
    from google.ads.googleads.v7 import ExpandedLandingPageViewServiceTransport
    expected_names.append(ExpandedLandingPageViewServiceTransport.__name__)
    from google.ads.googleads.v7 import ExpandedLandingPageViewServiceGrpcTransport
    expected_names.append(ExpandedLandingPageViewServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import DynamicSearchAdsSearchTermViewServiceClient
    expected_names.append(DynamicSearchAdsSearchTermViewServiceClient.__name__)
    from google.ads.googleads.v7 import DynamicSearchAdsSearchTermViewServiceTransport
    expected_names.append(DynamicSearchAdsSearchTermViewServiceTransport.__name__)
    from google.ads.googleads.v7 import DynamicSearchAdsSearchTermViewServiceGrpcTransport
    expected_names.append(DynamicSearchAdsSearchTermViewServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import DomainCategoryServiceClient
    expected_names.append(DomainCategoryServiceClient.__name__)
    from google.ads.googleads.v7 import DomainCategoryServiceTransport
    expected_names.append(DomainCategoryServiceTransport.__name__)
    from google.ads.googleads.v7 import DomainCategoryServiceGrpcTransport
    expected_names.append(DomainCategoryServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import DistanceViewServiceClient
    expected_names.append(DistanceViewServiceClient.__name__)
    from google.ads.googleads.v7 import DistanceViewServiceTransport
    expected_names.append(DistanceViewServiceTransport.__name__)
    from google.ads.googleads.v7 import DistanceViewServiceGrpcTransport
    expected_names.append(DistanceViewServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import DisplayKeywordViewServiceClient
    expected_names.append(DisplayKeywordViewServiceClient.__name__)
    from google.ads.googleads.v7 import DisplayKeywordViewServiceTransport
    expected_names.append(DisplayKeywordViewServiceTransport.__name__)
    from google.ads.googleads.v7 import DisplayKeywordViewServiceGrpcTransport
    expected_names.append(DisplayKeywordViewServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import DetailPlacementViewServiceClient
    expected_names.append(DetailPlacementViewServiceClient.__name__)
    from google.ads.googleads.v7 import DetailPlacementViewServiceTransport
    expected_names.append(DetailPlacementViewServiceTransport.__name__)
    from google.ads.googleads.v7 import DetailPlacementViewServiceGrpcTransport
    expected_names.append(DetailPlacementViewServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import CustomerUserAccessServiceClient
    expected_names.append(CustomerUserAccessServiceClient.__name__)
    from google.ads.googleads.v7 import CustomerUserAccessServiceTransport
    expected_names.append(CustomerUserAccessServiceTransport.__name__)
    from google.ads.googleads.v7 import CustomerUserAccessServiceGrpcTransport
    expected_names.append(CustomerUserAccessServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import CustomerUserAccessInvitationServiceClient
    expected_names.append(CustomerUserAccessInvitationServiceClient.__name__)
    from google.ads.googleads.v7 import CustomerUserAccessInvitationServiceTransport
    expected_names.append(CustomerUserAccessInvitationServiceTransport.__name__)
    from google.ads.googleads.v7 import CustomerUserAccessInvitationServiceGrpcTransport
    expected_names.append(CustomerUserAccessInvitationServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import CustomerManagerLinkServiceClient
    expected_names.append(CustomerManagerLinkServiceClient.__name__)
    from google.ads.googleads.v7 import CustomerManagerLinkServiceTransport
    expected_names.append(CustomerManagerLinkServiceTransport.__name__)
    from google.ads.googleads.v7 import CustomerManagerLinkServiceGrpcTransport
    expected_names.append(CustomerManagerLinkServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import CustomerClientServiceClient
    expected_names.append(CustomerClientServiceClient.__name__)
    from google.ads.googleads.v7 import CustomerClientServiceTransport
    expected_names.append(CustomerClientServiceTransport.__name__)
    from google.ads.googleads.v7 import CustomerClientServiceGrpcTransport
    expected_names.append(CustomerClientServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import CustomerClientLinkServiceClient
    expected_names.append(CustomerClientLinkServiceClient.__name__)
    from google.ads.googleads.v7 import CustomerClientLinkServiceTransport
    expected_names.append(CustomerClientLinkServiceTransport.__name__)
    from google.ads.googleads.v7 import CustomerClientLinkServiceGrpcTransport
    expected_names.append(CustomerClientLinkServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import CustomInterestServiceClient
    expected_names.append(CustomInterestServiceClient.__name__)
    from google.ads.googleads.v7 import CustomInterestServiceTransport
    expected_names.append(CustomInterestServiceTransport.__name__)
    from google.ads.googleads.v7 import CustomInterestServiceGrpcTransport
    expected_names.append(CustomInterestServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import CustomAudienceServiceClient
    expected_names.append(CustomAudienceServiceClient.__name__)
    from google.ads.googleads.v7 import CustomAudienceServiceTransport
    expected_names.append(CustomAudienceServiceTransport.__name__)
    from google.ads.googleads.v7 import CustomAudienceServiceGrpcTransport
    expected_names.append(CustomAudienceServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import CurrencyConstantServiceClient
    expected_names.append(CurrencyConstantServiceClient.__name__)
    from google.ads.googleads.v7 import CurrencyConstantServiceTransport
    expected_names.append(CurrencyConstantServiceTransport.__name__)
    from google.ads.googleads.v7 import CurrencyConstantServiceGrpcTransport
    expected_names.append(CurrencyConstantServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import ConversionUploadServiceClient
    expected_names.append(ConversionUploadServiceClient.__name__)
    from google.ads.googleads.v7 import ConversionUploadServiceTransport
    expected_names.append(ConversionUploadServiceTransport.__name__)
    from google.ads.googleads.v7 import ConversionUploadServiceGrpcTransport
    expected_names.append(ConversionUploadServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import ConversionAdjustmentUploadServiceClient
    expected_names.append(ConversionAdjustmentUploadServiceClient.__name__)
    from google.ads.googleads.v7 import ConversionAdjustmentUploadServiceTransport
    expected_names.append(ConversionAdjustmentUploadServiceTransport.__name__)
    from google.ads.googleads.v7 import ConversionAdjustmentUploadServiceGrpcTransport
    expected_names.append(ConversionAdjustmentUploadServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import CombinedAudienceServiceClient
    expected_names.append(CombinedAudienceServiceClient.__name__)
    from google.ads.googleads.v7 import CombinedAudienceServiceTransport
    expected_names.append(CombinedAudienceServiceTransport.__name__)
    from google.ads.googleads.v7 import CombinedAudienceServiceGrpcTransport
    expected_names.append(CombinedAudienceServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import ClickViewServiceClient
    expected_names.append(ClickViewServiceClient.__name__)
    from google.ads.googleads.v7 import ClickViewServiceTransport
    expected_names.append(ClickViewServiceTransport.__name__)
    from google.ads.googleads.v7 import ClickViewServiceGrpcTransport
    expected_names.append(ClickViewServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import ChangeStatusServiceClient
    expected_names.append(ChangeStatusServiceClient.__name__)
    from google.ads.googleads.v7 import ChangeStatusServiceTransport
    expected_names.append(ChangeStatusServiceTransport.__name__)
    from google.ads.googleads.v7 import ChangeStatusServiceGrpcTransport
    expected_names.append(ChangeStatusServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import CarrierConstantServiceClient
    expected_names.append(CarrierConstantServiceClient.__name__)
    from google.ads.googleads.v7 import CarrierConstantServiceTransport
    expected_names.append(CarrierConstantServiceTransport.__name__)
    from google.ads.googleads.v7 import CarrierConstantServiceGrpcTransport
    expected_names.append(CarrierConstantServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import CampaignSimulationServiceClient
    expected_names.append(CampaignSimulationServiceClient.__name__)
    from google.ads.googleads.v7 import CampaignSimulationServiceTransport
    expected_names.append(CampaignSimulationServiceTransport.__name__)
    from google.ads.googleads.v7 import CampaignSimulationServiceGrpcTransport
    expected_names.append(CampaignSimulationServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import CampaignCriterionSimulationServiceClient
    expected_names.append(CampaignCriterionSimulationServiceClient.__name__)
    from google.ads.googleads.v7 import CampaignCriterionSimulationServiceTransport
    expected_names.append(CampaignCriterionSimulationServiceTransport.__name__)
    from google.ads.googleads.v7 import CampaignCriterionSimulationServiceGrpcTransport
    expected_names.append(CampaignCriterionSimulationServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import CampaignAudienceViewServiceClient
    expected_names.append(CampaignAudienceViewServiceClient.__name__)
    from google.ads.googleads.v7 import CampaignAudienceViewServiceTransport
    expected_names.append(CampaignAudienceViewServiceTransport.__name__)
    from google.ads.googleads.v7 import CampaignAudienceViewServiceGrpcTransport
    expected_names.append(CampaignAudienceViewServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import BillingSetupServiceClient
    expected_names.append(BillingSetupServiceClient.__name__)
    from google.ads.googleads.v7 import BillingSetupServiceTransport
    expected_names.append(BillingSetupServiceTransport.__name__)
    from google.ads.googleads.v7 import BillingSetupServiceGrpcTransport
    expected_names.append(BillingSetupServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import BiddingStrategySimulationServiceClient
    expected_names.append(BiddingStrategySimulationServiceClient.__name__)
    from google.ads.googleads.v7 import BiddingStrategySimulationServiceTransport
    expected_names.append(BiddingStrategySimulationServiceTransport.__name__)
    from google.ads.googleads.v7 import BiddingStrategySimulationServiceGrpcTransport
    expected_names.append(BiddingStrategySimulationServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import BatchJobServiceClient
    expected_names.append(BatchJobServiceClient.__name__)
    from google.ads.googleads.v7 import BatchJobServiceTransport
    expected_names.append(BatchJobServiceTransport.__name__)
    from google.ads.googleads.v7 import BatchJobServiceGrpcTransport
    expected_names.append(BatchJobServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import GoogleAdsServiceClient
    expected_names.append(GoogleAdsServiceClient.__name__)
    from google.ads.googleads.v7 import GoogleAdsServiceTransport
    expected_names.append(GoogleAdsServiceTransport.__name__)
    from google.ads.googleads.v7 import GoogleAdsServiceGrpcTransport
    expected_names.append(GoogleAdsServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import UserListServiceClient
    expected_names.append(UserListServiceClient.__name__)
    from google.ads.googleads.v7 import UserListServiceTransport
    expected_names.append(UserListServiceTransport.__name__)
    from google.ads.googleads.v7 import UserListServiceGrpcTransport
    expected_names.append(UserListServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import SharedSetServiceClient
    expected_names.append(SharedSetServiceClient.__name__)
    from google.ads.googleads.v7 import SharedSetServiceTransport
    expected_names.append(SharedSetServiceTransport.__name__)
    from google.ads.googleads.v7 import SharedSetServiceGrpcTransport
    expected_names.append(SharedSetServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import SharedCriterionServiceClient
    expected_names.append(SharedCriterionServiceClient.__name__)
    from google.ads.googleads.v7 import SharedCriterionServiceTransport
    expected_names.append(SharedCriterionServiceTransport.__name__)
    from google.ads.googleads.v7 import SharedCriterionServiceGrpcTransport
    expected_names.append(SharedCriterionServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import RemarketingActionServiceClient
    expected_names.append(RemarketingActionServiceClient.__name__)
    from google.ads.googleads.v7 import RemarketingActionServiceTransport
    expected_names.append(RemarketingActionServiceTransport.__name__)
    from google.ads.googleads.v7 import RemarketingActionServiceGrpcTransport
    expected_names.append(RemarketingActionServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import MediaFileServiceClient
    expected_names.append(MediaFileServiceClient.__name__)
    from google.ads.googleads.v7 import MediaFileServiceTransport
    expected_names.append(MediaFileServiceTransport.__name__)
    from google.ads.googleads.v7 import MediaFileServiceGrpcTransport
    expected_names.append(MediaFileServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import LabelServiceClient
    expected_names.append(LabelServiceClient.__name__)
    from google.ads.googleads.v7 import LabelServiceTransport
    expected_names.append(LabelServiceTransport.__name__)
    from google.ads.googleads.v7 import LabelServiceGrpcTransport
    expected_names.append(LabelServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import KeywordPlanServiceClient
    expected_names.append(KeywordPlanServiceClient.__name__)
    from google.ads.googleads.v7 import KeywordPlanServiceTransport
    expected_names.append(KeywordPlanServiceTransport.__name__)
    from google.ads.googleads.v7 import KeywordPlanServiceGrpcTransport
    expected_names.append(KeywordPlanServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import KeywordPlanCampaignServiceClient
    expected_names.append(KeywordPlanCampaignServiceClient.__name__)
    from google.ads.googleads.v7 import KeywordPlanCampaignServiceTransport
    expected_names.append(KeywordPlanCampaignServiceTransport.__name__)
    from google.ads.googleads.v7 import KeywordPlanCampaignServiceGrpcTransport
    expected_names.append(KeywordPlanCampaignServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import KeywordPlanCampaignKeywordServiceClient
    expected_names.append(KeywordPlanCampaignKeywordServiceClient.__name__)
    from google.ads.googleads.v7 import KeywordPlanCampaignKeywordServiceTransport
    expected_names.append(KeywordPlanCampaignKeywordServiceTransport.__name__)
    from google.ads.googleads.v7 import KeywordPlanCampaignKeywordServiceGrpcTransport
    expected_names.append(KeywordPlanCampaignKeywordServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import KeywordPlanAdGroupServiceClient
    expected_names.append(KeywordPlanAdGroupServiceClient.__name__)
    from google.ads.googleads.v7 import KeywordPlanAdGroupServiceTransport
    expected_names.append(KeywordPlanAdGroupServiceTransport.__name__)
    from google.ads.googleads.v7 import KeywordPlanAdGroupServiceGrpcTransport
    expected_names.append(KeywordPlanAdGroupServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import KeywordPlanAdGroupKeywordServiceClient
    expected_names.append(KeywordPlanAdGroupKeywordServiceClient.__name__)
    from google.ads.googleads.v7 import KeywordPlanAdGroupKeywordServiceTransport
    expected_names.append(KeywordPlanAdGroupKeywordServiceTransport.__name__)
    from google.ads.googleads.v7 import KeywordPlanAdGroupKeywordServiceGrpcTransport
    expected_names.append(KeywordPlanAdGroupKeywordServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import FeedServiceClient
    expected_names.append(FeedServiceClient.__name__)
    from google.ads.googleads.v7 import FeedServiceTransport
    expected_names.append(FeedServiceTransport.__name__)
    from google.ads.googleads.v7 import FeedServiceGrpcTransport
    expected_names.append(FeedServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import FeedMappingServiceClient
    expected_names.append(FeedMappingServiceClient.__name__)
    from google.ads.googleads.v7 import FeedMappingServiceTransport
    expected_names.append(FeedMappingServiceTransport.__name__)
    from google.ads.googleads.v7 import FeedMappingServiceGrpcTransport
    expected_names.append(FeedMappingServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import FeedItemTargetServiceClient
    expected_names.append(FeedItemTargetServiceClient.__name__)
    from google.ads.googleads.v7 import FeedItemTargetServiceTransport
    expected_names.append(FeedItemTargetServiceTransport.__name__)
    from google.ads.googleads.v7 import FeedItemTargetServiceGrpcTransport
    expected_names.append(FeedItemTargetServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import FeedItemSetServiceClient
    expected_names.append(FeedItemSetServiceClient.__name__)
    from google.ads.googleads.v7 import FeedItemSetServiceTransport
    expected_names.append(FeedItemSetServiceTransport.__name__)
    from google.ads.googleads.v7 import FeedItemSetServiceGrpcTransport
    expected_names.append(FeedItemSetServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import FeedItemSetLinkServiceClient
    expected_names.append(FeedItemSetLinkServiceClient.__name__)
    from google.ads.googleads.v7 import FeedItemSetLinkServiceTransport
    expected_names.append(FeedItemSetLinkServiceTransport.__name__)
    from google.ads.googleads.v7 import FeedItemSetLinkServiceGrpcTransport
    expected_names.append(FeedItemSetLinkServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import FeedItemServiceClient
    expected_names.append(FeedItemServiceClient.__name__)
    from google.ads.googleads.v7 import FeedItemServiceTransport
    expected_names.append(FeedItemServiceTransport.__name__)
    from google.ads.googleads.v7 import FeedItemServiceGrpcTransport
    expected_names.append(FeedItemServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import ExtensionFeedItemServiceClient
    expected_names.append(ExtensionFeedItemServiceClient.__name__)
    from google.ads.googleads.v7 import ExtensionFeedItemServiceTransport
    expected_names.append(ExtensionFeedItemServiceTransport.__name__)
    from google.ads.googleads.v7 import ExtensionFeedItemServiceGrpcTransport
    expected_names.append(ExtensionFeedItemServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import CustomerServiceClient
    expected_names.append(CustomerServiceClient.__name__)
    from google.ads.googleads.v7 import CustomerServiceTransport
    expected_names.append(CustomerServiceTransport.__name__)
    from google.ads.googleads.v7 import CustomerServiceGrpcTransport
    expected_names.append(CustomerServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import CustomerNegativeCriterionServiceClient
    expected_names.append(CustomerNegativeCriterionServiceClient.__name__)
    from google.ads.googleads.v7 import CustomerNegativeCriterionServiceTransport
    expected_names.append(CustomerNegativeCriterionServiceTransport.__name__)
    from google.ads.googleads.v7 import CustomerNegativeCriterionServiceGrpcTransport
    expected_names.append(CustomerNegativeCriterionServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import CustomerLabelServiceClient
    expected_names.append(CustomerLabelServiceClient.__name__)
    from google.ads.googleads.v7 import CustomerLabelServiceTransport
    expected_names.append(CustomerLabelServiceTransport.__name__)
    from google.ads.googleads.v7 import CustomerLabelServiceGrpcTransport
    expected_names.append(CustomerLabelServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import CustomerFeedServiceClient
    expected_names.append(CustomerFeedServiceClient.__name__)
    from google.ads.googleads.v7 import CustomerFeedServiceTransport
    expected_names.append(CustomerFeedServiceTransport.__name__)
    from google.ads.googleads.v7 import CustomerFeedServiceGrpcTransport
    expected_names.append(CustomerFeedServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import CustomerExtensionSettingServiceClient
    expected_names.append(CustomerExtensionSettingServiceClient.__name__)
    from google.ads.googleads.v7 import CustomerExtensionSettingServiceTransport
    expected_names.append(CustomerExtensionSettingServiceTransport.__name__)
    from google.ads.googleads.v7 import CustomerExtensionSettingServiceGrpcTransport
    expected_names.append(CustomerExtensionSettingServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import CustomerAssetServiceClient
    expected_names.append(CustomerAssetServiceClient.__name__)
    from google.ads.googleads.v7 import CustomerAssetServiceTransport
    expected_names.append(CustomerAssetServiceTransport.__name__)
    from google.ads.googleads.v7 import CustomerAssetServiceGrpcTransport
    expected_names.append(CustomerAssetServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import ConversionCustomVariableServiceClient
    expected_names.append(ConversionCustomVariableServiceClient.__name__)
    from google.ads.googleads.v7 import ConversionCustomVariableServiceTransport
    expected_names.append(ConversionCustomVariableServiceTransport.__name__)
    from google.ads.googleads.v7 import ConversionCustomVariableServiceGrpcTransport
    expected_names.append(ConversionCustomVariableServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import ConversionActionServiceClient
    expected_names.append(ConversionActionServiceClient.__name__)
    from google.ads.googleads.v7 import ConversionActionServiceTransport
    expected_names.append(ConversionActionServiceTransport.__name__)
    from google.ads.googleads.v7 import ConversionActionServiceGrpcTransport
    expected_names.append(ConversionActionServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import CampaignSharedSetServiceClient
    expected_names.append(CampaignSharedSetServiceClient.__name__)
    from google.ads.googleads.v7 import CampaignSharedSetServiceTransport
    expected_names.append(CampaignSharedSetServiceTransport.__name__)
    from google.ads.googleads.v7 import CampaignSharedSetServiceGrpcTransport
    expected_names.append(CampaignSharedSetServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import CampaignServiceClient
    expected_names.append(CampaignServiceClient.__name__)
    from google.ads.googleads.v7 import CampaignServiceTransport
    expected_names.append(CampaignServiceTransport.__name__)
    from google.ads.googleads.v7 import CampaignServiceGrpcTransport
    expected_names.append(CampaignServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import CampaignLabelServiceClient
    expected_names.append(CampaignLabelServiceClient.__name__)
    from google.ads.googleads.v7 import CampaignLabelServiceTransport
    expected_names.append(CampaignLabelServiceTransport.__name__)
    from google.ads.googleads.v7 import CampaignLabelServiceGrpcTransport
    expected_names.append(CampaignLabelServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import CampaignFeedServiceClient
    expected_names.append(CampaignFeedServiceClient.__name__)
    from google.ads.googleads.v7 import CampaignFeedServiceTransport
    expected_names.append(CampaignFeedServiceTransport.__name__)
    from google.ads.googleads.v7 import CampaignFeedServiceGrpcTransport
    expected_names.append(CampaignFeedServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import CampaignExtensionSettingServiceClient
    expected_names.append(CampaignExtensionSettingServiceClient.__name__)
    from google.ads.googleads.v7 import CampaignExtensionSettingServiceTransport
    expected_names.append(CampaignExtensionSettingServiceTransport.__name__)
    from google.ads.googleads.v7 import CampaignExtensionSettingServiceGrpcTransport
    expected_names.append(CampaignExtensionSettingServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import CampaignExperimentServiceClient
    expected_names.append(CampaignExperimentServiceClient.__name__)
    from google.ads.googleads.v7 import CampaignExperimentServiceTransport
    expected_names.append(CampaignExperimentServiceTransport.__name__)
    from google.ads.googleads.v7 import CampaignExperimentServiceGrpcTransport
    expected_names.append(CampaignExperimentServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import CampaignDraftServiceClient
    expected_names.append(CampaignDraftServiceClient.__name__)
    from google.ads.googleads.v7 import CampaignDraftServiceTransport
    expected_names.append(CampaignDraftServiceTransport.__name__)
    from google.ads.googleads.v7 import CampaignDraftServiceGrpcTransport
    expected_names.append(CampaignDraftServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import CampaignCriterionServiceClient
    expected_names.append(CampaignCriterionServiceClient.__name__)
    from google.ads.googleads.v7 import CampaignCriterionServiceTransport
    expected_names.append(CampaignCriterionServiceTransport.__name__)
    from google.ads.googleads.v7 import CampaignCriterionServiceGrpcTransport
    expected_names.append(CampaignCriterionServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import CampaignBudgetServiceClient
    expected_names.append(CampaignBudgetServiceClient.__name__)
    from google.ads.googleads.v7 import CampaignBudgetServiceTransport
    expected_names.append(CampaignBudgetServiceTransport.__name__)
    from google.ads.googleads.v7 import CampaignBudgetServiceGrpcTransport
    expected_names.append(CampaignBudgetServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import CampaignBidModifierServiceClient
    expected_names.append(CampaignBidModifierServiceClient.__name__)
    from google.ads.googleads.v7 import CampaignBidModifierServiceTransport
    expected_names.append(CampaignBidModifierServiceTransport.__name__)
    from google.ads.googleads.v7 import CampaignBidModifierServiceGrpcTransport
    expected_names.append(CampaignBidModifierServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import CampaignAssetServiceClient
    expected_names.append(CampaignAssetServiceClient.__name__)
    from google.ads.googleads.v7 import CampaignAssetServiceTransport
    expected_names.append(CampaignAssetServiceTransport.__name__)
    from google.ads.googleads.v7 import CampaignAssetServiceGrpcTransport
    expected_names.append(CampaignAssetServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import BiddingStrategyServiceClient
    expected_names.append(BiddingStrategyServiceClient.__name__)
    from google.ads.googleads.v7 import BiddingStrategyServiceTransport
    expected_names.append(BiddingStrategyServiceTransport.__name__)
    from google.ads.googleads.v7 import BiddingStrategyServiceGrpcTransport
    expected_names.append(BiddingStrategyServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import AssetServiceClient
    expected_names.append(AssetServiceClient.__name__)
    from google.ads.googleads.v7 import AssetServiceTransport
    expected_names.append(AssetServiceTransport.__name__)
    from google.ads.googleads.v7 import AssetServiceGrpcTransport
    expected_names.append(AssetServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import AgeRangeViewServiceClient
    expected_names.append(AgeRangeViewServiceClient.__name__)
    from google.ads.googleads.v7 import AgeRangeViewServiceTransport
    expected_names.append(AgeRangeViewServiceTransport.__name__)
    from google.ads.googleads.v7 import AgeRangeViewServiceGrpcTransport
    expected_names.append(AgeRangeViewServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import AdServiceClient
    expected_names.append(AdServiceClient.__name__)
    from google.ads.googleads.v7 import AdServiceTransport
    expected_names.append(AdServiceTransport.__name__)
    from google.ads.googleads.v7 import AdServiceGrpcTransport
    expected_names.append(AdServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import AdScheduleViewServiceClient
    expected_names.append(AdScheduleViewServiceClient.__name__)
    from google.ads.googleads.v7 import AdScheduleViewServiceTransport
    expected_names.append(AdScheduleViewServiceTransport.__name__)
    from google.ads.googleads.v7 import AdScheduleViewServiceGrpcTransport
    expected_names.append(AdScheduleViewServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import AdParameterServiceClient
    expected_names.append(AdParameterServiceClient.__name__)
    from google.ads.googleads.v7 import AdParameterServiceTransport
    expected_names.append(AdParameterServiceTransport.__name__)
    from google.ads.googleads.v7 import AdParameterServiceGrpcTransport
    expected_names.append(AdParameterServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import AdGroupSimulationServiceClient
    expected_names.append(AdGroupSimulationServiceClient.__name__)
    from google.ads.googleads.v7 import AdGroupSimulationServiceTransport
    expected_names.append(AdGroupSimulationServiceTransport.__name__)
    from google.ads.googleads.v7 import AdGroupSimulationServiceGrpcTransport
    expected_names.append(AdGroupSimulationServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import AdGroupServiceClient
    expected_names.append(AdGroupServiceClient.__name__)
    from google.ads.googleads.v7 import AdGroupServiceTransport
    expected_names.append(AdGroupServiceTransport.__name__)
    from google.ads.googleads.v7 import AdGroupServiceGrpcTransport
    expected_names.append(AdGroupServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import AdGroupLabelServiceClient
    expected_names.append(AdGroupLabelServiceClient.__name__)
    from google.ads.googleads.v7 import AdGroupLabelServiceTransport
    expected_names.append(AdGroupLabelServiceTransport.__name__)
    from google.ads.googleads.v7 import AdGroupLabelServiceGrpcTransport
    expected_names.append(AdGroupLabelServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import AdGroupFeedServiceClient
    expected_names.append(AdGroupFeedServiceClient.__name__)
    from google.ads.googleads.v7 import AdGroupFeedServiceTransport
    expected_names.append(AdGroupFeedServiceTransport.__name__)
    from google.ads.googleads.v7 import AdGroupFeedServiceGrpcTransport
    expected_names.append(AdGroupFeedServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import AdGroupExtensionSettingServiceClient
    expected_names.append(AdGroupExtensionSettingServiceClient.__name__)
    from google.ads.googleads.v7 import AdGroupExtensionSettingServiceTransport
    expected_names.append(AdGroupExtensionSettingServiceTransport.__name__)
    from google.ads.googleads.v7 import AdGroupExtensionSettingServiceGrpcTransport
    expected_names.append(AdGroupExtensionSettingServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import AdGroupCriterionSimulationServiceClient
    expected_names.append(AdGroupCriterionSimulationServiceClient.__name__)
    from google.ads.googleads.v7 import AdGroupCriterionSimulationServiceTransport
    expected_names.append(AdGroupCriterionSimulationServiceTransport.__name__)
    from google.ads.googleads.v7 import AdGroupCriterionSimulationServiceGrpcTransport
    expected_names.append(AdGroupCriterionSimulationServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import AdGroupCriterionServiceClient
    expected_names.append(AdGroupCriterionServiceClient.__name__)
    from google.ads.googleads.v7 import AdGroupCriterionServiceTransport
    expected_names.append(AdGroupCriterionServiceTransport.__name__)
    from google.ads.googleads.v7 import AdGroupCriterionServiceGrpcTransport
    expected_names.append(AdGroupCriterionServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import AdGroupCriterionLabelServiceClient
    expected_names.append(AdGroupCriterionLabelServiceClient.__name__)
    from google.ads.googleads.v7 import AdGroupCriterionLabelServiceTransport
    expected_names.append(AdGroupCriterionLabelServiceTransport.__name__)
    from google.ads.googleads.v7 import AdGroupCriterionLabelServiceGrpcTransport
    expected_names.append(AdGroupCriterionLabelServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import AdGroupBidModifierServiceClient
    expected_names.append(AdGroupBidModifierServiceClient.__name__)
    from google.ads.googleads.v7 import AdGroupBidModifierServiceTransport
    expected_names.append(AdGroupBidModifierServiceTransport.__name__)
    from google.ads.googleads.v7 import AdGroupBidModifierServiceGrpcTransport
    expected_names.append(AdGroupBidModifierServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import AdGroupAudienceViewServiceClient
    expected_names.append(AdGroupAudienceViewServiceClient.__name__)
    from google.ads.googleads.v7 import AdGroupAudienceViewServiceTransport
    expected_names.append(AdGroupAudienceViewServiceTransport.__name__)
    from google.ads.googleads.v7 import AdGroupAudienceViewServiceGrpcTransport
    expected_names.append(AdGroupAudienceViewServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import AdGroupAssetServiceClient
    expected_names.append(AdGroupAssetServiceClient.__name__)
    from google.ads.googleads.v7 import AdGroupAssetServiceTransport
    expected_names.append(AdGroupAssetServiceTransport.__name__)
    from google.ads.googleads.v7 import AdGroupAssetServiceGrpcTransport
    expected_names.append(AdGroupAssetServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import AdGroupAdServiceClient
    expected_names.append(AdGroupAdServiceClient.__name__)
    from google.ads.googleads.v7 import AdGroupAdServiceTransport
    expected_names.append(AdGroupAdServiceTransport.__name__)
    from google.ads.googleads.v7 import AdGroupAdServiceGrpcTransport
    expected_names.append(AdGroupAdServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import AdGroupAdLabelServiceClient
    expected_names.append(AdGroupAdLabelServiceClient.__name__)
    from google.ads.googleads.v7 import AdGroupAdLabelServiceTransport
    expected_names.append(AdGroupAdLabelServiceTransport.__name__)
    from google.ads.googleads.v7 import AdGroupAdLabelServiceGrpcTransport
    expected_names.append(AdGroupAdLabelServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import AdGroupAdAssetViewServiceClient
    expected_names.append(AdGroupAdAssetViewServiceClient.__name__)
    from google.ads.googleads.v7 import AdGroupAdAssetViewServiceTransport
    expected_names.append(AdGroupAdAssetViewServiceTransport.__name__)
    from google.ads.googleads.v7 import AdGroupAdAssetViewServiceGrpcTransport
    expected_names.append(AdGroupAdAssetViewServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import AccountLinkServiceClient
    expected_names.append(AccountLinkServiceClient.__name__)
    from google.ads.googleads.v7 import AccountLinkServiceTransport
    expected_names.append(AccountLinkServiceTransport.__name__)
    from google.ads.googleads.v7 import AccountLinkServiceGrpcTransport
    expected_names.append(AccountLinkServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import AccountBudgetServiceClient
    expected_names.append(AccountBudgetServiceClient.__name__)
    from google.ads.googleads.v7 import AccountBudgetServiceTransport
    expected_names.append(AccountBudgetServiceTransport.__name__)
    from google.ads.googleads.v7 import AccountBudgetServiceGrpcTransport
    expected_names.append(AccountBudgetServiceGrpcTransport.__name__)
    from google.ads.googleads.v7 import AccountBudgetProposalServiceClient
    expected_names.append(AccountBudgetProposalServiceClient.__name__)
    from google.ads.googleads.v7 import AccountBudgetProposalServiceTransport
    expected_names.append(AccountBudgetProposalServiceTransport.__name__)
    from google.ads.googleads.v7 import AccountBudgetProposalServiceGrpcTransport
    expected_names.append(AccountBudgetProposalServiceGrpcTransport.__name__)

    expected_names.sort()
    from google.ads.googleads import v7
    actual_names = dir(v7)
    assert expected_names == actual_names

    # Verify the logic for handling non-existant names
    with pytest.raises(ImportError):
        from google.ads.googleads.v7 import GiantSquid
