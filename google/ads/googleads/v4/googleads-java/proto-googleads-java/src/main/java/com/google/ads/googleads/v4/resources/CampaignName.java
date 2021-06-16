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
public class CampaignName implements ResourceName {
  private static final PathTemplate CUSTOMER_CAMPAIGN =
      PathTemplate.createWithoutUrlEncoding("customers/{customer}/campaigns/{campaign}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String campaign;

  @Deprecated
  protected CampaignName() {
    customer = null;
    campaign = null;
  }

  private CampaignName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    campaign = Preconditions.checkNotNull(builder.getCampaign());
  }

  public String getCustomer() {
    return customer;
  }

  public String getCampaign() {
    return campaign;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static CampaignName of(String customer, String campaign) {
    return newBuilder().setCustomer(customer).setCampaign(campaign).build();
  }

  public static String format(String customer, String campaign) {
    return newBuilder().setCustomer(customer).setCampaign(campaign).build().toString();
  }

  public static CampaignName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_CAMPAIGN.validatedMatch(
            formattedString, "CampaignName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("campaign"));
  }

  public static List<CampaignName> parseList(List<String> formattedStrings) {
    List<CampaignName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<CampaignName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (CampaignName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_CAMPAIGN.matches(formattedString);
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
          if (campaign != null) {
            fieldMapBuilder.put("campaign", campaign);
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
    return CUSTOMER_CAMPAIGN.instantiate("customer", customer, "campaign", campaign);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      CampaignName that = ((CampaignName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.campaign, that.campaign);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(campaign);
    return h;
  }

  /** Builder for customers/{customer}/campaigns/{campaign}. */
  public static class Builder {
    private String customer;
    private String campaign;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getCampaign() {
      return campaign;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setCampaign(String campaign) {
      this.campaign = campaign;
      return this;
    }

    private Builder(CampaignName campaignName) {
      this.customer = campaignName.customer;
      this.campaign = campaignName.campaign;
    }

    public CampaignName build() {
      return new CampaignName(this);
    }
  }
}
