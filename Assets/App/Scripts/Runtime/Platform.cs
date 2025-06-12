using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private float _playerOffset;
    [SerializeField] private Transform _target;
    [SerializeField] private Collider2D _collider;
    
    protected bool _isInitiated;
    
    public void Init(Transform target)
    {
        _target = target;
        _isInitiated = true;
    }
    
    void Update()
    {
        if (_isInitiated)
        {
            OnUpdatePlatform();
        }
    }

    protected virtual void OnUpdatePlatform()
    {
        _collider.enabled = _target.transform.position.y > transform.position.y + _playerOffset;
    }
}
