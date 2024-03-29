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

# [START agentendpoint_v1beta_generated_AgentEndpointService_RegisterAgent_sync]
require "google/cloud/osconfig/agentendpoint/v1beta"

# Create a client object. The client can be reused for multiple calls.
client = Google::Cloud::Osconfig::Agentendpoint::V1beta::AgentEndpointService::Client.new

# Create a request. To set request fields, pass in keyword arguments.
request = Google::Cloud::Osconfig::Agentendpoint::V1beta::RegisterAgentRequest.new

# Call the register_agent method.
result = client.register_agent request

# The returned object is of type Google::Cloud::Osconfig::Agentendpoint::V1beta::RegisterAgentResponse.
p result
# [END agentendpoint_v1beta_generated_AgentEndpointService_RegisterAgent_sync]
