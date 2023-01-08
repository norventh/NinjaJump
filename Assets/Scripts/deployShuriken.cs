using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployShuriken : MonoBehaviour
    
{
    public GameObject shurikenPrefab;
    
    private Vector2 screenBounds;


    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(shurikenWaves());
    }
    private void spawnShuriken() 
    {
        GameObject a = Instantiate(shurikenPrefab) as GameObject;
        a.transform.position = new Vector3(Random.Range(-15,-12), (float)0.8959999, (float)2.744667);
    }
    IEnumerator shurikenWaves()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1,3));
            spawnShuriken();
        }
    }
       
       
    
        
    
}
