using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invisibility : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Marble")
        {
            this.gameObject.GetComponent<Renderer>().enabled = false;
            GameObject marble = col.gameObject;
            col.gameObject.GetComponent<Renderer>().enabled = false;
            StartCoroutine(invisibilityWaiting(marble));
        }
    }


    IEnumerator invisibilityWaiting(GameObject myObject)
    {
        yield return new WaitForSeconds(3);
        myObject.GetComponent<Renderer>().enabled = true;
        Destroy(this.gameObject);
    }
}

