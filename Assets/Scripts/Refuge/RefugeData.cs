using System.Collections.Generic;
using UnityEngine;

public class RefugeData : MonoBehaviour
{
    [SerializeField] private List<Refuge> _refuges;

    public IReadOnlyList<Refuge> Refuges => _refuges;
}
