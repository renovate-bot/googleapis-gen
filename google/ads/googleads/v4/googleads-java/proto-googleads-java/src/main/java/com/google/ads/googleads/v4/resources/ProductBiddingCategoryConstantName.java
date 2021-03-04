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
public class ProductBiddingCategoryConstantName implements ResourceName {
  private static final PathTemplate PRODUCT_BIDDING_CATEGORY_CONSTANT =
      PathTemplate.createWithoutUrlEncoding(
          "productBiddingCategoryConstants/{product_bidding_category_constant}");
  private volatile Map<String, String> fieldValuesMap;
  private final String productBiddingCategoryConstant;

  @Deprecated
  protected ProductBiddingCategoryConstantName() {
    productBiddingCategoryConstant = null;
  }

  private ProductBiddingCategoryConstantName(Builder builder) {
    productBiddingCategoryConstant =
        Preconditions.checkNotNull(builder.getProductBiddingCategoryConstant());
  }

  public String getProductBiddingCategoryConstant() {
    return productBiddingCategoryConstant;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static ProductBiddingCategoryConstantName of(String productBiddingCategoryConstant) {
    return newBuilder().setProductBiddingCategoryConstant(productBiddingCategoryConstant).build();
  }

  public static String format(String productBiddingCategoryConstant) {
    return newBuilder()
        .setProductBiddingCategoryConstant(productBiddingCategoryConstant)
        .build()
        .toString();
  }

  public static ProductBiddingCategoryConstantName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        PRODUCT_BIDDING_CATEGORY_CONSTANT.validatedMatch(
            formattedString,
            "ProductBiddingCategoryConstantName.parse: formattedString not in valid format");
    return of(matchMap.get("product_bidding_category_constant"));
  }

  public static List<ProductBiddingCategoryConstantName> parseList(List<String> formattedStrings) {
    List<ProductBiddingCategoryConstantName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<ProductBiddingCategoryConstantName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (ProductBiddingCategoryConstantName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return PRODUCT_BIDDING_CATEGORY_CONSTANT.matches(formattedString);
  }

  @Override
  public Map<String, String> getFieldValuesMap() {
    if (fieldValuesMap == null) {
      synchronized (this) {
        if (fieldValuesMap == null) {
          ImmutableMap.Builder<String, String> fieldMapBuilder = ImmutableMap.builder();
          if (productBiddingCategoryConstant != null) {
            fieldMapBuilder.put(
                "product_bidding_category_constant", productBiddingCategoryConstant);
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
    return PRODUCT_BIDDING_CATEGORY_CONSTANT.instantiate(
        "product_bidding_category_constant", productBiddingCategoryConstant);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      ProductBiddingCategoryConstantName that = ((ProductBiddingCategoryConstantName) o);
      return Objects.equals(
          this.productBiddingCategoryConstant, that.productBiddingCategoryConstant);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(productBiddingCategoryConstant);
    return h;
  }

  /** Builder for productBiddingCategoryConstants/{product_bidding_category_constant}. */
  public static class Builder {
    private String productBiddingCategoryConstant;

    protected Builder() {}

    public String getProductBiddingCategoryConstant() {
      return productBiddingCategoryConstant;
    }

    public Builder setProductBiddingCategoryConstant(String productBiddingCategoryConstant) {
      this.productBiddingCategoryConstant = productBiddingCategoryConstant;
      return this;
    }

    private Builder(ProductBiddingCategoryConstantName productBiddingCategoryConstantName) {
      productBiddingCategoryConstant =
          productBiddingCategoryConstantName.productBiddingCategoryConstant;
    }

    public ProductBiddingCategoryConstantName build() {
      return new ProductBiddingCategoryConstantName(this);
    }
  }
}
