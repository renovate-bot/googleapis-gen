// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/compute/v1/compute.proto

package com.google.cloud.compute.v1;

public interface InterconnectDiagnosticsLinkOpticalPowerOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.compute.v1.InterconnectDiagnosticsLinkOpticalPower)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The status of the current value when compared to the warning and alarm levels for the receiving or transmitting transceiver. Possible states include: - OK: The value has not crossed a warning threshold. - LOW_WARNING: The value has crossed below the low warning threshold. - HIGH_WARNING: The value has crossed above the high warning threshold. - LOW_ALARM: The value has crossed below the low alarm threshold. - HIGH_ALARM: The value has crossed above the high alarm threshold.
   * Check the State enum for the list of possible values.
   * </pre>
   *
   * <code>optional string state = 109757585;</code>
   * @return Whether the state field is set.
   */
  boolean hasState();
  /**
   * <pre>
   * The status of the current value when compared to the warning and alarm levels for the receiving or transmitting transceiver. Possible states include: - OK: The value has not crossed a warning threshold. - LOW_WARNING: The value has crossed below the low warning threshold. - HIGH_WARNING: The value has crossed above the high warning threshold. - LOW_ALARM: The value has crossed below the low alarm threshold. - HIGH_ALARM: The value has crossed above the high alarm threshold.
   * Check the State enum for the list of possible values.
   * </pre>
   *
   * <code>optional string state = 109757585;</code>
   * @return The state.
   */
  java.lang.String getState();
  /**
   * <pre>
   * The status of the current value when compared to the warning and alarm levels for the receiving or transmitting transceiver. Possible states include: - OK: The value has not crossed a warning threshold. - LOW_WARNING: The value has crossed below the low warning threshold. - HIGH_WARNING: The value has crossed above the high warning threshold. - LOW_ALARM: The value has crossed below the low alarm threshold. - HIGH_ALARM: The value has crossed above the high alarm threshold.
   * Check the State enum for the list of possible values.
   * </pre>
   *
   * <code>optional string state = 109757585;</code>
   * @return The bytes for state.
   */
  com.google.protobuf.ByteString
      getStateBytes();

  /**
   * <pre>
   * Value of the current receiving or transmitting optical power, read in dBm. Take a known good optical value, give it a 10% margin and trigger warnings relative to that value. In general, a -7dBm warning and a -11dBm alarm are good optical value estimates for most links.
   * </pre>
   *
   * <code>optional float value = 111972721;</code>
   * @return Whether the value field is set.
   */
  boolean hasValue();
  /**
   * <pre>
   * Value of the current receiving or transmitting optical power, read in dBm. Take a known good optical value, give it a 10% margin and trigger warnings relative to that value. In general, a -7dBm warning and a -11dBm alarm are good optical value estimates for most links.
   * </pre>
   *
   * <code>optional float value = 111972721;</code>
   * @return The value.
   */
  float getValue();
}
