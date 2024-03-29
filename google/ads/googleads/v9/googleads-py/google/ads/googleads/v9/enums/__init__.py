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
'AccessInvitationStatusEnum',
'AccessReasonEnum',
'AccessRoleEnum',
'AccountBudgetProposalStatusEnum',
'AccountBudgetProposalTypeEnum',
'AccountBudgetStatusEnum',
'AccountLinkStatusEnum',
'AdCustomizerPlaceholderFieldEnum',
'AdDestinationTypeEnum',
'AdGroupAdRotationModeEnum',
'AdGroupAdStatusEnum',
'AdGroupCriterionApprovalStatusEnum',
'AdGroupCriterionStatusEnum',
'AdGroupStatusEnum',
'AdGroupTypeEnum',
'AdNetworkTypeEnum',
'AdServingOptimizationStatusEnum',
'AdStrengthEnum',
'AdTypeEnum',
'AdvertisingChannelSubTypeEnum',
'AdvertisingChannelTypeEnum',
'AffiliateLocationFeedRelationshipTypeEnum',
'AffiliateLocationPlaceholderFieldEnum',
'AgeRangeTypeEnum',
'AppCampaignAppStoreEnum',
'AppCampaignBiddingStrategyGoalTypeEnum',
'AppPaymentModelTypeEnum',
'AppPlaceholderFieldEnum',
'AppStoreEnum',
'AppUrlOperatingSystemTypeEnum',
'AssetFieldTypeEnum',
'AssetGroupStatusEnum',
'AssetLinkStatusEnum',
'AssetPerformanceLabelEnum',
'AssetSetAssetStatusEnum',
'AssetSetLinkStatusEnum',
'AssetSetStatusEnum',
'AssetSetTypeEnum',
'AssetTypeEnum',
'AttributionModelEnum',
'BatchJobStatusEnum',
'BidModifierSourceEnum',
'BiddingSourceEnum',
'BiddingStrategyStatusEnum',
'BiddingStrategyTypeEnum',
'BillingSetupStatusEnum',
'BrandSafetySuitabilityEnum',
'BudgetCampaignAssociationStatusEnum',
'BudgetDeliveryMethodEnum',
'BudgetPeriodEnum',
'BudgetStatusEnum',
'BudgetTypeEnum',
'CallConversionReportingStateEnum',
'CallPlaceholderFieldEnum',
'CallToActionTypeEnum',
'CallTrackingDisplayLocationEnum',
'CallTypeEnum',
'CalloutPlaceholderFieldEnum',
'CampaignCriterionStatusEnum',
'CampaignDraftStatusEnum',
'CampaignExperimentStatusEnum',
'CampaignExperimentTrafficSplitTypeEnum',
'CampaignExperimentTypeEnum',
'CampaignServingStatusEnum',
'CampaignSharedSetStatusEnum',
'CampaignStatusEnum',
'ChangeClientTypeEnum',
'ChangeEventResourceTypeEnum',
'ChangeStatusOperationEnum',
'ChangeStatusResourceTypeEnum',
'ClickTypeEnum',
'CombinedAudienceStatusEnum',
'ContentLabelTypeEnum',
'ConversionActionCategoryEnum',
'ConversionActionCountingTypeEnum',
'ConversionActionStatusEnum',
'ConversionActionTypeEnum',
'ConversionAdjustmentTypeEnum',
'ConversionAttributionEventTypeEnum',
'ConversionCustomVariableStatusEnum',
'ConversionLagBucketEnum',
'ConversionOrAdjustmentLagBucketEnum',
'ConversionOriginEnum',
'ConversionValueRulePrimaryDimensionEnum',
'ConversionValueRuleSetStatusEnum',
'ConversionValueRuleStatusEnum',
'CriterionCategoryChannelAvailabilityModeEnum',
'CriterionCategoryLocaleAvailabilityModeEnum',
'CriterionSystemServingStatusEnum',
'CriterionTypeEnum',
'CustomAudienceMemberTypeEnum',
'CustomAudienceStatusEnum',
'CustomAudienceTypeEnum',
'CustomConversionGoalStatusEnum',
'CustomInterestMemberTypeEnum',
'CustomInterestStatusEnum',
'CustomInterestTypeEnum',
'CustomPlaceholderFieldEnum',
'CustomerMatchUploadKeyTypeEnum',
'CustomerPayPerConversionEligibilityFailureReasonEnum',
'CustomizerAttributeStatusEnum',
'CustomizerAttributeTypeEnum',
'CustomizerValueStatusEnum',
'DataDrivenModelStatusEnum',
'DayOfWeekEnum',
'DeviceEnum',
'DisplayAdFormatSettingEnum',
'DisplayUploadProductTypeEnum',
'DistanceBucketEnum',
'DsaPageFeedCriterionFieldEnum',
'EducationPlaceholderFieldEnum',
'ExtensionSettingDeviceEnum',
'ExtensionTypeEnum',
'ExternalConversionSourceEnum',
'FeedAttributeTypeEnum',
'FeedItemQualityApprovalStatusEnum',
'FeedItemQualityDisapprovalReasonEnum',
'FeedItemSetStatusEnum',
'FeedItemSetStringFilterTypeEnum',
'FeedItemStatusEnum',
'FeedItemTargetDeviceEnum',
'FeedItemTargetStatusEnum',
'FeedItemTargetTypeEnum',
'FeedItemValidationStatusEnum',
'FeedLinkStatusEnum',
'FeedMappingCriterionTypeEnum',
'FeedMappingStatusEnum',
'FeedOriginEnum',
'FeedStatusEnum',
'FlightPlaceholderFieldEnum',
'FrequencyCapEventTypeEnum',
'FrequencyCapLevelEnum',
'FrequencyCapTimeUnitEnum',
'GenderTypeEnum',
'GeoTargetConstantStatusEnum',
'GeoTargetingRestrictionEnum',
'GeoTargetingTypeEnum',
'GoalConfigLevelEnum',
'GoogleAdsFieldCategoryEnum',
'GoogleAdsFieldDataTypeEnum',
'GoogleVoiceCallStatusEnum',
'HotelDateSelectionTypeEnum',
'HotelPlaceholderFieldEnum',
'HotelPriceBucketEnum',
'HotelRateTypeEnum',
'HotelReconciliationStatusEnum',
'ImagePlaceholderFieldEnum',
'IncomeRangeTypeEnum',
'InteractionEventTypeEnum',
'InteractionTypeEnum',
'InvoiceTypeEnum',
'JobPlaceholderFieldEnum',
'KeywordMatchTypeEnum',
'KeywordPlanAggregateMetricTypeEnum',
'KeywordPlanCompetitionLevelEnum',
'KeywordPlanConceptGroupTypeEnum',
'KeywordPlanForecastIntervalEnum',
'KeywordPlanKeywordAnnotationEnum',
'KeywordPlanNetworkEnum',
'LabelStatusEnum',
'LeadFormCallToActionTypeEnum',
'LeadFormDesiredIntentEnum',
'LeadFormFieldUserInputTypeEnum',
'LeadFormPostSubmitCallToActionTypeEnum',
'LegacyAppInstallAdAppStoreEnum',
'LinkedAccountTypeEnum',
'ListingGroupFilterBiddingCategoryLevelEnum',
'ListingGroupFilterCustomAttributeIndexEnum',
'ListingGroupFilterProductChannelEnum',
'ListingGroupFilterProductConditionEnum',
'ListingGroupFilterProductTypeLevelEnum',
'ListingGroupFilterTypeEnum',
'ListingGroupFilterVerticalEnum',
'ListingGroupTypeEnum',
'LocalPlaceholderFieldEnum',
'LocationExtensionTargetingCriterionFieldEnum',
'LocationGroupRadiusUnitsEnum',
'LocationPlaceholderFieldEnum',
'LocationSourceTypeEnum',
'ManagerLinkStatusEnum',
'MatchingFunctionContextTypeEnum',
'MatchingFunctionOperatorEnum',
'MediaTypeEnum',
'MerchantCenterLinkStatusEnum',
'MessagePlaceholderFieldEnum',
'MimeTypeEnum',
'MinuteOfHourEnum',
'MobileAppVendorEnum',
'MobileDeviceTypeEnum',
'MonthOfYearEnum',
'NegativeGeoTargetTypeEnum',
'OfflineUserDataJobFailureReasonEnum',
'OfflineUserDataJobMatchRateRangeEnum',
'OfflineUserDataJobStatusEnum',
'OfflineUserDataJobTypeEnum',
'OperatingSystemVersionOperatorTypeEnum',
'OptimizationGoalTypeEnum',
'ParentalStatusTypeEnum',
'PaymentModeEnum',
'PlaceholderTypeEnum',
'PlacementTypeEnum',
'PolicyApprovalStatusEnum',
'PolicyReviewStatusEnum',
'PolicyTopicEntryTypeEnum',
'PolicyTopicEvidenceDestinationMismatchUrlTypeEnum',
'PolicyTopicEvidenceDestinationNotWorkingDeviceEnum',
'PolicyTopicEvidenceDestinationNotWorkingDnsErrorTypeEnum',
'PositiveGeoTargetTypeEnum',
'PreferredContentTypeEnum',
'PriceExtensionPriceQualifierEnum',
'PriceExtensionPriceUnitEnum',
'PriceExtensionTypeEnum',
'PricePlaceholderFieldEnum',
'ProductBiddingCategoryLevelEnum',
'ProductBiddingCategoryStatusEnum',
'ProductChannelEnum',
'ProductChannelExclusivityEnum',
'ProductConditionEnum',
'ProductCustomAttributeIndexEnum',
'ProductTypeLevelEnum',
'PromotionExtensionDiscountModifierEnum',
'PromotionExtensionOccasionEnum',
'PromotionPlaceholderFieldEnum',
'ProximityRadiusUnitsEnum',
'QualityScoreBucketEnum',
'ReachPlanAdLengthEnum',
'ReachPlanAgeRangeEnum',
'ReachPlanNetworkEnum',
'RealEstatePlaceholderFieldEnum',
'RecommendationTypeEnum',
'ResourceChangeOperationEnum',
'ResourceLimitTypeEnum',
'ResponseContentTypeEnum',
'SearchEngineResultsPageTypeEnum',
'SearchTermMatchTypeEnum',
'SearchTermTargetingStatusEnum',
'SeasonalityEventScopeEnum',
'SeasonalityEventStatusEnum',
'ServedAssetFieldTypeEnum',
'SharedSetStatusEnum',
'SharedSetTypeEnum',
'SimulationModificationMethodEnum',
'SimulationTypeEnum',
'SitelinkPlaceholderFieldEnum',
'SlotEnum',
'SpendingLimitTypeEnum',
'StructuredSnippetPlaceholderFieldEnum',
'SummaryRowSettingEnum',
'SystemManagedResourceSourceEnum',
'TargetCpaOptInRecommendationGoalEnum',
'TargetImpressionShareLocationEnum',
'TargetingDimensionEnum',
'TimeTypeEnum',
'TrackingCodePageFormatEnum',
'TrackingCodeTypeEnum',
'TravelPlaceholderFieldEnum',
'UserIdentifierSourceEnum',
'UserInterestTaxonomyTypeEnum',
'UserListAccessStatusEnum',
'UserListClosingReasonEnum',
'UserListCombinedRuleOperatorEnum',
'UserListCrmDataSourceTypeEnum',
'UserListDateRuleItemOperatorEnum',
'UserListLogicalRuleOperatorEnum',
'UserListMembershipStatusEnum',
'UserListNumberRuleItemOperatorEnum',
'UserListPrepopulationStatusEnum',
'UserListRuleTypeEnum',
'UserListSizeRangeEnum',
'UserListStringRuleItemOperatorEnum',
'UserListTypeEnum',
'ValueRuleDeviceTypeEnum',
'ValueRuleGeoLocationMatchTypeEnum',
'ValueRuleOperationEnum',
'ValueRuleSetAttachmentTypeEnum',
'ValueRuleSetDimensionEnum',
'VanityPharmaDisplayUrlModeEnum',
'VanityPharmaTextEnum',
'VideoThumbnailEnum',
'WebpageConditionOperandEnum',
'WebpageConditionOperatorEnum',
)
