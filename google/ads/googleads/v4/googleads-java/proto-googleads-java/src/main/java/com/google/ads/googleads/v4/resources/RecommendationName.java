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
public class RecommendationName implements ResourceName {
  private static final PathTemplate CUSTOMER_RECOMMENDATION =
      PathTemplate.createWithoutUrlEncoding(
          "customers/{customer}/recommendations/{recommendation}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String recommendation;

  @Deprecated
  protected RecommendationName() {
    customer = null;
    recommendation = null;
  }

  private RecommendationName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    recommendation = Preconditions.checkNotNull(builder.getRecommendation());
  }

  public String getCustomer() {
    return customer;
  }

  public String getRecommendation() {
    return recommendation;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static RecommendationName of(String customer, String recommendation) {
    return newBuilder().setCustomer(customer).setRecommendation(recommendation).build();
  }

  public static String format(String customer, String recommendation) {
    return newBuilder().setCustomer(customer).setRecommendation(recommendation).build().toString();
  }

  public static RecommendationName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_RECOMMENDATION.validatedMatch(
            formattedString, "RecommendationName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("recommendation"));
  }

  public static List<RecommendationName> parseList(List<String> formattedStrings) {
    List<RecommendationName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<RecommendationName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (RecommendationName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_RECOMMENDATION.matches(formattedString);
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
          if (recommendation != null) {
            fieldMapBuilder.put("recommendation", recommendation);
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
    return CUSTOMER_RECOMMENDATION.instantiate(
        "customer", customer, "recommendation", recommendation);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      RecommendationName that = ((RecommendationName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.recommendation, that.recommendation);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(recommendation);
    return h;
  }

  /** Builder for customers/{customer}/recommendations/{recommendation}. */
  public static class Builder {
    private String customer;
    private String recommendation;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getRecommendation() {
      return recommendation;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setRecommendation(String recommendation) {
      this.recommendation = recommendation;
      return this;
    }

    private Builder(RecommendationName recommendationName) {
      customer = recommendationName.customer;
      recommendation = recommendationName.recommendation;
    }

    public RecommendationName build() {
      return new RecommendationName(this);
    }
  }
}
