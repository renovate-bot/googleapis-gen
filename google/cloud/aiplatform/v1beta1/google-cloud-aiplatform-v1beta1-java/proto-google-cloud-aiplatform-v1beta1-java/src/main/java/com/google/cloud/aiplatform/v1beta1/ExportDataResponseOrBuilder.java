// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/aiplatform/v1beta1/dataset_service.proto

package com.google.cloud.aiplatform.v1beta1;

public interface ExportDataResponseOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.aiplatform.v1beta1.ExportDataResponse)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * All of the files that are exported in this export operation.
   * </pre>
   *
   * <code>repeated string exported_files = 1;</code>
   * @return A list containing the exportedFiles.
   */
  java.util.List<java.lang.String>
      getExportedFilesList();
  /**
   * <pre>
   * All of the files that are exported in this export operation.
   * </pre>
   *
   * <code>repeated string exported_files = 1;</code>
   * @return The count of exportedFiles.
   */
  int getExportedFilesCount();
  /**
   * <pre>
   * All of the files that are exported in this export operation.
   * </pre>
   *
   * <code>repeated string exported_files = 1;</code>
   * @param index The index of the element to return.
   * @return The exportedFiles at the given index.
   */
  java.lang.String getExportedFiles(int index);
  /**
   * <pre>
   * All of the files that are exported in this export operation.
   * </pre>
   *
   * <code>repeated string exported_files = 1;</code>
   * @param index The index of the value to return.
   * @return The bytes of the exportedFiles at the given index.
   */
  com.google.protobuf.ByteString
      getExportedFilesBytes(int index);
}
