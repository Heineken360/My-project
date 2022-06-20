using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLight : MonoBehaviour
{
    public static float minY =-2.5f;
    void Start()
    {
        
    }

    
    void Update()
    {
        
            Destroy(this.gameObject, 5);
        
    }
    
}
