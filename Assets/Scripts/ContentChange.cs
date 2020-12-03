using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContentChange : MonoBehaviour
{ 
    public string contentOne; // first text content
    public Sprite contentOneIcon; // first contentIcon
    public Sprite contentOneOrigin; // first contentIcon Origional
    public string contentTwo; // second text content
    public Sprite contentTwoIcon; // second content icon
    public Sprite contentTwoOrigin; // second contentIcon Origional
    public string contentThree; // Third text content
    public Sprite contentThreeIcon; // Third content icon
    public Sprite contentThreeOrigin; // Third contentIcon Origional
    public string contentFour; // Fourth text content
    public Sprite contentFourIcon; // Fourth content icon
    public Sprite contentFourOrigin; // Fourth contentIcon Origional
    public string contentFive; // Fifth text content
    public Sprite contentFiveIcon; // Fifth content icon
    public Sprite contentFiveOrigin; // fifth contentIcon


    public Image imageComponent; // reference to the icon image component
    public Image imageComponent2; // reference to the icon image component
    public Image imageComponent3; // reference to the icon image component
    public Image imageComponent4; // reference to the icon image component
    public Image imageComponent5; // reference to the icon image component

    // Start is called before the first frame update
    void Start()
    {
       
    }
    
    public void ChangeToContentOne()
    {
        
        imageComponent.sprite = contentOneIcon; // set our icon to our content sprite
        imageComponent2.sprite = contentTwoOrigin; // set our icon to our content sprite
        imageComponent3.sprite = contentThreeOrigin; // set our icon to our content sprite
        imageComponent5.sprite = contentFiveOrigin; // set our icon to our content sprite
    }

    public void ChangeToContentTwo()
    {
        //textComponent.text = contentTwo; // set our text to our text content
        imageComponent2.sprite = contentTwoIcon; // set our icon to our content sprite
        imageComponent.sprite = contentOneOrigin; // set our icon to our content sprite
        imageComponent3.sprite = contentThreeOrigin; // set our icon to our content sprite
        imageComponent5.sprite = contentFiveOrigin; // set our icon to our content sprite
    }
    public void ChangeToContentThree()
    {
        //textComponent.text = contentThree; // set our text to our text content
        imageComponent3.sprite = contentThreeIcon; // set our icon to our content sprite
        imageComponent2.sprite = contentTwoOrigin; // set our icon to our content sprite
        imageComponent.sprite = contentOneOrigin; // set our icon to our content sprite
        imageComponent5.sprite = contentFiveOrigin; // set our icon to our content sprite
    }
    public void ChangeToContentFour()
    {
        //textComponent.text = contentThree; // set our text to our text content
        imageComponent4.sprite = contentFourIcon; // set our icon to our content sprite
    }
    public void ChangeToContentFive()
    {
        //textComponent.text = contentThree; // set our text to our text content
        imageComponent5.sprite = contentFiveIcon; // set our icon to our content sprite
        imageComponent2.sprite = contentTwoOrigin; // set our icon to our content sprite
        imageComponent3.sprite = contentThreeOrigin; // set our icon to our content sprite
        imageComponent.sprite = contentOneOrigin; // set our icon to our content sprite
    }
}
