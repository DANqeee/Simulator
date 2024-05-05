using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


// Start is called before the first frame update
    public class BuyInShop : MonoBehaviour
    {
        [SerializeField] private int PriseProduct;
        [SerializeField] private string NameProduct;
        [SerializeField] private int multiplier;
        [SerializeField] private bool checkingThePurchase;
        public void NameButton()
        {
            Debug.Log(gameObject.name + NameProduct + PriseProduct);
            if (ClockCounter.ClickNum >= PriseProduct && checkingThePurchase == false)
            {
                checkingThePurchase = true;
                Debug.Log("поздравляем с покупкой");
                ClockCounter.ClickNum -= PriseProduct;
                ClickerZone.Multiplier += multiplier;
            }
            else if (checkingThePurchase == true)
            {
                Debug.Log("скин оделся");
            }
            else
            {
                Debug.Log("недостаточно средств");
            }
        }
       
    }

