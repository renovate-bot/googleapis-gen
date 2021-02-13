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
        # A `constraint` describes a way to restrict resource's configuration. For
        # example, you could enforce a constraint that controls which cloud services
        # can be activated across an organization, or whether a Compute Engine instance
        # can have serial port connections established. `Constraints` can be configured
        # by the organization's policy adminstrator to fit the needs of the organzation
        # by setting a `policy` that includes `constraints` at different locations in
        # the organization's resource hierarchy. Policies are inherited down the
        # resource hierarchy from higher levels, but can also be overridden. For
        # details about the inheritance rules please read about
        # {Google::Cloud::OrgPolicy#v2::Policy `policies`}.
        #
        # `Constraints` have a default behavior determined by the `constraint_default`
        # field, which is the enforcement behavior that is used in the absence of a
        # `policy` being defined or inherited for the resource in question.
        # @!attribute [rw] name
        #   @return [String]
        #     Immutable. The resource name of the Constraint. Must be in one of
        #     the following forms:
        #     * `projects/{project_number}/constraints/{constraint_name}`
        #     * `folders/{folder_id}/constraints/{constraint_name}`
        #     * `organizations/{organization_id}/constraints/{constraint_name}`
        #
        #     For example, "/projects/123/constraints/compute.disableSerialPortAccess".
        # @!attribute [rw] display_name
        #   @return [String]
        #     The human readable name.
        #
        #     Mutable.
        # @!attribute [rw] description
        #   @return [String]
        #     Detailed description of what this `Constraint` controls as well as how and
        #     where it is enforced.
        #
        #     Mutable.
        # @!attribute [rw] constraint_default
        #   @return [Google::Cloud::Orgpolicy::V2::Constraint::ConstraintDefault]
        #     The evaluation behavior of this constraint in the absence of 'Policy'.
        # @!attribute [rw] list_constraint
        #   @return [Google::Cloud::Orgpolicy::V2::Constraint::ListConstraint]
        #     Defines this constraint as being a ListConstraint.
        # @!attribute [rw] boolean_constraint
        #   @return [Google::Cloud::Orgpolicy::V2::Constraint::BooleanConstraint]
        #     Defines this constraint as being a BooleanConstraint.
        class Constraint
          # A `Constraint` that allows or disallows a list of string values, which are
          # configured by an Organization's policy administrator with a `Policy`.
          # @!attribute [rw] supports_in
          #   @return [true, false]
          #     Indicates whether values grouped into categories can be used in
          #     `Policy.allowed_values` and `Policy.denied_values`. For example,
          #     `"in:Python"` would match any value in the 'Python' group.
          # @!attribute [rw] supports_under
          #   @return [true, false]
          #     Indicates whether subtrees of Cloud Resource Manager resource hierarchy
          #     can be used in `Policy.allowed_values` and `Policy.denied_values`. For
          #     example, `"under:folders/123"` would match any resource under the
          #     'folders/123' folder.
          class ListConstraint; end

          # A `Constraint` that is either enforced or not.
          #
          # For example a constraint `constraints/compute.disableSerialPortAccess`.
          # If it is enforced on a VM instance, serial port connections will not be
          # opened to that instance.
          class BooleanConstraint; end

          # Specifies the default behavior in the absence of any `Policy` for the
          # `Constraint`. This must not be `CONSTRAINT_DEFAULT_UNSPECIFIED`.
          #
          # Immutable after creation.
          module ConstraintDefault
            # This is only used for distinguishing unset values and should never be
            # used.
            CONSTRAINT_DEFAULT_UNSPECIFIED = 0

            # Indicate that all values are allowed for list constraints.
            # Indicate that enforcement is off for boolean constraints.
            ALLOW = 1

            # Indicate that all values are denied for list constraints.
            # Indicate that enforcement is on for boolean constraints.
            DENY = 2
          end
        end
      end
    end
  end
end