using System;
using UnityEngine;

[RequireComponent(typeof(Refuge))]
public class RefugeTrigger : MonoBehaviour
{
    private Refuge _refuge;
   
    public event Action<Refuge> OnClickRefuge;

    private void Awake()
    {
        _refuge = GetComponent<Refuge>();
    }

    public void OnMouseDown()
    {
        OnClickRefuge?.Invoke(_refuge);
    }
}
