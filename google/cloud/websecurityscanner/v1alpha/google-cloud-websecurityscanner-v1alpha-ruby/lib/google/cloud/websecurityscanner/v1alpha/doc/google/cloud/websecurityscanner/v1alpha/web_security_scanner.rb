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
    module Websecurityscanner
      module V1alpha
        # Request for the `CreateScanConfig` method.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The parent resource name where the scan is created, which should be a
        #     project resource name in the format 'projects/{projectId}'.
        # @!attribute [rw] scan_config
        #   @return [Google::Cloud::Websecurityscanner::V1alpha::ScanConfig]
        #     Required. The ScanConfig to be created.
        class CreateScanConfigRequest; end

        # Request for the `DeleteScanConfig` method.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The resource name of the ScanConfig to be deleted. The name follows the
        #     format of 'projects/{projectId}/scanConfigs/{scanConfigId}'.
        class DeleteScanConfigRequest; end

        # Request for the `GetScanConfig` method.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The resource name of the ScanConfig to be returned. The name follows the
        #     format of 'projects/{projectId}/scanConfigs/{scanConfigId}'.
        class GetScanConfigRequest; end

        # Request for the `ListScanConfigs` method.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The parent resource name, which should be a project resource name in the
        #     format 'projects/{projectId}'.
        # @!attribute [rw] page_token
        #   @return [String]
        #     A token identifying a page of results to be returned. This should be a
        #     `next_page_token` value returned from a previous List request.
        #     If unspecified, the first page of results is returned.
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     The maximum number of ScanConfigs to return, can be limited by server.
        #     If not specified or not positive, the implementation will select a
        #     reasonable value.
        class ListScanConfigsRequest; end

        # Request for the `UpdateScanConfigRequest` method.
        # @!attribute [rw] scan_config
        #   @return [Google::Cloud::Websecurityscanner::V1alpha::ScanConfig]
        #     Required. The ScanConfig to be updated. The name field must be set to identify the
        #     resource to be updated. The values of fields not covered by the mask
        #     will be ignored.
        # @!attribute [rw] update_mask
        #   @return [Google::Protobuf::FieldMask]
        #     Required. The update mask applies to the resource. For the `FieldMask` definition,
        #     see
        #     https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
        class UpdateScanConfigRequest; end

        # Response for the `ListScanConfigs` method.
        # @!attribute [rw] scan_configs
        #   @return [Array<Google::Cloud::Websecurityscanner::V1alpha::ScanConfig>]
        #     The list of ScanConfigs returned.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     Token to retrieve the next page of results, or empty if there are no
        #     more results in the list.
        class ListScanConfigsResponse; end

        # Request for the `StartScanRun` method.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The resource name of the ScanConfig to be used. The name follows the
        #     format of 'projects/{projectId}/scanConfigs/{scanConfigId}'.
        class StartScanRunRequest; end

        # Request for the `GetScanRun` method.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The resource name of the ScanRun to be returned. The name follows the
        #     format of
        #     'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
        class GetScanRunRequest; end

        # Request for the `ListScanRuns` method.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The parent resource name, which should be a scan resource name in the
        #     format 'projects/{projectId}/scanConfigs/{scanConfigId}'.
        # @!attribute [rw] page_token
        #   @return [String]
        #     A token identifying a page of results to be returned. This should be a
        #     `next_page_token` value returned from a previous List request.
        #     If unspecified, the first page of results is returned.
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     The maximum number of ScanRuns to return, can be limited by server.
        #     If not specified or not positive, the implementation will select a
        #     reasonable value.
        class ListScanRunsRequest; end

        # Response for the `ListScanRuns` method.
        # @!attribute [rw] scan_runs
        #   @return [Array<Google::Cloud::Websecurityscanner::V1alpha::ScanRun>]
        #     The list of ScanRuns returned.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     Token to retrieve the next page of results, or empty if there are no
        #     more results in the list.
        class ListScanRunsResponse; end

        # Request for the `StopScanRun` method.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The resource name of the ScanRun to be stopped. The name follows the
        #     format of
        #     'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
        class StopScanRunRequest; end

        # Request for the `ListCrawledUrls` method.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The parent resource name, which should be a scan run resource name in the
        #     format
        #     'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
        # @!attribute [rw] page_token
        #   @return [String]
        #     A token identifying a page of results to be returned. This should be a
        #     `next_page_token` value returned from a previous List request.
        #     If unspecified, the first page of results is returned.
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     The maximum number of CrawledUrls to return, can be limited by server.
        #     If not specified or not positive, the implementation will select a
        #     reasonable value.
        class ListCrawledUrlsRequest; end

        # Response for the `ListCrawledUrls` method.
        # @!attribute [rw] crawled_urls
        #   @return [Array<Google::Cloud::Websecurityscanner::V1alpha::CrawledUrl>]
        #     The list of CrawledUrls returned.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     Token to retrieve the next page of results, or empty if there are no
        #     more results in the list.
        class ListCrawledUrlsResponse; end

        # Request for the `GetFinding` method.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The resource name of the Finding to be returned. The name follows the
        #     format of
        #     'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}/findings/{findingId}'.
        class GetFindingRequest; end

        # Request for the `ListFindings` method.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The parent resource name, which should be a scan run resource name in the
        #     format
        #     'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
        # @!attribute [rw] filter
        #   @return [String]
        #     Required. The filter expression. The expression must be in the format: <field>
        #     <operator> <value>.
        #     Supported field: 'finding_type'.
        #     Supported operator: '='.
        # @!attribute [rw] page_token
        #   @return [String]
        #     A token identifying a page of results to be returned. This should be a
        #     `next_page_token` value returned from a previous List request.
        #     If unspecified, the first page of results is returned.
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     The maximum number of Findings to return, can be limited by server.
        #     If not specified or not positive, the implementation will select a
        #     reasonable value.
        class ListFindingsRequest; end

        # Response for the `ListFindings` method.
        # @!attribute [rw] findings
        #   @return [Array<Google::Cloud::Websecurityscanner::V1alpha::Finding>]
        #     The list of Findings returned.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     Token to retrieve the next page of results, or empty if there are no
        #     more results in the list.
        class ListFindingsResponse; end

        # Request for the `ListFindingTypeStats` method.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The parent resource name, which should be a scan run resource name in the
        #     format
        #     'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
        class ListFindingTypeStatsRequest; end

        # Response for the `ListFindingTypeStats` method.
        # @!attribute [rw] finding_type_stats
        #   @return [Array<Google::Cloud::Websecurityscanner::V1alpha::FindingTypeStats>]
        #     The list of FindingTypeStats returned.
        class ListFindingTypeStatsResponse; end
      end
    end
  end
end