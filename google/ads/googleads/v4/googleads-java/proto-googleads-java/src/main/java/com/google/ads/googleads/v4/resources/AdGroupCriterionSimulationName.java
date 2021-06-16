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
public class AdGroupCriterionSimulationName implements ResourceName {
  private static final PathTemplate CUSTOMER_AD_GROUP_CRITERION_SIMULATION =
      PathTemplate.createWithoutUrlEncoding(
          "customers/{customer}/adGroupCriterionSimulations/{ad_group_criterion_simulation}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String adGroupCriterionSimulation;

  @Deprecated
  protected AdGroupCriterionSimulationName() {
    customer = null;
    adGroupCriterionSimulation = null;
  }

  private AdGroupCriterionSimulationName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    adGroupCriterionSimulation =
        Preconditions.checkNotNull(builder.getAdGroupCriterionSimulation());
  }

  public String getCustomer() {
    return customer;
  }

  public String getAdGroupCriterionSimulation() {
    return adGroupCriterionSimulation;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static AdGroupCriterionSimulationName of(
      String customer, String adGroupCriterionSimulation) {
    return newBuilder()
        .setCustomer(customer)
        .setAdGroupCriterionSimulation(adGroupCriterionSimulation)
        .build();
  }

  public static String format(String customer, String adGroupCriterionSimulation) {
    return newBuilder()
        .setCustomer(customer)
        .setAdGroupCriterionSimulation(adGroupCriterionSimulation)
        .build()
        .toString();
  }

  public static AdGroupCriterionSimulationName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_AD_GROUP_CRITERION_SIMULATION.validatedMatch(
            formattedString,
            "AdGroupCriterionSimulationName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("ad_group_criterion_simulation"));
  }

  public static List<AdGroupCriterionSimulationName> parseList(List<String> formattedStrings) {
    List<AdGroupCriterionSimulationName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<AdGroupCriterionSimulationName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (AdGroupCriterionSimulationName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_AD_GROUP_CRITERION_SIMULATION.matches(formattedString);
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
          if (adGroupCriterionSimulation != null) {
            fieldMapBuilder.put("ad_group_criterion_simulation", adGroupCriterionSimulation);
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
    return CUSTOMER_AD_GROUP_CRITERION_SIMULATION.instantiate(
        "customer", customer, "ad_group_criterion_simulation", adGroupCriterionSimulation);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      AdGroupCriterionSimulationName that = ((AdGroupCriterionSimulationName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.adGroupCriterionSimulation, that.adGroupCriterionSimulation);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(adGroupCriterionSimulation);
    return h;
  }

  /**
   * Builder for customers/{customer}/adGroupCriterionSimulations/{ad_group_criterion_simulation}.
   */
  public static class Builder {
    private String customer;
    private String adGroupCriterionSimulation;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getAdGroupCriterionSimulation() {
      return adGroupCriterionSimulation;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setAdGroupCriterionSimulation(String adGroupCriterionSimulation) {
      this.adGroupCriterionSimulation = adGroupCriterionSimulation;
      return this;
    }

    private Builder(AdGroupCriterionSimulationName adGroupCriterionSimulationName) {
      this.customer = adGroupCriterionSimulationName.customer;
      this.adGroupCriterionSimulation = adGroupCriterionSimulationName.adGroupCriterionSimulation;
    }

    public AdGroupCriterionSimulationName build() {
      return new AdGroupCriterionSimulationName(this);
    }
  }
}
