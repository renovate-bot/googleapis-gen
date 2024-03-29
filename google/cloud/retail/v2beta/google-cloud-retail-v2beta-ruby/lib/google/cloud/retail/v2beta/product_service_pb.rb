# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/retail/v2beta/product_service.proto

require 'google/api/annotations_pb'
require 'google/api/client_pb'
require 'google/api/field_behavior_pb'
require 'google/api/resource_pb'
require 'google/cloud/retail/v2beta/common_pb'
require 'google/cloud/retail/v2beta/export_config_pb'
require 'google/cloud/retail/v2beta/import_config_pb'
require 'google/cloud/retail/v2beta/product_pb'
require 'google/cloud/retail/v2beta/purge_config_pb'
require 'google/longrunning/operations_pb'
require 'google/protobuf/empty_pb'
require 'google/protobuf/field_mask_pb'
require 'google/protobuf/timestamp_pb'
require 'google/protobuf'

Google::Protobuf::DescriptorPool.generated_pool.build do
  add_file("google/cloud/retail/v2beta/product_service.proto", :syntax => :proto3) do
    add_message "google.cloud.retail.v2beta.CreateProductRequest" do
      optional :parent, :string, 1
      optional :product, :message, 2, "google.cloud.retail.v2beta.Product"
      optional :product_id, :string, 3
    end
    add_message "google.cloud.retail.v2beta.GetProductRequest" do
      optional :name, :string, 1
    end
    add_message "google.cloud.retail.v2beta.UpdateProductRequest" do
      optional :product, :message, 1, "google.cloud.retail.v2beta.Product"
      optional :update_mask, :message, 2, "google.protobuf.FieldMask"
      optional :allow_missing, :bool, 3
    end
    add_message "google.cloud.retail.v2beta.DeleteProductRequest" do
      optional :name, :string, 1
    end
    add_message "google.cloud.retail.v2beta.ListProductsRequest" do
      optional :parent, :string, 1
      optional :page_size, :int32, 2
      optional :page_token, :string, 3
      optional :filter, :string, 4
      optional :read_mask, :message, 5, "google.protobuf.FieldMask"
    end
    add_message "google.cloud.retail.v2beta.ListProductsResponse" do
      repeated :products, :message, 1, "google.cloud.retail.v2beta.Product"
      optional :next_page_token, :string, 2
    end
    add_message "google.cloud.retail.v2beta.SetInventoryRequest" do
      optional :inventory, :message, 1, "google.cloud.retail.v2beta.Product"
      optional :set_mask, :message, 2, "google.protobuf.FieldMask"
      optional :set_time, :message, 3, "google.protobuf.Timestamp"
      optional :allow_missing, :bool, 4
    end
    add_message "google.cloud.retail.v2beta.SetInventoryMetadata" do
    end
    add_message "google.cloud.retail.v2beta.SetInventoryResponse" do
    end
    add_message "google.cloud.retail.v2beta.AddFulfillmentPlacesRequest" do
      optional :product, :string, 1
      optional :type, :string, 2
      repeated :place_ids, :string, 3
      optional :add_time, :message, 4, "google.protobuf.Timestamp"
      optional :allow_missing, :bool, 5
    end
    add_message "google.cloud.retail.v2beta.AddFulfillmentPlacesMetadata" do
    end
    add_message "google.cloud.retail.v2beta.AddFulfillmentPlacesResponse" do
    end
    add_message "google.cloud.retail.v2beta.RemoveFulfillmentPlacesRequest" do
      optional :product, :string, 1
      optional :type, :string, 2
      repeated :place_ids, :string, 3
      optional :remove_time, :message, 4, "google.protobuf.Timestamp"
      optional :allow_missing, :bool, 5
    end
    add_message "google.cloud.retail.v2beta.RemoveFulfillmentPlacesMetadata" do
    end
    add_message "google.cloud.retail.v2beta.RemoveFulfillmentPlacesResponse" do
    end
  end
end

module Google
  module Cloud
    module Retail
      module V2beta
        CreateProductRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.retail.v2beta.CreateProductRequest").msgclass
        GetProductRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.retail.v2beta.GetProductRequest").msgclass
        UpdateProductRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.retail.v2beta.UpdateProductRequest").msgclass
        DeleteProductRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.retail.v2beta.DeleteProductRequest").msgclass
        ListProductsRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.retail.v2beta.ListProductsRequest").msgclass
        ListProductsResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.retail.v2beta.ListProductsResponse").msgclass
        SetInventoryRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.retail.v2beta.SetInventoryRequest").msgclass
        SetInventoryMetadata = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.retail.v2beta.SetInventoryMetadata").msgclass
        SetInventoryResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.retail.v2beta.SetInventoryResponse").msgclass
        AddFulfillmentPlacesRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.retail.v2beta.AddFulfillmentPlacesRequest").msgclass
        AddFulfillmentPlacesMetadata = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.retail.v2beta.AddFulfillmentPlacesMetadata").msgclass
        AddFulfillmentPlacesResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.retail.v2beta.AddFulfillmentPlacesResponse").msgclass
        RemoveFulfillmentPlacesRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.retail.v2beta.RemoveFulfillmentPlacesRequest").msgclass
        RemoveFulfillmentPlacesMetadata = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.retail.v2beta.RemoveFulfillmentPlacesMetadata").msgclass
        RemoveFulfillmentPlacesResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.retail.v2beta.RemoveFulfillmentPlacesResponse").msgclass
      end
    end
  end
end
