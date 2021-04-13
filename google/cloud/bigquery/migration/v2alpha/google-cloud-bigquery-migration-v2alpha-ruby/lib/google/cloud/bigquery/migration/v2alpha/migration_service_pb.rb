# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/bigquery/migration/v2alpha/migration_service.proto

require 'google/protobuf'

require 'google/api/annotations_pb'
require 'google/api/client_pb'
require 'google/api/field_behavior_pb'
require 'google/api/resource_pb'
require 'google/cloud/bigquery/migration/v2alpha/migration_entities_pb'
require 'google/cloud/bigquery/migration/v2alpha/migration_error_details_pb'
require 'google/cloud/bigquery/migration/v2alpha/migration_metrics_pb'
require 'google/protobuf/empty_pb'
require 'google/protobuf/field_mask_pb'
require 'google/rpc/error_details_pb'
Google::Protobuf::DescriptorPool.generated_pool.build do
  add_file("google/cloud/bigquery/migration/v2alpha/migration_service.proto", :syntax => :proto3) do
    add_message "google.cloud.bigquery.migration.v2alpha.CreateMigrationWorkflowRequest" do
      optional :parent, :string, 1
      optional :migration_workflow, :message, 2, "google.cloud.bigquery.migration.v2alpha.MigrationWorkflow"
    end
    add_message "google.cloud.bigquery.migration.v2alpha.GetMigrationWorkflowRequest" do
      optional :name, :string, 1
      optional :read_mask, :message, 2, "google.protobuf.FieldMask"
    end
    add_message "google.cloud.bigquery.migration.v2alpha.ListMigrationWorkflowsRequest" do
      optional :parent, :string, 1
      optional :read_mask, :message, 2, "google.protobuf.FieldMask"
      optional :page_size, :int32, 3
      optional :page_token, :string, 4
    end
    add_message "google.cloud.bigquery.migration.v2alpha.ListMigrationWorkflowsResponse" do
      repeated :migration_workflows, :message, 1, "google.cloud.bigquery.migration.v2alpha.MigrationWorkflow"
      optional :next_page_token, :string, 2
    end
    add_message "google.cloud.bigquery.migration.v2alpha.DeleteMigrationWorkflowRequest" do
      optional :name, :string, 1
    end
    add_message "google.cloud.bigquery.migration.v2alpha.StartMigrationWorkflowRequest" do
      optional :name, :string, 1
    end
    add_message "google.cloud.bigquery.migration.v2alpha.GetMigrationSubtaskRequest" do
      optional :name, :string, 1
      optional :read_mask, :message, 2, "google.protobuf.FieldMask"
    end
    add_message "google.cloud.bigquery.migration.v2alpha.ListMigrationSubtasksRequest" do
      optional :parent, :string, 1
      optional :read_mask, :message, 2, "google.protobuf.FieldMask"
      optional :page_size, :int32, 3
      optional :page_token, :string, 4
      optional :filter, :string, 5
    end
    add_message "google.cloud.bigquery.migration.v2alpha.ListMigrationSubtasksResponse" do
      repeated :migration_subtasks, :message, 1, "google.cloud.bigquery.migration.v2alpha.MigrationSubtask"
      optional :next_page_token, :string, 2
    end
  end
end

module Google
  module Cloud
    module Bigquery
      module Migration
        module V2alpha
          CreateMigrationWorkflowRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.bigquery.migration.v2alpha.CreateMigrationWorkflowRequest").msgclass
          GetMigrationWorkflowRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.bigquery.migration.v2alpha.GetMigrationWorkflowRequest").msgclass
          ListMigrationWorkflowsRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.bigquery.migration.v2alpha.ListMigrationWorkflowsRequest").msgclass
          ListMigrationWorkflowsResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.bigquery.migration.v2alpha.ListMigrationWorkflowsResponse").msgclass
          DeleteMigrationWorkflowRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.bigquery.migration.v2alpha.DeleteMigrationWorkflowRequest").msgclass
          StartMigrationWorkflowRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.bigquery.migration.v2alpha.StartMigrationWorkflowRequest").msgclass
          GetMigrationSubtaskRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.bigquery.migration.v2alpha.GetMigrationSubtaskRequest").msgclass
          ListMigrationSubtasksRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.bigquery.migration.v2alpha.ListMigrationSubtasksRequest").msgclass
          ListMigrationSubtasksResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.bigquery.migration.v2alpha.ListMigrationSubtasksResponse").msgclass
        end
      end
    end
  end
end
