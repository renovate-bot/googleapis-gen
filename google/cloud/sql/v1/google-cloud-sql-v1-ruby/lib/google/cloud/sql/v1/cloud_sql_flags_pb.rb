# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/sql/v1/cloud_sql_flags.proto

require 'google/api/annotations_pb'
require 'google/cloud/sql/v1/cloud_sql_resources_pb'
require 'google/protobuf/wrappers_pb'
require 'google/api/client_pb'
require 'google/protobuf'

Google::Protobuf::DescriptorPool.generated_pool.build do
  add_file("google/cloud/sql/v1/cloud_sql_flags.proto", :syntax => :proto3) do
    add_message "google.cloud.sql.v1.SqlFlagsListRequest" do
      optional :database_version, :string, 1
    end
    add_message "google.cloud.sql.v1.FlagsListResponse" do
      optional :kind, :string, 1
      repeated :items, :message, 2, "google.cloud.sql.v1.Flag"
    end
    add_message "google.cloud.sql.v1.Flag" do
      optional :name, :string, 1
      optional :type, :enum, 2, "google.cloud.sql.v1.SqlFlagType"
      repeated :applies_to, :enum, 3, "google.cloud.sql.v1.SqlDatabaseVersion"
      repeated :allowed_string_values, :string, 4
      optional :min_value, :message, 5, "google.protobuf.Int64Value"
      optional :max_value, :message, 6, "google.protobuf.Int64Value"
      optional :requires_restart, :message, 7, "google.protobuf.BoolValue"
      optional :kind, :string, 8
      optional :in_beta, :message, 9, "google.protobuf.BoolValue"
      repeated :allowed_int_values, :int64, 10
    end
    add_enum "google.cloud.sql.v1.SqlFlagType" do
      value :SQL_FLAG_TYPE_UNSPECIFIED, 0
      value :BOOLEAN, 1
      value :STRING, 2
      value :INTEGER, 3
      value :NONE, 4
      value :MYSQL_TIMEZONE_OFFSET, 5
      value :FLOAT, 6
      value :REPEATED_STRING, 7
    end
  end
end

module Google
  module Cloud
    module Sql
      module V1
        SqlFlagsListRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.SqlFlagsListRequest").msgclass
        FlagsListResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.FlagsListResponse").msgclass
        Flag = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.Flag").msgclass
        SqlFlagType = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.SqlFlagType").enummodule
      end
    end
  end
end
