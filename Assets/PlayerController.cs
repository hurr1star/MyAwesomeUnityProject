using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Code from User 1 (GitKraken)
        gameObject.SetActive(false);
        // Added by User 2 (GitHub Desktop)
        GameObject.Destroy(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
