using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerHealth : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //store hp in a varable
    //if we hit an enemy, reduce hp
    //when you lose all hp, you die.
    // when we die, reload the level
    public int health = 100;
    
        private void OnCollisionEnter2D(Collision2D collision)
        {
            Debug.Log(collision.gameObject.name);
            //double == compares the values to see if they are true or false
            if (collision.gameObject.tag == "Enemy")
            {
            Debug.Log("I have hit an enemy!");
            }
        }
    

    void start()
        {
        
        }
}
    
      