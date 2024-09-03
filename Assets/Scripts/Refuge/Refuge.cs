using System;
using System.Collections.Generic;
using UnityEngine;

public class Refuge : MonoBehaviour
{
    [SerializeField] private string _name;
    [SerializeField] private TypeResource _type;
    [SerializeField] private RouteCoordinator _routeCoordinator;

    public RouteCoordinator Conductor => _routeCoordinator;
    public TypeResource Type => _type;
    public string Name => _name;
    
}
