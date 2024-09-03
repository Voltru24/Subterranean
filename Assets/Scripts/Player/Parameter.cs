using System;
using UnityEngine;

[Serializable]
public class Parameter
{
    [SerializeField] private int _value;

    public Parameter()
    {
        _value = 0;
    }

    public int Value => _value;

    public event Action ValueChanged;

    public void AddValue(int value)
    {
        _value += value;

        ValueChanged?.Invoke();
    }

    public bool TryTakeValue(int value)
    {
        if (_value >= value)
        {
            _value -= value;

            ValueChanged?.Invoke();
            return true;
        }

        return false;
    }
}
