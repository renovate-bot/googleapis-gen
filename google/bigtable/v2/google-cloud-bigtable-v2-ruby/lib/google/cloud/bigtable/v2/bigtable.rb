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

require "google/cloud/bigtable/v2/version"

require "google/cloud/bigtable/v2/bigtable/credentials"
require "google/cloud/bigtable/v2/bigtable/paths"
require "google/cloud/bigtable/v2/bigtable/client"

module Google
  module Cloud
    module Bigtable
      module V2
        ##
        # Service for reading from and writing to existing Bigtable tables.
        #
        # To load this service and instantiate a client:
        #
        #     require "google/cloud/bigtable/v2/bigtable"
        #     client = ::Google::Cloud::Bigtable::V2::Bigtable::Client.new
        #
        module Bigtable
        end
      end
    end
  end
end

helper_path = ::File.join __dir__, "bigtable", "helpers.rb"
require "google/cloud/bigtable/v2/bigtable/helpers" if ::File.file? helper_path
