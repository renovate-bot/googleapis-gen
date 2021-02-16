# Generated by the protocol buffer compiler.  DO NOT EDIT!
# Source: google/cloud/dialogflow/cx/v3beta1/version.proto for package 'google.cloud.dialogflow.cx.v3beta1'
# Original file comments:
# Copyright 2021 Google LLC
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
require 'google/cloud/dialogflow/cx/v3beta1/version_pb'

module Google
  module Cloud
    module Dialogflow
      module Cx
        module V3beta1
          module Versions
            # Service for managing [Versions][google.cloud.dialogflow.cx.v3beta1.Version].
            class Service

              include GRPC::GenericService

              self.marshal_class_method = :encode
              self.unmarshal_class_method = :decode
              self.service_name = 'google.cloud.dialogflow.cx.v3beta1.Versions'

              # Returns the list of all versions in the specified [Flow][google.cloud.dialogflow.cx.v3beta1.Flow].
              rpc :ListVersions, ::Google::Cloud::Dialogflow::Cx::V3beta1::ListVersionsRequest, ::Google::Cloud::Dialogflow::Cx::V3beta1::ListVersionsResponse
              # Retrieves the specified [Version][google.cloud.dialogflow.cx.v3beta1.Version].
              rpc :GetVersion, ::Google::Cloud::Dialogflow::Cx::V3beta1::GetVersionRequest, ::Google::Cloud::Dialogflow::Cx::V3beta1::Version
              # Creates a [Version][google.cloud.dialogflow.cx.v3beta1.Version] in the specified [Flow][google.cloud.dialogflow.cx.v3beta1.Flow].
              rpc :CreateVersion, ::Google::Cloud::Dialogflow::Cx::V3beta1::CreateVersionRequest, ::Google::Longrunning::Operation
              # Updates the specified [Version][google.cloud.dialogflow.cx.v3beta1.Version].
              rpc :UpdateVersion, ::Google::Cloud::Dialogflow::Cx::V3beta1::UpdateVersionRequest, ::Google::Cloud::Dialogflow::Cx::V3beta1::Version
              # Deletes the specified [Version][google.cloud.dialogflow.cx.v3beta1.Version].
              rpc :DeleteVersion, ::Google::Cloud::Dialogflow::Cx::V3beta1::DeleteVersionRequest, ::Google::Protobuf::Empty
              # Loads a specified version to draft version.
              rpc :LoadVersion, ::Google::Cloud::Dialogflow::Cx::V3beta1::LoadVersionRequest, ::Google::Longrunning::Operation
            end

            Stub = Service.rpc_stub_class
          end
        end
      end
    end
  end
end
