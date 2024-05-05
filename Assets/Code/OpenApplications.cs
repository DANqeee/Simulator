using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenApplicationsMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ApplicationMenu;
    public GameObject Application;
    public GameObject Desktop;
    void Start()
    {
        Application.SetActive(false);
    }
    public void OpenApplication()
    {
        ApplicationMenu.SetActive(true);
        Application.SetActive(true);
        Desktop.SetActive(false);
    }
}
