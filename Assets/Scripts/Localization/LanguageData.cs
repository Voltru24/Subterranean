using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class LanguageData
{
    [SerializeField] private string _name;

    public string Name => _name;
   
    public List<LocalizationResource> Resources;


 
}
