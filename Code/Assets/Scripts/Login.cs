using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Firebase;
using Firebase.Auth;

public class Login : MonoBehaviour
{
    public InputField username;
    public InputField password;
    public Button loginButton;
    public Button registrButton;
    // Start is called before the first frame update
    void Start()
    {
        loginButton.onClick.AddListener(delegate { login(); });
        registrButton.onClick.AddListener(delegate { registration(); });
    }

    // Update is called once per frame
    private void login()
    {
        SceneManager.LoadScene("Menu");
    }

    private void registration()
    {
        var email = username.text;
        var paswd = password.text;
        FirebaseAuth.DefaultInstance.CreateUserWithEmailAndPasswordAsync(email, paswd).ContinueWith(task =>
        {
            FirebaseUser newuser = task.Result;
        });
    }
}
