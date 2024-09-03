using System;
using UnityEngine;

public abstract class Step
{
    public event Action<TypeResource> ReceiveResource;

    public abstract void Execute();

    protected void RaiseReceiveResource(TypeResource typeResource)
    {
        ReceiveResource?.Invoke(typeResource);
    }
}
