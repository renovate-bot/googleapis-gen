# Generated by the protocol buffer compiler.  DO NOT EDIT!
# Source: google/cloud/dialogflow/cx/v3/transition_route_group.proto for package 'google.cloud.dialogflow.cx.v3'
# Original file comments:
# Copyright 2021 Google LLC
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
require 'google/cloud/dialogflow/cx/v3/transition_route_group_pb'

module Google
  module Cloud
    module Dialogflow
      module Cx
        module V3
          module TransitionRouteGroups
            # Service for managing [TransitionRouteGroups][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
            class Service

              include GRPC::GenericService

              self.marshal_class_method = :encode
              self.unmarshal_class_method = :decode
              self.service_name = 'google.cloud.dialogflow.cx.v3.TransitionRouteGroups'

              # Returns the list of all transition route groups in the specified flow.
              rpc :ListTransitionRouteGroups, ::Google::Cloud::Dialogflow::Cx::V3::ListTransitionRouteGroupsRequest, ::Google::Cloud::Dialogflow::Cx::V3::ListTransitionRouteGroupsResponse
              # Retrieves the specified [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
              rpc :GetTransitionRouteGroup, ::Google::Cloud::Dialogflow::Cx::V3::GetTransitionRouteGroupRequest, ::Google::Cloud::Dialogflow::Cx::V3::TransitionRouteGroup
              # Creates an [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup] in the specified flow.
              rpc :CreateTransitionRouteGroup, ::Google::Cloud::Dialogflow::Cx::V3::CreateTransitionRouteGroupRequest, ::Google::Cloud::Dialogflow::Cx::V3::TransitionRouteGroup
              # Updates the specified [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
              rpc :UpdateTransitionRouteGroup, ::Google::Cloud::Dialogflow::Cx::V3::UpdateTransitionRouteGroupRequest, ::Google::Cloud::Dialogflow::Cx::V3::TransitionRouteGroup
              # Deletes the specified [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
              rpc :DeleteTransitionRouteGroup, ::Google::Cloud::Dialogflow::Cx::V3::DeleteTransitionRouteGroupRequest, ::Google::Protobuf::Empty
            end

            Stub = Service.rpc_stub_class
          end
        end
      end
    end
  end
end
