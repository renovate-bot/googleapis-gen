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
    module Orgpolicy
      module V2
        # Defines a Cloud Organization `Policy` which is used to specify `Constraints`
        # for configurations of Cloud Platform resources.
        # @!attribute [rw] name
        #   @return [String]
        #     Immutable. The resource name of the Policy. Must be one of the following
        #     forms, where constraint_name is the name of the constraint which this
        #     Policy configures:
        #     * `projects/{project_number}/policies/{constraint_name}`
        #     * `folders/{folder_id}/policies/{constraint_name}`
        #     * `organizations/{organization_id}/policies/{constraint_name}`
        #
        #     For example, "projects/123/policies/compute.disableSerialPortAccess".
        #
        #     Note: `projects/{project_id}/policies/{constraint_name}` is also an
        #     acceptable name for API requests, but responses will return the name using
        #     the equivalent project number.
        # @!attribute [rw] spec
        #   @return [Google::Cloud::Orgpolicy::V2::PolicySpec]
        #     Basic information about the Organization Policy.
        # @!attribute [rw] alternate
        #   @return [Google::Cloud::Orgpolicy::V2::AlternatePolicySpec]
        #     An alternate policy configuration that will be used instead of the baseline
        #     policy configurations as determined by the launch.
        #     Currently the only way the launch can trigger the alternate configuration
        #     is via dry-run/darklaunch.
        class Policy; end

        # Similar to PolicySpec but with an extra 'launch' field for launch reference.
        # The PolicySpec here is specific for dry-run/darklaunch.
        # @!attribute [rw] launch
        #   @return [String]
        #     Reference to the launch that will be used while audit logging and to
        #     control the launch.
        #     Should be set only in the alternate policy.
        # @!attribute [rw] spec
        #   @return [Google::Cloud::Orgpolicy::V2::PolicySpec]
        #     Specify `Constraint` for configurations of Cloud Platform resources.
        class AlternatePolicySpec; end

        # Defines a Cloud Organization `PolicySpec` which is used to specify
        # `Constraints` for configurations of Cloud Platform resources.
        # @!attribute [rw] etag
        #   @return [String]
        #     An opaque tag indicating the current version of the `Policy`, used for
        #     concurrency control.
        #
        #     This field is ignored if used in a `CreatePolicy` request.
        #
        #     When the `Policy` is returned from either a `GetPolicy` or a
        #     `ListPolicies` request, this `etag` indicates the version of the
        #     current `Policy` to use when executing a read-modify-write loop.
        #
        #     When the `Policy` is returned from a `GetEffectivePolicy` request, the
        #     `etag` will be unset.
        # @!attribute [rw] update_time
        #   @return [Google::Protobuf::Timestamp]
        #     Output only. The time stamp this was previously updated. This
        #     represents the last time a call to `CreatePolicy` or `UpdatePolicy` was
        #     made for that `Policy`.
        # @!attribute [rw] rules
        #   @return [Array<Google::Cloud::Orgpolicy::V2::PolicySpec::PolicyRule>]
        #     Up to 10 PolicyRules are allowed.
        #
        #     In Policies for boolean constraints, the following requirements apply:
        #     * There must be one and only one PolicyRule where condition is unset.
        #       * BooleanPolicyRules with conditions must set `enforced` to the opposite
        #         of the PolicyRule without a condition.
        #       * During policy evaluation, PolicyRules with conditions that are
        #         true for a target resource take precedence.
        # @!attribute [rw] inherit_from_parent
        #   @return [true, false]
        #     Determines the inheritance behavior for this `Policy`.
        #
        #     If `inherit_from_parent` is true, PolicyRules set higher up in the
        #     hierarchy (up to the closest root) are inherited and present in the
        #     effective policy. If it is false, then no rules are inherited, and this
        #     Policy becomes the new root for evaluation.
        #     This field can be set only for Policies which configure list constraints.
        # @!attribute [rw] reset
        #   @return [true, false]
        #     Ignores policies set above this resource and restores the
        #     `constraint_default` enforcement behavior of the specific `Constraint` at
        #     this resource.
        #     This field can be set in policies for either list or boolean
        #     constraints. If set, `rules` must be empty and `inherit_from_parent`
        #     must be set to false.
        class PolicySpec
          # A rule used to express this policy.
          # @!attribute [rw] values
          #   @return [Google::Cloud::Orgpolicy::V2::PolicySpec::PolicyRule::StringValues]
          #     List of values to be used for this PolicyRule. This field can be set
          #     only in Policies for list constraints.
          # @!attribute [rw] allow_all
          #   @return [true, false]
          #     Setting this to true means that all values are allowed. This field can
          #     be set only in Policies for list constraints.
          # @!attribute [rw] deny_all
          #   @return [true, false]
          #     Setting this to true means that all values are denied. This field can
          #     be set only in Policies for list constraints.
          # @!attribute [rw] enforce
          #   @return [true, false]
          #     If `true`, then the `Policy` is enforced. If `false`, then any
          #     configuration is acceptable.
          #     This field can be set only in Policies for boolean constraints.
          # @!attribute [rw] condition
          #   @return [Google::Type::Expr]
          #     A condition which determines whether this rule is used
          #     in the evaluation of the policy. When set, the `expression` field in
          #     the `Expr' must include from 1 to 10 subexpressions, joined by the "||"
          #     or "&&" operators. Each subexpression must be of the form
          #     "resource.matchLabels(key_name, value_name)",
          #     where key_name and value_name are the resource names for Label Keys
          #     and Values. These names are available from the Label Manager Service. An
          #     example expression is:
          #     "resource.matchLabels('labelKeys/123, 'labelValues/456')".
          class PolicyRule
            # A message that holds specific allowed and denied values.
            # This message can define specific values and subtrees of Cloud Resource
            # Manager resource hierarchy (`Organizations`, `Folders`, `Projects`) that
            # are allowed or denied. This is achieved by using the `under:` and
            # optional `is:` prefixes.
            # The `under:` prefix is used to denote resource subtree values.
            # The `is:` prefix is used to denote specific values, and is required only
            # if the value contains a ":". Values prefixed with "is:" are treated the
            # same as values with no prefix.
            # Ancestry subtrees must be in one of the following formats:
            # * "projects/<project-id>", e.g. "projects/tokyo-rain-123"
            #   * "folders/<folder-id>", e.g. "folders/1234"
            #     * "organizations/<organization-id>", e.g. "organizations/1234"
            #       The `supports_under` field of the associated `Constraint`  defines
            #       whether ancestry prefixes can be used.
            # @!attribute [rw] allowed_values
            #   @return [Array<String>]
            #     List of values allowed at this resource.
            # @!attribute [rw] denied_values
            #   @return [Array<String>]
            #     List of values denied at this resource.
            class StringValues; end
          end
        end

        # The request sent to the [ListConstraints]
        # [google.cloud.orgpolicy.v2.OrgPolicy.ListConstraints] method.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The Cloud resource that parents the constraint. Must be in one of the
        #     following forms:
        #     * `projects/{project_number}`
        #     * `projects/{project_id}`
        #     * `folders/{folder_id}`
        #     * `organizations/{organization_id}`
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     Size of the pages to be returned. This is currently unsupported and will
        #     be ignored. The server may at any point start using this field to limit
        #     page size.
        # @!attribute [rw] page_token
        #   @return [String]
        #     Page token used to retrieve the next page. This is currently unsupported
        #     and will be ignored. The server may at any point start using this field.
        class ListConstraintsRequest; end

        # The response returned from the [ListConstraints]
        # [google.cloud.orgpolicy.v2.OrgPolicy.ListConstraints] method.
        # @!attribute [rw] constraints
        #   @return [Array<Google::Cloud::Orgpolicy::V2::Constraint>]
        #     The collection of constraints that are available on the targeted resource.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     Page token used to retrieve the next page. This is currently not used.
        class ListConstraintsResponse; end

        # The request sent to the [ListPolicies]
        # [google.cloud.orgpolicy.v2.OrgPolicy.ListPolicies] method.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The target Cloud resource that parents the set of constraints and policies
        #     that will be returned from this call. Must be in one of the following
        #     forms:
        #     * `projects/{project_number}`
        #     * `projects/{project_id}`
        #     * `folders/{folder_id}`
        #     * `organizations/{organization_id}`
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     Size of the pages to be returned. This is currently unsupported and will
        #     be ignored. The server may at any point start using this field to limit
        #     page size.
        # @!attribute [rw] page_token
        #   @return [String]
        #     Page token used to retrieve the next page. This is currently unsupported
        #     and will be ignored. The server may at any point start using this field.
        class ListPoliciesRequest; end

        # The response returned from the [ListPolicies]
        # [google.cloud.orgpolicy.v2.OrgPolicy.ListPolicies] method. It will be empty
        # if no `Policies` are set on the resource.
        # @!attribute [rw] policies
        #   @return [Array<Google::Cloud::Orgpolicy::V2::Policy>]
        #     All `Policies` that exist on the resource. It will be empty if no
        #     `Policies` are set.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     Page token used to retrieve the next page. This is currently not used, but
        #     the server may at any point start supplying a valid token.
        class ListPoliciesResponse; end

        # The request sent to the [GetPolicy]
        # [google.cloud.orgpolicy.v2.OrgPolicy.GetPolicy] method.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. Resource name of the policy. See `Policy` for naming requirements.
        class GetPolicyRequest; end

        # The request sent to the [GetEffectivePolicy]
        # [google.cloud.orgpolicy.v2.OrgPolicy.GetEffectivePolicy] method.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The effective policy to compute. See `Policy` for naming rules.
        class GetEffectivePolicyRequest; end

        # The request sent to the [CreatePolicyRequest]
        # [google.cloud.orgpolicy.v2.OrgPolicy.CreatePolicy] method.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The Cloud resource that will parent the new Policy. Must be in one of the
        #     following forms:
        #     * `projects/{project_number}`
        #     * `projects/{project_id}`
        #     * `folders/{folder_id}`
        #     * `organizations/{organization_id}`
        # @!attribute [rw] policy
        #   @return [Google::Cloud::Orgpolicy::V2::Policy]
        #     Required. `Policy` to create.
        class CreatePolicyRequest; end

        # The request sent to the [UpdatePolicyRequest]
        # [google.cloud.orgpolicy.v2.OrgPolicy.UpdatePolicy] method.
        # @!attribute [rw] policy
        #   @return [Google::Cloud::Orgpolicy::V2::Policy]
        #     Required. `Policy` to update.
        class UpdatePolicyRequest; end

        # The request sent to the [DeletePolicy]
        # [google.cloud.orgpolicy.v2.OrgPolicy.DeletePolicy] method.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. Name of the policy to delete.
        #     See `Policy` for naming rules.
        class DeletePolicyRequest; end
      end
    end
  end
end