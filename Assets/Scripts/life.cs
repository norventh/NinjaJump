using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class life : MonoBehaviour
{
    public int remainingLife;
   
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "shuriken1")
        {
            remainingLife--;
            Debug.Log(remainingLife);
            
        }
        if(remainingLife == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            remainingLife= 3;
        }
    }
}
