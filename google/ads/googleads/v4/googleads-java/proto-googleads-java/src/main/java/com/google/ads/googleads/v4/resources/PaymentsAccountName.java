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
public class PaymentsAccountName implements ResourceName {
  private static final PathTemplate CUSTOMER_PAYMENTS_ACCOUNT =
      PathTemplate.createWithoutUrlEncoding(
          "customers/{customer}/paymentsAccounts/{payments_account}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String paymentsAccount;

  @Deprecated
  protected PaymentsAccountName() {
    customer = null;
    paymentsAccount = null;
  }

  private PaymentsAccountName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    paymentsAccount = Preconditions.checkNotNull(builder.getPaymentsAccount());
  }

  public String getCustomer() {
    return customer;
  }

  public String getPaymentsAccount() {
    return paymentsAccount;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static PaymentsAccountName of(String customer, String paymentsAccount) {
    return newBuilder().setCustomer(customer).setPaymentsAccount(paymentsAccount).build();
  }

  public static String format(String customer, String paymentsAccount) {
    return newBuilder()
        .setCustomer(customer)
        .setPaymentsAccount(paymentsAccount)
        .build()
        .toString();
  }

  public static PaymentsAccountName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_PAYMENTS_ACCOUNT.validatedMatch(
            formattedString, "PaymentsAccountName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("payments_account"));
  }

  public static List<PaymentsAccountName> parseList(List<String> formattedStrings) {
    List<PaymentsAccountName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<PaymentsAccountName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (PaymentsAccountName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_PAYMENTS_ACCOUNT.matches(formattedString);
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
          if (paymentsAccount != null) {
            fieldMapBuilder.put("payments_account", paymentsAccount);
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
    return CUSTOMER_PAYMENTS_ACCOUNT.instantiate(
        "customer", customer, "payments_account", paymentsAccount);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      PaymentsAccountName that = ((PaymentsAccountName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.paymentsAccount, that.paymentsAccount);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(paymentsAccount);
    return h;
  }

  /** Builder for customers/{customer}/paymentsAccounts/{payments_account}. */
  public static class Builder {
    private String customer;
    private String paymentsAccount;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getPaymentsAccount() {
      return paymentsAccount;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setPaymentsAccount(String paymentsAccount) {
      this.paymentsAccount = paymentsAccount;
      return this;
    }

    private Builder(PaymentsAccountName paymentsAccountName) {
      customer = paymentsAccountName.customer;
      paymentsAccount = paymentsAccountName.paymentsAccount;
    }

    public PaymentsAccountName build() {
      return new PaymentsAccountName(this);
    }
  }
}
