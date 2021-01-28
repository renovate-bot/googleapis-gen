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
    module Managedidentities
      module V1beta1
        # Represents the metadata of the long-running operation.
        # @!attribute [rw] create_time
        #   @return [Google::Protobuf::Timestamp]
        #     Output only. The time the operation was created.
        # @!attribute [rw] end_time
        #   @return [Google::Protobuf::Timestamp]
        #     Output only. The time the operation finished running.
        # @!attribute [rw] target
        #   @return [String]
        #     Output only. Server-defined resource path for the target of the operation.
        # @!attribute [rw] verb
        #   @return [String]
        #     Output only. Name of the verb executed by the operation.
        # @!attribute [rw] requested_cancellation
        #   @return [true, false]
        #     Output only. Identifies whether the user has requested cancellation
        #     of the operation. Operations that have successfully been cancelled
        #     have {Operation#error} value with a {Google::Rpc::Status#code} of 1,
        #     corresponding to `Code.CANCELLED`.
        # @!attribute [rw] api_version
        #   @return [String]
        #     Output only. API version used to start the operation.
        class OpMetadata; end

        # Request message for
        # {Google::Cloud::Managedidentities::V1beta1::CreateMicrosoftAdDomain CreateMicrosoftAdDomain}
        # @!attribute [rw] parent
        #   @return [String]
        #     The resource project name and location using the form:
        #     `projects/{project_id}/locations/global`
        # @!attribute [rw] domain_name
        #   @return [String]
        #     A domain name, e.g. mydomain.myorg.com, with the following restrictions:
        #     * Must contain only lowercase letters, numbers, periods and hyphens.
        #       * Must start with a letter.
        #     * Must contain between 2-64 characters.
        #       * Must end with a number or a letter.
        #     * Must not start with period.
        #       * First segement length (mydomain form example above) shouldn't exceed
        #         15 chars.
        #       * The last segment cannot be fully numeric.
        #     * Must be unique within the customer project.
        # @!attribute [rw] domain
        #   @return [Google::Cloud::Managedidentities::V1beta1::Domain]
        #     A Managed Identity domain resource.
        class CreateMicrosoftAdDomainRequest; end

        # Request message for
        # {Google::Cloud::Managedidentities::V1beta1::ResetAdminPassword ResetAdminPassword}
        # @!attribute [rw] name
        #   @return [String]
        #     The domain resource name using the form:
        #     `projects/{project_id}/locations/global/domains/{domain_name}`
        class ResetAdminPasswordRequest; end

        # Response message for
        # {Google::Cloud::Managedidentities::V1beta1::ResetAdminPassword ResetAdminPassword}
        # @!attribute [rw] password
        #   @return [String]
        #     A random password. See {Google::Cloud::Managedidentities::V1beta1::Domain#admin admin} for more information.
        class ResetAdminPasswordResponse; end

        # Request message for
        # {Google::Cloud::Managedidentities::V1beta1::ListDomains ListDomains}
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The resource name of the domain location using the form:
        #     `projects/{project_id}/locations/global`
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     Optional. The maximum number of items to return.
        #     If not specified, a default value of 1000 will be used.
        #     Regardless of the page_size value, the response may include a partial list.
        #     Callers should rely on a response's
        #     {Google::Cloud::Managedidentities::V1beta1::ListDomainsResponse#next_page_token next_page_token}
        #     to determine if there are additional results to list.
        # @!attribute [rw] page_token
        #   @return [String]
        #     The `next_page_token` value returned from a previous ListDomainsRequest
        #     request, if any.
        # @!attribute [rw] filter
        #   @return [String]
        #     Optional. A filter specifying constraints of a list operation.
        #     For example, `Domain.fqdn="mydomain.myorginization"`.
        # @!attribute [rw] order_by
        #   @return [String]
        #     Optional. Specifies the ordering of results. See
        #     [Sorting
        #     order](https://cloud.google.com/apis/design/design_patterns#sorting_order)
        #     for more information.
        class ListDomainsRequest; end

        # Response message for
        # {Google::Cloud::Managedidentities::V1beta1::ListDomains ListDomains}
        # @!attribute [rw] domains
        #   @return [Array<Google::Cloud::Managedidentities::V1beta1::Domain>]
        #     A list of Managed Identities Service domains in the project.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     A token to retrieve the next page of results, or empty if there are no more
        #     results in the list.
        # @!attribute [rw] unreachable
        #   @return [Array<String>]
        #     A list of locations that could not be reached.
        class ListDomainsResponse; end

        # Request message for
        # {Google::Cloud::Managedidentities::V1beta1::GetDomain GetDomain}
        # @!attribute [rw] name
        #   @return [String]
        #     The domain resource name using the form:
        #     `projects/{project_id}/locations/global/domains/{domain_name}`
        class GetDomainRequest; end

        # Request message for
        # {Google::Cloud::Managedidentities::V1beta1::UpdateDomain UpdateDomain}
        # @!attribute [rw] update_mask
        #   @return [Google::Protobuf::FieldMask]
        #     Mask of fields to update. At least one path must be supplied in this
        #     field. The elements of the repeated paths field may only include
        #     fields from {Google::Cloud::Managedidentities::V1beta1::Domain Domain}:
        #     * `labels`
        #       * `locations`
        #     * `authorized_networks`
        # @!attribute [rw] domain
        #   @return [Google::Cloud::Managedidentities::V1beta1::Domain]
        #     Domain message with updated fields. Only supported fields specified in
        #     update_mask are updated.
        class UpdateDomainRequest; end

        # Request message for
        # {Google::Cloud::Managedidentities::V1beta1::DeleteDomain DeleteDomain}
        # @!attribute [rw] name
        #   @return [String]
        #     The domain resource name using the form:
        #     `projects/{project_id}/locations/global/domains/{domain_name}`
        class DeleteDomainRequest; end

        # Request message for
        # {Google::Cloud::Managedidentities::V1beta1::AttachTrust AttachTrust}
        # @!attribute [rw] name
        #   @return [String]
        #     The resource domain name, project name and location using the form:
        #     `projects/{project_id}/locations/global/domains/{domain_name}`
        # @!attribute [rw] trust
        #   @return [Google::Cloud::Managedidentities::V1beta1::Trust]
        #     The domain trust resource.
        class AttachTrustRequest; end

        # Request message for
        # {Google::Cloud::Managedidentities::V1beta1::ReconfigureTrust ReconfigureTrust}
        # @!attribute [rw] name
        #   @return [String]
        #     The resource domain name, project name and location using the form:
        #     `projects/{project_id}/locations/global/domains/{domain_name}`
        # @!attribute [rw] target_domain_name
        #   @return [String]
        #     The fully-qualified target domain name which will be in trust with current
        #     domain.
        # @!attribute [rw] target_dns_ip_addresses
        #   @return [Array<String>]
        #     The target DNS server IP addresses to resolve the remote domain involved
        #     in the trust.
        class ReconfigureTrustRequest; end

        # Request message for
        # {Google::Cloud::Managedidentities::V1beta1::DetachTrust DetachTrust}
        # @!attribute [rw] name
        #   @return [String]
        #     The resource domain name, project name, and location using the form:
        #     `projects/{project_id}/locations/global/domains/{domain_name}`
        # @!attribute [rw] trust
        #   @return [Google::Cloud::Managedidentities::V1beta1::Trust]
        #     The domain trust resource to removed.
        class DetachTrustRequest; end

        # Request message for
        # {Google::Cloud::Managedidentities::V1beta1::ValidateTrust ValidateTrust}
        # @!attribute [rw] name
        #   @return [String]
        #     The resource domain name, project name, and location using the form:
        #     `projects/{project_id}/locations/global/domains/{domain_name}`
        # @!attribute [rw] trust
        #   @return [Google::Cloud::Managedidentities::V1beta1::Trust]
        #     The domain trust to validate trust state for.
        class ValidateTrustRequest; end
      end
    end
  end
end