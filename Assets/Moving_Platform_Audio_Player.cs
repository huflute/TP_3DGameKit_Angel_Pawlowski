using Gamekit3D.GameCommands;
using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Moving_Platform_Audio_Player : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Platform;
    public AK.Wwise.Event onStartEvent, onEndEvent;

    private SimpleTransformer _transformer;
    private float _duration;
    private float _stopTime;


    void Start()
    {
        _transformer = Platform.GetComponent<SimpleTransformer>();
        _duration = _transformer.duration - 2;
        _stopTime = _transformer.position;
        StartCoroutine(MovingPlatform(_duration, _stopTime));
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator MovingPlatform(float duration, float stoptime)
    {
        if (onStartEvent != null) onStartEvent.Post(this.gameObject);
        yield return new WaitForSeconds(duration);
        if (onEndEvent != null) onEndEvent.Post(this.gameObject);
        yield return new WaitForSeconds(stoptime);
        StartCoroutine(MovingPlatform(duration, stoptime));
    }
}
