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
public class FeedItemTargetName implements ResourceName {
  private static final PathTemplate CUSTOMER_FEED_ITEM_TARGET =
      PathTemplate.createWithoutUrlEncoding(
          "customers/{customer}/feedItemTargets/{feed_item_target}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String feedItemTarget;

  @Deprecated
  protected FeedItemTargetName() {
    customer = null;
    feedItemTarget = null;
  }

  private FeedItemTargetName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    feedItemTarget = Preconditions.checkNotNull(builder.getFeedItemTarget());
  }

  public String getCustomer() {
    return customer;
  }

  public String getFeedItemTarget() {
    return feedItemTarget;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static FeedItemTargetName of(String customer, String feedItemTarget) {
    return newBuilder().setCustomer(customer).setFeedItemTarget(feedItemTarget).build();
  }

  public static String format(String customer, String feedItemTarget) {
    return newBuilder().setCustomer(customer).setFeedItemTarget(feedItemTarget).build().toString();
  }

  public static FeedItemTargetName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_FEED_ITEM_TARGET.validatedMatch(
            formattedString, "FeedItemTargetName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("feed_item_target"));
  }

  public static List<FeedItemTargetName> parseList(List<String> formattedStrings) {
    List<FeedItemTargetName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<FeedItemTargetName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (FeedItemTargetName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_FEED_ITEM_TARGET.matches(formattedString);
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
          if (feedItemTarget != null) {
            fieldMapBuilder.put("feed_item_target", feedItemTarget);
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
    return CUSTOMER_FEED_ITEM_TARGET.instantiate(
        "customer", customer, "feed_item_target", feedItemTarget);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      FeedItemTargetName that = ((FeedItemTargetName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.feedItemTarget, that.feedItemTarget);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(feedItemTarget);
    return h;
  }

  /** Builder for customers/{customer}/feedItemTargets/{feed_item_target}. */
  public static class Builder {
    private String customer;
    private String feedItemTarget;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getFeedItemTarget() {
      return feedItemTarget;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setFeedItemTarget(String feedItemTarget) {
      this.feedItemTarget = feedItemTarget;
      return this;
    }

    private Builder(FeedItemTargetName feedItemTargetName) {
      this.customer = feedItemTargetName.customer;
      this.feedItemTarget = feedItemTargetName.feedItemTarget;
    }

    public FeedItemTargetName build() {
      return new FeedItemTargetName(this);
    }
  }
}
