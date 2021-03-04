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
public class CampaignAssetName implements ResourceName {
  private static final PathTemplate CUSTOMER_CAMPAIGN_ASSET =
      PathTemplate.createWithoutUrlEncoding("customers/{customer}/campaignAssets/{campaign_asset}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String campaignAsset;

  @Deprecated
  protected CampaignAssetName() {
    customer = null;
    campaignAsset = null;
  }

  private CampaignAssetName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    campaignAsset = Preconditions.checkNotNull(builder.getCampaignAsset());
  }

  public String getCustomer() {
    return customer;
  }

  public String getCampaignAsset() {
    return campaignAsset;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static CampaignAssetName of(String customer, String campaignAsset) {
    return newBuilder().setCustomer(customer).setCampaignAsset(campaignAsset).build();
  }

  public static String format(String customer, String campaignAsset) {
    return newBuilder().setCustomer(customer).setCampaignAsset(campaignAsset).build().toString();
  }

  public static CampaignAssetName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_CAMPAIGN_ASSET.validatedMatch(
            formattedString, "CampaignAssetName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("campaign_asset"));
  }

  public static List<CampaignAssetName> parseList(List<String> formattedStrings) {
    List<CampaignAssetName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<CampaignAssetName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (CampaignAssetName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_CAMPAIGN_ASSET.matches(formattedString);
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
          if (campaignAsset != null) {
            fieldMapBuilder.put("campaign_asset", campaignAsset);
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
    return CUSTOMER_CAMPAIGN_ASSET.instantiate(
        "customer", customer, "campaign_asset", campaignAsset);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      CampaignAssetName that = ((CampaignAssetName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.campaignAsset, that.campaignAsset);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(campaignAsset);
    return h;
  }

  /** Builder for customers/{customer}/campaignAssets/{campaign_asset}. */
  public static class Builder {
    private String customer;
    private String campaignAsset;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getCampaignAsset() {
      return campaignAsset;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setCampaignAsset(String campaignAsset) {
      this.campaignAsset = campaignAsset;
      return this;
    }

    private Builder(CampaignAssetName campaignAssetName) {
      customer = campaignAssetName.customer;
      campaignAsset = campaignAssetName.campaignAsset;
    }

    public CampaignAssetName build() {
      return new CampaignAssetName(this);
    }
  }
}
