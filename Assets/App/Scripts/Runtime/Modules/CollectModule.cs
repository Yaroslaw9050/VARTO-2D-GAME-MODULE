using System;
using App.Scripts.Core.CustomActionBase;
using UnityEngine;

namespace App.Scripts.Runtime.Modules
{
    public class CollectModule : ActionBase
    {
        [SerializeField] private CollectType _collectType;
        [SerializeField] private GameObject _targetObject;
        
        protected override void ExecuteInternal()
        {
            switch (_collectType)
            {
                case CollectType.Self:
                    Destroy(gameObject);
                    break;
                case CollectType.Target:
                    Destroy(_targetObject);
                    break;
                default:
                    Debug.LogError($"{gameObject.name} | Hase some issue with CollectModule");
                    break;
            }
        }
    }
}