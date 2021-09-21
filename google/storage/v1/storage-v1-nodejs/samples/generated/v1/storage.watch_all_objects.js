// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.


'use strict';

function main() {
  // [START storage_watch_all_objects_sample]
  /**
   * TODO(developer): Uncomment these variables before running the sample.
   */
  /**
   *  Name of the bucket in which to look for objects.
   */
  // const bucket = 'abc123'
  /**
   *  If `true`, lists all versions of an object as distinct results.
   *  The default is `false`. For more information, see
   *  [Object
   *  Versioning](https://cloud.google.com/storage/docs/object-versioning).
   */
  // const versions = true
  /**
   *  Returns results in a directory-like mode. `items` will contain
   *  only objects whose names, aside from the `prefix`, do not
   *  contain `delimiter`. Objects whose names, aside from the
   *  `prefix`, contain `delimiter` will have their name,
   *  truncated after the `delimiter`, returned in
   *  `prefixes`. Duplicate `prefixes` are omitted.
   */
  // const delimiter = 'abc123'
  /**
   *  Maximum number of `items` plus `prefixes` to return
   *  in a single page of responses. As duplicate `prefixes` are
   *  omitted, fewer total results may be returned than requested. The service
   *  will use this parameter or 1,000 items, whichever is smaller.
   */
  // const maxResults = 1234
  /**
   *  Filter results to objects whose names begin with this prefix.
   */
  // const prefix = 'abc123'
  /**
   *  If true, objects that end in exactly one instance of `delimiter`
   *  will have their metadata included in `items` in addition to
   *  `prefixes`.
   */
  // const includeTrailingDelimiter = true
  /**
   *  A previously-returned page token representing part of the larger set of
   *  results to view.
   */
  // const pageToken = 'abc123'
  /**
   *  Set of properties to return. Defaults to `NO_ACL`.
   */
  // const projection = ''
  /**
   *  Properties of the channel to be inserted.
   */
  // const channel = ''
  /**
   *  A set of parameters common to all Storage API requests.
   */
  // const commonRequestParams = ''

  // Imports the Storage library
  const {StorageClient} = require('storage').v1;

  // Instantiates a client
  const storageClient = new StorageClient();

  async function watchAllObjects() {
    // Construct request
    const request = {
    };

    // Run request
    const response = await storageClient.watchAllObjects(request);
    console.log(response);
  }

  watchAllObjects();
  // [END storage_watch_all_objects_sample]
}

process.on('unhandledRejection', err => {
  console.error(err.message);
  process.exitCode = 1;
});
main(...process.argv.slice(2));
