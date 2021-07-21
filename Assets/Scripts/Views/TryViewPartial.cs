using UnityMVC;
using UnityMVC.View;

public partial class TryView : View
{
    protected override void LocateController()
    {
        _controller = MVCApplication.Controllers.Get<TryController>();
    }
    
    protected override void InitializeController()
    {
        _controller.SetView(this);
        _controller.OnInitializeController();
    }

    protected override void MVCStart()
    {
        base.MVCStart();
        _controller.OnViewStart();
    }

    protected override void MVCOnDestroy()
    {
        base.MVCOnDestroy();
        _events.onViewDestroyed?.Invoke(this);
        _controller.OnViewDestroy();
    }

    protected override void MVCUpdate()
    {
        _controller.OnViewUpdate();
    }
}