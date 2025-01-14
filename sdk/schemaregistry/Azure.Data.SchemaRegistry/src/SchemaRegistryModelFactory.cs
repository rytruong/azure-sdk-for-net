﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.Data.SchemaRegistry
{
    /// <summary>
    /// This class contains methods to create Schema Registry models for mocking purposes.
    /// </summary>
    public static class SchemaRegistryModelFactory
    {
        /// <summary>
        /// Constructs a SchemaProperties instance for mocking.
        /// </summary>
        /// <param name="format">The format for the schema.</param>
        /// <param name="schemaId">The ID of the schema.</param>
        /// <returns></returns>
        public static SchemaProperties SchemaProperties(SchemaFormat format, string schemaId) => new(format, schemaId);
    }
}