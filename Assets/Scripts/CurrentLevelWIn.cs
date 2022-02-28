using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentLevelWIn : MonoBehaviour
{
    public GameObject btn;
    public GameObject timer;
    public int number;
    private void Awake()
    {
       
        timer = GameObject.Find("Timer");
    }
    private void OnTriggerEnter(Collider other)
    {

        btn.GetComponent<Loader>().Load(number);
    }
}
