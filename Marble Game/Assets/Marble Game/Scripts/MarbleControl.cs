using UnityEngine;
using System.Collections;

public class MarbleControl : MonoBehaviour {

    public float movementSpeed = 6.0f;
    public int jumpTest=0;
	
	void Update () {
        	Vector3 movement = (Input.GetAxis("Horizontal") * -Vector3.left * movementSpeed) + (Input.GetAxis("Vertical") * Vector3.forward *movementSpeed);
		movement *= Time.deltaTime;
        	GetComponent<Rigidbody>().AddForce(movement, ForceMode.Force);


        if (Input.GetKeyDown("space") && jumpTest==1)
        {
            GetComponent<Rigidbody>().AddForce(0,10,0);
            jumpTest = 0;
        }




    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Straight" || col.gameObject.name == "Turn")
        {
            jumpTest = 1;
        }
    }

    void OnTriggerEnter  (Collider other  ) {
        if (other.tag == "Pickup")
        {
            MarbleGameManager.SP.FoundGem();
            var go = GameObject.Find("PickupSound");
            AudioSource audio,audio2;
            if (other.gameObject.name == "pPlane3")
            {
                go = GameObject.Find("KeySound");
                audio2 = go.GetComponent<AudioSource>();
                audio2.Play();
            }
            else
            {
                audio = go.GetComponent<AudioSource>();
                audio.Play();
            }
            
            Destroy(other.gameObject);
        }
        else if (other.tag == "Invisibility" || other.tag == "SpeedUp" || other.tag == "Pad")
        {
            var go = GameObject.Find("PowerUpSound");
            AudioSource audio = go.GetComponent<AudioSource>();
            audio.Play();
        }        
    }

}
