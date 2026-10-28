using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int attack = 20;

        int r = -1;

        r = Random.Range(1, 101);
        Debug.Log(r);

        float rand = Random.Range(1, 101);

        if(attack >= 100)
        {
            Debug.Log("you defeated the enemy!");
        }

        if(attack < 100)
        {
            Debug.Log("you need more points");
        }
        
        if(rand >= 90)
        {
            Debug.Log("SPECIAL WEAPON DROP!");
        }

        if(rand < 90)
        {
            Debug.Log("the enemy droped a normal weapon");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
