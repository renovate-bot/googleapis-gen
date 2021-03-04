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
      module V2beta1
        # A knowledge document to be used by a {Google::Cloud::Dialogflow::V2beta1::KnowledgeBase KnowledgeBase}.
        #
        # For more information, see the [knowledge base
        # guide](https://cloud.google.com/dialogflow/docs/how/knowledge-bases).
        #
        # Note: The `projects.agent.knowledgeBases.documents` resource is deprecated;
        # only use `projects.knowledgeBases.documents`.
        # @!attribute [rw] name
        #   @return [String]
        #     Optional. The document resource name.
        #     The name must be empty when creating a document.
        #     Format: `projects/<Project ID>/locations/<Location
        #     ID>/knowledgeBases/<Knowledge Base ID>/documents/<Document ID>`.
        # @!attribute [rw] display_name
        #   @return [String]
        #     Required. The display name of the document. The name must be 1024 bytes or
        #     less; otherwise, the creation request fails.
        # @!attribute [rw] mime_type
        #   @return [String]
        #     Required. The MIME type of this document.
        # @!attribute [rw] knowledge_types
        #   @return [Array<Google::Cloud::Dialogflow::V2beta1::Document::KnowledgeType>]
        #     Required. The knowledge type of document content.
        # @!attribute [rw] content_uri
        #   @return [String]
        #     The URI where the file content is located.
        #
        #     For documents stored in Google Cloud Storage, these URIs must have
        #     the form `gs://<bucket-name>/<object-name>`.
        #
        #     NOTE: External URLs must correspond to public webpages, i.e., they must
        #     be indexed by Google Search. In particular, URLs for showing documents in
        #     Google Cloud Storage (i.e. the URL in your browser) are not supported.
        #     Instead use the `gs://` format URI described above.
        # @!attribute [rw] content
        #   @return [String]
        #     The raw content of the document. This field is only permitted for
        #     EXTRACTIVE_QA and FAQ knowledge types.
        #     Note: This field is in the process of being deprecated, please use
        #     raw_content instead.
        # @!attribute [rw] raw_content
        #   @return [String]
        #     The raw content of the document. This field is only permitted for
        #     EXTRACTIVE_QA and FAQ knowledge types.
        # @!attribute [rw] enable_auto_reload
        #   @return [true, false]
        #     Optional. If true, we try to automatically reload the document every day
        #     (at a time picked by the system). If false or unspecified, we don't try
        #     to automatically reload the document.
        #
        #     Currently you can only enable automatic reload for documents sourced from
        #     a public url, see `source` field for the source types.
        #
        #     Reload status can be tracked in `latest_reload_status`. If a reload
        #     fails, we will keep the document unchanged.
        #
        #     If a reload fails with internal errors, the system will try to reload the
        #     document on the next day.
        #     If a reload fails with non-retriable errors (e.g. PERMISION_DENIED), the
        #     system will not try to reload the document anymore. You need to manually
        #     reload the document successfully by calling `ReloadDocument` and clear the
        #     errors.
        # @!attribute [rw] latest_reload_status
        #   @return [Google::Cloud::Dialogflow::V2beta1::Document::ReloadStatus]
        #     Output only. The time and status of the latest reload.
        #     This reload may have been triggered automatically or manually
        #     and may not have succeeded.
        # @!attribute [rw] metadata
        #   @return [Hash{String => String}]
        #     Optional. Metadata for the document. The metadata supports arbitrary
        #     key-value pairs. Suggested use cases include storing a document's title,
        #     an external URL distinct from the document's content_uri, etc.
        #     The max size of a `key` or a `value` of the metadata is 1024 bytes.
        class Document
          # The status of a reload attempt.
          # @!attribute [rw] time
          #   @return [Google::Protobuf::Timestamp]
          #     Output only. The time of a reload attempt.
          #     This reload may have been triggered automatically or manually and may
          #     not have succeeded.
          # @!attribute [rw] status
          #   @return [Google::Rpc::Status]
          #     Output only. The status of a reload attempt or the initial load.
          class ReloadStatus; end

          # The knowledge type of document content.
          module KnowledgeType
            # The type is unspecified or arbitrary.
            KNOWLEDGE_TYPE_UNSPECIFIED = 0

            # The document content contains question and answer pairs as either HTML or
            # CSV. Typical FAQ HTML formats are parsed accurately, but unusual formats
            # may fail to be parsed.
            #
            # CSV must have questions in the first column and answers in the second,
            # with no header. Because of this explicit format, they are always parsed
            # accurately.
            FAQ = 1

            # Documents for which unstructured text is extracted and used for
            # question answering.
            EXTRACTIVE_QA = 2

            # The entire document content as a whole can be used for query results.
            # Only for Contact Center Solutions on Dialogflow.
            ARTICLE_SUGGESTION = 3

            # The legacy enum for agent-facing smart reply feature.
            SMART_REPLY = 4
          end
        end

        # Request message for {Google::Cloud::Dialogflow::V2beta1::Documents::GetDocument Documents::GetDocument}.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the document to retrieve.
        #     Format `projects/<Project ID>/locations/<Location
        #     ID>/knowledgeBases/<Knowledge Base ID>/documents/<Document ID>`.
        class GetDocumentRequest; end

        # Request message for {Google::Cloud::Dialogflow::V2beta1::Documents::ListDocuments Documents::ListDocuments}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The knowledge base to list all documents for.
        #     Format: `projects/<Project ID>/locations/<Location
        #     ID>/knowledgeBases/<Knowledge Base ID>`.
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     The maximum number of items to return in a single page. By
        #     default 10 and at most 100.
        # @!attribute [rw] page_token
        #   @return [String]
        #     The next_page_token value returned from a previous list request.
        # @!attribute [rw] filter
        #   @return [String]
        #     The filter expression used to filter documents returned by the list method.
        #     The expression has the following syntax:
        #
        #       <field> <operator> <value> [AND <field> <operator> <value>] ...
        #
        #     The following fields and operators are supported:
        #
        #     * knowledge_types with has(:) operator
        #     * display_name with has(:) operator
        #     * state with equals(=) operator
        #
        #     Examples:
        #
        #     * "knowledge_types:FAQ" matches documents with FAQ knowledge type.
        #     * "display_name:customer" matches documents whose display name contains
        #       "customer".
        #     * "state=ACTIVE" matches documents with ACTIVE state.
        #     * "knowledge_types:FAQ AND state=ACTIVE" matches all active FAQ documents.
        #
        #     For more information about filtering, see
        #     [API Filtering](https://aip.dev/160).
        class ListDocumentsRequest; end

        # Response message for {Google::Cloud::Dialogflow::V2beta1::Documents::ListDocuments Documents::ListDocuments}.
        # @!attribute [rw] documents
        #   @return [Array<Google::Cloud::Dialogflow::V2beta1::Document>]
        #     The list of documents.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     Token to retrieve the next page of results, or empty if there are no
        #     more results in the list.
        class ListDocumentsResponse; end

        # Request message for {Google::Cloud::Dialogflow::V2beta1::Documents::CreateDocument Documents::CreateDocument}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The knowledge base to create a document for.
        #     Format: `projects/<Project ID>/locations/<Location
        #     ID>/knowledgeBases/<Knowledge Base ID>`.
        # @!attribute [rw] document
        #   @return [Google::Cloud::Dialogflow::V2beta1::Document]
        #     Required. The document to create.
        # @!attribute [rw] import_gcs_custom_metadata
        #   @return [true, false]
        #     Whether to import custom metadata from Google Cloud Storage.
        #     Only valid when the document source is Google Cloud Storage URI.
        class CreateDocumentRequest; end

        # Request message for {Google::Cloud::Dialogflow::V2beta1::Documents::ImportDocuments Documents::ImportDocuments}.
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The knowledge base to import documents into.
        #     Format: `projects/<Project ID>/locations/<Location
        #     ID>/knowledgeBases/<Knowledge Base ID>`.
        # @!attribute [rw] gcs_source
        #   @return [Google::Cloud::Dialogflow::V2beta1::GcsSources]
        #     The Google Cloud Storage location for the documents.
        #     The path can include a wildcard.
        #
        #     These URIs may have the forms
        #     `gs://<bucket-name>/<object-name>`.
        #     `gs://<bucket-name>/<object-path>/*.<extension>`.
        # @!attribute [rw] document_template
        #   @return [Google::Cloud::Dialogflow::V2beta1::ImportDocumentTemplate]
        #     Required. Document template used for importing all the documents.
        # @!attribute [rw] import_gcs_custom_metadata
        #   @return [true, false]
        #     Whether to import custom metadata from Google Cloud Storage.
        #     Only valid when the document source is Google Cloud Storage URI.
        class ImportDocumentsRequest; end

        # The template used for importing documents.
        # @!attribute [rw] mime_type
        #   @return [String]
        #     Required. The MIME type of the document.
        # @!attribute [rw] knowledge_types
        #   @return [Array<Google::Cloud::Dialogflow::V2beta1::Document::KnowledgeType>]
        #     Required. The knowledge type of document content.
        # @!attribute [rw] metadata
        #   @return [Hash{String => String}]
        #     Metadata for the document. The metadata supports arbitrary
        #     key-value pairs. Suggested use cases include storing a document's title,
        #     an external URL distinct from the document's content_uri, etc.
        #     The max size of a `key` or a `value` of the metadata is 1024 bytes.
        class ImportDocumentTemplate; end

        # Response message for {Google::Cloud::Dialogflow::V2beta1::Documents::ImportDocuments Documents::ImportDocuments}.
        # @!attribute [rw] warnings
        #   @return [Array<Google::Rpc::Status>]
        #     Includes details about skipped documents or any other warnings.
        class ImportDocumentsResponse; end

        # Request message for {Google::Cloud::Dialogflow::V2beta1::Documents::DeleteDocument Documents::DeleteDocument}.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the document to delete.
        #     Format: `projects/<Project ID>/locations/<Location
        #     ID>/knowledgeBases/<Knowledge Base ID>/documents/<Document ID>`.
        class DeleteDocumentRequest; end

        # Request message for {Google::Cloud::Dialogflow::V2beta1::Documents::UpdateDocument Documents::UpdateDocument}.
        # @!attribute [rw] document
        #   @return [Google::Cloud::Dialogflow::V2beta1::Document]
        #     Required. The document to update.
        # @!attribute [rw] update_mask
        #   @return [Google::Protobuf::FieldMask]
        #     Optional. Not specified means `update all`.
        #     Currently, only `display_name` can be updated, an InvalidArgument will be
        #     returned for attempting to update other fields.
        class UpdateDocumentRequest; end

        # Metadata in google::longrunning::Operation for Knowledge operations.
        # @!attribute [rw] state
        #   @return [Google::Cloud::Dialogflow::V2beta1::KnowledgeOperationMetadata::State]
        #     Required. Output only. The current state of this operation.
        class KnowledgeOperationMetadata
          # States of the operation.
          module State
            # State unspecified.
            STATE_UNSPECIFIED = 0

            # The operation has been created.
            PENDING = 1

            # The operation is currently running.
            RUNNING = 2

            # The operation is done, either cancelled or completed.
            DONE = 3
          end
        end

        # Request message for {Google::Cloud::Dialogflow::V2beta1::Documents::ReloadDocument Documents::ReloadDocument}.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The name of the document to reload.
        #     Format: `projects/<Project ID>/locations/<Location
        #     ID>/knowledgeBases/<Knowledge Base ID>/documents/<Document ID>`
        # @!attribute [rw] gcs_source
        #   @return [Google::Cloud::Dialogflow::V2beta1::GcsSource]
        #     The path for a Cloud Storage source file for reloading document content.
        #     If not provided, the Document's existing source will be reloaded.
        # @!attribute [rw] import_gcs_custom_metadata
        #   @return [true, false]
        #     Whether to import custom metadata from Google Cloud Storage.
        #     Only valid when the document source is Google Cloud Storage URI.
        class ReloadDocumentRequest; end
      end
    end
  end
end