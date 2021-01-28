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
public class RemarketingActionName implements ResourceName {
  private static final PathTemplate CUSTOMER_REMARKETING_ACTION =
      PathTemplate.createWithoutUrlEncoding(
          "customers/{customer}/remarketingActions/{remarketing_action}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String remarketingAction;

  @Deprecated
  protected RemarketingActionName() {
    customer = null;
    remarketingAction = null;
  }

  private RemarketingActionName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    remarketingAction = Preconditions.checkNotNull(builder.getRemarketingAction());
  }

  public String getCustomer() {
    return customer;
  }

  public String getRemarketingAction() {
    return remarketingAction;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static RemarketingActionName of(String customer, String remarketingAction) {
    return newBuilder().setCustomer(customer).setRemarketingAction(remarketingAction).build();
  }

  public static String format(String customer, String remarketingAction) {
    return newBuilder()
        .setCustomer(customer)
        .setRemarketingAction(remarketingAction)
        .build()
        .toString();
  }

  public static RemarketingActionName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_REMARKETING_ACTION.validatedMatch(
            formattedString, "RemarketingActionName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("remarketing_action"));
  }

  public static List<RemarketingActionName> parseList(List<String> formattedStrings) {
    List<RemarketingActionName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<RemarketingActionName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (RemarketingActionName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_REMARKETING_ACTION.matches(formattedString);
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
          if (remarketingAction != null) {
            fieldMapBuilder.put("remarketing_action", remarketingAction);
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
    return CUSTOMER_REMARKETING_ACTION.instantiate(
        "customer", customer, "remarketing_action", remarketingAction);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      RemarketingActionName that = ((RemarketingActionName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.remarketingAction, that.remarketingAction);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(remarketingAction);
    return h;
  }

  /** Builder for customers/{customer}/remarketingActions/{remarketing_action}. */
  public static class Builder {
    private String customer;
    private String remarketingAction;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getRemarketingAction() {
      return remarketingAction;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setRemarketingAction(String remarketingAction) {
      this.remarketingAction = remarketingAction;
      return this;
    }

    private Builder(RemarketingActionName remarketingActionName) {
      customer = remarketingActionName.customer;
      remarketingAction = remarketingActionName.remarketingAction;
    }

    public RemarketingActionName build() {
      return new RemarketingActionName(this);
    }
  }
}
