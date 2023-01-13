using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Gamekit3D
{
    public class Chomper_Audio_Player : MonoBehaviour
    {
        public void Run()
        {
            AkSoundEngine.PostEvent("Play_Small_Monster_Run", this.gameObject);
        }
        public void Walk()
        {
            AkSoundEngine.PostEvent("Play_Small_Monster_Walk", this.gameObject);
        }
        public void GruntBeforeAttack()
        {
            AkSoundEngine.PostEvent("Play_Chomper_VOX_Before_Attack", this.gameObject);
        }
        public void Attack()
        {
            AkSoundEngine.PostEvent("Play_Chomper_Attack", this.gameObject);
        }

        public void Bodyfall()
        {
            AkSoundEngine.PostEvent("Plays_monster_Bodyfall", this.gameObject);
        }

        public void Hit()
        {
            AkSoundEngine.PostEvent("Play_Small_Monster_Hit", this.gameObject);
            AkSoundEngine.PostEvent("Play_Small_Monster_VOX_Hit", this.gameObject);
        }

        public void Spin()
        {
            AkSoundEngine.PostEvent("Play_Small_Monster_Spin", this.gameObject);
        }

        public void Death()
        {
            AkSoundEngine.PostEvent("Play_Small_Monster_VOX_Death", this.gameObject);
        }

        public void Grunt()
        {
            AkSoundEngine.PostEvent("Play_Small_Monster_VOX_Grunt", this.gameObject);
        }

        public void Spots()
        {
            AkSoundEngine.PostEvent("Play_Small_Monster_VOX_Spots", this.gameObject);
        }
        // Start is called before the first frame update
        void Start()
        {
            AkSoundEngine.SetSwitch("Small_Monster", "Chomper", this.gameObject);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
