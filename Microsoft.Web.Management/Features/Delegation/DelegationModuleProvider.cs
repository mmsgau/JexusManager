﻿// Copyright (c) Lex Li. All rights reserved.
// 
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using Microsoft.Web.Management.Server;

namespace Microsoft.Web.Management.Features.Delegation
{
    public sealed class DelegationModuleProvider : SimpleDelegatedModuleProvider
    {
        public override ModuleDefinition GetModuleDefinition(IManagementContext context)
        {
            return null;
        }

        public override bool SupportsScope(
            ManagementScope scope
            )
        {
            return scope == ManagementScope.Server;
        }

        public override string FriendlyName { get; }
        public override Type ServiceType { get; }
    }
}
