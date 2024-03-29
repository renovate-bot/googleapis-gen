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

# [START uidetection_v1_generated_UiDetectionService_ExecuteDetection_sync]
require "google/chromeos/uidetection/v1"

# Create a client object. The client can be reused for multiple calls.
client = Google::Chromeos::Uidetection::V1::UiDetectionService::Client.new

# Create a request. To set request fields, pass in keyword arguments.
request = Google::Chromeos::Uidetection::V1::UiDetectionRequest.new

# Call the execute_detection method.
result = client.execute_detection request

# The returned object is of type Google::Chromeos::Uidetection::V1::UiDetectionResponse.
p result
# [END uidetection_v1_generated_UiDetectionService_ExecuteDetection_sync]
