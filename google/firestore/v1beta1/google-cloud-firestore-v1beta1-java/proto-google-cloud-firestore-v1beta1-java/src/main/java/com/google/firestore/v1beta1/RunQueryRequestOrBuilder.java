// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/firestore/v1beta1/firestore.proto

package com.google.firestore.v1beta1;

public interface RunQueryRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.firestore.v1beta1.RunQueryRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. The parent resource name. In the format:
   * `projects/{project_id}/databases/{database_id}/documents` or
   * `projects/{project_id}/databases/{database_id}/documents/{document_path}`.
   * For example:
   * `projects/my-project/databases/my-database/documents` or
   * `projects/my-project/databases/my-database/documents/chatrooms/my-chatroom`
   * </pre>
   *
   * <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The parent.
   */
  java.lang.String getParent();
  /**
   * <pre>
   * Required. The parent resource name. In the format:
   * `projects/{project_id}/databases/{database_id}/documents` or
   * `projects/{project_id}/databases/{database_id}/documents/{document_path}`.
   * For example:
   * `projects/my-project/databases/my-database/documents` or
   * `projects/my-project/databases/my-database/documents/chatrooms/my-chatroom`
   * </pre>
   *
   * <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The bytes for parent.
   */
  com.google.protobuf.ByteString
      getParentBytes();

  /**
   * <pre>
   * A structured query.
   * </pre>
   *
   * <code>.google.firestore.v1beta1.StructuredQuery structured_query = 2;</code>
   * @return Whether the structuredQuery field is set.
   */
  boolean hasStructuredQuery();
  /**
   * <pre>
   * A structured query.
   * </pre>
   *
   * <code>.google.firestore.v1beta1.StructuredQuery structured_query = 2;</code>
   * @return The structuredQuery.
   */
  com.google.firestore.v1beta1.StructuredQuery getStructuredQuery();
  /**
   * <pre>
   * A structured query.
   * </pre>
   *
   * <code>.google.firestore.v1beta1.StructuredQuery structured_query = 2;</code>
   */
  com.google.firestore.v1beta1.StructuredQueryOrBuilder getStructuredQueryOrBuilder();

  /**
   * <pre>
   * Reads documents in a transaction.
   * </pre>
   *
   * <code>bytes transaction = 5;</code>
   * @return Whether the transaction field is set.
   */
  boolean hasTransaction();
  /**
   * <pre>
   * Reads documents in a transaction.
   * </pre>
   *
   * <code>bytes transaction = 5;</code>
   * @return The transaction.
   */
  com.google.protobuf.ByteString getTransaction();

  /**
   * <pre>
   * Starts a new transaction and reads the documents.
   * Defaults to a read-only transaction.
   * The new transaction ID will be returned as the first response in the
   * stream.
   * </pre>
   *
   * <code>.google.firestore.v1beta1.TransactionOptions new_transaction = 6;</code>
   * @return Whether the newTransaction field is set.
   */
  boolean hasNewTransaction();
  /**
   * <pre>
   * Starts a new transaction and reads the documents.
   * Defaults to a read-only transaction.
   * The new transaction ID will be returned as the first response in the
   * stream.
   * </pre>
   *
   * <code>.google.firestore.v1beta1.TransactionOptions new_transaction = 6;</code>
   * @return The newTransaction.
   */
  com.google.firestore.v1beta1.TransactionOptions getNewTransaction();
  /**
   * <pre>
   * Starts a new transaction and reads the documents.
   * Defaults to a read-only transaction.
   * The new transaction ID will be returned as the first response in the
   * stream.
   * </pre>
   *
   * <code>.google.firestore.v1beta1.TransactionOptions new_transaction = 6;</code>
   */
  com.google.firestore.v1beta1.TransactionOptionsOrBuilder getNewTransactionOrBuilder();

  /**
   * <pre>
   * Reads documents as they were at the given time.
   * This may not be older than 270 seconds.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp read_time = 7;</code>
   * @return Whether the readTime field is set.
   */
  boolean hasReadTime();
  /**
   * <pre>
   * Reads documents as they were at the given time.
   * This may not be older than 270 seconds.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp read_time = 7;</code>
   * @return The readTime.
   */
  com.google.protobuf.Timestamp getReadTime();
  /**
   * <pre>
   * Reads documents as they were at the given time.
   * This may not be older than 270 seconds.
   * </pre>
   *
   * <code>.google.protobuf.Timestamp read_time = 7;</code>
   */
  com.google.protobuf.TimestampOrBuilder getReadTimeOrBuilder();

  public com.google.firestore.v1beta1.RunQueryRequest.QueryTypeCase getQueryTypeCase();

  public com.google.firestore.v1beta1.RunQueryRequest.ConsistencySelectorCase getConsistencySelectorCase();
}
