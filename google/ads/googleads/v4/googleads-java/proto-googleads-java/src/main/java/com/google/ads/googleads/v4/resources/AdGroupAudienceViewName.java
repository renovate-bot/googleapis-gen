/*
 * Copyright 2020 Google LLC
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
public class AdGroupAudienceViewName implements ResourceName {
  private static final PathTemplate CUSTOMER_AD_GROUP_AUDIENCE_VIEW =
      PathTemplate.createWithoutUrlEncoding(
          "customers/{customer}/adGroupAudienceViews/{ad_group_audience_view}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String adGroupAudienceView;

  @Deprecated
  protected AdGroupAudienceViewName() {
    customer = null;
    adGroupAudienceView = null;
  }

  private AdGroupAudienceViewName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    adGroupAudienceView = Preconditions.checkNotNull(builder.getAdGroupAudienceView());
  }

  public String getCustomer() {
    return customer;
  }

  public String getAdGroupAudienceView() {
    return adGroupAudienceView;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static AdGroupAudienceViewName of(String customer, String adGroupAudienceView) {
    return newBuilder().setCustomer(customer).setAdGroupAudienceView(adGroupAudienceView).build();
  }

  public static String format(String customer, String adGroupAudienceView) {
    return newBuilder()
        .setCustomer(customer)
        .setAdGroupAudienceView(adGroupAudienceView)
        .build()
        .toString();
  }

  public static AdGroupAudienceViewName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_AD_GROUP_AUDIENCE_VIEW.validatedMatch(
            formattedString, "AdGroupAudienceViewName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("ad_group_audience_view"));
  }

  public static List<AdGroupAudienceViewName> parseList(List<String> formattedStrings) {
    List<AdGroupAudienceViewName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<AdGroupAudienceViewName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (AdGroupAudienceViewName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_AD_GROUP_AUDIENCE_VIEW.matches(formattedString);
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
          if (adGroupAudienceView != null) {
            fieldMapBuilder.put("ad_group_audience_view", adGroupAudienceView);
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
    return CUSTOMER_AD_GROUP_AUDIENCE_VIEW.instantiate(
        "customer", customer, "ad_group_audience_view", adGroupAudienceView);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      AdGroupAudienceViewName that = ((AdGroupAudienceViewName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.adGroupAudienceView, that.adGroupAudienceView);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(adGroupAudienceView);
    return h;
  }

  /** Builder for customers/{customer}/adGroupAudienceViews/{ad_group_audience_view}. */
  public static class Builder {
    private String customer;
    private String adGroupAudienceView;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getAdGroupAudienceView() {
      return adGroupAudienceView;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setAdGroupAudienceView(String adGroupAudienceView) {
      this.adGroupAudienceView = adGroupAudienceView;
      return this;
    }

    private Builder(AdGroupAudienceViewName adGroupAudienceViewName) {
      customer = adGroupAudienceViewName.customer;
      adGroupAudienceView = adGroupAudienceViewName.adGroupAudienceView;
    }

    public AdGroupAudienceViewName build() {
      return new AdGroupAudienceViewName(this);
    }
  }
}
