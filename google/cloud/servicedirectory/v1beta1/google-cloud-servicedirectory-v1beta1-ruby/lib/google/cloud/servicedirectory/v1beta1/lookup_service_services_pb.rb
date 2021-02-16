# Generated by the protocol buffer compiler.  DO NOT EDIT!
# Source: google/cloud/servicedirectory/v1beta1/lookup_service.proto for package 'Google.Cloud.ServiceDirectory.V1beta1'
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
require 'google/cloud/servicedirectory/v1beta1/lookup_service_pb'

module Google
  module Cloud
    module ServiceDirectory
      module V1beta1
        module LookupService
          # Service Directory API for looking up service data at runtime.
          class Service

            include GRPC::GenericService

            self.marshal_class_method = :encode
            self.unmarshal_class_method = :decode
            self.service_name = 'google.cloud.servicedirectory.v1beta1.LookupService'

            # Returns a [service][google.cloud.servicedirectory.v1beta1.Service] and its
            # associated endpoints.
            # Resolving a service is not considered an active developer method.
            rpc :ResolveService, ::Google::Cloud::ServiceDirectory::V1beta1::ResolveServiceRequest, ::Google::Cloud::ServiceDirectory::V1beta1::ResolveServiceResponse
          end

          Stub = Service.rpc_stub_class
        end
      end
    end
  end
end