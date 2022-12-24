using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enterMenu : MonoBehaviour
{

    public GameObject menu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKey("e")){
            menu.gameObject.SetActive(true);
            Debug.Log("INTERACTION");
        }
    }
}
