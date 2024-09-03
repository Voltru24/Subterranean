using System;
using UnityEngine;

[Serializable]
public class Route
{
    [SerializeField] private Refuge _point;
    [SerializeField] private bool _isOpen;

    public Route(Refuge point, bool isOpen)
    {
        _point = point;
        _isOpen = isOpen;
    } 

    public bool IsOpen => _isOpen;

    public void Open()
    {
        _isOpen = true;
    }

    public void Close()
    {
        _isOpen = false;
    }
}

