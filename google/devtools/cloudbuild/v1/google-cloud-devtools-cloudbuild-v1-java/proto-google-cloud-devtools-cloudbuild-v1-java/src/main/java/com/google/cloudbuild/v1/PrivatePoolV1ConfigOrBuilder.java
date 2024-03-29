// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/devtools/cloudbuild/v1/cloudbuild.proto

package com.google.cloudbuild.v1;

public interface PrivatePoolV1ConfigOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.devtools.cloudbuild.v1.PrivatePoolV1Config)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Machine configuration for the workers in the pool.
   * </pre>
   *
   * <code>.google.devtools.cloudbuild.v1.PrivatePoolV1Config.WorkerConfig worker_config = 1;</code>
   * @return Whether the workerConfig field is set.
   */
  boolean hasWorkerConfig();
  /**
   * <pre>
   * Machine configuration for the workers in the pool.
   * </pre>
   *
   * <code>.google.devtools.cloudbuild.v1.PrivatePoolV1Config.WorkerConfig worker_config = 1;</code>
   * @return The workerConfig.
   */
  com.google.cloudbuild.v1.PrivatePoolV1Config.WorkerConfig getWorkerConfig();
  /**
   * <pre>
   * Machine configuration for the workers in the pool.
   * </pre>
   *
   * <code>.google.devtools.cloudbuild.v1.PrivatePoolV1Config.WorkerConfig worker_config = 1;</code>
   */
  com.google.cloudbuild.v1.PrivatePoolV1Config.WorkerConfigOrBuilder getWorkerConfigOrBuilder();

  /**
   * <pre>
   * Network configuration for the pool.
   * </pre>
   *
   * <code>.google.devtools.cloudbuild.v1.PrivatePoolV1Config.NetworkConfig network_config = 2;</code>
   * @return Whether the networkConfig field is set.
   */
  boolean hasNetworkConfig();
  /**
   * <pre>
   * Network configuration for the pool.
   * </pre>
   *
   * <code>.google.devtools.cloudbuild.v1.PrivatePoolV1Config.NetworkConfig network_config = 2;</code>
   * @return The networkConfig.
   */
  com.google.cloudbuild.v1.PrivatePoolV1Config.NetworkConfig getNetworkConfig();
  /**
   * <pre>
   * Network configuration for the pool.
   * </pre>
   *
   * <code>.google.devtools.cloudbuild.v1.PrivatePoolV1Config.NetworkConfig network_config = 2;</code>
   */
  com.google.cloudbuild.v1.PrivatePoolV1Config.NetworkConfigOrBuilder getNetworkConfigOrBuilder();
}
