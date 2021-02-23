// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// ** This file is automatically generated by gapic-generator-typescript. **
// ** https://github.com/googleapis/gapic-generator-typescript **
// ** All changes to this file may be overwritten. **

/* global window */
import * as gax from 'google-gax';
import {Callback, CallOptions, Descriptors, ClientOptions, LROperation} from 'google-gax';
import * as path from 'path';

import * as protos from '../../protos/protos';
/**
 * Client JSON configuration object, loaded from
 * `src/v1p7beta1/asset_service_client_config.json`.
 * This file defines retry strategy and timeouts for all API methods in this library.
 */
import * as gapicConfig from './asset_service_client_config.json';
import { operationsProtos } from 'google-gax';
const version = require('../../../package.json').version;

/**
 *  Asset service definition.
 * @class
 * @memberof v1p7beta1
 */
export class AssetServiceClient {
  private _terminated = false;
  private _opts: ClientOptions;
  private _gaxModule: typeof gax | typeof gax.fallback;
  private _gaxGrpc: gax.GrpcClient | gax.fallback.GrpcClient;
  private _protos: {};
  private _defaults: {[method: string]: gax.CallSettings};
  auth: gax.GoogleAuth;
  descriptors: Descriptors = {
    page: {},
    stream: {},
    longrunning: {},
    batching: {},
  };
  innerApiCalls: {[name: string]: Function};
  operationsClient: gax.OperationsClient;
  assetServiceStub?: Promise<{[name: string]: Function}>;

  /**
   * Construct an instance of AssetServiceClient.
   *
   * @param {object} [options] - The configuration object.
   * The options accepted by the constructor are described in detail
   * in [this document](https://github.com/googleapis/gax-nodejs/blob/master/client-libraries.md#creating-the-client-instance).
   * The common options are:
   * @param {object} [options.credentials] - Credentials object.
   * @param {string} [options.credentials.client_email]
   * @param {string} [options.credentials.private_key]
   * @param {string} [options.email] - Account email address. Required when
   *     using a .pem or .p12 keyFilename.
   * @param {string} [options.keyFilename] - Full path to the a .json, .pem, or
   *     .p12 key downloaded from the Google Developers Console. If you provide
   *     a path to a JSON file, the projectId option below is not necessary.
   *     NOTE: .pem and .p12 require you to specify options.email as well.
   * @param {number} [options.port] - The port on which to connect to
   *     the remote host.
   * @param {string} [options.projectId] - The project ID from the Google
   *     Developer's Console, e.g. 'grape-spaceship-123'. We will also check
   *     the environment variable GCLOUD_PROJECT for your project ID. If your
   *     app is running in an environment which supports
   *     {@link https://developers.google.com/identity/protocols/application-default-credentials Application Default Credentials},
   *     your project ID will be detected automatically.
   * @param {string} [options.apiEndpoint] - The domain name of the
   *     API remote host.
   * @param {gax.ClientConfig} [options.clientConfig] - Client configuration override.
   *     Follows the structure of {@link gapicConfig}.
   * @param {boolean} [options.fallback] - Use HTTP fallback mode.
   *     In fallback mode, a special browser-compatible transport implementation is used
   *     instead of gRPC transport. In browser context (if the `window` object is defined)
   *     the fallback mode is enabled automatically; set `options.fallback` to `false`
   *     if you need to override this behavior.
   */
  constructor(opts?: ClientOptions) {
    // Ensure that options include all the required fields.
    const staticMembers = this.constructor as typeof AssetServiceClient;
    const servicePath = opts?.servicePath || opts?.apiEndpoint || staticMembers.servicePath;
    const port = opts?.port || staticMembers.port;
    const clientConfig = opts?.clientConfig ?? {};
    const fallback = opts?.fallback ?? (typeof window !== 'undefined' && typeof window?.fetch === 'function');
    opts = Object.assign({servicePath, port, clientConfig, fallback}, opts);

    // If scopes are unset in options and we're connecting to a non-default endpoint, set scopes just in case.
    if (servicePath !== staticMembers.servicePath && !('scopes' in opts)) {
      opts['scopes'] = staticMembers.scopes;
    }

    // Choose either gRPC or proto-over-HTTP implementation of google-gax.
    this._gaxModule = opts.fallback ? gax.fallback : gax;

    // Create a `gaxGrpc` object, with any grpc-specific options sent to the client.
    this._gaxGrpc = new this._gaxModule.GrpcClient(opts);

    // Save options to use in initialize() method.
    this._opts = opts;

    // Save the auth object to the client, for use by other methods.
    this.auth = (this._gaxGrpc.auth as gax.GoogleAuth);

    // Set the default scopes in auth client if needed.
    if (servicePath === staticMembers.servicePath) {
      this.auth.defaultScopes = staticMembers.scopes;
    }

    // Determine the client header string.
    const clientHeader = [
      `gax/${this._gaxModule.version}`,
      `gapic/${version}`,
    ];
    if (typeof process !== 'undefined' && 'versions' in process) {
      clientHeader.push(`gl-node/${process.versions.node}`);
    } else {
      clientHeader.push(`gl-web/${this._gaxModule.version}`);
    }
    if (!opts.fallback) {
      clientHeader.push(`grpc/${this._gaxGrpc.grpcVersion}`);
    }
    if (opts.libName && opts.libVersion) {
      clientHeader.push(`${opts.libName}/${opts.libVersion}`);
    }
    // Load the applicable protos.
    // For Node.js, pass the path to JSON proto file.
    // For browsers, pass the JSON content.

    const nodejsProtoPath = path.join(__dirname, '..', '..', 'protos', 'protos.json');
    this._protos = this._gaxGrpc.loadProto(
      opts.fallback ?
        // eslint-disable-next-line @typescript-eslint/no-var-requires
        require("../../protos/protos.json") :
        nodejsProtoPath
    );

    // This API contains "long-running operations", which return a
    // an Operation object that allows for tracking of the operation,
    // rather than holding a request open.
    const protoFilesRoot = opts.fallback ?
      this._gaxModule.protobuf.Root.fromJSON(
        // eslint-disable-next-line @typescript-eslint/no-var-requires
        require("../../protos/protos.json")) :
      this._gaxModule.protobuf.loadSync(nodejsProtoPath);

    this.operationsClient = this._gaxModule.lro({
      auth: this.auth,
      grpc: 'grpc' in this._gaxGrpc ? this._gaxGrpc.grpc : undefined
    }).operationsClient(opts);
    const exportAssetsResponse = protoFilesRoot.lookup(
      '.google.cloud.asset.v1p7beta1.ExportAssetsResponse') as gax.protobuf.Type;
    const exportAssetsMetadata = protoFilesRoot.lookup(
      '.google.cloud.asset.v1p7beta1.ExportAssetsRequest') as gax.protobuf.Type;

    this.descriptors.longrunning = {
      exportAssets: new this._gaxModule.LongrunningDescriptor(
        this.operationsClient,
        exportAssetsResponse.decode.bind(exportAssetsResponse),
        exportAssetsMetadata.decode.bind(exportAssetsMetadata))
    };

    // Put together the default options sent with requests.
    this._defaults = this._gaxGrpc.constructSettings(
        'google.cloud.asset.v1p7beta1.AssetService', gapicConfig as gax.ClientConfig,
        opts.clientConfig || {}, {'x-goog-api-client': clientHeader.join(' ')});

    // Set up a dictionary of "inner API calls"; the core implementation
    // of calling the API is handled in `google-gax`, with this code
    // merely providing the destination and request information.
    this.innerApiCalls = {};
  }

  /**
   * Initialize the client.
   * Performs asynchronous operations (such as authentication) and prepares the client.
   * This function will be called automatically when any class method is called for the
   * first time, but if you need to initialize it before calling an actual method,
   * feel free to call initialize() directly.
   *
   * You can await on this method if you want to make sure the client is initialized.
   *
   * @returns {Promise} A promise that resolves to an authenticated service stub.
   */
  initialize() {
    // If the client stub promise is already initialized, return immediately.
    if (this.assetServiceStub) {
      return this.assetServiceStub;
    }

    // Put together the "service stub" for
    // google.cloud.asset.v1p7beta1.AssetService.
    this.assetServiceStub = this._gaxGrpc.createStub(
        this._opts.fallback ?
          (this._protos as protobuf.Root).lookupService('google.cloud.asset.v1p7beta1.AssetService') :
          // eslint-disable-next-line @typescript-eslint/no-explicit-any
          (this._protos as any).google.cloud.asset.v1p7beta1.AssetService,
        this._opts) as Promise<{[method: string]: Function}>;

    // Iterate over each of the methods that the service provides
    // and create an API call method for each.
    const assetServiceStubMethods =
        ['exportAssets'];
    for (const methodName of assetServiceStubMethods) {
      const callPromise = this.assetServiceStub.then(
        stub => (...args: Array<{}>) => {
          if (this._terminated) {
            return Promise.reject('The client has already been closed.');
          }
          const func = stub[methodName];
          return func.apply(stub, args);
        },
        (err: Error|null|undefined) => () => {
          throw err;
        });

      const descriptor =
        this.descriptors.longrunning[methodName] ||
        undefined;
      const apiCall = this._gaxModule.createApiCall(
        callPromise,
        this._defaults[methodName],
        descriptor
      );

      this.innerApiCalls[methodName] = apiCall;
    }

    return this.assetServiceStub;
  }

  /**
   * The DNS address for this API service.
   * @returns {string} The DNS address for this service.
   */
  static get servicePath() {
    return 'cloudasset.googleapis.com';
  }

  /**
   * The DNS address for this API service - same as servicePath(),
   * exists for compatibility reasons.
   * @returns {string} The DNS address for this service.
   */
  static get apiEndpoint() {
    return 'cloudasset.googleapis.com';
  }

  /**
   * The port for this API service.
   * @returns {number} The default port for this service.
   */
  static get port() {
    return 443;
  }

  /**
   * The scopes needed to make gRPC calls for every method defined
   * in this service.
   * @returns {string[]} List of default scopes.
   */
  static get scopes() {
    return [
      'https://www.googleapis.com/auth/cloud-platform'
    ];
  }

  getProjectId(): Promise<string>;
  getProjectId(callback: Callback<string, undefined, undefined>): void;
  /**
   * Return the project ID used by this class.
   * @returns {Promise} A promise that resolves to string containing the project ID.
   */
  getProjectId(callback?: Callback<string, undefined, undefined>):
      Promise<string>|void {
    if (callback) {
      this.auth.getProjectId(callback);
      return;
    }
    return this.auth.getProjectId();
  }

  // -------------------
  // -- Service calls --
  // -------------------

  exportAssets(
      request: protos.google.cloud.asset.v1p7beta1.IExportAssetsRequest,
      options?: CallOptions):
      Promise<[
        LROperation<protos.google.cloud.asset.v1p7beta1.IExportAssetsResponse, protos.google.cloud.asset.v1p7beta1.IExportAssetsRequest>,
        protos.google.longrunning.IOperation|undefined, {}|undefined
      ]>;
  exportAssets(
      request: protos.google.cloud.asset.v1p7beta1.IExportAssetsRequest,
      options: CallOptions,
      callback: Callback<
          LROperation<protos.google.cloud.asset.v1p7beta1.IExportAssetsResponse, protos.google.cloud.asset.v1p7beta1.IExportAssetsRequest>,
          protos.google.longrunning.IOperation|null|undefined,
          {}|null|undefined>): void;
  exportAssets(
      request: protos.google.cloud.asset.v1p7beta1.IExportAssetsRequest,
      callback: Callback<
          LROperation<protos.google.cloud.asset.v1p7beta1.IExportAssetsResponse, protos.google.cloud.asset.v1p7beta1.IExportAssetsRequest>,
          protos.google.longrunning.IOperation|null|undefined,
          {}|null|undefined>): void;
/**
 * Exports assets with time and resource types to a given Cloud Storage
 * location/BigQuery table. For Cloud Storage location destinations, the
 * output format is newline-delimited JSON. Each line represents a
 * {@link google.cloud.asset.v1p7beta1.Asset|google.cloud.asset.v1p7beta1.Asset} in
 * the JSON format; for BigQuery table destinations, the output table stores
 * the fields in asset proto as columns. This API implements the
 * {@link google.longrunning.Operation|google.longrunning.Operation} API , which
 * allows you to keep track of the export. We recommend intervals of at least
 * 2 seconds with exponential retry to poll the export operation result. For
 * regular-size resource parent, the export operation usually finishes within
 * 5 minutes.
 *
 * @param {Object} request
 *   The request object that will be sent.
 * @param {string} request.parent
 *   Required. The relative name of the root asset. This can only be an
 *   organization number (such as "organizations/123"), a project ID (such as
 *   "projects/my-project-id"), or a project number (such as "projects/12345"),
 *   or a folder number (such as "folders/123").
 * @param {google.protobuf.Timestamp} request.readTime
 *   Timestamp to take an asset snapshot. This can only be set to a timestamp
 *   between the current time and the current time minus 35 days (inclusive).
 *   If not specified, the current time will be used. Due to delays in resource
 *   data collection and indexing, there is a volatile window during which
 *   running the same query may get different results.
 * @param {string[]} request.assetTypes
 *   A list of asset types to take a snapshot for. For example:
 *   "compute.googleapis.com/Disk".
 *
 *   Regular expressions are also supported. For example:
 *
 *   * "compute.googleapis.com.*" snapshots resources whose asset type starts
 *   with "compute.googleapis.com".
 *   * ".*Instance" snapshots resources whose asset type ends with "Instance".
 *   * ".*Instance.*" snapshots resources whose asset type contains "Instance".
 *
 *   See [RE2](https://github.com/google/re2/wiki/Syntax) for all supported
 *   regular expression syntax. If the regular expression does not match any
 *   supported asset type, an INVALID_ARGUMENT error will be returned.
 *
 *   If specified, only matching assets will be returned, otherwise, it will
 *   snapshot all asset types. See [Introduction to Cloud Asset
 *   Inventory](https://cloud.google.com/asset-inventory/docs/overview)
 *   for all supported asset types.
 * @param {google.cloud.asset.v1p7beta1.ContentType} request.contentType
 *   Asset content type. If not specified, no content but the asset name will be
 *   returned.
 * @param {google.cloud.asset.v1p7beta1.OutputConfig} request.outputConfig
 *   Required. Output configuration indicating where the results will be output
 *   to.
 * @param {string[]} request.relationshipTypes
 *   A list of relationship types to export, for example:
 *   `INSTANCE_TO_INSTANCEGROUP`. This field should only be specified if
 *   content_type=RELATIONSHIP. If specified, it will snapshot [asset_types]'
 *   specified relationships, or give errors if any relationship_types'
 *   supported types are not in [asset_types]. If not specified, it will
 *   snapshot all [asset_types]' supported relationships. An unspecified
 *   [asset_types] field means all supported asset_types. See [Introduction to
 *   Cloud Asset
 *   Inventory](https://cloud.google.com/asset-inventory/docs/overview) for all
 *   supported asset types and relationship types.
 * @param {object} [options]
 *   Call options. See {@link https://googleapis.dev/nodejs/google-gax/latest/interfaces/CallOptions.html|CallOptions} for more details.
 * @returns {Promise} - The promise which resolves to an array.
 *   The first element of the array is an object representing
 *   a long running operation. Its `promise()` method returns a promise
 *   you can `await` for.
 *   Please see the
 *   [documentation](https://github.com/googleapis/gax-nodejs/blob/master/client-libraries.md#long-running-operations)
 *   for more details and examples.
 * @example
 * const [operation] = await client.exportAssets(request);
 * const [response] = await operation.promise();
 */
  exportAssets(
      request: protos.google.cloud.asset.v1p7beta1.IExportAssetsRequest,
      optionsOrCallback?: CallOptions|Callback<
          LROperation<protos.google.cloud.asset.v1p7beta1.IExportAssetsResponse, protos.google.cloud.asset.v1p7beta1.IExportAssetsRequest>,
          protos.google.longrunning.IOperation|null|undefined,
          {}|null|undefined>,
      callback?: Callback<
          LROperation<protos.google.cloud.asset.v1p7beta1.IExportAssetsResponse, protos.google.cloud.asset.v1p7beta1.IExportAssetsRequest>,
          protos.google.longrunning.IOperation|null|undefined,
          {}|null|undefined>):
      Promise<[
        LROperation<protos.google.cloud.asset.v1p7beta1.IExportAssetsResponse, protos.google.cloud.asset.v1p7beta1.IExportAssetsRequest>,
        protos.google.longrunning.IOperation|undefined, {}|undefined
      ]>|void {
    request = request || {};
    let options: CallOptions;
    if (typeof optionsOrCallback === 'function' && callback === undefined) {
      callback = optionsOrCallback;
      options = {};
    }
    else {
      options = optionsOrCallback as CallOptions;
    }
    options = options || {};
    options.otherArgs = options.otherArgs || {};
    options.otherArgs.headers = options.otherArgs.headers || {};
    options.otherArgs.headers[
      'x-goog-request-params'
    ] = gax.routingHeader.fromParams({
      'parent': request.parent || '',
    });
    this.initialize();
    return this.innerApiCalls.exportAssets(request, options, callback);
  }
/**
 * Check the status of the long running operation returned by `exportAssets()`.
 * @param {String} name
 *   The operation name that will be passed.
 * @returns {Promise} - The promise which resolves to an object.
 *   The decoded operation object has result and metadata field to get information from.
 *   Please see the
 *   [documentation](https://github.com/googleapis/gax-nodejs/blob/master/client-libraries.md#long-running-operations)
 *   for more details and examples.
 * @example
 * const decodedOperation = await checkExportAssetsProgress(name);
 * console.log(decodedOperation.result);
 * console.log(decodedOperation.done);
 * console.log(decodedOperation.metadata);
 */
  async checkExportAssetsProgress(name: string): Promise<LROperation<protos.google.cloud.asset.v1p7beta1.ExportAssetsResponse, protos.google.cloud.asset.v1p7beta1.ExportAssetsRequest>>{
    const request = new operationsProtos.google.longrunning.GetOperationRequest({name});
    const [operation] = await this.operationsClient.getOperation(request);
    const decodeOperation = new gax.Operation(operation, this.descriptors.longrunning.exportAssets, gax.createDefaultBackoffSettings());
    return decodeOperation as LROperation<protos.google.cloud.asset.v1p7beta1.ExportAssetsResponse, protos.google.cloud.asset.v1p7beta1.ExportAssetsRequest>;
  }

  /**
   * Terminate the gRPC channel and close the client.
   *
   * The client will no longer be usable and all future behavior is undefined.
   * @returns {Promise} A promise that resolves when the client is closed.
   */
  close(): Promise<void> {
    this.initialize();
    if (!this._terminated) {
      return this.assetServiceStub!.then(stub => {
        this._terminated = true;
        stub.close();
      });
    }
    return Promise.resolve();
  }
}
