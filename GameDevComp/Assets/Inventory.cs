using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEditor;

public class Inventory : MonoBehaviour
{
    public GameObject Inv;
    public Color SelColor;
    GameObject Slot;
    GameObject HotBar;
    // I had to hive HotBar a tag for a different reason,so why not use that here
    void Start() {
        HotBar = GameObject.FindGameObjectWithTag("HotBar").gameObject;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab)) 
        {
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
                    if (Slot.transform.childCount >= 1){
                        if (HotBar.transform.childCount >= 1){
                            Destroy(HotBar.transform.GetChild(0).gameObject);
                        }

                        GameObject item = Slot.gameObject.transform.GetChild(0).gameObject;
                        item = Instantiate(item);
                        item.transform.SetParent(HotBar.transform);

                        item.gameObject.transform.position = new Vector3(550.5f,57,100);
                    }
                    else {
                        if (HotBar.transform.childCount >= 1){
                            Destroy(HotBar.transform.GetChild(0).gameObject);
                        }
                    }
                }
        }
        
    }
}
