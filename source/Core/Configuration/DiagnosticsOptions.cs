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

namespace Thinktecture.IdentityServer.Core.Configuration
{
    public class DiagnosticsOptions
    {
        public DiagnosticsOptions()
        {
            EnableWebApiDiagnostics = false;
            WebApiDiagnosticsIsVerbose = false;
        }

        /// <summary>
        /// Gets or sets a value indicating whether web API diagnostics should be enabled.
        /// </summary>
        /// <value>
        /// <c>true</c> if web API diagnostics should be enabled; otherwise, <c>false</c>.
        /// </value>
        public bool EnableWebApiDiagnostics { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether web API diagnostics logging should be set to verbose.
        /// </summary>
        /// <value>
        /// <c>true</c> if web API diagnostics logging shozld be verbose; otherwise, <c>false</c>.
        /// </value>
        public bool WebApiDiagnosticsIsVerbose { get; set; }
    }
}