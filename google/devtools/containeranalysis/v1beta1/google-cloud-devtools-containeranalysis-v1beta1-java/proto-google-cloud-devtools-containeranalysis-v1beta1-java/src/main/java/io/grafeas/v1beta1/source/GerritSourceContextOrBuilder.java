// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/devtools/containeranalysis/v1beta1/source/source.proto

package io.grafeas.v1beta1.source;

public interface GerritSourceContextOrBuilder extends
    // @@protoc_insertion_point(interface_extends:grafeas.v1beta1.source.GerritSourceContext)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The URI of a running Gerrit instance.
   * </pre>
   *
   * <code>string host_uri = 1;</code>
   * @return The hostUri.
   */
  java.lang.String getHostUri();
  /**
   * <pre>
   * The URI of a running Gerrit instance.
   * </pre>
   *
   * <code>string host_uri = 1;</code>
   * @return The bytes for hostUri.
   */
  com.google.protobuf.ByteString
      getHostUriBytes();

  /**
   * <pre>
   * The full project name within the host. Projects may be nested, so
   * "project/subproject" is a valid project name. The "repo name" is the
   * hostURI/project.
   * </pre>
   *
   * <code>string gerrit_project = 2;</code>
   * @return The gerritProject.
   */
  java.lang.String getGerritProject();
  /**
   * <pre>
   * The full project name within the host. Projects may be nested, so
   * "project/subproject" is a valid project name. The "repo name" is the
   * hostURI/project.
   * </pre>
   *
   * <code>string gerrit_project = 2;</code>
   * @return The bytes for gerritProject.
   */
  com.google.protobuf.ByteString
      getGerritProjectBytes();

  /**
   * <pre>
   * A revision (commit) ID.
   * </pre>
   *
   * <code>string revision_id = 3;</code>
   * @return Whether the revisionId field is set.
   */
  boolean hasRevisionId();
  /**
   * <pre>
   * A revision (commit) ID.
   * </pre>
   *
   * <code>string revision_id = 3;</code>
   * @return The revisionId.
   */
  java.lang.String getRevisionId();
  /**
   * <pre>
   * A revision (commit) ID.
   * </pre>
   *
   * <code>string revision_id = 3;</code>
   * @return The bytes for revisionId.
   */
  com.google.protobuf.ByteString
      getRevisionIdBytes();

  /**
   * <pre>
   * An alias, which may be a branch or tag.
   * </pre>
   *
   * <code>.grafeas.v1beta1.source.AliasContext alias_context = 4;</code>
   * @return Whether the aliasContext field is set.
   */
  boolean hasAliasContext();
  /**
   * <pre>
   * An alias, which may be a branch or tag.
   * </pre>
   *
   * <code>.grafeas.v1beta1.source.AliasContext alias_context = 4;</code>
   * @return The aliasContext.
   */
  io.grafeas.v1beta1.source.AliasContext getAliasContext();
  /**
   * <pre>
   * An alias, which may be a branch or tag.
   * </pre>
   *
   * <code>.grafeas.v1beta1.source.AliasContext alias_context = 4;</code>
   */
  io.grafeas.v1beta1.source.AliasContextOrBuilder getAliasContextOrBuilder();

  public io.grafeas.v1beta1.source.GerritSourceContext.RevisionCase getRevisionCase();
}
