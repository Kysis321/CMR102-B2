using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInput : MonoBehaviour
{
    public LayerMask layersToHit;// the layers we are going to allowed to hit.
    public float distance = 100; // the distance our ray can shoot

    // Update is called once per frame
    void Update()
    {
        GetMouseInput();
    }

    /// <summary>
    /// Gets input from the player mouse/tap on the screen.
    /// </summary>
    void GetMouseInput()
    {
        if (Input.GetMouseButtonDown(0))// primary mouse input/touch input.
        {
            RaycastHit hit; // data stored based on what we've hit.
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // draws a ray from my camera to my mouse position in the world.

            // Do our ray cast, if we hit something or blocks the ray, store the data in hit.
            if (Physics.Raycast(ray, out hit, distance, layersToHit))
            {
                // just a default ray
                Debug.Log(hit.transform.name);

                if (hit.transform.GetComponent<Bubble>()) // checks to see if what we hit with our ray has a bubble script
                {
                    // if what we hit has a bubble script on it. call our pop function!
                    hit.transform.GetComponent<Bubble>().Pop();
                }
            }
        }
    }
}
