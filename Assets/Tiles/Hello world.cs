using UnityEngine;
using UnityEngine.InputSystem.Processors;

public class Helloworld : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello world!");
        // CODE COMMENTS
        // :)
        int health = 10;

        health = 9;

        health = 10 - 1;

        health = health - 1;
        //floats store decimal values and end in f
        float critChance = 0.1f;

        critChance = critChance + 0.1f;
        //strings hold a string (or collection) of characters, making words
        string name = "john";

        Debug.Log("Hello " + name);
        //bools store a true or false value, used in lots of logic checks
        bool hasKey = true;
        bool isDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
