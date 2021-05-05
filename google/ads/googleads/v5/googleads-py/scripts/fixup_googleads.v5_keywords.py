#! /usr/bin/env python3
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
import argparse
import os
import libcst as cst
import pathlib
import sys
from typing import (Any, Callable, Dict, List, Sequence, Tuple)


def partition(
    predicate: Callable[[Any], bool],
    iterator: Sequence[Any]
) -> Tuple[List[Any], List[Any]]:
    """A stable, out-of-place partition."""
    results = ([], [])

    for i in iterator:
        results[int(predicate(i))].append(i)

    # Returns trueList, falseList
    return results[1], results[0]


class googleadsCallTransformer(cst.CSTTransformer):
    CTRL_PARAMS: Tuple[str] = ('retry', 'timeout', 'metadata')
    METHOD_TO_PARAMS: Dict[str, Tuple[str]] = {
          'add_batch_job_operations': ('resource_name', 'mutate_operations', 'sequence_token', ),
          'add_offline_user_data_job_operations': ('resource_name', 'operations', 'enable_partial_failure', ),
          'apply_recommendation': ('customer_id', 'operations', 'partial_failure', ),
          'create_account_link': ('customer_id', 'account_link', ),
          'create_campaign_experiment': ('customer_id', 'campaign_experiment', 'validate_only', ),
          'create_customer_client': ('customer_id', 'customer_client', 'email_address', 'access_role', ),
          'create_offline_user_data_job': ('customer_id', 'job', ),
          'dismiss_recommendation': ('customer_id', 'operations', 'partial_failure', ),
          'end_campaign_experiment': ('campaign_experiment', ),
          'generate_forecast_curve': ('keyword_plan', ),
          'generate_forecast_metrics': ('keyword_plan', ),
          'generate_forecast_time_series': ('keyword_plan', ),
          'generate_historical_metrics': ('keyword_plan', ),
          'generate_keyword_ideas': ('language', 'customer_id', 'geo_target_constants', 'include_adult_keywords', 'page_token', 'page_size', 'keyword_plan_network', 'keyword_and_url_seed', 'keyword_seed', 'url_seed', 'site_seed', ),
          'generate_product_mix_ideas': ('customer_id', 'plannable_location_id', 'currency_code', 'budget_micros', 'preferences', ),
          'generate_reach_forecast': ('customer_id', 'campaign_duration', 'planned_products', 'currency_code', 'cookie_frequency_cap', 'cookie_frequency_cap_setting', 'min_effective_frequency', 'targeting', ),
          'get_account_budget': ('resource_name', ),
          'get_account_budget_proposal': ('resource_name', ),
          'get_account_link': ('resource_name', ),
          'get_ad': ('resource_name', ),
          'get_ad_group': ('resource_name', ),
          'get_ad_group_ad': ('resource_name', ),
          'get_ad_group_ad_asset_view': ('resource_name', ),
          'get_ad_group_ad_label': ('resource_name', ),
          'get_ad_group_audience_view': ('resource_name', ),
          'get_ad_group_bid_modifier': ('resource_name', ),
          'get_ad_group_criterion': ('resource_name', ),
          'get_ad_group_criterion_label': ('resource_name', ),
          'get_ad_group_criterion_simulation': ('resource_name', ),
          'get_ad_group_extension_setting': ('resource_name', ),
          'get_ad_group_feed': ('resource_name', ),
          'get_ad_group_label': ('resource_name', ),
          'get_ad_group_simulation': ('resource_name', ),
          'get_ad_parameter': ('resource_name', ),
          'get_ad_schedule_view': ('resource_name', ),
          'get_age_range_view': ('resource_name', ),
          'get_asset': ('resource_name', ),
          'get_batch_job': ('resource_name', ),
          'get_bidding_strategy': ('resource_name', ),
          'get_billing_setup': ('resource_name', ),
          'get_campaign': ('resource_name', ),
          'get_campaign_asset': ('resource_name', ),
          'get_campaign_audience_view': ('resource_name', ),
          'get_campaign_bid_modifier': ('resource_name', ),
          'get_campaign_budget': ('resource_name', ),
          'get_campaign_criterion': ('resource_name', ),
          'get_campaign_criterion_simulation': ('resource_name', ),
          'get_campaign_draft': ('resource_name', ),
          'get_campaign_experiment': ('resource_name', ),
          'get_campaign_extension_setting': ('resource_name', ),
          'get_campaign_feed': ('resource_name', ),
          'get_campaign_label': ('resource_name', ),
          'get_campaign_shared_set': ('resource_name', ),
          'get_carrier_constant': ('resource_name', ),
          'get_change_status': ('resource_name', ),
          'get_click_view': ('resource_name', ),
          'get_conversion_action': ('resource_name', ),
          'get_currency_constant': ('resource_name', ),
          'get_customer': ('resource_name', ),
          'get_customer_client': ('resource_name', ),
          'get_customer_client_link': ('resource_name', ),
          'get_customer_extension_setting': ('resource_name', ),
          'get_customer_feed': ('resource_name', ),
          'get_customer_label': ('resource_name', ),
          'get_customer_manager_link': ('resource_name', ),
          'get_customer_negative_criterion': ('resource_name', ),
          'get_custom_interest': ('resource_name', ),
          'get_detail_placement_view': ('resource_name', ),
          'get_display_keyword_view': ('resource_name', ),
          'get_distance_view': ('resource_name', ),
          'get_domain_category': ('resource_name', ),
          'get_dynamic_search_ads_search_term_view': ('resource_name', ),
          'get_expanded_landing_page_view': ('resource_name', ),
          'get_extension_feed_item': ('resource_name', ),
          'get_feed': ('resource_name', ),
          'get_feed_item': ('resource_name', ),
          'get_feed_item_target': ('resource_name', ),
          'get_feed_mapping': ('resource_name', ),
          'get_feed_placeholder_view': ('resource_name', ),
          'get_gender_view': ('resource_name', ),
          'get_geographic_view': ('resource_name', ),
          'get_geo_target_constant': ('resource_name', ),
          'get_google_ads_field': ('resource_name', ),
          'get_group_placement_view': ('resource_name', ),
          'get_hotel_group_view': ('resource_name', ),
          'get_hotel_performance_view': ('resource_name', ),
          'get_income_range_view': ('resource_name', ),
          'get_keyword_plan': ('resource_name', ),
          'get_keyword_plan_ad_group': ('resource_name', ),
          'get_keyword_plan_ad_group_keyword': ('resource_name', ),
          'get_keyword_plan_campaign': ('resource_name', ),
          'get_keyword_plan_campaign_keyword': ('resource_name', ),
          'get_keyword_view': ('resource_name', ),
          'get_label': ('resource_name', ),
          'get_landing_page_view': ('resource_name', ),
          'get_language_constant': ('resource_name', ),
          'get_location_view': ('resource_name', ),
          'get_managed_placement_view': ('resource_name', ),
          'get_media_file': ('resource_name', ),
          'get_merchant_center_link': ('resource_name', ),
          'get_mobile_app_category_constant': ('resource_name', ),
          'get_mobile_device_constant': ('resource_name', ),
          'get_offline_user_data_job': ('resource_name', ),
          'get_operating_system_version_constant': ('resource_name', ),
          'get_paid_organic_search_term_view': ('resource_name', ),
          'get_parental_status_view': ('resource_name', ),
          'get_product_bidding_category_constant': ('resource_name', ),
          'get_product_group_view': ('resource_name', ),
          'get_recommendation': ('resource_name', ),
          'get_remarketing_action': ('resource_name', ),
          'get_search_term_view': ('resource_name', ),
          'get_shared_criterion': ('resource_name', ),
          'get_shared_set': ('resource_name', ),
          'get_shopping_performance_view': ('resource_name', ),
          'get_third_party_app_analytics_link': ('resource_name', ),
          'get_topic_constant': ('resource_name', ),
          'get_topic_view': ('resource_name', ),
          'get_user_interest': ('resource_name', ),
          'get_user_list': ('resource_name', ),
          'get_user_location_view': ('resource_name', ),
          'get_video': ('resource_name', ),
          'graduate_campaign_experiment': ('campaign_experiment', 'campaign_budget', ),
          'list_accessible_customers': (),
          'list_batch_job_results': ('resource_name', 'page_token', 'page_size', ),
          'list_campaign_draft_async_errors': ('resource_name', 'page_token', 'page_size', ),
          'list_campaign_experiment_async_errors': ('resource_name', 'page_token', 'page_size', ),
          'list_invoices': ('customer_id', 'billing_setup', 'issue_year', 'issue_month', ),
          'list_merchant_center_links': ('customer_id', ),
          'list_payments_accounts': ('customer_id', ),
          'list_plannable_locations': (),
          'list_plannable_products': ('plannable_location_id', ),
          'move_manager_link': ('customer_id', 'previous_customer_manager_link', 'new_manager', ),
          'mutate': ('customer_id', 'mutate_operations', 'partial_failure', 'validate_only', 'response_content_type', ),
          'mutate_account_budget_proposal': ('customer_id', 'operation', 'validate_only', ),
          'mutate_account_link': ('customer_id', 'operation', 'partial_failure', 'validate_only', ),
          'mutate_ad_group_ad_labels': ('customer_id', 'operations', 'partial_failure', 'validate_only', ),
          'mutate_ad_group_ads': ('customer_id', 'operations', 'partial_failure', 'validate_only', 'response_content_type', ),
          'mutate_ad_group_bid_modifiers': ('customer_id', 'operations', 'partial_failure', 'validate_only', 'response_content_type', ),
          'mutate_ad_group_criteria': ('customer_id', 'operations', 'partial_failure', 'validate_only', 'response_content_type', ),
          'mutate_ad_group_criterion_labels': ('customer_id', 'operations', 'partial_failure', 'validate_only', ),
          'mutate_ad_group_extension_settings': ('customer_id', 'operations', 'partial_failure', 'validate_only', ),
          'mutate_ad_group_feeds': ('customer_id', 'operations', 'partial_failure', 'validate_only', 'response_content_type', ),
          'mutate_ad_group_labels': ('customer_id', 'operations', 'partial_failure', 'validate_only', ),
          'mutate_ad_groups': ('customer_id', 'operations', 'partial_failure', 'validate_only', 'response_content_type', ),
          'mutate_ad_parameters': ('customer_id', 'operations', 'partial_failure', 'validate_only', ),
          'mutate_ads': ('customer_id', 'operations', 'response_content_type', ),
          'mutate_assets': ('customer_id', 'operations', 'response_content_type', ),
          'mutate_batch_job': ('customer_id', 'operation', ),
          'mutate_bidding_strategies': ('customer_id', 'operations', 'partial_failure', 'validate_only', ),
          'mutate_billing_setup': ('customer_id', 'operation', ),
          'mutate_campaign_assets': ('customer_id', 'operations', 'partial_failure', 'validate_only', ),
          'mutate_campaign_bid_modifiers': ('customer_id', 'operations', 'partial_failure', 'validate_only', ),
          'mutate_campaign_budgets': ('customer_id', 'operations', 'partial_failure', 'validate_only', 'response_content_type', ),
          'mutate_campaign_criteria': ('customer_id', 'operations', 'partial_failure', 'validate_only', 'response_content_type', ),
          'mutate_campaign_drafts': ('customer_id', 'operations', 'partial_failure', 'validate_only', 'response_content_type', ),
          'mutate_campaign_experiments': ('customer_id', 'operations', 'partial_failure', 'validate_only', 'response_content_type', ),
          'mutate_campaign_extension_settings': ('customer_id', 'operations', 'partial_failure', 'validate_only', ),
          'mutate_campaign_feeds': ('customer_id', 'operations', 'partial_failure', 'validate_only', 'response_content_type', ),
          'mutate_campaign_labels': ('customer_id', 'operations', 'partial_failure', 'validate_only', ),
          'mutate_campaigns': ('customer_id', 'operations', 'partial_failure', 'validate_only', 'response_content_type', ),
          'mutate_campaign_shared_sets': ('customer_id', 'operations', 'partial_failure', 'validate_only', ),
          'mutate_conversion_actions': ('customer_id', 'operations', 'partial_failure', 'validate_only', ),
          'mutate_customer': ('customer_id', 'operation', 'validate_only', 'response_content_type', ),
          'mutate_customer_client_link': ('customer_id', 'operation', ),
          'mutate_customer_extension_settings': ('customer_id', 'operations', 'partial_failure', 'validate_only', ),
          'mutate_customer_feeds': ('customer_id', 'operations', 'partial_failure', 'validate_only', 'response_content_type', ),
          'mutate_customer_labels': ('customer_id', 'operations', 'partial_failure', 'validate_only', ),
          'mutate_customer_manager_link': ('customer_id', 'operations', ),
          'mutate_customer_negative_criteria': ('customer_id', 'operations', 'partial_failure', 'validate_only', ),
          'mutate_custom_interests': ('customer_id', 'operations', 'validate_only', ),
          'mutate_extension_feed_items': ('customer_id', 'operations', 'partial_failure', 'validate_only', 'response_content_type', ),
          'mutate_feed_items': ('customer_id', 'operations', 'partial_failure', 'validate_only', 'response_content_type', ),
          'mutate_feed_item_targets': ('customer_id', 'operations', ),
          'mutate_feed_mappings': ('customer_id', 'operations', 'partial_failure', 'validate_only', ),
          'mutate_feeds': ('customer_id', 'operations', 'partial_failure', 'validate_only', 'response_content_type', ),
          'mutate_keyword_plan_ad_group_keywords': ('customer_id', 'operations', 'partial_failure', 'validate_only', ),
          'mutate_keyword_plan_ad_groups': ('customer_id', 'operations', 'partial_failure', 'validate_only', ),
          'mutate_keyword_plan_campaign_keywords': ('customer_id', 'operations', 'partial_failure', 'validate_only', ),
          'mutate_keyword_plan_campaigns': ('customer_id', 'operations', 'partial_failure', 'validate_only', ),
          'mutate_keyword_plans': ('customer_id', 'operations', 'partial_failure', 'validate_only', ),
          'mutate_labels': ('customer_id', 'operations', 'partial_failure', 'validate_only', 'response_content_type', ),
          'mutate_media_files': ('customer_id', 'operations', 'partial_failure', 'validate_only', 'response_content_type', ),
          'mutate_merchant_center_link': ('customer_id', 'operation', ),
          'mutate_remarketing_actions': ('customer_id', 'operations', 'partial_failure', 'validate_only', ),
          'mutate_shared_criteria': ('customer_id', 'operations', 'partial_failure', 'validate_only', ),
          'mutate_shared_sets': ('customer_id', 'operations', 'partial_failure', 'validate_only', 'response_content_type', ),
          'mutate_user_lists': ('customer_id', 'operations', 'partial_failure', 'validate_only', ),
          'promote_campaign_draft': ('campaign_draft', ),
          'promote_campaign_experiment': ('campaign_experiment', ),
          'regenerate_shareable_link_id': ('resource_name', ),
          'run_batch_job': ('resource_name', ),
          'run_offline_user_data_job': ('resource_name', ),
          'search': ('customer_id', 'query', 'page_token', 'page_size', 'validate_only', 'return_total_results_count', 'summary_row_setting', ),
          'search_google_ads_fields': ('query', 'page_token', 'page_size', ),
          'search_stream': ('customer_id', 'query', 'summary_row_setting', ),
          'suggest_geo_target_constants': ('locale', 'country_code', 'location_names', 'geo_targets', ),
          'upload_call_conversions': ('customer_id', 'conversions', 'partial_failure', 'validate_only', ),
          'upload_click_conversions': ('customer_id', 'conversions', 'partial_failure', 'validate_only', ),
          'upload_conversion_adjustments': ('customer_id', 'conversion_adjustments', 'partial_failure', 'validate_only', ),
          'upload_user_data': ('customer_id', 'operations', 'customer_match_user_list_metadata', ),
    }

    def leave_Call(self, original: cst.Call, updated: cst.Call) -> cst.CSTNode:
        try:
            key = original.func.attr.value
            kword_params = self.METHOD_TO_PARAMS[key]
        except (AttributeError, KeyError):
            # Either not a method from the API or too convoluted to be sure.
            return updated

        # If the existing code is valid, keyword args come after positional args.
        # Therefore, all positional args must map to the first parameters.
        args, kwargs = partition(lambda a: not bool(a.keyword), updated.args)
        if any(k.keyword.value == "request" for k in kwargs):
            # We've already fixed this file, don't fix it again.
            return updated

        kwargs, ctrl_kwargs = partition(
            lambda a: not a.keyword.value in self.CTRL_PARAMS,
            kwargs
        )

        args, ctrl_args = args[:len(kword_params)], args[len(kword_params):]
        ctrl_kwargs.extend(cst.Arg(value=a.value, keyword=cst.Name(value=ctrl))
                           for a, ctrl in zip(ctrl_args, self.CTRL_PARAMS))

        request_arg = cst.Arg(
            value=cst.Dict([
                cst.DictElement(
                    cst.SimpleString("'{}'".format(name)),
cst.Element(value=arg.value)
                )
                # Note: the args + kwargs looks silly, but keep in mind that
                # the control parameters had to be stripped out, and that
                # those could have been passed positionally or by keyword.
                for name, arg in zip(kword_params, args + kwargs)]),
            keyword=cst.Name("request")
        )

        return updated.with_changes(
            args=[request_arg] + ctrl_kwargs
        )


def fix_files(
    in_dir: pathlib.Path,
    out_dir: pathlib.Path,
    *,
    transformer=googleadsCallTransformer(),
):
    """Duplicate the input dir to the output dir, fixing file method calls.

    Preconditions:
    * in_dir is a real directory
    * out_dir is a real, empty directory
    """
    pyfile_gen = (
        pathlib.Path(os.path.join(root, f))
        for root, _, files in os.walk(in_dir)
        for f in files if os.path.splitext(f)[1] == ".py"
    )

    for fpath in pyfile_gen:
        with open(fpath, 'r') as f:
            src = f.read()

        # Parse the code and insert method call fixes.
        tree = cst.parse_module(src)
        updated = tree.visit(transformer)

        # Create the path and directory structure for the new file.
        updated_path = out_dir.joinpath(fpath.relative_to(in_dir))
        updated_path.parent.mkdir(parents=True, exist_ok=True)

        # Generate the updated source file at the corresponding path.
        with open(updated_path, 'w') as f:
            f.write(updated.code)


if __name__ == '__main__':
    parser = argparse.ArgumentParser(
        description="""Fix up source that uses the googleads client library.

The existing sources are NOT overwritten but are copied to output_dir with changes made.

Note: This tool operates at a best-effort level at converting positional
      parameters in client method calls to keyword based parameters.
      Cases where it WILL FAIL include
      A) * or ** expansion in a method call.
      B) Calls via function or method alias (includes free function calls)
      C) Indirect or dispatched calls (e.g. the method is looked up dynamically)

      These all constitute false negatives. The tool will also detect false
      positives when an API method shares a name with another method.
""")
    parser.add_argument(
        '-d',
        '--input-directory',
        required=True,
        dest='input_dir',
        help='the input directory to walk for python files to fix up',
    )
    parser.add_argument(
        '-o',
        '--output-directory',
        required=True,
        dest='output_dir',
        help='the directory to output files fixed via un-flattening',
    )
    args = parser.parse_args()
    input_dir = pathlib.Path(args.input_dir)
    output_dir = pathlib.Path(args.output_dir)
    if not input_dir.is_dir():
        print(
            f"input directory '{input_dir}' does not exist or is not a directory",
            file=sys.stderr,
        )
        sys.exit(-1)

    if not output_dir.is_dir():
        print(
            f"output directory '{output_dir}' does not exist or is not a directory",
            file=sys.stderr,
        )
        sys.exit(-1)

    if os.listdir(output_dir):
        print(
            f"output directory '{output_dir}' is not empty",
            file=sys.stderr,
        )
        sys.exit(-1)

    fix_files(input_dir, output_dir)
