// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;

namespace Azure.Learn.Computation.Models
{
    /// <summary> The LinuxComputeNode. </summary>
    public partial class LinuxComputeNode : ComputeNode
    {
        /// <summary> Initializes a new instance of LinuxComputeNode. </summary>
        /// <param name="name"> The name of the compute node. </param>
        /// <param name="sshPublicKey"> The compute node&apos;s public key. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="sshPublicKey"/> is null. </exception>
        public LinuxComputeNode(string name, string sshPublicKey) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (sshPublicKey == null)
            {
                throw new ArgumentNullException(nameof(sshPublicKey));
            }

            SshPublicKey = sshPublicKey;
            Kind = "LinuxComputeNode";
        }

        /// <summary> Initializes a new instance of LinuxComputeNode. </summary>
        /// <param name="eTag"> An HTTP ETag. </param>
        /// <param name="name"> The name of the compute node. </param>
        /// <param name="kind"> . </param>
        /// <param name="sshPublicKey"> The compute node&apos;s public key. </param>
        internal LinuxComputeNode(ETag eTag, string name, string kind, string sshPublicKey) : base(eTag, name, kind)
        {
            SshPublicKey = sshPublicKey;
            Kind = kind ?? "LinuxComputeNode";
        }

        /// <summary> The compute node&apos;s public key. </summary>
        public string SshPublicKey { get; set; }
    }
}
