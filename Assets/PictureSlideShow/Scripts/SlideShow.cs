using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlideShow : MonoBehaviour
{
    public Image slideShowImage; // reference to the image on the canvas
    public bool runAuto = false; // do we want to start the slideshow automatically or manual?
    public float timeTillNextShow; // if we are running automatically how often should the next image show up
    public List<Sprite> allImagesToDisplay = new List<Sprite>(); // a list of all the sprites to show.
     
    private int currIndex; // the current index we are up to.

    // Start is called before the first frame update
    void Start()
    {
        currIndex = 0; // set it to the starting index
        slideShowImage.sprite = allImagesToDisplay[currIndex]; // set the image
        RunAutomatically(); // start the slideshow automatically
    }

    /// <summary>
    /// If we are running automatically then loop through each photo
    /// </summary>
    private void RunAutomatically()
    {
        if (runAuto) // if we are running auto
        {
            CancelInvoke("ShowNext"); // if we are actually running this automatically, we want to stop and start this over again, otherwise bad times.
            InvokeRepeating("ShowNext", timeTillNextShow, timeTillNextShow); // keep calling the function every interval.
        }
    }

    /// <summary>
    /// show us the previous one in the list
    /// </summary>
    public void ShowNext()
    {
        RunAutomatically();

        currIndex += 1;
        if (currIndex >= allImagesToDisplay.Count)
        {
            currIndex = 0;
        }

        slideShowImage.sprite = allImagesToDisplay[currIndex];
    }

    /// <summary>
    /// show us the next one in the list
    /// </summary>
    public void ShowPrevious()
    {
        RunAutomatically();
        currIndex -= 1;
        if (currIndex <0)
        {
            currIndex = allImagesToDisplay.Count-1;
        }
        // set our sprite to the new sprite
        slideShowImage.sprite = allImagesToDisplay[currIndex];
    }
}
