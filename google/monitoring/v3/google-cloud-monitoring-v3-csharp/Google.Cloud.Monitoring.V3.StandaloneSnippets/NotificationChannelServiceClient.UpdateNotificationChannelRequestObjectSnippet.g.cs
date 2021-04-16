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

namespace Google.Cloud.Monitoring.V3.Snippets
{
    using Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedNotificationChannelServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for UpdateNotificationChannel</summary>
        public void UpdateNotificationChannelRequestObject()
        {
            // Snippet: UpdateNotificationChannel(UpdateNotificationChannelRequest, CallSettings)
            // Create client
            NotificationChannelServiceClient notificationChannelServiceClient = NotificationChannelServiceClient.Create();
            // Initialize request argument(s)
            UpdateNotificationChannelRequest request = new UpdateNotificationChannelRequest
            {
                UpdateMask = new FieldMask(),
                NotificationChannel = new NotificationChannel(),
            };
            // Make the request
            NotificationChannel response = notificationChannelServiceClient.UpdateNotificationChannel(request);
            // End snippet
        }
    }
}
