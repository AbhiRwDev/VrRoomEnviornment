using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionActivator : MonoBehaviour
{
    public GameObject NextObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(NextObject!=null)
        {
            NextObject.SetActive(true);
        }
    }
}
