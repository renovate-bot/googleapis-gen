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
public class AdScheduleViewName implements ResourceName {
  private static final PathTemplate CUSTOMER_AD_SCHEDULE_VIEW =
      PathTemplate.createWithoutUrlEncoding(
          "customers/{customer}/adScheduleViews/{ad_schedule_view}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String adScheduleView;

  @Deprecated
  protected AdScheduleViewName() {
    customer = null;
    adScheduleView = null;
  }

  private AdScheduleViewName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    adScheduleView = Preconditions.checkNotNull(builder.getAdScheduleView());
  }

  public String getCustomer() {
    return customer;
  }

  public String getAdScheduleView() {
    return adScheduleView;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static AdScheduleViewName of(String customer, String adScheduleView) {
    return newBuilder().setCustomer(customer).setAdScheduleView(adScheduleView).build();
  }

  public static String format(String customer, String adScheduleView) {
    return newBuilder().setCustomer(customer).setAdScheduleView(adScheduleView).build().toString();
  }

  public static AdScheduleViewName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_AD_SCHEDULE_VIEW.validatedMatch(
            formattedString, "AdScheduleViewName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("ad_schedule_view"));
  }

  public static List<AdScheduleViewName> parseList(List<String> formattedStrings) {
    List<AdScheduleViewName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<AdScheduleViewName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (AdScheduleViewName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_AD_SCHEDULE_VIEW.matches(formattedString);
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
          if (adScheduleView != null) {
            fieldMapBuilder.put("ad_schedule_view", adScheduleView);
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
    return CUSTOMER_AD_SCHEDULE_VIEW.instantiate(
        "customer", customer, "ad_schedule_view", adScheduleView);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      AdScheduleViewName that = ((AdScheduleViewName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.adScheduleView, that.adScheduleView);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(adScheduleView);
    return h;
  }

  /** Builder for customers/{customer}/adScheduleViews/{ad_schedule_view}. */
  public static class Builder {
    private String customer;
    private String adScheduleView;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getAdScheduleView() {
      return adScheduleView;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setAdScheduleView(String adScheduleView) {
      this.adScheduleView = adScheduleView;
      return this;
    }

    private Builder(AdScheduleViewName adScheduleViewName) {
      this.customer = adScheduleViewName.customer;
      this.adScheduleView = adScheduleViewName.adScheduleView;
    }

    public AdScheduleViewName build() {
      return new AdScheduleViewName(this);
    }
  }
}
