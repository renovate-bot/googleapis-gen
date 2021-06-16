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
public class AdGroupLabelName implements ResourceName {
  private static final PathTemplate CUSTOMER_AD_GROUP_LABEL =
      PathTemplate.createWithoutUrlEncoding("customers/{customer}/adGroupLabels/{ad_group_label}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String adGroupLabel;

  @Deprecated
  protected AdGroupLabelName() {
    customer = null;
    adGroupLabel = null;
  }

  private AdGroupLabelName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    adGroupLabel = Preconditions.checkNotNull(builder.getAdGroupLabel());
  }

  public String getCustomer() {
    return customer;
  }

  public String getAdGroupLabel() {
    return adGroupLabel;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static AdGroupLabelName of(String customer, String adGroupLabel) {
    return newBuilder().setCustomer(customer).setAdGroupLabel(adGroupLabel).build();
  }

  public static String format(String customer, String adGroupLabel) {
    return newBuilder().setCustomer(customer).setAdGroupLabel(adGroupLabel).build().toString();
  }

  public static AdGroupLabelName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_AD_GROUP_LABEL.validatedMatch(
            formattedString, "AdGroupLabelName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("ad_group_label"));
  }

  public static List<AdGroupLabelName> parseList(List<String> formattedStrings) {
    List<AdGroupLabelName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<AdGroupLabelName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (AdGroupLabelName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_AD_GROUP_LABEL.matches(formattedString);
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
          if (adGroupLabel != null) {
            fieldMapBuilder.put("ad_group_label", adGroupLabel);
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
    return CUSTOMER_AD_GROUP_LABEL.instantiate(
        "customer", customer, "ad_group_label", adGroupLabel);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      AdGroupLabelName that = ((AdGroupLabelName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.adGroupLabel, that.adGroupLabel);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(adGroupLabel);
    return h;
  }

  /** Builder for customers/{customer}/adGroupLabels/{ad_group_label}. */
  public static class Builder {
    private String customer;
    private String adGroupLabel;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getAdGroupLabel() {
      return adGroupLabel;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setAdGroupLabel(String adGroupLabel) {
      this.adGroupLabel = adGroupLabel;
      return this;
    }

    private Builder(AdGroupLabelName adGroupLabelName) {
      this.customer = adGroupLabelName.customer;
      this.adGroupLabel = adGroupLabelName.adGroupLabel;
    }

    public AdGroupLabelName build() {
      return new AdGroupLabelName(this);
    }
  }
}
