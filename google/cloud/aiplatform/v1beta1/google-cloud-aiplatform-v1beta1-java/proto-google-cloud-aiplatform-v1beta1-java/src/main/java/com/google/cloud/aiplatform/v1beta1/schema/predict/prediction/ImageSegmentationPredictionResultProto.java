// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/aiplatform/v1beta1/schema/predict/prediction/image_segmentation.proto

package com.google.cloud.aiplatform.v1beta1.schema.predict.prediction;

public final class ImageSegmentationPredictionResultProto {
  private ImageSegmentationPredictionResultProto() {}
  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistryLite registry) {
  }

  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistry registry) {
    registerAllExtensions(
        (com.google.protobuf.ExtensionRegistryLite) registry);
  }
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_aiplatform_v1beta1_schema_predict_prediction_ImageSegmentationPredictionResult_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_aiplatform_v1beta1_schema_predict_prediction_ImageSegmentationPredictionResult_fieldAccessorTable;

  public static com.google.protobuf.Descriptors.FileDescriptor
      getDescriptor() {
    return descriptor;
  }
  private static  com.google.protobuf.Descriptors.FileDescriptor
      descriptor;
  static {
    java.lang.String[] descriptorData = {
      "\nRgoogle/cloud/aiplatform/v1beta1/schema" +
      "/predict/prediction/image_segmentation.p" +
      "roto\0229google.cloud.aiplatform.v1beta1.sc" +
      "hema.predict.prediction\032\034google/api/anno" +
      "tations.proto\"S\n!ImageSegmentationPredic" +
      "tionResult\022\025\n\rcategory_mask\030\001 \001(\t\022\027\n\017con" +
      "fidence_mask\030\002 \001(\tB\316\001\n=com.google.cloud." +
      "aiplatform.v1beta1.schema.predict.predic" +
      "tionB&ImageSegmentationPredictionResultP" +
      "rotoP\001Zcgoogle.golang.org/genproto/googl" +
      "eapis/cloud/aiplatform/v1beta1/schema/pr" +
      "edict/prediction;predictionb\006proto3"
    };
    descriptor = com.google.protobuf.Descriptors.FileDescriptor
      .internalBuildGeneratedFileFrom(descriptorData,
        new com.google.protobuf.Descriptors.FileDescriptor[] {
          com.google.api.AnnotationsProto.getDescriptor(),
        });
    internal_static_google_cloud_aiplatform_v1beta1_schema_predict_prediction_ImageSegmentationPredictionResult_descriptor =
      getDescriptor().getMessageTypes().get(0);
    internal_static_google_cloud_aiplatform_v1beta1_schema_predict_prediction_ImageSegmentationPredictionResult_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_aiplatform_v1beta1_schema_predict_prediction_ImageSegmentationPredictionResult_descriptor,
        new java.lang.String[] { "CategoryMask", "ConfidenceMask", });
    com.google.api.AnnotationsProto.getDescriptor();
  }

  // @@protoc_insertion_point(outer_class_scope)
}
