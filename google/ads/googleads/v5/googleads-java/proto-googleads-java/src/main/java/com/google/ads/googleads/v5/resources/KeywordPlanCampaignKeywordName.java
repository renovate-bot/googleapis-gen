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
public class KeywordPlanCampaignKeywordName implements ResourceName {
  private static final PathTemplate CUSTOMER_KEYWORD_PLAN_CAMPAIGN_KEYWORD =
      PathTemplate.createWithoutUrlEncoding(
          "customers/{customer}/keywordPlanCampaignKeywords/{keyword_plan_campaign_keyword}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String keywordPlanCampaignKeyword;

  @Deprecated
  protected KeywordPlanCampaignKeywordName() {
    customer = null;
    keywordPlanCampaignKeyword = null;
  }

  private KeywordPlanCampaignKeywordName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    keywordPlanCampaignKeyword =
        Preconditions.checkNotNull(builder.getKeywordPlanCampaignKeyword());
  }

  public String getCustomer() {
    return customer;
  }

  public String getKeywordPlanCampaignKeyword() {
    return keywordPlanCampaignKeyword;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static KeywordPlanCampaignKeywordName of(
      String customer, String keywordPlanCampaignKeyword) {
    return newBuilder()
        .setCustomer(customer)
        .setKeywordPlanCampaignKeyword(keywordPlanCampaignKeyword)
        .build();
  }

  public static String format(String customer, String keywordPlanCampaignKeyword) {
    return newBuilder()
        .setCustomer(customer)
        .setKeywordPlanCampaignKeyword(keywordPlanCampaignKeyword)
        .build()
        .toString();
  }

  public static KeywordPlanCampaignKeywordName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_KEYWORD_PLAN_CAMPAIGN_KEYWORD.validatedMatch(
            formattedString,
            "KeywordPlanCampaignKeywordName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("keyword_plan_campaign_keyword"));
  }

  public static List<KeywordPlanCampaignKeywordName> parseList(List<String> formattedStrings) {
    List<KeywordPlanCampaignKeywordName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<KeywordPlanCampaignKeywordName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (KeywordPlanCampaignKeywordName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_KEYWORD_PLAN_CAMPAIGN_KEYWORD.matches(formattedString);
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
          if (keywordPlanCampaignKeyword != null) {
            fieldMapBuilder.put("keyword_plan_campaign_keyword", keywordPlanCampaignKeyword);
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
    return CUSTOMER_KEYWORD_PLAN_CAMPAIGN_KEYWORD.instantiate(
        "customer", customer, "keyword_plan_campaign_keyword", keywordPlanCampaignKeyword);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      KeywordPlanCampaignKeywordName that = ((KeywordPlanCampaignKeywordName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.keywordPlanCampaignKeyword, that.keywordPlanCampaignKeyword);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(keywordPlanCampaignKeyword);
    return h;
  }

  /**
   * Builder for customers/{customer}/keywordPlanCampaignKeywords/{keyword_plan_campaign_keyword}.
   */
  public static class Builder {
    private String customer;
    private String keywordPlanCampaignKeyword;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getKeywordPlanCampaignKeyword() {
      return keywordPlanCampaignKeyword;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setKeywordPlanCampaignKeyword(String keywordPlanCampaignKeyword) {
      this.keywordPlanCampaignKeyword = keywordPlanCampaignKeyword;
      return this;
    }

    private Builder(KeywordPlanCampaignKeywordName keywordPlanCampaignKeywordName) {
      customer = keywordPlanCampaignKeywordName.customer;
      keywordPlanCampaignKeyword = keywordPlanCampaignKeywordName.keywordPlanCampaignKeyword;
    }

    public KeywordPlanCampaignKeywordName build() {
      return new KeywordPlanCampaignKeywordName(this);
    }
  }
}
