using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePadAudioManager : MonoBehaviour
{
    [SerializeField] private AK.Wwise.Event TriggerPressurePad;

    public void PressurePad_Trigger()

    {
        TriggerPressurePad.Post(this.gameObject);
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
