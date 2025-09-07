using UnityEngine;

public class AppManager : MonoBehaviour
{ 
    public static UserData userData;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if (userData == null)
        {
            userData = ScriptableObject.CreateInstance<UserData>();
            DontDestroyOnLoad(this.gameObject);
            Debug.Log("UserData instance created and marked as DontDestroyOnLoad.");
        }


    }
    public void SetUserData(string userName, string lastName, string age, string email, string password)
    {
        userData.userName = userName;
        userData.lastName = lastName;
        userData.age = age;
        userData.email = email;
        userData.password = password;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
