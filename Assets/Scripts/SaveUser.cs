using UnityEngine;

public class SaveUser : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void SaveUserData()
    {   //TODO: Cambiar etiquetas de los Fields
        string userName = GameObject.Find("InputFieldUserName").GetComponent<UnityEngine.UI.InputField>().text;
        string lastName = GameObject.Find("InputFieldLastName").GetComponent<UnityEngine.UI.InputField>().text;
        string age = GameObject.Find("InputFieldAge").GetComponent<UnityEngine.UI.InputField>().text;
        string email = GameObject.Find("InputFieldEmail").GetComponent<UnityEngine.UI.InputField>().text;
        string password = GameObject.Find("InputFieldPassword").GetComponent<UnityEngine.UI.InputField>().text;
        AppManager appManager = FindFirstObjectByType <AppManager>();
        if (appManager != null)
        {
            appManager.SetUserData(userName, lastName, age, email, password);
            Debug.Log("User data saved successfully.");
        }
        else
        {
            Debug.LogError("AppManager instance not found.");
        }
    }
}
