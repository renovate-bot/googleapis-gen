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
public class CampaignFeedName implements ResourceName {
  private static final PathTemplate CUSTOMER_CAMPAIGN_FEED =
      PathTemplate.createWithoutUrlEncoding("customers/{customer}/campaignFeeds/{campaign_feed}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String campaignFeed;

  @Deprecated
  protected CampaignFeedName() {
    customer = null;
    campaignFeed = null;
  }

  private CampaignFeedName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    campaignFeed = Preconditions.checkNotNull(builder.getCampaignFeed());
  }

  public String getCustomer() {
    return customer;
  }

  public String getCampaignFeed() {
    return campaignFeed;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static CampaignFeedName of(String customer, String campaignFeed) {
    return newBuilder().setCustomer(customer).setCampaignFeed(campaignFeed).build();
  }

  public static String format(String customer, String campaignFeed) {
    return newBuilder().setCustomer(customer).setCampaignFeed(campaignFeed).build().toString();
  }

  public static CampaignFeedName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_CAMPAIGN_FEED.validatedMatch(
            formattedString, "CampaignFeedName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("campaign_feed"));
  }

  public static List<CampaignFeedName> parseList(List<String> formattedStrings) {
    List<CampaignFeedName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<CampaignFeedName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (CampaignFeedName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_CAMPAIGN_FEED.matches(formattedString);
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
          if (campaignFeed != null) {
            fieldMapBuilder.put("campaign_feed", campaignFeed);
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
    return CUSTOMER_CAMPAIGN_FEED.instantiate("customer", customer, "campaign_feed", campaignFeed);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      CampaignFeedName that = ((CampaignFeedName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.campaignFeed, that.campaignFeed);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(campaignFeed);
    return h;
  }

  /** Builder for customers/{customer}/campaignFeeds/{campaign_feed}. */
  public static class Builder {
    private String customer;
    private String campaignFeed;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getCampaignFeed() {
      return campaignFeed;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setCampaignFeed(String campaignFeed) {
      this.campaignFeed = campaignFeed;
      return this;
    }

    private Builder(CampaignFeedName campaignFeedName) {
      this.customer = campaignFeedName.customer;
      this.campaignFeed = campaignFeedName.campaignFeed;
    }

    public CampaignFeedName build() {
      return new CampaignFeedName(this);
    }
  }
}
