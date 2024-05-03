using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickerZone : MonoBehaviour
{
    // Start is called before the first frame update
    public static int Multiplier = 1;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));
            RaycastHit _hit;
            if (Physics.Raycast(ray, out _hit,Mathf.Infinity))
            {
                if (_hit.transform.tag == "ClickZone")
                {
                    ClockCounter.ClickNum +=Multiplier;
                }
                
            }
        }
    }
}
