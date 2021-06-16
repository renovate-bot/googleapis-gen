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
public class AdGroupSimulationName implements ResourceName {
  private static final PathTemplate CUSTOMER_AD_GROUP_SIMULATION =
      PathTemplate.createWithoutUrlEncoding(
          "customers/{customer}/adGroupSimulations/{ad_group_simulation}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String adGroupSimulation;

  @Deprecated
  protected AdGroupSimulationName() {
    customer = null;
    adGroupSimulation = null;
  }

  private AdGroupSimulationName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    adGroupSimulation = Preconditions.checkNotNull(builder.getAdGroupSimulation());
  }

  public String getCustomer() {
    return customer;
  }

  public String getAdGroupSimulation() {
    return adGroupSimulation;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static AdGroupSimulationName of(String customer, String adGroupSimulation) {
    return newBuilder().setCustomer(customer).setAdGroupSimulation(adGroupSimulation).build();
  }

  public static String format(String customer, String adGroupSimulation) {
    return newBuilder()
        .setCustomer(customer)
        .setAdGroupSimulation(adGroupSimulation)
        .build()
        .toString();
  }

  public static AdGroupSimulationName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_AD_GROUP_SIMULATION.validatedMatch(
            formattedString, "AdGroupSimulationName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("ad_group_simulation"));
  }

  public static List<AdGroupSimulationName> parseList(List<String> formattedStrings) {
    List<AdGroupSimulationName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<AdGroupSimulationName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (AdGroupSimulationName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_AD_GROUP_SIMULATION.matches(formattedString);
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
          if (adGroupSimulation != null) {
            fieldMapBuilder.put("ad_group_simulation", adGroupSimulation);
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
    return CUSTOMER_AD_GROUP_SIMULATION.instantiate(
        "customer", customer, "ad_group_simulation", adGroupSimulation);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      AdGroupSimulationName that = ((AdGroupSimulationName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.adGroupSimulation, that.adGroupSimulation);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(adGroupSimulation);
    return h;
  }

  /** Builder for customers/{customer}/adGroupSimulations/{ad_group_simulation}. */
  public static class Builder {
    private String customer;
    private String adGroupSimulation;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getAdGroupSimulation() {
      return adGroupSimulation;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setAdGroupSimulation(String adGroupSimulation) {
      this.adGroupSimulation = adGroupSimulation;
      return this;
    }

    private Builder(AdGroupSimulationName adGroupSimulationName) {
      this.customer = adGroupSimulationName.customer;
      this.adGroupSimulation = adGroupSimulationName.adGroupSimulation;
    }

    public AdGroupSimulationName build() {
      return new AdGroupSimulationName(this);
    }
  }
}
