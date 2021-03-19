# Copyright 2020 Google LLC
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

module Google
  module Cloud
    module Aiplatform
      module V1beta1
        # Request message for {Google::Cloud::Aiplatform::V1beta1::EndpointService::CreateEndpoint EndpointService::CreateEndpoint}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The resource name of the Location to create the Endpoint in.
        #     Format: `projects/{project}/locations/{location}`
        # @!attribute [rw] endpoint
        #   @return [Google::Cloud::Aiplatform::V1beta1::Endpoint]
        #     Required. The Endpoint to create.
        class CreateEndpointRequest; end

        # Runtime operation information for {Google::Cloud::Aiplatform::V1beta1::EndpointService::CreateEndpoint EndpointService::CreateEndpoint}.
        # @!attribute [rw] generic_metadata
        #   @return [Google::Cloud::Aiplatform::V1beta1::GenericOperationMetadata]
        #     The operation generic information.
        class CreateEndpointOperationMetadata; end

        # Request message for {Google::Cloud::Aiplatform::V1beta1::EndpointService::GetEndpoint EndpointService::GetEndpoint}
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the Endpoint resource.
        #     Format:
        #     `projects/{project}/locations/{location}/endpoints/{endpoint}`
        class GetEndpointRequest; end

        # Request message for {Google::Cloud::Aiplatform::V1beta1::EndpointService::ListEndpoints EndpointService::ListEndpoints}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The resource name of the Location from which to list the Endpoints.
        #     Format: `projects/{project}/locations/{location}`
        # @!attribute [rw] filter
        #   @return [String]
        #     Optional. An expression for filtering the results of the request. For field names
        #     both snake_case and camelCase are supported.
        #
        #     * `endpoint` supports = and !=. `endpoint` represents the Endpoint ID,
        #       i.e. the last segment of the Endpoint's {Google::Cloud::Aiplatform::V1beta1::Endpoint#name resource name}.
        #       * `display_name` supports = and, !=
        #       * `labels` supports general map functions that is:
        #         * `labels.key=value` - key:value equality
        #         * `labels.key:* or labels:key - key existence
        #         * A key including a space must be quoted. `labels."a key"`.
        #
        #         Some examples:
        #       * `endpoint=1`
        #       * `displayName="myDisplayName"`
        #       * `labels.myKey="myValue"`
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     Optional. The standard list page size.
        # @!attribute [rw] page_token
        #   @return [String]
        #     Optional. The standard list page token.
        #     Typically obtained via
        #     {Google::Cloud::Aiplatform::V1beta1::ListEndpointsResponse#next_page_token ListEndpointsResponse#next_page_token} of the previous
        #     {Google::Cloud::Aiplatform::V1beta1::EndpointService::ListEndpoints EndpointService::ListEndpoints} call.
        # @!attribute [rw] read_mask
        #   @return [Google::Protobuf::FieldMask]
        #     Optional. Mask specifying which fields to read.
        class ListEndpointsRequest; end

        # Response message for {Google::Cloud::Aiplatform::V1beta1::EndpointService::ListEndpoints EndpointService::ListEndpoints}.
        # @!attribute [rw] endpoints
        #   @return [Array<Google::Cloud::Aiplatform::V1beta1::Endpoint>]
        #     List of Endpoints in the requested page.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     A token to retrieve the next page of results.
        #     Pass to {Google::Cloud::Aiplatform::V1beta1::ListEndpointsRequest#page_token ListEndpointsRequest#page_token} to obtain that page.
        class ListEndpointsResponse; end

        # Request message for {Google::Cloud::Aiplatform::V1beta1::EndpointService::UpdateEndpoint EndpointService::UpdateEndpoint}.
        # @!attribute [rw] endpoint
        #   @return [Google::Cloud::Aiplatform::V1beta1::Endpoint]
        #     Required. The Endpoint which replaces the resource on the server.
        # @!attribute [rw] update_mask
        #   @return [Google::Protobuf::FieldMask]
        #     Required. The update mask applies to the resource.
        #     See
        #     [FieldMask](https://tinyurl.com/protobufs/google.protobuf#fieldmask).
        class UpdateEndpointRequest; end

        # Request message for {Google::Cloud::Aiplatform::V1beta1::EndpointService::DeleteEndpoint EndpointService::DeleteEndpoint}.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the Endpoint resource to be deleted.
        #     Format:
        #     `projects/{project}/locations/{location}/endpoints/{endpoint}`
        class DeleteEndpointRequest; end

        # Request message for {Google::Cloud::Aiplatform::V1beta1::EndpointService::DeployModel EndpointService::DeployModel}.
        # @!attribute [rw] endpoint
        #   @return [String]
        #     Required. The name of the Endpoint resource into which to deploy a Model.
        #     Format:
        #     `projects/{project}/locations/{location}/endpoints/{endpoint}`
        # @!attribute [rw] deployed_model
        #   @return [Google::Cloud::Aiplatform::V1beta1::DeployedModel]
        #     Required. The DeployedModel to be created within the Endpoint. Note that
        #     {Google::Cloud::Aiplatform::V1beta1::Endpoint#traffic_split Endpoint#traffic_split} must be updated for the DeployedModel to start
        #     receiving traffic, either as part of this call, or via
        #     {Google::Cloud::Aiplatform::V1beta1::EndpointService::UpdateEndpoint EndpointService::UpdateEndpoint}.
        # @!attribute [rw] traffic_split
        #   @return [Hash{String => Integer}]
        #     A map from a DeployedModel's ID to the percentage of this Endpoint's
        #     traffic that should be forwarded to that DeployedModel.
        #
        #     If this field is non-empty, then the Endpoint's
        #     {Google::Cloud::Aiplatform::V1beta1::Endpoint#traffic_split traffic_split} will be overwritten with it.
        #     To refer to the ID of the just being deployed Model, a "0" should be used,
        #     and the actual ID of the new DeployedModel will be filled in its place by
        #     this method. The traffic percentage values must add up to 100.
        #
        #     If this field is empty, then the Endpoint's
        #     {Google::Cloud::Aiplatform::V1beta1::Endpoint#traffic_split traffic_split} is not updated.
        class DeployModelRequest; end

        # Response message for {Google::Cloud::Aiplatform::V1beta1::EndpointService::DeployModel EndpointService::DeployModel}.
        # @!attribute [rw] deployed_model
        #   @return [Google::Cloud::Aiplatform::V1beta1::DeployedModel]
        #     The DeployedModel that had been deployed in the Endpoint.
        class DeployModelResponse; end

        # Runtime operation information for {Google::Cloud::Aiplatform::V1beta1::EndpointService::DeployModel EndpointService::DeployModel}.
        # @!attribute [rw] generic_metadata
        #   @return [Google::Cloud::Aiplatform::V1beta1::GenericOperationMetadata]
        #     The operation generic information.
        class DeployModelOperationMetadata; end

        # Request message for {Google::Cloud::Aiplatform::V1beta1::EndpointService::UndeployModel EndpointService::UndeployModel}.
        # @!attribute [rw] endpoint
        #   @return [String]
        #     Required. The name of the Endpoint resource from which to undeploy a Model.
        #     Format:
        #     `projects/{project}/locations/{location}/endpoints/{endpoint}`
        # @!attribute [rw] deployed_model_id
        #   @return [String]
        #     Required. The ID of the DeployedModel to be undeployed from the Endpoint.
        # @!attribute [rw] traffic_split
        #   @return [Hash{String => Integer}]
        #     If this field is provided, then the Endpoint's
        #     {Google::Cloud::Aiplatform::V1beta1::Endpoint#traffic_split traffic_split} will be overwritten with it. If
        #     last DeployedModel is being undeployed from the Endpoint, the
        #     [Endpoint.traffic_split] will always end up empty when this call returns.
        #     A DeployedModel will be successfully undeployed only if it doesn't have
        #     any traffic assigned to it when this method executes, or if this field
        #     unassigns any traffic to it.
        class UndeployModelRequest; end

        # Response message for {Google::Cloud::Aiplatform::V1beta1::EndpointService::UndeployModel EndpointService::UndeployModel}.
        class UndeployModelResponse; end

        # Runtime operation information for {Google::Cloud::Aiplatform::V1beta1::EndpointService::UndeployModel EndpointService::UndeployModel}.
        # @!attribute [rw] generic_metadata
        #   @return [Google::Cloud::Aiplatform::V1beta1::GenericOperationMetadata]
        #     The operation generic information.
        class UndeployModelOperationMetadata; end
      end
    end
  end
end