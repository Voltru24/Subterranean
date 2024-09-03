using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class RouteCoordinator
{
    [SerializeField] private List<Route> _route;

    public IReadOnlyList<Route> Routes => _route;

    public RouteCoordinator()
    {
        _route = new List<Route>();
    }

    public void AddPassage(Route route)
    {
        if (_route.Contains(route))
        {
            return;
        }

        _route.Add(route);
    }
}
