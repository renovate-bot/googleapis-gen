# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/tasks/v2beta3/cloudtasks.proto

require 'google/api/annotations_pb'
require 'google/api/client_pb'
require 'google/api/field_behavior_pb'
require 'google/api/resource_pb'
require 'google/cloud/tasks/v2beta3/queue_pb'
require 'google/cloud/tasks/v2beta3/task_pb'
require 'google/iam/v1/iam_policy_pb'
require 'google/iam/v1/policy_pb'
require 'google/protobuf/empty_pb'
require 'google/protobuf/field_mask_pb'
require 'google/protobuf'

Google::Protobuf::DescriptorPool.generated_pool.build do
  add_file("google/cloud/tasks/v2beta3/cloudtasks.proto", :syntax => :proto3) do
    add_message "google.cloud.tasks.v2beta3.ListQueuesRequest" do
      optional :parent, :string, 1
      optional :filter, :string, 2
      optional :page_size, :int32, 3
      optional :page_token, :string, 4
      optional :read_mask, :message, 5, "google.protobuf.FieldMask"
    end
    add_message "google.cloud.tasks.v2beta3.ListQueuesResponse" do
      repeated :queues, :message, 1, "google.cloud.tasks.v2beta3.Queue"
      optional :next_page_token, :string, 2
    end
    add_message "google.cloud.tasks.v2beta3.GetQueueRequest" do
      optional :name, :string, 1
      optional :read_mask, :message, 2, "google.protobuf.FieldMask"
    end
    add_message "google.cloud.tasks.v2beta3.CreateQueueRequest" do
      optional :parent, :string, 1
      optional :queue, :message, 2, "google.cloud.tasks.v2beta3.Queue"
    end
    add_message "google.cloud.tasks.v2beta3.UpdateQueueRequest" do
      optional :queue, :message, 1, "google.cloud.tasks.v2beta3.Queue"
      optional :update_mask, :message, 2, "google.protobuf.FieldMask"
    end
    add_message "google.cloud.tasks.v2beta3.DeleteQueueRequest" do
      optional :name, :string, 1
    end
    add_message "google.cloud.tasks.v2beta3.PurgeQueueRequest" do
      optional :name, :string, 1
    end
    add_message "google.cloud.tasks.v2beta3.PauseQueueRequest" do
      optional :name, :string, 1
    end
    add_message "google.cloud.tasks.v2beta3.ResumeQueueRequest" do
      optional :name, :string, 1
    end
    add_message "google.cloud.tasks.v2beta3.ListTasksRequest" do
      optional :parent, :string, 1
      optional :response_view, :enum, 2, "google.cloud.tasks.v2beta3.Task.View"
      optional :page_size, :int32, 3
      optional :page_token, :string, 4
    end
    add_message "google.cloud.tasks.v2beta3.ListTasksResponse" do
      repeated :tasks, :message, 1, "google.cloud.tasks.v2beta3.Task"
      optional :next_page_token, :string, 2
    end
    add_message "google.cloud.tasks.v2beta3.GetTaskRequest" do
      optional :name, :string, 1
      optional :response_view, :enum, 2, "google.cloud.tasks.v2beta3.Task.View"
    end
    add_message "google.cloud.tasks.v2beta3.CreateTaskRequest" do
      optional :parent, :string, 1
      optional :task, :message, 2, "google.cloud.tasks.v2beta3.Task"
      optional :response_view, :enum, 3, "google.cloud.tasks.v2beta3.Task.View"
    end
    add_message "google.cloud.tasks.v2beta3.DeleteTaskRequest" do
      optional :name, :string, 1
    end
    add_message "google.cloud.tasks.v2beta3.RunTaskRequest" do
      optional :name, :string, 1
      optional :response_view, :enum, 2, "google.cloud.tasks.v2beta3.Task.View"
    end
  end
end

module Google
  module Cloud
    module Tasks
      module V2beta3
        ListQueuesRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.tasks.v2beta3.ListQueuesRequest").msgclass
        ListQueuesResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.tasks.v2beta3.ListQueuesResponse").msgclass
        GetQueueRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.tasks.v2beta3.GetQueueRequest").msgclass
        CreateQueueRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.tasks.v2beta3.CreateQueueRequest").msgclass
        UpdateQueueRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.tasks.v2beta3.UpdateQueueRequest").msgclass
        DeleteQueueRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.tasks.v2beta3.DeleteQueueRequest").msgclass
        PurgeQueueRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.tasks.v2beta3.PurgeQueueRequest").msgclass
        PauseQueueRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.tasks.v2beta3.PauseQueueRequest").msgclass
        ResumeQueueRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.tasks.v2beta3.ResumeQueueRequest").msgclass
        ListTasksRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.tasks.v2beta3.ListTasksRequest").msgclass
        ListTasksResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.tasks.v2beta3.ListTasksResponse").msgclass
        GetTaskRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.tasks.v2beta3.GetTaskRequest").msgclass
        CreateTaskRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.tasks.v2beta3.CreateTaskRequest").msgclass
        DeleteTaskRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.tasks.v2beta3.DeleteTaskRequest").msgclass
        RunTaskRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.tasks.v2beta3.RunTaskRequest").msgclass
      end
    end
  end
end
