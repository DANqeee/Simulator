using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


// Start is called before the first frame update
    public class BuyShop : MonoBehaviour
    {
        [SerializeField] private int PriseProduct;
        [SerializeField] private string NameProduct;
        [SerializeField] private int multiplier;
        public void NameButton()
        {
            Debug.Log(gameObject.name + NameProduct + PriseProduct);
            if (ClockCounter.ClickNum >= PriseProduct)
            {
                Debug.Log("+++++");
                ClockCounter.ClickNum -= PriseProduct;
                ClickerZone.Multiplier += multiplier;
            }
            else
            {
                Debug.Log("----");
            }
        }
       
    }

