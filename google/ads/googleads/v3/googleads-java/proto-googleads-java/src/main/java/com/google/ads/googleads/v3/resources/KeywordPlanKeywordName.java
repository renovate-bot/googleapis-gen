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
public class KeywordPlanKeywordName implements ResourceName {
  private static final PathTemplate CUSTOMER_KEYWORD_PLAN_KEYWORD =
      PathTemplate.createWithoutUrlEncoding(
          "customers/{customer}/keywordPlanKeywords/{keyword_plan_keyword}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String keywordPlanKeyword;

  @Deprecated
  protected KeywordPlanKeywordName() {
    customer = null;
    keywordPlanKeyword = null;
  }

  private KeywordPlanKeywordName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    keywordPlanKeyword = Preconditions.checkNotNull(builder.getKeywordPlanKeyword());
  }

  public String getCustomer() {
    return customer;
  }

  public String getKeywordPlanKeyword() {
    return keywordPlanKeyword;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static KeywordPlanKeywordName of(String customer, String keywordPlanKeyword) {
    return newBuilder().setCustomer(customer).setKeywordPlanKeyword(keywordPlanKeyword).build();
  }

  public static String format(String customer, String keywordPlanKeyword) {
    return newBuilder()
        .setCustomer(customer)
        .setKeywordPlanKeyword(keywordPlanKeyword)
        .build()
        .toString();
  }

  public static KeywordPlanKeywordName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_KEYWORD_PLAN_KEYWORD.validatedMatch(
            formattedString, "KeywordPlanKeywordName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("keyword_plan_keyword"));
  }

  public static List<KeywordPlanKeywordName> parseList(List<String> formattedStrings) {
    List<KeywordPlanKeywordName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<KeywordPlanKeywordName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (KeywordPlanKeywordName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_KEYWORD_PLAN_KEYWORD.matches(formattedString);
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
          if (keywordPlanKeyword != null) {
            fieldMapBuilder.put("keyword_plan_keyword", keywordPlanKeyword);
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
    return CUSTOMER_KEYWORD_PLAN_KEYWORD.instantiate(
        "customer", customer, "keyword_plan_keyword", keywordPlanKeyword);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      KeywordPlanKeywordName that = ((KeywordPlanKeywordName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.keywordPlanKeyword, that.keywordPlanKeyword);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(keywordPlanKeyword);
    return h;
  }

  /** Builder for customers/{customer}/keywordPlanKeywords/{keyword_plan_keyword}. */
  public static class Builder {
    private String customer;
    private String keywordPlanKeyword;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getKeywordPlanKeyword() {
      return keywordPlanKeyword;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setKeywordPlanKeyword(String keywordPlanKeyword) {
      this.keywordPlanKeyword = keywordPlanKeyword;
      return this;
    }

    private Builder(KeywordPlanKeywordName keywordPlanKeywordName) {
      customer = keywordPlanKeywordName.customer;
      keywordPlanKeyword = keywordPlanKeywordName.keywordPlanKeyword;
    }

    public KeywordPlanKeywordName build() {
      return new KeywordPlanKeywordName(this);
    }
  }
}
