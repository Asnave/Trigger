using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger1 : MonoBehaviour
{
    public GameObject Ghost;

    private void Start()
    {
        Ghost.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        Ghost.SetActive(true);
    }
    void OnTriggerExit(Collider other)
    {
        Ghost.SetActive(false);
    }

}
