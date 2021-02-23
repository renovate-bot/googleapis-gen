# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/asset/v1p7beta1/assets.proto

require 'google/protobuf'

require 'google/api/annotations_pb'
require 'google/api/resource_pb'
require 'google/cloud/orgpolicy/v1/orgpolicy_pb'
require 'google/cloud/osconfig/v1/inventory_pb'
require 'google/iam/v1/policy_pb'
require 'google/identity/accesscontextmanager/v1/access_level_pb'
require 'google/identity/accesscontextmanager/v1/access_policy_pb'
require 'google/identity/accesscontextmanager/v1/service_perimeter_pb'
require 'google/protobuf/any_pb'
require 'google/protobuf/struct_pb'
require 'google/protobuf/timestamp_pb'
Google::Protobuf::DescriptorPool.generated_pool.build do
  add_file("google/cloud/asset/v1p7beta1/assets.proto", :syntax => :proto3) do
    add_message "google.cloud.asset.v1p7beta1.Asset" do
      optional :update_time, :message, 11, "google.protobuf.Timestamp"
      optional :name, :string, 1
      optional :asset_type, :string, 2
      optional :resource, :message, 3, "google.cloud.asset.v1p7beta1.Resource"
      optional :iam_policy, :message, 4, "google.iam.v1.Policy"
      repeated :org_policy, :message, 6, "google.cloud.orgpolicy.v1.Policy"
      optional :related_assets, :message, 13, "google.cloud.asset.v1p7beta1.RelatedAssets"
      repeated :ancestors, :string, 10
      oneof :access_context_policy do
        optional :access_policy, :message, 7, "google.identity.accesscontextmanager.v1.AccessPolicy"
        optional :access_level, :message, 8, "google.identity.accesscontextmanager.v1.AccessLevel"
        optional :service_perimeter, :message, 9, "google.identity.accesscontextmanager.v1.ServicePerimeter"
      end
    end
    add_message "google.cloud.asset.v1p7beta1.Resource" do
      optional :version, :string, 1
      optional :discovery_document_uri, :string, 2
      optional :discovery_name, :string, 3
      optional :resource_url, :string, 4
      optional :parent, :string, 5
      optional :data, :message, 6, "google.protobuf.Struct"
      optional :location, :string, 8
    end
    add_message "google.cloud.asset.v1p7beta1.RelatedAssets" do
      optional :relationship_attributes, :message, 1, "google.cloud.asset.v1p7beta1.RelationshipAttributes"
      repeated :assets, :message, 2, "google.cloud.asset.v1p7beta1.RelatedAsset"
    end
    add_message "google.cloud.asset.v1p7beta1.RelationshipAttributes" do
      optional :type, :string, 4
      optional :source_resource_type, :string, 1
      optional :target_resource_type, :string, 2
      optional :action, :string, 3
    end
    add_message "google.cloud.asset.v1p7beta1.RelatedAsset" do
      optional :asset, :string, 1
      optional :asset_type, :string, 2
      repeated :ancestors, :string, 3
    end
  end
end

module Google
  module Cloud
    module Asset
      module V1p7beta1
        Asset = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.asset.v1p7beta1.Asset").msgclass
        Resource = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.asset.v1p7beta1.Resource").msgclass
        RelatedAssets = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.asset.v1p7beta1.RelatedAssets").msgclass
        RelationshipAttributes = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.asset.v1p7beta1.RelationshipAttributes").msgclass
        RelatedAsset = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.asset.v1p7beta1.RelatedAsset").msgclass
      end
    end
  end
end
