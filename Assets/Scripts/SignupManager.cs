using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SignupManager : MonoBehaviour
{
    
    public InputField usernameInput, passwordInput, passwordConfirmationInput;

    private string savedUsername, savedPassword, savedPasswordConfirmation;

    public Button signupButton, backButton;

    public Text errorText;

    

    void Start()
    {   

        signupButton.onClick.AddListener(() => TaskOnSignUpButtonPress());

        backButton.onClick.AddListener(TaskOnBackButtonPress);

        
        
    }

    private void TaskOnSignUpButtonPress()
    {
        StoreCredentials();

        bool credentialsCorrect = AuthenticateCredentials();
        Debug.Log(credentialsCorrect);

        if (credentialsCorrect)
        {
            PushDataToDB();
        }

        else 
        {
            Debug.Log("SIGNUP FAILED data not pushed to DB");
            errorText.GetComponent<Text>().enabled = true;
        }
    }

    private void TaskOnBackButtonPress()
    {
        
        SceneManager.LoadScene("LoginScreen", LoadSceneMode.Single);

    }

    

    private void PushDataToDB()
    {
        Debug.Log("Button Success ... Username: " + savedUsername + " and " + "Password: " + savedPassword + "Password conf: " + savedPasswordConfirmation);

       //log in user 
       // SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
    }

    private void StoreCredentials()
    {
        savedUsername = usernameInput.text;

        savedPassword = passwordInput.text;

        savedPasswordConfirmation = passwordConfirmationInput.text;

        
    }

    private bool AuthenticateCredentials()
    {
        bool canBePushed = false;

        if(savedPassword != "" && savedUsername != "" && savedPasswordConfirmation != "")
        {   
            if (string.Compare(savedPassword, savedPasswordConfirmation) == 0)
            {return canBePushed = true;}

        }

        else 
        {
            return canBePushed = false;
        }
 
        return canBePushed;
    }

    
}
