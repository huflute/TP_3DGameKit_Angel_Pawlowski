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
            AkSoundEngine.PostEvent("Play_UI_Press_Play", null);
        }

        public void Navigate()
        {
            AkSoundEngine.PostEvent("Play_UI_Navigate", null);
        }

        public void PressButton()
        {
            AkSoundEngine.PostEvent("Play_Press_Other", null);
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
