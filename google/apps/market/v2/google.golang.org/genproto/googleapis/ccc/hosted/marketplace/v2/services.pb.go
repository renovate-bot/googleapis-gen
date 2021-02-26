// Copyright 2021 Google LLC
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
// 	protoc        v3.14.0
// source: google/apps/market/v2/services.proto

package marketplace

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

type CustomerLicenseGetRequest struct {
	state         protoimpl.MessageState
	sizeCache     protoimpl.SizeCache
	unknownFields protoimpl.UnknownFields

	// Application Id
	ApplicationId string `protobuf:"bytes,1,opt,name=application_id,json=applicationId,proto3" json:"application_id,omitempty"`
	// Customer Id
	CustomerId string `protobuf:"bytes,2,opt,name=customer_id,json=customerId,proto3" json:"customer_id,omitempty"`
}

func (x *CustomerLicenseGetRequest) Reset() {
	*x = CustomerLicenseGetRequest{}
	if protoimpl.UnsafeEnabled {
		mi := &file_google_apps_market_v2_services_proto_msgTypes[0]
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		ms.StoreMessageInfo(mi)
	}
}

func (x *CustomerLicenseGetRequest) String() string {
	return protoimpl.X.MessageStringOf(x)
}

func (*CustomerLicenseGetRequest) ProtoMessage() {}

func (x *CustomerLicenseGetRequest) ProtoReflect() protoreflect.Message {
	mi := &file_google_apps_market_v2_services_proto_msgTypes[0]
	if protoimpl.UnsafeEnabled && x != nil {
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		if ms.LoadMessageInfo() == nil {
			ms.StoreMessageInfo(mi)
		}
		return ms
	}
	return mi.MessageOf(x)
}

// Deprecated: Use CustomerLicenseGetRequest.ProtoReflect.Descriptor instead.
func (*CustomerLicenseGetRequest) Descriptor() ([]byte, []int) {
	return file_google_apps_market_v2_services_proto_rawDescGZIP(), []int{0}
}

func (x *CustomerLicenseGetRequest) GetApplicationId() string {
	if x != nil {
		return x.ApplicationId
	}
	return ""
}

func (x *CustomerLicenseGetRequest) GetCustomerId() string {
	if x != nil {
		return x.CustomerId
	}
	return ""
}

type LicenseNotificationListRequest struct {
	state         protoimpl.MessageState
	sizeCache     protoimpl.SizeCache
	unknownFields protoimpl.UnknownFields

	// Application Id
	ApplicationId string `protobuf:"bytes,1,opt,name=application_id,json=applicationId,proto3" json:"application_id,omitempty"`
	MaxResults    uint32 `protobuf:"varint,2,opt,name=max_results,json=maxResults,proto3" json:"max_results,omitempty"`
	StartToken    string `protobuf:"bytes,3,opt,name=start_token,json=startToken,proto3" json:"start_token,omitempty"`
	// Timestamp in milliseconds since epoch
	Timestamp uint64 `protobuf:"varint,4,opt,name=timestamp,proto3" json:"timestamp,omitempty"`
}

func (x *LicenseNotificationListRequest) Reset() {
	*x = LicenseNotificationListRequest{}
	if protoimpl.UnsafeEnabled {
		mi := &file_google_apps_market_v2_services_proto_msgTypes[1]
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		ms.StoreMessageInfo(mi)
	}
}

func (x *LicenseNotificationListRequest) String() string {
	return protoimpl.X.MessageStringOf(x)
}

func (*LicenseNotificationListRequest) ProtoMessage() {}

func (x *LicenseNotificationListRequest) ProtoReflect() protoreflect.Message {
	mi := &file_google_apps_market_v2_services_proto_msgTypes[1]
	if protoimpl.UnsafeEnabled && x != nil {
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		if ms.LoadMessageInfo() == nil {
			ms.StoreMessageInfo(mi)
		}
		return ms
	}
	return mi.MessageOf(x)
}

// Deprecated: Use LicenseNotificationListRequest.ProtoReflect.Descriptor instead.
func (*LicenseNotificationListRequest) Descriptor() ([]byte, []int) {
	return file_google_apps_market_v2_services_proto_rawDescGZIP(), []int{1}
}

func (x *LicenseNotificationListRequest) GetApplicationId() string {
	if x != nil {
		return x.ApplicationId
	}
	return ""
}

func (x *LicenseNotificationListRequest) GetMaxResults() uint32 {
	if x != nil {
		return x.MaxResults
	}
	return 0
}

func (x *LicenseNotificationListRequest) GetStartToken() string {
	if x != nil {
		return x.StartToken
	}
	return ""
}

func (x *LicenseNotificationListRequest) GetTimestamp() uint64 {
	if x != nil {
		return x.Timestamp
	}
	return 0
}

type UserLicenseGetRequest struct {
	state         protoimpl.MessageState
	sizeCache     protoimpl.SizeCache
	unknownFields protoimpl.UnknownFields

	// Application Id
	ApplicationId string `protobuf:"bytes,1,opt,name=application_id,json=applicationId,proto3" json:"application_id,omitempty"`
	// User Id
	UserId string `protobuf:"bytes,2,opt,name=user_id,json=userId,proto3" json:"user_id,omitempty"`
}

func (x *UserLicenseGetRequest) Reset() {
	*x = UserLicenseGetRequest{}
	if protoimpl.UnsafeEnabled {
		mi := &file_google_apps_market_v2_services_proto_msgTypes[2]
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		ms.StoreMessageInfo(mi)
	}
}

func (x *UserLicenseGetRequest) String() string {
	return protoimpl.X.MessageStringOf(x)
}

func (*UserLicenseGetRequest) ProtoMessage() {}

func (x *UserLicenseGetRequest) ProtoReflect() protoreflect.Message {
	mi := &file_google_apps_market_v2_services_proto_msgTypes[2]
	if protoimpl.UnsafeEnabled && x != nil {
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		if ms.LoadMessageInfo() == nil {
			ms.StoreMessageInfo(mi)
		}
		return ms
	}
	return mi.MessageOf(x)
}

// Deprecated: Use UserLicenseGetRequest.ProtoReflect.Descriptor instead.
func (*UserLicenseGetRequest) Descriptor() ([]byte, []int) {
	return file_google_apps_market_v2_services_proto_rawDescGZIP(), []int{2}
}

func (x *UserLicenseGetRequest) GetApplicationId() string {
	if x != nil {
		return x.ApplicationId
	}
	return ""
}

func (x *UserLicenseGetRequest) GetUserId() string {
	if x != nil {
		return x.UserId
	}
	return ""
}

var File_google_apps_market_v2_services_proto protoreflect.FileDescriptor

var file_google_apps_market_v2_services_proto_rawDesc = []byte{
	0x0a, 0x24, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2f, 0x61, 0x70, 0x70, 0x73, 0x2f, 0x6d, 0x61,
	0x72, 0x6b, 0x65, 0x74, 0x2f, 0x76, 0x32, 0x2f, 0x73, 0x65, 0x72, 0x76, 0x69, 0x63, 0x65, 0x73,
	0x2e, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x12, 0x19, 0x63, 0x63, 0x63, 0x2e, 0x68, 0x6f, 0x73, 0x74,
	0x65, 0x64, 0x2e, 0x6d, 0x61, 0x72, 0x6b, 0x65, 0x74, 0x70, 0x6c, 0x61, 0x63, 0x65, 0x2e, 0x76,
	0x32, 0x1a, 0x1c, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2f, 0x61, 0x70, 0x69, 0x2f, 0x61, 0x6e,
	0x6e, 0x6f, 0x74, 0x61, 0x74, 0x69, 0x6f, 0x6e, 0x73, 0x2e, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x1a,
	0x25, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2f, 0x61, 0x70, 0x70, 0x73, 0x2f, 0x6d, 0x61, 0x72,
	0x6b, 0x65, 0x74, 0x2f, 0x76, 0x32, 0x2f, 0x72, 0x65, 0x73, 0x6f, 0x75, 0x72, 0x63, 0x65, 0x73,
	0x2e, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x1a, 0x17, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2f, 0x61,
	0x70, 0x69, 0x2f, 0x63, 0x6c, 0x69, 0x65, 0x6e, 0x74, 0x2e, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x22,
	0x63, 0x0a, 0x19, 0x43, 0x75, 0x73, 0x74, 0x6f, 0x6d, 0x65, 0x72, 0x4c, 0x69, 0x63, 0x65, 0x6e,
	0x73, 0x65, 0x47, 0x65, 0x74, 0x52, 0x65, 0x71, 0x75, 0x65, 0x73, 0x74, 0x12, 0x25, 0x0a, 0x0e,
	0x61, 0x70, 0x70, 0x6c, 0x69, 0x63, 0x61, 0x74, 0x69, 0x6f, 0x6e, 0x5f, 0x69, 0x64, 0x18, 0x01,
	0x20, 0x01, 0x28, 0x09, 0x52, 0x0d, 0x61, 0x70, 0x70, 0x6c, 0x69, 0x63, 0x61, 0x74, 0x69, 0x6f,
	0x6e, 0x49, 0x64, 0x12, 0x1f, 0x0a, 0x0b, 0x63, 0x75, 0x73, 0x74, 0x6f, 0x6d, 0x65, 0x72, 0x5f,
	0x69, 0x64, 0x18, 0x02, 0x20, 0x01, 0x28, 0x09, 0x52, 0x0a, 0x63, 0x75, 0x73, 0x74, 0x6f, 0x6d,
	0x65, 0x72, 0x49, 0x64, 0x22, 0xa7, 0x01, 0x0a, 0x1e, 0x4c, 0x69, 0x63, 0x65, 0x6e, 0x73, 0x65,
	0x4e, 0x6f, 0x74, 0x69, 0x66, 0x69, 0x63, 0x61, 0x74, 0x69, 0x6f, 0x6e, 0x4c, 0x69, 0x73, 0x74,
	0x52, 0x65, 0x71, 0x75, 0x65, 0x73, 0x74, 0x12, 0x25, 0x0a, 0x0e, 0x61, 0x70, 0x70, 0x6c, 0x69,
	0x63, 0x61, 0x74, 0x69, 0x6f, 0x6e, 0x5f, 0x69, 0x64, 0x18, 0x01, 0x20, 0x01, 0x28, 0x09, 0x52,
	0x0d, 0x61, 0x70, 0x70, 0x6c, 0x69, 0x63, 0x61, 0x74, 0x69, 0x6f, 0x6e, 0x49, 0x64, 0x12, 0x1f,
	0x0a, 0x0b, 0x6d, 0x61, 0x78, 0x5f, 0x72, 0x65, 0x73, 0x75, 0x6c, 0x74, 0x73, 0x18, 0x02, 0x20,
	0x01, 0x28, 0x0d, 0x52, 0x0a, 0x6d, 0x61, 0x78, 0x52, 0x65, 0x73, 0x75, 0x6c, 0x74, 0x73, 0x12,
	0x1f, 0x0a, 0x0b, 0x73, 0x74, 0x61, 0x72, 0x74, 0x5f, 0x74, 0x6f, 0x6b, 0x65, 0x6e, 0x18, 0x03,
	0x20, 0x01, 0x28, 0x09, 0x52, 0x0a, 0x73, 0x74, 0x61, 0x72, 0x74, 0x54, 0x6f, 0x6b, 0x65, 0x6e,
	0x12, 0x1c, 0x0a, 0x09, 0x74, 0x69, 0x6d, 0x65, 0x73, 0x74, 0x61, 0x6d, 0x70, 0x18, 0x04, 0x20,
	0x01, 0x28, 0x04, 0x52, 0x09, 0x74, 0x69, 0x6d, 0x65, 0x73, 0x74, 0x61, 0x6d, 0x70, 0x22, 0x57,
	0x0a, 0x15, 0x55, 0x73, 0x65, 0x72, 0x4c, 0x69, 0x63, 0x65, 0x6e, 0x73, 0x65, 0x47, 0x65, 0x74,
	0x52, 0x65, 0x71, 0x75, 0x65, 0x73, 0x74, 0x12, 0x25, 0x0a, 0x0e, 0x61, 0x70, 0x70, 0x6c, 0x69,
	0x63, 0x61, 0x74, 0x69, 0x6f, 0x6e, 0x5f, 0x69, 0x64, 0x18, 0x01, 0x20, 0x01, 0x28, 0x09, 0x52,
	0x0d, 0x61, 0x70, 0x70, 0x6c, 0x69, 0x63, 0x61, 0x74, 0x69, 0x6f, 0x6e, 0x49, 0x64, 0x12, 0x17,
	0x0a, 0x07, 0x75, 0x73, 0x65, 0x72, 0x5f, 0x69, 0x64, 0x18, 0x02, 0x20, 0x01, 0x28, 0x09, 0x52,
	0x06, 0x75, 0x73, 0x65, 0x72, 0x49, 0x64, 0x32, 0xa1, 0x02, 0x0a, 0x16, 0x43, 0x75, 0x73, 0x74,
	0x6f, 0x6d, 0x65, 0x72, 0x4c, 0x69, 0x63, 0x65, 0x6e, 0x73, 0x65, 0x53, 0x65, 0x72, 0x76, 0x69,
	0x63, 0x65, 0x12, 0xae, 0x01, 0x0a, 0x03, 0x47, 0x65, 0x74, 0x12, 0x34, 0x2e, 0x63, 0x63, 0x63,
	0x2e, 0x68, 0x6f, 0x73, 0x74, 0x65, 0x64, 0x2e, 0x6d, 0x61, 0x72, 0x6b, 0x65, 0x74, 0x70, 0x6c,
	0x61, 0x63, 0x65, 0x2e, 0x76, 0x32, 0x2e, 0x43, 0x75, 0x73, 0x74, 0x6f, 0x6d, 0x65, 0x72, 0x4c,
	0x69, 0x63, 0x65, 0x6e, 0x73, 0x65, 0x47, 0x65, 0x74, 0x52, 0x65, 0x71, 0x75, 0x65, 0x73, 0x74,
	0x1a, 0x2a, 0x2e, 0x63, 0x63, 0x63, 0x2e, 0x68, 0x6f, 0x73, 0x74, 0x65, 0x64, 0x2e, 0x6d, 0x61,
	0x72, 0x6b, 0x65, 0x74, 0x70, 0x6c, 0x61, 0x63, 0x65, 0x2e, 0x76, 0x32, 0x2e, 0x43, 0x75, 0x73,
	0x74, 0x6f, 0x6d, 0x65, 0x72, 0x4c, 0x69, 0x63, 0x65, 0x6e, 0x73, 0x65, 0x22, 0x45, 0x82, 0xd3,
	0xe4, 0x93, 0x02, 0x3f, 0x12, 0x3d, 0x2f, 0x61, 0x70, 0x70, 0x73, 0x6d, 0x61, 0x72, 0x6b, 0x65,
	0x74, 0x2f, 0x76, 0x32, 0x2f, 0x63, 0x75, 0x73, 0x74, 0x6f, 0x6d, 0x65, 0x72, 0x4c, 0x69, 0x63,
	0x65, 0x6e, 0x73, 0x65, 0x2f, 0x7b, 0x61, 0x70, 0x70, 0x6c, 0x69, 0x63, 0x61, 0x74, 0x69, 0x6f,
	0x6e, 0x5f, 0x69, 0x64, 0x7d, 0x2f, 0x7b, 0x63, 0x75, 0x73, 0x74, 0x6f, 0x6d, 0x65, 0x72, 0x5f,
	0x69, 0x64, 0x7d, 0x1a, 0x56, 0xca, 0x41, 0x19, 0x61, 0x70, 0x70, 0x73, 0x6d, 0x61, 0x72, 0x6b,
	0x65, 0x74, 0x2e, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x61, 0x70, 0x69, 0x73, 0x2e, 0x63, 0x6f,
	0x6d, 0xd2, 0x41, 0x37, 0x68, 0x74, 0x74, 0x70, 0x73, 0x3a, 0x2f, 0x2f, 0x77, 0x77, 0x77, 0x2e,
	0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x61, 0x70, 0x69, 0x73, 0x2e, 0x63, 0x6f, 0x6d, 0x2f, 0x61,
	0x75, 0x74, 0x68, 0x2f, 0x61, 0x70, 0x70, 0x73, 0x6d, 0x61, 0x72, 0x6b, 0x65, 0x74, 0x70, 0x6c,
	0x61, 0x63, 0x65, 0x2e, 0x6c, 0x69, 0x63, 0x65, 0x6e, 0x73, 0x65, 0x32, 0xac, 0x02, 0x0a, 0x1a,
	0x4c, 0x69, 0x63, 0x65, 0x6e, 0x73, 0x65, 0x4e, 0x6f, 0x74, 0x69, 0x66, 0x69, 0x63, 0x61, 0x74,
	0x69, 0x6f, 0x6e, 0x53, 0x65, 0x72, 0x76, 0x69, 0x63, 0x65, 0x12, 0xb5, 0x01, 0x0a, 0x04, 0x4c,
	0x69, 0x73, 0x74, 0x12, 0x39, 0x2e, 0x63, 0x63, 0x63, 0x2e, 0x68, 0x6f, 0x73, 0x74, 0x65, 0x64,
	0x2e, 0x6d, 0x61, 0x72, 0x6b, 0x65, 0x74, 0x70, 0x6c, 0x61, 0x63, 0x65, 0x2e, 0x76, 0x32, 0x2e,
	0x4c, 0x69, 0x63, 0x65, 0x6e, 0x73, 0x65, 0x4e, 0x6f, 0x74, 0x69, 0x66, 0x69, 0x63, 0x61, 0x74,
	0x69, 0x6f, 0x6e, 0x4c, 0x69, 0x73, 0x74, 0x52, 0x65, 0x71, 0x75, 0x65, 0x73, 0x74, 0x1a, 0x32,
	0x2e, 0x63, 0x63, 0x63, 0x2e, 0x68, 0x6f, 0x73, 0x74, 0x65, 0x64, 0x2e, 0x6d, 0x61, 0x72, 0x6b,
	0x65, 0x74, 0x70, 0x6c, 0x61, 0x63, 0x65, 0x2e, 0x76, 0x32, 0x2e, 0x4c, 0x69, 0x63, 0x65, 0x6e,
	0x73, 0x65, 0x4e, 0x6f, 0x74, 0x69, 0x66, 0x69, 0x63, 0x61, 0x74, 0x69, 0x6f, 0x6e, 0x4c, 0x69,
	0x73, 0x74, 0x22, 0x3e, 0x82, 0xd3, 0xe4, 0x93, 0x02, 0x38, 0x12, 0x33, 0x2f, 0x61, 0x70, 0x70,
	0x73, 0x6d, 0x61, 0x72, 0x6b, 0x65, 0x74, 0x2f, 0x76, 0x32, 0x2f, 0x6c, 0x69, 0x63, 0x65, 0x6e,
	0x73, 0x65, 0x4e, 0x6f, 0x74, 0x69, 0x66, 0x69, 0x63, 0x61, 0x74, 0x69, 0x6f, 0x6e, 0x2f, 0x7b,
	0x61, 0x70, 0x70, 0x6c, 0x69, 0x63, 0x61, 0x74, 0x69, 0x6f, 0x6e, 0x5f, 0x69, 0x64, 0x7d, 0x3a,
	0x01, 0x2a, 0x1a, 0x56, 0xca, 0x41, 0x19, 0x61, 0x70, 0x70, 0x73, 0x6d, 0x61, 0x72, 0x6b, 0x65,
	0x74, 0x2e, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x61, 0x70, 0x69, 0x73, 0x2e, 0x63, 0x6f, 0x6d,
	0xd2, 0x41, 0x37, 0x68, 0x74, 0x74, 0x70, 0x73, 0x3a, 0x2f, 0x2f, 0x77, 0x77, 0x77, 0x2e, 0x67,
	0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x61, 0x70, 0x69, 0x73, 0x2e, 0x63, 0x6f, 0x6d, 0x2f, 0x61, 0x75,
	0x74, 0x68, 0x2f, 0x61, 0x70, 0x70, 0x73, 0x6d, 0x61, 0x72, 0x6b, 0x65, 0x74, 0x70, 0x6c, 0x61,
	0x63, 0x65, 0x2e, 0x6c, 0x69, 0x63, 0x65, 0x6e, 0x73, 0x65, 0x32, 0x8d, 0x02, 0x0a, 0x12, 0x55,
	0x73, 0x65, 0x72, 0x4c, 0x69, 0x63, 0x65, 0x6e, 0x73, 0x65, 0x53, 0x65, 0x72, 0x76, 0x69, 0x63,
	0x65, 0x12, 0x9e, 0x01, 0x0a, 0x03, 0x47, 0x65, 0x74, 0x12, 0x30, 0x2e, 0x63, 0x63, 0x63, 0x2e,
	0x68, 0x6f, 0x73, 0x74, 0x65, 0x64, 0x2e, 0x6d, 0x61, 0x72, 0x6b, 0x65, 0x74, 0x70, 0x6c, 0x61,
	0x63, 0x65, 0x2e, 0x76, 0x32, 0x2e, 0x55, 0x73, 0x65, 0x72, 0x4c, 0x69, 0x63, 0x65, 0x6e, 0x73,
	0x65, 0x47, 0x65, 0x74, 0x52, 0x65, 0x71, 0x75, 0x65, 0x73, 0x74, 0x1a, 0x26, 0x2e, 0x63, 0x63,
	0x63, 0x2e, 0x68, 0x6f, 0x73, 0x74, 0x65, 0x64, 0x2e, 0x6d, 0x61, 0x72, 0x6b, 0x65, 0x74, 0x70,
	0x6c, 0x61, 0x63, 0x65, 0x2e, 0x76, 0x32, 0x2e, 0x55, 0x73, 0x65, 0x72, 0x4c, 0x69, 0x63, 0x65,
	0x6e, 0x73, 0x65, 0x22, 0x3d, 0x82, 0xd3, 0xe4, 0x93, 0x02, 0x37, 0x12, 0x35, 0x2f, 0x61, 0x70,
	0x70, 0x73, 0x6d, 0x61, 0x72, 0x6b, 0x65, 0x74, 0x2f, 0x76, 0x32, 0x2f, 0x75, 0x73, 0x65, 0x72,
	0x4c, 0x69, 0x63, 0x65, 0x6e, 0x73, 0x65, 0x2f, 0x7b, 0x61, 0x70, 0x70, 0x6c, 0x69, 0x63, 0x61,
	0x74, 0x69, 0x6f, 0x6e, 0x5f, 0x69, 0x64, 0x7d, 0x2f, 0x7b, 0x75, 0x73, 0x65, 0x72, 0x5f, 0x69,
	0x64, 0x7d, 0x1a, 0x56, 0xca, 0x41, 0x19, 0x61, 0x70, 0x70, 0x73, 0x6d, 0x61, 0x72, 0x6b, 0x65,
	0x74, 0x2e, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x61, 0x70, 0x69, 0x73, 0x2e, 0x63, 0x6f, 0x6d,
	0xd2, 0x41, 0x37, 0x68, 0x74, 0x74, 0x70, 0x73, 0x3a, 0x2f, 0x2f, 0x77, 0x77, 0x77, 0x2e, 0x67,
	0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x61, 0x70, 0x69, 0x73, 0x2e, 0x63, 0x6f, 0x6d, 0x2f, 0x61, 0x75,
	0x74, 0x68, 0x2f, 0x61, 0x70, 0x70, 0x73, 0x6d, 0x61, 0x72, 0x6b, 0x65, 0x74, 0x70, 0x6c, 0x61,
	0x63, 0x65, 0x2e, 0x6c, 0x69, 0x63, 0x65, 0x6e, 0x73, 0x65, 0x42, 0x83, 0x01, 0x0a, 0x24, 0x63,
	0x6f, 0x6d, 0x2e, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2e, 0x63, 0x63, 0x63, 0x2e, 0x68, 0x6f,
	0x73, 0x74, 0x65, 0x64, 0x2e, 0x6d, 0x61, 0x72, 0x6b, 0x65, 0x74, 0x70, 0x6c, 0x61, 0x63, 0x65,
	0x2e, 0x76, 0x32, 0x42, 0x0c, 0x53, 0x65, 0x72, 0x76, 0x69, 0x63, 0x65, 0x50, 0x72, 0x6f, 0x74,
	0x6f, 0x50, 0x01, 0x5a, 0x4b, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2e, 0x67, 0x6f, 0x6c, 0x61,
	0x6e, 0x67, 0x2e, 0x6f, 0x72, 0x67, 0x2f, 0x67, 0x65, 0x6e, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x2f,
	0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x61, 0x70, 0x69, 0x73, 0x2f, 0x63, 0x63, 0x63, 0x2f, 0x68,
	0x6f, 0x73, 0x74, 0x65, 0x64, 0x2f, 0x6d, 0x61, 0x72, 0x6b, 0x65, 0x74, 0x70, 0x6c, 0x61, 0x63,
	0x65, 0x2f, 0x76, 0x32, 0x3b, 0x6d, 0x61, 0x72, 0x6b, 0x65, 0x74, 0x70, 0x6c, 0x61, 0x63, 0x65,
	0x62, 0x06, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x33,
}

var (
	file_google_apps_market_v2_services_proto_rawDescOnce sync.Once
	file_google_apps_market_v2_services_proto_rawDescData = file_google_apps_market_v2_services_proto_rawDesc
)

func file_google_apps_market_v2_services_proto_rawDescGZIP() []byte {
	file_google_apps_market_v2_services_proto_rawDescOnce.Do(func() {
		file_google_apps_market_v2_services_proto_rawDescData = protoimpl.X.CompressGZIP(file_google_apps_market_v2_services_proto_rawDescData)
	})
	return file_google_apps_market_v2_services_proto_rawDescData
}

var file_google_apps_market_v2_services_proto_msgTypes = make([]protoimpl.MessageInfo, 3)
var file_google_apps_market_v2_services_proto_goTypes = []interface{}{
	(*CustomerLicenseGetRequest)(nil),      // 0: ccc.hosted.marketplace.v2.CustomerLicenseGetRequest
	(*LicenseNotificationListRequest)(nil), // 1: ccc.hosted.marketplace.v2.LicenseNotificationListRequest
	(*UserLicenseGetRequest)(nil),          // 2: ccc.hosted.marketplace.v2.UserLicenseGetRequest
	(*CustomerLicense)(nil),                // 3: ccc.hosted.marketplace.v2.CustomerLicense
	(*LicenseNotificationList)(nil),        // 4: ccc.hosted.marketplace.v2.LicenseNotificationList
	(*UserLicense)(nil),                    // 5: ccc.hosted.marketplace.v2.UserLicense
}
var file_google_apps_market_v2_services_proto_depIdxs = []int32{
	0, // 0: ccc.hosted.marketplace.v2.CustomerLicenseService.Get:input_type -> ccc.hosted.marketplace.v2.CustomerLicenseGetRequest
	1, // 1: ccc.hosted.marketplace.v2.LicenseNotificationService.List:input_type -> ccc.hosted.marketplace.v2.LicenseNotificationListRequest
	2, // 2: ccc.hosted.marketplace.v2.UserLicenseService.Get:input_type -> ccc.hosted.marketplace.v2.UserLicenseGetRequest
	3, // 3: ccc.hosted.marketplace.v2.CustomerLicenseService.Get:output_type -> ccc.hosted.marketplace.v2.CustomerLicense
	4, // 4: ccc.hosted.marketplace.v2.LicenseNotificationService.List:output_type -> ccc.hosted.marketplace.v2.LicenseNotificationList
	5, // 5: ccc.hosted.marketplace.v2.UserLicenseService.Get:output_type -> ccc.hosted.marketplace.v2.UserLicense
	3, // [3:6] is the sub-list for method output_type
	0, // [0:3] is the sub-list for method input_type
	0, // [0:0] is the sub-list for extension type_name
	0, // [0:0] is the sub-list for extension extendee
	0, // [0:0] is the sub-list for field type_name
}

func init() { file_google_apps_market_v2_services_proto_init() }
func file_google_apps_market_v2_services_proto_init() {
	if File_google_apps_market_v2_services_proto != nil {
		return
	}
	file_google_apps_market_v2_resources_proto_init()
	if !protoimpl.UnsafeEnabled {
		file_google_apps_market_v2_services_proto_msgTypes[0].Exporter = func(v interface{}, i int) interface{} {
			switch v := v.(*CustomerLicenseGetRequest); i {
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
		file_google_apps_market_v2_services_proto_msgTypes[1].Exporter = func(v interface{}, i int) interface{} {
			switch v := v.(*LicenseNotificationListRequest); i {
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
		file_google_apps_market_v2_services_proto_msgTypes[2].Exporter = func(v interface{}, i int) interface{} {
			switch v := v.(*UserLicenseGetRequest); i {
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
			RawDescriptor: file_google_apps_market_v2_services_proto_rawDesc,
			NumEnums:      0,
			NumMessages:   3,
			NumExtensions: 0,
			NumServices:   3,
		},
		GoTypes:           file_google_apps_market_v2_services_proto_goTypes,
		DependencyIndexes: file_google_apps_market_v2_services_proto_depIdxs,
		MessageInfos:      file_google_apps_market_v2_services_proto_msgTypes,
	}.Build()
	File_google_apps_market_v2_services_proto = out.File
	file_google_apps_market_v2_services_proto_rawDesc = nil
	file_google_apps_market_v2_services_proto_goTypes = nil
	file_google_apps_market_v2_services_proto_depIdxs = nil
}

// Reference imports to suppress errors if they are not otherwise used.
var _ context.Context
var _ grpc.ClientConnInterface

// This is a compile-time assertion to ensure that this generated file
// is compatible with the grpc package it is being compiled against.
const _ = grpc.SupportPackageIsVersion6

// CustomerLicenseServiceClient is the client API for CustomerLicenseService service.
//
// For semantics around ctx use and closing/ending streaming RPCs, please refer to https://godoc.org/google.golang.org/grpc#ClientConn.NewStream.
type CustomerLicenseServiceClient interface {
	// Get the status of a license for a customer to determine if they have access
	// for a given app.
	Get(ctx context.Context, in *CustomerLicenseGetRequest, opts ...grpc.CallOption) (*CustomerLicense, error)
}

type customerLicenseServiceClient struct {
	cc grpc.ClientConnInterface
}

func NewCustomerLicenseServiceClient(cc grpc.ClientConnInterface) CustomerLicenseServiceClient {
	return &customerLicenseServiceClient{cc}
}

func (c *customerLicenseServiceClient) Get(ctx context.Context, in *CustomerLicenseGetRequest, opts ...grpc.CallOption) (*CustomerLicense, error) {
	out := new(CustomerLicense)
	err := c.cc.Invoke(ctx, "/ccc.hosted.marketplace.v2.CustomerLicenseService/Get", in, out, opts...)
	if err != nil {
		return nil, err
	}
	return out, nil
}

// CustomerLicenseServiceServer is the server API for CustomerLicenseService service.
type CustomerLicenseServiceServer interface {
	// Get the status of a license for a customer to determine if they have access
	// for a given app.
	Get(context.Context, *CustomerLicenseGetRequest) (*CustomerLicense, error)
}

// UnimplementedCustomerLicenseServiceServer can be embedded to have forward compatible implementations.
type UnimplementedCustomerLicenseServiceServer struct {
}

func (*UnimplementedCustomerLicenseServiceServer) Get(context.Context, *CustomerLicenseGetRequest) (*CustomerLicense, error) {
	return nil, status.Errorf(codes.Unimplemented, "method Get not implemented")
}

func RegisterCustomerLicenseServiceServer(s *grpc.Server, srv CustomerLicenseServiceServer) {
	s.RegisterService(&_CustomerLicenseService_serviceDesc, srv)
}

func _CustomerLicenseService_Get_Handler(srv interface{}, ctx context.Context, dec func(interface{}) error, interceptor grpc.UnaryServerInterceptor) (interface{}, error) {
	in := new(CustomerLicenseGetRequest)
	if err := dec(in); err != nil {
		return nil, err
	}
	if interceptor == nil {
		return srv.(CustomerLicenseServiceServer).Get(ctx, in)
	}
	info := &grpc.UnaryServerInfo{
		Server:     srv,
		FullMethod: "/ccc.hosted.marketplace.v2.CustomerLicenseService/Get",
	}
	handler := func(ctx context.Context, req interface{}) (interface{}, error) {
		return srv.(CustomerLicenseServiceServer).Get(ctx, req.(*CustomerLicenseGetRequest))
	}
	return interceptor(ctx, in, info, handler)
}

var _CustomerLicenseService_serviceDesc = grpc.ServiceDesc{
	ServiceName: "ccc.hosted.marketplace.v2.CustomerLicenseService",
	HandlerType: (*CustomerLicenseServiceServer)(nil),
	Methods: []grpc.MethodDesc{
		{
			MethodName: "Get",
			Handler:    _CustomerLicenseService_Get_Handler,
		},
	},
	Streams:  []grpc.StreamDesc{},
	Metadata: "google/apps/market/v2/services.proto",
}

// LicenseNotificationServiceClient is the client API for LicenseNotificationService service.
//
// For semantics around ctx use and closing/ending streaming RPCs, please refer to https://godoc.org/google.golang.org/grpc#ClientConn.NewStream.
type LicenseNotificationServiceClient interface {
	// Get a list of licensing notifications with regards to a given app.
	List(ctx context.Context, in *LicenseNotificationListRequest, opts ...grpc.CallOption) (*LicenseNotificationList, error)
}

type licenseNotificationServiceClient struct {
	cc grpc.ClientConnInterface
}

func NewLicenseNotificationServiceClient(cc grpc.ClientConnInterface) LicenseNotificationServiceClient {
	return &licenseNotificationServiceClient{cc}
}

func (c *licenseNotificationServiceClient) List(ctx context.Context, in *LicenseNotificationListRequest, opts ...grpc.CallOption) (*LicenseNotificationList, error) {
	out := new(LicenseNotificationList)
	err := c.cc.Invoke(ctx, "/ccc.hosted.marketplace.v2.LicenseNotificationService/List", in, out, opts...)
	if err != nil {
		return nil, err
	}
	return out, nil
}

// LicenseNotificationServiceServer is the server API for LicenseNotificationService service.
type LicenseNotificationServiceServer interface {
	// Get a list of licensing notifications with regards to a given app.
	List(context.Context, *LicenseNotificationListRequest) (*LicenseNotificationList, error)
}

// UnimplementedLicenseNotificationServiceServer can be embedded to have forward compatible implementations.
type UnimplementedLicenseNotificationServiceServer struct {
}

func (*UnimplementedLicenseNotificationServiceServer) List(context.Context, *LicenseNotificationListRequest) (*LicenseNotificationList, error) {
	return nil, status.Errorf(codes.Unimplemented, "method List not implemented")
}

func RegisterLicenseNotificationServiceServer(s *grpc.Server, srv LicenseNotificationServiceServer) {
	s.RegisterService(&_LicenseNotificationService_serviceDesc, srv)
}

func _LicenseNotificationService_List_Handler(srv interface{}, ctx context.Context, dec func(interface{}) error, interceptor grpc.UnaryServerInterceptor) (interface{}, error) {
	in := new(LicenseNotificationListRequest)
	if err := dec(in); err != nil {
		return nil, err
	}
	if interceptor == nil {
		return srv.(LicenseNotificationServiceServer).List(ctx, in)
	}
	info := &grpc.UnaryServerInfo{
		Server:     srv,
		FullMethod: "/ccc.hosted.marketplace.v2.LicenseNotificationService/List",
	}
	handler := func(ctx context.Context, req interface{}) (interface{}, error) {
		return srv.(LicenseNotificationServiceServer).List(ctx, req.(*LicenseNotificationListRequest))
	}
	return interceptor(ctx, in, info, handler)
}

var _LicenseNotificationService_serviceDesc = grpc.ServiceDesc{
	ServiceName: "ccc.hosted.marketplace.v2.LicenseNotificationService",
	HandlerType: (*LicenseNotificationServiceServer)(nil),
	Methods: []grpc.MethodDesc{
		{
			MethodName: "List",
			Handler:    _LicenseNotificationService_List_Handler,
		},
	},
	Streams:  []grpc.StreamDesc{},
	Metadata: "google/apps/market/v2/services.proto",
}

// UserLicenseServiceClient is the client API for UserLicenseService service.
//
// For semantics around ctx use and closing/ending streaming RPCs, please refer to https://godoc.org/google.golang.org/grpc#ClientConn.NewStream.
type UserLicenseServiceClient interface {
	// Get the user's licensing status for their permission to use a given app.
	Get(ctx context.Context, in *UserLicenseGetRequest, opts ...grpc.CallOption) (*UserLicense, error)
}

type userLicenseServiceClient struct {
	cc grpc.ClientConnInterface
}

func NewUserLicenseServiceClient(cc grpc.ClientConnInterface) UserLicenseServiceClient {
	return &userLicenseServiceClient{cc}
}

func (c *userLicenseServiceClient) Get(ctx context.Context, in *UserLicenseGetRequest, opts ...grpc.CallOption) (*UserLicense, error) {
	out := new(UserLicense)
	err := c.cc.Invoke(ctx, "/ccc.hosted.marketplace.v2.UserLicenseService/Get", in, out, opts...)
	if err != nil {
		return nil, err
	}
	return out, nil
}

// UserLicenseServiceServer is the server API for UserLicenseService service.
type UserLicenseServiceServer interface {
	// Get the user's licensing status for their permission to use a given app.
	Get(context.Context, *UserLicenseGetRequest) (*UserLicense, error)
}

// UnimplementedUserLicenseServiceServer can be embedded to have forward compatible implementations.
type UnimplementedUserLicenseServiceServer struct {
}

func (*UnimplementedUserLicenseServiceServer) Get(context.Context, *UserLicenseGetRequest) (*UserLicense, error) {
	return nil, status.Errorf(codes.Unimplemented, "method Get not implemented")
}

func RegisterUserLicenseServiceServer(s *grpc.Server, srv UserLicenseServiceServer) {
	s.RegisterService(&_UserLicenseService_serviceDesc, srv)
}

func _UserLicenseService_Get_Handler(srv interface{}, ctx context.Context, dec func(interface{}) error, interceptor grpc.UnaryServerInterceptor) (interface{}, error) {
	in := new(UserLicenseGetRequest)
	if err := dec(in); err != nil {
		return nil, err
	}
	if interceptor == nil {
		return srv.(UserLicenseServiceServer).Get(ctx, in)
	}
	info := &grpc.UnaryServerInfo{
		Server:     srv,
		FullMethod: "/ccc.hosted.marketplace.v2.UserLicenseService/Get",
	}
	handler := func(ctx context.Context, req interface{}) (interface{}, error) {
		return srv.(UserLicenseServiceServer).Get(ctx, req.(*UserLicenseGetRequest))
	}
	return interceptor(ctx, in, info, handler)
}

var _UserLicenseService_serviceDesc = grpc.ServiceDesc{
	ServiceName: "ccc.hosted.marketplace.v2.UserLicenseService",
	HandlerType: (*UserLicenseServiceServer)(nil),
	Methods: []grpc.MethodDesc{
		{
			MethodName: "Get",
			Handler:    _UserLicenseService_Get_Handler,
		},
	},
	Streams:  []grpc.StreamDesc{},
	Metadata: "google/apps/market/v2/services.proto",
}
