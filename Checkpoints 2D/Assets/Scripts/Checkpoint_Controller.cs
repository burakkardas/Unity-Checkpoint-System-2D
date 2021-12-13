using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint_Controller : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Player")) {
            Hero_Controller._lastPosition = transform.position;
        }
    }
}
