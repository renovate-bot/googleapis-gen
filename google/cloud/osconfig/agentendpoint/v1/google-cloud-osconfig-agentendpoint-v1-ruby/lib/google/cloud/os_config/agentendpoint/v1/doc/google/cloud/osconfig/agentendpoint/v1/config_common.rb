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
    module Osconfig
      module Agentendpoint
        module V1
          # Step performed by the OS Config agent for configuring an `OSPolicyResource`
          # to its desired state.
          # @!attribute [rw] type
          #   @return [Google::Cloud::Osconfig::Agentendpoint::V1::OSPolicyResourceConfigStep::Type]
          #     Configuration step type.
          # @!attribute [rw] outcome
          #   @return [Google::Cloud::Osconfig::Agentendpoint::V1::OSPolicyResourceConfigStep::Outcome]
          #     Outcome of the configuration step.
          class OSPolicyResourceConfigStep
            # Supported outcomes for a configuration step.
            module Outcome
              # Default value. This value is unused.
              OUTCOME_UNSPECIFIED = 0

              # The step succeeded.
              SUCCEEDED = 1

              # The step failed.
              FAILED = 2
            end

            # Supported configuration step types
            module Type
              # Default value. This value is unused.
              TYPE_UNSPECIFIED = 0

              # Validation to detect resource conflicts, schema errors, etc.
              VALIDATION = 1

              # Check the current desired state status of the resource.
              DESIRED_STATE_CHECK = 2

              # Enforce the desired state for a resource that is not in desired state.
              DESIRED_STATE_ENFORCEMENT = 3

              # Re-check desired state status for a resource after enforcement of all
              # resources in the current configuration run.
              #
              # This step is used to determine the final desired state status for the
              # resource. It accounts for any resources that might have drifted from
              # their desired state due to side effects from configuring other resources
              # during the current configuration run.
              DESIRED_STATE_CHECK_POST_ENFORCEMENT = 4
            end
          end

          # Compliance data for an OS policy resource.
          # @!attribute [rw] os_policy_resource_id
          #   @return [String]
          #     The id of the OS policy resource.
          # @!attribute [rw] config_steps
          #   @return [Array<Google::Cloud::Osconfig::Agentendpoint::V1::OSPolicyResourceConfigStep>]
          #     Ordered list of configuration steps taken by the agent for the OS policy
          #     resource.
          # @!attribute [rw] state
          #   @return [Google::Cloud::Osconfig::Agentendpoint::V1::OSPolicyComplianceState]
          #     Compliance state of the OS policy resource.
          class OSPolicyResourceCompliance; end

          # Supported OSPolicy compliance states.
          module OSPolicyComplianceState
            # Default value. This value is unused.
            OS_POLICY_COMPLIANCE_STATE_UNSPECIFIED = 0

            # Compliant state.
            COMPLIANT = 1

            # Non-compliant state
            NON_COMPLIANT = 2

            # Unknown compliance state.
            UNKNOWN = 3

            # No applicable OS policies were found for the instance.
            # This state is only applicable to the instance.
            NO_OS_POLICIES_APPLICABLE = 4
          end
        end
      end
    end
  end
end