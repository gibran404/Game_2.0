using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class charSlection : MonoBehaviour
{
    public static string character = "Boy";


    // Start is called before the first frame update
    public void PickBoy()
    {
        character = "Boy";
    }
    public void Pickgirl()
    {
        character = "Girl";
    }
}
