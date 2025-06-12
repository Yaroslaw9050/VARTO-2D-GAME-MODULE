using App.Scripts.Core.CustomActionBase;
using UnityEngine;

namespace App.Scripts.Runtime.Modules
{
    public class ObjectChangeColorModule : ActionBase
    {
        [SerializeField] private SpriteRenderer _targetRenderer;
        [SerializeField] private Color _defaultColor;

        public void ChangeColor(Color newColor)
        {
            if (_targetRenderer == null)
            {
                Debug.LogError("ObjectChangeColorModule | Target renderer is null");
                return;
            }
            
            _targetRenderer.color = newColor;
        }

        public void ChangeColorToDefault()
        {
            ChangeColor(_defaultColor);
        }

        protected override void ExecuteInternal()
        {
            ChangeColorToDefault();
        }
    }
}