// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/storage/v2/storage.proto

package com.google.storage.v2;

public interface BucketAccessControlOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.storage.v2.BucketAccessControl)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The access permission for the entity.
   * </pre>
   *
   * <code>string role = 1;</code>
   * @return The role.
   */
  java.lang.String getRole();
  /**
   * <pre>
   * The access permission for the entity.
   * </pre>
   *
   * <code>string role = 1;</code>
   * @return The bytes for role.
   */
  com.google.protobuf.ByteString
      getRoleBytes();

  /**
   * <pre>
   * The ID of the access-control entry.
   * </pre>
   *
   * <code>string id = 2;</code>
   * @return The id.
   */
  java.lang.String getId();
  /**
   * <pre>
   * The ID of the access-control entry.
   * </pre>
   *
   * <code>string id = 2;</code>
   * @return The bytes for id.
   */
  com.google.protobuf.ByteString
      getIdBytes();

  /**
   * <pre>
   * The entity holding the permission, in one of the following forms:
   * * `user-{userid}`
   * * `user-{email}`
   * * `group-{groupid}`
   * * `group-{email}`
   * * `domain-{domain}`
   * * `project-{team-projectid}`
   * * `allUsers`
   * * `allAuthenticatedUsers`
   * Examples:
   * * The user `liz&#64;example.com` would be `user-liz&#64;example.com`.
   * * The group `example&#64;googlegroups.com` would be
   * `group-example&#64;googlegroups.com`
   * * All members of the Google Apps for Business domain `example.com` would be
   * `domain-example.com`
   * </pre>
   *
   * <code>string entity = 3;</code>
   * @return The entity.
   */
  java.lang.String getEntity();
  /**
   * <pre>
   * The entity holding the permission, in one of the following forms:
   * * `user-{userid}`
   * * `user-{email}`
   * * `group-{groupid}`
   * * `group-{email}`
   * * `domain-{domain}`
   * * `project-{team-projectid}`
   * * `allUsers`
   * * `allAuthenticatedUsers`
   * Examples:
   * * The user `liz&#64;example.com` would be `user-liz&#64;example.com`.
   * * The group `example&#64;googlegroups.com` would be
   * `group-example&#64;googlegroups.com`
   * * All members of the Google Apps for Business domain `example.com` would be
   * `domain-example.com`
   * </pre>
   *
   * <code>string entity = 3;</code>
   * @return The bytes for entity.
   */
  com.google.protobuf.ByteString
      getEntityBytes();

  /**
   * <pre>
   * The ID for the entity, if any.
   * </pre>
   *
   * <code>string entity_id = 4;</code>
   * @return The entityId.
   */
  java.lang.String getEntityId();
  /**
   * <pre>
   * The ID for the entity, if any.
   * </pre>
   *
   * <code>string entity_id = 4;</code>
   * @return The bytes for entityId.
   */
  com.google.protobuf.ByteString
      getEntityIdBytes();

  /**
   * <pre>
   * The email address associated with the entity, if any.
   * </pre>
   *
   * <code>string email = 5;</code>
   * @return The email.
   */
  java.lang.String getEmail();
  /**
   * <pre>
   * The email address associated with the entity, if any.
   * </pre>
   *
   * <code>string email = 5;</code>
   * @return The bytes for email.
   */
  com.google.protobuf.ByteString
      getEmailBytes();

  /**
   * <pre>
   * The domain associated with the entity, if any.
   * </pre>
   *
   * <code>string domain = 6;</code>
   * @return The domain.
   */
  java.lang.String getDomain();
  /**
   * <pre>
   * The domain associated with the entity, if any.
   * </pre>
   *
   * <code>string domain = 6;</code>
   * @return The bytes for domain.
   */
  com.google.protobuf.ByteString
      getDomainBytes();

  /**
   * <pre>
   * The project team associated with the entity, if any.
   * </pre>
   *
   * <code>.google.storage.v2.ProjectTeam project_team = 7;</code>
   * @return Whether the projectTeam field is set.
   */
  boolean hasProjectTeam();
  /**
   * <pre>
   * The project team associated with the entity, if any.
   * </pre>
   *
   * <code>.google.storage.v2.ProjectTeam project_team = 7;</code>
   * @return The projectTeam.
   */
  com.google.storage.v2.ProjectTeam getProjectTeam();
  /**
   * <pre>
   * The project team associated with the entity, if any.
   * </pre>
   *
   * <code>.google.storage.v2.ProjectTeam project_team = 7;</code>
   */
  com.google.storage.v2.ProjectTeamOrBuilder getProjectTeamOrBuilder();
}
