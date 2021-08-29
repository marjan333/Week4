using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    public int i; 
    // Start is called before the first frame update
    void Start()
    {
        i = 3; 
    }

    // Update is called once per frame
    void Update()
    {
        i++; 
        Debug.Log(gameObject.name + ":" + i);

        if(gameObject.tag == "Red" && i ==100){
            gameObject.SetActive(false);
        }
        if(gameObject.tag == "Blue" && i== Random.Range(200f, 250f)){
             gameObject.SetActive(false);
        }
    }
}
