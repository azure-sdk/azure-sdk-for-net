// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using Azure.Core;
using Azure.ResourceManager.ComputeBulkActions;

namespace Azure.ResourceManager.ComputeBulkActions.Mocking
{
    /// <summary> A class to add extension methods to <see cref="ArmClient"/>. </summary>
    [Microsoft.TypeSpec.Generator.Customizations.CodeGenSuppress("GetBulkActionResource", typeof(ResourceIdentifier))]
    public partial class MockableComputeBulkActionsArmClient
    {
        /// <summary> Gets an object representing a <see cref="BulkActionResource"/> along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BulkActionResource"/> object. </returns>
        public virtual BulkActionResource GetBulkActionResource(ResourceIdentifier id)
        {
            BulkActionResource.ValidateResourceId(id);
            return new BulkActionResource(Client, id);
        }
    }
}
