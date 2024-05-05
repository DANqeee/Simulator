using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockCounter : MonoBehaviour
{
    [SerializeField]public  Text Click ;
  
    public static int ClickNum = 0;
    void Update()
    {
        Click.text = ClickNum.ToString();
        
    }
}
