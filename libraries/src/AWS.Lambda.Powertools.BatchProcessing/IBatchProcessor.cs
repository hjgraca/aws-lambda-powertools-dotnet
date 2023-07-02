﻿/*
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

using System.Threading;
using System.Threading.Tasks;

namespace AWS.Lambda.Powertools.BatchProcessing;
public interface IBatchProcessor<in TEvent, out TRecord>
{
    BatchResponse BatchResponse { get; }
    Task<BatchResponse> ProcessAsync(TEvent @event, IRecordHandler<TRecord> recordHandler);
    Task<BatchResponse> ProcessAsync(TEvent @event, IRecordHandler<TRecord> recordHandler, CancellationToken cancellationToken);
    Task<BatchResponse> ProcessAsync(TEvent @event, IRecordHandler<TRecord> recordHandler, ProcessingOptions processingOptions);
}
