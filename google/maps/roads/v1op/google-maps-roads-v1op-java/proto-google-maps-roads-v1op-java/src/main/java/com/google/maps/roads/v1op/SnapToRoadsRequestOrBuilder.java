// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/maps/roads/v1op/roads.proto

package com.google.maps.roads.v1op;

public interface SnapToRoadsRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.maps.roads.v1op.SnapToRoadsRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The path to be snapped as a series of lat, lng points. Specified as
   * a string of the format: lat,lng|lat,lng|...
   * </pre>
   *
   * <code>string path = 1;</code>
   * @return The path.
   */
  java.lang.String getPath();
  /**
   * <pre>
   * The path to be snapped as a series of lat, lng points. Specified as
   * a string of the format: lat,lng|lat,lng|...
   * </pre>
   *
   * <code>string path = 1;</code>
   * @return The bytes for path.
   */
  com.google.protobuf.ByteString
      getPathBytes();

  /**
   * <pre>
   * Whether to interpolate the points to return full road geometry.
   * </pre>
   *
   * <code>bool interpolate = 2;</code>
   * @return The interpolate.
   */
  boolean getInterpolate();

  /**
   * <pre>
   * The asset ID of the asset to which this path relates. This is used for
   * abuse detection purposes for clients with asset-based SKUs.
   * </pre>
   *
   * <code>string asset_id = 3;</code>
   * @return The assetId.
   */
  java.lang.String getAssetId();
  /**
   * <pre>
   * The asset ID of the asset to which this path relates. This is used for
   * abuse detection purposes for clients with asset-based SKUs.
   * </pre>
   *
   * <code>string asset_id = 3;</code>
   * @return The bytes for assetId.
   */
  com.google.protobuf.ByteString
      getAssetIdBytes();

  /**
   * <pre>
   * The type of travel being tracked. This will constrain the paths we snap to.
   * </pre>
   *
   * <code>.google.maps.roads.v1op.TravelMode travel_mode = 4;</code>
   * @return The enum numeric value on the wire for travelMode.
   */
  int getTravelModeValue();
  /**
   * <pre>
   * The type of travel being tracked. This will constrain the paths we snap to.
   * </pre>
   *
   * <code>.google.maps.roads.v1op.TravelMode travel_mode = 4;</code>
   * @return The travelMode.
   */
  com.google.maps.roads.v1op.TravelMode getTravelMode();
}
