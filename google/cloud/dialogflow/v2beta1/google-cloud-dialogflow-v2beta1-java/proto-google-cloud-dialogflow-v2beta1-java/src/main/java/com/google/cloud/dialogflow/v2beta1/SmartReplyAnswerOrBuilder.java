// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/dialogflow/v2beta1/participant.proto

package com.google.cloud.dialogflow.v2beta1;

public interface SmartReplyAnswerOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.dialogflow.v2beta1.SmartReplyAnswer)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The content of the reply.
   * </pre>
   *
   * <code>string reply = 1;</code>
   * @return The reply.
   */
  java.lang.String getReply();
  /**
   * <pre>
   * The content of the reply.
   * </pre>
   *
   * <code>string reply = 1;</code>
   * @return The bytes for reply.
   */
  com.google.protobuf.ByteString
      getReplyBytes();

  /**
   * <pre>
   * Smart reply confidence.
   * The system's confidence score that this reply is a good match for
   * this conversation, as a value from 0.0 (completely uncertain) to 1.0
   * (completely certain).
   * </pre>
   *
   * <code>float confidence = 2;</code>
   * @return The confidence.
   */
  float getConfidence();

  /**
   * <pre>
   * The name of answer record, in the format of
   * "projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/answerRecords/&lt;Answer Record
   * ID&gt;"
   * </pre>
   *
   * <code>string answer_record = 3;</code>
   * @return The answerRecord.
   */
  java.lang.String getAnswerRecord();
  /**
   * <pre>
   * The name of answer record, in the format of
   * "projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/answerRecords/&lt;Answer Record
   * ID&gt;"
   * </pre>
   *
   * <code>string answer_record = 3;</code>
   * @return The bytes for answerRecord.
   */
  com.google.protobuf.ByteString
      getAnswerRecordBytes();
}
