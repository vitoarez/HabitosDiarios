using UnityEngine;
using TMPro;


public class HabitsManager : MonoBehaviour
{
    public static HabitsManager instance;

    [Header("Referencias UI")]
    public Transform contentParent;
    public GameObject habitItemPrefab;
    public TMP_InputField newHabitInput;

    [Header("Opciones")]
    public int xpPerHabit = 10;

    private void Awake()
    {
        instance = this;
    }

    public void OnAddHabit()
    {
        string habitName = newHabitInput.text;

        if (!string.IsNullOrEmpty(habitName))
        {
            // Crear un nuevo habitItem
            GameObject obj = Instantiate(habitItemPrefab, contentParent);
            var ui = obj.GetComponent<HabitItemUI>();
            ui.Setup(habitName);

            // Limpiar el campo input
            newHabitInput.text = "";    
        }
    }
}
