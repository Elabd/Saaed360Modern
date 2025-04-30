using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Saaed360Modern.Application.Abstractions.AuthService // Assuming this is your abstractions namespace
{
    /// <summary>
    /// Defines methods for retrieving user-specific permissions, designed to be cached.
    /// </summary>
    public interface IPermissionService
    {
        /// <summary>
        /// Gets the list of organization IDs the user has access to.
        /// </summary>
        /// <param name="userId">The user's unique identifier.</param>
        /// <param name="ct">Cancellation token.</param>
        /// <returns>A list of organization IDs.</returns>
        Task<List<long>> GetUserOrganizationIdsAsync(Guid userId, CancellationToken ct = default);

        /// <summary>
        /// Gets the list of area IDs the user has access to (including derived areas).
        /// </summary>
        /// <param name="userId">The user's unique identifier.</param>
        /// <param name="ct">Cancellation token.</param>
        /// <returns>A list of area IDs.</returns>
        Task<List<long>> GetUserAreaIdsAsync(Guid userId, CancellationToken ct = default);

        /// <summary>
        /// Gets the list of roles assigned to the user.
        /// </summary>
        /// <param name="userId">The user's unique identifier.</param>
        /// <param name="ct">Cancellation token.</param>
        /// <returns>A list of role names or IDs.</returns>
        Task<List<Guid>> GetUserRolesAsync(Guid userId, CancellationToken ct = default); // Example: Added roles

        /// <summary>
        /// Invalidates the cached permissions for a specific user.
        /// Call this when user permissions are updated.
        /// </summary>
        /// <param name="userId">The user's unique identifier.</param>
        void InvalidateUserCache(Guid userId);
    }
}

