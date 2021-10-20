using UnityEngine;
using UnityMVC;
using UnityMVC.Events;
using UnityMVC.Model;
using UnityMVC.View;

namespace ModuloNamespace
{
    // Autogenerated code. DO NOT CHANGE unless it is really needed and you know what you are doing.
    public partial class ModuloView : View
    {
        private ModuloController Controller => _controller;
        private ModuloController _controller;
        public  ModuloControllerEvents Events => _controller.Events;
        public  ModuloViewModel Data => _data;
        private readonly ModuloViewModel _data = new ModuloViewModel();
        
        public override bool IsActive()
        {
            bool isActive = gameObject.activeSelf;
            if (!isActive)
            {
                Debug.LogWarning($"View {this.GetType().Name} not active");
            }
            return isActive;
        }
        
        protected override void LocateController()
        {
            _controller = MVCApplication.Controllers.Get<ModuloController>();
        }
        
        protected override void InternalAwake()
        {
            GetMVCComponents<MVCComponentTemplate>();
            _controller.SetView(this);
            _controller.OnViewAwake();
        }
        protected override void InternalStart()
        {
            StartCoroutine(LateStartRoutine());
        }
        protected override void InternalOnDestroy()
        {
            Events.onViewDestroyed?.Invoke(this);
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

        protected override void InternalOnEnable()
        {
            Events.onViewEnabled?.Invoke(this);
            RegisterControllerEvents();
            _controller.OnViewOnEnable();
        }

        protected override void InternalOnDisable()
        {
            Events.onViewDisabled?.Invoke(this);
            UnregisterControllerEvents();
            _controller.OnViewOnDisable();
        }
    }
}