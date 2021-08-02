using System;
using UnityMVC.Events;

namespace UnityMVC.Events
{
    public partial class ControllerTemplateEvents : MVCEvents
    {
        // Add events here
        public Action<UnityMVC.Controller.Controller> onControllerInitialized;
        public Action<UnityMVC.Controller.Controller> onControllerDestroyed;
    }
}

public partial class ControllerTemplate
{
    //// MVC properties available: View and Events

    // Start your code here
    protected override void SolveDependencies()
    {
        // Awake calls this method. Solve your dependencies here.
    }
    
    protected override void RegisterEvents()
    {
        // otherObject.EventName += MyMethod;
    }
    
    protected override void UnregisterEvents()
    {
        // otherObject.EventName -= MyMethod;
    }

    protected override void MVCAwake()
    {
        // Start your code from here
    }

    protected override void MVCStart()
    {
        // Start your code from here
    }

    protected override void MVCLateStart()
    {
        // Start your code from here
    }

    protected override void MVCUpdate()
    {
        // Start your code from here
    }
}