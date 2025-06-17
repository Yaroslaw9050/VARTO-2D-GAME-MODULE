using System.Collections.Generic;
using App.Scripts.Core.CustomActionBase;
using App.Scripts.Runtime.Player;
using UnityEngine;

namespace App.Scripts.Runtime.Location
{
    public class Apple : MonoBehaviour
    {
        [SerializeField] private List<ActionBase> _callWhenPlayerCollected;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.TryGetComponent(out Character _))
            {
                foreach (var actionBase in _callWhenPlayerCollected)
                {
                    actionBase.Execute();
                }
            }
        }
    }
}