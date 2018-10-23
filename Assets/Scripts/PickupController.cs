using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupController : MonoBehaviour {
    private void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            TextController text = Object.FindObjectOfType<TextController>();
            text.current++;
            Destroy(this.gameObject);
        }
    }
}
