# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/retail/v2beta/common.proto

require 'google/api/annotations_pb'
require 'google/api/field_behavior_pb'
require 'google/protobuf/timestamp_pb'
require 'google/protobuf'

Google::Protobuf::DescriptorPool.generated_pool.build do
  add_file("google/cloud/retail/v2beta/common.proto", :syntax => :proto3) do
    add_message "google.cloud.retail.v2beta.Audience" do
      repeated :genders, :string, 1
      repeated :age_groups, :string, 2
    end
    add_message "google.cloud.retail.v2beta.ColorInfo" do
      repeated :color_families, :string, 1
      repeated :colors, :string, 2
    end
    add_message "google.cloud.retail.v2beta.CustomAttribute" do
      repeated :text, :string, 1
      repeated :numbers, :double, 2
      proto3_optional :searchable, :bool, 3
      proto3_optional :indexable, :bool, 4
    end
    add_message "google.cloud.retail.v2beta.FulfillmentInfo" do
      optional :type, :string, 1
      repeated :place_ids, :string, 2
    end
    add_message "google.cloud.retail.v2beta.Image" do
      optional :uri, :string, 1
      optional :height, :int32, 2
      optional :width, :int32, 3
    end
    add_message "google.cloud.retail.v2beta.Interval" do
      oneof :min do
        optional :minimum, :double, 1
        optional :exclusive_minimum, :double, 2
      end
      oneof :max do
        optional :maximum, :double, 3
        optional :exclusive_maximum, :double, 4
      end
    end
    add_message "google.cloud.retail.v2beta.PriceInfo" do
      optional :currency_code, :string, 1
      optional :price, :float, 2
      optional :original_price, :float, 3
      optional :cost, :float, 4
      optional :price_effective_time, :message, 5, "google.protobuf.Timestamp"
      optional :price_expire_time, :message, 6, "google.protobuf.Timestamp"
      optional :price_range, :message, 7, "google.cloud.retail.v2beta.PriceInfo.PriceRange"
    end
    add_message "google.cloud.retail.v2beta.PriceInfo.PriceRange" do
      optional :price, :message, 1, "google.cloud.retail.v2beta.Interval"
      optional :original_price, :message, 2, "google.cloud.retail.v2beta.Interval"
    end
    add_message "google.cloud.retail.v2beta.Rating" do
      optional :rating_count, :int32, 1
      optional :average_rating, :float, 2
      repeated :rating_histogram, :int32, 3
    end
    add_message "google.cloud.retail.v2beta.UserInfo" do
      optional :user_id, :string, 1
      optional :ip_address, :string, 2
      optional :user_agent, :string, 3
      optional :direct_user_request, :bool, 4
    end
    add_message "google.cloud.retail.v2beta.Promotion" do
      optional :promotion_id, :string, 1
    end
  end
end

module Google
  module Cloud
    module Retail
      module V2beta
        Audience = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.retail.v2beta.Audience").msgclass
        ColorInfo = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.retail.v2beta.ColorInfo").msgclass
        CustomAttribute = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.retail.v2beta.CustomAttribute").msgclass
        FulfillmentInfo = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.retail.v2beta.FulfillmentInfo").msgclass
        Image = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.retail.v2beta.Image").msgclass
        Interval = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.retail.v2beta.Interval").msgclass
        PriceInfo = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.retail.v2beta.PriceInfo").msgclass
        PriceInfo::PriceRange = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.retail.v2beta.PriceInfo.PriceRange").msgclass
        Rating = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.retail.v2beta.Rating").msgclass
        UserInfo = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.retail.v2beta.UserInfo").msgclass
        Promotion = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.retail.v2beta.Promotion").msgclass
      end
    end
  end
end
