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
public class TopicViewName implements ResourceName {
  private static final PathTemplate CUSTOMER_TOPIC_VIEW =
      PathTemplate.createWithoutUrlEncoding("customers/{customer}/topicViews/{topic_view}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String topicView;

  @Deprecated
  protected TopicViewName() {
    customer = null;
    topicView = null;
  }

  private TopicViewName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    topicView = Preconditions.checkNotNull(builder.getTopicView());
  }

  public String getCustomer() {
    return customer;
  }

  public String getTopicView() {
    return topicView;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static TopicViewName of(String customer, String topicView) {
    return newBuilder().setCustomer(customer).setTopicView(topicView).build();
  }

  public static String format(String customer, String topicView) {
    return newBuilder().setCustomer(customer).setTopicView(topicView).build().toString();
  }

  public static TopicViewName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_TOPIC_VIEW.validatedMatch(
            formattedString, "TopicViewName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("topic_view"));
  }

  public static List<TopicViewName> parseList(List<String> formattedStrings) {
    List<TopicViewName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<TopicViewName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (TopicViewName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_TOPIC_VIEW.matches(formattedString);
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
          if (topicView != null) {
            fieldMapBuilder.put("topic_view", topicView);
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
    return CUSTOMER_TOPIC_VIEW.instantiate("customer", customer, "topic_view", topicView);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      TopicViewName that = ((TopicViewName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.topicView, that.topicView);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(topicView);
    return h;
  }

  /** Builder for customers/{customer}/topicViews/{topic_view}. */
  public static class Builder {
    private String customer;
    private String topicView;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getTopicView() {
      return topicView;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setTopicView(String topicView) {
      this.topicView = topicView;
      return this;
    }

    private Builder(TopicViewName topicViewName) {
      customer = topicViewName.customer;
      topicView = topicViewName.topicView;
    }

    public TopicViewName build() {
      return new TopicViewName(this);
    }
  }
}
