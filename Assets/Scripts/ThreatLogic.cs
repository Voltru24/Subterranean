using System.Collections.Generic;
using UnityEngine;

public class ThreatLogic : MonoBehaviour
{
    [SerializeField] private List<Refuge> _refuges;
    [SerializeField] private Color _colorRefuge;
    public IReadOnlyList<Refuge> Refuges => _refuges;

    private void Start()
    {
        foreach (Refuge refuge in _refuges)
        {
            SpriteRenderer renderer = refuge.GetComponent<SpriteRenderer>();
            renderer.color = _colorRefuge;
        }
    }
}
