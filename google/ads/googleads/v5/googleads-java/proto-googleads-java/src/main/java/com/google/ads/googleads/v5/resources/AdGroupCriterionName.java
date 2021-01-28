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
public class AdGroupCriterionName implements ResourceName {
  private static final PathTemplate CUSTOMER_AD_GROUP_CRITERION =
      PathTemplate.createWithoutUrlEncoding(
          "customers/{customer}/adGroupCriteria/{ad_group_criterion}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String adGroupCriterion;

  @Deprecated
  protected AdGroupCriterionName() {
    customer = null;
    adGroupCriterion = null;
  }

  private AdGroupCriterionName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    adGroupCriterion = Preconditions.checkNotNull(builder.getAdGroupCriterion());
  }

  public String getCustomer() {
    return customer;
  }

  public String getAdGroupCriterion() {
    return adGroupCriterion;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static AdGroupCriterionName of(String customer, String adGroupCriterion) {
    return newBuilder().setCustomer(customer).setAdGroupCriterion(adGroupCriterion).build();
  }

  public static String format(String customer, String adGroupCriterion) {
    return newBuilder()
        .setCustomer(customer)
        .setAdGroupCriterion(adGroupCriterion)
        .build()
        .toString();
  }

  public static AdGroupCriterionName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_AD_GROUP_CRITERION.validatedMatch(
            formattedString, "AdGroupCriterionName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("ad_group_criterion"));
  }

  public static List<AdGroupCriterionName> parseList(List<String> formattedStrings) {
    List<AdGroupCriterionName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<AdGroupCriterionName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (AdGroupCriterionName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_AD_GROUP_CRITERION.matches(formattedString);
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
          if (adGroupCriterion != null) {
            fieldMapBuilder.put("ad_group_criterion", adGroupCriterion);
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
    return CUSTOMER_AD_GROUP_CRITERION.instantiate(
        "customer", customer, "ad_group_criterion", adGroupCriterion);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      AdGroupCriterionName that = ((AdGroupCriterionName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.adGroupCriterion, that.adGroupCriterion);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(adGroupCriterion);
    return h;
  }

  /** Builder for customers/{customer}/adGroupCriteria/{ad_group_criterion}. */
  public static class Builder {
    private String customer;
    private String adGroupCriterion;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getAdGroupCriterion() {
      return adGroupCriterion;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setAdGroupCriterion(String adGroupCriterion) {
      this.adGroupCriterion = adGroupCriterion;
      return this;
    }

    private Builder(AdGroupCriterionName adGroupCriterionName) {
      customer = adGroupCriterionName.customer;
      adGroupCriterion = adGroupCriterionName.adGroupCriterion;
    }

    public AdGroupCriterionName build() {
      return new AdGroupCriterionName(this);
    }
  }
}
