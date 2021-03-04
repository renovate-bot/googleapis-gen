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
public class CampaignCriterionName implements ResourceName {
  private static final PathTemplate CUSTOMER_CAMPAIGN_CRITERION =
      PathTemplate.createWithoutUrlEncoding(
          "customers/{customer}/campaignCriteria/{campaign_criterion}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String campaignCriterion;

  @Deprecated
  protected CampaignCriterionName() {
    customer = null;
    campaignCriterion = null;
  }

  private CampaignCriterionName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    campaignCriterion = Preconditions.checkNotNull(builder.getCampaignCriterion());
  }

  public String getCustomer() {
    return customer;
  }

  public String getCampaignCriterion() {
    return campaignCriterion;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static CampaignCriterionName of(String customer, String campaignCriterion) {
    return newBuilder().setCustomer(customer).setCampaignCriterion(campaignCriterion).build();
  }

  public static String format(String customer, String campaignCriterion) {
    return newBuilder()
        .setCustomer(customer)
        .setCampaignCriterion(campaignCriterion)
        .build()
        .toString();
  }

  public static CampaignCriterionName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_CAMPAIGN_CRITERION.validatedMatch(
            formattedString, "CampaignCriterionName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("campaign_criterion"));
  }

  public static List<CampaignCriterionName> parseList(List<String> formattedStrings) {
    List<CampaignCriterionName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<CampaignCriterionName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (CampaignCriterionName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_CAMPAIGN_CRITERION.matches(formattedString);
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
          if (campaignCriterion != null) {
            fieldMapBuilder.put("campaign_criterion", campaignCriterion);
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
    return CUSTOMER_CAMPAIGN_CRITERION.instantiate(
        "customer", customer, "campaign_criterion", campaignCriterion);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      CampaignCriterionName that = ((CampaignCriterionName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.campaignCriterion, that.campaignCriterion);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(campaignCriterion);
    return h;
  }

  /** Builder for customers/{customer}/campaignCriteria/{campaign_criterion}. */
  public static class Builder {
    private String customer;
    private String campaignCriterion;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getCampaignCriterion() {
      return campaignCriterion;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setCampaignCriterion(String campaignCriterion) {
      this.campaignCriterion = campaignCriterion;
      return this;
    }

    private Builder(CampaignCriterionName campaignCriterionName) {
      customer = campaignCriterionName.customer;
      campaignCriterion = campaignCriterionName.campaignCriterion;
    }

    public CampaignCriterionName build() {
      return new CampaignCriterionName(this);
    }
  }
}
