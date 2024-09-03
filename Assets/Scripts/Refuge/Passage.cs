using UnityEngine;

public class Passage : MonoBehaviour
{
    [SerializeField] private Refuge _pointRefugeA;
    [SerializeField] private Refuge _pointRefugeB;
    [SerializeField] private bool _isOpen;

    private void Start()
    {
        _pointRefugeA.Conductor.AddPassage(new Route(_pointRefugeB, _isOpen));
        _pointRefugeB.Conductor.AddPassage(new Route(_pointRefugeA, _isOpen));
    }
}
