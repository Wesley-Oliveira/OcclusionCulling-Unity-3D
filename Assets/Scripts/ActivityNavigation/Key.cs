using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    private bool key;
    public GameObject door;
    
    void Start()
    {
        key = false;
        door.SetActive(true);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Key")
        {
            Debug.Log("opa");
            key = true;
            Destroy(col.gameObject);
        }

        if (col.gameObject.tag == "Door")
        {
            if (key)
            {
                Debug.Log("opa");
                //mover porta, abrir passagem
                door.SetActive(false);
            }
        }
    }
}
