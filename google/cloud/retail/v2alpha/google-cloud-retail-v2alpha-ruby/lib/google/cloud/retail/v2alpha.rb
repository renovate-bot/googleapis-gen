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

require "google/cloud/retail/v2alpha/catalog_service"
require "google/cloud/retail/v2alpha/completion_service"
require "google/cloud/retail/v2alpha/prediction_service"
require "google/cloud/retail/v2alpha/product_service"
require "google/cloud/retail/v2alpha/search_service"
require "google/cloud/retail/v2alpha/user_event_service"
require "google/cloud/retail/v2alpha/version"

module Google
  module Cloud
    module Retail
      ##
      # To load this package, including all its services, and instantiate a client:
      #
      #     require "google/cloud/retail/v2alpha"
      #     client = ::Google::Cloud::Retail::V2alpha::CatalogService::Client.new
      #
      module V2alpha
      end
    end
  end
end

helper_path = ::File.join __dir__, "v2alpha", "_helpers.rb"
require "google/cloud/retail/v2alpha/_helpers" if ::File.file? helper_path
