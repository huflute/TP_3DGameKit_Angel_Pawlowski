using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCrateAudioManager : MonoBehaviour
{
    [SerializeField] private AK.Wwise.Event OpenCrate;

    public void HealthCrate_Open()

    {
        OpenCrate.Post(this.gameObject);
    }
    public void DestroyCrate()
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
