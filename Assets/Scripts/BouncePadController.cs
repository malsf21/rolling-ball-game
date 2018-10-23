using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncePadController : MonoBehaviour {

    public float bouncePower = 20;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")){
            Rigidbody rb = other.GetComponent<Rigidbody>();
            rb.AddForce(this.transform.up * bouncePower, ForceMode.Impulse);
        }
    }
}
