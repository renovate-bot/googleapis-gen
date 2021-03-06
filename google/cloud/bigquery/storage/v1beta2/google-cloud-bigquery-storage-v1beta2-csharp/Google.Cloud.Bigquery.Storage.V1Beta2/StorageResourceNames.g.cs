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

// Generated code. DO NOT EDIT!

using gagr = Google.Api.Gax.ResourceNames;
using gcbsv = Google.Cloud.Bigquery.Storage.V1Beta2;

namespace Google.Cloud.Bigquery.Storage.V1Beta2
{
    public partial class CreateReadSessionRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ReadRowsRequest
    {
        /// <summary>
        /// <see cref="ReadStreamName"/>-typed view over the <see cref="ReadStream"/> resource name property.
        /// </summary>
        public ReadStreamName ReadStreamAsReadStreamName
        {
            get => string.IsNullOrEmpty(ReadStream) ? null : ReadStreamName.Parse(ReadStream, allowUnparsed: true);
            set => ReadStream = value?.ToString() ?? "";
        }
    }

    public partial class SplitReadStreamRequest
    {
        /// <summary>
        /// <see cref="gcbsv::ReadStreamName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbsv::ReadStreamName ReadStreamName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbsv::ReadStreamName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateWriteStreamRequest
    {
        /// <summary><see cref="TableName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public TableName ParentAsTableName
        {
            get => string.IsNullOrEmpty(Parent) ? null : TableName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class AppendRowsRequest
    {
        /// <summary>
        /// <see cref="WriteStreamName"/>-typed view over the <see cref="WriteStream"/> resource name property.
        /// </summary>
        public WriteStreamName WriteStreamAsWriteStreamName
        {
            get => string.IsNullOrEmpty(WriteStream) ? null : WriteStreamName.Parse(WriteStream, allowUnparsed: true);
            set => WriteStream = value?.ToString() ?? "";
        }
    }

    public partial class GetWriteStreamRequest
    {
        /// <summary>
        /// <see cref="gcbsv::WriteStreamName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbsv::WriteStreamName WriteStreamName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbsv::WriteStreamName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class FinalizeWriteStreamRequest
    {
        /// <summary>
        /// <see cref="gcbsv::WriteStreamName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbsv::WriteStreamName WriteStreamName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbsv::WriteStreamName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class FlushRowsRequest
    {
        /// <summary>
        /// <see cref="WriteStreamName"/>-typed view over the <see cref="WriteStream"/> resource name property.
        /// </summary>
        public WriteStreamName WriteStreamAsWriteStreamName
        {
            get => string.IsNullOrEmpty(WriteStream) ? null : WriteStreamName.Parse(WriteStream, allowUnparsed: true);
            set => WriteStream = value?.ToString() ?? "";
        }
    }
}
