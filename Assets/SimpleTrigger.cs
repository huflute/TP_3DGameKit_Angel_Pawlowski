using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SimpleTrigger : MonoBehaviour
{
    [System.Serializable]
    public class vTriggerEvent : UnityEvent<Collider> { }

    public bool AudioDebug = false;
    public List<string> tagsToDetect = new List<string>() { "Player" };
    public vTriggerEvent onTriggerEnter;
    public vTriggerEvent onTriggerExit;



    [HideInInspector]
    public bool inCollision;
    private bool triggerStay;
    private Collider other;

    //public string NameTag;

    void OnDrawGizmos()
    {
        Color red = new Color(1, 0, 0, 0.2f);
        Color green = new Color(0, 1, 0, 0.2f);
        Gizmos.matrix = Matrix4x4.TRS(transform.position, transform.rotation, (transform.lossyScale));
        Gizmos.color = inCollision && Application.isPlaying ? red : green;
        Gizmos.DrawCube(Vector3.zero, Vector3.one);
    }

    void Start()
    {
        inCollision = false;
        gameObject.GetComponent<BoxCollider>().isTrigger = true;
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("T'es rentré");
        bool hasTag = false;
        foreach (string tag in tagsToDetect)
        {
            if (other.gameObject.CompareTag(tag))
            {
                hasTag = true;
                break;
            }
        }
        if (!hasTag)
            return;
        inCollision = true;
        this.other = other;
        onTriggerEnter.Invoke(other);
        if (AudioDebug)
            Debug.Log("Trigger Enter");

    }

    void OnTriggerExit(Collider other)
    {
        bool hasTag = false;
        foreach (string tag in tagsToDetect)
        {
            if (other.gameObject.CompareTag(tag))
            {
                hasTag = true;
                break;
            }
        }
        if (!hasTag)
            return;
        inCollision = false;
        this.other = null;
        onTriggerExit.Invoke(other);
        if (AudioDebug)
            Debug.Log("Trigger Exit");
    }
}
