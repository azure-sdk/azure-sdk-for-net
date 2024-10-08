// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.StandbyPool.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableStandbyPoolArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableStandbyPoolArmClient"/> class for mocking. </summary>
        protected MockableStandbyPoolArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableStandbyPoolArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableStandbyPoolArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableStandbyPoolArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="StandbyVirtualMachinePoolResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StandbyVirtualMachinePoolResource.CreateResourceIdentifier" /> to create a <see cref="StandbyVirtualMachinePoolResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StandbyVirtualMachinePoolResource"/> object. </returns>
        public virtual StandbyVirtualMachinePoolResource GetStandbyVirtualMachinePoolResource(ResourceIdentifier id)
        {
            StandbyVirtualMachinePoolResource.ValidateResourceId(id);
            return new StandbyVirtualMachinePoolResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="StandbyVirtualMachineResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StandbyVirtualMachineResource.CreateResourceIdentifier" /> to create a <see cref="StandbyVirtualMachineResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StandbyVirtualMachineResource"/> object. </returns>
        public virtual StandbyVirtualMachineResource GetStandbyVirtualMachineResource(ResourceIdentifier id)
        {
            StandbyVirtualMachineResource.ValidateResourceId(id);
            return new StandbyVirtualMachineResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="StandbyVirtualMachinePoolRuntimeViewResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StandbyVirtualMachinePoolRuntimeViewResource.CreateResourceIdentifier" /> to create a <see cref="StandbyVirtualMachinePoolRuntimeViewResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StandbyVirtualMachinePoolRuntimeViewResource"/> object. </returns>
        public virtual StandbyVirtualMachinePoolRuntimeViewResource GetStandbyVirtualMachinePoolRuntimeViewResource(ResourceIdentifier id)
        {
            StandbyVirtualMachinePoolRuntimeViewResource.ValidateResourceId(id);
            return new StandbyVirtualMachinePoolRuntimeViewResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="StandbyContainerGroupPoolResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StandbyContainerGroupPoolResource.CreateResourceIdentifier" /> to create a <see cref="StandbyContainerGroupPoolResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StandbyContainerGroupPoolResource"/> object. </returns>
        public virtual StandbyContainerGroupPoolResource GetStandbyContainerGroupPoolResource(ResourceIdentifier id)
        {
            StandbyContainerGroupPoolResource.ValidateResourceId(id);
            return new StandbyContainerGroupPoolResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="StandbyContainerGroupPoolRuntimeViewResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StandbyContainerGroupPoolRuntimeViewResource.CreateResourceIdentifier" /> to create a <see cref="StandbyContainerGroupPoolRuntimeViewResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StandbyContainerGroupPoolRuntimeViewResource"/> object. </returns>
        public virtual StandbyContainerGroupPoolRuntimeViewResource GetStandbyContainerGroupPoolRuntimeViewResource(ResourceIdentifier id)
        {
            StandbyContainerGroupPoolRuntimeViewResource.ValidateResourceId(id);
            return new StandbyContainerGroupPoolRuntimeViewResource(Client, id);
        }
    }
}
