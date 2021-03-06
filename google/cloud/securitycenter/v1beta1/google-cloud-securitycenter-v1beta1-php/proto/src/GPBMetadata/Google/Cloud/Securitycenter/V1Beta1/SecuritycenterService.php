<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/securitycenter/v1beta1/securitycenter_service.proto

namespace GPBMetadata\Google\Cloud\Securitycenter\V1Beta1;

class SecuritycenterService
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();

        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Api\Annotations::initOnce();
        \GPBMetadata\Google\Api\Client::initOnce();
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        \GPBMetadata\Google\Api\Resource::initOnce();
        \GPBMetadata\Google\Cloud\Securitycenter\V1Beta1\Asset::initOnce();
        \GPBMetadata\Google\Cloud\Securitycenter\V1Beta1\Finding::initOnce();
        \GPBMetadata\Google\Cloud\Securitycenter\V1Beta1\OrganizationSettings::initOnce();
        \GPBMetadata\Google\Cloud\Securitycenter\V1Beta1\SecurityMarks::initOnce();
        \GPBMetadata\Google\Cloud\Securitycenter\V1Beta1\Source::initOnce();
        \GPBMetadata\Google\Iam\V1\IamPolicy::initOnce();
        \GPBMetadata\Google\Iam\V1\Policy::initOnce();
        \GPBMetadata\Google\Longrunning\Operations::initOnce();
        \GPBMetadata\Google\Protobuf\Duration::initOnce();
        \GPBMetadata\Google\Protobuf\GPBEmpty::initOnce();
        \GPBMetadata\Google\Protobuf\FieldMask::initOnce();
        \GPBMetadata\Google\Protobuf\Struct::initOnce();
        \GPBMetadata\Google\Protobuf\Timestamp::initOnce();
        $pool->internalAddGeneratedFile(
            '
�D
@google/cloud/securitycenter/v1beta1/securitycenter_service.proto#google.cloud.securitycenter.v1beta1google/api/client.protogoogle/api/field_behavior.protogoogle/api/resource.proto/google/cloud/securitycenter/v1beta1/asset.proto1google/cloud/securitycenter/v1beta1/finding.proto?google/cloud/securitycenter/v1beta1/organization_settings.proto8google/cloud/securitycenter/v1beta1/security_marks.proto0google/cloud/securitycenter/v1beta1/source.protogoogle/iam/v1/iam_policy.protogoogle/iam/v1/policy.proto#google/longrunning/operations.protogoogle/protobuf/duration.protogoogle/protobuf/empty.proto google/protobuf/field_mask.protogoogle/protobuf/struct.protogoogle/protobuf/timestamp.proto"�
CreateFindingRequest<
parent (	B,�A�A&
$securitycenter.googleapis.com/Source

finding_id (	B�AB
finding (2,.google.cloud.securitycenter.v1beta1.FindingB�A"�
CreateSourceRequestH
parent (	B8�A�A2
0cloudresourcemanager.googleapis.com/Organization@
source (2+.google.cloud.securitycenter.v1beta1.SourceB�A"j
GetOrganizationSettingsRequestH
name (	B:�A�A4
2securitycenter.googleapis.com/OrganizationSettings"N
GetSourceRequest:
name (	B,�A�A&
$securitycenter.googleapis.com/Source"�
GroupAssetsRequestH
parent (	B8�A�A2
0cloudresourcemanager.googleapis.com/Organization
filter (	
group_by (	B�A3
compare_duration (2.google.protobuf.Duration-
	read_time (2.google.protobuf.Timestamp

page_token (	
	page_size ("�
GroupAssetsResponseJ
group_by_results (20.google.cloud.securitycenter.v1beta1.GroupResult-
	read_time (2.google.protobuf.Timestamp
next_page_token (	"�
GroupFindingsRequest<
parent (	B,�A�A&
$securitycenter.googleapis.com/Source
filter (	
group_by (	B�A-
	read_time (2.google.protobuf.Timestamp

page_token (	
	page_size ("�
GroupFindingsResponseJ
group_by_results (20.google.cloud.securitycenter.v1beta1.GroupResult-
	read_time (2.google.protobuf.Timestamp
next_page_token (	"�
GroupResultT

properties (2@.google.cloud.securitycenter.v1beta1.GroupResult.PropertiesEntry
count (I
PropertiesEntry
key (	%
value (2.google.protobuf.Value:8"�
ListSourcesRequestH
parent (	B8�A�A2
0cloudresourcemanager.googleapis.com/Organization

page_token (	
	page_size ("l
ListSourcesResponse<
sources (2+.google.cloud.securitycenter.v1beta1.Source
next_page_token (	"�
ListAssetsRequestH
parent (	B8�A�A2
0cloudresourcemanager.googleapis.com/Organization
filter (	
order_by (	-
	read_time (2.google.protobuf.Timestamp3
compare_duration (2.google.protobuf.Duration3

field_mask (2.google.protobuf.FieldMaskB�A

page_token (	
	page_size	 ("�
ListAssetsResponsee
list_assets_results (2H.google.cloud.securitycenter.v1beta1.ListAssetsResponse.ListAssetsResult-
	read_time (2.google.protobuf.Timestamp
next_page_token (	

total_size (�
ListAssetsResult9
asset (2*.google.cloud.securitycenter.v1beta1.Asset]
state (2N.google.cloud.securitycenter.v1beta1.ListAssetsResponse.ListAssetsResult.State"N
State
STATE_UNSPECIFIED 

UNUSED	
ADDED
REMOVED

ACTIVE"�
ListFindingsRequest<
parent (	B,�A�A&
$securitycenter.googleapis.com/Source
filter (	
order_by (	-
	read_time (2.google.protobuf.Timestamp3

field_mask (2.google.protobuf.FieldMaskB�A

page_token (	
	page_size ("�
ListFindingsResponse>
findings (2,.google.cloud.securitycenter.v1beta1.Finding-
	read_time (2.google.protobuf.Timestamp
next_page_token (	

total_size ("�
SetFindingStateRequest;
name (	B-�A�A\'
%securitycenter.googleapis.com/FindingF
state (22.google.cloud.securitycenter.v1beta1.Finding.StateB�A3

start_time (2.google.protobuf.TimestampB�A"d
RunAssetDiscoveryRequestH
parent (	B8�A�A2
0cloudresourcemanager.googleapis.com/Organization"�
UpdateFindingRequestB
finding (2,.google.cloud.securitycenter.v1beta1.FindingB�A/
update_mask (2.google.protobuf.FieldMask"�
!UpdateOrganizationSettingsRequest]
organization_settings (29.google.cloud.securitycenter.v1beta1.OrganizationSettingsB�A/
update_mask (2.google.protobuf.FieldMask"�
UpdateSourceRequest@
source (2+.google.cloud.securitycenter.v1beta1.SourceB�A/
update_mask (2.google.protobuf.FieldMask"�
UpdateSecurityMarksRequestO
security_marks (22.google.cloud.securitycenter.v1beta1.SecurityMarksB�A/
update_mask (2.google.protobuf.FieldMask.

start_time (2.google.protobuf.Timestamp2�
SecurityCenter�
CreateSource8.google.cloud.securitycenter.v1beta1.CreateSourceRequest+.google.cloud.securitycenter.v1beta1.Source"I���3")/v1beta1/{parent=organizations/*}/sources:source�Aparent,source�
CreateFinding9.google.cloud.securitycenter.v1beta1.CreateFindingRequest,.google.cloud.securitycenter.v1beta1.Finding"a���?"4/v1beta1/{parent=organizations/*/sources/*}/findings:finding�Aparent,finding_id,finding�
GetIamPolicy".google.iam.v1.GetIamPolicyRequest.google.iam.v1.Policy"P���?":/v1beta1/{resource=organizations/*/sources/*}:getIamPolicy:*�Aresource�
GetOrganizationSettingsC.google.cloud.securitycenter.v1beta1.GetOrganizationSettingsRequest9.google.cloud.securitycenter.v1beta1.OrganizationSettings"C���64/v1beta1/{name=organizations/*/organizationSettings}�Aname�
	GetSource5.google.cloud.securitycenter.v1beta1.GetSourceRequest+.google.cloud.securitycenter.v1beta1.Source"8���+)/v1beta1/{name=organizations/*/sources/*}�Aname�
GroupAssets7.google.cloud.securitycenter.v1beta1.GroupAssetsRequest8.google.cloud.securitycenter.v1beta1.GroupAssetsResponse"9���3"./v1beta1/{parent=organizations/*}/assets:group:*�
GroupFindings9.google.cloud.securitycenter.v1beta1.GroupFindingsRequest:.google.cloud.securitycenter.v1beta1.GroupFindingsResponse"W���?":/v1beta1/{parent=organizations/*/sources/*}/findings:group:*�Aparent,group_by�

ListAssets6.google.cloud.securitycenter.v1beta1.ListAssetsRequest7.google.cloud.securitycenter.v1beta1.ListAssetsResponse"0���*(/v1beta1/{parent=organizations/*}/assets�
ListFindings8.google.cloud.securitycenter.v1beta1.ListFindingsRequest9.google.cloud.securitycenter.v1beta1.ListFindingsResponse"<���64/v1beta1/{parent=organizations/*/sources/*}/findings�
ListSources7.google.cloud.securitycenter.v1beta1.ListSourcesRequest8.google.cloud.securitycenter.v1beta1.ListSourcesResponse":���+)/v1beta1/{parent=organizations/*}/sources�Aparent�
RunAssetDiscovery=.google.cloud.securitycenter.v1beta1.RunAssetDiscoveryRequest.google.longrunning.Operation"z���:"5/v1beta1/{parent=organizations/*}/assets:runDiscovery:*�Aparent�A.
google.protobuf.Emptygoogle.protobuf.Empty�
SetFindingState;.google.cloud.securitycenter.v1beta1.SetFindingStateRequest,.google.cloud.securitycenter.v1beta1.Finding"`���B"=/v1beta1/{name=organizations/*/sources/*/findings/*}:setState:*�Aname,state,start_time�
SetIamPolicy".google.iam.v1.SetIamPolicyRequest.google.iam.v1.Policy"W���?":/v1beta1/{resource=organizations/*/sources/*}:setIamPolicy:*�Aresource,policy�
TestIamPermissions(.google.iam.v1.TestIamPermissionsRequest).google.iam.v1.TestIamPermissionsResponse"b���E"@/v1beta1/{resource=organizations/*/sources/*}:testIamPermissions:*�Aresource,permissions�
UpdateFinding9.google.cloud.securitycenter.v1beta1.UpdateFindingRequest,.google.cloud.securitycenter.v1beta1.Finding"W���G2</v1beta1/{finding.name=organizations/*/sources/*/findings/*}:finding�Afinding�
UpdateOrganizationSettingsF.google.cloud.securitycenter.v1beta1.UpdateOrganizationSettingsRequest9.google.cloud.securitycenter.v1beta1.OrganizationSettings"����c2J/v1beta1/{organization_settings.name=organizations/*/organizationSettings}:organization_settings�Aorganization_settings�
UpdateSource8.google.cloud.securitycenter.v1beta1.UpdateSourceRequest+.google.cloud.securitycenter.v1beta1.Source"I���:20/v1beta1/{source.name=organizations/*/sources/*}:source�Asource�
UpdateSecurityMarks?.google.cloud.securitycenter.v1beta1.UpdateSecurityMarksRequest2.google.cloud.securitycenter.v1beta1.SecurityMarks"�����2E/v1beta1/{security_marks.name=organizations/*/assets/*/securityMarks}:security_marksZc2Q/v1beta1/{security_marks.name=organizations/*/sources/*/findings/*/securityMarks}:security_marks�Asecurity_marksQ�Asecuritycenter.googleapis.com�A.https://www.googleapis.com/auth/cloud-platformB~
\'com.google.cloud.securitycenter.v1beta1PZQgoogle.golang.org/genproto/googleapis/cloud/securitycenter/v1beta1;securitycenterbproto3'
        , true);

        static::$is_initialized = true;
    }
}

