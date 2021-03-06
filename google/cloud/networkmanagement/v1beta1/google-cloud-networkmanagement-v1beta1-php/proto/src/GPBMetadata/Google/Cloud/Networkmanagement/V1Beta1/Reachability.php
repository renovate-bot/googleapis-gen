<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/networkmanagement/v1beta1/reachability.proto

namespace GPBMetadata\Google\Cloud\Networkmanagement\V1Beta1;

class Reachability
{
    public static $is_initialized = false;

    public static function initOnce() {
        $pool = \Google\Protobuf\Internal\DescriptorPool::getGeneratedPool();

        if (static::$is_initialized == true) {
          return;
        }
        \GPBMetadata\Google\Api\Annotations::initOnce();
        \GPBMetadata\Google\Api\FieldBehavior::initOnce();
        \GPBMetadata\Google\Api\Resource::initOnce();
        \GPBMetadata\Google\Cloud\Networkmanagement\V1Beta1\ConnectivityTest::initOnce();
        \GPBMetadata\Google\Longrunning\Operations::initOnce();
        \GPBMetadata\Google\Protobuf\FieldMask::initOnce();
        \GPBMetadata\Google\Protobuf\Timestamp::initOnce();
        \GPBMetadata\Google\Api\Client::initOnce();
        $pool->internalAddGeneratedFile(
            '
�
9google/cloud/networkmanagement/v1beta1/reachability.proto&google.cloud.networkmanagement.v1beta1google/api/field_behavior.protogoogle/api/resource.proto>google/cloud/networkmanagement/v1beta1/connectivity_test.proto#google/longrunning/operations.proto google/protobuf/field_mask.protogoogle/protobuf/timestamp.protogoogle/api/client.proto"|
ListConnectivityTestsRequest
parent (	B�A
	page_size (

page_token (	
filter (	
order_by (	"�
ListConnectivityTestsResponseK
	resources (28.google.cloud.networkmanagement.v1beta1.ConnectivityTest
next_page_token (	
unreachable (	"/
GetConnectivityTestRequest
name (	B�A"�
CreateConnectivityTestRequest
parent (	B�A
test_id (	B�AO
resource (28.google.cloud.networkmanagement.v1beta1.ConnectivityTestB�A"�
UpdateConnectivityTestRequest4
update_mask (2.google.protobuf.FieldMaskB�AO
resource (28.google.cloud.networkmanagement.v1beta1.ConnectivityTestB�A"2
DeleteConnectivityTestRequest
name (	B�A"1
RerunConnectivityTestRequest
name (	B�A"�
OperationMetadata/
create_time (2.google.protobuf.Timestamp,
end_time (2.google.protobuf.Timestamp
target (	
verb (	
status_detail (	
cancel_requested (
api_version (	2�
ReachabilityService�
ListConnectivityTestsD.google.cloud.networkmanagement.v1beta1.ListConnectivityTestsRequestE.google.cloud.networkmanagement.v1beta1.ListConnectivityTestsResponse"G���A?/v1beta1/{parent=projects/*/locations/global}/connectivityTests�
GetConnectivityTestB.google.cloud.networkmanagement.v1beta1.GetConnectivityTestRequest8.google.cloud.networkmanagement.v1beta1.ConnectivityTest"G���A?/v1beta1/{name=projects/*/locations/global/connectivityTests/*}�
CreateConnectivityTestE.google.cloud.networkmanagement.v1beta1.CreateConnectivityTestRequest.google.longrunning.Operation"����K"?/v1beta1/{parent=projects/*/locations/global}/connectivityTests:resource�AL
7google.cloud.networkmanagement.v1beta1.ConnectivityTestOperationMetadata�
UpdateConnectivityTestE.google.cloud.networkmanagement.v1beta1.UpdateConnectivityTestRequest.google.longrunning.Operation"����T2H/v1beta1/{resource.name=projects/*/locations/global/connectivityTests/*}:resource�AL
7google.cloud.networkmanagement.v1beta1.ConnectivityTestOperationMetadata�
RerunConnectivityTestD.google.cloud.networkmanagement.v1beta1.RerunConnectivityTestRequest.google.longrunning.Operation"����J"E/v1beta1/{name=projects/*/locations/global/connectivityTests/*}:rerun:*�AL
7google.cloud.networkmanagement.v1beta1.ConnectivityTestOperationMetadata�
DeleteConnectivityTestE.google.cloud.networkmanagement.v1beta1.DeleteConnectivityTestRequest.google.longrunning.Operation"t���A*?/v1beta1/{name=projects/*/locations/global/connectivityTests/*}�A*
google.protobuf.EmptyOperationMetadataT�A networkmanagement.googleapis.com�A.https://www.googleapis.com/auth/cloud-platformB�
*com.google.cloud.networkmanagement.v1beta1BReachabilityServiceProtoPZWgoogle.golang.org/genproto/googleapis/cloud/networkmanagement/v1beta1;networkmanagement�&Google.Cloud.NetworkManagement.V1Beta1�&Google\\Cloud\\NetworkManagement\\V1beta1�)Google::Cloud::NetworkManagement::V1beta1bproto3'
        , true);

        static::$is_initialized = true;
    }
}

