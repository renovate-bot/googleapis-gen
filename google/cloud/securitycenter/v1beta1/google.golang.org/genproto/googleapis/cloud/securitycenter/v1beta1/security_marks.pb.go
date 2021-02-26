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
// source: google/cloud/securitycenter/v1beta1/security_marks.proto

package securitycenter

import (
	proto "github.com/golang/protobuf/proto"
	_ "google.golang.org/genproto/googleapis/api/annotations"
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

// User specified security marks that are attached to the parent Security
// Command Center resource. Security marks are scoped within a Security Command
// Center organization -- they can be modified and viewed by all users who have
// proper permissions on the organization.
type SecurityMarks struct {
	state         protoimpl.MessageState
	sizeCache     protoimpl.SizeCache
	unknownFields protoimpl.UnknownFields

	// The relative resource name of the SecurityMarks. See:
	// https://cloud.google.com/apis/design/resource_names#relative_resource_name
	// Examples:
	// "organizations/{organization_id}/assets/{asset_id}/securityMarks"
	// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks".
	Name string `protobuf:"bytes,1,opt,name=name,proto3" json:"name,omitempty"`
	// Mutable user specified security marks belonging to the parent resource.
	// Constraints are as follows:
	//
	//   * Keys and values are treated as case insensitive
	//   * Keys must be between 1 - 256 characters (inclusive)
	//   * Keys must be letters, numbers, underscores, or dashes
	//   * Values have leading and trailing whitespace trimmed, remaining
	//     characters must be between 1 - 4096 characters (inclusive)
	Marks map[string]string `protobuf:"bytes,2,rep,name=marks,proto3" json:"marks,omitempty" protobuf_key:"bytes,1,opt,name=key,proto3" protobuf_val:"bytes,2,opt,name=value,proto3"`
}

func (x *SecurityMarks) Reset() {
	*x = SecurityMarks{}
	if protoimpl.UnsafeEnabled {
		mi := &file_google_cloud_securitycenter_v1beta1_security_marks_proto_msgTypes[0]
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		ms.StoreMessageInfo(mi)
	}
}

func (x *SecurityMarks) String() string {
	return protoimpl.X.MessageStringOf(x)
}

func (*SecurityMarks) ProtoMessage() {}

func (x *SecurityMarks) ProtoReflect() protoreflect.Message {
	mi := &file_google_cloud_securitycenter_v1beta1_security_marks_proto_msgTypes[0]
	if protoimpl.UnsafeEnabled && x != nil {
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		if ms.LoadMessageInfo() == nil {
			ms.StoreMessageInfo(mi)
		}
		return ms
	}
	return mi.MessageOf(x)
}

// Deprecated: Use SecurityMarks.ProtoReflect.Descriptor instead.
func (*SecurityMarks) Descriptor() ([]byte, []int) {
	return file_google_cloud_securitycenter_v1beta1_security_marks_proto_rawDescGZIP(), []int{0}
}

func (x *SecurityMarks) GetName() string {
	if x != nil {
		return x.Name
	}
	return ""
}

func (x *SecurityMarks) GetMarks() map[string]string {
	if x != nil {
		return x.Marks
	}
	return nil
}

var File_google_cloud_securitycenter_v1beta1_security_marks_proto protoreflect.FileDescriptor

var file_google_cloud_securitycenter_v1beta1_security_marks_proto_rawDesc = []byte{
	0x0a, 0x38, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2f, 0x63, 0x6c, 0x6f, 0x75, 0x64, 0x2f, 0x73,
	0x65, 0x63, 0x75, 0x72, 0x69, 0x74, 0x79, 0x63, 0x65, 0x6e, 0x74, 0x65, 0x72, 0x2f, 0x76, 0x31,
	0x62, 0x65, 0x74, 0x61, 0x31, 0x2f, 0x73, 0x65, 0x63, 0x75, 0x72, 0x69, 0x74, 0x79, 0x5f, 0x6d,
	0x61, 0x72, 0x6b, 0x73, 0x2e, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x12, 0x23, 0x67, 0x6f, 0x6f, 0x67,
	0x6c, 0x65, 0x2e, 0x63, 0x6c, 0x6f, 0x75, 0x64, 0x2e, 0x73, 0x65, 0x63, 0x75, 0x72, 0x69, 0x74,
	0x79, 0x63, 0x65, 0x6e, 0x74, 0x65, 0x72, 0x2e, 0x76, 0x31, 0x62, 0x65, 0x74, 0x61, 0x31, 0x1a,
	0x19, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2f, 0x61, 0x70, 0x69, 0x2f, 0x72, 0x65, 0x73, 0x6f,
	0x75, 0x72, 0x63, 0x65, 0x2e, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x1a, 0x1c, 0x67, 0x6f, 0x6f, 0x67,
	0x6c, 0x65, 0x2f, 0x61, 0x70, 0x69, 0x2f, 0x61, 0x6e, 0x6e, 0x6f, 0x74, 0x61, 0x74, 0x69, 0x6f,
	0x6e, 0x73, 0x2e, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x22, 0xf1, 0x02, 0x0a, 0x0d, 0x53, 0x65, 0x63,
	0x75, 0x72, 0x69, 0x74, 0x79, 0x4d, 0x61, 0x72, 0x6b, 0x73, 0x12, 0x12, 0x0a, 0x04, 0x6e, 0x61,
	0x6d, 0x65, 0x18, 0x01, 0x20, 0x01, 0x28, 0x09, 0x52, 0x04, 0x6e, 0x61, 0x6d, 0x65, 0x12, 0x53,
	0x0a, 0x05, 0x6d, 0x61, 0x72, 0x6b, 0x73, 0x18, 0x02, 0x20, 0x03, 0x28, 0x0b, 0x32, 0x3d, 0x2e,
	0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2e, 0x63, 0x6c, 0x6f, 0x75, 0x64, 0x2e, 0x73, 0x65, 0x63,
	0x75, 0x72, 0x69, 0x74, 0x79, 0x63, 0x65, 0x6e, 0x74, 0x65, 0x72, 0x2e, 0x76, 0x31, 0x62, 0x65,
	0x74, 0x61, 0x31, 0x2e, 0x53, 0x65, 0x63, 0x75, 0x72, 0x69, 0x74, 0x79, 0x4d, 0x61, 0x72, 0x6b,
	0x73, 0x2e, 0x4d, 0x61, 0x72, 0x6b, 0x73, 0x45, 0x6e, 0x74, 0x72, 0x79, 0x52, 0x05, 0x6d, 0x61,
	0x72, 0x6b, 0x73, 0x1a, 0x38, 0x0a, 0x0a, 0x4d, 0x61, 0x72, 0x6b, 0x73, 0x45, 0x6e, 0x74, 0x72,
	0x79, 0x12, 0x10, 0x0a, 0x03, 0x6b, 0x65, 0x79, 0x18, 0x01, 0x20, 0x01, 0x28, 0x09, 0x52, 0x03,
	0x6b, 0x65, 0x79, 0x12, 0x14, 0x0a, 0x05, 0x76, 0x61, 0x6c, 0x75, 0x65, 0x18, 0x02, 0x20, 0x01,
	0x28, 0x09, 0x52, 0x05, 0x76, 0x61, 0x6c, 0x75, 0x65, 0x3a, 0x02, 0x38, 0x01, 0x3a, 0xbc, 0x01,
	0xea, 0x41, 0xb8, 0x01, 0x0a, 0x2b, 0x73, 0x65, 0x63, 0x75, 0x72, 0x69, 0x74, 0x79, 0x63, 0x65,
	0x6e, 0x74, 0x65, 0x72, 0x2e, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x61, 0x70, 0x69, 0x73, 0x2e,
	0x63, 0x6f, 0x6d, 0x2f, 0x53, 0x65, 0x63, 0x75, 0x72, 0x69, 0x74, 0x79, 0x4d, 0x61, 0x72, 0x6b,
	0x73, 0x12, 0x39, 0x6f, 0x72, 0x67, 0x61, 0x6e, 0x69, 0x7a, 0x61, 0x74, 0x69, 0x6f, 0x6e, 0x73,
	0x2f, 0x7b, 0x6f, 0x72, 0x67, 0x61, 0x6e, 0x69, 0x7a, 0x61, 0x74, 0x69, 0x6f, 0x6e, 0x7d, 0x2f,
	0x61, 0x73, 0x73, 0x65, 0x74, 0x73, 0x2f, 0x7b, 0x61, 0x73, 0x73, 0x65, 0x74, 0x7d, 0x2f, 0x73,
	0x65, 0x63, 0x75, 0x72, 0x69, 0x74, 0x79, 0x4d, 0x61, 0x72, 0x6b, 0x73, 0x12, 0x4e, 0x6f, 0x72,
	0x67, 0x61, 0x6e, 0x69, 0x7a, 0x61, 0x74, 0x69, 0x6f, 0x6e, 0x73, 0x2f, 0x7b, 0x6f, 0x72, 0x67,
	0x61, 0x6e, 0x69, 0x7a, 0x61, 0x74, 0x69, 0x6f, 0x6e, 0x7d, 0x2f, 0x73, 0x6f, 0x75, 0x72, 0x63,
	0x65, 0x73, 0x2f, 0x7b, 0x73, 0x6f, 0x75, 0x72, 0x63, 0x65, 0x7d, 0x2f, 0x66, 0x69, 0x6e, 0x64,
	0x69, 0x6e, 0x67, 0x73, 0x2f, 0x7b, 0x66, 0x69, 0x6e, 0x64, 0x69, 0x6e, 0x67, 0x7d, 0x2f, 0x73,
	0x65, 0x63, 0x75, 0x72, 0x69, 0x74, 0x79, 0x4d, 0x61, 0x72, 0x6b, 0x73, 0x42, 0x7e, 0x0a, 0x27,
	0x63, 0x6f, 0x6d, 0x2e, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2e, 0x63, 0x6c, 0x6f, 0x75, 0x64,
	0x2e, 0x73, 0x65, 0x63, 0x75, 0x72, 0x69, 0x74, 0x79, 0x63, 0x65, 0x6e, 0x74, 0x65, 0x72, 0x2e,
	0x76, 0x31, 0x62, 0x65, 0x74, 0x61, 0x31, 0x50, 0x01, 0x5a, 0x51, 0x67, 0x6f, 0x6f, 0x67, 0x6c,
	0x65, 0x2e, 0x67, 0x6f, 0x6c, 0x61, 0x6e, 0x67, 0x2e, 0x6f, 0x72, 0x67, 0x2f, 0x67, 0x65, 0x6e,
	0x70, 0x72, 0x6f, 0x74, 0x6f, 0x2f, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x61, 0x70, 0x69, 0x73,
	0x2f, 0x63, 0x6c, 0x6f, 0x75, 0x64, 0x2f, 0x73, 0x65, 0x63, 0x75, 0x72, 0x69, 0x74, 0x79, 0x63,
	0x65, 0x6e, 0x74, 0x65, 0x72, 0x2f, 0x76, 0x31, 0x62, 0x65, 0x74, 0x61, 0x31, 0x3b, 0x73, 0x65,
	0x63, 0x75, 0x72, 0x69, 0x74, 0x79, 0x63, 0x65, 0x6e, 0x74, 0x65, 0x72, 0x62, 0x06, 0x70, 0x72,
	0x6f, 0x74, 0x6f, 0x33,
}

var (
	file_google_cloud_securitycenter_v1beta1_security_marks_proto_rawDescOnce sync.Once
	file_google_cloud_securitycenter_v1beta1_security_marks_proto_rawDescData = file_google_cloud_securitycenter_v1beta1_security_marks_proto_rawDesc
)

func file_google_cloud_securitycenter_v1beta1_security_marks_proto_rawDescGZIP() []byte {
	file_google_cloud_securitycenter_v1beta1_security_marks_proto_rawDescOnce.Do(func() {
		file_google_cloud_securitycenter_v1beta1_security_marks_proto_rawDescData = protoimpl.X.CompressGZIP(file_google_cloud_securitycenter_v1beta1_security_marks_proto_rawDescData)
	})
	return file_google_cloud_securitycenter_v1beta1_security_marks_proto_rawDescData
}

var file_google_cloud_securitycenter_v1beta1_security_marks_proto_msgTypes = make([]protoimpl.MessageInfo, 2)
var file_google_cloud_securitycenter_v1beta1_security_marks_proto_goTypes = []interface{}{
	(*SecurityMarks)(nil), // 0: google.cloud.securitycenter.v1beta1.SecurityMarks
	nil,                   // 1: google.cloud.securitycenter.v1beta1.SecurityMarks.MarksEntry
}
var file_google_cloud_securitycenter_v1beta1_security_marks_proto_depIdxs = []int32{
	1, // 0: google.cloud.securitycenter.v1beta1.SecurityMarks.marks:type_name -> google.cloud.securitycenter.v1beta1.SecurityMarks.MarksEntry
	1, // [1:1] is the sub-list for method output_type
	1, // [1:1] is the sub-list for method input_type
	1, // [1:1] is the sub-list for extension type_name
	1, // [1:1] is the sub-list for extension extendee
	0, // [0:1] is the sub-list for field type_name
}

func init() { file_google_cloud_securitycenter_v1beta1_security_marks_proto_init() }
func file_google_cloud_securitycenter_v1beta1_security_marks_proto_init() {
	if File_google_cloud_securitycenter_v1beta1_security_marks_proto != nil {
		return
	}
	if !protoimpl.UnsafeEnabled {
		file_google_cloud_securitycenter_v1beta1_security_marks_proto_msgTypes[0].Exporter = func(v interface{}, i int) interface{} {
			switch v := v.(*SecurityMarks); i {
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
			RawDescriptor: file_google_cloud_securitycenter_v1beta1_security_marks_proto_rawDesc,
			NumEnums:      0,
			NumMessages:   2,
			NumExtensions: 0,
			NumServices:   0,
		},
		GoTypes:           file_google_cloud_securitycenter_v1beta1_security_marks_proto_goTypes,
		DependencyIndexes: file_google_cloud_securitycenter_v1beta1_security_marks_proto_depIdxs,
		MessageInfos:      file_google_cloud_securitycenter_v1beta1_security_marks_proto_msgTypes,
	}.Build()
	File_google_cloud_securitycenter_v1beta1_security_marks_proto = out.File
	file_google_cloud_securitycenter_v1beta1_security_marks_proto_rawDesc = nil
	file_google_cloud_securitycenter_v1beta1_security_marks_proto_goTypes = nil
	file_google_cloud_securitycenter_v1beta1_security_marks_proto_depIdxs = nil
}
