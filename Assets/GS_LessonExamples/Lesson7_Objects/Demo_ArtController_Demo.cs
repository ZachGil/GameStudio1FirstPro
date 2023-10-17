using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo_ArtController_Demo : MonoBehaviour
{
    /*
    1. basic walk
    2. Dancing - array of sprites, iterate through array to dance

     */


    // Referance to the Sprite renderer
    public SpriteRenderer spriterenderer;

    // Referance to the sprites
    public Sprite idleSprite;
    public Sprite walkSprite;
    public Sprite jumpSprite;
    public Sprite deadSprite;

    // Input
    public Vector2 input;
    public bool isjumpButtonPressed;

    public Sprite[] danceSequence;
    public bool isDanceSequenceHappeneing = false;
    public float danceTimer = 5f;
    private float current_danceTimer = 0;
    private int currentDanceFrame = 0;

   
    void Update()
    {
        // input
        input = new Vector2(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"));
        isjumpButtonPressed = Input.GetButtonDown("Jump");


        // update our art according to input
        // 

        if( input.x < 0.1f && input.x > -0.1f)
        {   // idle state
            spriterenderer.sprite = idleSprite;
        }
        else if(input.x > 0.1f)
        {   //walk right
            spriterenderer.sprite = walkSprite;
            spriterenderer.flipX = true;
        }
        else if(input.x < -0.1f)
        {   //walk left
            spriterenderer.sprite = walkSprite;
            spriterenderer.flipX = false;
        }
        else
        {
            Debug.LogError("Should not be here");
        }


        if (input.x < 0.1f && input.x > -0.1f)
        {   // idle state
            spriterenderer.sprite = idleSprite;
        }
        else if (input.x > 0.1f)
        {   //walk right
            spriterenderer.sprite = walkSprite;
            spriterenderer.flipX = true;
        }
        else if (input.x < -0.1f)
        {   //walk left
            spriterenderer.sprite = walkSprite;
            spriterenderer.flipX = false;
        }
        else
        {
            Debug.LogError("Should not be here");
        }


        if (isjumpButtonPressed)
        {
            StartDanceSequence();
        }
        if (isDanceSequenceHappeneing)
        {
            spriterenderer.sprite = danceSequence[currentDanceFrame];
            currentDanceFrame++;

            currentDanceFrame = currentDanceFrame % danceSequence.Length;
        }

    }

    public void StartDanceSequence()
    {
        /*
        public Sprite[] danceSequence;
        public bool isDanceSequenceHappeneing = false;
        public float danceTimer = 5f;
        public float current_danceTimer = 0;
        private int currentDanceFrame = 0;
        */
        isDanceSequenceHappeneing = true;
        current_danceTimer = 0;
        spriterenderer.sprite = danceSequence[0];
    }
}
