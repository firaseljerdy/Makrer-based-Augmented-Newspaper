using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginManager : MonoBehaviour
{
    
    public InputField usernameInput;

    public InputField passwordInput;

    private string savedUsername;

    private string savedPassword;

    public Button loginButton, signupButton;

    private int userRegister = 0;

    int pulledPlayerPrefs;

    void Awake()
    {
        pulledPlayerPrefs = PlayerPrefs.GetInt("FirstTimeUserLogin");

        if (pulledPlayerPrefs == 1)
       {
           SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
       }
    }
    void Start()
    {

       loginButton.onClick.AddListener(TaskOnLogInButtonPress);

       signupButton.onClick.AddListener(TaskOnSignupButtonPress);
    


    }

    private void TaskOnLogInButtonPress()
    {

        // log in button
        RetrieveCredentials();

        userRegister = 1;

        Debug.Log("Button Success ... Username: " + savedUsername + " and " + "Password: " + savedPassword);

        PlayerPrefs.SetInt("FirstTimeUserLogin", userRegister);

        

    }

        private void TaskOnSignupButtonPress()
    {

        // move to sign up form 

        SceneManager.LoadScene("SignupScreen", LoadSceneMode.Single);

        

    }
    

    private void RetrieveCredentials()
    {
        savedUsername = usernameInput.text;

        savedPassword = passwordInput.text;

        AuthenticateCredentials();


    }

    private void AuthenticateCredentials()
    {

        // compare with DB 
        // if true ... load next scene


        SceneManager.LoadScene("MainScene", LoadSceneMode.Single);



    }


}
