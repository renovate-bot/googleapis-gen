// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/devtools/cloudbuild/v1/cloudbuild.proto

package com.google.cloudbuild.v1;

public interface RepoSourceOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.devtools.cloudbuild.v1.RepoSource)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * ID of the project that owns the Cloud Source Repository. If omitted, the
   * project ID requesting the build is assumed.
   * </pre>
   *
   * <code>string project_id = 1;</code>
   * @return The projectId.
   */
  java.lang.String getProjectId();
  /**
   * <pre>
   * ID of the project that owns the Cloud Source Repository. If omitted, the
   * project ID requesting the build is assumed.
   * </pre>
   *
   * <code>string project_id = 1;</code>
   * @return The bytes for projectId.
   */
  com.google.protobuf.ByteString
      getProjectIdBytes();

  /**
   * <pre>
   * Name of the Cloud Source Repository.
   * </pre>
   *
   * <code>string repo_name = 2;</code>
   * @return The repoName.
   */
  java.lang.String getRepoName();
  /**
   * <pre>
   * Name of the Cloud Source Repository.
   * </pre>
   *
   * <code>string repo_name = 2;</code>
   * @return The bytes for repoName.
   */
  com.google.protobuf.ByteString
      getRepoNameBytes();

  /**
   * <pre>
   * Regex matching branches to build.
   * The syntax of the regular expressions accepted is the syntax accepted by
   * RE2 and described at https://github.com/google/re2/wiki/Syntax
   * </pre>
   *
   * <code>string branch_name = 3;</code>
   * @return Whether the branchName field is set.
   */
  boolean hasBranchName();
  /**
   * <pre>
   * Regex matching branches to build.
   * The syntax of the regular expressions accepted is the syntax accepted by
   * RE2 and described at https://github.com/google/re2/wiki/Syntax
   * </pre>
   *
   * <code>string branch_name = 3;</code>
   * @return The branchName.
   */
  java.lang.String getBranchName();
  /**
   * <pre>
   * Regex matching branches to build.
   * The syntax of the regular expressions accepted is the syntax accepted by
   * RE2 and described at https://github.com/google/re2/wiki/Syntax
   * </pre>
   *
   * <code>string branch_name = 3;</code>
   * @return The bytes for branchName.
   */
  com.google.protobuf.ByteString
      getBranchNameBytes();

  /**
   * <pre>
   * Regex matching tags to build.
   * The syntax of the regular expressions accepted is the syntax accepted by
   * RE2 and described at https://github.com/google/re2/wiki/Syntax
   * </pre>
   *
   * <code>string tag_name = 4;</code>
   * @return Whether the tagName field is set.
   */
  boolean hasTagName();
  /**
   * <pre>
   * Regex matching tags to build.
   * The syntax of the regular expressions accepted is the syntax accepted by
   * RE2 and described at https://github.com/google/re2/wiki/Syntax
   * </pre>
   *
   * <code>string tag_name = 4;</code>
   * @return The tagName.
   */
  java.lang.String getTagName();
  /**
   * <pre>
   * Regex matching tags to build.
   * The syntax of the regular expressions accepted is the syntax accepted by
   * RE2 and described at https://github.com/google/re2/wiki/Syntax
   * </pre>
   *
   * <code>string tag_name = 4;</code>
   * @return The bytes for tagName.
   */
  com.google.protobuf.ByteString
      getTagNameBytes();

  /**
   * <pre>
   * Explicit commit SHA to build.
   * </pre>
   *
   * <code>string commit_sha = 5;</code>
   * @return Whether the commitSha field is set.
   */
  boolean hasCommitSha();
  /**
   * <pre>
   * Explicit commit SHA to build.
   * </pre>
   *
   * <code>string commit_sha = 5;</code>
   * @return The commitSha.
   */
  java.lang.String getCommitSha();
  /**
   * <pre>
   * Explicit commit SHA to build.
   * </pre>
   *
   * <code>string commit_sha = 5;</code>
   * @return The bytes for commitSha.
   */
  com.google.protobuf.ByteString
      getCommitShaBytes();

  /**
   * <pre>
   * Directory, relative to the source root, in which to run the build.
   * This must be a relative path. If a step's `dir` is specified and is an
   * absolute path, this value is ignored for that step's execution.
   * </pre>
   *
   * <code>string dir = 7;</code>
   * @return The dir.
   */
  java.lang.String getDir();
  /**
   * <pre>
   * Directory, relative to the source root, in which to run the build.
   * This must be a relative path. If a step's `dir` is specified and is an
   * absolute path, this value is ignored for that step's execution.
   * </pre>
   *
   * <code>string dir = 7;</code>
   * @return The bytes for dir.
   */
  com.google.protobuf.ByteString
      getDirBytes();

  /**
   * <pre>
   * Only trigger a build if the revision regex does NOT match the revision
   * regex.
   * </pre>
   *
   * <code>bool invert_regex = 8;</code>
   * @return The invertRegex.
   */
  boolean getInvertRegex();

  /**
   * <pre>
   * Substitutions to use in a triggered build.
   * Should only be used with RunBuildTrigger
   * </pre>
   *
   * <code>map&lt;string, string&gt; substitutions = 9;</code>
   */
  int getSubstitutionsCount();
  /**
   * <pre>
   * Substitutions to use in a triggered build.
   * Should only be used with RunBuildTrigger
   * </pre>
   *
   * <code>map&lt;string, string&gt; substitutions = 9;</code>
   */
  boolean containsSubstitutions(
      java.lang.String key);
  /**
   * Use {@link #getSubstitutionsMap()} instead.
   */
  @java.lang.Deprecated
  java.util.Map<java.lang.String, java.lang.String>
  getSubstitutions();
  /**
   * <pre>
   * Substitutions to use in a triggered build.
   * Should only be used with RunBuildTrigger
   * </pre>
   *
   * <code>map&lt;string, string&gt; substitutions = 9;</code>
   */
  java.util.Map<java.lang.String, java.lang.String>
  getSubstitutionsMap();
  /**
   * <pre>
   * Substitutions to use in a triggered build.
   * Should only be used with RunBuildTrigger
   * </pre>
   *
   * <code>map&lt;string, string&gt; substitutions = 9;</code>
   */

  java.lang.String getSubstitutionsOrDefault(
      java.lang.String key,
      java.lang.String defaultValue);
  /**
   * <pre>
   * Substitutions to use in a triggered build.
   * Should only be used with RunBuildTrigger
   * </pre>
   *
   * <code>map&lt;string, string&gt; substitutions = 9;</code>
   */

  java.lang.String getSubstitutionsOrThrow(
      java.lang.String key);

  public com.google.cloudbuild.v1.RepoSource.RevisionCase getRevisionCase();
}
