using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtonScript : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene("SampleScene");
    }
    //Loads the "SampleScene" when the button linked to PlayGame function is clicked 
}