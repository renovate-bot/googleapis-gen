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
public class AdParameterName implements ResourceName {
  private static final PathTemplate CUSTOMER_AD_PARAMETER =
      PathTemplate.createWithoutUrlEncoding("customers/{customer}/adParameters/{ad_parameter}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String adParameter;

  @Deprecated
  protected AdParameterName() {
    customer = null;
    adParameter = null;
  }

  private AdParameterName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    adParameter = Preconditions.checkNotNull(builder.getAdParameter());
  }

  public String getCustomer() {
    return customer;
  }

  public String getAdParameter() {
    return adParameter;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static AdParameterName of(String customer, String adParameter) {
    return newBuilder().setCustomer(customer).setAdParameter(adParameter).build();
  }

  public static String format(String customer, String adParameter) {
    return newBuilder().setCustomer(customer).setAdParameter(adParameter).build().toString();
  }

  public static AdParameterName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_AD_PARAMETER.validatedMatch(
            formattedString, "AdParameterName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("ad_parameter"));
  }

  public static List<AdParameterName> parseList(List<String> formattedStrings) {
    List<AdParameterName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<AdParameterName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (AdParameterName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_AD_PARAMETER.matches(formattedString);
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
          if (adParameter != null) {
            fieldMapBuilder.put("ad_parameter", adParameter);
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
    return CUSTOMER_AD_PARAMETER.instantiate("customer", customer, "ad_parameter", adParameter);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      AdParameterName that = ((AdParameterName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.adParameter, that.adParameter);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(adParameter);
    return h;
  }

  /** Builder for customers/{customer}/adParameters/{ad_parameter}. */
  public static class Builder {
    private String customer;
    private String adParameter;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getAdParameter() {
      return adParameter;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setAdParameter(String adParameter) {
      this.adParameter = adParameter;
      return this;
    }

    private Builder(AdParameterName adParameterName) {
      customer = adParameterName.customer;
      adParameter = adParameterName.adParameter;
    }

    public AdParameterName build() {
      return new AdParameterName(this);
    }
  }
}
