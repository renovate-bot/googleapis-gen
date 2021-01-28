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
public class AdGroupCriterionLabelName implements ResourceName {
  private static final PathTemplate CUSTOMER_AD_GROUP_CRITERION_LABEL =
      PathTemplate.createWithoutUrlEncoding(
          "customers/{customer}/adGroupCriterionLabels/{ad_group_criterion_label}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String adGroupCriterionLabel;

  @Deprecated
  protected AdGroupCriterionLabelName() {
    customer = null;
    adGroupCriterionLabel = null;
  }

  private AdGroupCriterionLabelName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    adGroupCriterionLabel = Preconditions.checkNotNull(builder.getAdGroupCriterionLabel());
  }

  public String getCustomer() {
    return customer;
  }

  public String getAdGroupCriterionLabel() {
    return adGroupCriterionLabel;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static AdGroupCriterionLabelName of(String customer, String adGroupCriterionLabel) {
    return newBuilder()
        .setCustomer(customer)
        .setAdGroupCriterionLabel(adGroupCriterionLabel)
        .build();
  }

  public static String format(String customer, String adGroupCriterionLabel) {
    return newBuilder()
        .setCustomer(customer)
        .setAdGroupCriterionLabel(adGroupCriterionLabel)
        .build()
        .toString();
  }

  public static AdGroupCriterionLabelName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_AD_GROUP_CRITERION_LABEL.validatedMatch(
            formattedString,
            "AdGroupCriterionLabelName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("ad_group_criterion_label"));
  }

  public static List<AdGroupCriterionLabelName> parseList(List<String> formattedStrings) {
    List<AdGroupCriterionLabelName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<AdGroupCriterionLabelName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (AdGroupCriterionLabelName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_AD_GROUP_CRITERION_LABEL.matches(formattedString);
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
          if (adGroupCriterionLabel != null) {
            fieldMapBuilder.put("ad_group_criterion_label", adGroupCriterionLabel);
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
    return CUSTOMER_AD_GROUP_CRITERION_LABEL.instantiate(
        "customer", customer, "ad_group_criterion_label", adGroupCriterionLabel);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      AdGroupCriterionLabelName that = ((AdGroupCriterionLabelName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.adGroupCriterionLabel, that.adGroupCriterionLabel);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(adGroupCriterionLabel);
    return h;
  }

  /** Builder for customers/{customer}/adGroupCriterionLabels/{ad_group_criterion_label}. */
  public static class Builder {
    private String customer;
    private String adGroupCriterionLabel;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getAdGroupCriterionLabel() {
      return adGroupCriterionLabel;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setAdGroupCriterionLabel(String adGroupCriterionLabel) {
      this.adGroupCriterionLabel = adGroupCriterionLabel;
      return this;
    }

    private Builder(AdGroupCriterionLabelName adGroupCriterionLabelName) {
      customer = adGroupCriterionLabelName.customer;
      adGroupCriterionLabel = adGroupCriterionLabelName.adGroupCriterionLabel;
    }

    public AdGroupCriterionLabelName build() {
      return new AdGroupCriterionLabelName(this);
    }
  }
}
