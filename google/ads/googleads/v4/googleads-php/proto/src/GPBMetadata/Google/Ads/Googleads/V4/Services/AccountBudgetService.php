<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v4/services/account_budget_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V4\Services;

class AccountBudgetService
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();
        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Protobuf\Wrappers::initOnce();
        \GPBMetadata\Google\Api\Http::initOnce();
        \GPBMetadata\Google\Api\Annotations::initOnce();
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        \GPBMetadata\Google\Api\Resource::initOnce();
        \GPBMetadata\Google\Api\Client::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
@google/ads/googleads/v4/enums/account_budget_proposal_type.protogoogle.ads.googleads.v4.enums"�
AccountBudgetProposalTypeEnum"f
AccountBudgetProposalType
UNSPECIFIED 
UNKNOWN

CREATE

UPDATE
END

REMOVEB�
!com.google.ads.googleads.v4.enumsBAccountBudgetProposalTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v4/enums;enums�GAA�Google.Ads.GoogleAds.V4.Enums�Google\\Ads\\GoogleAds\\V4\\Enums�!Google::Ads::GoogleAds::V4::Enumsbproto3
�
9google/ads/googleads/v4/enums/account_budget_status.protogoogle.ads.googleads.v4.enums"x
AccountBudgetStatusEnum"]
AccountBudgetStatus
UNSPECIFIED 
UNKNOWN
PENDING
APPROVED
	CANCELLEDB�
!com.google.ads.googleads.v4.enumsBAccountBudgetStatusProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v4/enums;enums�GAA�Google.Ads.GoogleAds.V4.Enums�Google\\Ads\\GoogleAds\\V4\\Enums�!Google::Ads::GoogleAds::V4::Enumsbproto3
�
7google/ads/googleads/v4/enums/spending_limit_type.protogoogle.ads.googleads.v4.enums"X
SpendingLimitTypeEnum"?
SpendingLimitType
UNSPECIFIED 
UNKNOWN
INFINITEB�
!com.google.ads.googleads.v4.enumsBSpendingLimitTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v4/enums;enums�GAA�Google.Ads.GoogleAds.V4.Enums�Google\\Ads\\GoogleAds\\V4\\Enums�!Google::Ads::GoogleAds::V4::Enumsbproto3
�
-google/ads/googleads/v4/enums/time_type.protogoogle.ads.googleads.v4.enums"N
TimeTypeEnum">
TimeType
UNSPECIFIED 
UNKNOWN
NOW
FOREVERB�
!com.google.ads.googleads.v4.enumsBTimeTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v4/enums;enums�GAA�Google.Ads.GoogleAds.V4.Enums�Google\\Ads\\GoogleAds\\V4\\Enums�!Google::Ads::GoogleAds::V4::Enumsbproto3
�
6google/ads/googleads/v4/resources/account_budget.proto!google.ads.googleads.v4.resources9google/ads/googleads/v4/enums/account_budget_status.proto7google/ads/googleads/v4/enums/spending_limit_type.proto-google/ads/googleads/v4/enums/time_type.protogoogle/api/field_behavior.protogoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
AccountBudgetE
resource_name (	B.�A�A(
&googleads.googleapis.com/AccountBudget,
id (2.google.protobuf.Int64ValueB�Ab
billing_setup (2.google.protobuf.StringValueB-�A�A\'
%googleads.googleapis.com/BillingSetup_
status (2J.google.ads.googleads.v4.enums.AccountBudgetStatusEnum.AccountBudgetStatusB�A/
name (2.google.protobuf.StringValueB�AC
proposed_start_date_time (2.google.protobuf.StringValueB�AC
approved_start_date_time (2.google.protobuf.StringValueB�AB
total_adjustments_micros (2.google.protobuf.Int64ValueB�A>
amount_served_micros (2.google.protobuf.Int64ValueB�A@
purchase_order_number (2.google.protobuf.StringValueB�A0
notes (2.google.protobuf.StringValueB�Al
pending_proposal (2M.google.ads.googleads.v4.resources.AccountBudget.PendingAccountBudgetProposalB�AC
proposed_end_date_time (2.google.protobuf.StringValueB�AH [
proposed_end_time_type	 (24.google.ads.googleads.v4.enums.TimeTypeEnum.TimeTypeB�AH C
approved_end_date_time
 (2.google.protobuf.StringValueB�AH[
approved_end_time_type (24.google.ads.googleads.v4.enums.TimeTypeEnum.TimeTypeB�AHJ
proposed_spending_limit_micros (2.google.protobuf.Int64ValueB�AHs
proposed_spending_limit_type (2F.google.ads.googleads.v4.enums.SpendingLimitTypeEnum.SpendingLimitTypeB�AHJ
approved_spending_limit_micros (2.google.protobuf.Int64ValueB�AHs
approved_spending_limit_type (2F.google.ads.googleads.v4.enums.SpendingLimitTypeEnum.SpendingLimitTypeB�AHJ
adjusted_spending_limit_micros (2.google.protobuf.Int64ValueB�AHs
adjusted_spending_limit_type (2F.google.ads.googleads.v4.enums.SpendingLimitTypeEnum.SpendingLimitTypeB�AH�
PendingAccountBudgetProposalu
account_budget_proposal (2.google.protobuf.StringValueB6�A�A0
.googleads.googleapis.com/AccountBudgetProposalr
proposal_type (2V.google.ads.googleads.v4.enums.AccountBudgetProposalTypeEnum.AccountBudgetProposalTypeB�A/
name (2.google.protobuf.StringValueB�A:
start_date_time (2.google.protobuf.StringValueB�A@
purchase_order_number	 (2.google.protobuf.StringValueB�A0
notes
 (2.google.protobuf.StringValueB�A=
creation_date_time (2.google.protobuf.StringValueB�A:
end_date_time (2.google.protobuf.StringValueB�AH R
end_time_type (24.google.ads.googleads.v4.enums.TimeTypeEnum.TimeTypeB�AH A
spending_limit_micros (2.google.protobuf.Int64ValueB�AHj
spending_limit_type (2F.google.ads.googleads.v4.enums.SpendingLimitTypeEnum.SpendingLimitTypeB�AHB

end_timeB
spending_limit:a�A^
&googleads.googleapis.com/AccountBudget4customers/{customer}/accountBudgets/{account_budget}B
proposed_end_timeB
approved_end_timeB
proposed_spending_limitB
approved_spending_limitB
adjusted_spending_limitB�
%com.google.ads.googleads.v4.resourcesBAccountBudgetProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v4/resources;resources�GAA�!Google.Ads.GoogleAds.V4.Resources�!Google\\Ads\\GoogleAds\\V4\\Resources�%Google::Ads::GoogleAds::V4::Resourcesbproto3
�
=google/ads/googleads/v4/services/account_budget_service.proto google.ads.googleads.v4.servicesgoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto"`
GetAccountBudgetRequestE
resource_name (	B.�A�A(
&googleads.googleapis.com/AccountBudget2�
AccountBudgetService�
GetAccountBudget9.google.ads.googleads.v4.services.GetAccountBudgetRequest0.google.ads.googleads.v4.resources.AccountBudget"H���20/v4/{resource_name=customers/*/accountBudgets/*}�Aresource_nameE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v4.servicesBAccountBudgetServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v4/services;services�GAA� Google.Ads.GoogleAds.V4.Services� Google\\Ads\\GoogleAds\\V4\\Services�$Google::Ads::GoogleAds::V4::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

