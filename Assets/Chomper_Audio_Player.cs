using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gamekit3D
{
    public class Chomper_Audio_Player : MonoBehaviour
    {
        public void Attack()
        {
            AkSoundEngine.PostEvent("Play_Chomper_Attack", this.gameObject);
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
