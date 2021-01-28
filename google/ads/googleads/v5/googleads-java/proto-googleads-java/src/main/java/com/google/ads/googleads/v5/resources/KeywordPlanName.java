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
public class KeywordPlanName implements ResourceName {
  private static final PathTemplate CUSTOMER_KEYWORD_PLAN =
      PathTemplate.createWithoutUrlEncoding("customers/{customer}/keywordPlans/{keyword_plan}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String keywordPlan;

  @Deprecated
  protected KeywordPlanName() {
    customer = null;
    keywordPlan = null;
  }

  private KeywordPlanName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    keywordPlan = Preconditions.checkNotNull(builder.getKeywordPlan());
  }

  public String getCustomer() {
    return customer;
  }

  public String getKeywordPlan() {
    return keywordPlan;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static KeywordPlanName of(String customer, String keywordPlan) {
    return newBuilder().setCustomer(customer).setKeywordPlan(keywordPlan).build();
  }

  public static String format(String customer, String keywordPlan) {
    return newBuilder().setCustomer(customer).setKeywordPlan(keywordPlan).build().toString();
  }

  public static KeywordPlanName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_KEYWORD_PLAN.validatedMatch(
            formattedString, "KeywordPlanName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("keyword_plan"));
  }

  public static List<KeywordPlanName> parseList(List<String> formattedStrings) {
    List<KeywordPlanName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<KeywordPlanName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (KeywordPlanName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_KEYWORD_PLAN.matches(formattedString);
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
          if (keywordPlan != null) {
            fieldMapBuilder.put("keyword_plan", keywordPlan);
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
    return CUSTOMER_KEYWORD_PLAN.instantiate("customer", customer, "keyword_plan", keywordPlan);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      KeywordPlanName that = ((KeywordPlanName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.keywordPlan, that.keywordPlan);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(keywordPlan);
    return h;
  }

  /** Builder for customers/{customer}/keywordPlans/{keyword_plan}. */
  public static class Builder {
    private String customer;
    private String keywordPlan;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getKeywordPlan() {
      return keywordPlan;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setKeywordPlan(String keywordPlan) {
      this.keywordPlan = keywordPlan;
      return this;
    }

    private Builder(KeywordPlanName keywordPlanName) {
      customer = keywordPlanName.customer;
      keywordPlan = keywordPlanName.keywordPlan;
    }

    public KeywordPlanName build() {
      return new KeywordPlanName(this);
    }
  }
}
