using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gamekit3D
{
    public class Particles_Audio : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            AkSoundEngine.PostEvent("Play_Monster_Vanish", this.gameObject);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
