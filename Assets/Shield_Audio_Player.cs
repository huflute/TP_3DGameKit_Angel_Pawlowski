using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gamekit3D
{
    public class Shield_Audio_Player : MonoBehaviour
    {
        public void PlayShield()
        {
            AkSoundEngine.PostEvent("Play_MC_Shield", this.gameObject);
        }

        public void StopShield()
        {
            AkSoundEngine.PostEvent("Play_MC_Shield_Off", this.gameObject);
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