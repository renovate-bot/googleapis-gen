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
import {Callback, CallOptions, Descriptors, ClientOptions} from 'google-gax';

import * as protos from '../../protos/protos';
import jsonProtos = require('../../protos/protos.json');
/**
 * Client JSON configuration object, loaded from
 * `src/v2/debugger2_client_config.json`.
 * This file defines retry strategy and timeouts for all API methods in this library.
 */
import * as gapicConfig from './debugger2_client_config.json';

const version = require('../../../package.json').version;

/**
 *  The Debugger service provides the API that allows users to collect run-time
 *  information from a running application, without stopping or slowing it down
 *  and without modifying its state.  An application may include one or
 *  more replicated processes performing the same work.
 *
 *  A debugged application is represented using the Debuggee concept. The
 *  Debugger service provides a way to query for available debuggees, but does
 *  not provide a way to create one.  A debuggee is created using the Controller
 *  service, usually by running a debugger agent with the application.
 *
 *  The Debugger service enables the client to set one or more Breakpoints on a
 *  Debuggee and collect the results of the set Breakpoints.
 * @class
 * @memberof v2
 */
export class Debugger2Client {
  private _terminated = false;
  private _opts: ClientOptions;
  private _providedCustomServicePath: boolean;
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
  warn: (code: string, message: string, warnType?: string) => void;
  innerApiCalls: {[name: string]: Function};
  debugger2Stub?: Promise<{[name: string]: Function}>;

  /**
   * Construct an instance of Debugger2Client.
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
    const staticMembers = this.constructor as typeof Debugger2Client;
    const servicePath = opts?.servicePath || opts?.apiEndpoint || staticMembers.servicePath;
    this._providedCustomServicePath = !!(opts?.servicePath || opts?.apiEndpoint);
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

    // Set useJWTAccessWithScope on the auth object.
    this.auth.useJWTAccessWithScope = true;

    // Set defaultServicePath on the auth object.
    this.auth.defaultServicePath = staticMembers.servicePath;

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
    } else if (opts.fallback === 'rest' ) {
      clientHeader.push(`rest/${this._gaxGrpc.grpcVersion}`);
    }
    if (opts.libName && opts.libVersion) {
      clientHeader.push(`${opts.libName}/${opts.libVersion}`);
    }
    // Load the applicable protos.
    this._protos = this._gaxGrpc.loadProtoJSON(jsonProtos);

    // Put together the default options sent with requests.
    this._defaults = this._gaxGrpc.constructSettings(
        'google.devtools.clouddebugger.v2.Debugger2', gapicConfig as gax.ClientConfig,
        opts.clientConfig || {}, {'x-goog-api-client': clientHeader.join(' ')});

    // Set up a dictionary of "inner API calls"; the core implementation
    // of calling the API is handled in `google-gax`, with this code
    // merely providing the destination and request information.
    this.innerApiCalls = {};

    // Add a warn function to the client constructor so it can be easily tested.
    this.warn = gax.warn;
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
    if (this.debugger2Stub) {
      return this.debugger2Stub;
    }

    // Put together the "service stub" for
    // google.devtools.clouddebugger.v2.Debugger2.
    this.debugger2Stub = this._gaxGrpc.createStub(
        this._opts.fallback ?
          (this._protos as protobuf.Root).lookupService('google.devtools.clouddebugger.v2.Debugger2') :
          // eslint-disable-next-line @typescript-eslint/no-explicit-any
          (this._protos as any).google.devtools.clouddebugger.v2.Debugger2,
        this._opts, this._providedCustomServicePath) as Promise<{[method: string]: Function}>;

    // Iterate over each of the methods that the service provides
    // and create an API call method for each.
    const debugger2StubMethods =
        ['setBreakpoint', 'getBreakpoint', 'deleteBreakpoint', 'listBreakpoints', 'listDebuggees'];
    for (const methodName of debugger2StubMethods) {
      const callPromise = this.debugger2Stub.then(
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
        undefined;
      const apiCall = this._gaxModule.createApiCall(
        callPromise,
        this._defaults[methodName],
        descriptor
      );

      this.innerApiCalls[methodName] = apiCall;
    }

    return this.debugger2Stub;
  }

  /**
   * The DNS address for this API service.
   * @returns {string} The DNS address for this service.
   */
  static get servicePath() {
    return 'clouddebugger.googleapis.com';
  }

  /**
   * The DNS address for this API service - same as servicePath(),
   * exists for compatibility reasons.
   * @returns {string} The DNS address for this service.
   */
  static get apiEndpoint() {
    return 'clouddebugger.googleapis.com';
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
      'https://www.googleapis.com/auth/cloud-platform',
      'https://www.googleapis.com/auth/cloud_debugger'
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
/**
 * Sets the breakpoint to the debuggee.
 *
 * @param {Object} request
 *   The request object that will be sent.
 * @param {string} request.debuggeeId
 *   Required. ID of the debuggee where the breakpoint is to be set.
 * @param {google.devtools.clouddebugger.v2.Breakpoint} request.breakpoint
 *   Required. Breakpoint specification to set.
 *   The field `location` of the breakpoint must be set.
 * @param {string} request.clientVersion
 *   Required. The client version making the call.
 *   Schema: `domain/type/version` (e.g., `google.com/intellij/v1`).
 * @param {object} [options]
 *   Call options. See {@link https://googleapis.dev/nodejs/google-gax/latest/interfaces/CallOptions.html|CallOptions} for more details.
 * @returns {Promise} - The promise which resolves to an array.
 *   The first element of the array is an object representing [SetBreakpointResponse]{@link google.devtools.clouddebugger.v2.SetBreakpointResponse}.
 *   Please see the
 *   [documentation](https://github.com/googleapis/gax-nodejs/blob/master/client-libraries.md#regular-methods)
 *   for more details and examples.
 * @example <caption>include:samples/generated/v2/debugger2.set_breakpoint.js</caption>
 * region_tag:clouddebugger_v2_generated_Debugger2_SetBreakpoint_async
 */
  setBreakpoint(
      request?: protos.google.devtools.clouddebugger.v2.ISetBreakpointRequest,
      options?: CallOptions):
      Promise<[
        protos.google.devtools.clouddebugger.v2.ISetBreakpointResponse,
        protos.google.devtools.clouddebugger.v2.ISetBreakpointRequest|undefined, {}|undefined
      ]>;
  setBreakpoint(
      request: protos.google.devtools.clouddebugger.v2.ISetBreakpointRequest,
      options: CallOptions,
      callback: Callback<
          protos.google.devtools.clouddebugger.v2.ISetBreakpointResponse,
          protos.google.devtools.clouddebugger.v2.ISetBreakpointRequest|null|undefined,
          {}|null|undefined>): void;
  setBreakpoint(
      request: protos.google.devtools.clouddebugger.v2.ISetBreakpointRequest,
      callback: Callback<
          protos.google.devtools.clouddebugger.v2.ISetBreakpointResponse,
          protos.google.devtools.clouddebugger.v2.ISetBreakpointRequest|null|undefined,
          {}|null|undefined>): void;
  setBreakpoint(
      request?: protos.google.devtools.clouddebugger.v2.ISetBreakpointRequest,
      optionsOrCallback?: CallOptions|Callback<
          protos.google.devtools.clouddebugger.v2.ISetBreakpointResponse,
          protos.google.devtools.clouddebugger.v2.ISetBreakpointRequest|null|undefined,
          {}|null|undefined>,
      callback?: Callback<
          protos.google.devtools.clouddebugger.v2.ISetBreakpointResponse,
          protos.google.devtools.clouddebugger.v2.ISetBreakpointRequest|null|undefined,
          {}|null|undefined>):
      Promise<[
        protos.google.devtools.clouddebugger.v2.ISetBreakpointResponse,
        protos.google.devtools.clouddebugger.v2.ISetBreakpointRequest|undefined, {}|undefined
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
      'debuggee_id': request.debuggeeId || '',
    });
    this.initialize();
    return this.innerApiCalls.setBreakpoint(request, options, callback);
  }
/**
 * Gets breakpoint information.
 *
 * @param {Object} request
 *   The request object that will be sent.
 * @param {string} request.debuggeeId
 *   Required. ID of the debuggee whose breakpoint to get.
 * @param {string} request.breakpointId
 *   Required. ID of the breakpoint to get.
 * @param {string} request.clientVersion
 *   Required. The client version making the call.
 *   Schema: `domain/type/version` (e.g., `google.com/intellij/v1`).
 * @param {object} [options]
 *   Call options. See {@link https://googleapis.dev/nodejs/google-gax/latest/interfaces/CallOptions.html|CallOptions} for more details.
 * @returns {Promise} - The promise which resolves to an array.
 *   The first element of the array is an object representing [GetBreakpointResponse]{@link google.devtools.clouddebugger.v2.GetBreakpointResponse}.
 *   Please see the
 *   [documentation](https://github.com/googleapis/gax-nodejs/blob/master/client-libraries.md#regular-methods)
 *   for more details and examples.
 * @example <caption>include:samples/generated/v2/debugger2.get_breakpoint.js</caption>
 * region_tag:clouddebugger_v2_generated_Debugger2_GetBreakpoint_async
 */
  getBreakpoint(
      request?: protos.google.devtools.clouddebugger.v2.IGetBreakpointRequest,
      options?: CallOptions):
      Promise<[
        protos.google.devtools.clouddebugger.v2.IGetBreakpointResponse,
        protos.google.devtools.clouddebugger.v2.IGetBreakpointRequest|undefined, {}|undefined
      ]>;
  getBreakpoint(
      request: protos.google.devtools.clouddebugger.v2.IGetBreakpointRequest,
      options: CallOptions,
      callback: Callback<
          protos.google.devtools.clouddebugger.v2.IGetBreakpointResponse,
          protos.google.devtools.clouddebugger.v2.IGetBreakpointRequest|null|undefined,
          {}|null|undefined>): void;
  getBreakpoint(
      request: protos.google.devtools.clouddebugger.v2.IGetBreakpointRequest,
      callback: Callback<
          protos.google.devtools.clouddebugger.v2.IGetBreakpointResponse,
          protos.google.devtools.clouddebugger.v2.IGetBreakpointRequest|null|undefined,
          {}|null|undefined>): void;
  getBreakpoint(
      request?: protos.google.devtools.clouddebugger.v2.IGetBreakpointRequest,
      optionsOrCallback?: CallOptions|Callback<
          protos.google.devtools.clouddebugger.v2.IGetBreakpointResponse,
          protos.google.devtools.clouddebugger.v2.IGetBreakpointRequest|null|undefined,
          {}|null|undefined>,
      callback?: Callback<
          protos.google.devtools.clouddebugger.v2.IGetBreakpointResponse,
          protos.google.devtools.clouddebugger.v2.IGetBreakpointRequest|null|undefined,
          {}|null|undefined>):
      Promise<[
        protos.google.devtools.clouddebugger.v2.IGetBreakpointResponse,
        protos.google.devtools.clouddebugger.v2.IGetBreakpointRequest|undefined, {}|undefined
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
      'debuggee_id': request.debuggeeId || '',
    });
    this.initialize();
    return this.innerApiCalls.getBreakpoint(request, options, callback);
  }
/**
 * Deletes the breakpoint from the debuggee.
 *
 * @param {Object} request
 *   The request object that will be sent.
 * @param {string} request.debuggeeId
 *   Required. ID of the debuggee whose breakpoint to delete.
 * @param {string} request.breakpointId
 *   Required. ID of the breakpoint to delete.
 * @param {string} request.clientVersion
 *   Required. The client version making the call.
 *   Schema: `domain/type/version` (e.g., `google.com/intellij/v1`).
 * @param {object} [options]
 *   Call options. See {@link https://googleapis.dev/nodejs/google-gax/latest/interfaces/CallOptions.html|CallOptions} for more details.
 * @returns {Promise} - The promise which resolves to an array.
 *   The first element of the array is an object representing [Empty]{@link google.protobuf.Empty}.
 *   Please see the
 *   [documentation](https://github.com/googleapis/gax-nodejs/blob/master/client-libraries.md#regular-methods)
 *   for more details and examples.
 * @example <caption>include:samples/generated/v2/debugger2.delete_breakpoint.js</caption>
 * region_tag:clouddebugger_v2_generated_Debugger2_DeleteBreakpoint_async
 */
  deleteBreakpoint(
      request?: protos.google.devtools.clouddebugger.v2.IDeleteBreakpointRequest,
      options?: CallOptions):
      Promise<[
        protos.google.protobuf.IEmpty,
        protos.google.devtools.clouddebugger.v2.IDeleteBreakpointRequest|undefined, {}|undefined
      ]>;
  deleteBreakpoint(
      request: protos.google.devtools.clouddebugger.v2.IDeleteBreakpointRequest,
      options: CallOptions,
      callback: Callback<
          protos.google.protobuf.IEmpty,
          protos.google.devtools.clouddebugger.v2.IDeleteBreakpointRequest|null|undefined,
          {}|null|undefined>): void;
  deleteBreakpoint(
      request: protos.google.devtools.clouddebugger.v2.IDeleteBreakpointRequest,
      callback: Callback<
          protos.google.protobuf.IEmpty,
          protos.google.devtools.clouddebugger.v2.IDeleteBreakpointRequest|null|undefined,
          {}|null|undefined>): void;
  deleteBreakpoint(
      request?: protos.google.devtools.clouddebugger.v2.IDeleteBreakpointRequest,
      optionsOrCallback?: CallOptions|Callback<
          protos.google.protobuf.IEmpty,
          protos.google.devtools.clouddebugger.v2.IDeleteBreakpointRequest|null|undefined,
          {}|null|undefined>,
      callback?: Callback<
          protos.google.protobuf.IEmpty,
          protos.google.devtools.clouddebugger.v2.IDeleteBreakpointRequest|null|undefined,
          {}|null|undefined>):
      Promise<[
        protos.google.protobuf.IEmpty,
        protos.google.devtools.clouddebugger.v2.IDeleteBreakpointRequest|undefined, {}|undefined
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
      'debuggee_id': request.debuggeeId || '',
    });
    this.initialize();
    return this.innerApiCalls.deleteBreakpoint(request, options, callback);
  }
/**
 * Lists all breakpoints for the debuggee.
 *
 * @param {Object} request
 *   The request object that will be sent.
 * @param {string} request.debuggeeId
 *   Required. ID of the debuggee whose breakpoints to list.
 * @param {boolean} request.includeAllUsers
 *   When set to `true`, the response includes the list of breakpoints set by
 *   any user. Otherwise, it includes only breakpoints set by the caller.
 * @param {boolean} request.includeInactive
 *   When set to `true`, the response includes active and inactive
 *   breakpoints. Otherwise, it includes only active breakpoints.
 * @param {google.devtools.clouddebugger.v2.ListBreakpointsRequest.BreakpointActionValue} request.action
 *   When set, the response includes only breakpoints with the specified action.
 * @param {boolean} request.stripResults
 *   This field is deprecated. The following fields are always stripped out of
 *   the result: `stack_frames`, `evaluated_expressions` and `variable_table`.
 * @param {string} request.waitToken
 *   A wait token that, if specified, blocks the call until the breakpoints
 *   list has changed, or a server selected timeout has expired.  The value
 *   should be set from the last response. The error code
 *   `google.rpc.Code.ABORTED` (RPC) is returned on wait timeout, which
 *   should be called again with the same `wait_token`.
 * @param {string} request.clientVersion
 *   Required. The client version making the call.
 *   Schema: `domain/type/version` (e.g., `google.com/intellij/v1`).
 * @param {object} [options]
 *   Call options. See {@link https://googleapis.dev/nodejs/google-gax/latest/interfaces/CallOptions.html|CallOptions} for more details.
 * @returns {Promise} - The promise which resolves to an array.
 *   The first element of the array is an object representing [ListBreakpointsResponse]{@link google.devtools.clouddebugger.v2.ListBreakpointsResponse}.
 *   Please see the
 *   [documentation](https://github.com/googleapis/gax-nodejs/blob/master/client-libraries.md#regular-methods)
 *   for more details and examples.
 * @example <caption>include:samples/generated/v2/debugger2.list_breakpoints.js</caption>
 * region_tag:clouddebugger_v2_generated_Debugger2_ListBreakpoints_async
 */
  listBreakpoints(
      request?: protos.google.devtools.clouddebugger.v2.IListBreakpointsRequest,
      options?: CallOptions):
      Promise<[
        protos.google.devtools.clouddebugger.v2.IListBreakpointsResponse,
        protos.google.devtools.clouddebugger.v2.IListBreakpointsRequest|undefined, {}|undefined
      ]>;
  listBreakpoints(
      request: protos.google.devtools.clouddebugger.v2.IListBreakpointsRequest,
      options: CallOptions,
      callback: Callback<
          protos.google.devtools.clouddebugger.v2.IListBreakpointsResponse,
          protos.google.devtools.clouddebugger.v2.IListBreakpointsRequest|null|undefined,
          {}|null|undefined>): void;
  listBreakpoints(
      request: protos.google.devtools.clouddebugger.v2.IListBreakpointsRequest,
      callback: Callback<
          protos.google.devtools.clouddebugger.v2.IListBreakpointsResponse,
          protos.google.devtools.clouddebugger.v2.IListBreakpointsRequest|null|undefined,
          {}|null|undefined>): void;
  listBreakpoints(
      request?: protos.google.devtools.clouddebugger.v2.IListBreakpointsRequest,
      optionsOrCallback?: CallOptions|Callback<
          protos.google.devtools.clouddebugger.v2.IListBreakpointsResponse,
          protos.google.devtools.clouddebugger.v2.IListBreakpointsRequest|null|undefined,
          {}|null|undefined>,
      callback?: Callback<
          protos.google.devtools.clouddebugger.v2.IListBreakpointsResponse,
          protos.google.devtools.clouddebugger.v2.IListBreakpointsRequest|null|undefined,
          {}|null|undefined>):
      Promise<[
        protos.google.devtools.clouddebugger.v2.IListBreakpointsResponse,
        protos.google.devtools.clouddebugger.v2.IListBreakpointsRequest|undefined, {}|undefined
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
      'debuggee_id': request.debuggeeId || '',
    });
    this.initialize();
    return this.innerApiCalls.listBreakpoints(request, options, callback);
  }
/**
 * Lists all the debuggees that the user has access to.
 *
 * @param {Object} request
 *   The request object that will be sent.
 * @param {string} request.project
 *   Required. Project number of a Google Cloud project whose debuggees to list.
 * @param {boolean} request.includeInactive
 *   When set to `true`, the result includes all debuggees. Otherwise, the
 *   result includes only debuggees that are active.
 * @param {string} request.clientVersion
 *   Required. The client version making the call.
 *   Schema: `domain/type/version` (e.g., `google.com/intellij/v1`).
 * @param {object} [options]
 *   Call options. See {@link https://googleapis.dev/nodejs/google-gax/latest/interfaces/CallOptions.html|CallOptions} for more details.
 * @returns {Promise} - The promise which resolves to an array.
 *   The first element of the array is an object representing [ListDebuggeesResponse]{@link google.devtools.clouddebugger.v2.ListDebuggeesResponse}.
 *   Please see the
 *   [documentation](https://github.com/googleapis/gax-nodejs/blob/master/client-libraries.md#regular-methods)
 *   for more details and examples.
 * @example <caption>include:samples/generated/v2/debugger2.list_debuggees.js</caption>
 * region_tag:clouddebugger_v2_generated_Debugger2_ListDebuggees_async
 */
  listDebuggees(
      request?: protos.google.devtools.clouddebugger.v2.IListDebuggeesRequest,
      options?: CallOptions):
      Promise<[
        protos.google.devtools.clouddebugger.v2.IListDebuggeesResponse,
        protos.google.devtools.clouddebugger.v2.IListDebuggeesRequest|undefined, {}|undefined
      ]>;
  listDebuggees(
      request: protos.google.devtools.clouddebugger.v2.IListDebuggeesRequest,
      options: CallOptions,
      callback: Callback<
          protos.google.devtools.clouddebugger.v2.IListDebuggeesResponse,
          protos.google.devtools.clouddebugger.v2.IListDebuggeesRequest|null|undefined,
          {}|null|undefined>): void;
  listDebuggees(
      request: protos.google.devtools.clouddebugger.v2.IListDebuggeesRequest,
      callback: Callback<
          protos.google.devtools.clouddebugger.v2.IListDebuggeesResponse,
          protos.google.devtools.clouddebugger.v2.IListDebuggeesRequest|null|undefined,
          {}|null|undefined>): void;
  listDebuggees(
      request?: protos.google.devtools.clouddebugger.v2.IListDebuggeesRequest,
      optionsOrCallback?: CallOptions|Callback<
          protos.google.devtools.clouddebugger.v2.IListDebuggeesResponse,
          protos.google.devtools.clouddebugger.v2.IListDebuggeesRequest|null|undefined,
          {}|null|undefined>,
      callback?: Callback<
          protos.google.devtools.clouddebugger.v2.IListDebuggeesResponse,
          protos.google.devtools.clouddebugger.v2.IListDebuggeesRequest|null|undefined,
          {}|null|undefined>):
      Promise<[
        protos.google.devtools.clouddebugger.v2.IListDebuggeesResponse,
        protos.google.devtools.clouddebugger.v2.IListDebuggeesRequest|undefined, {}|undefined
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
    this.initialize();
    return this.innerApiCalls.listDebuggees(request, options, callback);
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
      return this.debugger2Stub!.then(stub => {
        this._terminated = true;
        stub.close();
      });
    }
    return Promise.resolve();
  }
}
