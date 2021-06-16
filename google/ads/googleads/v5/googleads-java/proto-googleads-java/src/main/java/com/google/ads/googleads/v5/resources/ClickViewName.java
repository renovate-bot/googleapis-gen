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
public class ClickViewName implements ResourceName {
  private static final PathTemplate CUSTOMER_CLICK_VIEW =
      PathTemplate.createWithoutUrlEncoding("customers/{customer}/clickViews/{click_view}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String clickView;

  @Deprecated
  protected ClickViewName() {
    customer = null;
    clickView = null;
  }

  private ClickViewName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    clickView = Preconditions.checkNotNull(builder.getClickView());
  }

  public String getCustomer() {
    return customer;
  }

  public String getClickView() {
    return clickView;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static ClickViewName of(String customer, String clickView) {
    return newBuilder().setCustomer(customer).setClickView(clickView).build();
  }

  public static String format(String customer, String clickView) {
    return newBuilder().setCustomer(customer).setClickView(clickView).build().toString();
  }

  public static ClickViewName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_CLICK_VIEW.validatedMatch(
            formattedString, "ClickViewName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("click_view"));
  }

  public static List<ClickViewName> parseList(List<String> formattedStrings) {
    List<ClickViewName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<ClickViewName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (ClickViewName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_CLICK_VIEW.matches(formattedString);
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
          if (clickView != null) {
            fieldMapBuilder.put("click_view", clickView);
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
    return CUSTOMER_CLICK_VIEW.instantiate("customer", customer, "click_view", clickView);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      ClickViewName that = ((ClickViewName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.clickView, that.clickView);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(clickView);
    return h;
  }

  /** Builder for customers/{customer}/clickViews/{click_view}. */
  public static class Builder {
    private String customer;
    private String clickView;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getClickView() {
      return clickView;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setClickView(String clickView) {
      this.clickView = clickView;
      return this;
    }

    private Builder(ClickViewName clickViewName) {
      this.customer = clickViewName.customer;
      this.clickView = clickViewName.clickView;
    }

    public ClickViewName build() {
      return new ClickViewName(this);
    }
  }
}
