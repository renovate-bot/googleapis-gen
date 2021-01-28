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
public class KeywordPlanNegativeKeywordName implements ResourceName {
  private static final PathTemplate CUSTOMER_KEYWORD_PLAN_NEGATIVE_KEYWORD =
      PathTemplate.createWithoutUrlEncoding(
          "customers/{customer}/keywordPlanNegativeKeywords/{keyword_plan_negative_keyword}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String keywordPlanNegativeKeyword;

  @Deprecated
  protected KeywordPlanNegativeKeywordName() {
    customer = null;
    keywordPlanNegativeKeyword = null;
  }

  private KeywordPlanNegativeKeywordName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    keywordPlanNegativeKeyword =
        Preconditions.checkNotNull(builder.getKeywordPlanNegativeKeyword());
  }

  public String getCustomer() {
    return customer;
  }

  public String getKeywordPlanNegativeKeyword() {
    return keywordPlanNegativeKeyword;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static KeywordPlanNegativeKeywordName of(
      String customer, String keywordPlanNegativeKeyword) {
    return newBuilder()
        .setCustomer(customer)
        .setKeywordPlanNegativeKeyword(keywordPlanNegativeKeyword)
        .build();
  }

  public static String format(String customer, String keywordPlanNegativeKeyword) {
    return newBuilder()
        .setCustomer(customer)
        .setKeywordPlanNegativeKeyword(keywordPlanNegativeKeyword)
        .build()
        .toString();
  }

  public static KeywordPlanNegativeKeywordName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_KEYWORD_PLAN_NEGATIVE_KEYWORD.validatedMatch(
            formattedString,
            "KeywordPlanNegativeKeywordName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("keyword_plan_negative_keyword"));
  }

  public static List<KeywordPlanNegativeKeywordName> parseList(List<String> formattedStrings) {
    List<KeywordPlanNegativeKeywordName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<KeywordPlanNegativeKeywordName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (KeywordPlanNegativeKeywordName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_KEYWORD_PLAN_NEGATIVE_KEYWORD.matches(formattedString);
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
          if (keywordPlanNegativeKeyword != null) {
            fieldMapBuilder.put("keyword_plan_negative_keyword", keywordPlanNegativeKeyword);
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
    return CUSTOMER_KEYWORD_PLAN_NEGATIVE_KEYWORD.instantiate(
        "customer", customer, "keyword_plan_negative_keyword", keywordPlanNegativeKeyword);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      KeywordPlanNegativeKeywordName that = ((KeywordPlanNegativeKeywordName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.keywordPlanNegativeKeyword, that.keywordPlanNegativeKeyword);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(keywordPlanNegativeKeyword);
    return h;
  }

  /**
   * Builder for customers/{customer}/keywordPlanNegativeKeywords/{keyword_plan_negative_keyword}.
   */
  public static class Builder {
    private String customer;
    private String keywordPlanNegativeKeyword;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getKeywordPlanNegativeKeyword() {
      return keywordPlanNegativeKeyword;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setKeywordPlanNegativeKeyword(String keywordPlanNegativeKeyword) {
      this.keywordPlanNegativeKeyword = keywordPlanNegativeKeyword;
      return this;
    }

    private Builder(KeywordPlanNegativeKeywordName keywordPlanNegativeKeywordName) {
      customer = keywordPlanNegativeKeywordName.customer;
      keywordPlanNegativeKeyword = keywordPlanNegativeKeywordName.keywordPlanNegativeKeyword;
    }

    public KeywordPlanNegativeKeywordName build() {
      return new KeywordPlanNegativeKeywordName(this);
    }
  }
}
