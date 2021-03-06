// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/bigquery/reservation/v1/reservation.proto

package com.google.cloud.bigquery.reservation.v1;

public interface SplitCapacityCommitmentResponseOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.bigquery.reservation.v1.SplitCapacityCommitmentResponse)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * First capacity commitment, result of a split.
   * </pre>
   *
   * <code>.google.cloud.bigquery.reservation.v1.CapacityCommitment first = 1;</code>
   * @return Whether the first field is set.
   */
  boolean hasFirst();
  /**
   * <pre>
   * First capacity commitment, result of a split.
   * </pre>
   *
   * <code>.google.cloud.bigquery.reservation.v1.CapacityCommitment first = 1;</code>
   * @return The first.
   */
  com.google.cloud.bigquery.reservation.v1.CapacityCommitment getFirst();
  /**
   * <pre>
   * First capacity commitment, result of a split.
   * </pre>
   *
   * <code>.google.cloud.bigquery.reservation.v1.CapacityCommitment first = 1;</code>
   */
  com.google.cloud.bigquery.reservation.v1.CapacityCommitmentOrBuilder getFirstOrBuilder();

  /**
   * <pre>
   * Second capacity commitment, result of a split.
   * </pre>
   *
   * <code>.google.cloud.bigquery.reservation.v1.CapacityCommitment second = 2;</code>
   * @return Whether the second field is set.
   */
  boolean hasSecond();
  /**
   * <pre>
   * Second capacity commitment, result of a split.
   * </pre>
   *
   * <code>.google.cloud.bigquery.reservation.v1.CapacityCommitment second = 2;</code>
   * @return The second.
   */
  com.google.cloud.bigquery.reservation.v1.CapacityCommitment getSecond();
  /**
   * <pre>
   * Second capacity commitment, result of a split.
   * </pre>
   *
   * <code>.google.cloud.bigquery.reservation.v1.CapacityCommitment second = 2;</code>
   */
  com.google.cloud.bigquery.reservation.v1.CapacityCommitmentOrBuilder getSecondOrBuilder();
}
