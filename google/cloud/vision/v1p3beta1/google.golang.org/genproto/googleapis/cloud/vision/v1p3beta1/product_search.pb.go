// Copyright 2019 Google LLC.
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
//

// Code generated by protoc-gen-go. DO NOT EDIT.
// versions:
// 	protoc-gen-go v1.25.0
// 	protoc        v3.15.3
// source: google/cloud/vision/v1p3beta1/product_search.proto

package vision

import (
	proto "github.com/golang/protobuf/proto"
	_ "google.golang.org/genproto/googleapis/api/annotations"
	protoreflect "google.golang.org/protobuf/reflect/protoreflect"
	protoimpl "google.golang.org/protobuf/runtime/protoimpl"
	timestamppb "google.golang.org/protobuf/types/known/timestamppb"
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

// Supported product search categories.
type ProductSearchCategory int32

const (
	// Default value used when a category is not specified.
	ProductSearchCategory_PRODUCT_SEARCH_CATEGORY_UNSPECIFIED ProductSearchCategory = 0
	// Shoes category.
	ProductSearchCategory_SHOES ProductSearchCategory = 1
	// Bags category.
	ProductSearchCategory_BAGS ProductSearchCategory = 2
)

// Enum value maps for ProductSearchCategory.
var (
	ProductSearchCategory_name = map[int32]string{
		0: "PRODUCT_SEARCH_CATEGORY_UNSPECIFIED",
		1: "SHOES",
		2: "BAGS",
	}
	ProductSearchCategory_value = map[string]int32{
		"PRODUCT_SEARCH_CATEGORY_UNSPECIFIED": 0,
		"SHOES":                               1,
		"BAGS":                                2,
	}
)

func (x ProductSearchCategory) Enum() *ProductSearchCategory {
	p := new(ProductSearchCategory)
	*p = x
	return p
}

func (x ProductSearchCategory) String() string {
	return protoimpl.X.EnumStringOf(x.Descriptor(), protoreflect.EnumNumber(x))
}

func (ProductSearchCategory) Descriptor() protoreflect.EnumDescriptor {
	return file_google_cloud_vision_v1p3beta1_product_search_proto_enumTypes[0].Descriptor()
}

func (ProductSearchCategory) Type() protoreflect.EnumType {
	return &file_google_cloud_vision_v1p3beta1_product_search_proto_enumTypes[0]
}

func (x ProductSearchCategory) Number() protoreflect.EnumNumber {
	return protoreflect.EnumNumber(x)
}

// Deprecated: Use ProductSearchCategory.Descriptor instead.
func (ProductSearchCategory) EnumDescriptor() ([]byte, []int) {
	return file_google_cloud_vision_v1p3beta1_product_search_proto_rawDescGZIP(), []int{0}
}

// Specifies the fields to include in product search results.
type ProductSearchResultsView int32

const (
	// Product search results contain only `product_category` and `product_id`.
	// Default value.
	ProductSearchResultsView_BASIC ProductSearchResultsView = 0
	// Product search results contain `product_category`, `product_id`,
	// `image_uri`, and `score`.
	ProductSearchResultsView_FULL ProductSearchResultsView = 1
)

// Enum value maps for ProductSearchResultsView.
var (
	ProductSearchResultsView_name = map[int32]string{
		0: "BASIC",
		1: "FULL",
	}
	ProductSearchResultsView_value = map[string]int32{
		"BASIC": 0,
		"FULL":  1,
	}
)

func (x ProductSearchResultsView) Enum() *ProductSearchResultsView {
	p := new(ProductSearchResultsView)
	*p = x
	return p
}

func (x ProductSearchResultsView) String() string {
	return protoimpl.X.EnumStringOf(x.Descriptor(), protoreflect.EnumNumber(x))
}

func (ProductSearchResultsView) Descriptor() protoreflect.EnumDescriptor {
	return file_google_cloud_vision_v1p3beta1_product_search_proto_enumTypes[1].Descriptor()
}

func (ProductSearchResultsView) Type() protoreflect.EnumType {
	return &file_google_cloud_vision_v1p3beta1_product_search_proto_enumTypes[1]
}

func (x ProductSearchResultsView) Number() protoreflect.EnumNumber {
	return protoreflect.EnumNumber(x)
}

// Deprecated: Use ProductSearchResultsView.Descriptor instead.
func (ProductSearchResultsView) EnumDescriptor() ([]byte, []int) {
	return file_google_cloud_vision_v1p3beta1_product_search_proto_rawDescGZIP(), []int{1}
}

// Parameters for a product search request.
type ProductSearchParams struct {
	state         protoimpl.MessageState
	sizeCache     protoimpl.SizeCache
	unknownFields protoimpl.UnknownFields

	// The resource name of the catalog to search.
	//
	// Format is: `productSearch/catalogs/CATALOG_NAME`.
	CatalogName string `protobuf:"bytes,1,opt,name=catalog_name,json=catalogName,proto3" json:"catalog_name,omitempty"`
	// The category to search in.
	// Optional. It is inferred by the system if it is not specified.
	// [Deprecated] Use `product_category`.
	Category ProductSearchCategory `protobuf:"varint,2,opt,name=category,proto3,enum=google.cloud.vision.v1p3beta1.ProductSearchCategory" json:"category,omitempty"`
	// The product category to search in.
	// Optional. It is inferred by the system if it is not specified.
	// Supported values are `bag`, `shoe`, `sunglasses`, `dress`, `outerwear`,
	// `skirt`, `top`, `shorts`, and `pants`.
	ProductCategory string `protobuf:"bytes,5,opt,name=product_category,json=productCategory,proto3" json:"product_category,omitempty"`
	// The bounding polygon around the area of interest in the image.
	// Optional. If it is not specified, system discretion will be applied.
	// [Deprecated] Use `bounding_poly`.
	NormalizedBoundingPoly *NormalizedBoundingPoly `protobuf:"bytes,3,opt,name=normalized_bounding_poly,json=normalizedBoundingPoly,proto3" json:"normalized_bounding_poly,omitempty"`
	// The bounding polygon around the area of interest in the image.
	// Optional. If it is not specified, system discretion will be applied.
	BoundingPoly *BoundingPoly `protobuf:"bytes,9,opt,name=bounding_poly,json=boundingPoly,proto3" json:"bounding_poly,omitempty"`
	// Specifies the verbosity of the  product search results.
	// Optional. Defaults to `BASIC`.
	View ProductSearchResultsView `protobuf:"varint,4,opt,name=view,proto3,enum=google.cloud.vision.v1p3beta1.ProductSearchResultsView" json:"view,omitempty"`
	// The resource name of a
	// [ProductSet][google.cloud.vision.v1p3beta1.ProductSet] to be searched for
	// similar images.
	//
	// Format is:
	// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`.
	ProductSet string `protobuf:"bytes,6,opt,name=product_set,json=productSet,proto3" json:"product_set,omitempty"`
	// The list of product categories to search in. Currently, we only consider
	// the first category, and either "homegoods" or "apparel" should be
	// specified.
	ProductCategories []string `protobuf:"bytes,7,rep,name=product_categories,json=productCategories,proto3" json:"product_categories,omitempty"`
	// The filtering expression. This can be used to restrict search results based
	// on Product labels. We currently support an AND of OR of key-value
	// expressions, where each expression within an OR must have the same key.
	//
	// For example, "(color = red OR color = blue) AND brand = Google" is
	// acceptable, but not "(color = red OR brand = Google)" or "color: red".
	Filter string `protobuf:"bytes,8,opt,name=filter,proto3" json:"filter,omitempty"`
}

func (x *ProductSearchParams) Reset() {
	*x = ProductSearchParams{}
	if protoimpl.UnsafeEnabled {
		mi := &file_google_cloud_vision_v1p3beta1_product_search_proto_msgTypes[0]
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		ms.StoreMessageInfo(mi)
	}
}

func (x *ProductSearchParams) String() string {
	return protoimpl.X.MessageStringOf(x)
}

func (*ProductSearchParams) ProtoMessage() {}

func (x *ProductSearchParams) ProtoReflect() protoreflect.Message {
	mi := &file_google_cloud_vision_v1p3beta1_product_search_proto_msgTypes[0]
	if protoimpl.UnsafeEnabled && x != nil {
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		if ms.LoadMessageInfo() == nil {
			ms.StoreMessageInfo(mi)
		}
		return ms
	}
	return mi.MessageOf(x)
}

// Deprecated: Use ProductSearchParams.ProtoReflect.Descriptor instead.
func (*ProductSearchParams) Descriptor() ([]byte, []int) {
	return file_google_cloud_vision_v1p3beta1_product_search_proto_rawDescGZIP(), []int{0}
}

func (x *ProductSearchParams) GetCatalogName() string {
	if x != nil {
		return x.CatalogName
	}
	return ""
}

func (x *ProductSearchParams) GetCategory() ProductSearchCategory {
	if x != nil {
		return x.Category
	}
	return ProductSearchCategory_PRODUCT_SEARCH_CATEGORY_UNSPECIFIED
}

func (x *ProductSearchParams) GetProductCategory() string {
	if x != nil {
		return x.ProductCategory
	}
	return ""
}

func (x *ProductSearchParams) GetNormalizedBoundingPoly() *NormalizedBoundingPoly {
	if x != nil {
		return x.NormalizedBoundingPoly
	}
	return nil
}

func (x *ProductSearchParams) GetBoundingPoly() *BoundingPoly {
	if x != nil {
		return x.BoundingPoly
	}
	return nil
}

func (x *ProductSearchParams) GetView() ProductSearchResultsView {
	if x != nil {
		return x.View
	}
	return ProductSearchResultsView_BASIC
}

func (x *ProductSearchParams) GetProductSet() string {
	if x != nil {
		return x.ProductSet
	}
	return ""
}

func (x *ProductSearchParams) GetProductCategories() []string {
	if x != nil {
		return x.ProductCategories
	}
	return nil
}

func (x *ProductSearchParams) GetFilter() string {
	if x != nil {
		return x.Filter
	}
	return ""
}

// Results for a product search request.
type ProductSearchResults struct {
	state         protoimpl.MessageState
	sizeCache     protoimpl.SizeCache
	unknownFields protoimpl.UnknownFields

	// Product category.
	// [Deprecated] Use `product_category`.
	Category ProductSearchCategory `protobuf:"varint,1,opt,name=category,proto3,enum=google.cloud.vision.v1p3beta1.ProductSearchCategory" json:"category,omitempty"`
	// Product category.
	// Supported values are `bag` and `shoe`.
	// [Deprecated] `product_category` is provided in each Product.
	ProductCategory string `protobuf:"bytes,4,opt,name=product_category,json=productCategory,proto3" json:"product_category,omitempty"`
	// Timestamp of the index which provided these results. Changes made after
	// this time are not reflected in the current results.
	IndexTime *timestamppb.Timestamp `protobuf:"bytes,2,opt,name=index_time,json=indexTime,proto3" json:"index_time,omitempty"`
	// List of detected products.
	Products []*ProductSearchResults_ProductInfo `protobuf:"bytes,3,rep,name=products,proto3" json:"products,omitempty"`
	// List of results, one for each product match.
	Results []*ProductSearchResults_Result `protobuf:"bytes,5,rep,name=results,proto3" json:"results,omitempty"`
}

func (x *ProductSearchResults) Reset() {
	*x = ProductSearchResults{}
	if protoimpl.UnsafeEnabled {
		mi := &file_google_cloud_vision_v1p3beta1_product_search_proto_msgTypes[1]
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		ms.StoreMessageInfo(mi)
	}
}

func (x *ProductSearchResults) String() string {
	return protoimpl.X.MessageStringOf(x)
}

func (*ProductSearchResults) ProtoMessage() {}

func (x *ProductSearchResults) ProtoReflect() protoreflect.Message {
	mi := &file_google_cloud_vision_v1p3beta1_product_search_proto_msgTypes[1]
	if protoimpl.UnsafeEnabled && x != nil {
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		if ms.LoadMessageInfo() == nil {
			ms.StoreMessageInfo(mi)
		}
		return ms
	}
	return mi.MessageOf(x)
}

// Deprecated: Use ProductSearchResults.ProtoReflect.Descriptor instead.
func (*ProductSearchResults) Descriptor() ([]byte, []int) {
	return file_google_cloud_vision_v1p3beta1_product_search_proto_rawDescGZIP(), []int{1}
}

func (x *ProductSearchResults) GetCategory() ProductSearchCategory {
	if x != nil {
		return x.Category
	}
	return ProductSearchCategory_PRODUCT_SEARCH_CATEGORY_UNSPECIFIED
}

func (x *ProductSearchResults) GetProductCategory() string {
	if x != nil {
		return x.ProductCategory
	}
	return ""
}

func (x *ProductSearchResults) GetIndexTime() *timestamppb.Timestamp {
	if x != nil {
		return x.IndexTime
	}
	return nil
}

func (x *ProductSearchResults) GetProducts() []*ProductSearchResults_ProductInfo {
	if x != nil {
		return x.Products
	}
	return nil
}

func (x *ProductSearchResults) GetResults() []*ProductSearchResults_Result {
	if x != nil {
		return x.Results
	}
	return nil
}

// Information about a product.
type ProductSearchResults_ProductInfo struct {
	state         protoimpl.MessageState
	sizeCache     protoimpl.SizeCache
	unknownFields protoimpl.UnknownFields

	// Product ID.
	ProductId string `protobuf:"bytes,1,opt,name=product_id,json=productId,proto3" json:"product_id,omitempty"`
	// The URI of the image which matched the query image.
	//
	// This field is returned only if `view` is set to `FULL` in
	// the request.
	ImageUri string `protobuf:"bytes,2,opt,name=image_uri,json=imageUri,proto3" json:"image_uri,omitempty"`
	// A confidence level on the match, ranging from 0 (no confidence) to
	// 1 (full confidence).
	//
	// This field is returned only if `view` is set to `FULL` in
	// the request.
	Score float32 `protobuf:"fixed32,3,opt,name=score,proto3" json:"score,omitempty"`
}

func (x *ProductSearchResults_ProductInfo) Reset() {
	*x = ProductSearchResults_ProductInfo{}
	if protoimpl.UnsafeEnabled {
		mi := &file_google_cloud_vision_v1p3beta1_product_search_proto_msgTypes[2]
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		ms.StoreMessageInfo(mi)
	}
}

func (x *ProductSearchResults_ProductInfo) String() string {
	return protoimpl.X.MessageStringOf(x)
}

func (*ProductSearchResults_ProductInfo) ProtoMessage() {}

func (x *ProductSearchResults_ProductInfo) ProtoReflect() protoreflect.Message {
	mi := &file_google_cloud_vision_v1p3beta1_product_search_proto_msgTypes[2]
	if protoimpl.UnsafeEnabled && x != nil {
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		if ms.LoadMessageInfo() == nil {
			ms.StoreMessageInfo(mi)
		}
		return ms
	}
	return mi.MessageOf(x)
}

// Deprecated: Use ProductSearchResults_ProductInfo.ProtoReflect.Descriptor instead.
func (*ProductSearchResults_ProductInfo) Descriptor() ([]byte, []int) {
	return file_google_cloud_vision_v1p3beta1_product_search_proto_rawDescGZIP(), []int{1, 0}
}

func (x *ProductSearchResults_ProductInfo) GetProductId() string {
	if x != nil {
		return x.ProductId
	}
	return ""
}

func (x *ProductSearchResults_ProductInfo) GetImageUri() string {
	if x != nil {
		return x.ImageUri
	}
	return ""
}

func (x *ProductSearchResults_ProductInfo) GetScore() float32 {
	if x != nil {
		return x.Score
	}
	return 0
}

// Information about a product.
type ProductSearchResults_Result struct {
	state         protoimpl.MessageState
	sizeCache     protoimpl.SizeCache
	unknownFields protoimpl.UnknownFields

	// The Product.
	Product *Product `protobuf:"bytes,1,opt,name=product,proto3" json:"product,omitempty"`
	// A confidence level on the match, ranging from 0 (no confidence) to
	// 1 (full confidence).
	//
	// This field is returned only if `view` is set to `FULL` in
	// the request.
	Score float32 `protobuf:"fixed32,2,opt,name=score,proto3" json:"score,omitempty"`
	// The resource name of the image from the product that is the closest match
	// to the query.
	Image string `protobuf:"bytes,3,opt,name=image,proto3" json:"image,omitempty"`
}

func (x *ProductSearchResults_Result) Reset() {
	*x = ProductSearchResults_Result{}
	if protoimpl.UnsafeEnabled {
		mi := &file_google_cloud_vision_v1p3beta1_product_search_proto_msgTypes[3]
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		ms.StoreMessageInfo(mi)
	}
}

func (x *ProductSearchResults_Result) String() string {
	return protoimpl.X.MessageStringOf(x)
}

func (*ProductSearchResults_Result) ProtoMessage() {}

func (x *ProductSearchResults_Result) ProtoReflect() protoreflect.Message {
	mi := &file_google_cloud_vision_v1p3beta1_product_search_proto_msgTypes[3]
	if protoimpl.UnsafeEnabled && x != nil {
		ms := protoimpl.X.MessageStateOf(protoimpl.Pointer(x))
		if ms.LoadMessageInfo() == nil {
			ms.StoreMessageInfo(mi)
		}
		return ms
	}
	return mi.MessageOf(x)
}

// Deprecated: Use ProductSearchResults_Result.ProtoReflect.Descriptor instead.
func (*ProductSearchResults_Result) Descriptor() ([]byte, []int) {
	return file_google_cloud_vision_v1p3beta1_product_search_proto_rawDescGZIP(), []int{1, 1}
}

func (x *ProductSearchResults_Result) GetProduct() *Product {
	if x != nil {
		return x.Product
	}
	return nil
}

func (x *ProductSearchResults_Result) GetScore() float32 {
	if x != nil {
		return x.Score
	}
	return 0
}

func (x *ProductSearchResults_Result) GetImage() string {
	if x != nil {
		return x.Image
	}
	return ""
}

var File_google_cloud_vision_v1p3beta1_product_search_proto protoreflect.FileDescriptor

var file_google_cloud_vision_v1p3beta1_product_search_proto_rawDesc = []byte{
	0x0a, 0x32, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2f, 0x63, 0x6c, 0x6f, 0x75, 0x64, 0x2f, 0x76,
	0x69, 0x73, 0x69, 0x6f, 0x6e, 0x2f, 0x76, 0x31, 0x70, 0x33, 0x62, 0x65, 0x74, 0x61, 0x31, 0x2f,
	0x70, 0x72, 0x6f, 0x64, 0x75, 0x63, 0x74, 0x5f, 0x73, 0x65, 0x61, 0x72, 0x63, 0x68, 0x2e, 0x70,
	0x72, 0x6f, 0x74, 0x6f, 0x12, 0x1d, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2e, 0x63, 0x6c, 0x6f,
	0x75, 0x64, 0x2e, 0x76, 0x69, 0x73, 0x69, 0x6f, 0x6e, 0x2e, 0x76, 0x31, 0x70, 0x33, 0x62, 0x65,
	0x74, 0x61, 0x31, 0x1a, 0x1c, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2f, 0x61, 0x70, 0x69, 0x2f,
	0x61, 0x6e, 0x6e, 0x6f, 0x74, 0x61, 0x74, 0x69, 0x6f, 0x6e, 0x73, 0x2e, 0x70, 0x72, 0x6f, 0x74,
	0x6f, 0x1a, 0x19, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2f, 0x61, 0x70, 0x69, 0x2f, 0x72, 0x65,
	0x73, 0x6f, 0x75, 0x72, 0x63, 0x65, 0x2e, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x1a, 0x2c, 0x67, 0x6f,
	0x6f, 0x67, 0x6c, 0x65, 0x2f, 0x63, 0x6c, 0x6f, 0x75, 0x64, 0x2f, 0x76, 0x69, 0x73, 0x69, 0x6f,
	0x6e, 0x2f, 0x76, 0x31, 0x70, 0x33, 0x62, 0x65, 0x74, 0x61, 0x31, 0x2f, 0x67, 0x65, 0x6f, 0x6d,
	0x65, 0x74, 0x72, 0x79, 0x2e, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x1a, 0x3a, 0x67, 0x6f, 0x6f, 0x67,
	0x6c, 0x65, 0x2f, 0x63, 0x6c, 0x6f, 0x75, 0x64, 0x2f, 0x76, 0x69, 0x73, 0x69, 0x6f, 0x6e, 0x2f,
	0x76, 0x31, 0x70, 0x33, 0x62, 0x65, 0x74, 0x61, 0x31, 0x2f, 0x70, 0x72, 0x6f, 0x64, 0x75, 0x63,
	0x74, 0x5f, 0x73, 0x65, 0x61, 0x72, 0x63, 0x68, 0x5f, 0x73, 0x65, 0x72, 0x76, 0x69, 0x63, 0x65,
	0x2e, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x1a, 0x1f, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2f, 0x70,
	0x72, 0x6f, 0x74, 0x6f, 0x62, 0x75, 0x66, 0x2f, 0x74, 0x69, 0x6d, 0x65, 0x73, 0x74, 0x61, 0x6d,
	0x70, 0x2e, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x22, 0xd4, 0x04, 0x0a, 0x13, 0x50, 0x72, 0x6f, 0x64,
	0x75, 0x63, 0x74, 0x53, 0x65, 0x61, 0x72, 0x63, 0x68, 0x50, 0x61, 0x72, 0x61, 0x6d, 0x73, 0x12,
	0x21, 0x0a, 0x0c, 0x63, 0x61, 0x74, 0x61, 0x6c, 0x6f, 0x67, 0x5f, 0x6e, 0x61, 0x6d, 0x65, 0x18,
	0x01, 0x20, 0x01, 0x28, 0x09, 0x52, 0x0b, 0x63, 0x61, 0x74, 0x61, 0x6c, 0x6f, 0x67, 0x4e, 0x61,
	0x6d, 0x65, 0x12, 0x50, 0x0a, 0x08, 0x63, 0x61, 0x74, 0x65, 0x67, 0x6f, 0x72, 0x79, 0x18, 0x02,
	0x20, 0x01, 0x28, 0x0e, 0x32, 0x34, 0x2e, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2e, 0x63, 0x6c,
	0x6f, 0x75, 0x64, 0x2e, 0x76, 0x69, 0x73, 0x69, 0x6f, 0x6e, 0x2e, 0x76, 0x31, 0x70, 0x33, 0x62,
	0x65, 0x74, 0x61, 0x31, 0x2e, 0x50, 0x72, 0x6f, 0x64, 0x75, 0x63, 0x74, 0x53, 0x65, 0x61, 0x72,
	0x63, 0x68, 0x43, 0x61, 0x74, 0x65, 0x67, 0x6f, 0x72, 0x79, 0x52, 0x08, 0x63, 0x61, 0x74, 0x65,
	0x67, 0x6f, 0x72, 0x79, 0x12, 0x29, 0x0a, 0x10, 0x70, 0x72, 0x6f, 0x64, 0x75, 0x63, 0x74, 0x5f,
	0x63, 0x61, 0x74, 0x65, 0x67, 0x6f, 0x72, 0x79, 0x18, 0x05, 0x20, 0x01, 0x28, 0x09, 0x52, 0x0f,
	0x70, 0x72, 0x6f, 0x64, 0x75, 0x63, 0x74, 0x43, 0x61, 0x74, 0x65, 0x67, 0x6f, 0x72, 0x79, 0x12,
	0x6f, 0x0a, 0x18, 0x6e, 0x6f, 0x72, 0x6d, 0x61, 0x6c, 0x69, 0x7a, 0x65, 0x64, 0x5f, 0x62, 0x6f,
	0x75, 0x6e, 0x64, 0x69, 0x6e, 0x67, 0x5f, 0x70, 0x6f, 0x6c, 0x79, 0x18, 0x03, 0x20, 0x01, 0x28,
	0x0b, 0x32, 0x35, 0x2e, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2e, 0x63, 0x6c, 0x6f, 0x75, 0x64,
	0x2e, 0x76, 0x69, 0x73, 0x69, 0x6f, 0x6e, 0x2e, 0x76, 0x31, 0x70, 0x33, 0x62, 0x65, 0x74, 0x61,
	0x31, 0x2e, 0x4e, 0x6f, 0x72, 0x6d, 0x61, 0x6c, 0x69, 0x7a, 0x65, 0x64, 0x42, 0x6f, 0x75, 0x6e,
	0x64, 0x69, 0x6e, 0x67, 0x50, 0x6f, 0x6c, 0x79, 0x52, 0x16, 0x6e, 0x6f, 0x72, 0x6d, 0x61, 0x6c,
	0x69, 0x7a, 0x65, 0x64, 0x42, 0x6f, 0x75, 0x6e, 0x64, 0x69, 0x6e, 0x67, 0x50, 0x6f, 0x6c, 0x79,
	0x12, 0x50, 0x0a, 0x0d, 0x62, 0x6f, 0x75, 0x6e, 0x64, 0x69, 0x6e, 0x67, 0x5f, 0x70, 0x6f, 0x6c,
	0x79, 0x18, 0x09, 0x20, 0x01, 0x28, 0x0b, 0x32, 0x2b, 0x2e, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65,
	0x2e, 0x63, 0x6c, 0x6f, 0x75, 0x64, 0x2e, 0x76, 0x69, 0x73, 0x69, 0x6f, 0x6e, 0x2e, 0x76, 0x31,
	0x70, 0x33, 0x62, 0x65, 0x74, 0x61, 0x31, 0x2e, 0x42, 0x6f, 0x75, 0x6e, 0x64, 0x69, 0x6e, 0x67,
	0x50, 0x6f, 0x6c, 0x79, 0x52, 0x0c, 0x62, 0x6f, 0x75, 0x6e, 0x64, 0x69, 0x6e, 0x67, 0x50, 0x6f,
	0x6c, 0x79, 0x12, 0x4b, 0x0a, 0x04, 0x76, 0x69, 0x65, 0x77, 0x18, 0x04, 0x20, 0x01, 0x28, 0x0e,
	0x32, 0x37, 0x2e, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2e, 0x63, 0x6c, 0x6f, 0x75, 0x64, 0x2e,
	0x76, 0x69, 0x73, 0x69, 0x6f, 0x6e, 0x2e, 0x76, 0x31, 0x70, 0x33, 0x62, 0x65, 0x74, 0x61, 0x31,
	0x2e, 0x50, 0x72, 0x6f, 0x64, 0x75, 0x63, 0x74, 0x53, 0x65, 0x61, 0x72, 0x63, 0x68, 0x52, 0x65,
	0x73, 0x75, 0x6c, 0x74, 0x73, 0x56, 0x69, 0x65, 0x77, 0x52, 0x04, 0x76, 0x69, 0x65, 0x77, 0x12,
	0x46, 0x0a, 0x0b, 0x70, 0x72, 0x6f, 0x64, 0x75, 0x63, 0x74, 0x5f, 0x73, 0x65, 0x74, 0x18, 0x06,
	0x20, 0x01, 0x28, 0x09, 0x42, 0x25, 0xfa, 0x41, 0x22, 0x0a, 0x20, 0x76, 0x69, 0x73, 0x69, 0x6f,
	0x6e, 0x2e, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x61, 0x70, 0x69, 0x73, 0x2e, 0x63, 0x6f, 0x6d,
	0x2f, 0x50, 0x72, 0x6f, 0x64, 0x75, 0x63, 0x74, 0x53, 0x65, 0x74, 0x52, 0x0a, 0x70, 0x72, 0x6f,
	0x64, 0x75, 0x63, 0x74, 0x53, 0x65, 0x74, 0x12, 0x2d, 0x0a, 0x12, 0x70, 0x72, 0x6f, 0x64, 0x75,
	0x63, 0x74, 0x5f, 0x63, 0x61, 0x74, 0x65, 0x67, 0x6f, 0x72, 0x69, 0x65, 0x73, 0x18, 0x07, 0x20,
	0x03, 0x28, 0x09, 0x52, 0x11, 0x70, 0x72, 0x6f, 0x64, 0x75, 0x63, 0x74, 0x43, 0x61, 0x74, 0x65,
	0x67, 0x6f, 0x72, 0x69, 0x65, 0x73, 0x12, 0x16, 0x0a, 0x06, 0x66, 0x69, 0x6c, 0x74, 0x65, 0x72,
	0x18, 0x08, 0x20, 0x01, 0x28, 0x09, 0x52, 0x06, 0x66, 0x69, 0x6c, 0x74, 0x65, 0x72, 0x22, 0xda,
	0x04, 0x0a, 0x14, 0x50, 0x72, 0x6f, 0x64, 0x75, 0x63, 0x74, 0x53, 0x65, 0x61, 0x72, 0x63, 0x68,
	0x52, 0x65, 0x73, 0x75, 0x6c, 0x74, 0x73, 0x12, 0x50, 0x0a, 0x08, 0x63, 0x61, 0x74, 0x65, 0x67,
	0x6f, 0x72, 0x79, 0x18, 0x01, 0x20, 0x01, 0x28, 0x0e, 0x32, 0x34, 0x2e, 0x67, 0x6f, 0x6f, 0x67,
	0x6c, 0x65, 0x2e, 0x63, 0x6c, 0x6f, 0x75, 0x64, 0x2e, 0x76, 0x69, 0x73, 0x69, 0x6f, 0x6e, 0x2e,
	0x76, 0x31, 0x70, 0x33, 0x62, 0x65, 0x74, 0x61, 0x31, 0x2e, 0x50, 0x72, 0x6f, 0x64, 0x75, 0x63,
	0x74, 0x53, 0x65, 0x61, 0x72, 0x63, 0x68, 0x43, 0x61, 0x74, 0x65, 0x67, 0x6f, 0x72, 0x79, 0x52,
	0x08, 0x63, 0x61, 0x74, 0x65, 0x67, 0x6f, 0x72, 0x79, 0x12, 0x29, 0x0a, 0x10, 0x70, 0x72, 0x6f,
	0x64, 0x75, 0x63, 0x74, 0x5f, 0x63, 0x61, 0x74, 0x65, 0x67, 0x6f, 0x72, 0x79, 0x18, 0x04, 0x20,
	0x01, 0x28, 0x09, 0x52, 0x0f, 0x70, 0x72, 0x6f, 0x64, 0x75, 0x63, 0x74, 0x43, 0x61, 0x74, 0x65,
	0x67, 0x6f, 0x72, 0x79, 0x12, 0x39, 0x0a, 0x0a, 0x69, 0x6e, 0x64, 0x65, 0x78, 0x5f, 0x74, 0x69,
	0x6d, 0x65, 0x18, 0x02, 0x20, 0x01, 0x28, 0x0b, 0x32, 0x1a, 0x2e, 0x67, 0x6f, 0x6f, 0x67, 0x6c,
	0x65, 0x2e, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x62, 0x75, 0x66, 0x2e, 0x54, 0x69, 0x6d, 0x65, 0x73,
	0x74, 0x61, 0x6d, 0x70, 0x52, 0x09, 0x69, 0x6e, 0x64, 0x65, 0x78, 0x54, 0x69, 0x6d, 0x65, 0x12,
	0x5b, 0x0a, 0x08, 0x70, 0x72, 0x6f, 0x64, 0x75, 0x63, 0x74, 0x73, 0x18, 0x03, 0x20, 0x03, 0x28,
	0x0b, 0x32, 0x3f, 0x2e, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2e, 0x63, 0x6c, 0x6f, 0x75, 0x64,
	0x2e, 0x76, 0x69, 0x73, 0x69, 0x6f, 0x6e, 0x2e, 0x76, 0x31, 0x70, 0x33, 0x62, 0x65, 0x74, 0x61,
	0x31, 0x2e, 0x50, 0x72, 0x6f, 0x64, 0x75, 0x63, 0x74, 0x53, 0x65, 0x61, 0x72, 0x63, 0x68, 0x52,
	0x65, 0x73, 0x75, 0x6c, 0x74, 0x73, 0x2e, 0x50, 0x72, 0x6f, 0x64, 0x75, 0x63, 0x74, 0x49, 0x6e,
	0x66, 0x6f, 0x52, 0x08, 0x70, 0x72, 0x6f, 0x64, 0x75, 0x63, 0x74, 0x73, 0x12, 0x54, 0x0a, 0x07,
	0x72, 0x65, 0x73, 0x75, 0x6c, 0x74, 0x73, 0x18, 0x05, 0x20, 0x03, 0x28, 0x0b, 0x32, 0x3a, 0x2e,
	0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2e, 0x63, 0x6c, 0x6f, 0x75, 0x64, 0x2e, 0x76, 0x69, 0x73,
	0x69, 0x6f, 0x6e, 0x2e, 0x76, 0x31, 0x70, 0x33, 0x62, 0x65, 0x74, 0x61, 0x31, 0x2e, 0x50, 0x72,
	0x6f, 0x64, 0x75, 0x63, 0x74, 0x53, 0x65, 0x61, 0x72, 0x63, 0x68, 0x52, 0x65, 0x73, 0x75, 0x6c,
	0x74, 0x73, 0x2e, 0x52, 0x65, 0x73, 0x75, 0x6c, 0x74, 0x52, 0x07, 0x72, 0x65, 0x73, 0x75, 0x6c,
	0x74, 0x73, 0x1a, 0x5f, 0x0a, 0x0b, 0x50, 0x72, 0x6f, 0x64, 0x75, 0x63, 0x74, 0x49, 0x6e, 0x66,
	0x6f, 0x12, 0x1d, 0x0a, 0x0a, 0x70, 0x72, 0x6f, 0x64, 0x75, 0x63, 0x74, 0x5f, 0x69, 0x64, 0x18,
	0x01, 0x20, 0x01, 0x28, 0x09, 0x52, 0x09, 0x70, 0x72, 0x6f, 0x64, 0x75, 0x63, 0x74, 0x49, 0x64,
	0x12, 0x1b, 0x0a, 0x09, 0x69, 0x6d, 0x61, 0x67, 0x65, 0x5f, 0x75, 0x72, 0x69, 0x18, 0x02, 0x20,
	0x01, 0x28, 0x09, 0x52, 0x08, 0x69, 0x6d, 0x61, 0x67, 0x65, 0x55, 0x72, 0x69, 0x12, 0x14, 0x0a,
	0x05, 0x73, 0x63, 0x6f, 0x72, 0x65, 0x18, 0x03, 0x20, 0x01, 0x28, 0x02, 0x52, 0x05, 0x73, 0x63,
	0x6f, 0x72, 0x65, 0x1a, 0x76, 0x0a, 0x06, 0x52, 0x65, 0x73, 0x75, 0x6c, 0x74, 0x12, 0x40, 0x0a,
	0x07, 0x70, 0x72, 0x6f, 0x64, 0x75, 0x63, 0x74, 0x18, 0x01, 0x20, 0x01, 0x28, 0x0b, 0x32, 0x26,
	0x2e, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2e, 0x63, 0x6c, 0x6f, 0x75, 0x64, 0x2e, 0x76, 0x69,
	0x73, 0x69, 0x6f, 0x6e, 0x2e, 0x76, 0x31, 0x70, 0x33, 0x62, 0x65, 0x74, 0x61, 0x31, 0x2e, 0x50,
	0x72, 0x6f, 0x64, 0x75, 0x63, 0x74, 0x52, 0x07, 0x70, 0x72, 0x6f, 0x64, 0x75, 0x63, 0x74, 0x12,
	0x14, 0x0a, 0x05, 0x73, 0x63, 0x6f, 0x72, 0x65, 0x18, 0x02, 0x20, 0x01, 0x28, 0x02, 0x52, 0x05,
	0x73, 0x63, 0x6f, 0x72, 0x65, 0x12, 0x14, 0x0a, 0x05, 0x69, 0x6d, 0x61, 0x67, 0x65, 0x18, 0x03,
	0x20, 0x01, 0x28, 0x09, 0x52, 0x05, 0x69, 0x6d, 0x61, 0x67, 0x65, 0x2a, 0x55, 0x0a, 0x15, 0x50,
	0x72, 0x6f, 0x64, 0x75, 0x63, 0x74, 0x53, 0x65, 0x61, 0x72, 0x63, 0x68, 0x43, 0x61, 0x74, 0x65,
	0x67, 0x6f, 0x72, 0x79, 0x12, 0x27, 0x0a, 0x23, 0x50, 0x52, 0x4f, 0x44, 0x55, 0x43, 0x54, 0x5f,
	0x53, 0x45, 0x41, 0x52, 0x43, 0x48, 0x5f, 0x43, 0x41, 0x54, 0x45, 0x47, 0x4f, 0x52, 0x59, 0x5f,
	0x55, 0x4e, 0x53, 0x50, 0x45, 0x43, 0x49, 0x46, 0x49, 0x45, 0x44, 0x10, 0x00, 0x12, 0x09, 0x0a,
	0x05, 0x53, 0x48, 0x4f, 0x45, 0x53, 0x10, 0x01, 0x12, 0x08, 0x0a, 0x04, 0x42, 0x41, 0x47, 0x53,
	0x10, 0x02, 0x2a, 0x2f, 0x0a, 0x18, 0x50, 0x72, 0x6f, 0x64, 0x75, 0x63, 0x74, 0x53, 0x65, 0x61,
	0x72, 0x63, 0x68, 0x52, 0x65, 0x73, 0x75, 0x6c, 0x74, 0x73, 0x56, 0x69, 0x65, 0x77, 0x12, 0x09,
	0x0a, 0x05, 0x42, 0x41, 0x53, 0x49, 0x43, 0x10, 0x00, 0x12, 0x08, 0x0a, 0x04, 0x46, 0x55, 0x4c,
	0x4c, 0x10, 0x01, 0x42, 0x81, 0x01, 0x0a, 0x21, 0x63, 0x6f, 0x6d, 0x2e, 0x67, 0x6f, 0x6f, 0x67,
	0x6c, 0x65, 0x2e, 0x63, 0x6c, 0x6f, 0x75, 0x64, 0x2e, 0x76, 0x69, 0x73, 0x69, 0x6f, 0x6e, 0x2e,
	0x76, 0x31, 0x70, 0x33, 0x62, 0x65, 0x74, 0x61, 0x31, 0x42, 0x12, 0x50, 0x72, 0x6f, 0x64, 0x75,
	0x63, 0x74, 0x53, 0x65, 0x61, 0x72, 0x63, 0x68, 0x50, 0x72, 0x6f, 0x74, 0x6f, 0x50, 0x01, 0x5a,
	0x43, 0x67, 0x6f, 0x6f, 0x67, 0x6c, 0x65, 0x2e, 0x67, 0x6f, 0x6c, 0x61, 0x6e, 0x67, 0x2e, 0x6f,
	0x72, 0x67, 0x2f, 0x67, 0x65, 0x6e, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x2f, 0x67, 0x6f, 0x6f, 0x67,
	0x6c, 0x65, 0x61, 0x70, 0x69, 0x73, 0x2f, 0x63, 0x6c, 0x6f, 0x75, 0x64, 0x2f, 0x76, 0x69, 0x73,
	0x69, 0x6f, 0x6e, 0x2f, 0x76, 0x31, 0x70, 0x33, 0x62, 0x65, 0x74, 0x61, 0x31, 0x3b, 0x76, 0x69,
	0x73, 0x69, 0x6f, 0x6e, 0xf8, 0x01, 0x01, 0x62, 0x06, 0x70, 0x72, 0x6f, 0x74, 0x6f, 0x33,
}

var (
	file_google_cloud_vision_v1p3beta1_product_search_proto_rawDescOnce sync.Once
	file_google_cloud_vision_v1p3beta1_product_search_proto_rawDescData = file_google_cloud_vision_v1p3beta1_product_search_proto_rawDesc
)

func file_google_cloud_vision_v1p3beta1_product_search_proto_rawDescGZIP() []byte {
	file_google_cloud_vision_v1p3beta1_product_search_proto_rawDescOnce.Do(func() {
		file_google_cloud_vision_v1p3beta1_product_search_proto_rawDescData = protoimpl.X.CompressGZIP(file_google_cloud_vision_v1p3beta1_product_search_proto_rawDescData)
	})
	return file_google_cloud_vision_v1p3beta1_product_search_proto_rawDescData
}

var file_google_cloud_vision_v1p3beta1_product_search_proto_enumTypes = make([]protoimpl.EnumInfo, 2)
var file_google_cloud_vision_v1p3beta1_product_search_proto_msgTypes = make([]protoimpl.MessageInfo, 4)
var file_google_cloud_vision_v1p3beta1_product_search_proto_goTypes = []interface{}{
	(ProductSearchCategory)(0),               // 0: google.cloud.vision.v1p3beta1.ProductSearchCategory
	(ProductSearchResultsView)(0),            // 1: google.cloud.vision.v1p3beta1.ProductSearchResultsView
	(*ProductSearchParams)(nil),              // 2: google.cloud.vision.v1p3beta1.ProductSearchParams
	(*ProductSearchResults)(nil),             // 3: google.cloud.vision.v1p3beta1.ProductSearchResults
	(*ProductSearchResults_ProductInfo)(nil), // 4: google.cloud.vision.v1p3beta1.ProductSearchResults.ProductInfo
	(*ProductSearchResults_Result)(nil),      // 5: google.cloud.vision.v1p3beta1.ProductSearchResults.Result
	(*NormalizedBoundingPoly)(nil),           // 6: google.cloud.vision.v1p3beta1.NormalizedBoundingPoly
	(*BoundingPoly)(nil),                     // 7: google.cloud.vision.v1p3beta1.BoundingPoly
	(*timestamppb.Timestamp)(nil),            // 8: google.protobuf.Timestamp
	(*Product)(nil),                          // 9: google.cloud.vision.v1p3beta1.Product
}
var file_google_cloud_vision_v1p3beta1_product_search_proto_depIdxs = []int32{
	0, // 0: google.cloud.vision.v1p3beta1.ProductSearchParams.category:type_name -> google.cloud.vision.v1p3beta1.ProductSearchCategory
	6, // 1: google.cloud.vision.v1p3beta1.ProductSearchParams.normalized_bounding_poly:type_name -> google.cloud.vision.v1p3beta1.NormalizedBoundingPoly
	7, // 2: google.cloud.vision.v1p3beta1.ProductSearchParams.bounding_poly:type_name -> google.cloud.vision.v1p3beta1.BoundingPoly
	1, // 3: google.cloud.vision.v1p3beta1.ProductSearchParams.view:type_name -> google.cloud.vision.v1p3beta1.ProductSearchResultsView
	0, // 4: google.cloud.vision.v1p3beta1.ProductSearchResults.category:type_name -> google.cloud.vision.v1p3beta1.ProductSearchCategory
	8, // 5: google.cloud.vision.v1p3beta1.ProductSearchResults.index_time:type_name -> google.protobuf.Timestamp
	4, // 6: google.cloud.vision.v1p3beta1.ProductSearchResults.products:type_name -> google.cloud.vision.v1p3beta1.ProductSearchResults.ProductInfo
	5, // 7: google.cloud.vision.v1p3beta1.ProductSearchResults.results:type_name -> google.cloud.vision.v1p3beta1.ProductSearchResults.Result
	9, // 8: google.cloud.vision.v1p3beta1.ProductSearchResults.Result.product:type_name -> google.cloud.vision.v1p3beta1.Product
	9, // [9:9] is the sub-list for method output_type
	9, // [9:9] is the sub-list for method input_type
	9, // [9:9] is the sub-list for extension type_name
	9, // [9:9] is the sub-list for extension extendee
	0, // [0:9] is the sub-list for field type_name
}

func init() { file_google_cloud_vision_v1p3beta1_product_search_proto_init() }
func file_google_cloud_vision_v1p3beta1_product_search_proto_init() {
	if File_google_cloud_vision_v1p3beta1_product_search_proto != nil {
		return
	}
	file_google_cloud_vision_v1p3beta1_geometry_proto_init()
	file_google_cloud_vision_v1p3beta1_product_search_service_proto_init()
	if !protoimpl.UnsafeEnabled {
		file_google_cloud_vision_v1p3beta1_product_search_proto_msgTypes[0].Exporter = func(v interface{}, i int) interface{} {
			switch v := v.(*ProductSearchParams); i {
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
		file_google_cloud_vision_v1p3beta1_product_search_proto_msgTypes[1].Exporter = func(v interface{}, i int) interface{} {
			switch v := v.(*ProductSearchResults); i {
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
		file_google_cloud_vision_v1p3beta1_product_search_proto_msgTypes[2].Exporter = func(v interface{}, i int) interface{} {
			switch v := v.(*ProductSearchResults_ProductInfo); i {
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
		file_google_cloud_vision_v1p3beta1_product_search_proto_msgTypes[3].Exporter = func(v interface{}, i int) interface{} {
			switch v := v.(*ProductSearchResults_Result); i {
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
			RawDescriptor: file_google_cloud_vision_v1p3beta1_product_search_proto_rawDesc,
			NumEnums:      2,
			NumMessages:   4,
			NumExtensions: 0,
			NumServices:   0,
		},
		GoTypes:           file_google_cloud_vision_v1p3beta1_product_search_proto_goTypes,
		DependencyIndexes: file_google_cloud_vision_v1p3beta1_product_search_proto_depIdxs,
		EnumInfos:         file_google_cloud_vision_v1p3beta1_product_search_proto_enumTypes,
		MessageInfos:      file_google_cloud_vision_v1p3beta1_product_search_proto_msgTypes,
	}.Build()
	File_google_cloud_vision_v1p3beta1_product_search_proto = out.File
	file_google_cloud_vision_v1p3beta1_product_search_proto_rawDesc = nil
	file_google_cloud_vision_v1p3beta1_product_search_proto_goTypes = nil
	file_google_cloud_vision_v1p3beta1_product_search_proto_depIdxs = nil
}
