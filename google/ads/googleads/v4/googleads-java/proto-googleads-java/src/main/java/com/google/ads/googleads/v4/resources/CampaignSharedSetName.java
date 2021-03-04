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
public class CampaignSharedSetName implements ResourceName {
  private static final PathTemplate CUSTOMER_CAMPAIGN_SHARED_SET =
      PathTemplate.createWithoutUrlEncoding(
          "customers/{customer}/campaignSharedSets/{campaign_shared_set}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String campaignSharedSet;

  @Deprecated
  protected CampaignSharedSetName() {
    customer = null;
    campaignSharedSet = null;
  }

  private CampaignSharedSetName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    campaignSharedSet = Preconditions.checkNotNull(builder.getCampaignSharedSet());
  }

  public String getCustomer() {
    return customer;
  }

  public String getCampaignSharedSet() {
    return campaignSharedSet;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static CampaignSharedSetName of(String customer, String campaignSharedSet) {
    return newBuilder().setCustomer(customer).setCampaignSharedSet(campaignSharedSet).build();
  }

  public static String format(String customer, String campaignSharedSet) {
    return newBuilder()
        .setCustomer(customer)
        .setCampaignSharedSet(campaignSharedSet)
        .build()
        .toString();
  }

  public static CampaignSharedSetName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_CAMPAIGN_SHARED_SET.validatedMatch(
            formattedString, "CampaignSharedSetName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("campaign_shared_set"));
  }

  public static List<CampaignSharedSetName> parseList(List<String> formattedStrings) {
    List<CampaignSharedSetName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<CampaignSharedSetName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (CampaignSharedSetName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_CAMPAIGN_SHARED_SET.matches(formattedString);
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
          if (campaignSharedSet != null) {
            fieldMapBuilder.put("campaign_shared_set", campaignSharedSet);
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
    return CUSTOMER_CAMPAIGN_SHARED_SET.instantiate(
        "customer", customer, "campaign_shared_set", campaignSharedSet);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      CampaignSharedSetName that = ((CampaignSharedSetName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.campaignSharedSet, that.campaignSharedSet);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(campaignSharedSet);
    return h;
  }

  /** Builder for customers/{customer}/campaignSharedSets/{campaign_shared_set}. */
  public static class Builder {
    private String customer;
    private String campaignSharedSet;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getCampaignSharedSet() {
      return campaignSharedSet;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setCampaignSharedSet(String campaignSharedSet) {
      this.campaignSharedSet = campaignSharedSet;
      return this;
    }

    private Builder(CampaignSharedSetName campaignSharedSetName) {
      customer = campaignSharedSetName.customer;
      campaignSharedSet = campaignSharedSetName.campaignSharedSet;
    }

    public CampaignSharedSetName build() {
      return new CampaignSharedSetName(this);
    }
  }
}
