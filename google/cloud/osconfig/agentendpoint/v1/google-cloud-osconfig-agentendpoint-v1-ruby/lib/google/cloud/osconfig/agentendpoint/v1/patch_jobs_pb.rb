# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/osconfig/agentendpoint/v1/patch_jobs.proto

require 'google/protobuf'

Google::Protobuf::DescriptorPool.generated_pool.build do
  add_file("google/cloud/osconfig/agentendpoint/v1/patch_jobs.proto", :syntax => :proto3) do
    add_message "google.cloud.osconfig.agentendpoint.v1.PatchConfig" do
      optional :reboot_config, :enum, 1, "google.cloud.osconfig.agentendpoint.v1.PatchConfig.RebootConfig"
      optional :retry_strategy, :message, 2, "google.cloud.osconfig.agentendpoint.v1.RetryStrategy"
      optional :apt, :message, 3, "google.cloud.osconfig.agentendpoint.v1.AptSettings"
      optional :yum, :message, 4, "google.cloud.osconfig.agentendpoint.v1.YumSettings"
      optional :goo, :message, 5, "google.cloud.osconfig.agentendpoint.v1.GooSettings"
      optional :zypper, :message, 6, "google.cloud.osconfig.agentendpoint.v1.ZypperSettings"
      optional :windows_update, :message, 7, "google.cloud.osconfig.agentendpoint.v1.WindowsUpdateSettings"
      optional :pre_step, :message, 8, "google.cloud.osconfig.agentendpoint.v1.ExecStep"
      optional :post_step, :message, 9, "google.cloud.osconfig.agentendpoint.v1.ExecStep"
    end
    add_enum "google.cloud.osconfig.agentendpoint.v1.PatchConfig.RebootConfig" do
      value :REBOOT_CONFIG_UNSPECIFIED, 0
      value :DEFAULT, 1
      value :ALWAYS, 2
      value :NEVER, 3
    end
    add_message "google.cloud.osconfig.agentendpoint.v1.AptSettings" do
      optional :type, :enum, 1, "google.cloud.osconfig.agentendpoint.v1.AptSettings.Type"
      repeated :excludes, :string, 2
      repeated :exclusive_packages, :string, 3
    end
    add_enum "google.cloud.osconfig.agentendpoint.v1.AptSettings.Type" do
      value :TYPE_UNSPECIFIED, 0
      value :DIST, 1
      value :UPGRADE, 2
    end
    add_message "google.cloud.osconfig.agentendpoint.v1.YumSettings" do
      optional :security, :bool, 1
      optional :minimal, :bool, 2
      repeated :excludes, :string, 3
      repeated :exclusive_packages, :string, 4
    end
    add_message "google.cloud.osconfig.agentendpoint.v1.GooSettings" do
    end
    add_message "google.cloud.osconfig.agentendpoint.v1.ZypperSettings" do
      optional :with_optional, :bool, 1
      optional :with_update, :bool, 2
      repeated :categories, :string, 3
      repeated :severities, :string, 4
      repeated :excludes, :string, 5
      repeated :exclusive_patches, :string, 6
    end
    add_message "google.cloud.osconfig.agentendpoint.v1.WindowsUpdateSettings" do
      repeated :classifications, :enum, 1, "google.cloud.osconfig.agentendpoint.v1.WindowsUpdateSettings.Classification"
      repeated :excludes, :string, 2
      repeated :exclusive_patches, :string, 3
    end
    add_enum "google.cloud.osconfig.agentendpoint.v1.WindowsUpdateSettings.Classification" do
      value :CLASSIFICATION_UNSPECIFIED, 0
      value :CRITICAL, 1
      value :SECURITY, 2
      value :DEFINITION, 3
      value :DRIVER, 4
      value :FEATURE_PACK, 5
      value :SERVICE_PACK, 6
      value :TOOL, 7
      value :UPDATE_ROLLUP, 8
      value :UPDATE, 9
    end
    add_message "google.cloud.osconfig.agentendpoint.v1.RetryStrategy" do
      optional :enabled, :bool, 1
    end
    add_message "google.cloud.osconfig.agentendpoint.v1.ExecStep" do
      optional :linux_exec_step_config, :message, 1, "google.cloud.osconfig.agentendpoint.v1.ExecStepConfig"
      optional :windows_exec_step_config, :message, 2, "google.cloud.osconfig.agentendpoint.v1.ExecStepConfig"
    end
    add_message "google.cloud.osconfig.agentendpoint.v1.ExecStepConfig" do
      repeated :allowed_success_codes, :int32, 3
      optional :interpreter, :enum, 4, "google.cloud.osconfig.agentendpoint.v1.ExecStepConfig.Interpreter"
      oneof :executable do
        optional :local_path, :string, 1
        optional :gcs_object, :message, 2, "google.cloud.osconfig.agentendpoint.v1.GcsObject"
      end
    end
    add_enum "google.cloud.osconfig.agentendpoint.v1.ExecStepConfig.Interpreter" do
      value :INTERPRETER_UNSPECIFIED, 0
      value :SHELL, 1
      value :POWERSHELL, 2
    end
    add_message "google.cloud.osconfig.agentendpoint.v1.GcsObject" do
      optional :bucket, :string, 1
      optional :object, :string, 2
      optional :generation_number, :int64, 3
    end
  end
end

module Google
  module Cloud
    module Osconfig
      module Agentendpoint
        module V1
          PatchConfig = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.osconfig.agentendpoint.v1.PatchConfig").msgclass
          PatchConfig::RebootConfig = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.osconfig.agentendpoint.v1.PatchConfig.RebootConfig").enummodule
          AptSettings = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.osconfig.agentendpoint.v1.AptSettings").msgclass
          AptSettings::Type = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.osconfig.agentendpoint.v1.AptSettings.Type").enummodule
          YumSettings = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.osconfig.agentendpoint.v1.YumSettings").msgclass
          GooSettings = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.osconfig.agentendpoint.v1.GooSettings").msgclass
          ZypperSettings = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.osconfig.agentendpoint.v1.ZypperSettings").msgclass
          WindowsUpdateSettings = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.osconfig.agentendpoint.v1.WindowsUpdateSettings").msgclass
          WindowsUpdateSettings::Classification = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.osconfig.agentendpoint.v1.WindowsUpdateSettings.Classification").enummodule
          RetryStrategy = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.osconfig.agentendpoint.v1.RetryStrategy").msgclass
          ExecStep = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.osconfig.agentendpoint.v1.ExecStep").msgclass
          ExecStepConfig = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.osconfig.agentendpoint.v1.ExecStepConfig").msgclass
          ExecStepConfig::Interpreter = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.osconfig.agentendpoint.v1.ExecStepConfig.Interpreter").enummodule
          GcsObject = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.osconfig.agentendpoint.v1.GcsObject").msgclass
        end
      end
    end
  end
end
