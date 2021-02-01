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
    module Dialogflow
      module Cx
        module V3beta1
          # Represents a test case.
          # @!attribute [rw] name
          #   @return [String]
          #     The unique identifier of the test case.
          #     {Google::Cloud::Dialogflow::Cx::V3beta1::TestCases::CreateTestCase TestCases::CreateTestCase} will populate the name automatically.
          #     Otherwise use format: `projects/<Project ID>/locations/<LocationID>/agents/
          #     <AgentID>/testCases/<TestCase ID>`.
          # @!attribute [rw] tags
          #   @return [Array<String>]
          #     Tags are short descriptions that users may apply to test cases for
          #     organizational and filtering purposes. Each tag should start with "#" and
          #     has a limit of 30 characters.
          # @!attribute [rw] display_name
          #   @return [String]
          #     Required. The human-readable name of the test case, unique within the agent. Limit of
          #     200 characters.
          # @!attribute [rw] notes
          #   @return [String]
          #     Additional freeform notes about the test case. Limit of 400 characters.
          # @!attribute [rw] test_config
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::TestConfig]
          #     Config for the test case.
          # @!attribute [rw] test_case_conversation_turns
          #   @return [Array<Google::Cloud::Dialogflow::Cx::V3beta1::ConversationTurn>]
          #     The conversation turns uttered when the test case was created, in
          #     chronological order. These include the canonical set of agent utterances
          #     that should occur when the agent is working properly.
          # @!attribute [rw] creation_time
          #   @return [Google::Protobuf::Timestamp]
          #     Output only. When the test was created.
          # @!attribute [rw] last_test_result
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::TestCaseResult]
          #     The latest test result.
          class TestCase; end

          # Represents a result from running a test case in an agent environment.
          # @!attribute [rw] name
          #   @return [String]
          #     The resource name for the test case result. Format:
          #     `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>/testCases/
          #     <TestCase ID>/results/<TestCaseResult ID>`.
          # @!attribute [rw] environment
          #   @return [String]
          #     Environment where the test was run. If not set, it indicates the draft
          #     environment.
          # @!attribute [rw] conversation_turns
          #   @return [Array<Google::Cloud::Dialogflow::Cx::V3beta1::ConversationTurn>]
          #     The conversation turns uttered during the test case replay in chronological
          #     order.
          # @!attribute [rw] test_result
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::TestResult]
          #     Whether the test case passed in the agent environment.
          # @!attribute [rw] test_time
          #   @return [Google::Protobuf::Timestamp]
          #     The time that the test was run.
          class TestCaseResult; end

          # Represents configurations for a test case.
          # @!attribute [rw] tracking_parameters
          #   @return [Array<String>]
          #     Session parameters to be compared when calculating differences.
          # @!attribute [rw] flow
          #   @return [String]
          #     Flow name. If not set, default start flow is assumed.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/flows/<Flow ID>`.
          class TestConfig; end

          # One interaction between a human and virtual agent. The human provides some
          # input and the virtual agent provides a response.
          # @!attribute [rw] user_input
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::ConversationTurn::UserInput]
          #     The user input.
          # @!attribute [rw] virtual_agent_output
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::ConversationTurn::VirtualAgentOutput]
          #     The virtual agent output.
          class ConversationTurn
            # The input from the human user.
            # @!attribute [rw] input
            #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::QueryInput]
            #     Supports {Google::Cloud::Dialogflow::Cx::V3beta1::QueryInput#text text input}, {Google::Cloud::Dialogflow::Cx::V3beta1::QueryInput#event event input},
            #     {Google::Cloud::Dialogflow::Cx::V3beta1::QueryInput#dtmf dtmf input} in the test case.
            # @!attribute [rw] injected_parameters
            #   @return [Google::Protobuf::Struct]
            #     Parameters that need to be injected into the conversation during intent
            #     detection.
            # @!attribute [rw] is_webhook_enabled
            #   @return [true, false]
            #     If webhooks should be allowed to trigger in response to the user
            #     utterance. Often if parameters are injected, webhooks should not be
            #     enabled.
            class UserInput; end

            # The output from the virtual agent.
            # @!attribute [rw] session_parameters
            #   @return [Google::Protobuf::Struct]
            #     The session parameters available to the bot at this point.
            # @!attribute [rw] differences
            #   @return [Array<Google::Cloud::Dialogflow::Cx::V3beta1::TestRunDifference>]
            #     Output only. If this is part of a [result conversation
            #     turn][TestCaseResult.conversation_turns], the list of differences
            #     between the original run and the replay for this output, if any.
            # @!attribute [rw] diagnostic_info
            #   @return [Google::Protobuf::Struct]
            #     Required. Input only. The diagnostic
            #     {Session::DetectIntentResponse::QueryResult#diagnostic_info info}
            #     output for the turn.
            # @!attribute [rw] triggered_intent
            #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::Intent]
            #     The {Google::Cloud::Dialogflow::Cx::V3beta1::Intent Intent} that triggered the response. Only some fields such as
            #     name and displayname will be set.
            # @!attribute [rw] current_page
            #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::Page]
            #     The {Google::Cloud::Dialogflow::Cx::V3beta1::Page Page} on which the utterance was spoken. Only some fields such as
            #     name and displayname will be set.
            # @!attribute [rw] text_responses
            #   @return [Array<Google::Cloud::Dialogflow::Cx::V3beta1::ResponseMessage::Text>]
            #     The {Google::Cloud::Dialogflow::Cx::V3beta1::ResponseMessage::Text text} responses from the agent for the turn.
            # @!attribute [rw] status
            #   @return [Google::Rpc::Status]
            #     Response error from the agent in the test result. If set, other output
            #     is empty.
            class VirtualAgentOutput; end
          end

          # The description of differences between original and replayed agent output.
          # @!attribute [rw] type
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::TestRunDifference::DiffType]
          #     The type of diff.
          # @!attribute [rw] description
          #   @return [String]
          #     A description of the diff, showing the actual output vs expected output.
          class TestRunDifference
            # What part of the message replay differs from the test case.
            module DiffType
              # Should never be used.
              DIFF_TYPE_UNSPECIFIED = 0

              # The intent.
              INTENT = 1

              # The page.
              PAGE = 2

              # The parameters.
              PARAMETERS = 3

              # The message utterance.
              UTTERANCE = 4
            end
          end

          # Transition coverage represents the percentage of all possible transitions
          # present within any of a parent's test cases.
          # @!attribute [rw] transitions
          #   @return [Array<Google::Cloud::Dialogflow::Cx::V3beta1::TransitionCoverage::Transition>]
          #     The list of Transitions present in the agent.
          # @!attribute [rw] coverage_score
          #   @return [Float]
          #     The percent of transitions in the agent that are covered.
          class TransitionCoverage
            # The source or target of a transition.
            # @!attribute [rw] page
            #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::Page]
            #     Indicates a transition to a {Google::Cloud::Dialogflow::Cx::V3beta1::Page Page}. Only some fields such as name and
            #     displayname will be set.
            # @!attribute [rw] flow
            #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::Flow]
            #     Indicates a transition to a {Google::Cloud::Dialogflow::Cx::V3beta1::Flow Flow}. Only some fields such as name and
            #     displayname will be set.
            class TransitionNode; end

            # A transition in the agent's graph.
            # @!attribute [rw] source
            #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::TransitionCoverage::TransitionNode]
            #     The start node of a transition.
            # @!attribute [rw] index
            #   @return [Integer]
            #     The index of a transition in the transition list. Starting from 0.
            # @!attribute [rw] target
            #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::TransitionCoverage::TransitionNode]
            #     The end node of a transition.
            # @!attribute [rw] covered
            #   @return [true, false]
            #     Whether or not the transition is covered by at least one of the
            #     agent's test cases.
            # @!attribute [rw] transition_route
            #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::TransitionRoute]
            #     Intent route or condition route.
            # @!attribute [rw] event_handler
            #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::EventHandler]
            #     Event handler.
            class Transition; end
          end

          # Intent coverage represents the percentage of all possible intents in the
          # agent that are triggered in any of a parent's test cases.
          # @!attribute [rw] intents
          #   @return [Array<Google::Cloud::Dialogflow::Cx::V3beta1::IntentCoverage::Intent>]
          #     The list of Intents present in the agent
          # @!attribute [rw] coverage_score
          #   @return [Float]
          #     The percent of intents in the agent that are covered.
          class IntentCoverage
            # The agent's intent.
            # @!attribute [rw] intent
            #   @return [String]
            #     The intent full resource name
            # @!attribute [rw] covered
            #   @return [true, false]
            #     Whether or not the intent is covered by at least one of the agent's
            #     test cases.
            class Intent; end
          end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::TestCases::CalculateCoverage TestCases::CalculateCoverage}.
          # @!attribute [rw] agent
          #   @return [String]
          #     Required. The agent to calculate coverage for.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
          # @!attribute [rw] type
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::CalculateCoverageRequest::CoverageType]
          #     Required. The type of coverage requested.
          class CalculateCoverageRequest
            # The type of coverage score requested.
            module CoverageType
              # Should never be used.
              COVERAGE_TYPE_UNSPECIFIED = 0

              # Intent coverage.
              INTENT = 1

              # Page transition coverage
              PAGE_TRANSITION = 2
            end
          end

          # The response message for {Google::Cloud::Dialogflow::Cx::V3beta1::TestCases::CalculateCoverage TestCases::CalculateCoverage}.
          # @!attribute [rw] agent
          #   @return [String]
          #     The agent to calculate coverage for.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
          # @!attribute [rw] intent_coverage
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::IntentCoverage]
          #     Intent coverage.
          # @!attribute [rw] transition_coverage
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::TransitionCoverage]
          #     Transition coverage.
          class CalculateCoverageResponse; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::TestCases::ListTestCases TestCases::ListTestCases}.
          # @!attribute [rw] parent
          #   @return [String]
          #     Required. The agent to list all pages for.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
          # @!attribute [rw] page_size
          #   @return [Integer]
          #     The maximum number of items to return in a single page. By default 20.
          #     Note that when TestCaseView = FULL, the maximum page size allowed is 20.
          #     When TestCaseView = BASIC, the maximum page size allowed is 500.
          # @!attribute [rw] page_token
          #   @return [String]
          #     The next_page_token value returned from a previous list request.
          # @!attribute [rw] view
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::ListTestCasesRequest::TestCaseView]
          #     Specifies whether response should include all fields or just the metadata.
          class ListTestCasesRequest
            # Specifies how much test case information to include in the response.
            module TestCaseView
              # The default / unset value.
              # The API will default to the BASIC view.
              TEST_CASE_VIEW_UNSPECIFIED = 0

              # Include basic metadata about the test case, but not the conversation
              # turns. This is the default value.
              BASIC = 1

              # Include everything.
              FULL = 2
            end
          end

          # The response message for {Google::Cloud::Dialogflow::Cx::V3beta1::TestCases::ListTestCases TestCases::ListTestCases}.
          # @!attribute [rw] test_cases
          #   @return [Array<Google::Cloud::Dialogflow::Cx::V3beta1::TestCase>]
          #     The list of test cases. There will be a maximum number of items returned
          #     based on the page_size field in the request.
          # @!attribute [rw] next_page_token
          #   @return [String]
          #     Token to retrieve the next page of results, or empty if there are no more
          #     results in the list.
          class ListTestCasesResponse; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::TestCases::BatchDeleteTestCases TestCases::BatchDeleteTestCases}.
          # @!attribute [rw] parent
          #   @return [String]
          #     Required. The agent to delete test cases from.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
          # @!attribute [rw] names
          #   @return [Array<String>]
          #     Required. Format of test case names: `projects/<Project ID>/locations/
          #     <Location ID>/agents/<AgentID>/testCases/<TestCase ID>`.
          class BatchDeleteTestCasesRequest; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::TestCases::CreateTestCase TestCases::CreateTestCase}.
          # @!attribute [rw] parent
          #   @return [String]
          #     Required. The agent to create the test case for.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
          # @!attribute [rw] test_case
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::TestCase]
          #     Required. The test case to create.
          class CreateTestCaseRequest; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::TestCases::UpdateTestCase TestCases::UpdateTestCase}.
          # @!attribute [rw] test_case
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::TestCase]
          #     Required. The test case to update.
          # @!attribute [rw] update_mask
          #   @return [Google::Protobuf::FieldMask]
          #     Required. The mask to specify which fields should be updated. The
          #     {Google::Cloud::Dialogflow::Cx::V3beta1::TestCase#creation_time `creationTime`} and
          #     {Google::Cloud::Dialogflow::Cx::V3beta1::TestCase#last_test_result `lastTestResult`} cannot be updated.
          class UpdateTestCaseRequest; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::TestCases::GetTestCase TestCases::GetTestCase}.
          # @!attribute [rw] name
          #   @return [String]
          #     Required. The name of the testcase.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/testCases/<TestCase ID>`.
          class GetTestCaseRequest; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::TestCases::RunTestCase TestCases::RunTestCase}.
          # @!attribute [rw] name
          #   @return [String]
          #     Required. Format of test case name to run: `projects/<Project ID>/locations/
          #     <Location ID>/agents/<AgentID>/testCases/<TestCase ID>`.
          # @!attribute [rw] environment
          #   @return [String]
          #     Optional. Environment name. If not set, draft environment is assumed.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/environments/<Environment ID>`.
          class RunTestCaseRequest; end

          # The response message for {Google::Cloud::Dialogflow::Cx::V3beta1::TestCases::RunTestCase TestCases::RunTestCase}.
          # @!attribute [rw] result
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::TestCaseResult]
          #     The result.
          class RunTestCaseResponse; end

          # Metadata returned for the {Google::Cloud::Dialogflow::Cx::V3beta1::TestCases::RunTestCase TestCases::RunTestCase} long running operation.
          class RunTestCaseMetadata; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::TestCases::BatchRunTestCases TestCases::BatchRunTestCases}.
          # @!attribute [rw] parent
          #   @return [String]
          #     Required. Agent name. Format: `projects/<Project ID>/locations/<Location ID>/agents/
          #     <AgentID>`.
          # @!attribute [rw] environment
          #   @return [String]
          #     Optional. If not set, draft environment is assumed. Format: `projects/<Project
          #     ID>/locations/<Location ID>/agents/<Agent ID>/environments/<Environment
          #     ID>`.
          # @!attribute [rw] test_cases
          #   @return [Array<String>]
          #     Required. Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/testCases/<TestCase ID>`.
          class BatchRunTestCasesRequest; end

          # The response message for {Google::Cloud::Dialogflow::Cx::V3beta1::TestCases::BatchRunTestCases TestCases::BatchRunTestCases}.
          # @!attribute [rw] results
          #   @return [Array<Google::Cloud::Dialogflow::Cx::V3beta1::TestCaseResult>]
          #     The test case results. The detailed
          #     {Google::Cloud::Dialogflow::Cx::V3beta1::TestCaseResult#conversation_turns conversation turns} are empty in this
          #     response.
          class BatchRunTestCasesResponse; end

          # Metadata returned for the {Google::Cloud::Dialogflow::Cx::V3beta1::TestCases::BatchRunTestCases TestCases::BatchRunTestCases} long running
          # operation.
          # @!attribute [rw] errors
          #   @return [Array<Google::Cloud::Dialogflow::Cx::V3beta1::TestError>]
          #     The test errors.
          class BatchRunTestCasesMetadata; end

          # Error info for running a test.
          # @!attribute [rw] test_case
          #   @return [String]
          #     The test case resource name.
          # @!attribute [rw] status
          #   @return [Google::Rpc::Status]
          #     The status associated with the test.
          # @!attribute [rw] test_time
          #   @return [Google::Protobuf::Timestamp]
          #     The timestamp when the test was completed.
          class TestError; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::TestCases::ImportTestCases TestCases::ImportTestCases}.
          # @!attribute [rw] parent
          #   @return [String]
          #     Required. The agent to import test cases to.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
          # @!attribute [rw] gcs_uri
          #   @return [String]
          #     The [Google Cloud Storage](https://cloud.google.com/storage/docs/) URI
          #     to import test cases from. The format of this URI must be
          #     `gs://<bucket-name>/<object-name>`.
          # @!attribute [rw] content
          #   @return [String]
          #     Uncompressed raw byte content for test cases.
          class ImportTestCasesRequest; end

          # The response message for {Google::Cloud::Dialogflow::Cx::V3beta1::TestCases::ImportTestCases TestCases::ImportTestCases}.
          # @!attribute [rw] names
          #   @return [Array<String>]
          #     The unique identifiers of the new test cases.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/testCases/<TestCase ID>`.
          class ImportTestCasesResponse; end

          # Metadata returned for the {Google::Cloud::Dialogflow::Cx::V3beta1::TestCases::ImportTestCases TestCases::ImportTestCases} long running
          # operation.
          # @!attribute [rw] errors
          #   @return [Array<Google::Cloud::Dialogflow::Cx::V3beta1::TestCaseError>]
          #     Errors for failed test cases.
          class ImportTestCasesMetadata; end

          # Error info for importing a test.
          # @!attribute [rw] test_case
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::TestCase]
          #     The test case.
          # @!attribute [rw] status
          #   @return [Google::Rpc::Status]
          #     The status associated with the test case.
          class TestCaseError; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::TestCases::ExportTestCases TestCases::ExportTestCases}.
          # @!attribute [rw] parent
          #   @return [String]
          #     Required. The agent where to export test cases from.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
          # @!attribute [rw] gcs_uri
          #   @return [String]
          #     The [Google Cloud Storage](https://cloud.google.com/storage/docs/) URI to
          #     export the test cases to. The format of this URI must be
          #     `gs://<bucket-name>/<object-name>`. If unspecified, the serialized test
          #     cases is returned inline.
          # @!attribute [rw] data_format
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::ExportTestCasesRequest::DataFormat]
          #     The data format of the exported test cases. If not specified, `BLOB` is
          #     assumed.
          # @!attribute [rw] filter
          #   @return [String]
          #     The filter expression used to filter exported test cases, see
          #     [API Filtering](https://aip.dev/160). The expression is case insensitive
          #     and supports the following syntax:
          #
          #       name = <value> [OR name = <value>] ...
          #
          #     For example:
          #
          #     * "name = t1 OR name = t2" matches the test case with the exact resource
          #       name "t1" or "t2".
          class ExportTestCasesRequest
            # Data format of the exported test cases.
            module DataFormat
              # Unspecified format.
              DATA_FORMAT_UNSPECIFIED = 0

              # Raw bytes.
              BLOB = 1

              # JSON format.
              JSON = 2
            end
          end

          # The response message for {Google::Cloud::Dialogflow::Cx::V3beta1::TestCases::ExportTestCases TestCases::ExportTestCases}.
          # @!attribute [rw] gcs_uri
          #   @return [String]
          #     The URI to a file containing the exported test cases. This field is
          #     populated only if `gcs_uri` is specified in
          #     {Google::Cloud::Dialogflow::Cx::V3beta1::ExportTestCasesRequest ExportTestCasesRequest}.
          # @!attribute [rw] content
          #   @return [String]
          #     Uncompressed raw byte content for test cases.
          class ExportTestCasesResponse; end

          # Metadata returned for the {Google::Cloud::Dialogflow::Cx::V3beta1::TestCases::ExportTestCases TestCases::ExportTestCases} long running
          # operation.
          class ExportTestCasesMetadata; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::TestCases::ListTestCaseResults TestCases::ListTestCaseResults}.
          # @!attribute [rw] parent
          #   @return [String]
          #     Required. The test case to list results for.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>/
          #     testCases/<TestCase ID>`. Specify a `-` as a wildcard for TestCase ID to
          #     list results across multiple test cases.
          # @!attribute [rw] page_size
          #   @return [Integer]
          #     The maximum number of items to return in a single page. By default 100 and
          #     at most 1000.
          # @!attribute [rw] page_token
          #   @return [String]
          #     The next_page_token value returned from a previous list request.
          # @!attribute [rw] filter
          #   @return [String]
          #     The filter expression used to filter test case results. See
          #     [API Filtering](https://aip.dev/160).
          #
          #     The expression is case insensitive. Only 'AND' is supported for logical
          #     operators. The supported syntax is listed below in detail:
          #
          #       <field> <operator> <value> [AND <field> <operator> <value>] ...
          #       [AND latest]
          #
          #     The supported fields and operators are:
          #     field                 operator
          #     `environment`         `=`, `IN`  (Use value `draft` for draft environment)
          #     `test_time`           `>`, `<`
          #
          #     `latest` only returns the latest test result in all results for each test
          #     case.
          #
          #     Examples:
          #     * "environment=draft AND latest" matches the latest test result for each
          #       test case in the draft environment.
          #     * "environment IN (e1,e2)" matches any test case results with an
          #       environment resource name of either "e1" or "e2".
          #     * "test_time > 1602540713" matches any test case results with test time
          #       later than a unix timestamp in seconds 1602540713.
          class ListTestCaseResultsRequest; end

          # The response message for {Google::Cloud::Dialogflow::Cx::V3beta1::TestCases::ListTestCaseResults TestCases::ListTestCaseResults}.
          # @!attribute [rw] test_case_results
          #   @return [Array<Google::Cloud::Dialogflow::Cx::V3beta1::TestCaseResult>]
          #     The list of test case results.
          # @!attribute [rw] next_page_token
          #   @return [String]
          #     Token to retrieve the next page of results, or empty if there are no more
          #     results in the list.
          class ListTestCaseResultsResponse; end

          # The test result for a test case and an agent environment.
          module TestResult
            # Not specified. Should never be used.
            TEST_RESULT_UNSPECIFIED = 0

            # The test passed.
            PASSED = 1

            # The test did not pass.
            FAILED = 2
          end
        end
      end
    end
  end
end