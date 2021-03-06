﻿/*
 * Copyright 2014 Dominick Baier, Brock Allen
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Thinktecture.IdentityServer.Core.Extensions;

namespace Thinktecture.IdentityServer.Core.Models
{
    public class AuthorizationCode : ITokenMetadata
    {
        public DateTimeOffset CreationTime { get; set; }

        public Client Client { get; set; }
        public ClaimsPrincipal Subject { get; set; }
    
        public bool IsOpenId { get; set; }
        public IEnumerable<Scope> RequestedScopes { get; set; }
        public string RedirectUri { get; set; }
        public string Nonce { get; set; }

        public bool WasConsentShown { get; set; }

        public AuthorizationCode()
        {
            CreationTime = DateTimeOffset.UtcNow;
        }

        public string SubjectId
        {
            get { return Subject.GetSubjectId(); }
        }

        public string ClientId
        {
            get { return Client.ClientId; }
        }

        public IEnumerable<string> Scopes
        {
            get { return RequestedScopes.Select(x => x.Name); }
        }
    }
}