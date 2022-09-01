using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChestButtonScript : MonoBehaviour
{
    public GameObject chestPanel;
    public GameObject shopPanel;

    public void OpenChest()
    {
        if (chestPanel !=null)
        {
            bool isActive = chestPanel.activeSelf;
            chestPanel.SetActive(!isActive);
            if (shopPanel.activeInHierarchy == true)
            {
                shopPanel.SetActive(false);
            }
        }
    }
    //Opens the chest panel when the button linked to the OpenChest function is clicked 
    //Sets the shop panel to inactive 

}
