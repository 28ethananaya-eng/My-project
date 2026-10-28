using UnityEngine;

public class IsItEnough : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 10;

        if (score >= 100)
        {
            Debug.Log("Reward unlocked!");
        }

        if(score < 100)
        {
            Debug.Log("Keep playing.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
