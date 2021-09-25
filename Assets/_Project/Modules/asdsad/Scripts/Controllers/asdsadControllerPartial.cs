using System;
using UnityEngine;
using UnityMVC.Controller;
using UnityMVC.Events;
using UnityMVC.View;

namespace asdsadasd
{
    // Autogenerated code. DO NOT CHANGE unless it is really needed and you know what you are doing.
    public partial class asdsadController : Controller
    {
        private asdsadView View => _view;
        private asdsadView _view;
        public  asdsadControllerEvents Events => _events;
        private readonly asdsadControllerEvents _events = new asdsadControllerEvents();
        
        public override void SetView(View view)
        {
            if (_view != null)
            {
                Debug.LogException(new Exception($"More than one View are trying to access {this.GetType()}"));
                return;
            }
            _view = view as asdsadView;
        }

        public override View GetView()
        {
            return _view;
        }

        public override bool IsActive()
        {
            bool viewExists = _view != null;
            bool isActive = _view.gameObject.activeSelf;
            if (viewExists)
            {
                Debug.LogWarning($"View {typeof(asdsadView).Name} does not exist");
            }
            if (!isActive)
            {
                Debug.LogWarning($"View {this.GetType().Name} not active");
            }
            return isActive && viewExists;
        }

        protected override void InternalAwake()
        {
            _events.onControllerInitialized?.Invoke(this);
        }
        protected override void InternalOnDestroy()
        {
            _events.onControllerDestroyed?.Invoke(this);
        }

        protected override void InternalOnEnable()
        {
            
        }

        protected override void InternalOnDisable()
        {
            
        }
    }
}