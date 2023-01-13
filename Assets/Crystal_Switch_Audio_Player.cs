using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gamekit3D
{
    public class Crystal_Switch_Audio_Player : MonoBehaviour
    {
        
        public void Activation()
        {
            AkSoundEngine.PostEvent("Play_Switch_Crystals_Activation", this.gameObject);
            
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

