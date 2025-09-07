using UnityEngine;
using TMPro;

public class ProfileView : MonoBehaviour
{
    public TMP_Text nameText;
    public TMP_Text lastNameText;
    public TMP_Text ageText;
    public TMP_Text emailText;
    public TMP_Text passwordText;

    void OnEnable()
    {
        var u = AppManager.userData;
        if (u == null) return;
        if (nameText) nameText.text = u.userName;
        if (lastNameText) lastNameText.text = u.lastName;
        if (ageText) ageText.text = u.age;
        if (emailText) emailText.text = u.email;
        if (passwordText) passwordText.text = u.password;
    }
}
