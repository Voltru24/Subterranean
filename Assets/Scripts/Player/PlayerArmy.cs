using System;
using UnityEngine;

[Serializable]
public class PlayerArmy
{
    [SerializeField] private Parameter _force;

    public Parameter Force => _force;


}
