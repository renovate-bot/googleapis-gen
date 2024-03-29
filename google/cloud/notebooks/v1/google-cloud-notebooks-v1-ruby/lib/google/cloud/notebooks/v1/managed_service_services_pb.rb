# Generated by the protocol buffer compiler.  DO NOT EDIT!
# Source: google/cloud/notebooks/v1/managed_service.proto for package 'Google.Cloud.Notebooks.V1'
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
require 'google/cloud/notebooks/v1/managed_service_pb'

module Google
  module Cloud
    module Notebooks
      module V1
        module ManagedNotebookService
          # API v1 service for Managed Notebooks.
          class Service

            include ::GRPC::GenericService

            self.marshal_class_method = :encode
            self.unmarshal_class_method = :decode
            self.service_name = 'google.cloud.notebooks.v1.ManagedNotebookService'

            # Lists Runtimes in a given project and location.
            rpc :ListRuntimes, ::Google::Cloud::Notebooks::V1::ListRuntimesRequest, ::Google::Cloud::Notebooks::V1::ListRuntimesResponse
            # Gets details of a single Runtime. The location must be a regional endpoint
            # rather than zonal.
            rpc :GetRuntime, ::Google::Cloud::Notebooks::V1::GetRuntimeRequest, ::Google::Cloud::Notebooks::V1::Runtime
            # Creates a new Runtime in a given project and location.
            rpc :CreateRuntime, ::Google::Cloud::Notebooks::V1::CreateRuntimeRequest, ::Google::Longrunning::Operation
            # Deletes a single Runtime.
            rpc :DeleteRuntime, ::Google::Cloud::Notebooks::V1::DeleteRuntimeRequest, ::Google::Longrunning::Operation
            # Starts a Managed Notebook Runtime.
            # Perform "Start" on GPU instances; "Resume" on CPU instances
            # See:
            # https://cloud.google.com/compute/docs/instances/stop-start-instance
            # https://cloud.google.com/compute/docs/instances/suspend-resume-instance
            rpc :StartRuntime, ::Google::Cloud::Notebooks::V1::StartRuntimeRequest, ::Google::Longrunning::Operation
            # Stops a Managed Notebook Runtime.
            # Perform "Stop" on GPU instances; "Suspend" on CPU instances
            # See:
            # https://cloud.google.com/compute/docs/instances/stop-start-instance
            # https://cloud.google.com/compute/docs/instances/suspend-resume-instance
            rpc :StopRuntime, ::Google::Cloud::Notebooks::V1::StopRuntimeRequest, ::Google::Longrunning::Operation
            # Switch a Managed Notebook Runtime.
            rpc :SwitchRuntime, ::Google::Cloud::Notebooks::V1::SwitchRuntimeRequest, ::Google::Longrunning::Operation
            # Resets a Managed Notebook Runtime.
            rpc :ResetRuntime, ::Google::Cloud::Notebooks::V1::ResetRuntimeRequest, ::Google::Longrunning::Operation
            # Report and process a runtime event.
            rpc :ReportRuntimeEvent, ::Google::Cloud::Notebooks::V1::ReportRuntimeEventRequest, ::Google::Longrunning::Operation
          end

          Stub = Service.rpc_stub_class
        end
      end
    end
  end
end
