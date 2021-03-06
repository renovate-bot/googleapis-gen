// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/firestore/v1beta1/firestore.proto

package com.google.firestore.v1beta1;

public interface CreateDocumentRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.firestore.v1beta1.CreateDocumentRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. The parent resource. For example:
   * `projects/{project_id}/databases/{database_id}/documents` or
   * `projects/{project_id}/databases/{database_id}/documents/chatrooms/{chatroom_id}`
   * </pre>
   *
   * <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The parent.
   */
  java.lang.String getParent();
  /**
   * <pre>
   * Required. The parent resource. For example:
   * `projects/{project_id}/databases/{database_id}/documents` or
   * `projects/{project_id}/databases/{database_id}/documents/chatrooms/{chatroom_id}`
   * </pre>
   *
   * <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The bytes for parent.
   */
  com.google.protobuf.ByteString
      getParentBytes();

  /**
   * <pre>
   * Required. The collection ID, relative to `parent`, to list. For example: `chatrooms`.
   * </pre>
   *
   * <code>string collection_id = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The collectionId.
   */
  java.lang.String getCollectionId();
  /**
   * <pre>
   * Required. The collection ID, relative to `parent`, to list. For example: `chatrooms`.
   * </pre>
   *
   * <code>string collection_id = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The bytes for collectionId.
   */
  com.google.protobuf.ByteString
      getCollectionIdBytes();

  /**
   * <pre>
   * The client-assigned document ID to use for this document.
   * Optional. If not specified, an ID will be assigned by the service.
   * </pre>
   *
   * <code>string document_id = 3;</code>
   * @return The documentId.
   */
  java.lang.String getDocumentId();
  /**
   * <pre>
   * The client-assigned document ID to use for this document.
   * Optional. If not specified, an ID will be assigned by the service.
   * </pre>
   *
   * <code>string document_id = 3;</code>
   * @return The bytes for documentId.
   */
  com.google.protobuf.ByteString
      getDocumentIdBytes();

  /**
   * <pre>
   * Required. The document to create. `name` must not be set.
   * </pre>
   *
   * <code>.google.firestore.v1beta1.Document document = 4 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return Whether the document field is set.
   */
  boolean hasDocument();
  /**
   * <pre>
   * Required. The document to create. `name` must not be set.
   * </pre>
   *
   * <code>.google.firestore.v1beta1.Document document = 4 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The document.
   */
  com.google.firestore.v1beta1.Document getDocument();
  /**
   * <pre>
   * Required. The document to create. `name` must not be set.
   * </pre>
   *
   * <code>.google.firestore.v1beta1.Document document = 4 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  com.google.firestore.v1beta1.DocumentOrBuilder getDocumentOrBuilder();

  /**
   * <pre>
   * The fields to return. If not set, returns all fields.
   * If the document has a field that is not present in this mask, that field
   * will not be returned in the response.
   * </pre>
   *
   * <code>.google.firestore.v1beta1.DocumentMask mask = 5;</code>
   * @return Whether the mask field is set.
   */
  boolean hasMask();
  /**
   * <pre>
   * The fields to return. If not set, returns all fields.
   * If the document has a field that is not present in this mask, that field
   * will not be returned in the response.
   * </pre>
   *
   * <code>.google.firestore.v1beta1.DocumentMask mask = 5;</code>
   * @return The mask.
   */
  com.google.firestore.v1beta1.DocumentMask getMask();
  /**
   * <pre>
   * The fields to return. If not set, returns all fields.
   * If the document has a field that is not present in this mask, that field
   * will not be returned in the response.
   * </pre>
   *
   * <code>.google.firestore.v1beta1.DocumentMask mask = 5;</code>
   */
  com.google.firestore.v1beta1.DocumentMaskOrBuilder getMaskOrBuilder();
}
