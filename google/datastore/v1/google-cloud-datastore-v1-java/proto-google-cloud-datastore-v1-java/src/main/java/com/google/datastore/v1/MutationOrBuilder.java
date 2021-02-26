// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/datastore/v1/datastore.proto

package com.google.datastore.v1;

public interface MutationOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.datastore.v1.Mutation)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The entity to insert. The entity must not already exist.
   * The entity key's final path element may be incomplete.
   * </pre>
   *
   * <code>.google.datastore.v1.Entity insert = 4;</code>
   * @return Whether the insert field is set.
   */
  boolean hasInsert();
  /**
   * <pre>
   * The entity to insert. The entity must not already exist.
   * The entity key's final path element may be incomplete.
   * </pre>
   *
   * <code>.google.datastore.v1.Entity insert = 4;</code>
   * @return The insert.
   */
  com.google.datastore.v1.Entity getInsert();
  /**
   * <pre>
   * The entity to insert. The entity must not already exist.
   * The entity key's final path element may be incomplete.
   * </pre>
   *
   * <code>.google.datastore.v1.Entity insert = 4;</code>
   */
  com.google.datastore.v1.EntityOrBuilder getInsertOrBuilder();

  /**
   * <pre>
   * The entity to update. The entity must already exist.
   * Must have a complete key path.
   * </pre>
   *
   * <code>.google.datastore.v1.Entity update = 5;</code>
   * @return Whether the update field is set.
   */
  boolean hasUpdate();
  /**
   * <pre>
   * The entity to update. The entity must already exist.
   * Must have a complete key path.
   * </pre>
   *
   * <code>.google.datastore.v1.Entity update = 5;</code>
   * @return The update.
   */
  com.google.datastore.v1.Entity getUpdate();
  /**
   * <pre>
   * The entity to update. The entity must already exist.
   * Must have a complete key path.
   * </pre>
   *
   * <code>.google.datastore.v1.Entity update = 5;</code>
   */
  com.google.datastore.v1.EntityOrBuilder getUpdateOrBuilder();

  /**
   * <pre>
   * The entity to upsert. The entity may or may not already exist.
   * The entity key's final path element may be incomplete.
   * </pre>
   *
   * <code>.google.datastore.v1.Entity upsert = 6;</code>
   * @return Whether the upsert field is set.
   */
  boolean hasUpsert();
  /**
   * <pre>
   * The entity to upsert. The entity may or may not already exist.
   * The entity key's final path element may be incomplete.
   * </pre>
   *
   * <code>.google.datastore.v1.Entity upsert = 6;</code>
   * @return The upsert.
   */
  com.google.datastore.v1.Entity getUpsert();
  /**
   * <pre>
   * The entity to upsert. The entity may or may not already exist.
   * The entity key's final path element may be incomplete.
   * </pre>
   *
   * <code>.google.datastore.v1.Entity upsert = 6;</code>
   */
  com.google.datastore.v1.EntityOrBuilder getUpsertOrBuilder();

  /**
   * <pre>
   * The key of the entity to delete. The entity may or may not already exist.
   * Must have a complete key path and must not be reserved/read-only.
   * </pre>
   *
   * <code>.google.datastore.v1.Key delete = 7;</code>
   * @return Whether the delete field is set.
   */
  boolean hasDelete();
  /**
   * <pre>
   * The key of the entity to delete. The entity may or may not already exist.
   * Must have a complete key path and must not be reserved/read-only.
   * </pre>
   *
   * <code>.google.datastore.v1.Key delete = 7;</code>
   * @return The delete.
   */
  com.google.datastore.v1.Key getDelete();
  /**
   * <pre>
   * The key of the entity to delete. The entity may or may not already exist.
   * Must have a complete key path and must not be reserved/read-only.
   * </pre>
   *
   * <code>.google.datastore.v1.Key delete = 7;</code>
   */
  com.google.datastore.v1.KeyOrBuilder getDeleteOrBuilder();

  /**
   * <pre>
   * The version of the entity that this mutation is being applied to. If this
   * does not match the current version on the server, the mutation conflicts.
   * </pre>
   *
   * <code>int64 base_version = 8;</code>
   * @return Whether the baseVersion field is set.
   */
  boolean hasBaseVersion();
  /**
   * <pre>
   * The version of the entity that this mutation is being applied to. If this
   * does not match the current version on the server, the mutation conflicts.
   * </pre>
   *
   * <code>int64 base_version = 8;</code>
   * @return The baseVersion.
   */
  long getBaseVersion();

  public com.google.datastore.v1.Mutation.OperationCase getOperationCase();

  public com.google.datastore.v1.Mutation.ConflictDetectionStrategyCase getConflictDetectionStrategyCase();
}
