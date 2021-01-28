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
public class UserInterestName implements ResourceName {
  private static final PathTemplate CUSTOMER_USER_INTEREST =
      PathTemplate.createWithoutUrlEncoding("customers/{customer}/userInterests/{user_interest}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String userInterest;

  @Deprecated
  protected UserInterestName() {
    customer = null;
    userInterest = null;
  }

  private UserInterestName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    userInterest = Preconditions.checkNotNull(builder.getUserInterest());
  }

  public String getCustomer() {
    return customer;
  }

  public String getUserInterest() {
    return userInterest;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static UserInterestName of(String customer, String userInterest) {
    return newBuilder().setCustomer(customer).setUserInterest(userInterest).build();
  }

  public static String format(String customer, String userInterest) {
    return newBuilder().setCustomer(customer).setUserInterest(userInterest).build().toString();
  }

  public static UserInterestName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_USER_INTEREST.validatedMatch(
            formattedString, "UserInterestName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("user_interest"));
  }

  public static List<UserInterestName> parseList(List<String> formattedStrings) {
    List<UserInterestName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<UserInterestName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (UserInterestName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_USER_INTEREST.matches(formattedString);
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
          if (userInterest != null) {
            fieldMapBuilder.put("user_interest", userInterest);
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
    return CUSTOMER_USER_INTEREST.instantiate("customer", customer, "user_interest", userInterest);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      UserInterestName that = ((UserInterestName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.userInterest, that.userInterest);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(userInterest);
    return h;
  }

  /** Builder for customers/{customer}/userInterests/{user_interest}. */
  public static class Builder {
    private String customer;
    private String userInterest;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getUserInterest() {
      return userInterest;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setUserInterest(String userInterest) {
      this.userInterest = userInterest;
      return this;
    }

    private Builder(UserInterestName userInterestName) {
      customer = userInterestName.customer;
      userInterest = userInterestName.userInterest;
    }

    public UserInterestName build() {
      return new UserInterestName(this);
    }
  }
}
