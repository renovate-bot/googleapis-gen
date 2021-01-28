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
public class MutateJobName implements ResourceName {
  private static final PathTemplate CUSTOMER_MUTATE_JOB =
      PathTemplate.createWithoutUrlEncoding("customers/{customer}/mutateJobs/{mutate_job}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String mutateJob;

  @Deprecated
  protected MutateJobName() {
    customer = null;
    mutateJob = null;
  }

  private MutateJobName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    mutateJob = Preconditions.checkNotNull(builder.getMutateJob());
  }

  public String getCustomer() {
    return customer;
  }

  public String getMutateJob() {
    return mutateJob;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static MutateJobName of(String customer, String mutateJob) {
    return newBuilder().setCustomer(customer).setMutateJob(mutateJob).build();
  }

  public static String format(String customer, String mutateJob) {
    return newBuilder().setCustomer(customer).setMutateJob(mutateJob).build().toString();
  }

  public static MutateJobName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_MUTATE_JOB.validatedMatch(
            formattedString, "MutateJobName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("mutate_job"));
  }

  public static List<MutateJobName> parseList(List<String> formattedStrings) {
    List<MutateJobName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<MutateJobName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (MutateJobName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_MUTATE_JOB.matches(formattedString);
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
          if (mutateJob != null) {
            fieldMapBuilder.put("mutate_job", mutateJob);
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
    return CUSTOMER_MUTATE_JOB.instantiate("customer", customer, "mutate_job", mutateJob);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      MutateJobName that = ((MutateJobName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.mutateJob, that.mutateJob);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(mutateJob);
    return h;
  }

  /** Builder for customers/{customer}/mutateJobs/{mutate_job}. */
  public static class Builder {
    private String customer;
    private String mutateJob;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getMutateJob() {
      return mutateJob;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setMutateJob(String mutateJob) {
      this.mutateJob = mutateJob;
      return this;
    }

    private Builder(MutateJobName mutateJobName) {
      customer = mutateJobName.customer;
      mutateJob = mutateJobName.mutateJob;
    }

    public MutateJobName build() {
      return new MutateJobName(this);
    }
  }
}
