# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/sql/v1/cloud_sql_instances.proto

require 'google/api/annotations_pb'
require 'google/api/field_behavior_pb'
require 'google/cloud/sql/v1/cloud_sql_resources_pb'
require 'google/protobuf/timestamp_pb'
require 'google/protobuf/wrappers_pb'
require 'google/api/client_pb'
require 'google/protobuf'

Google::Protobuf::DescriptorPool.generated_pool.build do
  add_file("google/cloud/sql/v1/cloud_sql_instances.proto", :syntax => :proto3) do
    add_message "google.cloud.sql.v1.SqlInstancesAddServerCaRequest" do
      optional :instance, :string, 1
      optional :project, :string, 2
    end
    add_message "google.cloud.sql.v1.SqlInstancesCloneRequest" do
      optional :instance, :string, 1
      optional :project, :string, 2
      optional :body, :message, 100, "google.cloud.sql.v1.InstancesCloneRequest"
    end
    add_message "google.cloud.sql.v1.SqlInstancesDeleteRequest" do
      optional :instance, :string, 1
      optional :project, :string, 2
    end
    add_message "google.cloud.sql.v1.SqlInstancesDemoteMasterRequest" do
      optional :instance, :string, 1
      optional :project, :string, 2
      optional :body, :message, 100, "google.cloud.sql.v1.InstancesDemoteMasterRequest"
    end
    add_message "google.cloud.sql.v1.SqlInstancesExportRequest" do
      optional :instance, :string, 1
      optional :project, :string, 2
      optional :body, :message, 100, "google.cloud.sql.v1.InstancesExportRequest"
    end
    add_message "google.cloud.sql.v1.SqlInstancesFailoverRequest" do
      optional :instance, :string, 1
      optional :project, :string, 2
      optional :body, :message, 100, "google.cloud.sql.v1.InstancesFailoverRequest"
    end
    add_message "google.cloud.sql.v1.SqlInstancesGetRequest" do
      optional :instance, :string, 1
      optional :project, :string, 2
    end
    add_message "google.cloud.sql.v1.SqlInstancesImportRequest" do
      optional :instance, :string, 1
      optional :project, :string, 2
      optional :body, :message, 100, "google.cloud.sql.v1.InstancesImportRequest"
    end
    add_message "google.cloud.sql.v1.SqlInstancesInsertRequest" do
      optional :project, :string, 1
      optional :body, :message, 100, "google.cloud.sql.v1.DatabaseInstance"
    end
    add_message "google.cloud.sql.v1.SqlInstancesListRequest" do
      optional :filter, :string, 1
      optional :max_results, :uint32, 2
      optional :page_token, :string, 3
      optional :project, :string, 4
    end
    add_message "google.cloud.sql.v1.SqlInstancesListServerCasRequest" do
      optional :instance, :string, 1
      optional :project, :string, 2
    end
    add_message "google.cloud.sql.v1.SqlInstancesPatchRequest" do
      optional :instance, :string, 1
      optional :project, :string, 2
      optional :body, :message, 100, "google.cloud.sql.v1.DatabaseInstance"
    end
    add_message "google.cloud.sql.v1.SqlInstancesPromoteReplicaRequest" do
      optional :instance, :string, 1
      optional :project, :string, 2
    end
    add_message "google.cloud.sql.v1.SqlInstancesResetSslConfigRequest" do
      optional :instance, :string, 1
      optional :project, :string, 2
    end
    add_message "google.cloud.sql.v1.SqlInstancesRestartRequest" do
      optional :instance, :string, 1
      optional :project, :string, 2
    end
    add_message "google.cloud.sql.v1.SqlInstancesRestoreBackupRequest" do
      optional :instance, :string, 1
      optional :project, :string, 2
      optional :body, :message, 100, "google.cloud.sql.v1.InstancesRestoreBackupRequest"
    end
    add_message "google.cloud.sql.v1.SqlInstancesRotateServerCaRequest" do
      optional :instance, :string, 1
      optional :project, :string, 2
      optional :body, :message, 100, "google.cloud.sql.v1.InstancesRotateServerCaRequest"
    end
    add_message "google.cloud.sql.v1.SqlInstancesStartReplicaRequest" do
      optional :instance, :string, 1
      optional :project, :string, 2
    end
    add_message "google.cloud.sql.v1.SqlInstancesStopReplicaRequest" do
      optional :instance, :string, 1
      optional :project, :string, 2
    end
    add_message "google.cloud.sql.v1.SqlInstancesTruncateLogRequest" do
      optional :instance, :string, 1
      optional :project, :string, 2
      optional :body, :message, 100, "google.cloud.sql.v1.InstancesTruncateLogRequest"
    end
    add_message "google.cloud.sql.v1.SqlInstancesUpdateRequest" do
      optional :instance, :string, 1
      optional :project, :string, 2
      optional :body, :message, 100, "google.cloud.sql.v1.DatabaseInstance"
    end
    add_message "google.cloud.sql.v1.SqlInstancesRescheduleMaintenanceRequest" do
      optional :instance, :string, 1
      optional :project, :string, 2
      optional :body, :message, 100, "google.cloud.sql.v1.SqlInstancesRescheduleMaintenanceRequestBody"
    end
    add_message "google.cloud.sql.v1.SqlInstancesVerifyExternalSyncSettingsRequest" do
      optional :instance, :string, 1
      optional :project, :string, 2
      optional :verify_connection_only, :bool, 3
      optional :sync_mode, :enum, 4, "google.cloud.sql.v1.SqlInstancesVerifyExternalSyncSettingsRequest.ExternalSyncMode"
      optional :verify_replication_only, :bool, 5
      oneof :sync_config do
        optional :mysql_sync_config, :message, 6, "google.cloud.sql.v1.MySqlSyncConfig"
      end
    end
    add_enum "google.cloud.sql.v1.SqlInstancesVerifyExternalSyncSettingsRequest.ExternalSyncMode" do
      value :EXTERNAL_SYNC_MODE_UNSPECIFIED, 0
      value :ONLINE, 1
      value :OFFLINE, 2
    end
    add_message "google.cloud.sql.v1.SqlInstancesStartExternalSyncRequest" do
      optional :instance, :string, 1
      optional :project, :string, 2
      optional :sync_mode, :enum, 3, "google.cloud.sql.v1.SqlInstancesVerifyExternalSyncSettingsRequest.ExternalSyncMode"
      optional :skip_verification, :bool, 4
      oneof :sync_config do
        optional :mysql_sync_config, :message, 6, "google.cloud.sql.v1.MySqlSyncConfig"
      end
    end
    add_message "google.cloud.sql.v1.SqlInstancesCreateEphemeralCertRequest" do
      optional :instance, :string, 1
      optional :project, :string, 2
      optional :body, :message, 100, "google.cloud.sql.v1.SslCertsCreateEphemeralRequest"
    end
    add_message "google.cloud.sql.v1.InstancesCloneRequest" do
      optional :clone_context, :message, 1, "google.cloud.sql.v1.CloneContext"
    end
    add_message "google.cloud.sql.v1.InstancesDemoteMasterRequest" do
      optional :demote_master_context, :message, 1, "google.cloud.sql.v1.DemoteMasterContext"
    end
    add_message "google.cloud.sql.v1.InstancesExportRequest" do
      optional :export_context, :message, 1, "google.cloud.sql.v1.ExportContext"
    end
    add_message "google.cloud.sql.v1.InstancesFailoverRequest" do
      optional :failover_context, :message, 1, "google.cloud.sql.v1.FailoverContext"
    end
    add_message "google.cloud.sql.v1.SslCertsCreateEphemeralRequest" do
      optional :public_key, :string, 1
      optional :access_token, :string, 2
    end
    add_message "google.cloud.sql.v1.InstancesImportRequest" do
      optional :import_context, :message, 1, "google.cloud.sql.v1.ImportContext"
    end
    add_message "google.cloud.sql.v1.InstancesListResponse" do
      optional :kind, :string, 1
      repeated :warnings, :message, 2, "google.cloud.sql.v1.ApiWarning"
      repeated :items, :message, 3, "google.cloud.sql.v1.DatabaseInstance"
      optional :next_page_token, :string, 4
    end
    add_message "google.cloud.sql.v1.InstancesListServerCasResponse" do
      repeated :certs, :message, 1, "google.cloud.sql.v1.SslCert"
      optional :active_version, :string, 2
      optional :kind, :string, 3
    end
    add_message "google.cloud.sql.v1.InstancesRestoreBackupRequest" do
      optional :restore_backup_context, :message, 1, "google.cloud.sql.v1.RestoreBackupContext"
    end
    add_message "google.cloud.sql.v1.InstancesRotateServerCaRequest" do
      optional :rotate_server_ca_context, :message, 1, "google.cloud.sql.v1.RotateServerCaContext"
    end
    add_message "google.cloud.sql.v1.InstancesTruncateLogRequest" do
      optional :truncate_log_context, :message, 1, "google.cloud.sql.v1.TruncateLogContext"
    end
    add_message "google.cloud.sql.v1.SqlInstancesVerifyExternalSyncSettingsResponse" do
      optional :kind, :string, 1
      repeated :errors, :message, 2, "google.cloud.sql.v1.SqlExternalSyncSettingError"
      repeated :warnings, :message, 3, "google.cloud.sql.v1.SqlExternalSyncSettingError"
    end
    add_message "google.cloud.sql.v1.CloneContext" do
      optional :kind, :string, 1
      optional :pitr_timestamp_ms, :int64, 2
      optional :destination_instance_name, :string, 3
      optional :bin_log_coordinates, :message, 4, "google.cloud.sql.v1.BinLogCoordinates"
      optional :point_in_time, :message, 5, "google.protobuf.Timestamp"
    end
    add_message "google.cloud.sql.v1.BinLogCoordinates" do
      optional :bin_log_file_name, :string, 1
      optional :bin_log_position, :int64, 2
      optional :kind, :string, 3
    end
    add_message "google.cloud.sql.v1.DatabaseInstance" do
      optional :kind, :string, 1
      optional :state, :enum, 2, "google.cloud.sql.v1.DatabaseInstance.SqlInstanceState"
      optional :database_version, :enum, 3, "google.cloud.sql.v1.SqlDatabaseVersion"
      optional :settings, :message, 4, "google.cloud.sql.v1.Settings"
      optional :etag, :string, 5
      optional :failover_replica, :message, 6, "google.cloud.sql.v1.DatabaseInstance.SqlFailoverReplica"
      optional :master_instance_name, :string, 7
      repeated :replica_names, :string, 8
      optional :max_disk_size, :message, 9, "google.protobuf.Int64Value"
      optional :current_disk_size, :message, 10, "google.protobuf.Int64Value"
      repeated :ip_addresses, :message, 11, "google.cloud.sql.v1.IpMapping"
      optional :server_ca_cert, :message, 12, "google.cloud.sql.v1.SslCert"
      optional :instance_type, :enum, 13, "google.cloud.sql.v1.SqlInstanceType"
      optional :project, :string, 14
      optional :ipv6_address, :string, 15
      optional :service_account_email_address, :string, 16
      optional :on_premises_configuration, :message, 17, "google.cloud.sql.v1.OnPremisesConfiguration"
      optional :replica_configuration, :message, 18, "google.cloud.sql.v1.ReplicaConfiguration"
      optional :backend_type, :enum, 19, "google.cloud.sql.v1.SqlBackendType"
      optional :self_link, :string, 20
      repeated :suspension_reason, :enum, 21, "google.cloud.sql.v1.SqlSuspensionReason"
      optional :connection_name, :string, 22
      optional :name, :string, 23
      optional :region, :string, 24
      optional :gce_zone, :string, 25
      optional :secondary_gce_zone, :string, 34
      optional :disk_encryption_configuration, :message, 26, "google.cloud.sql.v1.DiskEncryptionConfiguration"
      optional :disk_encryption_status, :message, 27, "google.cloud.sql.v1.DiskEncryptionStatus"
      optional :root_password, :string, 29
      optional :scheduled_maintenance, :message, 30, "google.cloud.sql.v1.DatabaseInstance.SqlScheduledMaintenance"
      optional :satisfies_pzs, :message, 35, "google.protobuf.BoolValue"
      proto3_optional :out_of_disk_report, :message, 38, "google.cloud.sql.v1.DatabaseInstance.SqlOutOfDiskReport"
      optional :create_time, :message, 39, "google.protobuf.Timestamp"
    end
    add_message "google.cloud.sql.v1.DatabaseInstance.SqlFailoverReplica" do
      optional :name, :string, 1
      optional :available, :message, 2, "google.protobuf.BoolValue"
    end
    add_message "google.cloud.sql.v1.DatabaseInstance.SqlScheduledMaintenance" do
      optional :start_time, :message, 1, "google.protobuf.Timestamp"
      optional :can_defer, :bool, 2
      optional :can_reschedule, :bool, 3
      proto3_optional :schedule_deadline_time, :message, 4, "google.protobuf.Timestamp"
    end
    add_message "google.cloud.sql.v1.DatabaseInstance.SqlOutOfDiskReport" do
      proto3_optional :sql_out_of_disk_state, :enum, 1, "google.cloud.sql.v1.DatabaseInstance.SqlOutOfDiskReport.SqlOutOfDiskState"
      proto3_optional :sql_min_recommended_increase_size_gb, :int32, 2
    end
    add_enum "google.cloud.sql.v1.DatabaseInstance.SqlOutOfDiskReport.SqlOutOfDiskState" do
      value :SQL_OUT_OF_DISK_STATE_UNSPECIFIED, 0
      value :NORMAL, 1
      value :SOFT_SHUTDOWN, 2
    end
    add_enum "google.cloud.sql.v1.DatabaseInstance.SqlInstanceState" do
      value :SQL_INSTANCE_STATE_UNSPECIFIED, 0
      value :RUNNABLE, 1
      value :SUSPENDED, 2
      value :PENDING_DELETE, 3
      value :PENDING_CREATE, 4
      value :MAINTENANCE, 5
      value :FAILED, 6
      value :ONLINE_MAINTENANCE, 7
    end
    add_message "google.cloud.sql.v1.SqlInstancesRescheduleMaintenanceRequestBody" do
      optional :reschedule, :message, 3, "google.cloud.sql.v1.SqlInstancesRescheduleMaintenanceRequestBody.Reschedule"
    end
    add_message "google.cloud.sql.v1.SqlInstancesRescheduleMaintenanceRequestBody.Reschedule" do
      optional :reschedule_type, :enum, 1, "google.cloud.sql.v1.SqlInstancesRescheduleMaintenanceRequestBody.RescheduleType"
      optional :schedule_time, :message, 2, "google.protobuf.Timestamp"
    end
    add_enum "google.cloud.sql.v1.SqlInstancesRescheduleMaintenanceRequestBody.RescheduleType" do
      value :RESCHEDULE_TYPE_UNSPECIFIED, 0
      value :IMMEDIATE, 1
      value :NEXT_AVAILABLE_WINDOW, 2
      value :SPECIFIC_TIME, 3
    end
    add_message "google.cloud.sql.v1.DemoteMasterContext" do
      optional :kind, :string, 1
      optional :verify_gtid_consistency, :message, 2, "google.protobuf.BoolValue"
      optional :master_instance_name, :string, 3
      optional :replica_configuration, :message, 4, "google.cloud.sql.v1.DemoteMasterConfiguration"
      optional :skip_replication_setup, :bool, 5
    end
    add_message "google.cloud.sql.v1.FailoverContext" do
      optional :settings_version, :int64, 1
      optional :kind, :string, 2
    end
    add_message "google.cloud.sql.v1.RestoreBackupContext" do
      optional :kind, :string, 1
      optional :backup_run_id, :int64, 2
      optional :instance_id, :string, 3
      optional :project, :string, 4
    end
    add_message "google.cloud.sql.v1.RotateServerCaContext" do
      optional :kind, :string, 1
      optional :next_version, :string, 2
    end
    add_message "google.cloud.sql.v1.TruncateLogContext" do
      optional :kind, :string, 1
      optional :log_type, :string, 2
    end
    add_message "google.cloud.sql.v1.SqlExternalSyncSettingError" do
      optional :kind, :string, 1
      optional :type, :enum, 2, "google.cloud.sql.v1.SqlExternalSyncSettingError.SqlExternalSyncSettingErrorType"
      optional :detail, :string, 3
    end
    add_enum "google.cloud.sql.v1.SqlExternalSyncSettingError.SqlExternalSyncSettingErrorType" do
      value :SQL_EXTERNAL_SYNC_SETTING_ERROR_TYPE_UNSPECIFIED, 0
      value :CONNECTION_FAILURE, 1
      value :BINLOG_NOT_ENABLED, 2
      value :INCOMPATIBLE_DATABASE_VERSION, 3
      value :REPLICA_ALREADY_SETUP, 4
      value :INSUFFICIENT_PRIVILEGE, 5
      value :UNSUPPORTED_MIGRATION_TYPE, 6
      value :NO_PGLOGICAL_INSTALLED, 7
      value :PGLOGICAL_NODE_ALREADY_EXISTS, 8
      value :INVALID_WAL_LEVEL, 9
      value :INVALID_SHARED_PRELOAD_LIBRARY, 10
      value :INSUFFICIENT_MAX_REPLICATION_SLOTS, 11
      value :INSUFFICIENT_MAX_WAL_SENDERS, 12
      value :INSUFFICIENT_MAX_WORKER_PROCESSES, 13
      value :UNSUPPORTED_EXTENSIONS, 14
      value :INVALID_RDS_LOGICAL_REPLICATION, 15
      value :INVALID_LOGGING_SETUP, 16
      value :INVALID_DB_PARAM, 17
      value :UNSUPPORTED_GTID_MODE, 18
      value :SQLSERVER_AGENT_NOT_RUNNING, 19
      value :UNSUPPORTED_TABLE_DEFINITION, 20
      value :UNSUPPORTED_DEFINER, 21
      value :SQLSERVER_SERVERNAME_MISMATCH, 22
      value :PRIMARY_ALREADY_SETUP, 23
      value :UNSUPPORTED_BINLOG_FORMAT, 24
      value :BINLOG_RETENTION_SETTING, 25
    end
    add_message "google.cloud.sql.v1.OnPremisesConfiguration" do
      optional :host_port, :string, 1
      optional :kind, :string, 2
      optional :username, :string, 3
      optional :password, :string, 4
      optional :ca_certificate, :string, 5
      optional :client_certificate, :string, 6
      optional :client_key, :string, 7
      optional :dump_file_path, :string, 8
      optional :source_instance, :message, 15, "google.cloud.sql.v1.InstanceReference"
    end
    add_message "google.cloud.sql.v1.ReplicaConfiguration" do
      optional :kind, :string, 1
      optional :mysql_replica_configuration, :message, 2, "google.cloud.sql.v1.MySqlReplicaConfiguration"
      optional :failover_target, :message, 3, "google.protobuf.BoolValue"
    end
    add_enum "google.cloud.sql.v1.SqlInstanceType" do
      value :SQL_INSTANCE_TYPE_UNSPECIFIED, 0
      value :CLOUD_SQL_INSTANCE, 1
      value :ON_PREMISES_INSTANCE, 2
      value :READ_REPLICA_INSTANCE, 3
    end
    add_enum "google.cloud.sql.v1.SqlSuspensionReason" do
      value :SQL_SUSPENSION_REASON_UNSPECIFIED, 0
      value :BILLING_ISSUE, 2
      value :LEGAL_ISSUE, 3
      value :OPERATIONAL_ISSUE, 4
      value :KMS_KEY_ISSUE, 5
    end
  end
end

module Google
  module Cloud
    module Sql
      module V1
        SqlInstancesAddServerCaRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.SqlInstancesAddServerCaRequest").msgclass
        SqlInstancesCloneRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.SqlInstancesCloneRequest").msgclass
        SqlInstancesDeleteRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.SqlInstancesDeleteRequest").msgclass
        SqlInstancesDemoteMasterRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.SqlInstancesDemoteMasterRequest").msgclass
        SqlInstancesExportRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.SqlInstancesExportRequest").msgclass
        SqlInstancesFailoverRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.SqlInstancesFailoverRequest").msgclass
        SqlInstancesGetRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.SqlInstancesGetRequest").msgclass
        SqlInstancesImportRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.SqlInstancesImportRequest").msgclass
        SqlInstancesInsertRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.SqlInstancesInsertRequest").msgclass
        SqlInstancesListRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.SqlInstancesListRequest").msgclass
        SqlInstancesListServerCasRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.SqlInstancesListServerCasRequest").msgclass
        SqlInstancesPatchRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.SqlInstancesPatchRequest").msgclass
        SqlInstancesPromoteReplicaRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.SqlInstancesPromoteReplicaRequest").msgclass
        SqlInstancesResetSslConfigRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.SqlInstancesResetSslConfigRequest").msgclass
        SqlInstancesRestartRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.SqlInstancesRestartRequest").msgclass
        SqlInstancesRestoreBackupRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.SqlInstancesRestoreBackupRequest").msgclass
        SqlInstancesRotateServerCaRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.SqlInstancesRotateServerCaRequest").msgclass
        SqlInstancesStartReplicaRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.SqlInstancesStartReplicaRequest").msgclass
        SqlInstancesStopReplicaRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.SqlInstancesStopReplicaRequest").msgclass
        SqlInstancesTruncateLogRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.SqlInstancesTruncateLogRequest").msgclass
        SqlInstancesUpdateRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.SqlInstancesUpdateRequest").msgclass
        SqlInstancesRescheduleMaintenanceRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.SqlInstancesRescheduleMaintenanceRequest").msgclass
        SqlInstancesVerifyExternalSyncSettingsRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.SqlInstancesVerifyExternalSyncSettingsRequest").msgclass
        SqlInstancesVerifyExternalSyncSettingsRequest::ExternalSyncMode = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.SqlInstancesVerifyExternalSyncSettingsRequest.ExternalSyncMode").enummodule
        SqlInstancesStartExternalSyncRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.SqlInstancesStartExternalSyncRequest").msgclass
        SqlInstancesCreateEphemeralCertRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.SqlInstancesCreateEphemeralCertRequest").msgclass
        InstancesCloneRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.InstancesCloneRequest").msgclass
        InstancesDemoteMasterRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.InstancesDemoteMasterRequest").msgclass
        InstancesExportRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.InstancesExportRequest").msgclass
        InstancesFailoverRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.InstancesFailoverRequest").msgclass
        SslCertsCreateEphemeralRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.SslCertsCreateEphemeralRequest").msgclass
        InstancesImportRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.InstancesImportRequest").msgclass
        InstancesListResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.InstancesListResponse").msgclass
        InstancesListServerCasResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.InstancesListServerCasResponse").msgclass
        InstancesRestoreBackupRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.InstancesRestoreBackupRequest").msgclass
        InstancesRotateServerCaRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.InstancesRotateServerCaRequest").msgclass
        InstancesTruncateLogRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.InstancesTruncateLogRequest").msgclass
        SqlInstancesVerifyExternalSyncSettingsResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.SqlInstancesVerifyExternalSyncSettingsResponse").msgclass
        CloneContext = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.CloneContext").msgclass
        BinLogCoordinates = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.BinLogCoordinates").msgclass
        DatabaseInstance = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.DatabaseInstance").msgclass
        DatabaseInstance::SqlFailoverReplica = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.DatabaseInstance.SqlFailoverReplica").msgclass
        DatabaseInstance::SqlScheduledMaintenance = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.DatabaseInstance.SqlScheduledMaintenance").msgclass
        DatabaseInstance::SqlOutOfDiskReport = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.DatabaseInstance.SqlOutOfDiskReport").msgclass
        DatabaseInstance::SqlOutOfDiskReport::SqlOutOfDiskState = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.DatabaseInstance.SqlOutOfDiskReport.SqlOutOfDiskState").enummodule
        DatabaseInstance::SqlInstanceState = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.DatabaseInstance.SqlInstanceState").enummodule
        SqlInstancesRescheduleMaintenanceRequestBody = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.SqlInstancesRescheduleMaintenanceRequestBody").msgclass
        SqlInstancesRescheduleMaintenanceRequestBody::Reschedule = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.SqlInstancesRescheduleMaintenanceRequestBody.Reschedule").msgclass
        SqlInstancesRescheduleMaintenanceRequestBody::RescheduleType = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.SqlInstancesRescheduleMaintenanceRequestBody.RescheduleType").enummodule
        DemoteMasterContext = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.DemoteMasterContext").msgclass
        FailoverContext = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.FailoverContext").msgclass
        RestoreBackupContext = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.RestoreBackupContext").msgclass
        RotateServerCaContext = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.RotateServerCaContext").msgclass
        TruncateLogContext = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.TruncateLogContext").msgclass
        SqlExternalSyncSettingError = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.SqlExternalSyncSettingError").msgclass
        SqlExternalSyncSettingError::SqlExternalSyncSettingErrorType = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.SqlExternalSyncSettingError.SqlExternalSyncSettingErrorType").enummodule
        OnPremisesConfiguration = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.OnPremisesConfiguration").msgclass
        ReplicaConfiguration = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.ReplicaConfiguration").msgclass
        SqlInstanceType = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.SqlInstanceType").enummodule
        SqlSuspensionReason = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.sql.v1.SqlSuspensionReason").enummodule
      end
    end
  end
end
