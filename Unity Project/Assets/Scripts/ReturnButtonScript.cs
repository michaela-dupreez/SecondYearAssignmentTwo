using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnButtonScript : MonoBehaviour
{
    public void ReturnButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
    //Loads "SampleScene" when the button linked to the ReturnButton function is clicked 
}
