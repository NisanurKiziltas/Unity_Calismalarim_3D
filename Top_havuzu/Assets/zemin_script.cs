using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zemin_script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        KureYarat(150);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void KureYarat(int length)
    {
    	for(int i = 0; i < length; i++)
    	{
    		GameObject kure = GameObject.CreatePrimitive(PrimitiveType.Sphere);
    		kure.transform.position = new
    		Vector3(
    		Random.Range(-5.0f, 5.0f),
    		Random.Range(-5.0f, 50.0f),
    		Random.Range(-5.0f, 5.0f)
    		);
    		kure.AddComponent<Rigidbody>();
    	}
    
    
    }
}
