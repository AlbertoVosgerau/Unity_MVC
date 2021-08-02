using UnityMVC;
using UnityMVC.Events;
using UnityMVC.Model;
using UnityMVC.View;

//// Autogenerated code. DO NOT CHANGE unless it is really needed and you know what you are doing.
public partial class ViewTemplate : View
{
    private ControllerTemplate Controller => _controller;
    private ControllerTemplate _controller;
    // Access Events from here. Please, use Observer pattern, people who uses Observer patterns are nice people.
    public new ControllerTemplateEvents Events => _controller.Events;
    public new ViewTemplateModel Data => _data;
    private readonly ViewTemplateModel _data = new ViewTemplateModel();
    
    protected override void LocateController()
    {
        _controller = MVCApplication.Controllers.Get<ControllerTemplate>();
    }
    
    protected override void InternalAwake()
    {
        GetMVCComponents<MVCComponentTemplate>();
        _controller.SetView(this);
        _controller.OnViewAwake();
    }
    protected override void InternalStart()
    {
        RegisterControllerEvents();
        StartCoroutine(LateStartRoutine());
    }
    protected override void InternalOnDestroy()
    {
        Events.onViewDestroyed?.Invoke(this);
        UnregisterControllerEvents();
    }
    
    protected override void ControllerStart()
    {
        _controller.OnViewStart();
    }
    protected override void ControllerUpdate()
    {
        _controller.OnViewUpdate();
    }
    protected override void ControllerOnEnable()
    {
        _controller.OnViewOnEnable();
    }
    protected override void ControllerOnDisable()
    {
        _controller.OnViewOnDisable();
    }
    protected override void ControllerOnDestroy()
    {
        _controller.OnViewDestroy();
    }
}