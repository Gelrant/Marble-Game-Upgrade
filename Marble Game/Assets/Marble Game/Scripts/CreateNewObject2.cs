using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewObject2 : MonoBehaviour {


    private GameObject secondLevel;

    void Start()
    {
        secondLevel = GameObject.Find("Second Level");
        secondLevel.SetActive(false);
    }

    void OnDestroy()
    {

        secondLevel.SetActive(true);

    }
}
