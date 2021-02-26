// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Code generated by protoc-gen-go. DO NOT EDIT.
// versions:
// 	protoc-gen-go v1.25.0
// 	protoc        v3.15.3
// source: google/cloud/asset/v1p1beta1/asset_service.proto

package asset

import (
	context "context"
	proto "github.com/golang/protobuf/proto"
	_ "google.golang.org/genproto/googleapis/api/annotations"
	grpc "google.golang.org/grpc"
	codes "google.golang.org/grpc/codes"
	status "google.golang.org/grpc/status"
	protoreflect "google.golang.org/protobuf/reflect/protoreflect"
	protoimpl "google.golang.org/protobuf/runtime/protoimpl"
	reflect "reflect"
	sync "sync"
)

const (
	// Verify that this generated code is sufficiently up-to-date.
	_ = protoimpl.EnforceVersion(20 - protoimpl.MinVersion)
	// Verify that runtime/protoimpl is sufficiently up-to-date.
	_ = protoimpl.EnforceVersion(protoimpl.MaxVersion - 20)
)

// This is a compile-time assertion that a sufficiently up-to-date version
// of the legacy proto package is being used.
const _ = proto.ProtoPackageIsVersion4

// Search all resources request.
type SearchAllResourcesRequest struct {
	state         protoimpl.MessageState
	sizeCache     protoimpl.SizeCache
	unknownFields protoimpl.UnknownFields

	// Required. The relative name of an asset. The search is limited to the resources
	// within the `scope`. The allowed value must be:
	// * Organization number (such as "organizations/123")
	// * Folder number(such as "folders/1234")
	// * Project number (such as "projects/12345")
	// * Project id (such as "projects/abc")
	Scope string `protobuf:"bytes,1,opt,name=scope,proto3" json:"scope,omitempty"`
	// Optional. The query statement.
	Query string `protobuf:"bytes,2,opt,name=query,proto3" json:"query,omitempty"`
	// Optional. A list of asset types that this request searches for. If empty, it will
	// search all the supported asset types.
	AssetTypes []string `protobuf:"bytes,3,rep,name=asset_types,json=assetTypes,proto3" json:"asset_types,omitempty"`
	// Optional. The page size for search result pagination. Page size is capped at 500 even
	// if a larger value is given. If set to zero, server will pick an appropriate
	// default. Returned results may be fewer than requested. When this happens,
	// there could be more results as long as `next_page_token` is returned.
	PageSize int32 `protobuf:"varint,4,opt,name=page_size,json=pageSize,proto3" json:"page_size,omitempty"`
	// Optional. If present, then retrieve the next batch of results from the preceding call
	// to this method.  `page_token` must be the value of `next_page_token` from
	// the previous response. The values of all other method parameters, must be
	// identical to those in the previous call.
	PageToken string `protobuf:"bytes,5,opt,name=page_token,json=pageToken,proto3" json:"page_token,omitempty"`
	// Optional. A comma separated list of fields specifying the sorting order of the
	// results. The default order is ascending. Add " desc" after the field name
	// to indicate descending order. Redundant space characters are ignored. For
	// example, "  foo ,  bar  desc  ".
	OrderBy string `protobuf:"bytes,10,opt,name=order_by,json=orderBy,proto3" json:"order_by,omitempty"`
}

func (x *SearchAllResourcesRequest) Reset() {
	*x = SearchAllResourcesRequest{}
	if protoimpl.UnsafeEnabled {
		mi := &file_google_cloud_asset_v1p1beta1_asset_service_proto_msgTypes[0]
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		ms.StoreMessageInfo(mi)
	}
}

func (x *SearchAllResourcesRequest) String() string {
	return protoimpl.X.MessageStringOf(x)
}

func (*SearchAllResourcesRequest) ProtoMessage() {}

func (x *SearchAllResourcesRequest) ProtoReflect() protoreflect.Message {
	mi := &file_google_cloud_asset_v1p1beta1_asset_service_proto_msgTypes[0]
	if protoimpl.UnsafeEnabled && x != nil {
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		if ms.LoadMessageInfo() == nil {
			ms.StoreMessageInfo(mi)
		}
		return ms
	}
	return mi.MessageOf(x)
}

// Deprecated: Use SearchAllResourcesRequest.ProtoReflect.Descriptor instead.
func (*SearchAllResourcesRequest) Descriptor() ([]byte, []int) {
	return file_google_cloud_asset_v1p1beta1_asset_service_proto_rawDescGZIP(), []int{0}
}

func (x *SearchAllResourcesRequest) GetScope() string {
	if x != nil {
		return x.Scope
	}
	return ""
}

func (x *SearchAllResourcesRequest) GetQuery() string {
	if x != nil {
		return x.Query
	}
	return ""
}

func (x *SearchAllResourcesRequest) GetAssetTypes() []string {
	if x != nil {
		return x.AssetTypes
	}
	return nil
}

func (x *SearchAllResourcesRequest) GetPageSize() int32 {
	if x != nil {
		return x.PageSize
	}
	return 0
}

func (x *SearchAllResourcesRequest) GetPageToken() string {
	if x != nil {
		return x.PageToken
	}
	return ""
}

func (x *SearchAllResourcesRequest) GetOrderBy() string {
	if x != nil {
		return x.OrderBy
	}
	return ""
}

// Search all resources response.
type SearchAllResourcesResponse struct {
	state         protoimpl.MessageState
	sizeCache     protoimpl.SizeCache
	unknownFields protoimpl.UnknownFields

	// A list of resource that match the search query.
	Results []*StandardResourceMetadata `protobuf:"bytes,1,rep,name=results,proto3" json:"results,omitempty"`
	// If there are more results than those appearing in this response, then
	// `next_page_token` is included.  To get the next set of results, call this
	// method again using the value of `next_page_token` as `page_token`.
	NextPageToken string `protobuf:"bytes,2,opt,name=next_page_token,json=nextPageToken,proto3" json:"next_page_token,omitempty"`
}

func (x *SearchAllResourcesResponse) Reset() {
	*x = SearchAllResourcesResponse{}
	if protoimpl.UnsafeEnabled {
		mi := &file_google_cloud_asset_v1p1beta1_asset_service_proto_msgTypes[1]
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		ms.StoreMessageInfo(mi)
	}
}

func (x *SearchAllResourcesResponse) String() string {
	return protoimpl.X.MessageStringOf(x)
}

func (*SearchAllResourcesResponse) ProtoMessage() {}

func (x *SearchAllResourcesResponse) ProtoReflect() protoreflect.Message {
	mi := &file_google_cloud_asset_v1p1beta1_asset_service_proto_msgTypes[1]
	if protoimpl.UnsafeEnabled && x != nil {
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		if ms.LoadMessageInfo() == nil {
			ms.StoreMessageInfo(mi)
		}
		return ms
	}
	return mi.MessageOf(x)
}

// Deprecated: Use SearchAllResourcesResponse.ProtoReflect.Descriptor instead.
func (*SearchAllResourcesResponse) Descriptor() ([]byte, []int) {
	return file_google_cloud_asset_v1p1beta1_asset_service_proto_rawDescGZIP(), []int{1}
}

func (x *SearchAllResourcesResponse) GetResults() []*StandardResourceMetadata {
	if x != nil {
		return x.Results
	}
	return nil
}

func (x *SearchAllResourcesResponse) GetNextPageToken() string {
	if x != nil {
		return x.NextPageToken
	}
	return ""
}

// Search all IAM policies request.
type SearchAllIamPoliciesRequest struct {
	state         protoimpl.MessageState
	sizeCache     protoimpl.SizeCache
	unknownFields protoimpl.UnknownFields

	// Required. The relative name of an asset. The search is limited to the resources
	// within the `scope`. The allowed value must be:
	// * Organization number (such as "organizations/123")
	// * Folder number(such as "folders/1234")
	// * Project number (such as "projects/12345")
	// * Project id (such as "projects/abc")
	Scope string `protobuf:"bytes,1,opt,name=scope,proto3" json:"scope,omitempty"`
	// Optional. The query statement.
	// Examples:
	// * "policy:myuser@mydomain.com"
	// * "policy:(myuser@mydomain.com viewer)"
	Query string `protobuf:"bytes,2,opt,name=query,proto3" json:"query,omitempty"`
	// Optional. The page size for search result pagination. Page size is capped at 500 even
	// if a larger value is given. If set to zero, server will pick an appropriate
	// default. Returned results may be fewer than requested. When this happens,
	// there could be more results as long as `next_page_token` is returned.
	PageSize int32 `protobuf:"varint,3,opt,name=page_size,json=pageSize,proto3" json:"page_size,omitempty"`
	// Optional. If present, retrieve the next batch of results from the preceding call to
	// this method. `page_token` must be the value of `next_page_token` from the
	// previous response. The values of all other method parameters must be
	// identical to those in the previous call.
	PageToken string `protobuf:"bytes,4,opt,name=page_token,json=pageToken,proto3" json:"page_token,omitempty"`
}

func (x *SearchAllIamPoliciesRequest) Reset() {
	*x = SearchAllIamPoliciesRequest{}
	if protoimpl.UnsafeEnabled {
		mi := &file_google_cloud_asset_v1p1beta1_asset_service_proto_msgTypes[2]
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		ms.StoreMessageInfo(mi)
	}
}

func (x *SearchAllIamPoliciesRequest) String() string {
	return protoimpl.X.MessageStringOf(x)
}

func (*SearchAllIamPoliciesRequest) ProtoMessage() {}

func (x *SearchAllIamPoliciesRequest) ProtoReflect() protoreflect.Message {
	mi := &file_google_cloud_asset_v1p1beta1_asset_service_proto_msgTypes[2]
	if protoimpl.UnsafeEnabled && x != nil {
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		if ms.LoadMessageInfo() == nil {
			ms.StoreMessageInfo(mi)
		}
		return ms
	}
	return mi.MessageOf(x)
}

// Deprecated: Use SearchAllIamPoliciesRequest.ProtoReflect.Descriptor instead.
func (*SearchAllIamPoliciesRequest) Descriptor() ([]byte, []int) {
	return file_google_cloud_asset_v1p1beta1_asset_service_proto_rawDescGZIP(), []int{2}
}

func (x *SearchAllIamPoliciesRequest) GetScope() string {
	if x != nil {
		return x.Scope
	}
	return ""
}

func (x *SearchAllIamPoliciesRequest) GetQuery() string {
	if x != nil {
		return x.Query
	}
	return ""
}

func (x *SearchAllIamPoliciesRequest) GetPageSize() int32 {
	if x != nil {
		return x.PageSize
	}
	return 0
}

func (x *SearchAllIamPoliciesRequest) GetPageToken() string {
	if x != nil {
		return x.PageToken
	}
	return ""
}

// Search all IAM policies response.
type SearchAllIamPoliciesResponse struct {
	state         protoimpl.MessageState
	sizeCache     protoimpl.SizeCache
	unknownFields protoimpl.UnknownFields

	// A list of IamPolicy that match the search query. Related information such
	// as the associated resource is returned along with the policy.
	Results []*IamPolicySearchResult `protobuf:"bytes,1,rep,name=results,proto3" json:"results,omitempty"`
	// Set if there are more results than those appearing in this response; to get
	// the next set of results, call this method again, using this value as the
	// `page_token`.
	NextPageToken string `protobuf:"bytes,2,opt,name=next_page_token,json=nextPageToken,proto3" json:"next_page_token,omitempty"`
}

func (x *SearchAllIamPoliciesResponse) Reset() {
	*x = SearchAllIamPoliciesResponse{}
	if protoimpl.UnsafeEnabled {
		mi := &file_google_cloud_asset_v1p1beta1_asset_service_proto_msgTypes[3]
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		ms.StoreMessageInfo(mi)
	}
}

func (x *SearchAllIamPoliciesResponse) String() string {
	return protoimpl.X.MessageStringOf(x)
}

func (*SearchAllIamPoliciesResponse) ProtoMessage() {}

func (x *SearchAllIamPoliciesResponse) ProtoReflect() protoreflect.Message {
	mi := &file_google_cloud_asset_v1p1beta1_asset_service_proto_msgTypes[3]
	if protoimpl.UnsafeEnabled && x != nil {
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		if ms.LoadMessageInfo() == nil {
			ms.StoreMessageInfo(mi)
		}
		return ms
	}
	return mi.MessageOf(x)
}

// Deprecated: Use SearchAllIamPoliciesResponse.ProtoReflect.Descriptor instead.
func (*SearchAllIamPoliciesResponse) Descriptor() ([]byte, []int) {
	return file_google_cloud_asset_v1p1beta1_asset_service_proto_rawDescGZIP(), []int{3}
}

func (x *SearchAllIamPoliciesResponse) GetResults() []*IamPolicySearchResult {
	if x != nil {
		return x.Results
	}
	return nil
}

func (x *SearchAllIamPoliciesResponse) GetNextPageToken() string {
	if x != nil {
		return x.NextPageToken
	}
	return ""
}

var File_google_cloud_asset_v1p1beta1_asset_service_proto protoreflect.FileDescriptor

var file_google_cloud_asset_v1p1beta1_asset_service_proto_rawDesc = []byte{
	0x0a, 0x30, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2f, 0x63, 0x6c, 0x6f, 0x75, 0x64, 0x2f, 0x61,
	0x73, 0x73, 0x65, 0x74, 0x2f, 0x76, 0x31, 0x70, 0x31, 0x62, 0x65, 0x74, 0x61, 0x31, 0x2f, 0x61,
	0x73, 0x73, 0x65, 0x74, 0x5f, 0x73, 0x65, 0x72, 0x76, 0x69, 0x63, 0x65, 0x2e, 0x70, 0x72, 0x6f,
	0x74, 0x6f, 0x12, 0x1c, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2e, 0x63, 0x6c, 0x6f, 0x75, 0x64,
	0x2e, 0x61, 0x73, 0x73, 0x65, 0x74, 0x2e, 0x76, 0x31, 0x70, 0x31, 0x62, 0x65, 0x74, 0x61, 0x31,
	0x1a, 0x1c, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2f, 0x61, 0x70, 0x69, 0x2f, 0x61, 0x6e, 0x6e,
	0x6f, 0x74, 0x61, 0x74, 0x69, 0x6f, 0x6e, 0x73, 0x2e, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x1a, 0x17,
	0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2f, 0x61, 0x70, 0x69, 0x2f, 0x63, 0x6c, 0x69, 0x65, 0x6e,
	0x74, 0x2e, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x1a, 0x1f, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2f,
	0x61, 0x70, 0x69, 0x2f, 0x66, 0x69, 0x65, 0x6c, 0x64, 0x5f, 0x62, 0x65, 0x68, 0x61, 0x76, 0x69,
	0x6f, 0x72, 0x2e, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x1a, 0x29, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65,
	0x2f, 0x63, 0x6c, 0x6f, 0x75, 0x64, 0x2f, 0x61, 0x73, 0x73, 0x65, 0x74, 0x2f, 0x76, 0x31, 0x70,
	0x31, 0x62, 0x65, 0x74, 0x61, 0x31, 0x2f, 0x61, 0x73, 0x73, 0x65, 0x74, 0x73, 0x2e, 0x70, 0x72,
	0x6f, 0x74, 0x6f, 0x22, 0xdd, 0x01, 0x0a, 0x19, 0x53, 0x65, 0x61, 0x72, 0x63, 0x68, 0x41, 0x6c,
	0x6c, 0x52, 0x65, 0x73, 0x6f, 0x75, 0x72, 0x63, 0x65, 0x73, 0x52, 0x65, 0x71, 0x75, 0x65, 0x73,
	0x74, 0x12, 0x19, 0x0a, 0x05, 0x73, 0x63, 0x6f, 0x70, 0x65, 0x18, 0x01, 0x20, 0x01, 0x28, 0x09,
	0x42, 0x03, 0xe0, 0x41, 0x02, 0x52, 0x05, 0x73, 0x63, 0x6f, 0x70, 0x65, 0x12, 0x19, 0x0a, 0x05,
	0x71, 0x75, 0x65, 0x72, 0x79, 0x18, 0x02, 0x20, 0x01, 0x28, 0x09, 0x42, 0x03, 0xe0, 0x41, 0x01,
	0x52, 0x05, 0x71, 0x75, 0x65, 0x72, 0x79, 0x12, 0x24, 0x0a, 0x0b, 0x61, 0x73, 0x73, 0x65, 0x74,
	0x5f, 0x74, 0x79, 0x70, 0x65, 0x73, 0x18, 0x03, 0x20, 0x03, 0x28, 0x09, 0x42, 0x03, 0xe0, 0x41,
	0x01, 0x52, 0x0a, 0x61, 0x73, 0x73, 0x65, 0x74, 0x54, 0x79, 0x70, 0x65, 0x73, 0x12, 0x20, 0x0a,
	0x09, 0x70, 0x61, 0x67, 0x65, 0x5f, 0x73, 0x69, 0x7a, 0x65, 0x18, 0x04, 0x20, 0x01, 0x28, 0x05,
	0x42, 0x03, 0xe0, 0x41, 0x01, 0x52, 0x08, 0x70, 0x61, 0x67, 0x65, 0x53, 0x69, 0x7a, 0x65, 0x12,
	0x22, 0x0a, 0x0a, 0x70, 0x61, 0x67, 0x65, 0x5f, 0x74, 0x6f, 0x6b, 0x65, 0x6e, 0x18, 0x05, 0x20,
	0x01, 0x28, 0x09, 0x42, 0x03, 0xe0, 0x41, 0x01, 0x52, 0x09, 0x70, 0x61, 0x67, 0x65, 0x54, 0x6f,
	0x6b, 0x65, 0x6e, 0x12, 0x1e, 0x0a, 0x08, 0x6f, 0x72, 0x64, 0x65, 0x72, 0x5f, 0x62, 0x79, 0x18,
	0x0a, 0x20, 0x01, 0x28, 0x09, 0x42, 0x03, 0xe0, 0x41, 0x01, 0x52, 0x07, 0x6f, 0x72, 0x64, 0x65,
	0x72, 0x42, 0x79, 0x22, 0x96, 0x01, 0x0a, 0x1a, 0x53, 0x65, 0x61, 0x72, 0x63, 0x68, 0x41, 0x6c,
	0x6c, 0x52, 0x65, 0x73, 0x6f, 0x75, 0x72, 0x63, 0x65, 0x73, 0x52, 0x65, 0x73, 0x70, 0x6f, 0x6e,
	0x73, 0x65, 0x12, 0x50, 0x0a, 0x07, 0x72, 0x65, 0x73, 0x75, 0x6c, 0x74, 0x73, 0x18, 0x01, 0x20,
	0x03, 0x28, 0x0b, 0x32, 0x36, 0x2e, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2e, 0x63, 0x6c, 0x6f,
	0x75, 0x64, 0x2e, 0x61, 0x73, 0x73, 0x65, 0x74, 0x2e, 0x76, 0x31, 0x70, 0x31, 0x62, 0x65, 0x74,
	0x61, 0x31, 0x2e, 0x53, 0x74, 0x61, 0x6e, 0x64, 0x61, 0x72, 0x64, 0x52, 0x65, 0x73, 0x6f, 0x75,
	0x72, 0x63, 0x65, 0x4d, 0x65, 0x74, 0x61, 0x64, 0x61, 0x74, 0x61, 0x52, 0x07, 0x72, 0x65, 0x73,
	0x75, 0x6c, 0x74, 0x73, 0x12, 0x26, 0x0a, 0x0f, 0x6e, 0x65, 0x78, 0x74, 0x5f, 0x70, 0x61, 0x67,
	0x65, 0x5f, 0x74, 0x6f, 0x6b, 0x65, 0x6e, 0x18, 0x02, 0x20, 0x01, 0x28, 0x09, 0x52, 0x0d, 0x6e,
	0x65, 0x78, 0x74, 0x50, 0x61, 0x67, 0x65, 0x54, 0x6f, 0x6b, 0x65, 0x6e, 0x22, 0x99, 0x01, 0x0a,
	0x1b, 0x53, 0x65, 0x61, 0x72, 0x63, 0x68, 0x41, 0x6c, 0x6c, 0x49, 0x61, 0x6d, 0x50, 0x6f, 0x6c,
	0x69, 0x63, 0x69, 0x65, 0x73, 0x52, 0x65, 0x71, 0x75, 0x65, 0x73, 0x74, 0x12, 0x19, 0x0a, 0x05,
	0x73, 0x63, 0x6f, 0x70, 0x65, 0x18, 0x01, 0x20, 0x01, 0x28, 0x09, 0x42, 0x03, 0xe0, 0x41, 0x02,
	0x52, 0x05, 0x73, 0x63, 0x6f, 0x70, 0x65, 0x12, 0x19, 0x0a, 0x05, 0x71, 0x75, 0x65, 0x72, 0x79,
	0x18, 0x02, 0x20, 0x01, 0x28, 0x09, 0x42, 0x03, 0xe0, 0x41, 0x01, 0x52, 0x05, 0x71, 0x75, 0x65,
	0x72, 0x79, 0x12, 0x20, 0x0a, 0x09, 0x70, 0x61, 0x67, 0x65, 0x5f, 0x73, 0x69, 0x7a, 0x65, 0x18,
	0x03, 0x20, 0x01, 0x28, 0x05, 0x42, 0x03, 0xe0, 0x41, 0x01, 0x52, 0x08, 0x70, 0x61, 0x67, 0x65,
	0x53, 0x69, 0x7a, 0x65, 0x12, 0x22, 0x0a, 0x0a, 0x70, 0x61, 0x67, 0x65, 0x5f, 0x74, 0x6f, 0x6b,
	0x65, 0x6e, 0x18, 0x04, 0x20, 0x01, 0x28, 0x09, 0x42, 0x03, 0xe0, 0x41, 0x01, 0x52, 0x09, 0x70,
	0x61, 0x67, 0x65, 0x54, 0x6f, 0x6b, 0x65, 0x6e, 0x22, 0x95, 0x01, 0x0a, 0x1c, 0x53, 0x65, 0x61,
	0x72, 0x63, 0x68, 0x41, 0x6c, 0x6c, 0x49, 0x61, 0x6d, 0x50, 0x6f, 0x6c, 0x69, 0x63, 0x69, 0x65,
	0x73, 0x52, 0x65, 0x73, 0x70, 0x6f, 0x6e, 0x73, 0x65, 0x12, 0x4d, 0x0a, 0x07, 0x72, 0x65, 0x73,
	0x75, 0x6c, 0x74, 0x73, 0x18, 0x01, 0x20, 0x03, 0x28, 0x0b, 0x32, 0x33, 0x2e, 0x67, 0x6f, 0x6f,
	0x67, 0x6c, 0x65, 0x2e, 0x63, 0x6c, 0x6f, 0x75, 0x64, 0x2e, 0x61, 0x73, 0x73, 0x65, 0x74, 0x2e,
	0x76, 0x31, 0x70, 0x31, 0x62, 0x65, 0x74, 0x61, 0x31, 0x2e, 0x49, 0x61, 0x6d, 0x50, 0x6f, 0x6c,
	0x69, 0x63, 0x79, 0x53, 0x65, 0x61, 0x72, 0x63, 0x68, 0x52, 0x65, 0x73, 0x75, 0x6c, 0x74, 0x52,
	0x07, 0x72, 0x65, 0x73, 0x75, 0x6c, 0x74, 0x73, 0x12, 0x26, 0x0a, 0x0f, 0x6e, 0x65, 0x78, 0x74,
	0x5f, 0x70, 0x61, 0x67, 0x65, 0x5f, 0x74, 0x6f, 0x6b, 0x65, 0x6e, 0x18, 0x02, 0x20, 0x01, 0x28,
	0x09, 0x52, 0x0d, 0x6e, 0x65, 0x78, 0x74, 0x50, 0x61, 0x67, 0x65, 0x54, 0x6f, 0x6b, 0x65, 0x6e,
	0x32, 0x89, 0x04, 0x0a, 0x0c, 0x41, 0x73, 0x73, 0x65, 0x74, 0x53, 0x65, 0x72, 0x76, 0x69, 0x63,
	0x65, 0x12, 0xd5, 0x01, 0x0a, 0x12, 0x53, 0x65, 0x61, 0x72, 0x63, 0x68, 0x41, 0x6c, 0x6c, 0x52,
	0x65, 0x73, 0x6f, 0x75, 0x72, 0x63, 0x65, 0x73, 0x12, 0x37, 0x2e, 0x67, 0x6f, 0x6f, 0x67, 0x6c,
	0x65, 0x2e, 0x63, 0x6c, 0x6f, 0x75, 0x64, 0x2e, 0x61, 0x73, 0x73, 0x65, 0x74, 0x2e, 0x76, 0x31,
	0x70, 0x31, 0x62, 0x65, 0x74, 0x61, 0x31, 0x2e, 0x53, 0x65, 0x61, 0x72, 0x63, 0x68, 0x41, 0x6c,
	0x6c, 0x52, 0x65, 0x73, 0x6f, 0x75, 0x72, 0x63, 0x65, 0x73, 0x52, 0x65, 0x71, 0x75, 0x65, 0x73,
	0x74, 0x1a, 0x38, 0x2e, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2e, 0x63, 0x6c, 0x6f, 0x75, 0x64,
	0x2e, 0x61, 0x73, 0x73, 0x65, 0x74, 0x2e, 0x76, 0x31, 0x70, 0x31, 0x62, 0x65, 0x74, 0x61, 0x31,
	0x2e, 0x53, 0x65, 0x61, 0x72, 0x63, 0x68, 0x41, 0x6c, 0x6c, 0x52, 0x65, 0x73, 0x6f, 0x75, 0x72,
	0x63, 0x65, 0x73, 0x52, 0x65, 0x73, 0x70, 0x6f, 0x6e, 0x73, 0x65, 0x22, 0x4c, 0x82, 0xd3, 0xe4,
	0x93, 0x02, 0x2c, 0x12, 0x2a, 0x2f, 0x76, 0x31, 0x70, 0x31, 0x62, 0x65, 0x74, 0x61, 0x31, 0x2f,
	0x7b, 0x73, 0x63, 0x6f, 0x70, 0x65, 0x3d, 0x2a, 0x2f, 0x2a, 0x7d, 0x2f, 0x72, 0x65, 0x73, 0x6f,
	0x75, 0x72, 0x63, 0x65, 0x73, 0x3a, 0x73, 0x65, 0x61, 0x72, 0x63, 0x68, 0x41, 0x6c, 0x6c, 0xda,
	0x41, 0x17, 0x73, 0x63, 0x6f, 0x70, 0x65, 0x2c, 0x71, 0x75, 0x65, 0x72, 0x79, 0x2c, 0x61, 0x73,
	0x73, 0x65, 0x74, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x73, 0x12, 0xd1, 0x01, 0x0a, 0x14, 0x53, 0x65,
	0x61, 0x72, 0x63, 0x68, 0x41, 0x6c, 0x6c, 0x49, 0x61, 0x6d, 0x50, 0x6f, 0x6c, 0x69, 0x63, 0x69,
	0x65, 0x73, 0x12, 0x39, 0x2e, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2e, 0x63, 0x6c, 0x6f, 0x75,
	0x64, 0x2e, 0x61, 0x73, 0x73, 0x65, 0x74, 0x2e, 0x76, 0x31, 0x70, 0x31, 0x62, 0x65, 0x74, 0x61,
	0x31, 0x2e, 0x53, 0x65, 0x61, 0x72, 0x63, 0x68, 0x41, 0x6c, 0x6c, 0x49, 0x61, 0x6d, 0x50, 0x6f,
	0x6c, 0x69, 0x63, 0x69, 0x65, 0x73, 0x52, 0x65, 0x71, 0x75, 0x65, 0x73, 0x74, 0x1a, 0x3a, 0x2e,
	0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2e, 0x63, 0x6c, 0x6f, 0x75, 0x64, 0x2e, 0x61, 0x73, 0x73,
	0x65, 0x74, 0x2e, 0x76, 0x31, 0x70, 0x31, 0x62, 0x65, 0x74, 0x61, 0x31, 0x2e, 0x53, 0x65, 0x61,
	0x72, 0x63, 0x68, 0x41, 0x6c, 0x6c, 0x49, 0x61, 0x6d, 0x50, 0x6f, 0x6c, 0x69, 0x63, 0x69, 0x65,
	0x73, 0x52, 0x65, 0x73, 0x70, 0x6f, 0x6e, 0x73, 0x65, 0x22, 0x42, 0x82, 0xd3, 0xe4, 0x93, 0x02,
	0x2e, 0x12, 0x2c, 0x2f, 0x76, 0x31, 0x70, 0x31, 0x62, 0x65, 0x74, 0x61, 0x31, 0x2f, 0x7b, 0x73,
	0x63, 0x6f, 0x70, 0x65, 0x3d, 0x2a, 0x2f, 0x2a, 0x7d, 0x2f, 0x69, 0x61, 0x6d, 0x50, 0x6f, 0x6c,
	0x69, 0x63, 0x69, 0x65, 0x73, 0x3a, 0x73, 0x65, 0x61, 0x72, 0x63, 0x68, 0x41, 0x6c, 0x6c, 0xda,
	0x41, 0x0b, 0x73, 0x63, 0x6f, 0x70, 0x65, 0x2c, 0x71, 0x75, 0x65, 0x72, 0x79, 0x1a, 0x4d, 0xca,
	0x41, 0x19, 0x63, 0x6c, 0x6f, 0x75, 0x64, 0x61, 0x73, 0x73, 0x65, 0x74, 0x2e, 0x67, 0x6f, 0x6f,
	0x67, 0x6c, 0x65, 0x61, 0x70, 0x69, 0x73, 0x2e, 0x63, 0x6f, 0x6d, 0xd2, 0x41, 0x2e, 0x68, 0x74,
	0x74, 0x70, 0x73, 0x3a, 0x2f, 0x2f, 0x77, 0x77, 0x77, 0x2e, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65,
	0x61, 0x70, 0x69, 0x73, 0x2e, 0x63, 0x6f, 0x6d, 0x2f, 0x61, 0x75, 0x74, 0x68, 0x2f, 0x63, 0x6c,
	0x6f, 0x75, 0x64, 0x2d, 0x70, 0x6c, 0x61, 0x74, 0x66, 0x6f, 0x72, 0x6d, 0x42, 0xb8, 0x01, 0x0a,
	0x20, 0x63, 0x6f, 0x6d, 0x2e, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2e, 0x63, 0x6c, 0x6f, 0x75,
	0x64, 0x2e, 0x61, 0x73, 0x73, 0x65, 0x74, 0x2e, 0x76, 0x31, 0x70, 0x31, 0x62, 0x65, 0x74, 0x61,
	0x31, 0x42, 0x11, 0x41, 0x73, 0x73, 0x65, 0x74, 0x53, 0x65, 0x72, 0x76, 0x69, 0x63, 0x65, 0x50,
	0x72, 0x6f, 0x74, 0x6f, 0x50, 0x01, 0x5a, 0x41, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2e, 0x67,
	0x6f, 0x6c, 0x61, 0x6e, 0x67, 0x2e, 0x6f, 0x72, 0x67, 0x2f, 0x67, 0x65, 0x6e, 0x70, 0x72, 0x6f,
	0x74, 0x6f, 0x2f, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x61, 0x70, 0x69, 0x73, 0x2f, 0x63, 0x6c,
	0x6f, 0x75, 0x64, 0x2f, 0x61, 0x73, 0x73, 0x65, 0x74, 0x2f, 0x76, 0x31, 0x70, 0x31, 0x62, 0x65,
	0x74, 0x61, 0x31, 0x3b, 0x61, 0x73, 0x73, 0x65, 0x74, 0xaa, 0x02, 0x1c, 0x47, 0x6f, 0x6f, 0x67,
	0x6c, 0x65, 0x2e, 0x43, 0x6c, 0x6f, 0x75, 0x64, 0x2e, 0x41, 0x73, 0x73, 0x65, 0x74, 0x2e, 0x56,
	0x31, 0x50, 0x31, 0x42, 0x65, 0x74, 0x61, 0x31, 0xca, 0x02, 0x1c, 0x47, 0x6f, 0x6f, 0x67, 0x6c,
	0x65, 0x5c, 0x43, 0x6c, 0x6f, 0x75, 0x64, 0x5c, 0x41, 0x73, 0x73, 0x65, 0x74, 0x5c, 0x56, 0x31,
	0x70, 0x31, 0x62, 0x65, 0x74, 0x61, 0x31, 0x62, 0x06, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x33,
}

var (
	file_google_cloud_asset_v1p1beta1_asset_service_proto_rawDescOnce sync.Once
	file_google_cloud_asset_v1p1beta1_asset_service_proto_rawDescData = file_google_cloud_asset_v1p1beta1_asset_service_proto_rawDesc
)

func file_google_cloud_asset_v1p1beta1_asset_service_proto_rawDescGZIP() []byte {
	file_google_cloud_asset_v1p1beta1_asset_service_proto_rawDescOnce.Do(func() {
		file_google_cloud_asset_v1p1beta1_asset_service_proto_rawDescData = protoimpl.X.CompressGZIP(file_google_cloud_asset_v1p1beta1_asset_service_proto_rawDescData)
	})
	return file_google_cloud_asset_v1p1beta1_asset_service_proto_rawDescData
}

var file_google_cloud_asset_v1p1beta1_asset_service_proto_msgTypes = make([]protoimpl.MessageInfo, 4)
var file_google_cloud_asset_v1p1beta1_asset_service_proto_goTypes = []interface{}{
	(*SearchAllResourcesRequest)(nil),    // 0: google.cloud.asset.v1p1beta1.SearchAllResourcesRequest
	(*SearchAllResourcesResponse)(nil),   // 1: google.cloud.asset.v1p1beta1.SearchAllResourcesResponse
	(*SearchAllIamPoliciesRequest)(nil),  // 2: google.cloud.asset.v1p1beta1.SearchAllIamPoliciesRequest
	(*SearchAllIamPoliciesResponse)(nil), // 3: google.cloud.asset.v1p1beta1.SearchAllIamPoliciesResponse
	(*StandardResourceMetadata)(nil),     // 4: google.cloud.asset.v1p1beta1.StandardResourceMetadata
	(*IamPolicySearchResult)(nil),        // 5: google.cloud.asset.v1p1beta1.IamPolicySearchResult
}
var file_google_cloud_asset_v1p1beta1_asset_service_proto_depIdxs = []int32{
	4, // 0: google.cloud.asset.v1p1beta1.SearchAllResourcesResponse.results:type_name -> google.cloud.asset.v1p1beta1.StandardResourceMetadata
	5, // 1: google.cloud.asset.v1p1beta1.SearchAllIamPoliciesResponse.results:type_name -> google.cloud.asset.v1p1beta1.IamPolicySearchResult
	0, // 2: google.cloud.asset.v1p1beta1.AssetService.SearchAllResources:input_type -> google.cloud.asset.v1p1beta1.SearchAllResourcesRequest
	2, // 3: google.cloud.asset.v1p1beta1.AssetService.SearchAllIamPolicies:input_type -> google.cloud.asset.v1p1beta1.SearchAllIamPoliciesRequest
	1, // 4: google.cloud.asset.v1p1beta1.AssetService.SearchAllResources:output_type -> google.cloud.asset.v1p1beta1.SearchAllResourcesResponse
	3, // 5: google.cloud.asset.v1p1beta1.AssetService.SearchAllIamPolicies:output_type -> google.cloud.asset.v1p1beta1.SearchAllIamPoliciesResponse
	4, // [4:6] is the sub-list for method output_type
	2, // [2:4] is the sub-list for method input_type
	2, // [2:2] is the sub-list for extension type_name
	2, // [2:2] is the sub-list for extension extendee
	0, // [0:2] is the sub-list for field type_name
}

func init() { file_google_cloud_asset_v1p1beta1_asset_service_proto_init() }
func file_google_cloud_asset_v1p1beta1_asset_service_proto_init() {
	if File_google_cloud_asset_v1p1beta1_asset_service_proto != nil {
		return
	}
	file_google_cloud_asset_v1p1beta1_assets_proto_init()
	if !protoimpl.UnsafeEnabled {
		file_google_cloud_asset_v1p1beta1_asset_service_proto_msgTypes[0].Exporter = func(v interface{}, i int) interface{} {
			switch v := v.(*SearchAllResourcesRequest); i {
			case 0:
				return &v.state
			case 1:
				return &v.sizeCache
			case 2:
				return &v.unknownFields
			default:
				return nil
			}
		}
		file_google_cloud_asset_v1p1beta1_asset_service_proto_msgTypes[1].Exporter = func(v interface{}, i int) interface{} {
			switch v := v.(*SearchAllResourcesResponse); i {
			case 0:
				return &v.state
			case 1:
				return &v.sizeCache
			case 2:
				return &v.unknownFields
			default:
				return nil
			}
		}
		file_google_cloud_asset_v1p1beta1_asset_service_proto_msgTypes[2].Exporter = func(v interface{}, i int) interface{} {
			switch v := v.(*SearchAllIamPoliciesRequest); i {
			case 0:
				return &v.state
			case 1:
				return &v.sizeCache
			case 2:
				return &v.unknownFields
			default:
				return nil
			}
		}
		file_google_cloud_asset_v1p1beta1_asset_service_proto_msgTypes[3].Exporter = func(v interface{}, i int) interface{} {
			switch v := v.(*SearchAllIamPoliciesResponse); i {
			case 0:
				return &v.state
			case 1:
				return &v.sizeCache
			case 2:
				return &v.unknownFields
			default:
				return nil
			}
		}
	}
	type x struct{}
	out := protoimpl.TypeBuilder{
		File: protoimpl.DescBuilder{
			GoPackagePath: reflect.TypeOf(x{}).PkgPath(),
			RawDescriptor: file_google_cloud_asset_v1p1beta1_asset_service_proto_rawDesc,
			NumEnums:      0,
			NumMessages:   4,
			NumExtensions: 0,
			NumServices:   1,
		},
		GoTypes:           file_google_cloud_asset_v1p1beta1_asset_service_proto_goTypes,
		DependencyIndexes: file_google_cloud_asset_v1p1beta1_asset_service_proto_depIdxs,
		MessageInfos:      file_google_cloud_asset_v1p1beta1_asset_service_proto_msgTypes,
	}.Build()
	File_google_cloud_asset_v1p1beta1_asset_service_proto = out.File
	file_google_cloud_asset_v1p1beta1_asset_service_proto_rawDesc = nil
	file_google_cloud_asset_v1p1beta1_asset_service_proto_goTypes = nil
	file_google_cloud_asset_v1p1beta1_asset_service_proto_depIdxs = nil
}

// Reference imports to suppress errors if they are not otherwise used.
var _ context.Context
var _ grpc.ClientConnInterface

// This is a compile-time assertion to ensure that this generated file
// is compatible with the grpc package it is being compiled against.
const _ = grpc.SupportPackageIsVersion6

// AssetServiceClient is the client API for AssetService service.
//
// For semantics around ctx use and closing/ending streaming RPCs, please refer to https://godoc.org/google.golang.org/grpc#ClientConn.NewStream.
type AssetServiceClient interface {
	// Searches all the resources under a given accessible CRM scope
	// (project/folder/organization). This RPC gives callers
	// especially admins the ability to search all the resources under a scope,
	// even if they don't have .get permission of all the resources. Callers
	// should have cloud.assets.SearchAllResources permission on the requested
	// scope, otherwise it will be rejected.
	SearchAllResources(ctx context.Context, in *SearchAllResourcesRequest, opts ...grpc.CallOption) (*SearchAllResourcesResponse, error)
	// Searches all the IAM policies under a given accessible CRM scope
	// (project/folder/organization). This RPC gives callers
	// especially admins the ability to search all the IAM policies under a scope,
	// even if they don't have .getIamPolicy permission of all the IAM policies.
	// Callers should have cloud.assets.SearchAllIamPolicies permission on the
	// requested scope, otherwise it will be rejected.
	SearchAllIamPolicies(ctx context.Context, in *SearchAllIamPoliciesRequest, opts ...grpc.CallOption) (*SearchAllIamPoliciesResponse, error)
}

type assetServiceClient struct {
	cc grpc.ClientConnInterface
}

func NewAssetServiceClient(cc grpc.ClientConnInterface) AssetServiceClient {
	return &assetServiceClient{cc}
}

func (c *assetServiceClient) SearchAllResources(ctx context.Context, in *SearchAllResourcesRequest, opts ...grpc.CallOption) (*SearchAllResourcesResponse, error) {
	out := new(SearchAllResourcesResponse)
	err := c.cc.Invoke(ctx, "/google.cloud.asset.v1p1beta1.AssetService/SearchAllResources", in, out, opts...)
	if err != nil {
		return nil, err
	}
	return out, nil
}

func (c *assetServiceClient) SearchAllIamPolicies(ctx context.Context, in *SearchAllIamPoliciesRequest, opts ...grpc.CallOption) (*SearchAllIamPoliciesResponse, error) {
	out := new(SearchAllIamPoliciesResponse)
	err := c.cc.Invoke(ctx, "/google.cloud.asset.v1p1beta1.AssetService/SearchAllIamPolicies", in, out, opts...)
	if err != nil {
		return nil, err
	}
	return out, nil
}

// AssetServiceServer is the server API for AssetService service.
type AssetServiceServer interface {
	// Searches all the resources under a given accessible CRM scope
	// (project/folder/organization). This RPC gives callers
	// especially admins the ability to search all the resources under a scope,
	// even if they don't have .get permission of all the resources. Callers
	// should have cloud.assets.SearchAllResources permission on the requested
	// scope, otherwise it will be rejected.
	SearchAllResources(context.Context, *SearchAllResourcesRequest) (*SearchAllResourcesResponse, error)
	// Searches all the IAM policies under a given accessible CRM scope
	// (project/folder/organization). This RPC gives callers
	// especially admins the ability to search all the IAM policies under a scope,
	// even if they don't have .getIamPolicy permission of all the IAM policies.
	// Callers should have cloud.assets.SearchAllIamPolicies permission on the
	// requested scope, otherwise it will be rejected.
	SearchAllIamPolicies(context.Context, *SearchAllIamPoliciesRequest) (*SearchAllIamPoliciesResponse, error)
}

// UnimplementedAssetServiceServer can be embedded to have forward compatible implementations.
type UnimplementedAssetServiceServer struct {
}

func (*UnimplementedAssetServiceServer) SearchAllResources(context.Context, *SearchAllResourcesRequest) (*SearchAllResourcesResponse, error) {
	return nil, status.Errorf(codes.Unimplemented, "method SearchAllResources not implemented")
}
func (*UnimplementedAssetServiceServer) SearchAllIamPolicies(context.Context, *SearchAllIamPoliciesRequest) (*SearchAllIamPoliciesResponse, error) {
	return nil, status.Errorf(codes.Unimplemented, "method SearchAllIamPolicies not implemented")
}

func RegisterAssetServiceServer(s *grpc.Server, srv AssetServiceServer) {
	s.RegisterService(&_AssetService_serviceDesc, srv)
}

func _AssetService_SearchAllResources_Handler(srv interface{}, ctx context.Context, dec func(interface{}) error, interceptor grpc.UnaryServerInterceptor) (interface{}, error) {
	in := new(SearchAllResourcesRequest)
	if err := dec(in); err != nil {
		return nil, err
	}
	if interceptor == nil {
		return srv.(AssetServiceServer).SearchAllResources(ctx, in)
	}
	info := &grpc.UnaryServerInfo{
		Server:     srv,
		FullMethod: "/google.cloud.asset.v1p1beta1.AssetService/SearchAllResources",
	}
	handler := func(ctx context.Context, req interface{}) (interface{}, error) {
		return srv.(AssetServiceServer).SearchAllResources(ctx, req.(*SearchAllResourcesRequest))
	}
	return interceptor(ctx, in, info, handler)
}

func _AssetService_SearchAllIamPolicies_Handler(srv interface{}, ctx context.Context, dec func(interface{}) error, interceptor grpc.UnaryServerInterceptor) (interface{}, error) {
	in := new(SearchAllIamPoliciesRequest)
	if err := dec(in); err != nil {
		return nil, err
	}
	if interceptor == nil {
		return srv.(AssetServiceServer).SearchAllIamPolicies(ctx, in)
	}
	info := &grpc.UnaryServerInfo{
		Server:     srv,
		FullMethod: "/google.cloud.asset.v1p1beta1.AssetService/SearchAllIamPolicies",
	}
	handler := func(ctx context.Context, req interface{}) (interface{}, error) {
		return srv.(AssetServiceServer).SearchAllIamPolicies(ctx, req.(*SearchAllIamPoliciesRequest))
	}
	return interceptor(ctx, in, info, handler)
}

var _AssetService_serviceDesc = grpc.ServiceDesc{
	ServiceName: "google.cloud.asset.v1p1beta1.AssetService",
	HandlerType: (*AssetServiceServer)(nil),
	Methods: []grpc.MethodDesc{
		{
			MethodName: "SearchAllResources",
			Handler:    _AssetService_SearchAllResources_Handler,
		},
		{
			MethodName: "SearchAllIamPolicies",
			Handler:    _AssetService_SearchAllIamPolicies_Handler,
		},
	},
	Streams:  []grpc.StreamDesc{},
	Metadata: "google/cloud/asset/v1p1beta1/asset_service.proto",
}
