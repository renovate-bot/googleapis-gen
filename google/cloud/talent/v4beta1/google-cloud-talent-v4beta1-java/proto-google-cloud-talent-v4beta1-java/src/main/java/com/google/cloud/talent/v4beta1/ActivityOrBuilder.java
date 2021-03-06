// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/talent/v4beta1/profile.proto

package com.google.cloud.talent.v4beta1;

public interface ActivityOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.talent.v4beta1.Activity)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * Activity display name.
   * Number of characters allowed is 100.
   * </pre>
   *
   * <code>string display_name = 1;</code>
   * @return The displayName.
   */
  java.lang.String getDisplayName();
  /**
   * <pre>
   * Activity display name.
   * Number of characters allowed is 100.
   * </pre>
   *
   * <code>string display_name = 1;</code>
   * @return The bytes for displayName.
   */
  com.google.protobuf.ByteString
      getDisplayNameBytes();

  /**
   * <pre>
   * Activity description.
   * Number of characters allowed is 100,000.
   * </pre>
   *
   * <code>string description = 2;</code>
   * @return The description.
   */
  java.lang.String getDescription();
  /**
   * <pre>
   * Activity description.
   * Number of characters allowed is 100,000.
   * </pre>
   *
   * <code>string description = 2;</code>
   * @return The bytes for description.
   */
  com.google.protobuf.ByteString
      getDescriptionBytes();

  /**
   * <pre>
   * Activity URI.
   * Number of characters allowed is 4,000.
   * </pre>
   *
   * <code>string uri = 3;</code>
   * @return The uri.
   */
  java.lang.String getUri();
  /**
   * <pre>
   * Activity URI.
   * Number of characters allowed is 4,000.
   * </pre>
   *
   * <code>string uri = 3;</code>
   * @return The bytes for uri.
   */
  com.google.protobuf.ByteString
      getUriBytes();

  /**
   * <pre>
   * The first creation date of the activity.
   * </pre>
   *
   * <code>.google.type.Date create_date = 4;</code>
   * @return Whether the createDate field is set.
   */
  boolean hasCreateDate();
  /**
   * <pre>
   * The first creation date of the activity.
   * </pre>
   *
   * <code>.google.type.Date create_date = 4;</code>
   * @return The createDate.
   */
  com.google.type.Date getCreateDate();
  /**
   * <pre>
   * The first creation date of the activity.
   * </pre>
   *
   * <code>.google.type.Date create_date = 4;</code>
   */
  com.google.type.DateOrBuilder getCreateDateOrBuilder();

  /**
   * <pre>
   * The last update date of the activity.
   * </pre>
   *
   * <code>.google.type.Date update_date = 5;</code>
   * @return Whether the updateDate field is set.
   */
  boolean hasUpdateDate();
  /**
   * <pre>
   * The last update date of the activity.
   * </pre>
   *
   * <code>.google.type.Date update_date = 5;</code>
   * @return The updateDate.
   */
  com.google.type.Date getUpdateDate();
  /**
   * <pre>
   * The last update date of the activity.
   * </pre>
   *
   * <code>.google.type.Date update_date = 5;</code>
   */
  com.google.type.DateOrBuilder getUpdateDateOrBuilder();

  /**
   * <pre>
   * A list of team members involved in this activity.
   * Number of characters allowed is 100.
   * The limitation for max number of team members is 50.
   * </pre>
   *
   * <code>repeated string team_members = 6;</code>
   * @return A list containing the teamMembers.
   */
  java.util.List<java.lang.String>
      getTeamMembersList();
  /**
   * <pre>
   * A list of team members involved in this activity.
   * Number of characters allowed is 100.
   * The limitation for max number of team members is 50.
   * </pre>
   *
   * <code>repeated string team_members = 6;</code>
   * @return The count of teamMembers.
   */
  int getTeamMembersCount();
  /**
   * <pre>
   * A list of team members involved in this activity.
   * Number of characters allowed is 100.
   * The limitation for max number of team members is 50.
   * </pre>
   *
   * <code>repeated string team_members = 6;</code>
   * @param index The index of the element to return.
   * @return The teamMembers at the given index.
   */
  java.lang.String getTeamMembers(int index);
  /**
   * <pre>
   * A list of team members involved in this activity.
   * Number of characters allowed is 100.
   * The limitation for max number of team members is 50.
   * </pre>
   *
   * <code>repeated string team_members = 6;</code>
   * @param index The index of the value to return.
   * @return The bytes of the teamMembers at the given index.
   */
  com.google.protobuf.ByteString
      getTeamMembersBytes(int index);

  /**
   * <pre>
   * A list of skills used in this activity.
   * The limitation for max number of skills used is 50.
   * </pre>
   *
   * <code>repeated .google.cloud.talent.v4beta1.Skill skills_used = 7;</code>
   */
  java.util.List<com.google.cloud.talent.v4beta1.Skill> 
      getSkillsUsedList();
  /**
   * <pre>
   * A list of skills used in this activity.
   * The limitation for max number of skills used is 50.
   * </pre>
   *
   * <code>repeated .google.cloud.talent.v4beta1.Skill skills_used = 7;</code>
   */
  com.google.cloud.talent.v4beta1.Skill getSkillsUsed(int index);
  /**
   * <pre>
   * A list of skills used in this activity.
   * The limitation for max number of skills used is 50.
   * </pre>
   *
   * <code>repeated .google.cloud.talent.v4beta1.Skill skills_used = 7;</code>
   */
  int getSkillsUsedCount();
  /**
   * <pre>
   * A list of skills used in this activity.
   * The limitation for max number of skills used is 50.
   * </pre>
   *
   * <code>repeated .google.cloud.talent.v4beta1.Skill skills_used = 7;</code>
   */
  java.util.List<? extends com.google.cloud.talent.v4beta1.SkillOrBuilder> 
      getSkillsUsedOrBuilderList();
  /**
   * <pre>
   * A list of skills used in this activity.
   * The limitation for max number of skills used is 50.
   * </pre>
   *
   * <code>repeated .google.cloud.talent.v4beta1.Skill skills_used = 7;</code>
   */
  com.google.cloud.talent.v4beta1.SkillOrBuilder getSkillsUsedOrBuilder(
      int index);

  /**
   * <pre>
   * Output only. Activity name snippet shows how the [display_name][google.cloud.talent.v4beta1.Activity.display_name] is related to a search
   * query. It's empty if the [display_name][google.cloud.talent.v4beta1.Activity.display_name] isn't related to the search
   * query.
   * </pre>
   *
   * <code>string activity_name_snippet = 8 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The activityNameSnippet.
   */
  java.lang.String getActivityNameSnippet();
  /**
   * <pre>
   * Output only. Activity name snippet shows how the [display_name][google.cloud.talent.v4beta1.Activity.display_name] is related to a search
   * query. It's empty if the [display_name][google.cloud.talent.v4beta1.Activity.display_name] isn't related to the search
   * query.
   * </pre>
   *
   * <code>string activity_name_snippet = 8 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The bytes for activityNameSnippet.
   */
  com.google.protobuf.ByteString
      getActivityNameSnippetBytes();

  /**
   * <pre>
   * Output only. Activity description snippet shows how the
   * [description][google.cloud.talent.v4beta1.Activity.description] is related to a search query. It's empty if the
   * [description][google.cloud.talent.v4beta1.Activity.description] isn't related to the search query.
   * </pre>
   *
   * <code>string activity_description_snippet = 9 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The activityDescriptionSnippet.
   */
  java.lang.String getActivityDescriptionSnippet();
  /**
   * <pre>
   * Output only. Activity description snippet shows how the
   * [description][google.cloud.talent.v4beta1.Activity.description] is related to a search query. It's empty if the
   * [description][google.cloud.talent.v4beta1.Activity.description] isn't related to the search query.
   * </pre>
   *
   * <code>string activity_description_snippet = 9 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The bytes for activityDescriptionSnippet.
   */
  com.google.protobuf.ByteString
      getActivityDescriptionSnippetBytes();

  /**
   * <pre>
   * Output only. Skill used snippet shows how the corresponding
   * [skills_used][google.cloud.talent.v4beta1.Activity.skills_used] are related to a search query. It's empty if the
   * corresponding [skills_used][google.cloud.talent.v4beta1.Activity.skills_used] are not related to the search query.
   * </pre>
   *
   * <code>repeated string skills_used_snippet = 10 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return A list containing the skillsUsedSnippet.
   */
  java.util.List<java.lang.String>
      getSkillsUsedSnippetList();
  /**
   * <pre>
   * Output only. Skill used snippet shows how the corresponding
   * [skills_used][google.cloud.talent.v4beta1.Activity.skills_used] are related to a search query. It's empty if the
   * corresponding [skills_used][google.cloud.talent.v4beta1.Activity.skills_used] are not related to the search query.
   * </pre>
   *
   * <code>repeated string skills_used_snippet = 10 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @return The count of skillsUsedSnippet.
   */
  int getSkillsUsedSnippetCount();
  /**
   * <pre>
   * Output only. Skill used snippet shows how the corresponding
   * [skills_used][google.cloud.talent.v4beta1.Activity.skills_used] are related to a search query. It's empty if the
   * corresponding [skills_used][google.cloud.talent.v4beta1.Activity.skills_used] are not related to the search query.
   * </pre>
   *
   * <code>repeated string skills_used_snippet = 10 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @param index The index of the element to return.
   * @return The skillsUsedSnippet at the given index.
   */
  java.lang.String getSkillsUsedSnippet(int index);
  /**
   * <pre>
   * Output only. Skill used snippet shows how the corresponding
   * [skills_used][google.cloud.talent.v4beta1.Activity.skills_used] are related to a search query. It's empty if the
   * corresponding [skills_used][google.cloud.talent.v4beta1.Activity.skills_used] are not related to the search query.
   * </pre>
   *
   * <code>repeated string skills_used_snippet = 10 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
   * @param index The index of the value to return.
   * @return The bytes of the skillsUsedSnippet at the given index.
   */
  com.google.protobuf.ByteString
      getSkillsUsedSnippetBytes(int index);
}
