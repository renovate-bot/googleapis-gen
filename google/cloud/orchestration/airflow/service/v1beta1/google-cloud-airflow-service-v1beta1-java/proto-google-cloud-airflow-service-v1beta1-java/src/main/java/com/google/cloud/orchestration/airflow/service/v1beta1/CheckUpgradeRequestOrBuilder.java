// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/orchestration/airflow/service/v1beta1/environments.proto

package com.google.cloud.orchestration.airflow.service.v1beta1;

public interface CheckUpgradeRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.orchestration.airflow.service.v1beta1.CheckUpgradeRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The resource name of the environment to check upgrade for, in the
   * form:
   * "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
   * </pre>
   *
   * <code>string environment = 1;</code>
   * @return The environment.
   */
  java.lang.String getEnvironment();
  /**
   * <pre>
   * The resource name of the environment to check upgrade for, in the
   * form:
   * "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
   * </pre>
   *
   * <code>string environment = 1;</code>
   * @return The bytes for environment.
   */
  com.google.protobuf.ByteString
      getEnvironmentBytes();

  /**
   * <pre>
   * The version of the software running in the environment.
   * This encapsulates both the version of Cloud Composer functionality and the
   * version of Apache Airflow. It must match the regular expression
   * `composer-([0-9]+&#92;.[0-9]+&#92;.[0-9]+|latest)-airflow-[0-9]+&#92;.[0-9]+(&#92;.[0-9]+.*)?`.
   * When used as input, the server also checks if the provided version is
   * supported and denies the request for an unsupported version.
   * The Cloud Composer portion of the version is a
   * [semantic version](https://semver.org) or `latest`. When the patch version
   * is omitted, the current Cloud Composer patch version is selected.
   * When `latest` is provided instead of an explicit version number,
   * the server replaces `latest` with the current Cloud Composer version
   * and stores that version number in the same field.
   * The portion of the image version that follows `airflow-` is an
   * official Apache Airflow repository
   * [release name](https://github.com/apache/incubator-airflow/releases).
   * See also [Version List]
   * (/composer/docs/concepts/versioning/composer-versions).
   * </pre>
   *
   * <code>string image_version = 2;</code>
   * @return The imageVersion.
   */
  java.lang.String getImageVersion();
  /**
   * <pre>
   * The version of the software running in the environment.
   * This encapsulates both the version of Cloud Composer functionality and the
   * version of Apache Airflow. It must match the regular expression
   * `composer-([0-9]+&#92;.[0-9]+&#92;.[0-9]+|latest)-airflow-[0-9]+&#92;.[0-9]+(&#92;.[0-9]+.*)?`.
   * When used as input, the server also checks if the provided version is
   * supported and denies the request for an unsupported version.
   * The Cloud Composer portion of the version is a
   * [semantic version](https://semver.org) or `latest`. When the patch version
   * is omitted, the current Cloud Composer patch version is selected.
   * When `latest` is provided instead of an explicit version number,
   * the server replaces `latest` with the current Cloud Composer version
   * and stores that version number in the same field.
   * The portion of the image version that follows `airflow-` is an
   * official Apache Airflow repository
   * [release name](https://github.com/apache/incubator-airflow/releases).
   * See also [Version List]
   * (/composer/docs/concepts/versioning/composer-versions).
   * </pre>
   *
   * <code>string image_version = 2;</code>
   * @return The bytes for imageVersion.
   */
  com.google.protobuf.ByteString
      getImageVersionBytes();
}
