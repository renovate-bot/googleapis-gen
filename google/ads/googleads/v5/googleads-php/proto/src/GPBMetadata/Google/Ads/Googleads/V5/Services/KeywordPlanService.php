<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v5/services/keyword_plan_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V5\Services;

class KeywordPlanService
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();
        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Api\Http::initOnce();
        \GPBMetadata\Google\Api\Annotations::initOnce();
        \GPBMetadata\Google\Protobuf\Wrappers::initOnce();
        \GPBMetadata\Google\Api\Resource::initOnce();
        \GPBMetadata\Google\Api\Client::initOnce();
        \GPBMetadata\Google\Protobuf\FieldMask::initOnce();
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        \GPBMetadata\Google\Protobuf\Any::initOnce();
        \GPBMetadata\Google\Rpc\Status::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
Bgoogle/ads/googleads/v5/enums/keyword_plan_competition_level.protogoogle.ads.googleads.v5.enums"}
KeywordPlanCompetitionLevelEnum"Z
KeywordPlanCompetitionLevel
UNSPECIFIED 
UNKNOWN
LOW

MEDIUM
HIGHB�
!com.google.ads.googleads.v5.enumsB KeywordPlanCompetitionLevelProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v5/enums;enums�GAA�Google.Ads.GoogleAds.V5.Enums�Google\\Ads\\GoogleAds\\V5\\Enums�!Google::Ads::GoogleAds::V5::Enumsbproto3
�
*google/ads/googleads/v5/common/dates.protogoogle.ads.googleads.v5.commongoogle/api/annotations.proto"m
	DateRange0

start_date (2.google.protobuf.StringValue.
end_date (2.google.protobuf.StringValueB�
"com.google.ads.googleads.v5.commonB
DatesProtoPZDgoogle.golang.org/genproto/googleapis/ads/googleads/v5/common;common�GAA�Google.Ads.GoogleAds.V5.Common�Google\\Ads\\GoogleAds\\V5\\Common�"Google::Ads::GoogleAds::V5::Commonbproto3
�
1google/ads/googleads/v5/enums/month_of_year.protogoogle.ads.googleads.v5.enums"�
MonthOfYearEnum"�
MonthOfYear
UNSPECIFIED 
UNKNOWN
JANUARY
FEBRUARY	
MARCH	
APRIL
MAY
JUNE
JULY

AUGUST	
	SEPTEMBER

OCTOBER
NOVEMBER
DECEMBERB�
!com.google.ads.googleads.v5.enumsBMonthOfYearProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v5/enums;enums�GAA�Google.Ads.GoogleAds.V5.Enums�Google\\Ads\\GoogleAds\\V5\\Enums�!Google::Ads::GoogleAds::V5::Enumsbproto3
�
8google/ads/googleads/v5/common/keyword_plan_common.protogoogle.ads.googleads.v5.common1google/ads/googleads/v5/enums/month_of_year.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
KeywordPlanHistoricalMetrics9
avg_monthly_searches (2.google.protobuf.Int64ValueS
monthly_search_volumes (23.google.ads.googleads.v5.common.MonthlySearchVolumeo
competition (2Z.google.ads.googleads.v5.enums.KeywordPlanCompetitionLevelEnum.KeywordPlanCompetitionLevel6
competition_index (2.google.protobuf.Int64Value?
low_top_of_page_bid_micros (2.google.protobuf.Int64Value@
high_top_of_page_bid_micros (2.google.protobuf.Int64Value"�
MonthlySearchVolume)
year (2.google.protobuf.Int64ValueI
month (2:.google.ads.googleads.v5.enums.MonthOfYearEnum.MonthOfYear5
monthly_searches (2.google.protobuf.Int64ValueB�
"com.google.ads.googleads.v5.commonBKeywordPlanCommonProtoPZDgoogle.golang.org/genproto/googleapis/ads/googleads/v5/common;common�GAA�Google.Ads.GoogleAds.V5.Common�Google\\Ads\\GoogleAds\\V5\\Common�"Google::Ads::GoogleAds::V5::Commonbproto3
�
Bgoogle/ads/googleads/v5/enums/keyword_plan_forecast_interval.protogoogle.ads.googleads.v5.enums"�
KeywordPlanForecastIntervalEnum"l
KeywordPlanForecastInterval
UNSPECIFIED 
UNKNOWN
	NEXT_WEEK

NEXT_MONTH
NEXT_QUARTERB�
!com.google.ads.googleads.v5.enumsB KeywordPlanForecastIntervalProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v5/enums;enums�GAA�Google.Ads.GoogleAds.V5.Enums�Google\\Ads\\GoogleAds\\V5\\Enums�!Google::Ads::GoogleAds::V5::Enumsbproto3
�
4google/ads/googleads/v5/resources/keyword_plan.proto!google.ads.googleads.v5.resourcesBgoogle/ads/googleads/v5/enums/keyword_plan_forecast_interval.protogoogle/api/field_behavior.protogoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
KeywordPlanC
resource_name (	B,�A�A&
$googleads.googleapis.com/KeywordPlan,
id (2.google.protobuf.Int64ValueB�A*
name (2.google.protobuf.StringValueU
forecast_period (2<.google.ads.googleads.v5.resources.KeywordPlanForecastPeriod:[�AX
$googleads.googleapis.com/KeywordPlan0customers/{customer}/keywordPlans/{keyword_plan}"�
KeywordPlanForecastPeriods
date_interval (2Z.google.ads.googleads.v5.enums.KeywordPlanForecastIntervalEnum.KeywordPlanForecastIntervalH ?

date_range (2).google.ads.googleads.v5.common.DateRangeH B

intervalB�
%com.google.ads.googleads.v5.resourcesBKeywordPlanProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v5/resources;resources�GAA�!Google.Ads.GoogleAds.V5.Resources�!Google\\Ads\\GoogleAds\\V5\\Resources�%Google::Ads::GoogleAds::V5::Resourcesbproto3
�.
;google/ads/googleads/v5/services/keyword_plan_service.proto google.ads.googleads.v5.services4google/ads/googleads/v5/resources/keyword_plan.protogoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto google/protobuf/field_mask.protogoogle/protobuf/wrappers.protogoogle/rpc/status.proto"\\
GetKeywordPlanRequestC
resource_name (	B,�A�A&
$googleads.googleapis.com/KeywordPlan"�
MutateKeywordPlansRequest
customer_id (	B�AO

operations (26.google.ads.googleads.v5.services.KeywordPlanOperationB�A
partial_failure (
validate_only ("�
KeywordPlanOperation/
update_mask (2.google.protobuf.FieldMask@
create (2..google.ads.googleads.v5.resources.KeywordPlanH @
update (2..google.ads.googleads.v5.resources.KeywordPlanH ;
remove (	B)�A&
$googleads.googleapis.com/KeywordPlanH B
	operation"�
MutateKeywordPlansResponse1
partial_failure_error (2.google.rpc.StatusK
results (2:.google.ads.googleads.v5.services.MutateKeywordPlansResult"1
MutateKeywordPlansResult
resource_name (	"b
GenerateForecastCurveRequestB
keyword_plan (	B,�A�A&
$googleads.googleapis.com/KeywordPlan"�
GenerateForecastCurveResponsed
campaign_forecast_curves (2B.google.ads.googleads.v5.services.KeywordPlanCampaignForecastCurve"g
!GenerateForecastTimeSeriesRequestB
keyword_plan (	B,�A�A&
$googleads.googleapis.com/KeywordPlan"�
"GenerateForecastTimeSeriesResponsek
weekly_time_series_forecasts (2E.google.ads.googleads.v5.services.KeywordPlanWeeklyTimeSeriesForecast"d
GenerateForecastMetricsRequestB
keyword_plan (	B,�A�A&
$googleads.googleapis.com/KeywordPlan"�
GenerateForecastMetricsResponseY
campaign_forecasts (2=.google.ads.googleads.v5.services.KeywordPlanCampaignForecastX
ad_group_forecasts (2<.google.ads.googleads.v5.services.KeywordPlanAdGroupForecastW
keyword_forecasts (2<.google.ads.googleads.v5.services.KeywordPlanKeywordForecast"�
KeywordPlanCampaignForecast;
keyword_plan_campaign (2.google.protobuf.StringValueL
campaign_forecast (21.google.ads.googleads.v5.services.ForecastMetrics"�
KeywordPlanAdGroupForecast;
keyword_plan_ad_group (2.google.protobuf.StringValueL
ad_group_forecast (21.google.ads.googleads.v5.services.ForecastMetrics"�
KeywordPlanKeywordForecastC
keyword_plan_ad_group_keyword (2.google.protobuf.StringValueK
keyword_forecast (21.google.ads.googleads.v5.services.ForecastMetrics"�
 KeywordPlanCampaignForecastCurve;
keyword_plan_campaign (2.google.protobuf.StringValueg
max_cpc_bid_forecast_curve (2C.google.ads.googleads.v5.services.KeywordPlanMaxCpcBidForecastCurve"�
!KeywordPlanMaxCpcBidForecastCurve]
max_cpc_bid_forecasts (2>.google.ads.googleads.v5.services.KeywordPlanMaxCpcBidForecast"�
KeywordPlanMaxCpcBidForecast7
max_cpc_bid_micros (2.google.protobuf.Int64ValueO
max_cpc_bid_forecast (21.google.ads.googleads.v5.services.ForecastMetrics"�
#KeywordPlanWeeklyTimeSeriesForecast"
keyword_plan_campaign (	H �U
weekly_forecasts (2;.google.ads.googleads.v5.services.KeywordPlanWeeklyForecastB
_keyword_plan_campaign"�
KeywordPlanWeeklyForecast

start_date (	H �C
forecast (21.google.ads.googleads.v5.services.ForecastMetricsB
_start_date"�
ForecastMetrics1
impressions (2.google.protobuf.DoubleValue)
ctr (2.google.protobuf.DoubleValue0
average_cpc (2.google.protobuf.Int64Value,
clicks (2.google.protobuf.DoubleValue0
cost_micros (2.google.protobuf.Int64Value"f
 GenerateHistoricalMetricsRequestB
keyword_plan (	B,�A�A&
$googleads.googleapis.com/KeywordPlan"{
!GenerateHistoricalMetricsResponseV
metrics (2E.google.ads.googleads.v5.services.KeywordPlanKeywordHistoricalMetrics"�
#KeywordPlanKeywordHistoricalMetrics2
search_query (2.google.protobuf.StringValue
close_variants (	U
keyword_metrics (2<.google.ads.googleads.v5.common.KeywordPlanHistoricalMetrics2�
KeywordPlanService�
GetKeywordPlan7.google.ads.googleads.v5.services.GetKeywordPlanRequest..google.ads.googleads.v5.resources.KeywordPlan"F���0./v5/{resource_name=customers/*/keywordPlans/*}�Aresource_name�
MutateKeywordPlans;.google.ads.googleads.v5.services.MutateKeywordPlansRequest<.google.ads.googleads.v5.services.MutateKeywordPlansResponse"U���6"1/v5/customers/{customer_id=*}/keywordPlans:mutate:*�Acustomer_id,operations�
GenerateForecastCurve>.google.ads.googleads.v5.services.GenerateForecastCurveRequest?.google.ads.googleads.v5.services.GenerateForecastCurveResponse"]���H"C/v5/{keyword_plan=customers/*/keywordPlans/*}:generateForecastCurve:*�Akeyword_plan�
GenerateForecastTimeSeriesC.google.ads.googleads.v5.services.GenerateForecastTimeSeriesRequestD.google.ads.googleads.v5.services.GenerateForecastTimeSeriesResponse"b���M"H/v5/{keyword_plan=customers/*/keywordPlans/*}:generateForecastTimeSeries:*�Akeyword_plan�
GenerateForecastMetrics@.google.ads.googleads.v5.services.GenerateForecastMetricsRequestA.google.ads.googleads.v5.services.GenerateForecastMetricsResponse"_���J"E/v5/{keyword_plan=customers/*/keywordPlans/*}:generateForecastMetrics:*�Akeyword_plan�
GenerateHistoricalMetricsB.google.ads.googleads.v5.services.GenerateHistoricalMetricsRequestC.google.ads.googleads.v5.services.GenerateHistoricalMetricsResponse"a���L"G/v5/{keyword_plan=customers/*/keywordPlans/*}:generateHistoricalMetrics:*�Akeyword_planE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v5.servicesBKeywordPlanServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v5/services;services�GAA� Google.Ads.GoogleAds.V5.Services� Google\\Ads\\GoogleAds\\V5\\Services�$Google::Ads::GoogleAds::V5::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

