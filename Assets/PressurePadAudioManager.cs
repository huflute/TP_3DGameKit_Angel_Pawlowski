using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePadAudioManager : MonoBehaviour
{
    

    public void PressurePad_Trigger()

    {
        AkSoundEngine.PostEvent("Play_Switch_Stone_Activation", this.gameObject);
    }
    public void DestroyPad()
    {
        Destroy(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
