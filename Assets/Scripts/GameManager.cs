using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int currentScore = 0; // our currentScore;
    private UIManager uiManager; // reference to our UI manager
    public Transform bubbleZone; // reference to the area bubbles start at
    public Vector3 bubbleSpawnArea; //size of the Bubble area
    public GameObject bubble; // a Reference to the Bubble prefab to spawn
    private GameObject currentBubble; //a reference to the current spawned bubble
    public Transform ARContentParent; //reference to the parent of AR Content for Bubble
    public float upForce = 1; //upwards force added to bubbles at their spawn

    private void Start()
    {
        Debug.Log("New bubble start position was:" + RandomBubbleStart());
        uiManager = FindObjectOfType<UIManager>(); // find a reference to our Ui manager
        uiManager.UpdateScoreText(currentScore); // update our UI to show the starting score
        nextTimeToSpawn = Time.time + Random.Range(0, 5f);
    }

    private void Update()
    {
        TimeToSpawn();
    }




    public void AddScore(int amount)
    {
        currentScore += amount; // add the new amount to our current score.
        uiManager.UpdateScoreText(currentScore); // update our UI
    }

    public Vector3 RandomBubbleStart()
    {
        float xPosition = Random.Range(-bubbleSpawnArea.x / 2, bubbleSpawnArea.x / 2); // gives us a random number between negative moveArea X and Positive moveArea X.
        float yPosition = bubbleZone.position.y; // our soccerfields Y transform position
        float zPosition = Random.Range(-bubbleSpawnArea.z / 2, bubbleSpawnArea.z / 2); // gives us a random number between negative moveArea Z and Positive moveArea Z.

        return new Vector3(xPosition, yPosition, zPosition);
    }
    ///<summary>
    ///Spawns in a bubble at a random position after a random time has elapsed. Only one bubble will be active at any given time (Hopefully)
    ///</summary>
    ///<param name="positionToSpawn"></param>

    public void SpawnBubble(Vector3 positionToSpawn)
    {
        if (bubble == null)
        {
            Debug.LogError("Bubble hasnt been assigned! check the Inspector");
        }
        if(currentBubble ==null)
        {
            currentBubble = Instantiate(bubble, positionToSpawn, bubble.transform.rotation, ARContentParent);
            currentBubble.GetComponent<Rigidbody>().velocity = Vector3.zero; //sets velocity of bubble to zero on spawn
            currentBubble.GetComponent<Rigidbody>().angularVelocity = Vector3.zero; // sets the velocity to start as Zero
            currentBubble.GetComponent<Rigidbody>().AddForce(transform.up * upForce);
            
            
        }
        else
        {
            currentBubble.transform.position = positionToSpawn;
            currentBubble.GetComponent<Rigidbody>().velocity = Vector3.zero; //sets velocity of bubble to zero on spawn
            currentBubble.GetComponent<Rigidbody>().angularVelocity = Vector3.zero; // sets the velocity to start as Zero
            currentBubble.GetComponent<Rigidbody>().AddForce(transform.up * upForce);
        }
        Destroy(currentBubble, 10f);
    }

    private float nextTimeToSpawn = 0f;

   
    private void TimeToSpawn()
    {
        if(Time.time >= nextTimeToSpawn)
        {
            nextTimeToSpawn = Time.time + Random.Range(0, 5f);
            Vector3 nextSpawnPoint = new Vector3(Random.Range(-5, 5f), 0, Random.Range(-5, 5f));
            SpawnBubble(nextSpawnPoint);
        }
    }

}
