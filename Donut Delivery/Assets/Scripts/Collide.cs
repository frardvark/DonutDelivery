using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collide : MonoBehaviour
{
    public Material green;

    void OnCollisionEnter(Collision collisionInfo)
    {
        //Debug.Log("Collision detected!");
        if (collisionInfo.collider.tag == "toDeliver")
        {
            Debug.Log("Delivered!");
            Collider house = collisionInfo.collider;
            house.tag = "Delivered";

            //maybe need to change more than just material?
            Renderer rend = house.GetComponent<Renderer>();
            if (rend != null)
                rend.material = green;


        }
    }
}
