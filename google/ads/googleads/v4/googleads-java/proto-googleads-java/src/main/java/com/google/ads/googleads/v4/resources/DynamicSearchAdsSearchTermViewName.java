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
public class DynamicSearchAdsSearchTermViewName implements ResourceName {
  private static final PathTemplate CUSTOMER_DYNAMIC_SEARCH_ADS_SEARCH_TERM_VIEW =
      PathTemplate.createWithoutUrlEncoding(
          "customers/{customer}/dynamicSearchAdsSearchTermViews/{dynamic_search_ads_search_term_view}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String dynamicSearchAdsSearchTermView;

  @Deprecated
  protected DynamicSearchAdsSearchTermViewName() {
    customer = null;
    dynamicSearchAdsSearchTermView = null;
  }

  private DynamicSearchAdsSearchTermViewName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    dynamicSearchAdsSearchTermView =
        Preconditions.checkNotNull(builder.getDynamicSearchAdsSearchTermView());
  }

  public String getCustomer() {
    return customer;
  }

  public String getDynamicSearchAdsSearchTermView() {
    return dynamicSearchAdsSearchTermView;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static DynamicSearchAdsSearchTermViewName of(
      String customer, String dynamicSearchAdsSearchTermView) {
    return newBuilder()
        .setCustomer(customer)
        .setDynamicSearchAdsSearchTermView(dynamicSearchAdsSearchTermView)
        .build();
  }

  public static String format(String customer, String dynamicSearchAdsSearchTermView) {
    return newBuilder()
        .setCustomer(customer)
        .setDynamicSearchAdsSearchTermView(dynamicSearchAdsSearchTermView)
        .build()
        .toString();
  }

  public static DynamicSearchAdsSearchTermViewName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_DYNAMIC_SEARCH_ADS_SEARCH_TERM_VIEW.validatedMatch(
            formattedString,
            "DynamicSearchAdsSearchTermViewName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("dynamic_search_ads_search_term_view"));
  }

  public static List<DynamicSearchAdsSearchTermViewName> parseList(List<String> formattedStrings) {
    List<DynamicSearchAdsSearchTermViewName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<DynamicSearchAdsSearchTermViewName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (DynamicSearchAdsSearchTermViewName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_DYNAMIC_SEARCH_ADS_SEARCH_TERM_VIEW.matches(formattedString);
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
          if (dynamicSearchAdsSearchTermView != null) {
            fieldMapBuilder.put(
                "dynamic_search_ads_search_term_view", dynamicSearchAdsSearchTermView);
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
    return CUSTOMER_DYNAMIC_SEARCH_ADS_SEARCH_TERM_VIEW.instantiate(
        "customer",
        customer,
        "dynamic_search_ads_search_term_view",
        dynamicSearchAdsSearchTermView);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      DynamicSearchAdsSearchTermViewName that = ((DynamicSearchAdsSearchTermViewName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(
              this.dynamicSearchAdsSearchTermView, that.dynamicSearchAdsSearchTermView);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(dynamicSearchAdsSearchTermView);
    return h;
  }

  /**
   * Builder for
   * customers/{customer}/dynamicSearchAdsSearchTermViews/{dynamic_search_ads_search_term_view}.
   */
  public static class Builder {
    private String customer;
    private String dynamicSearchAdsSearchTermView;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getDynamicSearchAdsSearchTermView() {
      return dynamicSearchAdsSearchTermView;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setDynamicSearchAdsSearchTermView(String dynamicSearchAdsSearchTermView) {
      this.dynamicSearchAdsSearchTermView = dynamicSearchAdsSearchTermView;
      return this;
    }

    private Builder(DynamicSearchAdsSearchTermViewName dynamicSearchAdsSearchTermViewName) {
      this.customer = dynamicSearchAdsSearchTermViewName.customer;
      this.dynamicSearchAdsSearchTermView =
          dynamicSearchAdsSearchTermViewName.dynamicSearchAdsSearchTermView;
    }

    public DynamicSearchAdsSearchTermViewName build() {
      return new DynamicSearchAdsSearchTermViewName(this);
    }
  }
}
