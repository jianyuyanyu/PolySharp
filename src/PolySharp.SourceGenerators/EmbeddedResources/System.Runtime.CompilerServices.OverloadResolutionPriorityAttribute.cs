// <auto-generated/>
#pragma warning disable
#nullable enable annotations

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Runtime.CompilerServices
{
    /// <summary>
    /// Specifies the priority of a member in overload resolution. When unspecified, the default priority is 0.
    /// </summary>
    [global::System.AttributeUsage(
        global::System.AttributeTargets.Method |
        global::System.AttributeTargets.Constructor |
        global::System.AttributeTargets.Property,
        AllowMultiple = false,
        Inherited = false)]
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    internal sealed class OverloadResolutionPriorityAttribute : global::System.Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="global::System.Runtime.CompilerServices.OverloadResolutionPriorityAttribute"/> class.
        /// </summary>
        /// <param name="priority">The priority of the attributed member. Higher numbers are prioritized, lower numbers are deprioritized. 0 is the default if no attribute is present.</param>
        public OverloadResolutionPriorityAttribute(int priority)
        {
            Priority = priority;
        }

        /// <summary>
        /// The priority of the member.
        /// </summary>
        public int Priority { get; }
    }
}