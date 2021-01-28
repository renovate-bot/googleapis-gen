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
public class IncomeRangeViewName implements ResourceName {
  private static final PathTemplate CUSTOMER_INCOME_RANGE_VIEW =
      PathTemplate.createWithoutUrlEncoding(
          "customers/{customer}/incomeRangeViews/{income_range_view}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String incomeRangeView;

  @Deprecated
  protected IncomeRangeViewName() {
    customer = null;
    incomeRangeView = null;
  }

  private IncomeRangeViewName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    incomeRangeView = Preconditions.checkNotNull(builder.getIncomeRangeView());
  }

  public String getCustomer() {
    return customer;
  }

  public String getIncomeRangeView() {
    return incomeRangeView;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static IncomeRangeViewName of(String customer, String incomeRangeView) {
    return newBuilder().setCustomer(customer).setIncomeRangeView(incomeRangeView).build();
  }

  public static String format(String customer, String incomeRangeView) {
    return newBuilder()
        .setCustomer(customer)
        .setIncomeRangeView(incomeRangeView)
        .build()
        .toString();
  }

  public static IncomeRangeViewName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_INCOME_RANGE_VIEW.validatedMatch(
            formattedString, "IncomeRangeViewName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("income_range_view"));
  }

  public static List<IncomeRangeViewName> parseList(List<String> formattedStrings) {
    List<IncomeRangeViewName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<IncomeRangeViewName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (IncomeRangeViewName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_INCOME_RANGE_VIEW.matches(formattedString);
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
          if (incomeRangeView != null) {
            fieldMapBuilder.put("income_range_view", incomeRangeView);
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
    return CUSTOMER_INCOME_RANGE_VIEW.instantiate(
        "customer", customer, "income_range_view", incomeRangeView);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      IncomeRangeViewName that = ((IncomeRangeViewName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.incomeRangeView, that.incomeRangeView);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(incomeRangeView);
    return h;
  }

  /** Builder for customers/{customer}/incomeRangeViews/{income_range_view}. */
  public static class Builder {
    private String customer;
    private String incomeRangeView;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getIncomeRangeView() {
      return incomeRangeView;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setIncomeRangeView(String incomeRangeView) {
      this.incomeRangeView = incomeRangeView;
      return this;
    }

    private Builder(IncomeRangeViewName incomeRangeViewName) {
      customer = incomeRangeViewName.customer;
      incomeRangeView = incomeRangeViewName.incomeRangeView;
    }

    public IncomeRangeViewName build() {
      return new IncomeRangeViewName(this);
    }
  }
}
