# frozen_string_literal: true

# Copyright 2022 Google LLC
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     https://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.

# Auto-generated by gapic-generator-ruby. DO NOT EDIT!


module Google
  module Cloud
    module Talent
      module V4
        # A Tenant resource represents a tenant in the service. A tenant is a group or
        # entity that shares common access with specific privileges for resources like
        # jobs. Customer may create multiple tenants to provide data isolation for
        # different groups.
        # @!attribute [rw] name
        #   @return [::String]
        #     Required during tenant update.
        #
        #     The resource name for a tenant. This is generated by the service when a
        #     tenant is created.
        #
        #     The format is "projects/\\{project_id}/tenants/\\{tenant_id}", for example,
        #     "projects/foo/tenants/bar".
        # @!attribute [rw] external_id
        #   @return [::String]
        #     Required. Client side tenant identifier, used to uniquely identify the tenant.
        #
        #     The maximum number of allowed characters is 255.
        class Tenant
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end
      end
    end
  end
end
