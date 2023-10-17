using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    //get projectile

    public Rigidbody2D projectilePrefab;

    //get input
    public bool input;

    public float shootingForce = 10f;

    //get pos to spawn at
    //get rotation to spawn at 

    //get referance to the projectile rigidbody
    //add the force



    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        input = Input.GetButtonDown("Jump");
       
        if(input)
        {
            //Rigidbody2D rb = Instantiate(projectilePrefab);

            Rigidbody2D rb = Instantiate<Rigidbody2D>(projectilePrefab, transform.position, transform.rotation);

            //also get collider
            CircleCollider2D cc = rb.GetComponent<CircleCollider2D>();
            //Rigidbody2D rb = Instantiate<Rigidbody2D>(projectilePrefab, transform.position + (Vector3)Vector2.up, Quaternion.identity);


            rb.AddRelativeForce(Vector2.up * shootingForce, ForceMode2D.Impulse);

            //rb.AddRelativeForce(Vector2.up)


            //was trying to get the prefab to destroy after a certain amount 
            //Destroy(projectilePrefab, 10f);

            //Destroy(go, Random.Range(1f, 7f));-------do this if you want it to destroy after a certain amount
            //more of it in spawner Zach, gamestudio1FirstPro
        }
    }
}
