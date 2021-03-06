﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;

namespace Dashboard.Data
{
    public interface IRecentInvocationIndexByFunctionWriter
    {
        void CreateOrUpdate(FunctionInstanceSnapshot snapshot, DateTimeOffset timestamp);

        void DeleteIfExists(string functionId, DateTimeOffset timestamp, Guid id);
    }
}
