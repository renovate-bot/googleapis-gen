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
    module Asset
      module V1p1beta1
        # Search all resources request.
        # @!attribute [rw] scope
        #   @return [String]
        #     Required. The relative name of an asset. The search is limited to the resources
        #     within the `scope`. The allowed value must be:
        #     * Organization number (such as "organizations/123")
        #     * Folder number(such as "folders/1234")
        #     * Project number (such as "projects/12345")
        #     * Project id (such as "projects/abc")
        # @!attribute [rw] query
        #   @return [String]
        #     Optional. The query statement.
        # @!attribute [rw] asset_types
        #   @return [Array<String>]
        #     Optional. A list of asset types that this request searches for. If empty, it will
        #     search all the supported asset types.
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     Optional. The page size for search result pagination. Page size is capped at 500 even
        #     if a larger value is given. If set to zero, server will pick an appropriate
        #     default. Returned results may be fewer than requested. When this happens,
        #     there could be more results as long as `next_page_token` is returned.
        # @!attribute [rw] page_token
        #   @return [String]
        #     Optional. If present, then retrieve the next batch of results from the preceding call
        #     to this method.  `page_token` must be the value of `next_page_token` from
        #     the previous response. The values of all other method parameters, must be
        #     identical to those in the previous call.
        # @!attribute [rw] order_by
        #   @return [String]
        #     Optional. A comma separated list of fields specifying the sorting order of the
        #     results. The default order is ascending. Add " desc" after the field name
        #     to indicate descending order. Redundant space characters are ignored. For
        #     example, "  foo ,  bar  desc  ".
        class SearchAllResourcesRequest; end

        # Search all resources response.
        # @!attribute [rw] results
        #   @return [Array<Google::Cloud::Asset::V1p1beta1::StandardResourceMetadata>]
        #     A list of resource that match the search query.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     If there are more results than those appearing in this response, then
        #     `next_page_token` is included.  To get the next set of results, call this
        #     method again using the value of `next_page_token` as `page_token`.
        class SearchAllResourcesResponse; end

        # Search all IAM policies request.
        # @!attribute [rw] scope
        #   @return [String]
        #     Required. The relative name of an asset. The search is limited to the resources
        #     within the `scope`. The allowed value must be:
        #     * Organization number (such as "organizations/123")
        #     * Folder number(such as "folders/1234")
        #     * Project number (such as "projects/12345")
        #     * Project id (such as "projects/abc")
        # @!attribute [rw] query
        #   @return [String]
        #     Optional. The query statement.
        #     Examples:
        #     * "policy:myuser@mydomain.com"
        #     * "policy:(myuser@mydomain.com viewer)"
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     Optional. The page size for search result pagination. Page size is capped at 500 even
        #     if a larger value is given. If set to zero, server will pick an appropriate
        #     default. Returned results may be fewer than requested. When this happens,
        #     there could be more results as long as `next_page_token` is returned.
        # @!attribute [rw] page_token
        #   @return [String]
        #     Optional. If present, retrieve the next batch of results from the preceding call to
        #     this method. `page_token` must be the value of `next_page_token` from the
        #     previous response. The values of all other method parameters must be
        #     identical to those in the previous call.
        class SearchAllIamPoliciesRequest; end

        # Search all IAM policies response.
        # @!attribute [rw] results
        #   @return [Array<Google::Cloud::Asset::V1p1beta1::IamPolicySearchResult>]
        #     A list of IamPolicy that match the search query. Related information such
        #     as the associated resource is returned along with the policy.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     Set if there are more results than those appearing in this response; to get
        #     the next set of results, call this method again, using this value as the
        #     `page_token`.
        class SearchAllIamPoliciesResponse; end
      end
    end
  end
end