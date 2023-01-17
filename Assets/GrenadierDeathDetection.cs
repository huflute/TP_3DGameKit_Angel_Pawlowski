using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadierDeathDetection : MonoBehaviour
{
 

    public void DestroyDetectGrenadier()
    {
        Destroy(this);
    }

    public void NotInCombat()
    {
        AkSoundEngine.SetState("IsInCombat", "False");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
