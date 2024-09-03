using System;
using UnityEngine;

[Serializable]
public class PlayerResources
{
    [SerializeField] private Parameter _food = new Parameter();
    [SerializeField] private Parameter _armament = new Parameter();
    [SerializeField] private Parameter _medicines = new Parameter();

    public Parameter Food => _food;
    public Parameter Armament => _armament;
    public Parameter Medicines => _medicines;
}
