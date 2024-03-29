# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/retail/v2beta/user_event.proto

require 'google/api/annotations_pb'
require 'google/api/field_behavior_pb'
require 'google/cloud/retail/v2beta/common_pb'
require 'google/cloud/retail/v2beta/product_pb'
require 'google/protobuf/timestamp_pb'
require 'google/protobuf/wrappers_pb'
require 'google/protobuf'

Google::Protobuf::DescriptorPool.generated_pool.build do
  add_file("google/cloud/retail/v2beta/user_event.proto", :syntax => :proto3) do
    add_message "google.cloud.retail.v2beta.UserEvent" do
      optional :event_type, :string, 1
      optional :visitor_id, :string, 2
      optional :session_id, :string, 21
      optional :event_time, :message, 3, "google.protobuf.Timestamp"
      repeated :experiment_ids, :string, 4
      optional :attribution_token, :string, 5
      repeated :product_details, :message, 6, "google.cloud.retail.v2beta.ProductDetail"
      optional :completion_detail, :message, 22, "google.cloud.retail.v2beta.CompletionDetail"
      map :attributes, :string, :message, 7, "google.cloud.retail.v2beta.CustomAttribute"
      optional :cart_id, :string, 8
      optional :purchase_transaction, :message, 9, "google.cloud.retail.v2beta.PurchaseTransaction"
      optional :search_query, :string, 10
      optional :filter, :string, 16
      optional :order_by, :string, 17
      optional :offset, :int32, 18
      repeated :page_categories, :string, 11
      optional :user_info, :message, 12, "google.cloud.retail.v2beta.UserInfo"
      optional :uri, :string, 13
      optional :referrer_uri, :string, 14
      optional :page_view_id, :string, 15
    end
    add_message "google.cloud.retail.v2beta.ProductDetail" do
      optional :product, :message, 1, "google.cloud.retail.v2beta.Product"
      optional :quantity, :message, 2, "google.protobuf.Int32Value"
    end
    add_message "google.cloud.retail.v2beta.CompletionDetail" do
      optional :completion_attribution_token, :string, 1
      optional :selected_suggestion, :string, 2
      optional :selected_position, :int32, 3
    end
    add_message "google.cloud.retail.v2beta.PurchaseTransaction" do
      optional :id, :string, 1
      optional :revenue, :float, 2
      optional :tax, :float, 3
      optional :cost, :float, 4
      optional :currency_code, :string, 5
    end
  end
end

module Google
  module Cloud
    module Retail
      module V2beta
        UserEvent = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.retail.v2beta.UserEvent").msgclass
        ProductDetail = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.retail.v2beta.ProductDetail").msgclass
        CompletionDetail = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.retail.v2beta.CompletionDetail").msgclass
        PurchaseTransaction = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.retail.v2beta.PurchaseTransaction").msgclass
      end
    end
  end
end
