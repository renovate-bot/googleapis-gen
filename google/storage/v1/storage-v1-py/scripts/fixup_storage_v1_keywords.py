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


class storageCallTransformer(cst.CSTTransformer):
    CTRL_PARAMS: Tuple[str] = ('retry', 'timeout', 'metadata')
    METHOD_TO_PARAMS: Dict[str, Tuple[str]] = {
    'compose_object': ('destination_bucket', 'destination_object', 'destination_predefined_acl', 'destination', 'source_objects', 'if_generation_match', 'if_metageneration_match', 'kms_key_name', 'common_object_request_params', 'common_request_params', ),
    'copy_object': ('destination_bucket', 'destination_object', 'source_bucket', 'source_object', 'destination_predefined_acl', 'if_generation_match', 'if_generation_not_match', 'if_metageneration_match', 'if_metageneration_not_match', 'if_source_generation_match', 'if_source_generation_not_match', 'if_source_metageneration_match', 'if_source_metageneration_not_match', 'projection', 'source_generation', 'destination', 'destination_kms_key_name', 'common_object_request_params', 'common_request_params', ),
    'create_hmac_key': ('project_id', 'service_account_email', 'common_request_params', ),
    'delete_bucket': ('bucket', 'if_metageneration_match', 'if_metageneration_not_match', 'common_request_params', ),
    'delete_bucket_access_control': ('bucket', 'entity', 'common_request_params', ),
    'delete_default_object_access_control': ('bucket', 'entity', 'common_request_params', ),
    'delete_hmac_key': ('access_id', 'project_id', 'common_request_params', ),
    'delete_notification': ('bucket', 'notification', 'common_request_params', ),
    'delete_object': ('bucket', 'object_', 'upload_id', 'generation', 'if_generation_match', 'if_generation_not_match', 'if_metageneration_match', 'if_metageneration_not_match', 'common_object_request_params', 'common_request_params', ),
    'delete_object_access_control': ('bucket', 'entity', 'object_', 'generation', 'common_request_params', ),
    'get_bucket': ('bucket', 'if_metageneration_match', 'if_metageneration_not_match', 'projection', 'common_request_params', ),
    'get_bucket_access_control': ('bucket', 'entity', 'common_request_params', ),
    'get_bucket_iam_policy': ('iam_request', 'common_request_params', ),
    'get_default_object_access_control': ('bucket', 'entity', 'common_request_params', ),
    'get_hmac_key': ('access_id', 'project_id', 'common_request_params', ),
    'get_notification': ('bucket', 'notification', 'common_request_params', ),
    'get_object': ('bucket', 'object_', 'generation', 'if_generation_match', 'if_generation_not_match', 'if_metageneration_match', 'if_metageneration_not_match', 'projection', 'common_object_request_params', 'common_request_params', ),
    'get_object_access_control': ('bucket', 'entity', 'object_', 'generation', 'common_request_params', ),
    'get_object_iam_policy': ('iam_request', 'common_request_params', ),
    'get_object_media': ('bucket', 'object_', 'generation', 'read_offset', 'read_limit', 'if_generation_match', 'if_generation_not_match', 'if_metageneration_match', 'if_metageneration_not_match', 'common_object_request_params', 'common_request_params', ),
    'get_service_account': ('project_id', 'common_request_params', ),
    'insert_bucket': ('project', 'predefined_acl', 'predefined_default_object_acl', 'projection', 'bucket', 'common_request_params', ),
    'insert_bucket_access_control': ('bucket', 'bucket_access_control', 'common_request_params', ),
    'insert_default_object_access_control': ('bucket', 'object_access_control', 'common_request_params', ),
    'insert_notification': ('bucket', 'notification', 'common_request_params', ),
    'insert_object': ('write_offset', 'upload_id', 'insert_object_spec', 'checksummed_data', 'reference', 'object_checksums', 'finish_write', 'common_object_request_params', 'common_request_params', ),
    'insert_object_access_control': ('bucket', 'object_', 'generation', 'object_access_control', 'common_request_params', ),
    'list_bucket_access_controls': ('bucket', 'common_request_params', ),
    'list_buckets': ('project', 'max_results', 'page_token', 'prefix', 'projection', 'common_request_params', ),
    'list_channels': ('bucket', 'common_request_params', ),
    'list_default_object_access_controls': ('bucket', 'if_metageneration_match', 'if_metageneration_not_match', 'common_request_params', ),
    'list_hmac_keys': ('project_id', 'service_account_email', 'show_deleted_keys', 'max_results', 'page_token', 'common_request_params', ),
    'list_notifications': ('bucket', 'common_request_params', ),
    'list_object_access_controls': ('bucket', 'object_', 'generation', 'common_request_params', ),
    'list_objects': ('bucket', 'delimiter', 'include_trailing_delimiter', 'max_results', 'page_token', 'prefix', 'projection', 'versions', 'common_request_params', ),
    'lock_bucket_retention_policy': ('bucket', 'if_metageneration_match', 'common_request_params', ),
    'patch_bucket': ('bucket', 'if_metageneration_match', 'if_metageneration_not_match', 'predefined_acl', 'predefined_default_object_acl', 'projection', 'metadata', 'update_mask', 'common_request_params', ),
    'patch_bucket_access_control': ('bucket', 'entity', 'bucket_access_control', 'update_mask', 'common_request_params', ),
    'patch_default_object_access_control': ('bucket', 'entity', 'object_access_control', 'update_mask', 'common_request_params', ),
    'patch_object': ('bucket', 'object_', 'generation', 'if_generation_match', 'if_generation_not_match', 'if_metageneration_match', 'if_metageneration_not_match', 'predefined_acl', 'projection', 'metadata', 'update_mask', 'common_object_request_params', 'common_request_params', ),
    'patch_object_access_control': ('bucket', 'entity', 'object_', 'generation', 'object_access_control', 'common_request_params', 'update_mask', ),
    'query_write_status': ('upload_id', 'common_object_request_params', 'common_request_params', ),
    'rewrite_object': ('destination_bucket', 'destination_object', 'source_bucket', 'source_object', 'destination_kms_key_name', 'destination_predefined_acl', 'if_generation_match', 'if_generation_not_match', 'if_metageneration_match', 'if_metageneration_not_match', 'if_source_generation_match', 'if_source_generation_not_match', 'if_source_metageneration_match', 'if_source_metageneration_not_match', 'max_bytes_rewritten_per_call', 'projection', 'rewrite_token', 'source_generation', 'object_', 'copy_source_encryption_algorithm', 'copy_source_encryption_key', 'copy_source_encryption_key_sha256', 'common_object_request_params', 'common_request_params', ),
    'set_bucket_iam_policy': ('iam_request', 'common_request_params', ),
    'set_object_iam_policy': ('iam_request', 'common_request_params', ),
    'start_resumable_write': ('insert_object_spec', 'common_object_request_params', 'common_request_params', ),
    'stop_channel': ('channel', 'common_request_params', ),
    'test_bucket_iam_permissions': ('iam_request', 'common_request_params', ),
    'test_object_iam_permissions': ('iam_request', 'common_request_params', ),
    'update_bucket': ('bucket', 'if_metageneration_match', 'if_metageneration_not_match', 'predefined_acl', 'predefined_default_object_acl', 'projection', 'metadata', 'common_request_params', ),
    'update_bucket_access_control': ('bucket', 'entity', 'bucket_access_control', 'common_request_params', ),
    'update_default_object_access_control': ('bucket', 'entity', 'object_access_control', 'common_request_params', ),
    'update_hmac_key': ('access_id', 'project_id', 'metadata', 'common_request_params', ),
    'update_object': ('bucket', 'object_', 'generation', 'if_generation_match', 'if_generation_not_match', 'if_metageneration_match', 'if_metageneration_not_match', 'predefined_acl', 'projection', 'metadata', 'common_object_request_params', 'common_request_params', ),
    'update_object_access_control': ('bucket', 'entity', 'object_', 'generation', 'object_access_control', 'common_request_params', 'update_mask', ),
    'watch_all_objects': ('bucket', 'versions', 'delimiter', 'max_results', 'prefix', 'include_trailing_delimiter', 'page_token', 'projection', 'channel', 'common_request_params', ),

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
    transformer=storageCallTransformer(),
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
        description="""Fix up source that uses the storage client library.

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
