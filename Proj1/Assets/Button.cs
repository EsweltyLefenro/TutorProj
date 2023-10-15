using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Object;

    public void Press()
    {
        if (Object.active == true)
        {
            Debug.Log("Object deacivated");
            Object.SetActive(false);
        }

        else
        {
            Debug.Log("Object acivated");
            Object.SetActive(true);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
