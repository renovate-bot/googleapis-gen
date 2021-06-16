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
public class CustomerFeedName implements ResourceName {
  private static final PathTemplate CUSTOMER_CUSTOMER_FEED =
      PathTemplate.createWithoutUrlEncoding("customers/{customer}/customerFeeds/{customer_feed}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String customerFeed;

  @Deprecated
  protected CustomerFeedName() {
    customer = null;
    customerFeed = null;
  }

  private CustomerFeedName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    customerFeed = Preconditions.checkNotNull(builder.getCustomerFeed());
  }

  public String getCustomer() {
    return customer;
  }

  public String getCustomerFeed() {
    return customerFeed;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static CustomerFeedName of(String customer, String customerFeed) {
    return newBuilder().setCustomer(customer).setCustomerFeed(customerFeed).build();
  }

  public static String format(String customer, String customerFeed) {
    return newBuilder().setCustomer(customer).setCustomerFeed(customerFeed).build().toString();
  }

  public static CustomerFeedName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_CUSTOMER_FEED.validatedMatch(
            formattedString, "CustomerFeedName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("customer_feed"));
  }

  public static List<CustomerFeedName> parseList(List<String> formattedStrings) {
    List<CustomerFeedName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<CustomerFeedName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (CustomerFeedName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_CUSTOMER_FEED.matches(formattedString);
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
          if (customerFeed != null) {
            fieldMapBuilder.put("customer_feed", customerFeed);
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
    return CUSTOMER_CUSTOMER_FEED.instantiate("customer", customer, "customer_feed", customerFeed);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      CustomerFeedName that = ((CustomerFeedName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.customerFeed, that.customerFeed);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(customerFeed);
    return h;
  }

  /** Builder for customers/{customer}/customerFeeds/{customer_feed}. */
  public static class Builder {
    private String customer;
    private String customerFeed;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getCustomerFeed() {
      return customerFeed;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setCustomerFeed(String customerFeed) {
      this.customerFeed = customerFeed;
      return this;
    }

    private Builder(CustomerFeedName customerFeedName) {
      this.customer = customerFeedName.customer;
      this.customerFeed = customerFeedName.customerFeed;
    }

    public CustomerFeedName build() {
      return new CustomerFeedName(this);
    }
  }
}
