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
public class CampaignLabelName implements ResourceName {
  private static final PathTemplate CUSTOMER_CAMPAIGN_LABEL =
      PathTemplate.createWithoutUrlEncoding("customers/{customer}/campaignLabels/{campaign_label}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String campaignLabel;

  @Deprecated
  protected CampaignLabelName() {
    customer = null;
    campaignLabel = null;
  }

  private CampaignLabelName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    campaignLabel = Preconditions.checkNotNull(builder.getCampaignLabel());
  }

  public String getCustomer() {
    return customer;
  }

  public String getCampaignLabel() {
    return campaignLabel;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static CampaignLabelName of(String customer, String campaignLabel) {
    return newBuilder().setCustomer(customer).setCampaignLabel(campaignLabel).build();
  }

  public static String format(String customer, String campaignLabel) {
    return newBuilder().setCustomer(customer).setCampaignLabel(campaignLabel).build().toString();
  }

  public static CampaignLabelName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_CAMPAIGN_LABEL.validatedMatch(
            formattedString, "CampaignLabelName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("campaign_label"));
  }

  public static List<CampaignLabelName> parseList(List<String> formattedStrings) {
    List<CampaignLabelName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<CampaignLabelName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (CampaignLabelName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_CAMPAIGN_LABEL.matches(formattedString);
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
          if (campaignLabel != null) {
            fieldMapBuilder.put("campaign_label", campaignLabel);
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
    return CUSTOMER_CAMPAIGN_LABEL.instantiate(
        "customer", customer, "campaign_label", campaignLabel);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      CampaignLabelName that = ((CampaignLabelName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.campaignLabel, that.campaignLabel);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(campaignLabel);
    return h;
  }

  /** Builder for customers/{customer}/campaignLabels/{campaign_label}. */
  public static class Builder {
    private String customer;
    private String campaignLabel;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getCampaignLabel() {
      return campaignLabel;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setCampaignLabel(String campaignLabel) {
      this.campaignLabel = campaignLabel;
      return this;
    }

    private Builder(CampaignLabelName campaignLabelName) {
      this.customer = campaignLabelName.customer;
      this.campaignLabel = campaignLabelName.campaignLabel;
    }

    public CampaignLabelName build() {
      return new CampaignLabelName(this);
    }
  }
}
