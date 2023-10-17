using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerZach : MonoBehaviour
{
    public GameObject theObjectToSpawn;
    
    public GameObject[] arrayOfSpawningObjects = new GameObject[10];
    private float amountOfObjects = 10;//amount of objects
    public bool[] arrayOfNoObjects = new bool[10];// to count the removed objects from spawnObj

    // Start is called before the first frame update
    void Start()
    {
        //GameObject go = Instantiate(theObjectToSpawn, transform.position, Quaternion.identity);
        //Rigidbody2D rb = go.GetComponent<Rigidbody2D>();

        //arrayOfSpawningObjects[0] = go;

        for(int i = 0; i < arrayOfSpawningObjects.Length; i++)
        {
            GameObject go = Instantiate(theObjectToSpawn, transform.position, Quaternion.identity);
            go.name = go.name + ": (" + i + ")";//changes the name of each object 
            arrayOfSpawningObjects[i] = go;
            Destroy(go, Random.Range(1f, 7f));
            Debug.Log("spawned: " + go.name);
        }
        Debug.Log("The amount of objects: " + amountOfObjects);
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0;i < arrayOfSpawningObjects.Length;i++)
        {
            if (arrayOfSpawningObjects[i] == null && arrayOfNoObjects[i] == false && amountOfObjects > 0)
            {                                                                       //amount of objects
                amountOfObjects--;
                arrayOfNoObjects[i] = true;
                Debug.Log("The amount of objects: " + amountOfObjects);
            }
            
        }
    }
}
