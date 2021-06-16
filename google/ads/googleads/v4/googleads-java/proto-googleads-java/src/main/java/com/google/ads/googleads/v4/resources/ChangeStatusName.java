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
public class ChangeStatusName implements ResourceName {
  private static final PathTemplate CUSTOMER_CHANGE_STATUS =
      PathTemplate.createWithoutUrlEncoding("customers/{customer}/changeStatus/{change_status}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String changeStatus;

  @Deprecated
  protected ChangeStatusName() {
    customer = null;
    changeStatus = null;
  }

  private ChangeStatusName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    changeStatus = Preconditions.checkNotNull(builder.getChangeStatus());
  }

  public String getCustomer() {
    return customer;
  }

  public String getChangeStatus() {
    return changeStatus;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static ChangeStatusName of(String customer, String changeStatus) {
    return newBuilder().setCustomer(customer).setChangeStatus(changeStatus).build();
  }

  public static String format(String customer, String changeStatus) {
    return newBuilder().setCustomer(customer).setChangeStatus(changeStatus).build().toString();
  }

  public static ChangeStatusName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_CHANGE_STATUS.validatedMatch(
            formattedString, "ChangeStatusName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("change_status"));
  }

  public static List<ChangeStatusName> parseList(List<String> formattedStrings) {
    List<ChangeStatusName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<ChangeStatusName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (ChangeStatusName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_CHANGE_STATUS.matches(formattedString);
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
          if (changeStatus != null) {
            fieldMapBuilder.put("change_status", changeStatus);
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
    return CUSTOMER_CHANGE_STATUS.instantiate("customer", customer, "change_status", changeStatus);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      ChangeStatusName that = ((ChangeStatusName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.changeStatus, that.changeStatus);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(changeStatus);
    return h;
  }

  /** Builder for customers/{customer}/changeStatus/{change_status}. */
  public static class Builder {
    private String customer;
    private String changeStatus;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getChangeStatus() {
      return changeStatus;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setChangeStatus(String changeStatus) {
      this.changeStatus = changeStatus;
      return this;
    }

    private Builder(ChangeStatusName changeStatusName) {
      this.customer = changeStatusName.customer;
      this.changeStatus = changeStatusName.changeStatus;
    }

    public ChangeStatusName build() {
      return new ChangeStatusName(this);
    }
  }
}
