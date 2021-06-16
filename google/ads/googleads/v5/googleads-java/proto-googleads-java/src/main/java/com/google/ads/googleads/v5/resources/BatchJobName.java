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
public class BatchJobName implements ResourceName {
  private static final PathTemplate CUSTOMER_BATCH_JOB =
      PathTemplate.createWithoutUrlEncoding("customers/{customer}/batchJobs/{batch_job}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String batchJob;

  @Deprecated
  protected BatchJobName() {
    customer = null;
    batchJob = null;
  }

  private BatchJobName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    batchJob = Preconditions.checkNotNull(builder.getBatchJob());
  }

  public String getCustomer() {
    return customer;
  }

  public String getBatchJob() {
    return batchJob;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static BatchJobName of(String customer, String batchJob) {
    return newBuilder().setCustomer(customer).setBatchJob(batchJob).build();
  }

  public static String format(String customer, String batchJob) {
    return newBuilder().setCustomer(customer).setBatchJob(batchJob).build().toString();
  }

  public static BatchJobName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_BATCH_JOB.validatedMatch(
            formattedString, "BatchJobName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("batch_job"));
  }

  public static List<BatchJobName> parseList(List<String> formattedStrings) {
    List<BatchJobName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<BatchJobName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (BatchJobName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_BATCH_JOB.matches(formattedString);
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
          if (batchJob != null) {
            fieldMapBuilder.put("batch_job", batchJob);
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
    return CUSTOMER_BATCH_JOB.instantiate("customer", customer, "batch_job", batchJob);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      BatchJobName that = ((BatchJobName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.batchJob, that.batchJob);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(batchJob);
    return h;
  }

  /** Builder for customers/{customer}/batchJobs/{batch_job}. */
  public static class Builder {
    private String customer;
    private String batchJob;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getBatchJob() {
      return batchJob;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setBatchJob(String batchJob) {
      this.batchJob = batchJob;
      return this;
    }

    private Builder(BatchJobName batchJobName) {
      this.customer = batchJobName.customer;
      this.batchJob = batchJobName.batchJob;
    }

    public BatchJobName build() {
      return new BatchJobName(this);
    }
  }
}
