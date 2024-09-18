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

using Microsoft.Identity.Web;
using System.Security.Claims;

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
        /// Gets the claims principal associated with the user token credential.
        /// </summary>
        public ClaimsPrincipal ClaimsPrincipal { get; }

        /// <summary>
        /// Gets the token acquisition service used to acquire tokens.
        /// </summary>
        public ITokenAcquisition TokenAcquisition { get; }

        /// <summary>
        /// Gets the scope of the token.
        /// </summary>
        public string Scope { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="UserTokenCredential"/> class.
        /// </summary>
        /// <param name="claimsPrincipal">The claims principal associated with the user token credential.</param>
        /// <param name="tokenAcquisition">The token acquisition service used to acquire tokens.</param>
        /// <param name="scope">The scope of the token.</param>
        public UserTokenCredential(ClaimsPrincipal claimsPrincipal, ITokenAcquisition tokenAcquisition, string scope)
        {
            ClaimsPrincipal = claimsPrincipal;
            TokenAcquisition = tokenAcquisition;
            Scope = scope;
        }

        #endregion

    }

}
