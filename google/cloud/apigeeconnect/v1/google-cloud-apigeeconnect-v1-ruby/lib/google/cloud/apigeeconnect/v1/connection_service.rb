# frozen_string_literal: true

# Copyright 2021 Google LLC
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

require "google/cloud/apigee_connect/v1/version"

require "google/cloud/apigeeconnect/v1/connection_service/credentials"
require "google/cloud/apigeeconnect/v1/connection_service/paths"
require "google/cloud/apigeeconnect/v1/connection_service/client"

module Google
  module Cloud
    module Apigeeconnect
      module V1
        ##
        # Service Interface for the Apigee Connect connection management APIs.
        #
        # To load this service and instantiate a client:
        #
        #     require "google/cloud/apigeeconnect/v1/connection_service"
        #     client = ::Google::Cloud::Apigeeconnect::V1::ConnectionService::Client.new
        #
        module ConnectionService
        end
      end
    end
  end
end

helper_path = ::File.join __dir__, "connection_service", "helpers.rb"
require "google/cloud/apigeeconnect/v1/connection_service/helpers" if ::File.file? helper_path
