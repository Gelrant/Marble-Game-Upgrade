using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUp : MonoBehaviour {

    

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Marble")
        {
            Destroy(this.gameObject);
            Rigidbody rb = col.GetComponent<Rigidbody>();
            rb.AddForce(rb.velocity.normalized * 0.24f, ForceMode.Impulse);
        }
    }
}
