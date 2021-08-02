﻿using System;
using UnityMVC.Events;

namespace UnityMVC.Events
{
    public partial class ControllerTemplateEvents
    {
        // Add events here
        public Action<View.View> onViewDestroyed;
    }
}

namespace UnityMVC.Model
{
    public class ViewTemplateModel : MVCModel
    {
        // Add data here
    }
}

public partial class ViewTemplate
{
    //// MVC properties available: Controller, Events and Data

    // Start your code here
    protected override void SolveDependencies()
    {
        // Awake calls this method. Solve your dependencies here.
    }
    
    protected override void RegisterControllerEvents()
    {
        // otherObject.EventName += MyMethod;
    }

    protected override void UnregisterControllerEvents()
    {
        // otherObject.EventName -= MyMethod;
    }

    protected override void MVCAwake()
    {
        // Add your code here
    }

    protected override void MVCStart()
    {
        // Add your code here
    }

    protected override void MVCLateStart()
    {
        // Add your code here
    }

    protected override void MVCUpdate()
    {
        // Add your code here
    }
}