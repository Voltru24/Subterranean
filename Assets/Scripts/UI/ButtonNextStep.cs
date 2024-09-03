using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonNextStep : MonoBehaviour
{
    [SerializeField] private TurnStep _turnStep;

    private void Awake()
    {
        if (_turnStep == null)
        {
            throw new ArgumentNullException(nameof(_turnStep));
        }
    }

    public void OnClick()
    {
        _turnStep.Next();
    }
}
