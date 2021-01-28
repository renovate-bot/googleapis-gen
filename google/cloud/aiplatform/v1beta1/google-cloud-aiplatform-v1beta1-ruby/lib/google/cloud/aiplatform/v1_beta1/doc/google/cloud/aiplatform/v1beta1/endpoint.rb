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
        # Models are deployed into it, and afterwards Endpoint is called to obtain
        # predictions and explanations.
        # @!attribute [rw] name
        #   @return [String]
        #     Output only. The resource name of the Endpoint.
        # @!attribute [rw] display_name
        #   @return [String]
        #     Required. The display name of the Endpoint.
        #     The name can be up to 128 characters long and can be consist of any UTF-8
        #     characters.
        # @!attribute [rw] description
        #   @return [String]
        #     The description of the Endpoint.
        # @!attribute [rw] deployed_models
        #   @return [Array<Google::Cloud::Aiplatform::V1beta1::DeployedModel>]
        #     Output only. The models deployed in this Endpoint.
        #     To add or remove DeployedModels use {Google::Cloud::Aiplatform::V1beta1::EndpointService::DeployModel EndpointService::DeployModel} and
        #     {Google::Cloud::Aiplatform::V1beta1::EndpointService::UndeployModel EndpointService::UndeployModel} respectively.
        # @!attribute [rw] traffic_split
        #   @return [Hash{String => Integer}]
        #     A map from a DeployedModel's ID to the percentage of this Endpoint's
        #     traffic that should be forwarded to that DeployedModel.
        #
        #     If a DeployedModel's ID is not listed in this map, then it receives no
        #     traffic.
        #
        #     The traffic percentage values must add up to 100, or map must be empty if
        #     the Endpoint is to not accept any traffic at a moment.
        # @!attribute [rw] etag
        #   @return [String]
        #     Used to perform consistent read-modify-write updates. If not set, a blind
        #     "overwrite" update happens.
        # @!attribute [rw] labels
        #   @return [Hash{String => String}]
        #     The labels with user-defined metadata to organize your Endpoints.
        #
        #     Label keys and values can be no longer than 64 characters
        #     (Unicode codepoints), can only contain lowercase letters, numeric
        #     characters, underscores and dashes. International characters are allowed.
        #
        #     See https://goo.gl/xmQnxf for more information and examples of labels.
        # @!attribute [rw] create_time
        #   @return [Google::Protobuf::Timestamp]
        #     Output only. Timestamp when this Endpoint was created.
        # @!attribute [rw] update_time
        #   @return [Google::Protobuf::Timestamp]
        #     Output only. Timestamp when this Endpoint was last updated.
        class Endpoint; end

        # A deployment of a Model. Endpoints contain one or more DeployedModels.
        # @!attribute [rw] dedicated_resources
        #   @return [Google::Cloud::Aiplatform::V1beta1::DedicatedResources]
        #     A description of resources that are dedicated to the DeployedModel, and
        #     that need a higher degree of manual configuration.
        # @!attribute [rw] automatic_resources
        #   @return [Google::Cloud::Aiplatform::V1beta1::AutomaticResources]
        #     A description of resources that to large degree are decided by AI
        #     Platform, and require only a modest additional configuration.
        # @!attribute [rw] id
        #   @return [String]
        #     Output only. The ID of the DeployedModel.
        # @!attribute [rw] model
        #   @return [String]
        #     Required. The name of the Model this is the deployment of. Note that the Model
        #     may be in a different location than the DeployedModel's Endpoint.
        # @!attribute [rw] display_name
        #   @return [String]
        #     The display name of the DeployedModel. If not provided upon creation,
        #     the Model's display_name is used.
        # @!attribute [rw] create_time
        #   @return [Google::Protobuf::Timestamp]
        #     Output only. Timestamp when the DeployedModel was created.
        # @!attribute [rw] explanation_spec
        #   @return [Google::Cloud::Aiplatform::V1beta1::ExplanationSpec]
        #     Explanation configuration for this DeployedModel.
        #
        #     When deploying a Model using {Google::Cloud::Aiplatform::V1beta1::EndpointService::DeployModel EndpointService::DeployModel}, this value
        #     overrides the value of {Google::Cloud::Aiplatform::V1beta1::Model#explanation_spec Model#explanation_spec}. All fields of
        #     {Google::Cloud::Aiplatform::V1beta1::DeployedModel#explanation_spec explanation_spec} are optional in the request. If a field of
        #     {Google::Cloud::Aiplatform::V1beta1::DeployedModel#explanation_spec explanation_spec} is not populated, the value of the same field of
        #     {Google::Cloud::Aiplatform::V1beta1::Model#explanation_spec Model#explanation_spec} is inherited. The corresponding
        #     {Google::Cloud::Aiplatform::V1beta1::Model#explanation_spec Model#explanation_spec} must be populated, otherwise explanation for
        #     this Model is not allowed.
        # @!attribute [rw] service_account
        #   @return [String]
        #     The service account that the DeployedModel's container runs as. Specify the
        #     email address of the service account. If this service account is not
        #     specified, the container runs as a service account that doesn't have access
        #     to the resource project.
        #
        #     Users deploying the Model must have the `iam.serviceAccounts.actAs`
        #     permission on this service account.
        # @!attribute [rw] enable_container_logging
        #   @return [true, false]
        #     If true, the container of the DeployedModel instances will send `stderr`
        #     and `stdout` streams to Stackdriver Logging.
        #
        #     Only supported for custom-trained Models and AutoML Tables Models.
        # @!attribute [rw] enable_access_logging
        #   @return [true, false]
        #     These logs are like standard server access logs, containing
        #     information like timestamp and latency for each prediction request.
        #
        #     Note that Stackdriver logs may incur a cost, especially if your project
        #     receives prediction requests at a high queries per second rate (QPS).
        #     Estimate your costs before enabling this option.
        class DeployedModel; end
      end
    end
  end
end