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

using Thinktecture.IdentityServer.Core.Resources;

namespace Thinktecture.IdentityServer.Core.Services.Default
{
    public class DefaultLocalizationService : ILocalizationService
    {
        public string GetString(string category, string id)
        {
            switch(category)
            {
                case Constants.LocalizationCategories.Messages:
                    return Messages.ResourceManager.GetString(id);
                case Constants.LocalizationCategories.Events:
                    return Resources.Events.ResourceManager.GetString(id);
                case Constants.LocalizationCategories.Scopes:
                    return Scopes.ResourceManager.GetString(id);
            }
            
            return null;
        }
    }
}
