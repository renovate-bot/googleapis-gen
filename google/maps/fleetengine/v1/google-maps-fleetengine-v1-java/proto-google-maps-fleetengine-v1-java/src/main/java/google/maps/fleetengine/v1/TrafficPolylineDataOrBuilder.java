// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/maps/fleetengine/v1/vehicles.proto

package google.maps.fleetengine.v1;

public interface TrafficPolylineDataOrBuilder extends
    // @@protoc_insertion_point(interface_extends:maps.fleetengine.v1.TrafficPolylineData)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * A polyline rendering of how fast traffic is for all regions along
   * one stretch of a customer ride.
   * </pre>
   *
   * <code>.maps.fleetengine.v1.VisualTrafficReportPolylineRendering traffic_rendering = 1;</code>
   * @return Whether the trafficRendering field is set.
   */
  boolean hasTrafficRendering();
  /**
   * <pre>
   * A polyline rendering of how fast traffic is for all regions along
   * one stretch of a customer ride.
   * </pre>
   *
   * <code>.maps.fleetengine.v1.VisualTrafficReportPolylineRendering traffic_rendering = 1;</code>
   * @return The trafficRendering.
   */
  google.maps.fleetengine.v1.VisualTrafficReportPolylineRendering getTrafficRendering();
  /**
   * <pre>
   * A polyline rendering of how fast traffic is for all regions along
   * one stretch of a customer ride.
   * </pre>
   *
   * <code>.maps.fleetengine.v1.VisualTrafficReportPolylineRendering traffic_rendering = 1;</code>
   */
  google.maps.fleetengine.v1.VisualTrafficReportPolylineRenderingOrBuilder getTrafficRenderingOrBuilder();
}
