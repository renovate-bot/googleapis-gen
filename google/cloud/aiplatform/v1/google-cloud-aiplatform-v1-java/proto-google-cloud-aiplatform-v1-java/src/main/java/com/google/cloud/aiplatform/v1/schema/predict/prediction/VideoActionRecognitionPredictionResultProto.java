// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/aiplatform/v1/schema/predict/prediction/video_action_recognition.proto

package com.google.cloud.aiplatform.v1.schema.predict.prediction;

public final class VideoActionRecognitionPredictionResultProto {
  private VideoActionRecognitionPredictionResultProto() {}
  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistryLite registry) {
  }

  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistry registry) {
    registerAllExtensions(
        (com.google.protobuf.ExtensionRegistryLite) registry);
  }
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_cloud_aiplatform_v1_schema_predict_prediction_VideoActionRecognitionPredictionResult_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_cloud_aiplatform_v1_schema_predict_prediction_VideoActionRecognitionPredictionResult_fieldAccessorTable;

  public static com.google.protobuf.Descriptors.FileDescriptor
      getDescriptor() {
    return descriptor;
  }
  private static  com.google.protobuf.Descriptors.FileDescriptor
      descriptor;
  static {
    java.lang.String[] descriptorData = {
      "\nSgoogle/cloud/aiplatform/v1/schema/pred" +
      "ict/prediction/video_action_recognition." +
      "proto\0224google.cloud.aiplatform.v1.schema" +
      ".predict.prediction\032\036google/protobuf/dur" +
      "ation.proto\032\036google/protobuf/wrappers.pr" +
      "oto\032\034google/api/annotations.proto\"\347\001\n&Vi" +
      "deoActionRecognitionPredictionResult\022\n\n\002" +
      "id\030\001 \001(\t\022\024\n\014display_name\030\002 \001(\t\0225\n\022time_s" +
      "egment_start\030\004 \001(\0132\031.google.protobuf.Dur" +
      "ation\0223\n\020time_segment_end\030\005 \001(\0132\031.google" +
      ".protobuf.Duration\022/\n\nconfidence\030\006 \001(\0132\033" +
      ".google.protobuf.FloatValueB\364\002\n8com.goog" +
      "le.cloud.aiplatform.v1.schema.predict.pr" +
      "edictionB+VideoActionRecognitionPredicti" +
      "onResultProtoP\001Z^google.golang.org/genpr" +
      "oto/googleapis/cloud/aiplatform/v1/schem" +
      "a/predict/prediction;prediction\252\0024Google" +
      ".Cloud.AIPlatform.V1.Schema.Predict.Pred" +
      "iction\312\0024Google\\Cloud\\AIPlatform\\V1\\Sche" +
      "ma\\Predict\\Prediction\352\002:Google::Cloud::A" +
      "IPlatform::V1::Schema::Predict::Predicti" +
      "onb\006proto3"
    };
    descriptor = com.google.protobuf.Descriptors.FileDescriptor
      .internalBuildGeneratedFileFrom(descriptorData,
        new com.google.protobuf.Descriptors.FileDescriptor[] {
          com.google.protobuf.DurationProto.getDescriptor(),
          com.google.protobuf.WrappersProto.getDescriptor(),
          com.google.api.AnnotationsProto.getDescriptor(),
        });
    internal_static_google_cloud_aiplatform_v1_schema_predict_prediction_VideoActionRecognitionPredictionResult_descriptor =
      getDescriptor().getMessageTypes().get(0);
    internal_static_google_cloud_aiplatform_v1_schema_predict_prediction_VideoActionRecognitionPredictionResult_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_cloud_aiplatform_v1_schema_predict_prediction_VideoActionRecognitionPredictionResult_descriptor,
        new java.lang.String[] { "Id", "DisplayName", "TimeSegmentStart", "TimeSegmentEnd", "Confidence", });
    com.google.protobuf.DurationProto.getDescriptor();
    com.google.protobuf.WrappersProto.getDescriptor();
    com.google.api.AnnotationsProto.getDescriptor();
  }

  // @@protoc_insertion_point(outer_class_scope)
}
