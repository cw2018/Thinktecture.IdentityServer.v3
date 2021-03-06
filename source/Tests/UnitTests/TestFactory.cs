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

using Thinktecture.IdentityServer.Core.Configuration;
using Thinktecture.IdentityServer.Core.Services;
using Thinktecture.IdentityServer.Core.Services.InMemory;

namespace Thinktecture.IdentityServer.Tests
{
    public class TestFactory
    {
        public static IdentityServerServiceFactory Create()
        {
            var scopes = new InMemoryScopeStore(TestScopes.Get());
            var clients = new InMemoryClientStore(TestClients.Get());
            
            var fact = new IdentityServerServiceFactory
            {
                ScopeStore = new Registration<IScopeStore>((resolver) => scopes),
                ClientStore = new Registration<IClientStore>((resolver) => clients)
            };

            return fact;
        }
    }
}
