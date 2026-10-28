using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    //OnAttack will get called whenever the attack button is pressed
    //creat a new copy of the player bullet object
    //push the bullet in the directionof the mouse
    //destroy the bullet after a few seconds to keep the level clean
    // Update is called once per frame
    public GameObject bullet;
    public void OnAttack()
    {
        GameObject shot = Instantiate(bullet, transform.position, Quaternion.identity);
        Vector3 mousePos = Mouse.current.position.ReadValue();
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        mousePos.z = 0;
        Debug.Log(mousePos);
        Vector3 shootDir = mousePos - transform.position;
        shot.GetComponent<Rigidbody2D>().linearVelocity = shootDir;
        //CHALLENGE
        // Make it so the bullets go faster, but still maintain a consistant velocity
        // Try to get Enemy health that will reduce when hit by a bullet    L
    }
}
