// Copyright 2019 The Grafeas Authors. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
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
// source: grafeas/v1/attestation.proto

package grafeas

import (
	proto "github.com/golang/protobuf/proto"
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

// Note kind that represents a logical attestation "role" or "authority". For
// example, an organization might have one `Authority` for "QA" and one for
// "build". This note is intended to act strictly as a grouping mechanism for
// the attached occurrences (Attestations). This grouping mechanism also
// provides a security boundary, since IAM ACLs gate the ability for a principle
// to attach an occurrence to a given note. It also provides a single point of
// lookup to find all attached attestation occurrences, even if they don't all
// live in the same project.
type AttestationNote struct {
	state         protoimpl.MessageState
	sizeCache     protoimpl.SizeCache
	unknownFields protoimpl.UnknownFields

	// Hint hints at the purpose of the attestation authority.
	Hint *AttestationNote_Hint `protobuf:"bytes,1,opt,name=hint,proto3" json:"hint,omitempty"`
}

func (x *AttestationNote) Reset() {
	*x = AttestationNote{}
	if protoimpl.UnsafeEnabled {
		mi := &file_grafeas_v1_attestation_proto_msgTypes[0]
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		ms.StoreMessageInfo(mi)
	}
}

func (x *AttestationNote) String() string {
	return protoimpl.X.MessageStringOf(x)
}

func (*AttestationNote) ProtoMessage() {}

func (x *AttestationNote) ProtoReflect() protoreflect.Message {
	mi := &file_grafeas_v1_attestation_proto_msgTypes[0]
	if protoimpl.UnsafeEnabled && x != nil {
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		if ms.LoadMessageInfo() == nil {
			ms.StoreMessageInfo(mi)
		}
		return ms
	}
	return mi.MessageOf(x)
}

// Deprecated: Use AttestationNote.ProtoReflect.Descriptor instead.
func (*AttestationNote) Descriptor() ([]byte, []int) {
	return file_grafeas_v1_attestation_proto_rawDescGZIP(), []int{0}
}

func (x *AttestationNote) GetHint() *AttestationNote_Hint {
	if x != nil {
		return x.Hint
	}
	return nil
}

// Occurrence that represents a single "attestation". The authenticity of an
// attestation can be verified using the attached signature. If the verifier
// trusts the public key of the signer, then verifying the signature is
// sufficient to establish trust. In this circumstance, the authority to which
// this attestation is attached is primarily useful for lookup (how to find
// this attestation if you already know the authority and artifact to be
// verified) and intent (for which authority this attestation was intended to
// sign.
type AttestationOccurrence struct {
	state         protoimpl.MessageState
	sizeCache     protoimpl.SizeCache
	unknownFields protoimpl.UnknownFields

	// Required. The serialized payload that is verified by one or more
	// `signatures`.
	SerializedPayload []byte `protobuf:"bytes,1,opt,name=serialized_payload,json=serializedPayload,proto3" json:"serialized_payload,omitempty"`
	// One or more signatures over `serialized_payload`.  Verifier implementations
	// should consider this attestation message verified if at least one
	// `signature` verifies `serialized_payload`.  See `Signature` in common.proto
	// for more details on signature structure and verification.
	Signatures []*Signature `protobuf:"bytes,2,rep,name=signatures,proto3" json:"signatures,omitempty"`
}

func (x *AttestationOccurrence) Reset() {
	*x = AttestationOccurrence{}
	if protoimpl.UnsafeEnabled {
		mi := &file_grafeas_v1_attestation_proto_msgTypes[1]
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		ms.StoreMessageInfo(mi)
	}
}

func (x *AttestationOccurrence) String() string {
	return protoimpl.X.MessageStringOf(x)
}

func (*AttestationOccurrence) ProtoMessage() {}

func (x *AttestationOccurrence) ProtoReflect() protoreflect.Message {
	mi := &file_grafeas_v1_attestation_proto_msgTypes[1]
	if protoimpl.UnsafeEnabled && x != nil {
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		if ms.LoadMessageInfo() == nil {
			ms.StoreMessageInfo(mi)
		}
		return ms
	}
	return mi.MessageOf(x)
}

// Deprecated: Use AttestationOccurrence.ProtoReflect.Descriptor instead.
func (*AttestationOccurrence) Descriptor() ([]byte, []int) {
	return file_grafeas_v1_attestation_proto_rawDescGZIP(), []int{1}
}

func (x *AttestationOccurrence) GetSerializedPayload() []byte {
	if x != nil {
		return x.SerializedPayload
	}
	return nil
}

func (x *AttestationOccurrence) GetSignatures() []*Signature {
	if x != nil {
		return x.Signatures
	}
	return nil
}

// This submessage provides human-readable hints about the purpose of the
// authority. Because the name of a note acts as its resource reference, it is
// important to disambiguate the canonical name of the Note (which might be a
// UUID for security purposes) from "readable" names more suitable for debug
// output. Note that these hints should not be used to look up authorities in
// security sensitive contexts, such as when looking up attestations to
// verify.
type AttestationNote_Hint struct {
	state         protoimpl.MessageState
	sizeCache     protoimpl.SizeCache
	unknownFields protoimpl.UnknownFields

	// Required. The human readable name of this attestation authority, for
	// example "qa".
	HumanReadableName string `protobuf:"bytes,1,opt,name=human_readable_name,json=humanReadableName,proto3" json:"human_readable_name,omitempty"`
}

func (x *AttestationNote_Hint) Reset() {
	*x = AttestationNote_Hint{}
	if protoimpl.UnsafeEnabled {
		mi := &file_grafeas_v1_attestation_proto_msgTypes[2]
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		ms.StoreMessageInfo(mi)
	}
}

func (x *AttestationNote_Hint) String() string {
	return protoimpl.X.MessageStringOf(x)
}

func (*AttestationNote_Hint) ProtoMessage() {}

func (x *AttestationNote_Hint) ProtoReflect() protoreflect.Message {
	mi := &file_grafeas_v1_attestation_proto_msgTypes[2]
	if protoimpl.UnsafeEnabled && x != nil {
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		if ms.LoadMessageInfo() == nil {
			ms.StoreMessageInfo(mi)
		}
		return ms
	}
	return mi.MessageOf(x)
}

// Deprecated: Use AttestationNote_Hint.ProtoReflect.Descriptor instead.
func (*AttestationNote_Hint) Descriptor() ([]byte, []int) {
	return file_grafeas_v1_attestation_proto_rawDescGZIP(), []int{0, 0}
}

func (x *AttestationNote_Hint) GetHumanReadableName() string {
	if x != nil {
		return x.HumanReadableName
	}
	return ""
}

var File_grafeas_v1_attestation_proto protoreflect.FileDescriptor

var file_grafeas_v1_attestation_proto_rawDesc = []byte{
	0x0a, 0x1c, 0x67, 0x72, 0x61, 0x66, 0x65, 0x61, 0x73, 0x2f, 0x76, 0x31, 0x2f, 0x61, 0x74, 0x74,
	0x65, 0x73, 0x74, 0x61, 0x74, 0x69, 0x6f, 0x6e, 0x2e, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x12, 0x0a,
	0x67, 0x72, 0x61, 0x66, 0x65, 0x61, 0x73, 0x2e, 0x76, 0x31, 0x1a, 0x17, 0x67, 0x72, 0x61, 0x66,
	0x65, 0x61, 0x73, 0x2f, 0x76, 0x31, 0x2f, 0x63, 0x6f, 0x6d, 0x6d, 0x6f, 0x6e, 0x2e, 0x70, 0x72,
	0x6f, 0x74, 0x6f, 0x22, 0x7f, 0x0a, 0x0f, 0x41, 0x74, 0x74, 0x65, 0x73, 0x74, 0x61, 0x74, 0x69,
	0x6f, 0x6e, 0x4e, 0x6f, 0x74, 0x65, 0x12, 0x34, 0x0a, 0x04, 0x68, 0x69, 0x6e, 0x74, 0x18, 0x01,
	0x20, 0x01, 0x28, 0x0b, 0x32, 0x20, 0x2e, 0x67, 0x72, 0x61, 0x66, 0x65, 0x61, 0x73, 0x2e, 0x76,
	0x31, 0x2e, 0x41, 0x74, 0x74, 0x65, 0x73, 0x74, 0x61, 0x74, 0x69, 0x6f, 0x6e, 0x4e, 0x6f, 0x74,
	0x65, 0x2e, 0x48, 0x69, 0x6e, 0x74, 0x52, 0x04, 0x68, 0x69, 0x6e, 0x74, 0x1a, 0x36, 0x0a, 0x04,
	0x48, 0x69, 0x6e, 0x74, 0x12, 0x2e, 0x0a, 0x13, 0x68, 0x75, 0x6d, 0x61, 0x6e, 0x5f, 0x72, 0x65,
	0x61, 0x64, 0x61, 0x62, 0x6c, 0x65, 0x5f, 0x6e, 0x61, 0x6d, 0x65, 0x18, 0x01, 0x20, 0x01, 0x28,
	0x09, 0x52, 0x11, 0x68, 0x75, 0x6d, 0x61, 0x6e, 0x52, 0x65, 0x61, 0x64, 0x61, 0x62, 0x6c, 0x65,
	0x4e, 0x61, 0x6d, 0x65, 0x22, 0x7d, 0x0a, 0x15, 0x41, 0x74, 0x74, 0x65, 0x73, 0x74, 0x61, 0x74,
	0x69, 0x6f, 0x6e, 0x4f, 0x63, 0x63, 0x75, 0x72, 0x72, 0x65, 0x6e, 0x63, 0x65, 0x12, 0x2d, 0x0a,
	0x12, 0x73, 0x65, 0x72, 0x69, 0x61, 0x6c, 0x69, 0x7a, 0x65, 0x64, 0x5f, 0x70, 0x61, 0x79, 0x6c,
	0x6f, 0x61, 0x64, 0x18, 0x01, 0x20, 0x01, 0x28, 0x0c, 0x52, 0x11, 0x73, 0x65, 0x72, 0x69, 0x61,
	0x6c, 0x69, 0x7a, 0x65, 0x64, 0x50, 0x61, 0x79, 0x6c, 0x6f, 0x61, 0x64, 0x12, 0x35, 0x0a, 0x0a,
	0x73, 0x69, 0x67, 0x6e, 0x61, 0x74, 0x75, 0x72, 0x65, 0x73, 0x18, 0x02, 0x20, 0x03, 0x28, 0x0b,
	0x32, 0x15, 0x2e, 0x67, 0x72, 0x61, 0x66, 0x65, 0x61, 0x73, 0x2e, 0x76, 0x31, 0x2e, 0x53, 0x69,
	0x67, 0x6e, 0x61, 0x74, 0x75, 0x72, 0x65, 0x52, 0x0a, 0x73, 0x69, 0x67, 0x6e, 0x61, 0x74, 0x75,
	0x72, 0x65, 0x73, 0x42, 0x51, 0x0a, 0x0d, 0x69, 0x6f, 0x2e, 0x67, 0x72, 0x61, 0x66, 0x65, 0x61,
	0x73, 0x2e, 0x76, 0x31, 0x50, 0x01, 0x5a, 0x38, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2e, 0x67,
	0x6f, 0x6c, 0x61, 0x6e, 0x67, 0x2e, 0x6f, 0x72, 0x67, 0x2f, 0x67, 0x65, 0x6e, 0x70, 0x72, 0x6f,
	0x74, 0x6f, 0x2f, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x61, 0x70, 0x69, 0x73, 0x2f, 0x67, 0x72,
	0x61, 0x66, 0x65, 0x61, 0x73, 0x2f, 0x76, 0x31, 0x3b, 0x67, 0x72, 0x61, 0x66, 0x65, 0x61, 0x73,
	0xa2, 0x02, 0x03, 0x47, 0x52, 0x41, 0x62, 0x06, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x33,
}

var (
	file_grafeas_v1_attestation_proto_rawDescOnce sync.Once
	file_grafeas_v1_attestation_proto_rawDescData = file_grafeas_v1_attestation_proto_rawDesc
)

func file_grafeas_v1_attestation_proto_rawDescGZIP() []byte {
	file_grafeas_v1_attestation_proto_rawDescOnce.Do(func() {
		file_grafeas_v1_attestation_proto_rawDescData = protoimpl.X.CompressGZIP(file_grafeas_v1_attestation_proto_rawDescData)
	})
	return file_grafeas_v1_attestation_proto_rawDescData
}

var file_grafeas_v1_attestation_proto_msgTypes = make([]protoimpl.MessageInfo, 3)
var file_grafeas_v1_attestation_proto_goTypes = []interface{}{
	(*AttestationNote)(nil),       // 0: grafeas.v1.AttestationNote
	(*AttestationOccurrence)(nil), // 1: grafeas.v1.AttestationOccurrence
	(*AttestationNote_Hint)(nil),  // 2: grafeas.v1.AttestationNote.Hint
	(*Signature)(nil),             // 3: grafeas.v1.Signature
}
var file_grafeas_v1_attestation_proto_depIdxs = []int32{
	2, // 0: grafeas.v1.AttestationNote.hint:type_name -> grafeas.v1.AttestationNote.Hint
	3, // 1: grafeas.v1.AttestationOccurrence.signatures:type_name -> grafeas.v1.Signature
	2, // [2:2] is the sub-list for method output_type
	2, // [2:2] is the sub-list for method input_type
	2, // [2:2] is the sub-list for extension type_name
	2, // [2:2] is the sub-list for extension extendee
	0, // [0:2] is the sub-list for field type_name
}

func init() { file_grafeas_v1_attestation_proto_init() }
func file_grafeas_v1_attestation_proto_init() {
	if File_grafeas_v1_attestation_proto != nil {
		return
	}
	file_grafeas_v1_common_proto_init()
	if !protoimpl.UnsafeEnabled {
		file_grafeas_v1_attestation_proto_msgTypes[0].Exporter = func(v interface{}, i int) interface{} {
			switch v := v.(*AttestationNote); i {
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
		file_grafeas_v1_attestation_proto_msgTypes[1].Exporter = func(v interface{}, i int) interface{} {
			switch v := v.(*AttestationOccurrence); i {
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
		file_grafeas_v1_attestation_proto_msgTypes[2].Exporter = func(v interface{}, i int) interface{} {
			switch v := v.(*AttestationNote_Hint); i {
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
			RawDescriptor: file_grafeas_v1_attestation_proto_rawDesc,
			NumEnums:      0,
			NumMessages:   3,
			NumExtensions: 0,
			NumServices:   0,
		},
		GoTypes:           file_grafeas_v1_attestation_proto_goTypes,
		DependencyIndexes: file_grafeas_v1_attestation_proto_depIdxs,
		MessageInfos:      file_grafeas_v1_attestation_proto_msgTypes,
	}.Build()
	File_grafeas_v1_attestation_proto = out.File
	file_grafeas_v1_attestation_proto_rawDesc = nil
	file_grafeas_v1_attestation_proto_goTypes = nil
	file_grafeas_v1_attestation_proto_depIdxs = nil
}
