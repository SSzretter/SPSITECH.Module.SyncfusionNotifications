using Oqtane.Models;
using Oqtane.Modules;
using Oqtane.Shared;
using System.Collections.Generic;

namespace SPSITECH.Module.SyncfusionNotifications
{
    public class ModuleInfo : IModule
    {
        public ModuleDefinition ModuleDefinition => new ModuleDefinition
        {
            Name = "SyncfusionNotifications",
            Description = " Testing Syncfusion Notifications and Octane",
            Version = "1.0.0",
            ServerManagerType = "SPSITECH.Module.SyncfusionNotifications.Manager.SyncfusionNotificationsManager, SPSITECH.Module.SyncfusionNotifications.Server.Oqtane",
            ReleaseVersions = "1.0.0",
            Dependencies = "SPSITECH.Module.SyncfusionNotifications.Shared.Oqtane,Syncfusion.Blazor,Syncfusion.Licensing",
            PackageName = "SPSITECH.Module.SyncfusionNotifications",
            Resources = new List<Resource>()
            {
                 new Resource { ResourceType = ResourceType.Stylesheet, Url =  "~/Module.css" },
                new Resource { ResourceType = ResourceType.Script, Url =  "~/Module.js" },

                new Resource { ResourceType = ResourceType.Stylesheet, Url = "_content/Syncfusion.Blazor/styles/bootstrap5.css" },
                new Resource { ResourceType = ResourceType.Stylesheet, Url = "_content/Syncfusion.Blazor/styles/material-dark.css" },
                 new Resource { ResourceType = ResourceType.Script, Url = "_content/Syncfusion.Blazor/scripts/syncfusion-blazor.min.js" }
            }
        };
    }
}
