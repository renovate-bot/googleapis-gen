# Generated by the protocol buffer compiler.  DO NOT EDIT!
# Source: google/cloud/oslogin/v1beta/oslogin.proto for package 'Google.Cloud.OsLogin.V1beta'
# Original file comments:
# Copyright 2019 Google LLC.
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
#
#

require 'grpc'
require 'google/cloud/oslogin/v1beta/oslogin_pb'

module Google
  module Cloud
    module OsLogin
      module V1beta
        module OsLoginService
          # Cloud OS Login API
          #
          # The Cloud OS Login API allows you to manage users and their associated SSH
          # public keys for logging into virtual machines on Google Cloud Platform.
          class Service

            include GRPC::GenericService

            self.marshal_class_method = :encode
            self.unmarshal_class_method = :decode
            self.service_name = 'google.cloud.oslogin.v1beta.OsLoginService'

            # Deletes a POSIX account.
            rpc :DeletePosixAccount, ::Google::Cloud::OsLogin::V1beta::DeletePosixAccountRequest, ::Google::Protobuf::Empty
            # Deletes an SSH public key.
            rpc :DeleteSshPublicKey, ::Google::Cloud::OsLogin::V1beta::DeleteSshPublicKeyRequest, ::Google::Protobuf::Empty
            # Retrieves the profile information used for logging in to a virtual machine
            # on Google Compute Engine.
            rpc :GetLoginProfile, ::Google::Cloud::OsLogin::V1beta::GetLoginProfileRequest, ::Google::Cloud::OsLogin::V1beta::LoginProfile
            # Retrieves an SSH public key.
            rpc :GetSshPublicKey, ::Google::Cloud::OsLogin::V1beta::GetSshPublicKeyRequest, ::Google::Cloud::OsLogin::Common::SshPublicKey
            # Adds an SSH public key and returns the profile information. Default POSIX
            # account information is set when no username and UID exist as part of the
            # login profile.
            rpc :ImportSshPublicKey, ::Google::Cloud::OsLogin::V1beta::ImportSshPublicKeyRequest, ::Google::Cloud::OsLogin::V1beta::ImportSshPublicKeyResponse
            # Updates an SSH public key and returns the profile information. This method
            # supports patch semantics.
            rpc :UpdateSshPublicKey, ::Google::Cloud::OsLogin::V1beta::UpdateSshPublicKeyRequest, ::Google::Cloud::OsLogin::Common::SshPublicKey
          end

          Stub = Service.rpc_stub_class
        end
      end
    end
  end
end