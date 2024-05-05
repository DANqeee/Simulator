using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telephone : MonoBehaviour
{
    public GameObject TelephoneMenu;
    public GameObject ApplicationMenu;
    public GameObject Desktop;
    void Start()
    {
        TelephoneMenu.SetActive(false);
    }
    public void OpenTelephoneMenu()
    {
        TelephoneMenu.SetActive(true);
    }
    public void CloseTelephoneMenu()
    {
         ApplicationMenu.SetActive(false);
         Desktop.SetActive(true);
        TelephoneMenu.SetActive(false);
    }
}
