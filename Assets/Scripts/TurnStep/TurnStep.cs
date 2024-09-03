using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TurnStep : MonoBehaviour
{
    [SerializeField] private Player _player;
    [Range(0, 8)]
    [SerializeField] private int _indexStep;

    private List<Step> _steps;

    public event Action ChangedStep;

    private void Awake()
    {
        _indexStep = 0;

        _steps = new List<Step>
        {
            new Step1(),
            new Step2(),
            new StepThreat(),
            new Step3(),
            new Step4(),
            new StepThreat(),
            new Step5(),
            new Step6(),
            new StepThreat()
        };
    }

    private void OnEnable()
    {
        foreach (Step step in _steps)
        {
            step.ReceiveResource += ReceiveResource;
        }
    }

    private void OnDisable()
    {
        foreach (Step step in _steps)
        {
            step.ReceiveResource -= ReceiveResource;
        }
    }

    public void Next()
    {
        _steps[_indexStep].Execute();

        _indexStep++;

        if (_indexStep >= _steps.Count)
        {
            _indexStep = 0;
        }

        ChangedStep?.Invoke();
    }

    private void ReceiveResource(TypeResource type)
    {
        int countRefuges = _player.Refuges.Count(refuge => refuge.Type == type);

        if (countRefuges == 0)
        {
            return;
        }

        switch (type)
        {
            case TypeResource.Food:
                _player.Resources.Food.AddValue(countRefuges);
                break;
            case TypeResource.Armament:
                _player.Resources.Armament.AddValue(countRefuges);
                break;
            case TypeResource.Medicines:
                _player.Resources.Medicines.AddValue(countRefuges);
                break;
            default:
                break;
        }
    }
}
