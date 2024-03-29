# Generated by the protocol buffer compiler.  DO NOT EDIT!
# Source: google/cloud/gaming/v1beta/realms_service.proto for package 'google.cloud.gaming.v1beta'
# Original file comments:
# Copyright 2020 Google LLC
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

require 'grpc'
require 'google/cloud/gaming/v1beta/realms_service_pb'

module Google
  module Cloud
    module Gaming
      module V1beta
        module RealmsService
          # A realm is a grouping of game server clusters that are considered
          # interchangeable.
          class Service

            include ::GRPC::GenericService

            self.marshal_class_method = :encode
            self.unmarshal_class_method = :decode
            self.service_name = 'google.cloud.gaming.v1beta.RealmsService'

            # Lists realms in a given project and location.
            rpc :ListRealms, ::Google::Cloud::Gaming::V1beta::ListRealmsRequest, ::Google::Cloud::Gaming::V1beta::ListRealmsResponse
            # Gets details of a single realm.
            rpc :GetRealm, ::Google::Cloud::Gaming::V1beta::GetRealmRequest, ::Google::Cloud::Gaming::V1beta::Realm
            # Creates a new realm in a given project and location.
            rpc :CreateRealm, ::Google::Cloud::Gaming::V1beta::CreateRealmRequest, ::Google::Longrunning::Operation
            # Deletes a single realm.
            rpc :DeleteRealm, ::Google::Cloud::Gaming::V1beta::DeleteRealmRequest, ::Google::Longrunning::Operation
            # Patches a single realm.
            rpc :UpdateRealm, ::Google::Cloud::Gaming::V1beta::UpdateRealmRequest, ::Google::Longrunning::Operation
            # Previews patches to a single realm.
            rpc :PreviewRealmUpdate, ::Google::Cloud::Gaming::V1beta::PreviewRealmUpdateRequest, ::Google::Cloud::Gaming::V1beta::PreviewRealmUpdateResponse
          end

          Stub = Service.rpc_stub_class
        end
      end
    end
  end
end
