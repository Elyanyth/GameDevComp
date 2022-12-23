using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Inventory : MonoBehaviour
{
    public GameObject Inv;
    [SerializeField] public Color Color;
    GameObject Slot;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab)) 
        {
            Debug.Log("Tab is pressed");
            if (Inv.gameObject.activeSelf) 
            {
                Inv.gameObject.SetActive(false);
            } 
            else 
            {
                Inv.gameObject.SetActive(true);                
            }
            
        }

        if (Inv.gameObject.activeSelf) 
        {
            //Debug.Log(Int32.TryParse(Input.inputString, out int num));
                if (Int32.TryParse(Input.inputString, out int num)) {
                    if (Slot != null) 
                    {
                        Slot.SetActive(true);
                    }
                    Slot = Inv.gameObject.transform.GetChild(num-1).gameObject;
                    Slot.SetActive(false);
                }
        }
        
    }
}
