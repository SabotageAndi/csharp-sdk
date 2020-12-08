﻿// <copyright file="SafariDriver.cs" company="TestProject">
// Copyright 2020 TestProject (https://testproject.io)
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

using OpenQA.Selenium.Safari;

namespace TestProject.SDK.Drivers.Web
{
    /// <summary>
    /// Extension of <see cref="OpenQA.Selenium.Safari.SafariDriver">SafariDriver</see> for use with TestProject.
    /// Instead of initializing a new session, it starts it in the TestProject Agent and then reconnects to it.
    /// </summary>
    public class SafariDriver : BaseDriver
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SafariDriver"/> class.
        /// </summary>
        /// <param name="remoteAddress">The base address for the Agent API (e.g. http://localhost:8585).</param>
        /// <param name="token">The development token used to communicate with the Agent, see <a href="https://app.testproject.io/#/integrations/sdk">here</a> for more info.</param>
        /// <param name="safariOptions">See <see cref="SafariOptions"/> for more details.</param>
        /// <param name="projectName">The project name to report.</param>
        /// <param name="jobName">The job name to report.</param>
        /// <param name="disableReports">Set to true to disable all reporting (no report will be created on TestProject).</param>
        public SafariDriver(
            string remoteAddress = "http://localhost:8585",  // TODO: replace with proper logic
            string token = null,
            SafariOptions safariOptions = null,
            string projectName = null,
            string jobName = null,
            bool disableReports = false)
            : base(remoteAddress, token, safariOptions, projectName, jobName, disableReports)
        {
        }
    }
}