using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasRotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 relativePosition = transform.position - Camera.main.transform.position; //get the relative dorection of the canvas to the players camera
        //relativePosition.y = 0; //to prevent the canvas to rotate on the Y axis
        Quaternion rotation = Quaternion.LookRotation(relativePosition);//create the rotation to look at the user
        transform.rotation = rotation;




    }
}
