using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followcamera : MonoBehaviour
{
    public Transform followTransform;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(followTransform.position.x + offset.x, followTransform.position.y + offset.y, this.transform.position.z);
        
        
    }
}
