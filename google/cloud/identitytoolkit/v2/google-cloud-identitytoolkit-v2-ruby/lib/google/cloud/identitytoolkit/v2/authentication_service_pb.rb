# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/identitytoolkit/v2/authentication_service.proto

require 'google/api/annotations_pb'
require 'google/api/field_behavior_pb'
require 'google/cloud/identitytoolkit/v2/mfa_info_pb'
require 'google/api/client_pb'
require 'google/protobuf'

Google::Protobuf::DescriptorPool.generated_pool.build do
  add_file("google/cloud/identitytoolkit/v2/authentication_service.proto", :syntax => :proto3) do
    add_message "google.cloud.identitytoolkit.v2.FinalizeMfaSignInRequest" do
      optional :mfa_pending_credential, :string, 2
      optional :tenant_id, :string, 4
      oneof :verification_info do
        optional :phone_verification_info, :message, 3, "google.cloud.identitytoolkit.v2.FinalizeMfaPhoneRequestInfo"
      end
    end
    add_message "google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse" do
      optional :id_token, :string, 1
      optional :refresh_token, :string, 2
      oneof :auxiliary_auth_info do
        optional :phone_auth_info, :message, 3, "google.cloud.identitytoolkit.v2.FinalizeMfaPhoneResponseInfo"
      end
    end
    add_message "google.cloud.identitytoolkit.v2.StartMfaSignInRequest" do
      optional :mfa_pending_credential, :string, 2
      optional :mfa_enrollment_id, :string, 3
      optional :tenant_id, :string, 5
      oneof :sign_in_info do
        optional :phone_sign_in_info, :message, 4, "google.cloud.identitytoolkit.v2.StartMfaPhoneRequestInfo"
      end
    end
    add_message "google.cloud.identitytoolkit.v2.StartMfaSignInResponse" do
      oneof :response_info do
        optional :phone_response_info, :message, 1, "google.cloud.identitytoolkit.v2.StartMfaPhoneResponseInfo"
      end
    end
  end
end

module Google
  module Cloud
    module IdentityToolkit
      module V2
        FinalizeMfaSignInRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.identitytoolkit.v2.FinalizeMfaSignInRequest").msgclass
        FinalizeMfaSignInResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse").msgclass
        StartMfaSignInRequest = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.identitytoolkit.v2.StartMfaSignInRequest").msgclass
        StartMfaSignInResponse = ::Google::Protobuf::DescriptorPool.generated_pool.lookup("google.cloud.identitytoolkit.v2.StartMfaSignInResponse").msgclass
      end
    end
  end
end
