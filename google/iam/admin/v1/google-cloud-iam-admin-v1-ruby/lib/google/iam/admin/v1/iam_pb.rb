# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/iam/admin/v1/iam.proto

require 'google/api/client_pb'
require 'google/api/field_behavior_pb'
require 'google/api/resource_pb'
require 'google/iam/v1/iam_policy_pb'
require 'google/iam/v1/options_pb'
require 'google/iam/v1/policy_pb'
require 'google/protobuf/any_pb'
require 'google/protobuf/empty_pb'
require 'google/protobuf/field_mask_pb'
require 'google/protobuf/timestamp_pb'
require 'google/type/expr_pb'
require 'google/api/annotations_pb'
require 'google/protobuf'

Google::Protobuf::DescriptorPool.generated_pool.build do
  add_file("google/iam/admin/v1/iam.proto", :syntax => :proto3) do
    add_message "google.iam.admin.v1.ServiceAccount" do
      optional :name, :string, 1
      optional :project_id, :string, 2
      optional :unique_id, :string, 4
      optional :email, :string, 5
      optional :display_name, :string, 6
      optional :etag, :bytes, 7
      optional :description, :string, 8
      optional :oauth2_client_id, :string, 9
      optional :disabled, :bool, 11
    end
    add_message "google.iam.admin.v1.CreateServiceAccountRequest" do
      optional :name, :string, 1
      optional :account_id, :string, 2
      optional :service_account, :message, 3, "google.iam.admin.v1.ServiceAccount"
    end
    add_message "google.iam.admin.v1.ListServiceAccountsRequest" do
      optional :name, :string, 1
      optional :page_size, :int32, 2
      optional :page_token, :string, 3
    end
    add_message "google.iam.admin.v1.ListServiceAccountsResponse" do
      repeated :accounts, :message, 1, "google.iam.admin.v1.ServiceAccount"
      optional :next_page_token, :string, 2
    end
    add_message "google.iam.admin.v1.GetServiceAccountRequest" do
      optional :name, :string, 1
    end
    add_message "google.iam.admin.v1.DeleteServiceAccountRequest" do
      optional :name, :string, 1
    end
    add_message "google.iam.admin.v1.PatchServiceAccountRequest" do
      optional :service_account, :message, 1, "google.iam.admin.v1.ServiceAccount"
      optional :update_mask, :message, 2, "google.protobuf.FieldMask"
    end
    add_message "google.iam.admin.v1.UndeleteServiceAccountRequest" do
      optional :name, :string, 1
    end
    add_message "google.iam.admin.v1.UndeleteServiceAccountResponse" do
      optional :restored_account, :message, 1, "google.iam.admin.v1.ServiceAccount"
    end
    add_message "google.iam.admin.v1.EnableServiceAccountRequest" do
      optional :name, :string, 1
    end
    add_message "google.iam.admin.v1.DisableServiceAccountRequest" do
      optional :name, :string, 1
    end
    add_message "google.iam.admin.v1.ListServiceAccountKeysRequest" do
      optional :name, :string, 1
      repeated :key_types, :enum, 2, "google.iam.admin.v1.ListServiceAccountKeysRequest.KeyType"
    end
    add_enum "google.iam.admin.v1.ListServiceAccountKeysRequest.KeyType" do
      value :KEY_TYPE_UNSPECIFIED, 0
      value :USER_MANAGED, 1
      value :SYSTEM_MANAGED, 2
    end
    add_message "google.iam.admin.v1.ListServiceAccountKeysResponse" do
      repeated :keys, :message, 1, "google.iam.admin.v1.ServiceAccountKey"
    end
    add_message "google.iam.admin.v1.GetServiceAccountKeyRequest" do
      optional :name, :string, 1
      optional :public_key_type, :enum, 2, "google.iam.admin.v1.ServiceAccountPublicKeyType"
    end
    add_message "google.iam.admin.v1.ServiceAccountKey" do
      optional :name, :string, 1
      optional :private_key_type, :enum, 2, "google.iam.admin.v1.ServiceAccountPrivateKeyType"
      optional :key_algorithm, :enum, 8, "google.iam.admin.v1.ServiceAccountKeyAlgorithm"
      optional :private_key_data, :bytes, 3
      optional :public_key_data, :bytes, 7
      optional :valid_after_time, :message, 4, "google.protobuf.Timestamp"
      optional :valid_before_time, :message, 5, "google.protobuf.Timestamp"
      optional :key_origin, :enum, 9, "google.iam.admin.v1.ServiceAccountKeyOrigin"
      optional :key_type, :enum, 10, "google.iam.admin.v1.ListServiceAccountKeysRequest.KeyType"
    end
    add_message "google.iam.admin.v1.CreateServiceAccountKeyRequest" do
      optional :name, :string, 1
      optional :private_key_type, :enum, 2, "google.iam.admin.v1.ServiceAccountPrivateKeyType"
      optional :key_algorithm, :enum, 3, "google.iam.admin.v1.ServiceAccountKeyAlgorithm"
    end
    add_message "google.iam.admin.v1.UploadServiceAccountKeyRequest" do
      optional :name, :string, 1
      optional :public_key_data, :bytes, 2
    end
    add_message "google.iam.admin.v1.DeleteServiceAccountKeyRequest" do
      optional :name, :string, 1
    end
    add_message "google.iam.admin.v1.SignBlobRequest" do
      optional :name, :string, 1
      optional :bytes_to_sign, :bytes, 2
    end
    add_message "google.iam.admin.v1.SignBlobResponse" do
      optional :key_id, :string, 1
      optional :signature, :bytes, 2
    end
    add_message "google.iam.admin.v1.SignJwtRequest" do
      optional :name, :string, 1
      optional :payload, :string, 2
    end
    add_message "google.iam.admin.v1.SignJwtResponse" do
      optional :key_id, :string, 1
      optional :signed_jwt, :string, 2
    end
    add_message "google.iam.admin.v1.Role" do
      optional :name, :string, 1
      optional :title, :string, 2
      optional :description, :string, 3
      repeated :included_permissions, :string, 7
      optional :stage, :enum, 8, "google.iam.admin.v1.Role.RoleLaunchStage"
      optional :etag, :bytes, 9
      optional :deleted, :bool, 11
    end
    add_enum "google.iam.admin.v1.Role.RoleLaunchStage" do
      value :ALPHA, 0
      value :BETA, 1
      value :GA, 2
      value :DEPRECATED, 4
      value :DISABLED, 5
      value :EAP, 6
    end
    add_message "google.iam.admin.v1.QueryGrantableRolesRequest" do
      optional :full_resource_name, :string, 1
      optional :view, :enum, 2, "google.iam.admin.v1.RoleView"
      optional :page_size, :int32, 3
      optional :page_token, :string, 4
    end
    add_message "google.iam.admin.v1.QueryGrantableRolesResponse" do
      repeated :roles, :message, 1, "google.iam.admin.v1.Role"
      optional :next_page_token, :string, 2
    end
    add_message "google.iam.admin.v1.ListRolesRequest" do
      optional :parent, :string, 1
      optional :page_size, :int32, 2
      optional :page_token, :string, 3
      optional :view, :enum, 4, "google.iam.admin.v1.RoleView"
      optional :show_deleted, :bool, 6
    end
    add_message "google.iam.admin.v1.ListRolesResponse" do
      repeated :roles, :message, 1, "google.iam.admin.v1.Role"
      optional :next_page_token, :string, 2
    end
    add_message "google.iam.admin.v1.GetRoleRequest" do
      optional :name, :string, 1
    end
    add_message "google.iam.admin.v1.CreateRoleRequest" do
      optional :parent, :string, 1
      optional :role_id, :string, 2
      optional :role, :message, 3, "google.iam.admin.v1.Role"
    end
    add_message "google.iam.admin.v1.UpdateRoleRequest" do
      optional :name, :string, 1
      optional :role, :message, 2, "google.iam.admin.v1.Role"
      optional :update_mask, :message, 3, "google.protobuf.FieldMask"
    end
    add_message "google.iam.admin.v1.DeleteRoleRequest" do
      optional :name, :string, 1
      optional :etag, :bytes, 2
    end
    add_message "google.iam.admin.v1.UndeleteRoleRequest" do
      optional :name, :string, 1
      optional :etag, :bytes, 2
    end
    add_message "google.iam.admin.v1.Permission" do
      optional :name, :string, 1
      optional :title, :string, 2
      optional :description, :string, 3
      optional :only_in_predefined_roles, :bool, 4
      optional :stage, :enum, 5, "google.iam.admin.v1.Permission.PermissionLaunchStage"
      optional :custom_roles_support_level, :enum, 6, "google.iam.admin.v1.Permission.CustomRolesSupportLevel"
      optional :api_disabled, :bool, 7
      optional :primary_permission, :string, 8
    end
    add_enum "google.iam.admin.v1.Permission.PermissionLaunchStage" do
      value :ALPHA, 0
      value :BETA, 1
      value :GA, 2
      value :DEPRECATED, 3
    end
    add_enum "google.iam.admin.v1.Permission.CustomRolesSupportLevel" do
      value :SUPPORTED, 0
      value :TESTING, 1
      value :NOT_SUPPORTED, 2
    end
    add_message "google.iam.admin.v1.QueryTestablePermissionsRequest" do
      optional :full_resource_name, :string, 1
      optional :page_size, :int32, 2
      optional :page_token, :string, 3
    end
    add_message "google.iam.admin.v1.QueryTestablePermissionsResponse" do
      repeated :permissions, :message, 1, "google.iam.admin.v1.Permission"
      optional :next_page_token, :string, 2
    end
    add_message "google.iam.admin.v1.QueryAuditableServicesRequest" do
      optional :full_resource_name, :string, 1
    end
    add_message "google.iam.admin.v1.QueryAuditableServicesResponse" do
      repeated :services, :message, 1, "google.iam.admin.v1.QueryAuditableServicesResponse.AuditableService"
    end
    add_message "google.iam.admin.v1.QueryAuditableServicesResponse.AuditableService" do
      optional :name, :string, 1
    end
    add_message "google.iam.admin.v1.LintPolicyRequest" do
      optional :full_resource_name, :string, 1
      oneof :lint_object do
        optional :condition, :message, 5, "google.type.Expr"
      end
    end
    add_message "google.iam.admin.v1.LintResult" do
      optional :level, :enum, 1, "google.iam.admin.v1.LintResult.Level"
      optional :validation_unit_name, :string, 2
      optional :severity, :enum, 3, "google.iam.admin.v1.LintResult.Severity"
      optional :field_name, :string, 5
      optional :location_offset, :int32, 6
      optional :debug_message, :string, 7
    end
    add_enum "google.iam.admin.v1.LintResult.Level" do
      value :LEVEL_UNSPECIFIED, 0
      value :CONDITION, 3
    end
    add_enum "google.iam.admin.v1.LintResult.Severity" do
      value :SEVERITY_UNSPECIFIED, 0
      value :ERROR, 1
      value :WARNING, 2
      value :NOTICE, 3
      value :INFO, 4
      value :DEPRECATED, 5
    end
    add_message "google.iam.admin.v1.LintPolicyResponse" do
      repeated :lint_results, :message, 1, "google.iam.admin.v1.LintResult"
    end
    add_enum "google.iam.admin.v1.ServiceAccountKeyAlgorithm" do
      value :KEY_ALG_UNSPECIFIED, 0
      value :KEY_ALG_RSA_1024, 1
      value :KEY_ALG_RSA_2048, 2
    end
    add_enum "google.iam.admin.v1.ServiceAccountPrivateKeyType" do
      value :TYPE_UNSPECIFIED, 0
      value :TYPE_PKCS12_FILE, 1
      value :TYPE_GOOGLE_CREDENTIALS_FILE, 2
    end
    add_enum "google.iam.admin.v1.ServiceAccountPublicKeyType" do
      value :TYPE_NONE, 0
      value :TYPE_X509_PEM_FILE, 1
      value :TYPE_RAW_PUBLIC_KEY, 2
    end
    add_enum "google.iam.admin.v1.ServiceAccountKeyOrigin" do
      value :ORIGIN_UNSPECIFIED, 0
      value :USER_PROVIDED, 1
      value :GOOGLE_PROVIDED, 2
    end
    add_enum "google.iam.admin.v1.RoleView" do
      value :BASIC, 0
      value :FULL, 1
    end
  end
end

module Google
  module Iam
    module Admin
      module V1
        ServiceAccount = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.ServiceAccount").msgclass
        CreateServiceAccountRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.CreateServiceAccountRequest").msgclass
        ListServiceAccountsRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.ListServiceAccountsRequest").msgclass
        ListServiceAccountsResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.ListServiceAccountsResponse").msgclass
        GetServiceAccountRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.GetServiceAccountRequest").msgclass
        DeleteServiceAccountRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.DeleteServiceAccountRequest").msgclass
        PatchServiceAccountRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.PatchServiceAccountRequest").msgclass
        UndeleteServiceAccountRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.UndeleteServiceAccountRequest").msgclass
        UndeleteServiceAccountResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.UndeleteServiceAccountResponse").msgclass
        EnableServiceAccountRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.EnableServiceAccountRequest").msgclass
        DisableServiceAccountRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.DisableServiceAccountRequest").msgclass
        ListServiceAccountKeysRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.ListServiceAccountKeysRequest").msgclass
        ListServiceAccountKeysRequest::KeyType = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.ListServiceAccountKeysRequest.KeyType").enummodule
        ListServiceAccountKeysResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.ListServiceAccountKeysResponse").msgclass
        GetServiceAccountKeyRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.GetServiceAccountKeyRequest").msgclass
        ServiceAccountKey = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.ServiceAccountKey").msgclass
        CreateServiceAccountKeyRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.CreateServiceAccountKeyRequest").msgclass
        UploadServiceAccountKeyRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.UploadServiceAccountKeyRequest").msgclass
        DeleteServiceAccountKeyRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.DeleteServiceAccountKeyRequest").msgclass
        SignBlobRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.SignBlobRequest").msgclass
        SignBlobResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.SignBlobResponse").msgclass
        SignJwtRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.SignJwtRequest").msgclass
        SignJwtResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.SignJwtResponse").msgclass
        Role = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.Role").msgclass
        Role::RoleLaunchStage = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.Role.RoleLaunchStage").enummodule
        QueryGrantableRolesRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.QueryGrantableRolesRequest").msgclass
        QueryGrantableRolesResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.QueryGrantableRolesResponse").msgclass
        ListRolesRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.ListRolesRequest").msgclass
        ListRolesResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.ListRolesResponse").msgclass
        GetRoleRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.GetRoleRequest").msgclass
        CreateRoleRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.CreateRoleRequest").msgclass
        UpdateRoleRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.UpdateRoleRequest").msgclass
        DeleteRoleRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.DeleteRoleRequest").msgclass
        UndeleteRoleRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.UndeleteRoleRequest").msgclass
        Permission = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.Permission").msgclass
        Permission::PermissionLaunchStage = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.Permission.PermissionLaunchStage").enummodule
        Permission::CustomRolesSupportLevel = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.Permission.CustomRolesSupportLevel").enummodule
        QueryTestablePermissionsRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.QueryTestablePermissionsRequest").msgclass
        QueryTestablePermissionsResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.QueryTestablePermissionsResponse").msgclass
        QueryAuditableServicesRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.QueryAuditableServicesRequest").msgclass
        QueryAuditableServicesResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.QueryAuditableServicesResponse").msgclass
        QueryAuditableServicesResponse::AuditableService = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.QueryAuditableServicesResponse.AuditableService").msgclass
        LintPolicyRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.LintPolicyRequest").msgclass
        LintResult = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.LintResult").msgclass
        LintResult::Level = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.LintResult.Level").enummodule
        LintResult::Severity = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.LintResult.Severity").enummodule
        LintPolicyResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.LintPolicyResponse").msgclass
        ServiceAccountKeyAlgorithm = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.ServiceAccountKeyAlgorithm").enummodule
        ServiceAccountPrivateKeyType = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.ServiceAccountPrivateKeyType").enummodule
        ServiceAccountPublicKeyType = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.ServiceAccountPublicKeyType").enummodule
        ServiceAccountKeyOrigin = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.ServiceAccountKeyOrigin").enummodule
        RoleView = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.iam.admin.v1.RoleView").enummodule
      end
    end
  end
end
