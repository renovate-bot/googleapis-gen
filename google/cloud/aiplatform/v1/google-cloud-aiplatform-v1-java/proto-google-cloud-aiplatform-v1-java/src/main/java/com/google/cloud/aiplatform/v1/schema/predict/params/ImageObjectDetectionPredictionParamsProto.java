// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/aiplatform/v1/schema/predict/params/image_object_detection.proto

package com.google.cloud.aiplatform.v1.schema.predict.params;

public final class ImageObjectDetectionPredictionParamsProto {
  private ImageObjectDetectionPredictionParamsProto() {}
  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistryLite registry) {
  }

  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistry registry) {
    registerAllExtensions(
        (com.google.protobuf.ExtensionRegistryLite) registry);
  }
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_aiplatform_v1_schema_predict_params_ImageObjectDetectionPredictionParams_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_aiplatform_v1_schema_predict_params_ImageObjectDetectionPredictionParams_fieldAccessorTable;

  public static com.google.protobuf.Descriptors.FileDescriptor
      getDescriptor() {
    return descriptor;
  }
  private static  com.google.protobuf.Descriptors.FileDescriptor
      descriptor;
  static {
    java.lang.String[] descriptorData = {
      "\nMgoogle/cloud/aiplatform/v1/schema/pred" +
      "ict/params/image_object_detection.proto\022" +
      "0google.cloud.aiplatform.v1.schema.predi" +
      "ct.params\032\034google/api/annotations.proto\"" +
      "]\n$ImageObjectDetectionPredictionParams\022" +
      "\034\n\024confidence_threshold\030\001 \001(\002\022\027\n\017max_pre" +
      "dictions\030\002 \001(\005B\273\001\n4com.google.cloud.aipl" +
      "atform.v1.schema.predict.paramsB)ImageOb" +
      "jectDetectionPredictionParamsProtoP\001ZVgo" +
      "ogle.golang.org/genproto/googleapis/clou" +
      "d/aiplatform/v1/schema/predict/params;pa" +
      "ramsb\006proto3"
    };
    descriptor = com.google.protobuf.Descriptors.FileDescriptor
      .internalBuildGeneratedFileFrom(descriptorData,
        new com.google.protobuf.Descriptors.FileDescriptor[] {
          com.google.api.AnnotationsProto.getDescriptor(),
        });
    internal_static_google_cloud_aiplatform_v1_schema_predict_params_ImageObjectDetectionPredictionParams_descriptor =
      getDescriptor().getMessageTypes().get(0);
    internal_static_google_cloud_aiplatform_v1_schema_predict_params_ImageObjectDetectionPredictionParams_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_aiplatform_v1_schema_predict_params_ImageObjectDetectionPredictionParams_descriptor,
        new java.lang.String[] { "ConfidenceThreshold", "MaxPredictions", });
    com.google.api.AnnotationsProto.getDescriptor();
  }

  // @@protoc_insertion_point(outer_class_scope)
}
