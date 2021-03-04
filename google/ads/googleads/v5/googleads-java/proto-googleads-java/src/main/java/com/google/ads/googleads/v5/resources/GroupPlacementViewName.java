/*
 * Copyright 2021 Google LLC
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      https://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

package com.google.ads.googleads.v5.resources;

import com.google.api.pathtemplate.PathTemplate;
import com.google.api.resourcenames.ResourceName;
import com.google.common.base.Preconditions;
import com.google.common.collect.ImmutableMap;
import java.util.ArrayList;
import java.util.List;
import java.util.Map;
import java.util.Objects;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
@Generated("by gapic-generator-java")
public class GroupPlacementViewName implements ResourceName {
  private static final PathTemplate CUSTOMER_GROUP_PLACEMENT_VIEW =
      PathTemplate.createWithoutUrlEncoding(
          "customers/{customer}/groupPlacementViews/{group_placement_view}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String groupPlacementView;

  @Deprecated
  protected GroupPlacementViewName() {
    customer = null;
    groupPlacementView = null;
  }

  private GroupPlacementViewName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    groupPlacementView = Preconditions.checkNotNull(builder.getGroupPlacementView());
  }

  public String getCustomer() {
    return customer;
  }

  public String getGroupPlacementView() {
    return groupPlacementView;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static GroupPlacementViewName of(String customer, String groupPlacementView) {
    return newBuilder().setCustomer(customer).setGroupPlacementView(groupPlacementView).build();
  }

  public static String format(String customer, String groupPlacementView) {
    return newBuilder()
        .setCustomer(customer)
        .setGroupPlacementView(groupPlacementView)
        .build()
        .toString();
  }

  public static GroupPlacementViewName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_GROUP_PLACEMENT_VIEW.validatedMatch(
            formattedString, "GroupPlacementViewName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("group_placement_view"));
  }

  public static List<GroupPlacementViewName> parseList(List<String> formattedStrings) {
    List<GroupPlacementViewName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<GroupPlacementViewName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (GroupPlacementViewName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_GROUP_PLACEMENT_VIEW.matches(formattedString);
  }

  @Override
  public Map<String, String> getFieldValuesMap() {
    if (fieldValuesMap == null) {
      synchronized (this) {
        if (fieldValuesMap == null) {
          ImmutableMap.Builder<String, String> fieldMapBuilder = ImmutableMap.builder();
          if (customer != null) {
            fieldMapBuilder.put("customer", customer);
          }
          if (groupPlacementView != null) {
            fieldMapBuilder.put("group_placement_view", groupPlacementView);
          }
          fieldValuesMap = fieldMapBuilder.build();
        }
      }
    }
    return fieldValuesMap;
  }

  public String getFieldValue(String fieldName) {
    return getFieldValuesMap().get(fieldName);
  }

  @Override
  public String toString() {
    return CUSTOMER_GROUP_PLACEMENT_VIEW.instantiate(
        "customer", customer, "group_placement_view", groupPlacementView);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      GroupPlacementViewName that = ((GroupPlacementViewName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.groupPlacementView, that.groupPlacementView);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(groupPlacementView);
    return h;
  }

  /** Builder for customers/{customer}/groupPlacementViews/{group_placement_view}. */
  public static class Builder {
    private String customer;
    private String groupPlacementView;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getGroupPlacementView() {
      return groupPlacementView;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setGroupPlacementView(String groupPlacementView) {
      this.groupPlacementView = groupPlacementView;
      return this;
    }

    private Builder(GroupPlacementViewName groupPlacementViewName) {
      customer = groupPlacementViewName.customer;
      groupPlacementView = groupPlacementViewName.groupPlacementView;
    }

    public GroupPlacementViewName build() {
      return new GroupPlacementViewName(this);
    }
  }
}
