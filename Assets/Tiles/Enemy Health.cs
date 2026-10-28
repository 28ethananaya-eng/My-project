using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
