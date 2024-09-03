using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerResources _resources = new PlayerResources();
    [SerializeField] private PlayerArmy _army = new PlayerArmy();
    [SerializeField] private List<Refuge> _refuges;
    [SerializeField] private Color _colorRefuge;
    public PlayerResources Resources => _resources;
    public IReadOnlyList<Refuge> Refuges => _refuges;
    
    private void Start()
    {
        foreach (Refuge refuge in _refuges)
        {
            SpriteRenderer renderer =  refuge.GetComponent<SpriteRenderer>();
            renderer.color = _colorRefuge;
        }
    }
}
