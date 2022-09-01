using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenShopButtonScript : MonoBehaviour
{
    public GameObject shopPanel;
    public GameObject ChestPanel;

    public void OpenShop()
    {
        if (shopPanel != null)
        {
            bool isActive = shopPanel.activeSelf;
            shopPanel.SetActive(!isActive);
            if (ChestPanel.activeInHierarchy == true)
            {
                ChestPanel.SetActive(false);
            }
        }
        //Opens the shop panel when the button linked to the OpenShop function is clicked 
        //Sets the chest panel to inactive 
    }
}
