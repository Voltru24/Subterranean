using TMPro;
using UnityEngine;

public class MenuRefuge : MonoBehaviour
{
    [SerializeField] private RefugeData _refugeData;
    [SerializeField] private TMP_Text _textName;
    [SerializeField] private TMP_Text _textType;

    private void OnEnable()
    {
        foreach (Refuge refuge in _refugeData.Refuges)
        {
            //Переделать! Но не смертельно
            refuge.GetComponent<RefugeTrigger>().OnClickRefuge += ShowInfo;
        }
    }

    private void OnDisable()
    {
        foreach (Refuge refuge in _refugeData.Refuges)
        {
            //Переделать! Но не смертельно
            refuge.GetComponent<RefugeTrigger>().OnClickRefuge -= ShowInfo;
        }
    }

    public void ShowInfo(Refuge refuge)
    {
        _textName.text = refuge.Name;

        switch (refuge.Type)
        {
            case TypeResource.Food:
                _textType.text = "Продовольствие";
                break;
            case TypeResource.Armament:
                _textType.text = "Вооружение";
                break;
            case TypeResource.Medicines:
                _textType.text = "Медикаменты";
                break;
            default:
                _textType.text = "";
                break;
        }
    }

}
