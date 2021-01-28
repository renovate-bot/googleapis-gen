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
        # Request message for {Google::Cloud::Aiplatform::V1beta1::SpecialistPoolService::CreateSpecialistPool SpecialistPoolService::CreateSpecialistPool}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The parent Project name for the new SpecialistPool.
        #     The form is `projects/{project}/locations/{location}`.
        # @!attribute [rw] specialist_pool
        #   @return [Google::Cloud::Aiplatform::V1beta1::SpecialistPool]
        #     Required. The SpecialistPool to create.
        class CreateSpecialistPoolRequest; end

        # Runtime operation information for
        # {Google::Cloud::Aiplatform::V1beta1::SpecialistPoolService::CreateSpecialistPool SpecialistPoolService::CreateSpecialistPool}.
        # @!attribute [rw] generic_metadata
        #   @return [Google::Cloud::Aiplatform::V1beta1::GenericOperationMetadata]
        #     The operation generic information.
        class CreateSpecialistPoolOperationMetadata; end

        # Request message for {Google::Cloud::Aiplatform::V1beta1::SpecialistPoolService::GetSpecialistPool SpecialistPoolService::GetSpecialistPool}.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the SpecialistPool resource.
        #     The form is
        #
        #     `projects/{project}/locations/{location}/specialistPools/{specialist_pool}`.
        class GetSpecialistPoolRequest; end

        # Request message for {Google::Cloud::Aiplatform::V1beta1::SpecialistPoolService::ListSpecialistPools SpecialistPoolService::ListSpecialistPools}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The name of the SpecialistPool's parent resource.
        #     Format: `projects/{project}/locations/{location}`
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     The standard list page size.
        # @!attribute [rw] page_token
        #   @return [String]
        #     The standard list page token.
        #     Typically obtained by {Google::Cloud::Aiplatform::V1beta1::ListSpecialistPoolsResponse#next_page_token ListSpecialistPoolsResponse#next_page_token} of
        #     the previous {Google::Cloud::Aiplatform::V1beta1::SpecialistPoolService::ListSpecialistPools SpecialistPoolService::ListSpecialistPools} call. Return
        #     first page if empty.
        # @!attribute [rw] read_mask
        #   @return [Google::Protobuf::FieldMask]
        #     Mask specifying which fields to read. FieldMask represents a set of
        class ListSpecialistPoolsRequest; end

        # Response message for {Google::Cloud::Aiplatform::V1beta1::SpecialistPoolService::ListSpecialistPools SpecialistPoolService::ListSpecialistPools}.
        # @!attribute [rw] specialist_pools
        #   @return [Array<Google::Cloud::Aiplatform::V1beta1::SpecialistPool>]
        #     A list of SpecialistPools that matches the specified filter in the request.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     The standard List next-page token.
        class ListSpecialistPoolsResponse; end

        # Request message for {Google::Cloud::Aiplatform::V1beta1::SpecialistPoolService::DeleteSpecialistPool SpecialistPoolService::DeleteSpecialistPool}.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The resource name of the SpecialistPool to delete. Format:
        #     `projects/{project}/locations/{location}/specialistPools/{specialist_pool}`
        # @!attribute [rw] force
        #   @return [true, false]
        #     If set to true, any specialist managers in this SpecialistPool will also be
        #     deleted. (Otherwise, the request will only work if the SpecialistPool has
        #     no specialist managers.)
        class DeleteSpecialistPoolRequest; end

        # Request message for {Google::Cloud::Aiplatform::V1beta1::SpecialistPoolService::UpdateSpecialistPool SpecialistPoolService::UpdateSpecialistPool}.
        # @!attribute [rw] specialist_pool
        #   @return [Google::Cloud::Aiplatform::V1beta1::SpecialistPool]
        #     Required. The SpecialistPool which replaces the resource on the server.
        # @!attribute [rw] update_mask
        #   @return [Google::Protobuf::FieldMask]
        #     Required. The update mask applies to the resource.
        class UpdateSpecialistPoolRequest; end

        # Runtime operation metadata for
        # {Google::Cloud::Aiplatform::V1beta1::SpecialistPoolService::UpdateSpecialistPool SpecialistPoolService::UpdateSpecialistPool}.
        # @!attribute [rw] specialist_pool
        #   @return [String]
        #     Output only. The name of the SpecialistPool to which the specialists are being added.
        #     Format:
        #
        #     `projects/{project_id}/locations/{location_id}/specialistPools/{specialist_pool}`
        # @!attribute [rw] generic_metadata
        #   @return [Google::Cloud::Aiplatform::V1beta1::GenericOperationMetadata]
        #     The operation generic information.
        class UpdateSpecialistPoolOperationMetadata; end
      end
    end
  end
end