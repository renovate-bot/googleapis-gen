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
public class CustomerClientLinkName implements ResourceName {
  private static final PathTemplate CUSTOMER_CUSTOMER_CLIENT_LINK =
      PathTemplate.createWithoutUrlEncoding(
          "customers/{customer}/customerClientLinks/{customer_client_link}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String customerClientLink;

  @Deprecated
  protected CustomerClientLinkName() {
    customer = null;
    customerClientLink = null;
  }

  private CustomerClientLinkName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    customerClientLink = Preconditions.checkNotNull(builder.getCustomerClientLink());
  }

  public String getCustomer() {
    return customer;
  }

  public String getCustomerClientLink() {
    return customerClientLink;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static CustomerClientLinkName of(String customer, String customerClientLink) {
    return newBuilder().setCustomer(customer).setCustomerClientLink(customerClientLink).build();
  }

  public static String format(String customer, String customerClientLink) {
    return newBuilder()
        .setCustomer(customer)
        .setCustomerClientLink(customerClientLink)
        .build()
        .toString();
  }

  public static CustomerClientLinkName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_CUSTOMER_CLIENT_LINK.validatedMatch(
            formattedString, "CustomerClientLinkName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("customer_client_link"));
  }

  public static List<CustomerClientLinkName> parseList(List<String> formattedStrings) {
    List<CustomerClientLinkName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<CustomerClientLinkName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (CustomerClientLinkName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_CUSTOMER_CLIENT_LINK.matches(formattedString);
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
          if (customerClientLink != null) {
            fieldMapBuilder.put("customer_client_link", customerClientLink);
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
    return CUSTOMER_CUSTOMER_CLIENT_LINK.instantiate(
        "customer", customer, "customer_client_link", customerClientLink);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      CustomerClientLinkName that = ((CustomerClientLinkName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.customerClientLink, that.customerClientLink);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(customerClientLink);
    return h;
  }

  /** Builder for customers/{customer}/customerClientLinks/{customer_client_link}. */
  public static class Builder {
    private String customer;
    private String customerClientLink;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getCustomerClientLink() {
      return customerClientLink;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setCustomerClientLink(String customerClientLink) {
      this.customerClientLink = customerClientLink;
      return this;
    }

    private Builder(CustomerClientLinkName customerClientLinkName) {
      this.customer = customerClientLinkName.customer;
      this.customerClientLink = customerClientLinkName.customerClientLink;
    }

    public CustomerClientLinkName build() {
      return new CustomerClientLinkName(this);
    }
  }
}
