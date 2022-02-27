using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;
    public int currentForm;
    public Vector3 horizontalIncrease;
    public Vector3 verticalIncrease;
    Rigidbody rb;
    void Start()
    {
        currentForm = 0;
    }


    void Update()
    {
        if (player.transform.localScale.z > 0.1f)
        {
            if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.N))
            {
                player.transform.localScale += horizontalIncrease;
            }
        }
        if (player.transform.localScale.x > 0.3f)
        {
            if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.M))
            {
                player.transform.localScale += verticalIncrease;
            }
        }
        
    }
}
