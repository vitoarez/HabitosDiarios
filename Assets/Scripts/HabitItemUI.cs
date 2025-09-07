using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HabitItemUI : MonoBehaviour
{
    public Toggle toggle;
    public TMP_Text label;

    public void Setup(string habitName)
    {
        label.text = habitName;
        toggle.isOn = false;// Inicialmente desmarcado
    }
}
