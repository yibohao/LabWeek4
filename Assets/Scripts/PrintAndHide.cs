using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{

    int i = 3;

    public Renderer rend;

    int random;

    // Start is called before the first frame update
    void Awake()
    {
        random = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);
        //Debug.Log("random number: " + random);

        if (i == 100 && GameObject.FindWithTag("Red") != null)
        {
            GameObject.FindWithTag("Red").SetActive(false);
        }
        if(i == random)
        {
            GameObject.FindWithTag("Blue").GetComponent<Renderer>().enabled = false;
        }
    }
}
