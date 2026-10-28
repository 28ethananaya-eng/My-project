using UnityEngine;

public class UpgradeYourSword : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpgradeSword();
    }
    int coins = 100;
    int swordLevel = 1;
    void UpgradeSword()
    {
        if(coins >= 50)
        {
            swordLevel++;
            coins -= 50;
            Debug.Log("You have upgraded your sword! Your sword is now level 2.");
        }

        if(coins < 50)
        {
            Debug.Log("Can't upgrade sword. You don't have enough coins.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
