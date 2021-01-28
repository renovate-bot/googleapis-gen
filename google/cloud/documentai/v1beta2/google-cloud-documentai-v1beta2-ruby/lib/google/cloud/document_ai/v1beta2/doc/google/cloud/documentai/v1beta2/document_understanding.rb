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
    module Documentai
      module V1beta2
        # Request to batch process documents as an asynchronous operation. The output
        # is written to Cloud Storage as JSON in the [Document] format.
        # @!attribute [rw] requests
        #   @return [Array<Google::Cloud::Documentai::V1beta2::ProcessDocumentRequest>]
        #     Required. Individual requests for each document.
        # @!attribute [rw] parent
        #   @return [String]
        #     Target project and location to make a call.
        #
        #     Format: `projects/{project-id}/locations/{location-id}`.
        #
        #     If no location is specified, a region will be chosen automatically.
        class BatchProcessDocumentsRequest; end

        # Request to process one document.
        # @!attribute [rw] parent
        #   @return [String]
        #     Target project and location to make a call.
        #
        #     Format: `projects/{project-id}/locations/{location-id}`.
        #
        #     If no location is specified, a region will be chosen automatically.
        #     This field is only populated when used in ProcessDocument method.
        # @!attribute [rw] input_config
        #   @return [Google::Cloud::Documentai::V1beta2::InputConfig]
        #     Required. Information about the input file.
        # @!attribute [rw] output_config
        #   @return [Google::Cloud::Documentai::V1beta2::OutputConfig]
        #     Optional. The desired output location. This field is only needed in
        #     BatchProcessDocumentsRequest.
        # @!attribute [rw] document_type
        #   @return [String]
        #     Specifies a known document type for deeper structure detection. Valid
        #     values are currently "general" and "invoice". If not provided, "general"\
        #     is used as default. If any other value is given, the request is rejected.
        # @!attribute [rw] table_extraction_params
        #   @return [Google::Cloud::Documentai::V1beta2::TableExtractionParams]
        #     Controls table extraction behavior. If not specified, the system will
        #     decide reasonable defaults.
        # @!attribute [rw] form_extraction_params
        #   @return [Google::Cloud::Documentai::V1beta2::FormExtractionParams]
        #     Controls form extraction behavior. If not specified, the system will
        #     decide reasonable defaults.
        # @!attribute [rw] entity_extraction_params
        #   @return [Google::Cloud::Documentai::V1beta2::EntityExtractionParams]
        #     Controls entity extraction behavior. If not specified, the system will
        #     decide reasonable defaults.
        # @!attribute [rw] ocr_params
        #   @return [Google::Cloud::Documentai::V1beta2::OcrParams]
        #     Controls OCR behavior. If not specified, the system will decide reasonable
        #     defaults.
        # @!attribute [rw] automl_params
        #   @return [Google::Cloud::Documentai::V1beta2::AutoMlParams]
        #     Controls AutoML model prediction behavior. AutoMlParams cannot be used
        #     together with other Params.
        class ProcessDocumentRequest; end

        # Response to an batch document processing request. This is returned in
        # the LRO Operation after the operation is complete.
        # @!attribute [rw] responses
        #   @return [Array<Google::Cloud::Documentai::V1beta2::ProcessDocumentResponse>]
        #     Responses for each individual document.
        class BatchProcessDocumentsResponse; end

        # Response to a single document processing request.
        # @!attribute [rw] input_config
        #   @return [Google::Cloud::Documentai::V1beta2::InputConfig]
        #     Information about the input file. This is the same as the corresponding
        #     input config in the request.
        # @!attribute [rw] output_config
        #   @return [Google::Cloud::Documentai::V1beta2::OutputConfig]
        #     The output location of the parsed responses. The responses are written to
        #     this location as JSON-serialized `Document` objects.
        class ProcessDocumentResponse; end

        # Parameters to control Optical Character Recognition (OCR) behavior.
        # @!attribute [rw] language_hints
        #   @return [Array<String>]
        #     List of languages to use for OCR. In most cases, an empty value
        #     yields the best results since it enables automatic language detection. For
        #     languages based on the Latin alphabet, setting `language_hints` is not
        #     needed. In rare cases, when the language of the text in the image is known,
        #     setting a hint will help get better results (although it will be a
        #     significant hindrance if the hint is wrong). Document processing returns an
        #     error if one or more of the specified languages is not one of the
        #     supported languages.
        class OcrParams; end

        # Parameters to control table extraction behavior.
        # @!attribute [rw] enabled
        #   @return [true, false]
        #     Whether to enable table extraction.
        # @!attribute [rw] table_bound_hints
        #   @return [Array<Google::Cloud::Documentai::V1beta2::TableBoundHint>]
        #     Optional. Table bounding box hints that can be provided to complex cases
        #     which our algorithm cannot locate the table(s) in.
        # @!attribute [rw] header_hints
        #   @return [Array<String>]
        #     Optional. Table header hints. The extraction will bias towards producing
        #     these terms as table headers, which may improve accuracy.
        # @!attribute [rw] model_version
        #   @return [String]
        #     Model version of the table extraction system. Default is "builtin/stable".
        #     Specify "builtin/latest" for the latest model.
        class TableExtractionParams; end

        # A hint for a table bounding box on the page for table parsing.
        # @!attribute [rw] page_number
        #   @return [Integer]
        #     Optional. Page number for multi-paged inputs this hint applies to. If not
        #     provided, this hint will apply to all pages by default. This value is
        #     1-based.
        # @!attribute [rw] bounding_box
        #   @return [Google::Cloud::Documentai::V1beta2::BoundingPoly]
        #     Bounding box hint for a table on this page. The coordinates must be
        #     normalized to [0,1] and the bounding box must be an axis-aligned rectangle.
        class TableBoundHint; end

        # Parameters to control form extraction behavior.
        # @!attribute [rw] enabled
        #   @return [true, false]
        #     Whether to enable form extraction.
        # @!attribute [rw] key_value_pair_hints
        #   @return [Array<Google::Cloud::Documentai::V1beta2::KeyValuePairHint>]
        #     User can provide pairs of (key text, value type) to improve the parsing
        #     result.
        #
        #     For example, if a document has a field called "Date" that holds a date
        #     value and a field called "Amount" that may hold either a currency value
        #     (e.g., "$500.00") or a simple number value (e.g., "20"), you could use the
        #     following hints: [ {"key": "Date", value_types: [ "DATE"]}, {"key":
        #     "Amount", "value_types": [ "PRICE", "NUMBER" ]} ]
        #
        #     If the value type is unknown, but you want to provide hints for the keys,
        #     you can leave the value_types field blank. e.g. {"key": "Date",
        #     "value_types": []}
        # @!attribute [rw] model_version
        #   @return [String]
        #     Model version of the form extraction system. Default is
        #     "builtin/stable". Specify "builtin/latest" for the latest model.
        #     For custom form models, specify: “custom/{model_name}". Model name
        #     format is "bucket_name/path/to/modeldir" corresponding to
        #     "gs://bucket_name/path/to/modeldir" where annotated examples are stored.
        class FormExtractionParams; end

        # User-provided hint for key value pair.
        # @!attribute [rw] key
        #   @return [String]
        #     The key text for the hint.
        # @!attribute [rw] value_types
        #   @return [Array<String>]
        #     Type of the value. This is case-insensitive, and could be one of:
        #     ADDRESS, LOCATION, ORGANIZATION, PERSON, PHONE_NUMBER,
        #     ID, NUMBER, EMAIL, PRICE, TERMS, DATE, NAME. Types not in this list will
        #     be ignored.
        class KeyValuePairHint; end

        # Parameters to control entity extraction behavior.
        # @!attribute [rw] enabled
        #   @return [true, false]
        #     Whether to enable entity extraction.
        # @!attribute [rw] model_version
        #   @return [String]
        #     Model version of the entity extraction. Default is
        #     "builtin/stable". Specify "builtin/latest" for the latest model.
        class EntityExtractionParams; end

        # Parameters to control AutoML model prediction behavior.
        # @!attribute [rw] model
        #   @return [String]
        #     Resource name of the AutoML model.
        #
        #     Format: `projects/{project-id}/locations/{location-id}/models/{model-id}`.
        class AutoMlParams; end

        # The desired input location and metadata.
        # @!attribute [rw] gcs_source
        #   @return [Google::Cloud::Documentai::V1beta2::GcsSource]
        #     The Google Cloud Storage location to read the input from. This must be a
        #     single file.
        # @!attribute [rw] contents
        #   @return [String]
        #     Content in bytes, represented as a stream of bytes.
        #     Note: As with all `bytes` fields, proto buffer messages use a pure binary
        #     representation, whereas JSON representations use base64.
        #
        #     This field only works for synchronous ProcessDocument method.
        # @!attribute [rw] mime_type
        #   @return [String]
        #     Required. Mimetype of the input. Current supported mimetypes are application/pdf,
        #     image/tiff, and image/gif.
        #     In addition, application/json type is supported for requests with
        #     {Google::Cloud::Documentai::V1beta2::ProcessDocumentRequest#automl_params ProcessDocumentRequest#automl_params} field set. The JSON file needs to
        #     be in {Google::Cloud::Documentai::V1beta2::Document Document} format.
        class InputConfig; end

        # The desired output location and metadata.
        # @!attribute [rw] gcs_destination
        #   @return [Google::Cloud::Documentai::V1beta2::GcsDestination]
        #     The Google Cloud Storage location to write the output to.
        # @!attribute [rw] pages_per_shard
        #   @return [Integer]
        #     The max number of pages to include into each output Document shard JSON on
        #     Google Cloud Storage.
        #
        #     The valid range is [1, 100]. If not specified, the default value is 20.
        #
        #     For example, for one pdf file with 100 pages, 100 parsed pages will be
        #     produced. If `pages_per_shard` = 20, then 5 Document shard JSON files each
        #     containing 20 parsed pages will be written under the prefix
        #     {OutputConfig#gcs_destination#uri} and suffix pages-x-to-y.json where
        #     x and y are 1-indexed page numbers.
        #
        #     Example GCS outputs with 157 pages and pages_per_shard = 50:
        #
        #     <prefix>pages-001-to-050.json
        #     <prefix>pages-051-to-100.json
        #     <prefix>pages-101-to-150.json
        #     <prefix>pages-151-to-157.json
        class OutputConfig; end

        # The Google Cloud Storage location where the input file will be read from.
        # @!attribute [rw] uri
        #   @return [String]
        class GcsSource; end

        # The Google Cloud Storage location where the output file will be written to.
        # @!attribute [rw] uri
        #   @return [String]
        class GcsDestination; end

        # Contains metadata for the BatchProcessDocuments operation.
        # @!attribute [rw] state
        #   @return [Google::Cloud::Documentai::V1beta2::OperationMetadata::State]
        #     The state of the current batch processing.
        # @!attribute [rw] state_message
        #   @return [String]
        #     A message providing more details about the current state of processing.
        # @!attribute [rw] create_time
        #   @return [Google::Protobuf::Timestamp]
        #     The creation time of the operation.
        # @!attribute [rw] update_time
        #   @return [Google::Protobuf::Timestamp]
        #     The last update time of the operation.
        class OperationMetadata
          module State
            # The default value. This value is used if the state is omitted.
            STATE_UNSPECIFIED = 0

            # Request is received.
            ACCEPTED = 1

            # Request operation is waiting for scheduling.
            WAITING = 2

            # Request is being processed.
            RUNNING = 3

            # The batch processing completed successfully.
            SUCCEEDED = 4

            # The batch processing was cancelled.
            CANCELLED = 5

            # The batch processing has failed.
            FAILED = 6
          end
        end
      end
    end
  end
end