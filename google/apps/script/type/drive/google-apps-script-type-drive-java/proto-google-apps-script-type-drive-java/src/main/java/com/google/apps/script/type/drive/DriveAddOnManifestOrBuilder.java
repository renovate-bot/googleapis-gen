// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/apps/script/type/drive/drive_addon_manifest.proto

package com.google.apps.script.type.drive;

public interface DriveAddOnManifestOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.apps.script.type.drive.DriveAddOnManifest)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * If present, this overrides the configuration from
   * `addOns.common.homepageTrigger`.
   * </pre>
   *
   * <code>.google.apps.script.type.HomepageExtensionPoint homepage_trigger = 1;</code>
   * @return Whether the homepageTrigger field is set.
   */
  boolean hasHomepageTrigger();
  /**
   * <pre>
   * If present, this overrides the configuration from
   * `addOns.common.homepageTrigger`.
   * </pre>
   *
   * <code>.google.apps.script.type.HomepageExtensionPoint homepage_trigger = 1;</code>
   * @return The homepageTrigger.
   */
  com.google.apps.script.type.HomepageExtensionPoint getHomepageTrigger();
  /**
   * <pre>
   * If present, this overrides the configuration from
   * `addOns.common.homepageTrigger`.
   * </pre>
   *
   * <code>.google.apps.script.type.HomepageExtensionPoint homepage_trigger = 1;</code>
   */
  com.google.apps.script.type.HomepageExtensionPointOrBuilder getHomepageTriggerOrBuilder();

  /**
   * <pre>
   * Corresponds to behvior that should execute when items are selected
   * in relevant Drive view (e.g. the My Drive Doclist).
   * </pre>
   *
   * <code>.google.apps.script.type.drive.DriveExtensionPoint on_items_selected_trigger = 2;</code>
   * @return Whether the onItemsSelectedTrigger field is set.
   */
  boolean hasOnItemsSelectedTrigger();
  /**
   * <pre>
   * Corresponds to behvior that should execute when items are selected
   * in relevant Drive view (e.g. the My Drive Doclist).
   * </pre>
   *
   * <code>.google.apps.script.type.drive.DriveExtensionPoint on_items_selected_trigger = 2;</code>
   * @return The onItemsSelectedTrigger.
   */
  com.google.apps.script.type.drive.DriveExtensionPoint getOnItemsSelectedTrigger();
  /**
   * <pre>
   * Corresponds to behvior that should execute when items are selected
   * in relevant Drive view (e.g. the My Drive Doclist).
   * </pre>
   *
   * <code>.google.apps.script.type.drive.DriveExtensionPoint on_items_selected_trigger = 2;</code>
   */
  com.google.apps.script.type.drive.DriveExtensionPointOrBuilder getOnItemsSelectedTriggerOrBuilder();
}
