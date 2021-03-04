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
public class FeedPlaceholderViewName implements ResourceName {
  private static final PathTemplate CUSTOMER_FEED_PLACEHOLDER_VIEW =
      PathTemplate.createWithoutUrlEncoding(
          "customers/{customer}/feedPlaceholderViews/{feed_placeholder_view}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String feedPlaceholderView;

  @Deprecated
  protected FeedPlaceholderViewName() {
    customer = null;
    feedPlaceholderView = null;
  }

  private FeedPlaceholderViewName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    feedPlaceholderView = Preconditions.checkNotNull(builder.getFeedPlaceholderView());
  }

  public String getCustomer() {
    return customer;
  }

  public String getFeedPlaceholderView() {
    return feedPlaceholderView;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static FeedPlaceholderViewName of(String customer, String feedPlaceholderView) {
    return newBuilder().setCustomer(customer).setFeedPlaceholderView(feedPlaceholderView).build();
  }

  public static String format(String customer, String feedPlaceholderView) {
    return newBuilder()
        .setCustomer(customer)
        .setFeedPlaceholderView(feedPlaceholderView)
        .build()
        .toString();
  }

  public static FeedPlaceholderViewName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_FEED_PLACEHOLDER_VIEW.validatedMatch(
            formattedString, "FeedPlaceholderViewName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("feed_placeholder_view"));
  }

  public static List<FeedPlaceholderViewName> parseList(List<String> formattedStrings) {
    List<FeedPlaceholderViewName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<FeedPlaceholderViewName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (FeedPlaceholderViewName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_FEED_PLACEHOLDER_VIEW.matches(formattedString);
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
          if (feedPlaceholderView != null) {
            fieldMapBuilder.put("feed_placeholder_view", feedPlaceholderView);
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
    return CUSTOMER_FEED_PLACEHOLDER_VIEW.instantiate(
        "customer", customer, "feed_placeholder_view", feedPlaceholderView);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      FeedPlaceholderViewName that = ((FeedPlaceholderViewName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.feedPlaceholderView, that.feedPlaceholderView);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(feedPlaceholderView);
    return h;
  }

  /** Builder for customers/{customer}/feedPlaceholderViews/{feed_placeholder_view}. */
  public static class Builder {
    private String customer;
    private String feedPlaceholderView;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getFeedPlaceholderView() {
      return feedPlaceholderView;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setFeedPlaceholderView(String feedPlaceholderView) {
      this.feedPlaceholderView = feedPlaceholderView;
      return this;
    }

    private Builder(FeedPlaceholderViewName feedPlaceholderViewName) {
      customer = feedPlaceholderViewName.customer;
      feedPlaceholderView = feedPlaceholderViewName.feedPlaceholderView;
    }

    public FeedPlaceholderViewName build() {
      return new FeedPlaceholderViewName(this);
    }
  }
}
