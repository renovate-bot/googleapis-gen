// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: grafeas/v1/upgrade.proto

package io.grafeas.v1;

public interface UpgradeDistributionOrBuilder extends
    // @@protoc_insertion_point(interface_extends:grafeas.v1.UpgradeDistribution)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required - The specific operating system this metadata applies to. See
   * https://cpe.mitre.org/specification/.
   * </pre>
   *
   * <code>string cpe_uri = 1;</code>
   * @return The cpeUri.
   */
  java.lang.String getCpeUri();
  /**
   * <pre>
   * Required - The specific operating system this metadata applies to. See
   * https://cpe.mitre.org/specification/.
   * </pre>
   *
   * <code>string cpe_uri = 1;</code>
   * @return The bytes for cpeUri.
   */
  com.google.protobuf.ByteString
      getCpeUriBytes();

  /**
   * <pre>
   * The operating system classification of this Upgrade, as specified by the
   * upstream operating system upgrade feed. For Windows the classification is
   * one of the category_ids listed at
   * https://docs.microsoft.com/en-us/previous-versions/windows/desktop/ff357803(v=vs.85)
   * </pre>
   *
   * <code>string classification = 2;</code>
   * @return The classification.
   */
  java.lang.String getClassification();
  /**
   * <pre>
   * The operating system classification of this Upgrade, as specified by the
   * upstream operating system upgrade feed. For Windows the classification is
   * one of the category_ids listed at
   * https://docs.microsoft.com/en-us/previous-versions/windows/desktop/ff357803(v=vs.85)
   * </pre>
   *
   * <code>string classification = 2;</code>
   * @return The bytes for classification.
   */
  com.google.protobuf.ByteString
      getClassificationBytes();

  /**
   * <pre>
   * The severity as specified by the upstream operating system.
   * </pre>
   *
   * <code>string severity = 3;</code>
   * @return The severity.
   */
  java.lang.String getSeverity();
  /**
   * <pre>
   * The severity as specified by the upstream operating system.
   * </pre>
   *
   * <code>string severity = 3;</code>
   * @return The bytes for severity.
   */
  com.google.protobuf.ByteString
      getSeverityBytes();

  /**
   * <pre>
   * The cve tied to this Upgrade.
   * </pre>
   *
   * <code>repeated string cve = 4;</code>
   * @return A list containing the cve.
   */
  java.util.List<java.lang.String>
      getCveList();
  /**
   * <pre>
   * The cve tied to this Upgrade.
   * </pre>
   *
   * <code>repeated string cve = 4;</code>
   * @return The count of cve.
   */
  int getCveCount();
  /**
   * <pre>
   * The cve tied to this Upgrade.
   * </pre>
   *
   * <code>repeated string cve = 4;</code>
   * @param index The index of the element to return.
   * @return The cve at the given index.
   */
  java.lang.String getCve(int index);
  /**
   * <pre>
   * The cve tied to this Upgrade.
   * </pre>
   *
   * <code>repeated string cve = 4;</code>
   * @param index The index of the value to return.
   * @return The bytes of the cve at the given index.
   */
  com.google.protobuf.ByteString
      getCveBytes(int index);
}
