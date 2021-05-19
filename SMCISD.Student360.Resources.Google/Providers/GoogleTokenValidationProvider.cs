// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using Google.Apis.Auth;
using SMCISD.Student360.Resources.Providers;
using System.Threading.Tasks;

namespace SMCISD.Student360.Resources.Google.Providers
{
    public class GoogleTokenValidationProvider : ITokenValidationProvider
    {
        public async Task<IdentityProviderModel> ValidateTokenAsync(string token)
        {
            var validPayload = await GoogleJsonWebSignature.ValidateAsync(token);

            if (validPayload == null)
                return null;

            return new IdentityProviderModel {
                FirstName = validPayload.GivenName,
                LastSurname = validPayload.FamilyName,
                ElectronicMailAddress = validPayload.Email,
                PictureUrl = validPayload.Picture
            }; 
        }
    }
}
