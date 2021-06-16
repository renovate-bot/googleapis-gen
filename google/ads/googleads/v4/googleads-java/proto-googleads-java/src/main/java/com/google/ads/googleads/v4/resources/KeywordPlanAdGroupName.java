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
public class KeywordPlanAdGroupName implements ResourceName {
  private static final PathTemplate CUSTOMER_KEYWORD_PLAN_AD_GROUP =
      PathTemplate.createWithoutUrlEncoding(
          "customers/{customer}/keywordPlanAdGroups/{keyword_plan_ad_group}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String keywordPlanAdGroup;

  @Deprecated
  protected KeywordPlanAdGroupName() {
    customer = null;
    keywordPlanAdGroup = null;
  }

  private KeywordPlanAdGroupName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    keywordPlanAdGroup = Preconditions.checkNotNull(builder.getKeywordPlanAdGroup());
  }

  public String getCustomer() {
    return customer;
  }

  public String getKeywordPlanAdGroup() {
    return keywordPlanAdGroup;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static KeywordPlanAdGroupName of(String customer, String keywordPlanAdGroup) {
    return newBuilder().setCustomer(customer).setKeywordPlanAdGroup(keywordPlanAdGroup).build();
  }

  public static String format(String customer, String keywordPlanAdGroup) {
    return newBuilder()
        .setCustomer(customer)
        .setKeywordPlanAdGroup(keywordPlanAdGroup)
        .build()
        .toString();
  }

  public static KeywordPlanAdGroupName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_KEYWORD_PLAN_AD_GROUP.validatedMatch(
            formattedString, "KeywordPlanAdGroupName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("keyword_plan_ad_group"));
  }

  public static List<KeywordPlanAdGroupName> parseList(List<String> formattedStrings) {
    List<KeywordPlanAdGroupName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<KeywordPlanAdGroupName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (KeywordPlanAdGroupName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_KEYWORD_PLAN_AD_GROUP.matches(formattedString);
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
          if (keywordPlanAdGroup != null) {
            fieldMapBuilder.put("keyword_plan_ad_group", keywordPlanAdGroup);
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
    return CUSTOMER_KEYWORD_PLAN_AD_GROUP.instantiate(
        "customer", customer, "keyword_plan_ad_group", keywordPlanAdGroup);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      KeywordPlanAdGroupName that = ((KeywordPlanAdGroupName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.keywordPlanAdGroup, that.keywordPlanAdGroup);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(keywordPlanAdGroup);
    return h;
  }

  /** Builder for customers/{customer}/keywordPlanAdGroups/{keyword_plan_ad_group}. */
  public static class Builder {
    private String customer;
    private String keywordPlanAdGroup;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getKeywordPlanAdGroup() {
      return keywordPlanAdGroup;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setKeywordPlanAdGroup(String keywordPlanAdGroup) {
      this.keywordPlanAdGroup = keywordPlanAdGroup;
      return this;
    }

    private Builder(KeywordPlanAdGroupName keywordPlanAdGroupName) {
      this.customer = keywordPlanAdGroupName.customer;
      this.keywordPlanAdGroup = keywordPlanAdGroupName.keywordPlanAdGroup;
    }

    public KeywordPlanAdGroupName build() {
      return new KeywordPlanAdGroupName(this);
    }
  }
}
