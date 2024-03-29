# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/websecurityscanner/v1beta/scan_run.proto

require 'google/api/resource_pb'
require 'google/cloud/websecurityscanner/v1beta/scan_run_error_trace_pb'
require 'google/cloud/websecurityscanner/v1beta/scan_run_warning_trace_pb'
require 'google/protobuf/timestamp_pb'
require 'google/protobuf'

Google::Protobuf::DescriptorPool.generated_pool.build do
  add_file("google/cloud/websecurityscanner/v1beta/scan_run.proto", :syntax => :proto3) do
    add_message "google.cloud.websecurityscanner.v1beta.ScanRun" do
      optional :name, :string, 1
      optional :execution_state, :enum, 2, "google.cloud.websecurityscanner.v1beta.ScanRun.ExecutionState"
      optional :result_state, :enum, 3, "google.cloud.websecurityscanner.v1beta.ScanRun.ResultState"
      optional :start_time, :message, 4, "google.protobuf.Timestamp"
      optional :end_time, :message, 5, "google.protobuf.Timestamp"
      optional :urls_crawled_count, :int64, 6
      optional :urls_tested_count, :int64, 7
      optional :has_vulnerabilities, :bool, 8
      optional :progress_percent, :int32, 9
      optional :error_trace, :message, 10, "google.cloud.websecurityscanner.v1beta.ScanRunErrorTrace"
      repeated :warning_traces, :message, 11, "google.cloud.websecurityscanner.v1beta.ScanRunWarningTrace"
    end
    add_enum "google.cloud.websecurityscanner.v1beta.ScanRun.ExecutionState" do
      value :EXECUTION_STATE_UNSPECIFIED, 0
      value :QUEUED, 1
      value :SCANNING, 2
      value :FINISHED, 3
    end
    add_enum "google.cloud.websecurityscanner.v1beta.ScanRun.ResultState" do
      value :RESULT_STATE_UNSPECIFIED, 0
      value :SUCCESS, 1
      value :ERROR, 2
      value :KILLED, 3
    end
  end
end

module Google
  module Cloud
    module WebSecurityScanner
      module V1beta
        ScanRun = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.websecurityscanner.v1beta.ScanRun").msgclass
        ScanRun::ExecutionState = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.websecurityscanner.v1beta.ScanRun.ExecutionState").enummodule
        ScanRun::ResultState = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.websecurityscanner.v1beta.ScanRun.ResultState").enummodule
      end
    end
  end
end
