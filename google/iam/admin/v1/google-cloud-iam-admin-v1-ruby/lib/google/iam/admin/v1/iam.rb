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

require "google/cloud/iam/admin/v1/version"

require "google/iam/admin/v1/iam/credentials"
require "google/iam/admin/v1/iam/paths"
require "google/iam/admin/v1/iam/client"

module Google
  module Iam
    module Admin
      module V1
        ##
        # Creates and manages Identity and Access Management (IAM) resources.
        #
        # You can use this service to work with all of the following resources:
        #
        # * **Service accounts**, which identify an application or a virtual machine
        #   (VM) instance rather than a person
        # * **Service account keys**, which service accounts use to authenticate with
        #   Google APIs
        # * **IAM policies for service accounts**, which specify the roles that a
        #   member has for the service account
        # * **IAM custom roles**, which help you limit the number of permissions that
        #   you grant to members
        #
        # In addition, you can use this service to complete the following tasks, among
        # others:
        #
        # * Test whether a service account can use specific permissions
        # * Check which roles you can grant for a specific resource
        # * Lint, or validate, condition expressions in an IAM policy
        #
        # To load this service and instantiate a client:
        #
        #     require "google/iam/admin/v1/iam"
        #     client = ::Google::Iam::Admin::V1::IAM::Client.new
        #
        module IAM
        end
      end
    end
  end
end

helper_path = ::File.join __dir__, "iam", "helpers.rb"
require "google/iam/admin/v1/iam/helpers" if ::File.file? helper_path
