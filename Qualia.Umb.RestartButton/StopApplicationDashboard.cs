using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.Dashboards;

namespace Qualia.Umb.RestartButton
{
    [Weight(85)]
    public class StopApplicationDashboard : IDashboard
    {
        public string Alias => "App stop";

        public string[] Sections => new[]
        {
            Umbraco.Cms.Core.Constants.Applications.Settings
        };

        public string View => "/App_Plugins/Qualia.Umb.RestartButton/views/dashboard.html";

        public IAccessRule[] AccessRules
        {
            get
            {
                var rules = new IAccessRule[]
                {
                    new AccessRule {Type = AccessRuleType.Grant, Value = Umbraco.Cms.Core.Constants.Security.AdminGroupAlias}
                };
                return rules;
            }
        }
    }
}
