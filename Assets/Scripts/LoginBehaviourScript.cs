using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginBehaviourScript : MonoBehaviour
{
    public InputField usernameField;
    public InputField passwordField;
    public Button loginButton;
    public Button registrationButton;

    // Start is called before the first frame update
    void Start()
    {
        loginButton.onClick.AddListener(delegate{
            login();
        });
    }

    // Update is called once per frame
    private void login()
    {
        SceneManager.LoadScene("MainScene");
    }
}
