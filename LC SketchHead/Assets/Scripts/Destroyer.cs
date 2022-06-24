using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        //GameObject.Find("GameController").GetComponent<GameController>().GameOver();
        //Debug.Log(collision.gameObject.name);
        
        if (collision.gameObject.name.Contains("Platform"))
        {

            Destroy(collision.gameObject);
            collision.gameObject.SetActive(false);
            Debug.LogWarning("found");
        } else
        {
            GameObject.Find("DoodleHead").SetActive(false);
        }
       }
}
