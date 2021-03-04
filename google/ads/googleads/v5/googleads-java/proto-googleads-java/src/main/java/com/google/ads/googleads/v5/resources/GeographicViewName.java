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
public class GeographicViewName implements ResourceName {
  private static final PathTemplate CUSTOMER_GEOGRAPHIC_VIEW =
      PathTemplate.createWithoutUrlEncoding(
          "customers/{customer}/geographicViews/{geographic_view}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String geographicView;

  @Deprecated
  protected GeographicViewName() {
    customer = null;
    geographicView = null;
  }

  private GeographicViewName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    geographicView = Preconditions.checkNotNull(builder.getGeographicView());
  }

  public String getCustomer() {
    return customer;
  }

  public String getGeographicView() {
    return geographicView;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static GeographicViewName of(String customer, String geographicView) {
    return newBuilder().setCustomer(customer).setGeographicView(geographicView).build();
  }

  public static String format(String customer, String geographicView) {
    return newBuilder().setCustomer(customer).setGeographicView(geographicView).build().toString();
  }

  public static GeographicViewName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_GEOGRAPHIC_VIEW.validatedMatch(
            formattedString, "GeographicViewName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("geographic_view"));
  }

  public static List<GeographicViewName> parseList(List<String> formattedStrings) {
    List<GeographicViewName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<GeographicViewName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (GeographicViewName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_GEOGRAPHIC_VIEW.matches(formattedString);
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
          if (geographicView != null) {
            fieldMapBuilder.put("geographic_view", geographicView);
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
    return CUSTOMER_GEOGRAPHIC_VIEW.instantiate(
        "customer", customer, "geographic_view", geographicView);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      GeographicViewName that = ((GeographicViewName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.geographicView, that.geographicView);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(geographicView);
    return h;
  }

  /** Builder for customers/{customer}/geographicViews/{geographic_view}. */
  public static class Builder {
    private String customer;
    private String geographicView;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getGeographicView() {
      return geographicView;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setGeographicView(String geographicView) {
      this.geographicView = geographicView;
      return this;
    }

    private Builder(GeographicViewName geographicViewName) {
      customer = geographicViewName.customer;
      geographicView = geographicViewName.geographicView;
    }

    public GeographicViewName build() {
      return new GeographicViewName(this);
    }
  }
}
