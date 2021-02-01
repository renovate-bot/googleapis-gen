<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/ads/googleads/v6/services/account_budget_proposal_service.proto

namespace GPBMetadata\Google\Ads\Googleads\V6\Services;

class AccountBudgetProposalService
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();
        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        \GPBMetadata\Google\Api\Http::initOnce();
        \GPBMetadata\Google\Api\Annotations::initOnce();
        \GPBMetadata\Google\Api\Resource::initOnce();
        \GPBMetadata\Google\Protobuf\FieldMask::initOnce();
        \GPBMetadata\Google\Api\Client::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
@google/ads/googleads/v6/enums/account_budget_proposal_type.protogoogle.ads.googleads.v6.enums"�
AccountBudgetProposalTypeEnum"f
AccountBudgetProposalType
UNSPECIFIED 
UNKNOWN

CREATE

UPDATE
END

REMOVEB�
!com.google.ads.googleads.v6.enumsBAccountBudgetProposalTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
Bgoogle/ads/googleads/v6/enums/account_budget_proposal_status.protogoogle.ads.googleads.v6.enums"�
AccountBudgetProposalStatusEnum"�
AccountBudgetProposalStatus
UNSPECIFIED 
UNKNOWN
PENDING
APPROVED_HELD
APPROVED
	CANCELLED
REJECTEDB�
!com.google.ads.googleads.v6.enumsB AccountBudgetProposalStatusProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
7google/ads/googleads/v6/enums/spending_limit_type.protogoogle.ads.googleads.v6.enums"X
SpendingLimitTypeEnum"?
SpendingLimitType
UNSPECIFIED 
UNKNOWN
INFINITEB�
!com.google.ads.googleads.v6.enumsBSpendingLimitTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
-google/ads/googleads/v6/enums/time_type.protogoogle.ads.googleads.v6.enums"N
TimeTypeEnum">
TimeType
UNSPECIFIED 
UNKNOWN
NOW
FOREVERB�
!com.google.ads.googleads.v6.enumsBTimeTypeProtoPZBgoogle.golang.org/genproto/googleapis/ads/googleads/v6/enums;enums�GAA�Google.Ads.GoogleAds.V6.Enums�Google\\Ads\\GoogleAds\\V6\\Enums�!Google::Ads::GoogleAds::V6::Enumsbproto3
�
?google/ads/googleads/v6/resources/account_budget_proposal.proto!google.ads.googleads.v6.resources@google/ads/googleads/v6/enums/account_budget_proposal_type.proto7google/ads/googleads/v6/enums/spending_limit_type.proto-google/ads/googleads/v6/enums/time_type.protogoogle/api/field_behavior.protogoogle/api/resource.protogoogle/api/annotations.proto"�
AccountBudgetProposalM
resource_name (	B6�A�A0
.googleads.googleapis.com/AccountBudgetProposal
id (B�AH�I
billing_setup (	B-�A�A\'
%googleads.googleapis.com/BillingSetupH�K
account_budget (	B.�A�A(
&googleads.googleapis.com/AccountBudgetH�r
proposal_type (2V.google.ads.googleads.v6.enums.AccountBudgetProposalTypeEnum.AccountBudgetProposalTypeB�Ao
status (2Z.google.ads.googleads.v6.enums.AccountBudgetProposalStatusEnum.AccountBudgetProposalStatusB�A
proposed_name (	B�AH�*
approved_start_date_time (	B�AH	�0
proposed_purchase_order_number# (	B�AH
� 
proposed_notes$ (	B�AH�$
creation_date_time% (	B�AH�$
approval_date_time& (	B�AH�\'
proposed_start_date_time (	B�AH ]
proposed_start_time_type (24.google.ads.googleads.v6.enums.TimeTypeEnum.TimeTypeB�AH %
proposed_end_date_time (	B�AH[
proposed_end_time_type	 (24.google.ads.googleads.v6.enums.TimeTypeEnum.TimeTypeB�AH%
approved_end_date_time  (	B�AH[
approved_end_time_type (24.google.ads.googleads.v6.enums.TimeTypeEnum.TimeTypeB�AH-
proposed_spending_limit_micros! (B�AHs
proposed_spending_limit_type (2F.google.ads.googleads.v6.enums.SpendingLimitTypeEnum.SpendingLimitTypeB�AH-
approved_spending_limit_micros" (B�AHs
approved_spending_limit_type (2F.google.ads.googleads.v6.enums.SpendingLimitTypeEnum.SpendingLimitTypeB�AH:��A}
.googleads.googleapis.com/AccountBudgetProposalKcustomers/{customer_id}/accountBudgetProposals/{account_budget_proposal_id}B
proposed_start_timeB
proposed_end_timeB
approved_end_timeB
proposed_spending_limitB
approved_spending_limitB
_idB
_billing_setupB
_account_budgetB
_proposed_nameB
_approved_start_date_timeB!
_proposed_purchase_order_numberB
_proposed_notesB
_creation_date_timeB
_approval_date_timeB�
%com.google.ads.googleads.v6.resourcesBAccountBudgetProposalProtoPZJgoogle.golang.org/genproto/googleapis/ads/googleads/v6/resources;resources�GAA�!Google.Ads.GoogleAds.V6.Resources�!Google\\Ads\\GoogleAds\\V6\\Resources�%Google::Ads::GoogleAds::V6::Resourcesbproto3
�
Fgoogle/ads/googleads/v6/services/account_budget_proposal_service.proto google.ads.googleads.v6.servicesgoogle/api/annotations.protogoogle/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto google/protobuf/field_mask.proto"p
GetAccountBudgetProposalRequestM
resource_name (	B6�A�A0
.googleads.googleapis.com/AccountBudgetProposal"�
"MutateAccountBudgetProposalRequest
customer_id (	B�AX
	operation (2@.google.ads.googleads.v6.services.AccountBudgetProposalOperationB�A
validate_only ("�
AccountBudgetProposalOperation/
update_mask (2.google.protobuf.FieldMaskJ
create (28.google.ads.googleads.v6.resources.AccountBudgetProposalH 
remove (	H B
	operation"z
#MutateAccountBudgetProposalResponseS
result (2C.google.ads.googleads.v6.services.MutateAccountBudgetProposalResult":
!MutateAccountBudgetProposalResult
resource_name (	2�
AccountBudgetProposalService�
GetAccountBudgetProposalA.google.ads.googleads.v6.services.GetAccountBudgetProposalRequest8.google.ads.googleads.v6.resources.AccountBudgetProposal"P���:8/v6/{resource_name=customers/*/accountBudgetProposals/*}�Aresource_name�
MutateAccountBudgetProposalD.google.ads.googleads.v6.services.MutateAccountBudgetProposalRequestE.google.ads.googleads.v6.services.MutateAccountBudgetProposalResponse"^���@";/v6/customers/{customer_id=*}/accountBudgetProposals:mutate:*�Acustomer_id,operationE�Agoogleads.googleapis.com�A\'https://www.googleapis.com/auth/adwordsB�
$com.google.ads.googleads.v6.servicesB!AccountBudgetProposalServiceProtoPZHgoogle.golang.org/genproto/googleapis/ads/googleads/v6/services;services�GAA� Google.Ads.GoogleAds.V6.Services� Google\\Ads\\GoogleAds\\V6\\Services�$Google::Ads::GoogleAds::V6::Servicesbproto3'
        , true);
        static::$is_initialized = true;
    }
}

