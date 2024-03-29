// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/managedidentities/v1beta1/managed_identities_service.proto

package com.google.cloud.managedidentities.v1beta1;

public interface CreateMicrosoftAdDomainRequestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.managedidentities.v1beta1.CreateMicrosoftAdDomainRequest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Required. The resource project name and location using the form:
   * `projects/{project_id}/locations/global`
   * </pre>
   *
   * <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The parent.
   */
  java.lang.String getParent();
  /**
   * <pre>
   * Required. The resource project name and location using the form:
   * `projects/{project_id}/locations/global`
   * </pre>
   *
   * <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = { ... }</code>
   * @return The bytes for parent.
   */
  com.google.protobuf.ByteString
      getParentBytes();

  /**
   * <pre>
   * Required. A domain name, e.g. mydomain.myorg.com, with the following restrictions:
   *  * Must contain only lowercase letters, numbers, periods and hyphens.
   *  * Must start with a letter.
   *  * Must contain between 2-64 characters.
   *  * Must end with a number or a letter.
   *  * Must not start with period.
   *  * First segment length (mydomain form example above) shouldn't exceed
   *    15 chars.
   *  * The last segment cannot be fully numeric.
   *  * Must be unique within the customer project.
   * </pre>
   *
   * <code>string domain_name = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The domainName.
   */
  java.lang.String getDomainName();
  /**
   * <pre>
   * Required. A domain name, e.g. mydomain.myorg.com, with the following restrictions:
   *  * Must contain only lowercase letters, numbers, periods and hyphens.
   *  * Must start with a letter.
   *  * Must contain between 2-64 characters.
   *  * Must end with a number or a letter.
   *  * Must not start with period.
   *  * First segment length (mydomain form example above) shouldn't exceed
   *    15 chars.
   *  * The last segment cannot be fully numeric.
   *  * Must be unique within the customer project.
   * </pre>
   *
   * <code>string domain_name = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The bytes for domainName.
   */
  com.google.protobuf.ByteString
      getDomainNameBytes();

  /**
   * <pre>
   * Required. A Managed Identity domain resource.
   * </pre>
   *
   * <code>.google.cloud.managedidentities.v1beta1.Domain domain = 3 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return Whether the domain field is set.
   */
  boolean hasDomain();
  /**
   * <pre>
   * Required. A Managed Identity domain resource.
   * </pre>
   *
   * <code>.google.cloud.managedidentities.v1beta1.Domain domain = 3 [(.google.api.field_behavior) = REQUIRED];</code>
   * @return The domain.
   */
  com.google.cloud.managedidentities.v1beta1.Domain getDomain();
  /**
   * <pre>
   * Required. A Managed Identity domain resource.
   * </pre>
   *
   * <code>.google.cloud.managedidentities.v1beta1.Domain domain = 3 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  com.google.cloud.managedidentities.v1beta1.DomainOrBuilder getDomainOrBuilder();
}
