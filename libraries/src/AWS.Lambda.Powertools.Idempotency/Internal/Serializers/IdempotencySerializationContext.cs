/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System.Text.Json.Serialization;

namespace AWS.Lambda.Powertools.Idempotency.Internal.Serializers;

#if NET8_0_OR_GREATER


/// <summary>
/// The source generated JsonSerializerContext to be used to Serialize Idempotency types 
/// </summary>
[JsonSerializable(typeof(string))]
[JsonSerializable(typeof(object))]
public partial class IdempotencySerializationContext : JsonSerializerContext
{
    
}
#endif