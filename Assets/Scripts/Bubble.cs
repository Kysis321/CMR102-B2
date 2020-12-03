using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    public int bubbleWorth; // how much bubble is worth
    private GameManager gameManager; // reference to our GameManager
    AudioSource audioData;
    public ParticleSystem stars;

    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();
        gameManager = FindObjectOfType<GameManager>(); //find a reference to our gamemanager;
    }

    /// <summary>
    /// Called when our bubble is popped.
    /// </summary>
    public void Pop()
    {
        audioData.Play();
        gameManager.AddScore(bubbleWorth); // add our score to the gamemanager
        stars.Play();
        Destroy(gameObject, 0.5f);
        
        // here we would probably spawn in a pop particle effect?
        // also can destroy this bubble here too, by using
        //Destroy(gameObject);
    }
}
