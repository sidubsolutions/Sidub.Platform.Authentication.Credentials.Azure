/*
 * Sidub Platform - Authentication - Azure Credentials
 * Copyright (C) 2024 Sidub Inc.
 * All rights reserved.
 *
 * This file is part of Sidub Platform - Authentication - Azure Credentials (the "Product").
 *
 * The Product is dual-licensed under:
 * 1. The GNU Affero General Public License version 3 (AGPLv3)
 * 2. Sidub Inc.'s Proprietary Software License Agreement (PSLA)
 *
 * You may choose to use, redistribute, and/or modify the Product under
 * the terms of either license.
 *
 * The Product is provided "AS IS" and "AS AVAILABLE," without any
 * warranties or conditions of any kind, either express or implied, including
 * but not limited to implied warranties or conditions of merchantability and
 * fitness for a particular purpose. See the applicable license for more
 * details.
 *
 * See the LICENSE.txt file for detailed license terms and conditions or
 * visit https://sidub.ca/licensing for a copy of the license texts.
 */

#region Imports

using Azure.Core;

#endregion

namespace Sidub.Platform.Authentication.Credentials
{

    /// <summary>
    /// Represents a user token credential.
    /// </summary>
    public class UserTokenCredential : IClientCredential
    {

        #region Public properties

        /// <summary>
        /// Gets the token credential.
        /// </summary>
        public TokenCredential Credential { get; }

        /// <summary>
        /// Gets the client ID.
        /// </summary>
        public Guid ClientId { get; }

        /// <summary>
        /// Gets the tenant ID.
        /// </summary>
        public Guid TenantId { get; }

        /// <summary>
        /// Gets the redirect URI.
        /// </summary>
        public string RedirectUri { get; }

        /// <summary>
        /// Gets the scopes for the token credential.
        /// </summary>
        public string[] Scopes { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="UserTokenCredential"/> class with the specified token credential and scope.
        /// </summary>
        /// <param name="credential">The token credential.</param>
        /// <param name="scope">The scope for the token credential.</param>
        /// <param name="redirectUri">The redirect URI for the authentication flow.</param>
        public UserTokenCredential(TokenCredential credential, string scope, Guid clientId, Guid tenantId, string redirectUri)
        {
            Credential = credential;
            Scopes = new[] { scope };
            ClientId = clientId;
            TenantId = tenantId;
            RedirectUri = redirectUri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserTokenCredential"/> class with the specified token credential and scopes.
        /// </summary>
        /// <param name="credential">The token credential.</param>
        /// <param name="scopes">The scopes for the token credential.</param>
        /// <param name="redirectUri">The redirect URI for the authentication flow.</param>
        public UserTokenCredential(TokenCredential credential, string[] scopes, Guid clientId, Guid tenantId, string redirectUri)
        {
            Credential = credential;
            Scopes = scopes;
            ClientId = clientId;
            TenantId = tenantId;
            RedirectUri = redirectUri;
        }

        #endregion

    }

}
