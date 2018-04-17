using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewObject : MonoBehaviour {


    private GameObject secondLevelWay;

    void Start()
    {
        secondLevelWay = GameObject.Find("Way to Second Level");
        secondLevelWay.SetActive(false);
    }

	void OnDestroy()
    {

        secondLevelWay.SetActive(true);

    }
}
