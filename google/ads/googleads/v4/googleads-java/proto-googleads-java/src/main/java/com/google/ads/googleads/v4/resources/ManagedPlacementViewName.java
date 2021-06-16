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

package com.google.ads.googleads.v4.resources;

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
public class ManagedPlacementViewName implements ResourceName {
  private static final PathTemplate CUSTOMER_MANAGED_PLACEMENT_VIEW =
      PathTemplate.createWithoutUrlEncoding(
          "customers/{customer}/managedPlacementViews/{managed_placement_view}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String managedPlacementView;

  @Deprecated
  protected ManagedPlacementViewName() {
    customer = null;
    managedPlacementView = null;
  }

  private ManagedPlacementViewName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    managedPlacementView = Preconditions.checkNotNull(builder.getManagedPlacementView());
  }

  public String getCustomer() {
    return customer;
  }

  public String getManagedPlacementView() {
    return managedPlacementView;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static ManagedPlacementViewName of(String customer, String managedPlacementView) {
    return newBuilder().setCustomer(customer).setManagedPlacementView(managedPlacementView).build();
  }

  public static String format(String customer, String managedPlacementView) {
    return newBuilder()
        .setCustomer(customer)
        .setManagedPlacementView(managedPlacementView)
        .build()
        .toString();
  }

  public static ManagedPlacementViewName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_MANAGED_PLACEMENT_VIEW.validatedMatch(
            formattedString, "ManagedPlacementViewName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("managed_placement_view"));
  }

  public static List<ManagedPlacementViewName> parseList(List<String> formattedStrings) {
    List<ManagedPlacementViewName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<ManagedPlacementViewName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (ManagedPlacementViewName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_MANAGED_PLACEMENT_VIEW.matches(formattedString);
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
          if (managedPlacementView != null) {
            fieldMapBuilder.put("managed_placement_view", managedPlacementView);
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
    return CUSTOMER_MANAGED_PLACEMENT_VIEW.instantiate(
        "customer", customer, "managed_placement_view", managedPlacementView);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      ManagedPlacementViewName that = ((ManagedPlacementViewName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.managedPlacementView, that.managedPlacementView);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(managedPlacementView);
    return h;
  }

  /** Builder for customers/{customer}/managedPlacementViews/{managed_placement_view}. */
  public static class Builder {
    private String customer;
    private String managedPlacementView;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getManagedPlacementView() {
      return managedPlacementView;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setManagedPlacementView(String managedPlacementView) {
      this.managedPlacementView = managedPlacementView;
      return this;
    }

    private Builder(ManagedPlacementViewName managedPlacementViewName) {
      this.customer = managedPlacementViewName.customer;
      this.managedPlacementView = managedPlacementViewName.managedPlacementView;
    }

    public ManagedPlacementViewName build() {
      return new ManagedPlacementViewName(this);
    }
  }
}
