# Copyright 2020 Google LLC
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     https://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.

module Google
  module Cloud
    module Dialogflow
      module Cx
        module V3beta1
          # Entities are extracted from user input and represent parameters that are
          # meaningful to your application. For example, a date range, a proper name
          # such as a geographic location or landmark, and so on. Entities represent
          # actionable data for your application.
          #
          # When you define an entity, you can also include synonyms that all map to
          # that entity. For example, "soft drink", "soda", "pop", and so on.
          #
          # There are three types of entities:
          #
          # * **System** - entities that are defined by the Dialogflow API for common
          #   data types such as date, time, currency, and so on. A system entity is
          #   represented by the `EntityType` type.
          #
          # * **Custom** - entities that are defined by you that represent
          #   actionable data that is meaningful to your application. For example,
          #   you could define a `pizza.sauce` entity for red or white pizza sauce,
          #   a `pizza.cheese` entity for the different types of cheese on a pizza,
          #   a `pizza.topping` entity for different toppings, and so on. A custom
          #   entity is represented by the `EntityType` type.
          #
          # * **User** - entities that are built for an individual user such as
          #   favorites, preferences, playlists, and so on. A user entity is
          #   represented by the {Google::Cloud::Dialogflow::Cx::V3beta1::SessionEntityType SessionEntityType} type.
          #
          # For more information about entity types, see the [Dialogflow
          # documentation](https://cloud.google.com/dialogflow/docs/entities-overview).
          # @!attribute [rw] name
          #   @return [String]
          #     The unique identifier of the entity type.
          #     Required for {Google::Cloud::Dialogflow::Cx::V3beta1::EntityTypes::UpdateEntityType EntityTypes::UpdateEntityType}.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/entityTypes/<Entity Type ID>`.
          # @!attribute [rw] display_name
          #   @return [String]
          #     Required. The human-readable name of the entity type, unique within the agent.
          # @!attribute [rw] kind
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::EntityType::Kind]
          #     Required. Indicates the kind of entity type.
          # @!attribute [rw] auto_expansion_mode
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::EntityType::AutoExpansionMode]
          #     Indicates whether the entity type can be automatically expanded.
          # @!attribute [rw] entities
          #   @return [Array<Google::Cloud::Dialogflow::Cx::V3beta1::EntityType::Entity>]
          #     The collection of entity entries associated with the entity type.
          # @!attribute [rw] excluded_phrases
          #   @return [Array<Google::Cloud::Dialogflow::Cx::V3beta1::EntityType::ExcludedPhrase>]
          #     Collection of exceptional words and phrases that shouldn't be matched.
          #     For example, if you have a size entity type with entry `giant`(an
          #     adjective), you might consider adding `giants`(a noun) as an exclusion.
          #     If the kind of entity type is `KIND_MAP`, then the phrases specified by
          #     entities and excluded phrases should be mutually exclusive.
          # @!attribute [rw] enable_fuzzy_extraction
          #   @return [true, false]
          #     Enables fuzzy entity extraction during classification.
          # @!attribute [rw] redact
          #   @return [true, false]
          #     Indicates whether parameters of the entity type should be redacted in log.
          #     If redaction is enabled, page parameters and intent parameters referring to
          #     the entity type will be replaced by parameter name during logging.
          class EntityType
            # An **entity entry** for an associated entity type.
            # @!attribute [rw] value
            #   @return [String]
            #     Required. The primary value associated with this entity entry.
            #     For example, if the entity type is *vegetable*, the value could be
            #     *scallions*.
            #
            #     For `KIND_MAP` entity types:
            #
            #     * A canonical value to be used in place of synonyms.
            #
            #     For `KIND_LIST` entity types:
            #
            #     * A string that can contain references to other entity types (with or
            #       without aliases).
            # @!attribute [rw] synonyms
            #   @return [Array<String>]
            #     Required. A collection of value synonyms. For example, if the entity type
            #     is *vegetable*, and `value` is *scallions*, a synonym could be *green
            #     onions*.
            #
            #     For `KIND_LIST` entity types:
            #
            #     * This collection must contain exactly one synonym equal to `value`.
            class Entity; end

            # An excluded entity phrase that should not be matched.
            # @!attribute [rw] value
            #   @return [String]
            #     Required. The word or phrase to be excluded.
            class ExcludedPhrase; end

            # Represents different entity type expansion modes. Automated expansion
            # allows an agent to recognize values that have not been explicitly listed in
            # the entity (for example, new kinds of shopping list items).
            module AutoExpansionMode
              # Auto expansion disabled for the entity.
              AUTO_EXPANSION_MODE_UNSPECIFIED = 0

              # Allows an agent to recognize values that have not been explicitly
              # listed in the entity.
              AUTO_EXPANSION_MODE_DEFAULT = 1
            end

            # Represents kinds of entities.
            module Kind
              # Not specified. This value should be never used.
              KIND_UNSPECIFIED = 0

              # Map entity types allow mapping of a group of synonyms to a canonical
              # value.
              KIND_MAP = 1

              # List entity types contain a set of entries that do not map to canonical
              # values. However, list entity types can contain references to other entity
              # types (with or without aliases).
              KIND_LIST = 2

              # Regexp entity types allow to specify regular expressions in entries
              # values.
              KIND_REGEXP = 3
            end
          end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::EntityTypes::ListEntityTypes EntityTypes::ListEntityTypes}.
          # @!attribute [rw] parent
          #   @return [String]
          #     Required. The agent to list all entity types for.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
          # @!attribute [rw] language_code
          #   @return [String]
          #     The language to list entity types for. The following fields are language
          #     dependent:
          #
          #     * `EntityType.entities.value`
          #     * `EntityType.entities.synonyms`
          #     * `EntityType.excluded_phrases.value`
          #
          #     If not specified, the agent's default language is used.
          #     [Many
          #     languages](https://cloud.google.com/dialogflow/cx/docs/reference/language)
          #     are supported.
          #     Note: languages must be enabled in the agent before they can be used.
          # @!attribute [rw] page_size
          #   @return [Integer]
          #     The maximum number of items to return in a single page. By default 100 and
          #     at most 1000.
          # @!attribute [rw] page_token
          #   @return [String]
          #     The next_page_token value returned from a previous list request.
          class ListEntityTypesRequest; end

          # The response message for {Google::Cloud::Dialogflow::Cx::V3beta1::EntityTypes::ListEntityTypes EntityTypes::ListEntityTypes}.
          # @!attribute [rw] entity_types
          #   @return [Array<Google::Cloud::Dialogflow::Cx::V3beta1::EntityType>]
          #     The list of entity types. There will be a maximum number of items returned
          #     based on the page_size field in the request.
          # @!attribute [rw] next_page_token
          #   @return [String]
          #     Token to retrieve the next page of results, or empty if there are no
          #     more results in the list.
          class ListEntityTypesResponse; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::EntityTypes::GetEntityType EntityTypes::GetEntityType}.
          # @!attribute [rw] name
          #   @return [String]
          #     Required. The name of the entity type.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/entityTypes/<Entity Type ID>`.
          # @!attribute [rw] language_code
          #   @return [String]
          #     The language to retrieve the entity type for. The following fields are
          #     language dependent:
          #
          #     * `EntityType.entities.value`
          #     * `EntityType.entities.synonyms`
          #     * `EntityType.excluded_phrases.value`
          #
          #     If not specified, the agent's default language is used.
          #     [Many
          #     languages](https://cloud.google.com/dialogflow/cx/docs/reference/language)
          #     are supported.
          #     Note: languages must be enabled in the agent before they can be used.
          class GetEntityTypeRequest; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::EntityTypes::CreateEntityType EntityTypes::CreateEntityType}.
          # @!attribute [rw] parent
          #   @return [String]
          #     Required. The agent to create a entity type for.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent ID>`.
          # @!attribute [rw] entity_type
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::EntityType]
          #     Required. The entity type to create.
          # @!attribute [rw] language_code
          #   @return [String]
          #     The language of the following fields in `entity_type`:
          #
          #     * `EntityType.entities.value`
          #     * `EntityType.entities.synonyms`
          #     * `EntityType.excluded_phrases.value`
          #
          #     If not specified, the agent's default language is used.
          #     [Many
          #     languages](https://cloud.google.com/dialogflow/cx/docs/reference/language)
          #     are supported.
          #     Note: languages must be enabled in the agent before they can be used.
          class CreateEntityTypeRequest; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::EntityTypes::UpdateEntityType EntityTypes::UpdateEntityType}.
          # @!attribute [rw] entity_type
          #   @return [Google::Cloud::Dialogflow::Cx::V3beta1::EntityType]
          #     Required. The entity type to update.
          # @!attribute [rw] language_code
          #   @return [String]
          #     The language of the following fields in `entity_type`:
          #
          #     * `EntityType.entities.value`
          #     * `EntityType.entities.synonyms`
          #     * `EntityType.excluded_phrases.value`
          #
          #     If not specified, the agent's default language is used.
          #     [Many
          #     languages](https://cloud.google.com/dialogflow/cx/docs/reference/language)
          #     are supported.
          #     Note: languages must be enabled in the agent before they can be used.
          # @!attribute [rw] update_mask
          #   @return [Google::Protobuf::FieldMask]
          #     The mask to control which fields get updated.
          class UpdateEntityTypeRequest; end

          # The request message for {Google::Cloud::Dialogflow::Cx::V3beta1::EntityTypes::DeleteEntityType EntityTypes::DeleteEntityType}.
          # @!attribute [rw] name
          #   @return [String]
          #     Required. The name of the entity type to delete.
          #     Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
          #     ID>/entityTypes/<Entity Type ID>`.
          # @!attribute [rw] force
          #   @return [true, false]
          #     This field has no effect for entity type not being used.
          #     For entity types that are used by intents or pages:
          #
          #     * If `force` is set to false, an error will be returned with message
          #       indicating the referencing resources.
          #     * If `force` is set to true, Dialogflow will remove the entity type, as
          #       well as any references to the entity type (i.e. Page
          #       {Google::Cloud::Dialogflow::Cx::V3beta1::Form::Parameter parameter} of the entity type will be changed to
          #       '@sys.any' and intent {Google::Cloud::Dialogflow::Cx::V3beta1::Intent::Parameter parameter} of the entity type
          #       will be removed).
          class DeleteEntityTypeRequest; end
        end
      end
    end
  end
end