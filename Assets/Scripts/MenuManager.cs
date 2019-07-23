using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using UnityEngine.EventSystems;

public class MenuManager : MonoBehaviour
{
    public Button menuButton, homeButton, musicButton, deleteButton;

    public VideoPlayer video;

    GameObject augmentedImageVisualizer;

    GameObject popoutPanel;

    private int pulledPlayerPrefs;

    private bool isMenuOpen = false;

    private bool isTouchUI = false;

    public Text text;
    

    void Start()
    {
        

        popoutPanel = menuButton.transform.GetChild(0).gameObject;

        menuButton.onClick.AddListener(() => TaskOnMenuButtonDown());

        homeButton.onClick.AddListener(TaskOnHomeButtonDown);

        musicButton.onClick.AddListener(TaskOnMusicButtonDown);

        deleteButton.onClick.AddListener(TaskOnDeleteButtonDown);

        pulledPlayerPrefs = PlayerPrefs.GetInt("FirstTimeUserLogin");

    }

    void Update()
    {
      

        

    }

    private bool CheckTouchOnUI()
    {

        foreach (Touch touch in Input.touches)
        {
            int id = touch.fingerId;

            if (EventSystem.current.IsPointerOverGameObject(id))
            {
                return isTouchUI = true;
            }

            
        }
        return isTouchUI = false;


    }

    private void TaskOnMenuButtonDown()
    {   
        if (popoutPanel.activeInHierarchy)
        {
            popoutPanel.SetActive(false);
            isMenuOpen = false;
        }

        else 
        {
            popoutPanel.SetActive(true);
            isMenuOpen = true;
        }
    }

    private void TaskOnHomeButtonDown()
    {
        if (pulledPlayerPrefs == 1)
        {
            PlayerPrefs.SetInt("FirstTimeUserLogin", 0);
        }

        SceneManager.LoadScene("LoginScreen", LoadSceneMode.Single);
        // log out user from session

    }

    private void TaskOnMusicButtonDown()
    {
        // turn off audio coming from video
        
        

    }

     private void TaskOnDeleteButtonDown()
    {
        
        // TODO: delete user record from DB

    }



}
