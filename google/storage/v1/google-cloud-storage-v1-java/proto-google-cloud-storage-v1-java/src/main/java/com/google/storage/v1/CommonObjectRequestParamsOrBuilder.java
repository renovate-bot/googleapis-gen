// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/storage/v1/storage.proto

package com.google.storage.v1;

public interface CommonObjectRequestParamsOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.storage.v1.CommonObjectRequestParams)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Encryption algorithm used with Customer-Supplied Encryption Keys feature.
   * </pre>
   *
   * <code>string encryption_algorithm = 1;</code>
   * @return The encryptionAlgorithm.
   */
  java.lang.String getEncryptionAlgorithm();
  /**
   * <pre>
   * Encryption algorithm used with Customer-Supplied Encryption Keys feature.
   * </pre>
   *
   * <code>string encryption_algorithm = 1;</code>
   * @return The bytes for encryptionAlgorithm.
   */
  com.google.protobuf.ByteString
      getEncryptionAlgorithmBytes();

  /**
   * <pre>
   * Encryption key used with Customer-Supplied Encryption Keys feature.
   * </pre>
   *
   * <code>string encryption_key = 2;</code>
   * @return The encryptionKey.
   */
  java.lang.String getEncryptionKey();
  /**
   * <pre>
   * Encryption key used with Customer-Supplied Encryption Keys feature.
   * </pre>
   *
   * <code>string encryption_key = 2;</code>
   * @return The bytes for encryptionKey.
   */
  com.google.protobuf.ByteString
      getEncryptionKeyBytes();

  /**
   * <pre>
   * SHA256 hash of encryption key used with Customer-Supplied Encryption Keys
   * feature.
   * </pre>
   *
   * <code>string encryption_key_sha256 = 3;</code>
   * @return The encryptionKeySha256.
   */
  java.lang.String getEncryptionKeySha256();
  /**
   * <pre>
   * SHA256 hash of encryption key used with Customer-Supplied Encryption Keys
   * feature.
   * </pre>
   *
   * <code>string encryption_key_sha256 = 3;</code>
   * @return The bytes for encryptionKeySha256.
   */
  com.google.protobuf.ByteString
      getEncryptionKeySha256Bytes();
}
