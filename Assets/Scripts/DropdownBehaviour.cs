using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownBehaviour : MonoBehaviour
{
    
    public Text dropdownDescription;

    private string username;

    void Start()
    {
        

        ShowUsername("User123");
        

    }

    private void ShowUsername(string user)
    {

        
        dropdownDescription.text = "Welcome, " + user;


    }

    private void RetrieveUsername()
    {
        // TODO: pull username from database and welcome
    }
    
}
