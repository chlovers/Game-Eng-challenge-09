using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DailogManager : MonoBehaviour
{
    private GameManager gameManager;

    private Queue<string> dailogue;

    // Start is called before the first frame update
    void Start()
    {
        dailogue = new Queue<string>();

    }

    public void startdailogue(string[] sentences)
    {
        foreach(string currstring in sentences)
        {
            dailogue.Enqueue(currstring);
        }

        foreach(string sentence in dailogue)
        {

            Debug.Log(sentence);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
