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
public class AdGroupBidModifierName implements ResourceName {
  private static final PathTemplate CUSTOMER_AD_GROUP_BID_MODIFIER =
      PathTemplate.createWithoutUrlEncoding(
          "customers/{customer}/adGroupBidModifiers/{ad_group_bid_modifier}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String adGroupBidModifier;

  @Deprecated
  protected AdGroupBidModifierName() {
    customer = null;
    adGroupBidModifier = null;
  }

  private AdGroupBidModifierName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    adGroupBidModifier = Preconditions.checkNotNull(builder.getAdGroupBidModifier());
  }

  public String getCustomer() {
    return customer;
  }

  public String getAdGroupBidModifier() {
    return adGroupBidModifier;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static AdGroupBidModifierName of(String customer, String adGroupBidModifier) {
    return newBuilder().setCustomer(customer).setAdGroupBidModifier(adGroupBidModifier).build();
  }

  public static String format(String customer, String adGroupBidModifier) {
    return newBuilder()
        .setCustomer(customer)
        .setAdGroupBidModifier(adGroupBidModifier)
        .build()
        .toString();
  }

  public static AdGroupBidModifierName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_AD_GROUP_BID_MODIFIER.validatedMatch(
            formattedString, "AdGroupBidModifierName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("ad_group_bid_modifier"));
  }

  public static List<AdGroupBidModifierName> parseList(List<String> formattedStrings) {
    List<AdGroupBidModifierName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<AdGroupBidModifierName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (AdGroupBidModifierName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_AD_GROUP_BID_MODIFIER.matches(formattedString);
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
          if (adGroupBidModifier != null) {
            fieldMapBuilder.put("ad_group_bid_modifier", adGroupBidModifier);
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
    return CUSTOMER_AD_GROUP_BID_MODIFIER.instantiate(
        "customer", customer, "ad_group_bid_modifier", adGroupBidModifier);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      AdGroupBidModifierName that = ((AdGroupBidModifierName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.adGroupBidModifier, that.adGroupBidModifier);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(adGroupBidModifier);
    return h;
  }

  /** Builder for customers/{customer}/adGroupBidModifiers/{ad_group_bid_modifier}. */
  public static class Builder {
    private String customer;
    private String adGroupBidModifier;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getAdGroupBidModifier() {
      return adGroupBidModifier;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setAdGroupBidModifier(String adGroupBidModifier) {
      this.adGroupBidModifier = adGroupBidModifier;
      return this;
    }

    private Builder(AdGroupBidModifierName adGroupBidModifierName) {
      this.customer = adGroupBidModifierName.customer;
      this.adGroupBidModifier = adGroupBidModifierName.adGroupBidModifier;
    }

    public AdGroupBidModifierName build() {
      return new AdGroupBidModifierName(this);
    }
  }
}
