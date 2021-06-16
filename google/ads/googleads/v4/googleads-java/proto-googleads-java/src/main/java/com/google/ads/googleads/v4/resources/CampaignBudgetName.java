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
public class CampaignBudgetName implements ResourceName {
  private static final PathTemplate CUSTOMER_CAMPAIGN_BUDGET =
      PathTemplate.createWithoutUrlEncoding(
          "customers/{customer}/campaignBudgets/{campaign_budget}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String campaignBudget;

  @Deprecated
  protected CampaignBudgetName() {
    customer = null;
    campaignBudget = null;
  }

  private CampaignBudgetName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    campaignBudget = Preconditions.checkNotNull(builder.getCampaignBudget());
  }

  public String getCustomer() {
    return customer;
  }

  public String getCampaignBudget() {
    return campaignBudget;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static CampaignBudgetName of(String customer, String campaignBudget) {
    return newBuilder().setCustomer(customer).setCampaignBudget(campaignBudget).build();
  }

  public static String format(String customer, String campaignBudget) {
    return newBuilder().setCustomer(customer).setCampaignBudget(campaignBudget).build().toString();
  }

  public static CampaignBudgetName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_CAMPAIGN_BUDGET.validatedMatch(
            formattedString, "CampaignBudgetName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("campaign_budget"));
  }

  public static List<CampaignBudgetName> parseList(List<String> formattedStrings) {
    List<CampaignBudgetName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<CampaignBudgetName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (CampaignBudgetName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_CAMPAIGN_BUDGET.matches(formattedString);
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
          if (campaignBudget != null) {
            fieldMapBuilder.put("campaign_budget", campaignBudget);
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
    return CUSTOMER_CAMPAIGN_BUDGET.instantiate(
        "customer", customer, "campaign_budget", campaignBudget);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      CampaignBudgetName that = ((CampaignBudgetName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.campaignBudget, that.campaignBudget);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(campaignBudget);
    return h;
  }

  /** Builder for customers/{customer}/campaignBudgets/{campaign_budget}. */
  public static class Builder {
    private String customer;
    private String campaignBudget;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getCampaignBudget() {
      return campaignBudget;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setCampaignBudget(String campaignBudget) {
      this.campaignBudget = campaignBudget;
      return this;
    }

    private Builder(CampaignBudgetName campaignBudgetName) {
      this.customer = campaignBudgetName.customer;
      this.campaignBudget = campaignBudgetName.campaignBudget;
    }

    public CampaignBudgetName build() {
      return new CampaignBudgetName(this);
    }
  }
}
