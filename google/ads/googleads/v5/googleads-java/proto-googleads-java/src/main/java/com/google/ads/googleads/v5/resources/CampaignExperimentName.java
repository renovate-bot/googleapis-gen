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
public class CampaignExperimentName implements ResourceName {
  private static final PathTemplate CUSTOMER_CAMPAIGN_EXPERIMENT =
      PathTemplate.createWithoutUrlEncoding(
          "customers/{customer}/campaignExperiments/{campaign_experiment}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String campaignExperiment;

  @Deprecated
  protected CampaignExperimentName() {
    customer = null;
    campaignExperiment = null;
  }

  private CampaignExperimentName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    campaignExperiment = Preconditions.checkNotNull(builder.getCampaignExperiment());
  }

  public String getCustomer() {
    return customer;
  }

  public String getCampaignExperiment() {
    return campaignExperiment;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static CampaignExperimentName of(String customer, String campaignExperiment) {
    return newBuilder().setCustomer(customer).setCampaignExperiment(campaignExperiment).build();
  }

  public static String format(String customer, String campaignExperiment) {
    return newBuilder()
        .setCustomer(customer)
        .setCampaignExperiment(campaignExperiment)
        .build()
        .toString();
  }

  public static CampaignExperimentName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_CAMPAIGN_EXPERIMENT.validatedMatch(
            formattedString, "CampaignExperimentName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("campaign_experiment"));
  }

  public static List<CampaignExperimentName> parseList(List<String> formattedStrings) {
    List<CampaignExperimentName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<CampaignExperimentName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (CampaignExperimentName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_CAMPAIGN_EXPERIMENT.matches(formattedString);
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
          if (campaignExperiment != null) {
            fieldMapBuilder.put("campaign_experiment", campaignExperiment);
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
    return CUSTOMER_CAMPAIGN_EXPERIMENT.instantiate(
        "customer", customer, "campaign_experiment", campaignExperiment);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      CampaignExperimentName that = ((CampaignExperimentName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.campaignExperiment, that.campaignExperiment);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(campaignExperiment);
    return h;
  }

  /** Builder for customers/{customer}/campaignExperiments/{campaign_experiment}. */
  public static class Builder {
    private String customer;
    private String campaignExperiment;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getCampaignExperiment() {
      return campaignExperiment;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setCampaignExperiment(String campaignExperiment) {
      this.campaignExperiment = campaignExperiment;
      return this;
    }

    private Builder(CampaignExperimentName campaignExperimentName) {
      customer = campaignExperimentName.customer;
      campaignExperiment = campaignExperimentName.campaignExperiment;
    }

    public CampaignExperimentName build() {
      return new CampaignExperimentName(this);
    }
  }
}
