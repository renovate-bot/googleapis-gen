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

package com.google.ads.googleads.v3.resources;

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
public class CampaignCriterionSimulationName implements ResourceName {
  private static final PathTemplate CUSTOMER_CAMPAIGN_CRITERION_SIMULATION =
      PathTemplate.createWithoutUrlEncoding(
          "customers/{customer}/campaignCriterionSimulations/{campaign_criterion_simulation}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String campaignCriterionSimulation;

  @Deprecated
  protected CampaignCriterionSimulationName() {
    customer = null;
    campaignCriterionSimulation = null;
  }

  private CampaignCriterionSimulationName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    campaignCriterionSimulation =
        Preconditions.checkNotNull(builder.getCampaignCriterionSimulation());
  }

  public String getCustomer() {
    return customer;
  }

  public String getCampaignCriterionSimulation() {
    return campaignCriterionSimulation;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static CampaignCriterionSimulationName of(
      String customer, String campaignCriterionSimulation) {
    return newBuilder()
        .setCustomer(customer)
        .setCampaignCriterionSimulation(campaignCriterionSimulation)
        .build();
  }

  public static String format(String customer, String campaignCriterionSimulation) {
    return newBuilder()
        .setCustomer(customer)
        .setCampaignCriterionSimulation(campaignCriterionSimulation)
        .build()
        .toString();
  }

  public static CampaignCriterionSimulationName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_CAMPAIGN_CRITERION_SIMULATION.validatedMatch(
            formattedString,
            "CampaignCriterionSimulationName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("campaign_criterion_simulation"));
  }

  public static List<CampaignCriterionSimulationName> parseList(List<String> formattedStrings) {
    List<CampaignCriterionSimulationName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<CampaignCriterionSimulationName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (CampaignCriterionSimulationName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_CAMPAIGN_CRITERION_SIMULATION.matches(formattedString);
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
          if (campaignCriterionSimulation != null) {
            fieldMapBuilder.put("campaign_criterion_simulation", campaignCriterionSimulation);
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
    return CUSTOMER_CAMPAIGN_CRITERION_SIMULATION.instantiate(
        "customer", customer, "campaign_criterion_simulation", campaignCriterionSimulation);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      CampaignCriterionSimulationName that = ((CampaignCriterionSimulationName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.campaignCriterionSimulation, that.campaignCriterionSimulation);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(campaignCriterionSimulation);
    return h;
  }

  /**
   * Builder for customers/{customer}/campaignCriterionSimulations/{campaign_criterion_simulation}.
   */
  public static class Builder {
    private String customer;
    private String campaignCriterionSimulation;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getCampaignCriterionSimulation() {
      return campaignCriterionSimulation;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setCampaignCriterionSimulation(String campaignCriterionSimulation) {
      this.campaignCriterionSimulation = campaignCriterionSimulation;
      return this;
    }

    private Builder(CampaignCriterionSimulationName campaignCriterionSimulationName) {
      customer = campaignCriterionSimulationName.customer;
      campaignCriterionSimulation = campaignCriterionSimulationName.campaignCriterionSimulation;
    }

    public CampaignCriterionSimulationName build() {
      return new CampaignCriterionSimulationName(this);
    }
  }
}
