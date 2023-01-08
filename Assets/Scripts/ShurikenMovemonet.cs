using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShurikenMovemonet : MonoBehaviour
{
    public float moveSpeed;
    
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));


    }


    private void OnTriggerEnter(Collider collision)
    {   
        if (collision.GetComponent<wall>() ) 
        {
            moveSpeed *= -1f;
        }
        
    }
 // Update is called once per frame
    void Update()
    {
        transform.Translate(moveSpeed*Time.deltaTime, 0, 0);
        
        if (transform.position.x < screenBounds.x * 3)
        {
            Destroy(this.gameObject);


        }
        



}
}
