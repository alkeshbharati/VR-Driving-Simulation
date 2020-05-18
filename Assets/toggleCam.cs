using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleCam : MonoBehaviour
{

    public GameObject cam1;
    public GameObject cam2;

    void Update() {
        if (Input.GetButtonDown("1Key"))
        {
            Debug.Log("pressed 1");
            cam1.SetActive(true);
            cam2.SetActive(false);

        }
        if (Input.GetButtonDown("2Key"))
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
        }
    }

}
