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
public class DistanceViewName implements ResourceName {
  private static final PathTemplate CUSTOMER_DISTANCE_VIEW =
      PathTemplate.createWithoutUrlEncoding("customers/{customer}/distanceViews/{distance_view}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String distanceView;

  @Deprecated
  protected DistanceViewName() {
    customer = null;
    distanceView = null;
  }

  private DistanceViewName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    distanceView = Preconditions.checkNotNull(builder.getDistanceView());
  }

  public String getCustomer() {
    return customer;
  }

  public String getDistanceView() {
    return distanceView;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static DistanceViewName of(String customer, String distanceView) {
    return newBuilder().setCustomer(customer).setDistanceView(distanceView).build();
  }

  public static String format(String customer, String distanceView) {
    return newBuilder().setCustomer(customer).setDistanceView(distanceView).build().toString();
  }

  public static DistanceViewName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_DISTANCE_VIEW.validatedMatch(
            formattedString, "DistanceViewName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("distance_view"));
  }

  public static List<DistanceViewName> parseList(List<String> formattedStrings) {
    List<DistanceViewName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<DistanceViewName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (DistanceViewName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_DISTANCE_VIEW.matches(formattedString);
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
          if (distanceView != null) {
            fieldMapBuilder.put("distance_view", distanceView);
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
    return CUSTOMER_DISTANCE_VIEW.instantiate("customer", customer, "distance_view", distanceView);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      DistanceViewName that = ((DistanceViewName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.distanceView, that.distanceView);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(distanceView);
    return h;
  }

  /** Builder for customers/{customer}/distanceViews/{distance_view}. */
  public static class Builder {
    private String customer;
    private String distanceView;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getDistanceView() {
      return distanceView;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setDistanceView(String distanceView) {
      this.distanceView = distanceView;
      return this;
    }

    private Builder(DistanceViewName distanceViewName) {
      customer = distanceViewName.customer;
      distanceView = distanceViewName.distanceView;
    }

    public DistanceViewName build() {
      return new DistanceViewName(this);
    }
  }
}
