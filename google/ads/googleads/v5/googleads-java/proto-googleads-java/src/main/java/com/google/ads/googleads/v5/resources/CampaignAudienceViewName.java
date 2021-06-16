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
public class CampaignAudienceViewName implements ResourceName {
  private static final PathTemplate CUSTOMER_CAMPAIGN_AUDIENCE_VIEW =
      PathTemplate.createWithoutUrlEncoding(
          "customers/{customer}/campaignAudienceViews/{campaign_audience_view}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String campaignAudienceView;

  @Deprecated
  protected CampaignAudienceViewName() {
    customer = null;
    campaignAudienceView = null;
  }

  private CampaignAudienceViewName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    campaignAudienceView = Preconditions.checkNotNull(builder.getCampaignAudienceView());
  }

  public String getCustomer() {
    return customer;
  }

  public String getCampaignAudienceView() {
    return campaignAudienceView;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static CampaignAudienceViewName of(String customer, String campaignAudienceView) {
    return newBuilder().setCustomer(customer).setCampaignAudienceView(campaignAudienceView).build();
  }

  public static String format(String customer, String campaignAudienceView) {
    return newBuilder()
        .setCustomer(customer)
        .setCampaignAudienceView(campaignAudienceView)
        .build()
        .toString();
  }

  public static CampaignAudienceViewName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_CAMPAIGN_AUDIENCE_VIEW.validatedMatch(
            formattedString, "CampaignAudienceViewName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("campaign_audience_view"));
  }

  public static List<CampaignAudienceViewName> parseList(List<String> formattedStrings) {
    List<CampaignAudienceViewName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<CampaignAudienceViewName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (CampaignAudienceViewName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_CAMPAIGN_AUDIENCE_VIEW.matches(formattedString);
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
          if (campaignAudienceView != null) {
            fieldMapBuilder.put("campaign_audience_view", campaignAudienceView);
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
    return CUSTOMER_CAMPAIGN_AUDIENCE_VIEW.instantiate(
        "customer", customer, "campaign_audience_view", campaignAudienceView);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      CampaignAudienceViewName that = ((CampaignAudienceViewName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.campaignAudienceView, that.campaignAudienceView);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(campaignAudienceView);
    return h;
  }

  /** Builder for customers/{customer}/campaignAudienceViews/{campaign_audience_view}. */
  public static class Builder {
    private String customer;
    private String campaignAudienceView;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getCampaignAudienceView() {
      return campaignAudienceView;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setCampaignAudienceView(String campaignAudienceView) {
      this.campaignAudienceView = campaignAudienceView;
      return this;
    }

    private Builder(CampaignAudienceViewName campaignAudienceViewName) {
      this.customer = campaignAudienceViewName.customer;
      this.campaignAudienceView = campaignAudienceViewName.campaignAudienceView;
    }

    public CampaignAudienceViewName build() {
      return new CampaignAudienceViewName(this);
    }
  }
}
