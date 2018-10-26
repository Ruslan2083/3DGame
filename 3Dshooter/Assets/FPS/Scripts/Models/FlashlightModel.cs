using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPS
{
    public class FlashlightModel : MonoBehaviour
    {
        public Action<bool> OnFlashlightSwitch;

        private Light _light;

        public bool IsOn
        {
            get
            {
                if (_light == null) return false;
                return _light.enabled;
            }
        }

        private void Awake()
        {
            _light = GetComponent<Light>();
        }

        public void On()
        {
            _light.enabled = true;
            if (OnFlashlightSwitch != null) OnFlashlightSwitch.Invoke(true);
        }

        public void Off()
        {
            _light.enabled = false;
            if (OnFlashlightSwitch != null) OnFlashlightSwitch.Invoke(false);
        }

        public void Switch()
        {
            if (IsOn) Off();
            else On();
        }
    }
}