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

require "gapic/common"
require "gapic/config"
require "gapic/config/method"

require "google/identity/access_context_manager/v1/version"

require "google/identity/access_context_manager/v1/access_context_manager/credentials"
require "google/identity/access_context_manager/v1/access_context_manager/paths"
require "google/identity/access_context_manager/v1/access_context_manager/operations"
require "google/identity/access_context_manager/v1/access_context_manager/client"

module Google
  module Identity
    module AccessContextManager
      module V1
        ##
        # API for setting [Access Levels]
        # [google.identity.accesscontextmanager.v1.AccessLevel] and [Service
        # Perimeters] [google.identity.accesscontextmanager.v1.ServicePerimeter]
        # for Google Cloud Projects. Each organization has one [AccessPolicy]
        # [google.identity.accesscontextmanager.v1.AccessPolicy] containing the
        # [Access Levels] [google.identity.accesscontextmanager.v1.AccessLevel]
        # and [Service Perimeters]
        # [google.identity.accesscontextmanager.v1.ServicePerimeter]. This
        # [AccessPolicy] [google.identity.accesscontextmanager.v1.AccessPolicy] is
        # applicable to all resources in the organization.
        # AccessPolicies
        #
        # To load this service and instantiate a client:
        #
        #     require "google/identity/access_context_manager/v1/access_context_manager"
        #     client = ::Google::Identity::AccessContextManager::V1::AccessContextManager::Client.new
        #
        module AccessContextManager
        end
      end
    end
  end
end

helper_path = ::File.join __dir__, "access_context_manager", "helpers.rb"
require "google/identity/access_context_manager/v1/access_context_manager/helpers" if ::File.file? helper_path
