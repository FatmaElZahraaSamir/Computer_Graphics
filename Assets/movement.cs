using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
    private Rigidbody rb;
    public float speed
 ;	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float v = Input.GetAxis("Vertical");
        float H = Input.GetAxis("Horizontal");
        Vector3 v3 = new Vector3(H, 0.0f, v);
        rb.AddForce(v3);
	}
}
