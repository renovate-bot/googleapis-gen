<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/networkservices/v1beta1/network_services.proto

namespace GPBMetadata\Google\Cloud\Networkservices\V1Beta1;

class NetworkServices
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();

        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Api\Annotations::initOnce();
        \GPBMetadata\Google\Api\Client::initOnce();
        \GPBMetadata\Google\Cloud\Networkservices\V1Beta1\EndpointPolicy::initOnce();
        \GPBMetadata\Google\Longrunning\Operations::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
;google/cloud/networkservices/v1beta1/network_services.proto$google.cloud.networkservices.v1beta1google/api/client.proto:google/cloud/networkservices/v1beta1/endpoint_policy.proto#google/longrunning/operations.proto2�
NetworkServices�
ListEndpointPoliciesA.google.cloud.networkservices.v1beta1.ListEndpointPoliciesRequestB.google.cloud.networkservices.v1beta1.ListEndpointPoliciesResponse"J���;9/v1beta1/{parent=projects/*/locations/*}/endpointPolicies�Aparent�
GetEndpointPolicy>.google.cloud.networkservices.v1beta1.GetEndpointPolicyRequest4.google.cloud.networkservices.v1beta1.EndpointPolicy"H���;9/v1beta1/{name=projects/*/locations/*/endpointPolicies/*}�Aname�
CreateEndpointPolicyA.google.cloud.networkservices.v1beta1.CreateEndpointPolicyRequest.google.longrunning.Operation"����L"9/v1beta1/{parent=projects/*/locations/*}/endpointPolicies:endpoint_policy�A)parent,endpoint_policy,endpoint_policy_id�AH
EndpointPolicy6google.cloud.networkservices.v1beta1.OperationMetadata�
UpdateEndpointPolicyA.google.cloud.networkservices.v1beta1.UpdateEndpointPolicyRequest.google.longrunning.Operation"����\\2I/v1beta1/{endpoint_policy.name=projects/*/locations/*/endpointPolicies/*}:endpoint_policy�Aendpoint_policy,update_mask�AH
EndpointPolicy6google.cloud.networkservices.v1beta1.OperationMetadata�
DeleteEndpointPolicyA.google.cloud.networkservices.v1beta1.DeleteEndpointPolicyRequest.google.longrunning.Operation"����;*9/v1beta1/{name=projects/*/locations/*/endpointPolicies/*}�Aname�AO
google.protobuf.Empty6google.cloud.networkservices.v1beta1.OperationMetadataR�Anetworkservices.googleapis.com�A.https://www.googleapis.com/auth/cloud-platformB�
(com.google.cloud.networkservices.v1beta1PZSgoogle.golang.org/genproto/googleapis/cloud/networkservices/v1beta1;networkservices�$Google.Cloud.NetworkServices.V1Beta1�$Google\\Cloud\\NetworkServices\\V1beta1�\'Google::Cloud::NetworkServices::V1beta1bproto3'
        , true);

        static::$is_initialized = true;
    }
}

