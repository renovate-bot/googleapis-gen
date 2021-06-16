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
public class ExpandedLandingPageViewName implements ResourceName {
  private static final PathTemplate CUSTOMER_EXPANDED_LANDING_PAGE_VIEW =
      PathTemplate.createWithoutUrlEncoding(
          "customers/{customer}/expandedLandingPageViews/{expanded_landing_page_view}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String expandedLandingPageView;

  @Deprecated
  protected ExpandedLandingPageViewName() {
    customer = null;
    expandedLandingPageView = null;
  }

  private ExpandedLandingPageViewName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    expandedLandingPageView = Preconditions.checkNotNull(builder.getExpandedLandingPageView());
  }

  public String getCustomer() {
    return customer;
  }

  public String getExpandedLandingPageView() {
    return expandedLandingPageView;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static ExpandedLandingPageViewName of(String customer, String expandedLandingPageView) {
    return newBuilder()
        .setCustomer(customer)
        .setExpandedLandingPageView(expandedLandingPageView)
        .build();
  }

  public static String format(String customer, String expandedLandingPageView) {
    return newBuilder()
        .setCustomer(customer)
        .setExpandedLandingPageView(expandedLandingPageView)
        .build()
        .toString();
  }

  public static ExpandedLandingPageViewName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_EXPANDED_LANDING_PAGE_VIEW.validatedMatch(
            formattedString,
            "ExpandedLandingPageViewName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("expanded_landing_page_view"));
  }

  public static List<ExpandedLandingPageViewName> parseList(List<String> formattedStrings) {
    List<ExpandedLandingPageViewName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<ExpandedLandingPageViewName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (ExpandedLandingPageViewName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_EXPANDED_LANDING_PAGE_VIEW.matches(formattedString);
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
          if (expandedLandingPageView != null) {
            fieldMapBuilder.put("expanded_landing_page_view", expandedLandingPageView);
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
    return CUSTOMER_EXPANDED_LANDING_PAGE_VIEW.instantiate(
        "customer", customer, "expanded_landing_page_view", expandedLandingPageView);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      ExpandedLandingPageViewName that = ((ExpandedLandingPageViewName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.expandedLandingPageView, that.expandedLandingPageView);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(expandedLandingPageView);
    return h;
  }

  /** Builder for customers/{customer}/expandedLandingPageViews/{expanded_landing_page_view}. */
  public static class Builder {
    private String customer;
    private String expandedLandingPageView;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getExpandedLandingPageView() {
      return expandedLandingPageView;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setExpandedLandingPageView(String expandedLandingPageView) {
      this.expandedLandingPageView = expandedLandingPageView;
      return this;
    }

    private Builder(ExpandedLandingPageViewName expandedLandingPageViewName) {
      this.customer = expandedLandingPageViewName.customer;
      this.expandedLandingPageView = expandedLandingPageViewName.expandedLandingPageView;
    }

    public ExpandedLandingPageViewName build() {
      return new ExpandedLandingPageViewName(this);
    }
  }
}
