using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Gamekit3D
{
    public class Bodyfall_Player : MonoBehaviour
    {
        void OnCollisionEnter(Collision other)
        {
            Debug.Log("BodyFall");
            AkSoundEngine.PostEvent("Play_Small_Monster_Bodyfall", this.gameObject);
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
}
