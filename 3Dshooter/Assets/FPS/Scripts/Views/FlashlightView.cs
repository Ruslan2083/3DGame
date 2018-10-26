using UnityEngine;
using UnityEngine.UI;

namespace FPS
{
    public class FlashlightView : MonoBehaviour
    {
        [SerializeField]
        private Color _onColor;
        [SerializeField]
        private Color _offColor;

        private FlashlightModel _model;
        private Image _image;

        private void Awake()
        {
            _image = GetComponent<Image>();
            _model = FindObjectOfType<FlashlightModel>();
            _model.OnFlashlightSwitch += FlashlightSwitch;

            FlashlightSwitch(_model.IsOn);
        }

        private void OnDestroy()
        {
            _model.OnFlashlightSwitch -= FlashlightSwitch;
        }

        private void FlashlightSwitch(bool state)
        {
            _image.color = state ? _onColor : _offColor;
        }
    }
}