using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation : MonoBehaviour
{
    //public GameObject respawnPrefab;
    public GameObject[] deliveryTargets;
    public GameObject targetHouse; 

    // Start is called before the first frame update
    void Start()
    {
        deliveryTargets = GameObject.FindGameObjectsWithTag("DeliveryTarget");

        if (deliveryTargets != null)
            targetHouse = deliveryTargets[Random.Range(0, deliveryTargets.Length - 1)];

       
            targetHouse.GetComponent<Renderer>().material.color = Color.green;
    
    }


    // Update is called once per frame
    void Update()
    {

    }
}
