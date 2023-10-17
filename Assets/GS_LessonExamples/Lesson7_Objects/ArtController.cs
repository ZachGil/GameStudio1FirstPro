using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]

public class ArtController : MonoBehaviour
{
    /*=====================start==============================================
    [Header("Input")]
    public float xInput;
    public float yInput;
    public Vector2 input;

    [Header("Art")]
    private SpriteRenderer spriteRenderer; //can hide it since will override anyways
    public Sprite walkSprite;
    public Sprite idleSprite;
    public Sprite jumpSprite;

    [Header("Player Controller")]
    public PlayerController playerController;

    // Update is called once per frame
    void Update()
    {
        GetInput();

        //jumping
        //check if is jumping first
        if (playerController.GetIsJumping())
        {
            //update my sprite renderer to my jump sprite
            //update sprite renderer to jump sprite
            spriteRenderer.sprite = jumpSprite;
        }
        else
        {
            UpdateWalk();
        }
    }

    private void GetInput()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertiacal");

        input = new Vector2(xInput, yInput);
    }

    private void UpdateWalk()
    {
        if(input.x < -0.1f)
        {   //left walk (MAKE SURE TO FLIP THE WALK SPRITE!!!!)
            spriteRenderer.sprite = walkSprite;
            spriteRenderer.flipX = true;
        }else if(input.x > 0.1f)
        {   //right walk
            spriteRenderer.sprite = walkSprite;
            spriteRenderer.flipX = false;
        }
        else
        {   //idle
            spriteRenderer.sprite = idleSprite;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //art
        spriteRenderer = this.GetComponent<SpriteRenderer>();

        if(spriteRenderer == null)
        {
            Debug.Log("No sprite renderer found !!!");
        }

        //player
        //get a referance to the player controller
        playerController = GetComponentInParent<PlayerController>();
        if (playerController == null)
        {
            Debug.Log("No player controller found !!!");
        }
    }
    ============================end=======================================*/
}
