// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.PureStorageBlock.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockablePureStorageBlockArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockablePureStorageBlockArmClient"/> class for mocking. </summary>
        protected MockablePureStorageBlockArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockablePureStorageBlockArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockablePureStorageBlockArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockablePureStorageBlockArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="PureStorageReservationResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PureStorageReservationResource.CreateResourceIdentifier" /> to create a <see cref="PureStorageReservationResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PureStorageReservationResource"/> object. </returns>
        public virtual PureStorageReservationResource GetPureStorageReservationResource(ResourceIdentifier id)
        {
            PureStorageReservationResource.ValidateResourceId(id);
            return new PureStorageReservationResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PureStoragePoolResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PureStoragePoolResource.CreateResourceIdentifier" /> to create a <see cref="PureStoragePoolResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PureStoragePoolResource"/> object. </returns>
        public virtual PureStoragePoolResource GetPureStoragePoolResource(ResourceIdentifier id)
        {
            PureStoragePoolResource.ValidateResourceId(id);
            return new PureStoragePoolResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PureStorageAvsStorageContainerResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PureStorageAvsStorageContainerResource.CreateResourceIdentifier" /> to create a <see cref="PureStorageAvsStorageContainerResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PureStorageAvsStorageContainerResource"/> object. </returns>
        public virtual PureStorageAvsStorageContainerResource GetPureStorageAvsStorageContainerResource(ResourceIdentifier id)
        {
            PureStorageAvsStorageContainerResource.ValidateResourceId(id);
            return new PureStorageAvsStorageContainerResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PureStorageAvsStorageContainerVolumeResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PureStorageAvsStorageContainerVolumeResource.CreateResourceIdentifier" /> to create a <see cref="PureStorageAvsStorageContainerVolumeResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PureStorageAvsStorageContainerVolumeResource"/> object. </returns>
        public virtual PureStorageAvsStorageContainerVolumeResource GetPureStorageAvsStorageContainerVolumeResource(ResourceIdentifier id)
        {
            PureStorageAvsStorageContainerVolumeResource.ValidateResourceId(id);
            return new PureStorageAvsStorageContainerVolumeResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PureStorageAvsVmResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PureStorageAvsVmResource.CreateResourceIdentifier" /> to create a <see cref="PureStorageAvsVmResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PureStorageAvsVmResource"/> object. </returns>
        public virtual PureStorageAvsVmResource GetPureStorageAvsVmResource(ResourceIdentifier id)
        {
            PureStorageAvsVmResource.ValidateResourceId(id);
            return new PureStorageAvsVmResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PureStorageAvsVmVolumeResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PureStorageAvsVmVolumeResource.CreateResourceIdentifier" /> to create a <see cref="PureStorageAvsVmVolumeResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PureStorageAvsVmVolumeResource"/> object. </returns>
        public virtual PureStorageAvsVmVolumeResource GetPureStorageAvsVmVolumeResource(ResourceIdentifier id)
        {
            PureStorageAvsVmVolumeResource.ValidateResourceId(id);
            return new PureStorageAvsVmVolumeResource(Client, id);
        }
    }
}
