using UnityEngine;

public class RandomNumbers : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int r = -1;
        //Random.Range for integers is inclusive on the min
        //exclusive on the max. So (1, 100) can give values from 1 through 99
        r = Random.Range(1, 101);
        Debug.Log(r);
        //floats using Random.Range are inclusive on the min and the max 
        //so (1f, 100f) can give any value from 1.0-100.0
        float rand = Random.Range(1f, 100f);
        //if my random float is high enough, get a special loot drop
        if (rand > 90)
        {
            Debug.Log("you received Deathcharger's reins!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
