// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/devtools/containeranalysis/v1beta1/source/source.proto

package io.grafeas.v1beta1.source;

public interface AliasContextOrBuilder extends
    // @@protoc_insertion_point(interface_extends:grafeas.v1beta1.source.AliasContext)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The alias kind.
   * </pre>
   *
   * <code>.grafeas.v1beta1.source.AliasContext.Kind kind = 1;</code>
   * @return The enum numeric value on the wire for kind.
   */
  int getKindValue();
  /**
   * <pre>
   * The alias kind.
   * </pre>
   *
   * <code>.grafeas.v1beta1.source.AliasContext.Kind kind = 1;</code>
   * @return The kind.
   */
  io.grafeas.v1beta1.source.AliasContext.Kind getKind();

  /**
   * <pre>
   * The alias name.
   * </pre>
   *
   * <code>string name = 2;</code>
   * @return The name.
   */
  java.lang.String getName();
  /**
   * <pre>
   * The alias name.
   * </pre>
   *
   * <code>string name = 2;</code>
   * @return The bytes for name.
   */
  com.google.protobuf.ByteString
      getNameBytes();
}
