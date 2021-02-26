<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v5/services/account_budget_proposal_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V5\Services;

class AccountBudgetProposalService
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
        \GPBMetadata\Google\Api\Client::initOnce();
        \GPBMetadata\Google\Protobuf\FieldMask::initOnce();
        \GPBMetadata\Google\Api\Resource::initOnce();
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
@google/ads/googleads/v5/enums/account_budget_proposal_type.protogoogle.ads.googleads.v5.enums"�
AccountBudgetProposalTypeEnum"f
AccountBudgetProposalType
UNSPECIFIED 
UNKNOWN

CREATE

UPDATE
END

REMOVEB�
!com.google.ads.googleads.v5.enumsBAccountBudgetProposalTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v5/enums;enums�GAA�Google.Ads.GoogleAds.V5.Enums�Google\\Ads\\GoogleAds\\V5\\Enums�!Google::Ads::GoogleAds::V5::Enumsbproto3
�
Bgoogle/ads/googleads/v5/enums/account_budget_proposal_status.protogoogle.ads.googleads.v5.enums"�
AccountBudgetProposalStatusEnum"�
AccountBudgetProposalStatus
UNSPECIFIED 
UNKNOWN
PENDING
APPROVED_HELD
APPROVED
	CANCELLED
REJECTEDB�
!com.google.ads.googleads.v5.enumsB AccountBudgetProposalStatusProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v5/enums;enums�GAA�Google.Ads.GoogleAds.V5.Enums�Google\\Ads\\GoogleAds\\V5\\Enums�!Google::Ads::GoogleAds::V5::Enumsbproto3
�
7google/ads/googleads/v5/enums/spending_limit_type.protogoogle.ads.googleads.v5.enums"X
SpendingLimitTypeEnum"?
SpendingLimitType
UNSPECIFIED 
UNKNOWN
INFINITEB�
!com.google.ads.googleads.v5.enumsBSpendingLimitTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v5/enums;enums�GAA�Google.Ads.GoogleAds.V5.Enums�Google\\Ads\\GoogleAds\\V5\\Enums�!Google::Ads::GoogleAds::V5::Enumsbproto3
�
-google/ads/googleads/v5/enums/time_type.protogoogle.ads.googleads.v5.enums"N
TimeTypeEnum">
TimeType
UNSPECIFIED 
UNKNOWN
NOW
FOREVERB�
!com.google.ads.googleads.v5.enumsBTimeTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v5/enums;enums�GAA�Google.Ads.GoogleAds.V5.Enums�Google\\Ads\\GoogleAds\\V5\\Enums�!Google::Ads::GoogleAds::V5::Enumsbproto3
�
?google/ads/googleads/v5/resources/account_budget_proposal.proto!google.ads.googleads.v5.resources@google/ads/googleads/v5/enums/account_budget_proposal_type.proto7google/ads/googleads/v5/enums/spending_limit_type.proto-google/ads/googleads/v5/enums/time_type.protogoogle/api/field_behavior.protogoogle/api/resource.protogoogle/protobuf/wrappers.protogoogle/api/annotations.proto"�
AccountBudgetProposalM
resource_name (	B6�A�A0
.googleads.googleapis.com/AccountBudgetProposal,
id (2.google.protobuf.Int64ValueB�Ab
billing_setup (2.google.protobuf.StringValueB-�A�A\'
%googleads.googleapis.com/BillingSetupd
account_budget (2.google.protobuf.StringValueB.�A�A(
&googleads.googleapis.com/AccountBudgetr
proposal_type (2V.google.ads.googleads.v5.enums.AccountBudgetProposalTypeEnum.AccountBudgetProposalTypeB�Ao
status (2Z.google.ads.googleads.v5.enums.AccountBudgetProposalStatusEnum.AccountBudgetProposalStatusB�A8
proposed_name (2.google.protobuf.StringValueB�AC
approved_start_date_time (2.google.protobuf.StringValueB�AI
proposed_purchase_order_number (2.google.protobuf.StringValueB�A9
proposed_notes (2.google.protobuf.StringValueB�A=
creation_date_time (2.google.protobuf.StringValueB�A=
approval_date_time (2.google.protobuf.StringValueB�AE
proposed_start_date_time (2.google.protobuf.StringValueB�AH ]
proposed_start_time_type (24.google.ads.googleads.v5.enums.TimeTypeEnum.TimeTypeB�AH C
proposed_end_date_time (2.google.protobuf.StringValueB�AH[
proposed_end_time_type	 (24.google.ads.googleads.v5.enums.TimeTypeEnum.TimeTypeB�AHC
approved_end_date_time (2.google.protobuf.StringValueB�AH[
approved_end_time_type (24.google.ads.googleads.v5.enums.TimeTypeEnum.TimeTypeB�AHJ
proposed_spending_limit_micros
 (2.google.protobuf.Int64ValueB�AHs
proposed_spending_limit_type (2F.google.ads.googleads.v5.enums.SpendingLimitTypeEnum.SpendingLimitTypeB�AHJ
approved_spending_limit_micros (2.google.protobuf.Int64ValueB�AHs
approved_spending_limit_type (2F.google.ads.googleads.v5.enums.SpendingLimitTypeEnum.SpendingLimitTypeB�AH:z�Aw
.googleads.googleapis.com/AccountBudgetProposalEcustomers/{customer}/accountBudgetProposals/{account_budget_proposal}B
proposed_start_timeB
proposed_end_timeB
approved_end_timeB
proposed_spending_limitB
approved_spending_limitB�
%com.google.ads.googleads.v5.resourcesBAccountBudgetProposalProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v5/resources;resources�GAA�!Google.Ads.GoogleAds.V5.Resources�!Google\\Ads\\GoogleAds\\V5\\Resources�%Google::Ads::GoogleAds::V5::Resourcesbproto3
�
Fgoogle/ads/googleads/v5/services/account_budget_proposal_service.proto google.ads.googleads.v5.servicesgoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto google/protobuf/field_mask.proto"p
GetAccountBudgetProposalRequestM
resource_name (	B6�A�A0
.googleads.googleapis.com/AccountBudgetProposal"�
"MutateAccountBudgetProposalRequest
customer_id (	B�AX
	operation (2@.google.ads.googleads.v5.services.AccountBudgetProposalOperationB�A
validate_only ("�
AccountBudgetProposalOperation/
update_mask (2.google.protobuf.FieldMaskJ
create (28.google.ads.googleads.v5.resources.AccountBudgetProposalH 
remove (	H B
	operation"z
#MutateAccountBudgetProposalResponseS
result (2C.google.ads.googleads.v5.services.MutateAccountBudgetProposalResult":
!MutateAccountBudgetProposalResult
resource_name (	2�
AccountBudgetProposalService�
GetAccountBudgetProposalA.google.ads.googleads.v5.services.GetAccountBudgetProposalRequest8.google.ads.googleads.v5.resources.AccountBudgetProposal"P���:8/v5/{resource_name=customers/*/accountBudgetProposals/*}�Aresource_name�
MutateAccountBudgetProposalD.google.ads.googleads.v5.services.MutateAccountBudgetProposalRequestE.google.ads.googleads.v5.services.MutateAccountBudgetProposalResponse"^���@";/v5/customers/{customer_id=*}/accountBudgetProposals:mutate:*�Acustomer_id,operationE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v5.servicesB!AccountBudgetProposalServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v5/services;services�GAA� Google.Ads.GoogleAds.V5.Services� Google\\Ads\\GoogleAds\\V5\\Services�$Google::Ads::GoogleAds::V5::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

