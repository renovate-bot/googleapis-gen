# -*- coding: utf-8 -*-
# Copyright 2020 Google LLC
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
#
import proto  # type: ignore


__protobuf__ = proto.module(
    package='google.cloud.retail.v2alpha',
    manifest={
        'ProductLevelConfig',
        'MerchantCenterLink',
        'MerchantCenterLinkingConfig',
        'Catalog',
    },
)


class ProductLevelConfig(proto.Message):
    r"""Configures what level the product should be uploaded with
    regards to how users will be send events and how predictions
    will be made.

    Attributes:
        ingestion_product_type (str):
            The type of [Product][google.cloud.retail.v2alpha.Product]s
            allowed to be ingested into the catalog. Acceptable values
            are:

            -  ``primary`` (default): You can ingest
               [Product][google.cloud.retail.v2alpha.Product]s of all
               types. When ingesting a
               [Product][google.cloud.retail.v2alpha.Product], its type
               will default to
               [Product.Type.PRIMARY][google.cloud.retail.v2alpha.Product.Type.PRIMARY]
               if unset.
            -  ``variant``: You can only ingest
               [Product.Type.VARIANT][google.cloud.retail.v2alpha.Product.Type.VARIANT]
               [Product][google.cloud.retail.v2alpha.Product]s. This
               means
               [Product.primary_product_id][google.cloud.retail.v2alpha.Product.primary_product_id]
               cannot be empty.

            If this field is set to an invalid value other than these,
            an INVALID_ARGUMENT error is returned.

            If this field is ``variant`` and
            [merchant_center_product_id_field][google.cloud.retail.v2alpha.ProductLevelConfig.merchant_center_product_id_field]
            is ``itemGroupId``, an INVALID_ARGUMENT error is returned.

            See `Using product
            levels <https://cloud.google.com/retail/recommendations-ai/docs/catalog#product-levels>`__
            for more details.
        merchant_center_product_id_field (str):
            Which field of `Merchant Center
            Product </bigquery-transfer/docs/merchant-center-products-schema>`__
            should be imported as
            [Product.id][google.cloud.retail.v2alpha.Product.id].
            Acceptable values are:

            -  ``offerId`` (default): Import ``offerId`` as the product
               ID.
            -  ``itemGroupId``: Import ``itemGroupId`` as the product
               ID. Notice that Retail API will choose one item from the
               ones with the same ``itemGroupId``, and use it to
               represent the item group.

            If this field is set to an invalid value other than these,
            an INVALID_ARGUMENT error is returned.

            If this field is ``itemGroupId`` and
            [ingestion_product_type][google.cloud.retail.v2alpha.ProductLevelConfig.ingestion_product_type]
            is ``variant``, an INVALID_ARGUMENT error is returned.

            See `Using product
            levels <https://cloud.google.com/retail/recommendations-ai/docs/catalog#product-levels>`__
            for more details.
    """

    ingestion_product_type = proto.Field(
        proto.STRING,
        number=1,
    )
    merchant_center_product_id_field = proto.Field(
        proto.STRING,
        number=2,
    )


class MerchantCenterLink(proto.Message):
    r"""Represents a link between a Merchant Center account and a
    branch. Once a link is established, products from the linked
    merchant center account will be streamed to the linked branch.

    Attributes:
        merchant_center_account_id (int):
            Required. The linked `Merchant center account
            id <https://developers.google.com/shopping-content/guides/accountstatuses>`__.
            The account must be a standalone account or a sub-account of
            a MCA.
        branch_id (str):
            The branch id (e.g. 0/1/2) within this catalog that products
            from merchant_center_account_id are streamed to. When
            updating this field, an empty value will use the currently
            configured default branch. However, changing the default
            branch later on won't change the linked branch here.

            A single branch id can only have one linked merchant center
            account id.
        destinations (Sequence[str]):
            String representing the destination to import for, all if
            left empty. List of possible values can be found here.
            [https://support.google.com/merchants/answer/7501026] List
            of allowed string values: "Shopping_ads",
            "Buy_on_google_listings", "Display_ads", "Local_inventory
            \_ads", "Free_listings", "Free_local_listings" NOTE: The
            string values are case sensitive.
    """

    merchant_center_account_id = proto.Field(
        proto.INT64,
        number=1,
    )
    branch_id = proto.Field(
        proto.STRING,
        number=2,
    )
    destinations = proto.RepeatedField(
        proto.STRING,
        number=3,
    )


class MerchantCenterLinkingConfig(proto.Message):
    r"""Configures Merchant Center linking.
    Links contained in the config will be used to sync data from a
    Merchant Center account to a Cloud Retail branch.

    Attributes:
        links (Sequence[google.cloud.retail_v2alpha.types.MerchantCenterLink]):
            Links between Merchant Center accounts and
            branches.
    """

    links = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='MerchantCenterLink',
    )


class Catalog(proto.Message):
    r"""The catalog configuration.

    Attributes:
        name (str):
            Required. Immutable. The fully qualified
            resource name of the catalog.
        display_name (str):
            Required. Immutable. The catalog display name.

            This field must be a UTF-8 encoded string with a length
            limit of 128 characters. Otherwise, an INVALID_ARGUMENT
            error is returned.
        product_level_config (google.cloud.retail_v2alpha.types.ProductLevelConfig):
            Required. The product level configuration.
        merchant_center_linking_config (google.cloud.retail_v2alpha.types.MerchantCenterLinkingConfig):
            The Merchant Center linking configuration.
            Once a link is added, the data stream from
            Merchant Center to Cloud Retail will be enabled
            automatically. The requester must have access to
            the merchant center account in order to make
            changes to this field.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    display_name = proto.Field(
        proto.STRING,
        number=2,
    )
    product_level_config = proto.Field(
        proto.MESSAGE,
        number=4,
        message='ProductLevelConfig',
    )
    merchant_center_linking_config = proto.Field(
        proto.MESSAGE,
        number=6,
        message='MerchantCenterLinkingConfig',
    )


__all__ = tuple(sorted(__protobuf__.manifest))
