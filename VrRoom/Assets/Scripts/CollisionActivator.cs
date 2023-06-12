using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollisionActivator : MonoBehaviour
{
    public GameObject NextObject,BrightLight;
    

    private void Start()
    {
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if(NextObject!=null)
        {
            NextObject.SetActive(true);
            transform.parent.gameObject.SetActive(false);
            BrightLight.SetActive(true);
           
           
        }
        else
        {
            Debug.Log("Exit");
            Application.Quit();
        }
    }
}
