using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonScript : MonoBehaviour
{
    public void LoadMenu()
    {
        SceneManager.LoadScene("StartScene");
    }
    //Opens the "StartScene" when the button linked to the LoadMenu function is clicked 
}
