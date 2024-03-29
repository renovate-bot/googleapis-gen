# Generated by the protocol buffer compiler.  DO NOT EDIT!
# Source: google/cloud/dialogflow/cx/v3beta1/environment.proto for package 'Google.Cloud.Dialogflow.CX.V3beta1'
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
require 'google/cloud/dialogflow/cx/v3beta1/environment_pb'

module Google
  module Cloud
    module Dialogflow
      module CX
        module V3beta1
          module Environments
            # Service for managing [Environments][google.cloud.dialogflow.cx.v3beta1.Environment].
            class Service

              include ::GRPC::GenericService

              self.marshal_class_method = :encode
              self.unmarshal_class_method = :decode
              self.service_name = 'google.cloud.dialogflow.cx.v3beta1.Environments'

              # Returns the list of all environments in the specified [Agent][google.cloud.dialogflow.cx.v3beta1.Agent].
              rpc :ListEnvironments, ::Google::Cloud::Dialogflow::CX::V3beta1::ListEnvironmentsRequest, ::Google::Cloud::Dialogflow::CX::V3beta1::ListEnvironmentsResponse
              # Retrieves the specified [Environment][google.cloud.dialogflow.cx.v3beta1.Environment].
              rpc :GetEnvironment, ::Google::Cloud::Dialogflow::CX::V3beta1::GetEnvironmentRequest, ::Google::Cloud::Dialogflow::CX::V3beta1::Environment
              # Creates an [Environment][google.cloud.dialogflow.cx.v3beta1.Environment] in the specified [Agent][google.cloud.dialogflow.cx.v3beta1.Agent].
              #
              # This method is a [long-running
              # operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
              # The returned `Operation` type has the following method-specific fields:
              #
              # - `metadata`: An empty [Struct
              #   message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
              # - `response`: [Environment][google.cloud.dialogflow.cx.v3beta1.Environment]
              rpc :CreateEnvironment, ::Google::Cloud::Dialogflow::CX::V3beta1::CreateEnvironmentRequest, ::Google::Longrunning::Operation
              # Updates the specified [Environment][google.cloud.dialogflow.cx.v3beta1.Environment].
              #
              # This method is a [long-running
              # operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
              # The returned `Operation` type has the following method-specific fields:
              #
              # - `metadata`: An empty [Struct
              #   message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
              # - `response`: [Environment][google.cloud.dialogflow.cx.v3beta1.Environment]
              rpc :UpdateEnvironment, ::Google::Cloud::Dialogflow::CX::V3beta1::UpdateEnvironmentRequest, ::Google::Longrunning::Operation
              # Deletes the specified [Environment][google.cloud.dialogflow.cx.v3beta1.Environment].
              rpc :DeleteEnvironment, ::Google::Cloud::Dialogflow::CX::V3beta1::DeleteEnvironmentRequest, ::Google::Protobuf::Empty
              # Looks up the history of the specified [Environment][google.cloud.dialogflow.cx.v3beta1.Environment].
              rpc :LookupEnvironmentHistory, ::Google::Cloud::Dialogflow::CX::V3beta1::LookupEnvironmentHistoryRequest, ::Google::Cloud::Dialogflow::CX::V3beta1::LookupEnvironmentHistoryResponse
              # Kicks off a continuous test under the specified [Environment][google.cloud.dialogflow.cx.v3beta1.Environment].
              #
              # This method is a [long-running
              # operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
              # The returned `Operation` type has the following method-specific fields:
              #
              # - `metadata`: [RunContinuousTestMetadata][google.cloud.dialogflow.cx.v3beta1.RunContinuousTestMetadata]
              # - `response`: [RunContinuousTestResponse][google.cloud.dialogflow.cx.v3beta1.RunContinuousTestResponse]
              rpc :RunContinuousTest, ::Google::Cloud::Dialogflow::CX::V3beta1::RunContinuousTestRequest, ::Google::Longrunning::Operation
              # Fetches a list of continuous test results for a given environment.
              rpc :ListContinuousTestResults, ::Google::Cloud::Dialogflow::CX::V3beta1::ListContinuousTestResultsRequest, ::Google::Cloud::Dialogflow::CX::V3beta1::ListContinuousTestResultsResponse
              # Deploys a flow to the specified [Environment][google.cloud.dialogflow.cx.v3beta1.Environment].
              #
              # This method is a [long-running
              # operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
              # The returned `Operation` type has the following method-specific fields:
              #
              # - `metadata`: [DeployFlowMetadata][google.cloud.dialogflow.cx.v3beta1.DeployFlowMetadata]
              # - `response`: [DeployFlowResponse][google.cloud.dialogflow.cx.v3beta1.DeployFlowResponse]
              rpc :DeployFlow, ::Google::Cloud::Dialogflow::CX::V3beta1::DeployFlowRequest, ::Google::Longrunning::Operation
            end

            Stub = Service.rpc_stub_class
          end
        end
      end
    end
  end
end
