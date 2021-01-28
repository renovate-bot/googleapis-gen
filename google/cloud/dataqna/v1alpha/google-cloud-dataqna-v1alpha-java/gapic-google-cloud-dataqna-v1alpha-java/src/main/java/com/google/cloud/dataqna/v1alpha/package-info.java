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

/**
 * The interfaces provided are listed below, along with usage samples.
 *
 * <p>======================= AutoSuggestionServiceClient =======================
 *
 * <p>Service Description: This stateless API provides automatic suggestions for natural language
 * queries for the data sources in the provided project and location.
 *
 * <p>The service provides a resourceless operation `suggestQueries` that can be called to get a
 * list of suggestions for a given incomplete query and scope (or list of scopes) under which the
 * query is to be interpreted.
 *
 * <p>There are two types of suggestions, ENTITY for single entity suggestions and TEMPLATE for full
 * sentences. By default, both types are returned.
 *
 * <p>Example Request: ``` GetSuggestions({ parent: "locations/us/projects/my-project" scopes:
 * "//bigquery.googleapis.com/projects/my-project/datasets/my-dataset/tables/my-table" query: "top
 * it" }) ```
 *
 * <p>The service will retrieve information based on the given scope(s) and give suggestions based
 * on that (e.g. "top item" for "top it" if "item" is a known dimension for the provided scope). ```
 * suggestions { suggestion_info { annotated_suggestion { text_formatted: "top item by sum of
 * usd_revenue_net" markups { type: DIMENSION start_char_index: 4 length: 4 } markups { type: METRIC
 * start_char_index: 19 length: 15 } } query_matches { start_char_index: 0 length: 6 } }
 * suggestion_type: TEMPLATE ranking_score: 0.9 } suggestions { suggestion_info {
 * annotated_suggestion { text_formatted: "item" markups { type: DIMENSION start_char_index: 4
 * length: 2 } } query_matches { start_char_index: 0 length: 6 } } suggestion_type: ENTITY
 * ranking_score: 0.8 } ```
 *
 * <p>Sample for AutoSuggestionServiceClient:
 *
 * <p>======================= QuestionServiceClient =======================
 *
 * <p>Service Description: Service to interpret natural language queries. The service allows to
 * create `Question` resources that are interpreted and are filled with one or more interpretations
 * if the question could be interpreted. Once a `Question` resource is created and has at least one
 * interpretation, an interpretation can be chosen for execution, which triggers a query to the
 * backend (for BigQuery, it will create a job). Upon successful execution of that interpretation,
 * backend specific information will be returned so that the client can retrieve the results from
 * the backend.
 *
 * <p>The `Question` resources are named `projects/&#42;/locations/&#42;/questions/&#42;`.
 *
 * <p>The `Question` resource has a singletion sub-resource `UserFeedback` named
 * `projects/&#42;/locations/&#42;/questions/&#42;/userFeedback`, which allows access to user
 * feedback.
 *
 * <p>Sample for QuestionServiceClient:
 */
@Generated("by gapic-generator-java")
package com.google.cloud.dataqna.v1alpha;

import javax.annotation.Generated;
