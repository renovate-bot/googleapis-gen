// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/aiplatform/v1beta1/index_endpoint.proto

package com.google.cloud.aiplatform.v1beta1;

public interface IndexPrivateEndpointsOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.aiplatform.v1beta1.IndexPrivateEndpoints)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Output only. The ip address used to send match gRPC requests.
   * </pre>
   *
   * <code>string match_grpc_address = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The matchGrpcAddress.
   */
  java.lang.String getMatchGrpcAddress();
  /**
   * <pre>
   * Output only. The ip address used to send match gRPC requests.
   * </pre>
   *
   * <code>string match_grpc_address = 1 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The bytes for matchGrpcAddress.
   */
  com.google.protobuf.ByteString
      getMatchGrpcAddressBytes();

  /**
   * <pre>
   * Output only. The name of the service attachment resource. Populated if private service
   * connect is enabled.
   * </pre>
   *
   * <code>string service_attachment = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The serviceAttachment.
   */
  java.lang.String getServiceAttachment();
  /**
   * <pre>
   * Output only. The name of the service attachment resource. Populated if private service
   * connect is enabled.
   * </pre>
   *
   * <code>string service_attachment = 2 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The bytes for serviceAttachment.
   */
  com.google.protobuf.ByteString
      getServiceAttachmentBytes();
}
