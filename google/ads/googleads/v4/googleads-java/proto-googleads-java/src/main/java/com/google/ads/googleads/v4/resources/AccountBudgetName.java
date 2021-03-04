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
public class AccountBudgetName implements ResourceName {
  private static final PathTemplate CUSTOMER_ACCOUNT_BUDGET =
      PathTemplate.createWithoutUrlEncoding("customers/{customer}/accountBudgets/{account_budget}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String accountBudget;

  @Deprecated
  protected AccountBudgetName() {
    customer = null;
    accountBudget = null;
  }

  private AccountBudgetName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    accountBudget = Preconditions.checkNotNull(builder.getAccountBudget());
  }

  public String getCustomer() {
    return customer;
  }

  public String getAccountBudget() {
    return accountBudget;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static AccountBudgetName of(String customer, String accountBudget) {
    return newBuilder().setCustomer(customer).setAccountBudget(accountBudget).build();
  }

  public static String format(String customer, String accountBudget) {
    return newBuilder().setCustomer(customer).setAccountBudget(accountBudget).build().toString();
  }

  public static AccountBudgetName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_ACCOUNT_BUDGET.validatedMatch(
            formattedString, "AccountBudgetName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("account_budget"));
  }

  public static List<AccountBudgetName> parseList(List<String> formattedStrings) {
    List<AccountBudgetName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<AccountBudgetName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (AccountBudgetName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_ACCOUNT_BUDGET.matches(formattedString);
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
          if (accountBudget != null) {
            fieldMapBuilder.put("account_budget", accountBudget);
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
    return CUSTOMER_ACCOUNT_BUDGET.instantiate(
        "customer", customer, "account_budget", accountBudget);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      AccountBudgetName that = ((AccountBudgetName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.accountBudget, that.accountBudget);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(accountBudget);
    return h;
  }

  /** Builder for customers/{customer}/accountBudgets/{account_budget}. */
  public static class Builder {
    private String customer;
    private String accountBudget;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getAccountBudget() {
      return accountBudget;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setAccountBudget(String accountBudget) {
      this.accountBudget = accountBudget;
      return this;
    }

    private Builder(AccountBudgetName accountBudgetName) {
      customer = accountBudgetName.customer;
      accountBudget = accountBudgetName.accountBudget;
    }

    public AccountBudgetName build() {
      return new AccountBudgetName(this);
    }
  }
}
