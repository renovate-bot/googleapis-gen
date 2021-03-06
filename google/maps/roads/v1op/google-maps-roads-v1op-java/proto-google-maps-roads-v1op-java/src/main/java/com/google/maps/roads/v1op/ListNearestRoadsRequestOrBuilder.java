// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/maps/roads/v1op/roads.proto

package com.google.maps.roads.v1op;

public interface ListNearestRoadsRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.maps.roads.v1op.ListNearestRoadsRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The points to be snapped as a series of lat, lng points. Specified as
   * a string of the format: lat,lng|lat,lng|...
   * </pre>
   *
   * <code>string points = 1;</code>
   * @return The points.
   */
  java.lang.String getPoints();
  /**
   * <pre>
   * The points to be snapped as a series of lat, lng points. Specified as
   * a string of the format: lat,lng|lat,lng|...
   * </pre>
   *
   * <code>string points = 1;</code>
   * @return The bytes for points.
   */
  com.google.protobuf.ByteString
      getPointsBytes();

  /**
   * <pre>
   * The type of travel being tracked. This will constrain the roads we snap to.
   * </pre>
   *
   * <code>.google.maps.roads.v1op.TravelMode travel_mode = 2;</code>
   * @return The enum numeric value on the wire for travelMode.
   */
  int getTravelModeValue();
  /**
   * <pre>
   * The type of travel being tracked. This will constrain the roads we snap to.
   * </pre>
   *
   * <code>.google.maps.roads.v1op.TravelMode travel_mode = 2;</code>
   * @return The travelMode.
   */
  com.google.maps.roads.v1op.TravelMode getTravelMode();
}
