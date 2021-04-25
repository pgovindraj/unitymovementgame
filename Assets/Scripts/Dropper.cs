using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{

    MeshRenderer  meshrenderer;
    Rigidbody rb;

    // Start is called before the first frame update

   [SerializeField] float timeToWait=3.0f;
    void Start()

    {
        meshrenderer= GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();

        meshrenderer.enabled=false;
        rb.useGravity=false;                    
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Time.time > timeToWait){
            // Debug.Log(Time.time);
            meshrenderer.enabled=true;
            rb.useGravity=true;
        }

        
    }
}
