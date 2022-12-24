using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Inventory : MonoBehaviour
{
    public GameObject Inv;
    [SerializeField] public Color SelColor;
    GameObject Slot;
    [SerializeField] public GameObject HotBar;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab)) 
        {
            Debug.Log("Tab is pressed");
            if (Inv.gameObject.activeSelf) 
            {
                Inv.gameObject.SetActive(false);
                HotBar.gameObject.SetActive(true);
            } 
            else 
            {
                Inv.gameObject.SetActive(true);  
                HotBar.gameObject.SetActive(false);              
            }
            
        }

        if (Inv.gameObject.activeSelf) 
        {
            //Debug.Log(Int32.TryParse(Input.inputString, out int num));
                if (Int32.TryParse(Input.inputString, out int num)) {
                    if (Slot != null) 
                    {
                        Slot.GetComponent<Image>().color = Color.black;
                    }
                    Slot = Inv.gameObject.transform.GetChild(num-1).gameObject;
                    Slot.GetComponent<Image>().color = Color.red;
                    if (Slot.transform.childCount == 1){
                        GameObject item = Slot.gameObject.transform.GetChild(0).gameObject;
                        item = Instantiate(item);
                        item.transform.SetParent(HotBar.transform);
                    }
                    

                }
        }
        
    }
}
