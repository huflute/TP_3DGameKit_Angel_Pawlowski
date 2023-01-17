using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gamekit3D
{
    public class UI_Audio_Player : MonoBehaviour
    {
        // Start is called before the first frame update
        public void PlayStart()
        {
            AkSoundEngine.PostEvent("Play_UI_Press_Play",this.gameObject);
            AkSoundEngine.PostEvent("Stop_All", this.gameObject);
        }

        public void Navigate()
        {
            AkSoundEngine.PostEvent("Play_UI_Navigate", this.gameObject);
        }

        public void PressButton()
        {
            AkSoundEngine.PostEvent("Play_UI_Press_Other", this.gameObject);
        }

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
