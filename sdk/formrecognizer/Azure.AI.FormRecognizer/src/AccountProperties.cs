﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.FormRecognizer.Models;

namespace Azure.AI.FormRecognizer.Training
{
    /// <summary>
    /// Contains general information about a Cognitive Services Account, such as the number
    /// of models and account limits.
    /// </summary>
    public class AccountProperties
    {
        internal AccountProperties(ModelsSummary summary)
        {
            CustomModelCount = summary.Count;
            CustomModelLimit = summary.Limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountProperties"/> class.
        /// </summary>
        /// <param name="customModelCount">The current count of trained custom models.</param>
        /// <param name="customModelLimit">The maximum number of models that can be trained for this subscription.</param>
        internal AccountProperties(int customModelCount, int customModelLimit)
        {
            CustomModelCount = customModelCount;
            CustomModelLimit = customModelLimit;
        }

        /// <summary>
        /// The current count of trained custom models.
        /// </summary>
        public int CustomModelCount { get; }

        /// <summary>
        /// The maximum number of models that can be trained for this subscription.
        /// </summary>
        public int CustomModelLimit { get; }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"CustomModelCount: {CustomModelCount}, CustomModelLimit: {CustomModelLimit}";
        }
    }
}
