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
public class AdGroupFeedName implements ResourceName {
  private static final PathTemplate CUSTOMER_AD_GROUP_FEED =
      PathTemplate.createWithoutUrlEncoding("customers/{customer}/adGroupFeeds/{ad_group_feed}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String adGroupFeed;

  @Deprecated
  protected AdGroupFeedName() {
    customer = null;
    adGroupFeed = null;
  }

  private AdGroupFeedName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    adGroupFeed = Preconditions.checkNotNull(builder.getAdGroupFeed());
  }

  public String getCustomer() {
    return customer;
  }

  public String getAdGroupFeed() {
    return adGroupFeed;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static AdGroupFeedName of(String customer, String adGroupFeed) {
    return newBuilder().setCustomer(customer).setAdGroupFeed(adGroupFeed).build();
  }

  public static String format(String customer, String adGroupFeed) {
    return newBuilder().setCustomer(customer).setAdGroupFeed(adGroupFeed).build().toString();
  }

  public static AdGroupFeedName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_AD_GROUP_FEED.validatedMatch(
            formattedString, "AdGroupFeedName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("ad_group_feed"));
  }

  public static List<AdGroupFeedName> parseList(List<String> formattedStrings) {
    List<AdGroupFeedName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<AdGroupFeedName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (AdGroupFeedName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_AD_GROUP_FEED.matches(formattedString);
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
          if (adGroupFeed != null) {
            fieldMapBuilder.put("ad_group_feed", adGroupFeed);
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
    return CUSTOMER_AD_GROUP_FEED.instantiate("customer", customer, "ad_group_feed", adGroupFeed);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      AdGroupFeedName that = ((AdGroupFeedName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.adGroupFeed, that.adGroupFeed);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(adGroupFeed);
    return h;
  }

  /** Builder for customers/{customer}/adGroupFeeds/{ad_group_feed}. */
  public static class Builder {
    private String customer;
    private String adGroupFeed;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getAdGroupFeed() {
      return adGroupFeed;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setAdGroupFeed(String adGroupFeed) {
      this.adGroupFeed = adGroupFeed;
      return this;
    }

    private Builder(AdGroupFeedName adGroupFeedName) {
      customer = adGroupFeedName.customer;
      adGroupFeed = adGroupFeedName.adGroupFeed;
    }

    public AdGroupFeedName build() {
      return new AdGroupFeedName(this);
    }
  }
}
