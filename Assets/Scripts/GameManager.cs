using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Text userPrompt;

    void Start()
    {
        Invoke("ShowWelcomeText", 7f);
    }

    private void ShowWelcomeText()
    {

        if (userPrompt.enabled == false)
        {
            userPrompt.enabled = true;
        }

    }





}
