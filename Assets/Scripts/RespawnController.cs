using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnController : MonoBehaviour {

    public Transform playerTransform;
    private Vector3 startPosition;

	// Use this for initialization
	void Start () {
        startPosition = playerTransform.position;
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")){
            Rigidbody rb = other.GetComponent<Rigidbody>();
            rb.transform.position = startPosition;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            rb.velocity = Vector3.zero;
            //Debug.Log(rb.angularVelocity);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
