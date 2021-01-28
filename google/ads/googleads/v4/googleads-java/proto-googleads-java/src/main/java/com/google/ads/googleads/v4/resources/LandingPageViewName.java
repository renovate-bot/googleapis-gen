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
public class LandingPageViewName implements ResourceName {
  private static final PathTemplate CUSTOMER_LANDING_PAGE_VIEW =
      PathTemplate.createWithoutUrlEncoding(
          "customers/{customer}/landingPageViews/{landing_page_view}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String landingPageView;

  @Deprecated
  protected LandingPageViewName() {
    customer = null;
    landingPageView = null;
  }

  private LandingPageViewName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    landingPageView = Preconditions.checkNotNull(builder.getLandingPageView());
  }

  public String getCustomer() {
    return customer;
  }

  public String getLandingPageView() {
    return landingPageView;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static LandingPageViewName of(String customer, String landingPageView) {
    return newBuilder().setCustomer(customer).setLandingPageView(landingPageView).build();
  }

  public static String format(String customer, String landingPageView) {
    return newBuilder()
        .setCustomer(customer)
        .setLandingPageView(landingPageView)
        .build()
        .toString();
  }

  public static LandingPageViewName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_LANDING_PAGE_VIEW.validatedMatch(
            formattedString, "LandingPageViewName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("landing_page_view"));
  }

  public static List<LandingPageViewName> parseList(List<String> formattedStrings) {
    List<LandingPageViewName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<LandingPageViewName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (LandingPageViewName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_LANDING_PAGE_VIEW.matches(formattedString);
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
          if (landingPageView != null) {
            fieldMapBuilder.put("landing_page_view", landingPageView);
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
    return CUSTOMER_LANDING_PAGE_VIEW.instantiate(
        "customer", customer, "landing_page_view", landingPageView);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      LandingPageViewName that = ((LandingPageViewName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.landingPageView, that.landingPageView);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(landingPageView);
    return h;
  }

  /** Builder for customers/{customer}/landingPageViews/{landing_page_view}. */
  public static class Builder {
    private String customer;
    private String landingPageView;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getLandingPageView() {
      return landingPageView;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setLandingPageView(String landingPageView) {
      this.landingPageView = landingPageView;
      return this;
    }

    private Builder(LandingPageViewName landingPageViewName) {
      customer = landingPageViewName.customer;
      landingPageView = landingPageViewName.landingPageView;
    }

    public LandingPageViewName build() {
      return new LandingPageViewName(this);
    }
  }
}
