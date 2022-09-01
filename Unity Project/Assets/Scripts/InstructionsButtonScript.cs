using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionsButtonScript : MonoBehaviour
{
    public void LoadInstructions()
    {
        SceneManager.LoadScene("InstructionsScene");
    }
    //Opens the "InstructionsScene" when the button linked to the LoadInstructions function is clicked 
}
