using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentLevelWIn : MonoBehaviour
{
    public GameObject btn;
    public GameObject timer;
    private void Awake()
    {
        btn = GameObject.Find("NextLevelBtn");
        timer = GameObject.Find("Timer");
    }
    private void OnTriggerEnter(Collider other)
    {

        Debug.Log(other);
        if ( other.gameObject.name == "Player")
        {
            Vector3 pos = btn.transform.position;
            pos.x += 50f;
            pos.y -= 50f; 
            btn.transform.position = pos;
            btn.transform.localScale = new Vector3(2,2,2);
        }
        timer.GetComponent<Timer>().enabled = false;
    }
}
