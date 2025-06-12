using System;
using System.Collections.Generic;
using App.Scripts.Core.CustomActionBase;
using App.Scripts.Runtime.Player;
using UnityEngine;

namespace App.Scripts.Runtime.Location
{
    public class Platform : MonoBehaviour
    {
        [SerializeField] private Transform _target;
        [SerializeField] private Collider2D _collider;

        [SerializeField] private List<ActionBase> _executeWhenPlayerTouch;
        
        protected bool _isInitiated;
        protected float YOffset = 1f;


        private void Update()
        {
            if (_isInitiated)
            {
                OnUpdatePlatform();
            }
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.TryGetComponent<Character>(out _))
            {
                foreach (var actionBase in _executeWhenPlayerTouch)
                {
                    actionBase.Execute();
                }
            }
        }

        public void Init(Transform target)
        {
            _target = target;
            _isInitiated = true;
        }

        protected virtual void OnUpdatePlatform()
        {
            _collider.enabled = _target.transform.position.y > transform.position.y + YOffset;
        }
    }
}
