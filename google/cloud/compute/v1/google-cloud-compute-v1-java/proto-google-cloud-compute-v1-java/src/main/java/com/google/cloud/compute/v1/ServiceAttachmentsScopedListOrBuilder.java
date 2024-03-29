// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/compute/v1/compute.proto

package com.google.cloud.compute.v1;

public interface ServiceAttachmentsScopedListOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.compute.v1.ServiceAttachmentsScopedList)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * A list of ServiceAttachments contained in this scope.
   * </pre>
   *
   * <code>repeated .google.cloud.compute.v1.ServiceAttachment service_attachments = 307136806;</code>
   */
  java.util.List<com.google.cloud.compute.v1.ServiceAttachment> 
      getServiceAttachmentsList();
  /**
   * <pre>
   * A list of ServiceAttachments contained in this scope.
   * </pre>
   *
   * <code>repeated .google.cloud.compute.v1.ServiceAttachment service_attachments = 307136806;</code>
   */
  com.google.cloud.compute.v1.ServiceAttachment getServiceAttachments(int index);
  /**
   * <pre>
   * A list of ServiceAttachments contained in this scope.
   * </pre>
   *
   * <code>repeated .google.cloud.compute.v1.ServiceAttachment service_attachments = 307136806;</code>
   */
  int getServiceAttachmentsCount();
  /**
   * <pre>
   * A list of ServiceAttachments contained in this scope.
   * </pre>
   *
   * <code>repeated .google.cloud.compute.v1.ServiceAttachment service_attachments = 307136806;</code>
   */
  java.util.List<? extends com.google.cloud.compute.v1.ServiceAttachmentOrBuilder> 
      getServiceAttachmentsOrBuilderList();
  /**
   * <pre>
   * A list of ServiceAttachments contained in this scope.
   * </pre>
   *
   * <code>repeated .google.cloud.compute.v1.ServiceAttachment service_attachments = 307136806;</code>
   */
  com.google.cloud.compute.v1.ServiceAttachmentOrBuilder getServiceAttachmentsOrBuilder(
      int index);

  /**
   * <pre>
   * Informational warning which replaces the list of service attachments when the list is empty.
   * </pre>
   *
   * <code>optional .google.cloud.compute.v1.Warning warning = 50704284;</code>
   * @return Whether the warning field is set.
   */
  boolean hasWarning();
  /**
   * <pre>
   * Informational warning which replaces the list of service attachments when the list is empty.
   * </pre>
   *
   * <code>optional .google.cloud.compute.v1.Warning warning = 50704284;</code>
   * @return The warning.
   */
  com.google.cloud.compute.v1.Warning getWarning();
  /**
   * <pre>
   * Informational warning which replaces the list of service attachments when the list is empty.
   * </pre>
   *
   * <code>optional .google.cloud.compute.v1.Warning warning = 50704284;</code>
   */
  com.google.cloud.compute.v1.WarningOrBuilder getWarningOrBuilder();
}
