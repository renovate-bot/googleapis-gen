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
  module Iam
    module V1
      # Associates `members` with a `role`.
      # @!attribute [rw] role
      #   @return [String]
      #     Role that is assigned to `members`.
      #     For example, `roles/viewer`, `roles/editor`, or `roles/owner`.
      # @!attribute [rw] members
      #   @return [Array<String>]
      #     Specifies the identities requesting access for a Cloud Platform resource.
      #     `members` can have the following values:
      #
      #     * `allUsers`: A special identifier that represents anyone who is
      #       on the internet; with or without a Google account.
      #
      #     * `allAuthenticatedUsers`: A special identifier that represents anyone
      #       who is authenticated with a Google account or a service account.
      #
      #     * `user:{emailid}`: An email address that represents a specific Google
      #       account. For example, `alice@example.com` .
      #
      #
      #     * `serviceAccount:{emailid}`: An email address that represents a service
      #       account. For example, `my-other-app@appspot.gserviceaccount.com`.
      #
      #     * `group:{emailid}`: An email address that represents a Google group.
      #       For example, `admins@example.com`.
      #
      #
      #     * `domain:{domain}`: The G Suite domain (primary) that represents all the
      #       users of that domain. For example, `google.com` or `example.com`.
      # @!attribute [rw] condition
      #   @return [Google::Type::Expr]
      #     The condition that is associated with this binding.
      #     NOTE: An unsatisfied condition will not allow user access via current
      #     binding. Different bindings, including their conditions, are examined
      #     independently.
      class Binding; end
    end
  end
end