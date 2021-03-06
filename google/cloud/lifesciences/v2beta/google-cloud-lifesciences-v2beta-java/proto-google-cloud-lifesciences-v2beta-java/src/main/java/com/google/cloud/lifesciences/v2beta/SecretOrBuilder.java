// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/lifesciences/v2beta/workflows.proto

package com.google.cloud.lifesciences.v2beta;

public interface SecretOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.lifesciences.v2beta.Secret)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The name of the Cloud KMS key that will be used to decrypt the secret
   * value. The VM service account must have the required permissions and
   * authentication scopes to invoke the `decrypt` method on the specified key.
   * </pre>
   *
   * <code>string key_name = 1;</code>
   * @return The keyName.
   */
  java.lang.String getKeyName();
  /**
   * <pre>
   * The name of the Cloud KMS key that will be used to decrypt the secret
   * value. The VM service account must have the required permissions and
   * authentication scopes to invoke the `decrypt` method on the specified key.
   * </pre>
   *
   * <code>string key_name = 1;</code>
   * @return The bytes for keyName.
   */
  com.google.protobuf.ByteString
      getKeyNameBytes();

  /**
   * <pre>
   * The value of the cipherText response from the `encrypt` method. This field
   * is intentionally unaudited.
   * </pre>
   *
   * <code>string cipher_text = 2;</code>
   * @return The cipherText.
   */
  java.lang.String getCipherText();
  /**
   * <pre>
   * The value of the cipherText response from the `encrypt` method. This field
   * is intentionally unaudited.
   * </pre>
   *
   * <code>string cipher_text = 2;</code>
   * @return The bytes for cipherText.
   */
  com.google.protobuf.ByteString
      getCipherTextBytes();
}
