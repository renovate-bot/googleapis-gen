# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/policytroubleshooter/v1/explanations.proto

require 'google/api/field_behavior_pb'
require 'google/iam/v1/policy_pb'
require 'google/type/expr_pb'
require 'google/protobuf'

Google::Protobuf::DescriptorPool.generated_pool.build do
  add_file("google/cloud/policytroubleshooter/v1/explanations.proto", :syntax => :proto3) do
    add_message "google.cloud.policytroubleshooter.v1.AccessTuple" do
      optional :principal, :string, 1
      optional :full_resource_name, :string, 2
      optional :permission, :string, 3
    end
    add_message "google.cloud.policytroubleshooter.v1.ExplainedPolicy" do
      optional :access, :enum, 1, "google.cloud.policytroubleshooter.v1.AccessState"
      optional :full_resource_name, :string, 2
      optional :policy, :message, 3, "google.iam.v1.Policy"
      repeated :binding_explanations, :message, 4, "google.cloud.policytroubleshooter.v1.BindingExplanation"
      optional :relevance, :enum, 5, "google.cloud.policytroubleshooter.v1.HeuristicRelevance"
    end
    add_message "google.cloud.policytroubleshooter.v1.BindingExplanation" do
      optional :access, :enum, 1, "google.cloud.policytroubleshooter.v1.AccessState"
      optional :role, :string, 2
      optional :role_permission, :enum, 3, "google.cloud.policytroubleshooter.v1.BindingExplanation.RolePermission"
      optional :role_permission_relevance, :enum, 4, "google.cloud.policytroubleshooter.v1.HeuristicRelevance"
      map :memberships, :string, :message, 5, "google.cloud.policytroubleshooter.v1.BindingExplanation.AnnotatedMembership"
      optional :relevance, :enum, 6, "google.cloud.policytroubleshooter.v1.HeuristicRelevance"
      optional :condition, :message, 7, "google.type.Expr"
    end
    add_message "google.cloud.policytroubleshooter.v1.BindingExplanation.AnnotatedMembership" do
      optional :membership, :enum, 1, "google.cloud.policytroubleshooter.v1.BindingExplanation.Membership"
      optional :relevance, :enum, 2, "google.cloud.policytroubleshooter.v1.HeuristicRelevance"
    end
    add_enum "google.cloud.policytroubleshooter.v1.BindingExplanation.RolePermission" do
      value :ROLE_PERMISSION_UNSPECIFIED, 0
      value :ROLE_PERMISSION_INCLUDED, 1
      value :ROLE_PERMISSION_NOT_INCLUDED, 2
      value :ROLE_PERMISSION_UNKNOWN_INFO_DENIED, 3
    end
    add_enum "google.cloud.policytroubleshooter.v1.BindingExplanation.Membership" do
      value :MEMBERSHIP_UNSPECIFIED, 0
      value :MEMBERSHIP_INCLUDED, 1
      value :MEMBERSHIP_NOT_INCLUDED, 2
      value :MEMBERSHIP_UNKNOWN_INFO_DENIED, 3
      value :MEMBERSHIP_UNKNOWN_UNSUPPORTED, 4
    end
    add_enum "google.cloud.policytroubleshooter.v1.AccessState" do
      value :ACCESS_STATE_UNSPECIFIED, 0
      value :GRANTED, 1
      value :NOT_GRANTED, 2
      value :UNKNOWN_CONDITIONAL, 3
      value :UNKNOWN_INFO_DENIED, 4
    end
    add_enum "google.cloud.policytroubleshooter.v1.HeuristicRelevance" do
      value :HEURISTIC_RELEVANCE_UNSPECIFIED, 0
      value :NORMAL, 1
      value :HIGH, 2
    end
  end
end

module Google
  module Cloud
    module PolicyTroubleshooter
      module V1
        AccessTuple = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.policytroubleshooter.v1.AccessTuple").msgclass
        ExplainedPolicy = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.policytroubleshooter.v1.ExplainedPolicy").msgclass
        BindingExplanation = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.policytroubleshooter.v1.BindingExplanation").msgclass
        BindingExplanation::AnnotatedMembership = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.policytroubleshooter.v1.BindingExplanation.AnnotatedMembership").msgclass
        BindingExplanation::RolePermission = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.policytroubleshooter.v1.BindingExplanation.RolePermission").enummodule
        BindingExplanation::Membership = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.policytroubleshooter.v1.BindingExplanation.Membership").enummodule
        AccessState = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.policytroubleshooter.v1.AccessState").enummodule
        HeuristicRelevance = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.policytroubleshooter.v1.HeuristicRelevance").enummodule
      end
    end
  end
end
