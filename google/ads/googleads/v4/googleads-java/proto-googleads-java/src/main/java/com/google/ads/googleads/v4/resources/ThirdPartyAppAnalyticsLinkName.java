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
public class ThirdPartyAppAnalyticsLinkName implements ResourceName {
  private static final PathTemplate CUSTOMER_THIRD_PARTY_APP_ANALYTICS_LINK =
      PathTemplate.createWithoutUrlEncoding(
          "customers/{customer}/thirdPartyAppAnalyticsLinks/{third_party_app_analytics_link}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String thirdPartyAppAnalyticsLink;

  @Deprecated
  protected ThirdPartyAppAnalyticsLinkName() {
    customer = null;
    thirdPartyAppAnalyticsLink = null;
  }

  private ThirdPartyAppAnalyticsLinkName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    thirdPartyAppAnalyticsLink =
        Preconditions.checkNotNull(builder.getThirdPartyAppAnalyticsLink());
  }

  public String getCustomer() {
    return customer;
  }

  public String getThirdPartyAppAnalyticsLink() {
    return thirdPartyAppAnalyticsLink;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static ThirdPartyAppAnalyticsLinkName of(
      String customer, String thirdPartyAppAnalyticsLink) {
    return newBuilder()
        .setCustomer(customer)
        .setThirdPartyAppAnalyticsLink(thirdPartyAppAnalyticsLink)
        .build();
  }

  public static String format(String customer, String thirdPartyAppAnalyticsLink) {
    return newBuilder()
        .setCustomer(customer)
        .setThirdPartyAppAnalyticsLink(thirdPartyAppAnalyticsLink)
        .build()
        .toString();
  }

  public static ThirdPartyAppAnalyticsLinkName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_THIRD_PARTY_APP_ANALYTICS_LINK.validatedMatch(
            formattedString,
            "ThirdPartyAppAnalyticsLinkName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("third_party_app_analytics_link"));
  }

  public static List<ThirdPartyAppAnalyticsLinkName> parseList(List<String> formattedStrings) {
    List<ThirdPartyAppAnalyticsLinkName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<ThirdPartyAppAnalyticsLinkName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (ThirdPartyAppAnalyticsLinkName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_THIRD_PARTY_APP_ANALYTICS_LINK.matches(formattedString);
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
          if (thirdPartyAppAnalyticsLink != null) {
            fieldMapBuilder.put("third_party_app_analytics_link", thirdPartyAppAnalyticsLink);
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
    return CUSTOMER_THIRD_PARTY_APP_ANALYTICS_LINK.instantiate(
        "customer", customer, "third_party_app_analytics_link", thirdPartyAppAnalyticsLink);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      ThirdPartyAppAnalyticsLinkName that = ((ThirdPartyAppAnalyticsLinkName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.thirdPartyAppAnalyticsLink, that.thirdPartyAppAnalyticsLink);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(thirdPartyAppAnalyticsLink);
    return h;
  }

  /**
   * Builder for customers/{customer}/thirdPartyAppAnalyticsLinks/{third_party_app_analytics_link}.
   */
  public static class Builder {
    private String customer;
    private String thirdPartyAppAnalyticsLink;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getThirdPartyAppAnalyticsLink() {
      return thirdPartyAppAnalyticsLink;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setThirdPartyAppAnalyticsLink(String thirdPartyAppAnalyticsLink) {
      this.thirdPartyAppAnalyticsLink = thirdPartyAppAnalyticsLink;
      return this;
    }

    private Builder(ThirdPartyAppAnalyticsLinkName thirdPartyAppAnalyticsLinkName) {
      customer = thirdPartyAppAnalyticsLinkName.customer;
      thirdPartyAppAnalyticsLink = thirdPartyAppAnalyticsLinkName.thirdPartyAppAnalyticsLink;
    }

    public ThirdPartyAppAnalyticsLinkName build() {
      return new ThirdPartyAppAnalyticsLinkName(this);
    }
  }
}
