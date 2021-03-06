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

require "google/cloud/playablelocations/v3/version"

require "google/maps/playablelocations/v3/playable_locations/credentials"
require "google/maps/playablelocations/v3/playable_locations/client"

module Google
  module Maps
    module Playablelocations
      module V3
        ##
        # The Playable Locations API for v3.
        #
        # To load this service and instantiate a client:
        #
        #     require "google/maps/playablelocations/v3/playable_locations"
        #     client = ::Google::Maps::Playablelocations::V3::PlayableLocations::Client.new
        #
        module PlayableLocations
        end
      end
    end
  end
end

helper_path = ::File.join __dir__, "playable_locations", "helpers.rb"
require "google/maps/playablelocations/v3/playable_locations/helpers" if ::File.file? helper_path
