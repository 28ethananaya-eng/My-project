using UnityEngine;

public class Customfunction : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LevelUp(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //variables defined at the class level can be used elsewhere
    int xp = 100;
    int level = 1;
    void LevelUp()
    {
        //when we level up we increase the player level if their xp is high enough, then we reduce our xp
        //two variables we really care about: xp and level (maybe: xp cap, stats, etc
        if(xp >= 100)
        {
            //when I level up, gain a level and subract xp required to level from xp
            level = level + 1;
            //level + = 1;
            //level++;
            xp -= 100;
            Debug.Log("Ding! You leveled up! Congrats!");
        }
    }
}
