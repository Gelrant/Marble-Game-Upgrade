using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingPad : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Marble")
        {
            Destroy(this.gameObject);
            Rigidbody rb = col.GetComponent<Rigidbody>();
            rb.AddForce(0,120,0);
        }
    }
}
