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
public class AdGroupAdAssetViewName implements ResourceName {
  private static final PathTemplate CUSTOMER_AD_GROUP_AD_ASSET_VIEW =
      PathTemplate.createWithoutUrlEncoding(
          "customers/{customer}/adGroupAdAssetViews/{ad_group_ad_asset_view}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String adGroupAdAssetView;

  @Deprecated
  protected AdGroupAdAssetViewName() {
    customer = null;
    adGroupAdAssetView = null;
  }

  private AdGroupAdAssetViewName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    adGroupAdAssetView = Preconditions.checkNotNull(builder.getAdGroupAdAssetView());
  }

  public String getCustomer() {
    return customer;
  }

  public String getAdGroupAdAssetView() {
    return adGroupAdAssetView;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static AdGroupAdAssetViewName of(String customer, String adGroupAdAssetView) {
    return newBuilder().setCustomer(customer).setAdGroupAdAssetView(adGroupAdAssetView).build();
  }

  public static String format(String customer, String adGroupAdAssetView) {
    return newBuilder()
        .setCustomer(customer)
        .setAdGroupAdAssetView(adGroupAdAssetView)
        .build()
        .toString();
  }

  public static AdGroupAdAssetViewName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_AD_GROUP_AD_ASSET_VIEW.validatedMatch(
            formattedString, "AdGroupAdAssetViewName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("ad_group_ad_asset_view"));
  }

  public static List<AdGroupAdAssetViewName> parseList(List<String> formattedStrings) {
    List<AdGroupAdAssetViewName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<AdGroupAdAssetViewName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (AdGroupAdAssetViewName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_AD_GROUP_AD_ASSET_VIEW.matches(formattedString);
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
          if (adGroupAdAssetView != null) {
            fieldMapBuilder.put("ad_group_ad_asset_view", adGroupAdAssetView);
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
    return CUSTOMER_AD_GROUP_AD_ASSET_VIEW.instantiate(
        "customer", customer, "ad_group_ad_asset_view", adGroupAdAssetView);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      AdGroupAdAssetViewName that = ((AdGroupAdAssetViewName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.adGroupAdAssetView, that.adGroupAdAssetView);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(adGroupAdAssetView);
    return h;
  }

  /** Builder for customers/{customer}/adGroupAdAssetViews/{ad_group_ad_asset_view}. */
  public static class Builder {
    private String customer;
    private String adGroupAdAssetView;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getAdGroupAdAssetView() {
      return adGroupAdAssetView;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setAdGroupAdAssetView(String adGroupAdAssetView) {
      this.adGroupAdAssetView = adGroupAdAssetView;
      return this;
    }

    private Builder(AdGroupAdAssetViewName adGroupAdAssetViewName) {
      customer = adGroupAdAssetViewName.customer;
      adGroupAdAssetView = adGroupAdAssetViewName.adGroupAdAssetView;
    }

    public AdGroupAdAssetViewName build() {
      return new AdGroupAdAssetViewName(this);
    }
  }
}
