using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpriteController : MonoBehaviour
{
    public GameObject Boy;
    public GameObject Girl;
    // Start is called before the first frame update
    void Start()
    {
        if (charSlection.character == "Boy")
        {
            Boy.SetActive(true);
            Girl.SetActive(false);
        }
        else
        {
            Boy.SetActive(false);
            Girl.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
