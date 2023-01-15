using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gamekit3D
{
    [RequireComponent(typeof(Collider))]
    public class DeathVolume : MonoBehaviour
    {
        public new AudioSource audio;


        void OnTriggerEnter(Collider other)
        {
            AkSoundEngine.PostEvent("Play_Water_Hit", this.gameObject);
            var pc = other.GetComponent<PlayerController>();
            if (pc != null)
            {
                //Debug.Log("Tu es mort");
                
                pc.Die(new Damageable.DamageMessage());
            }
            if (audio != null)
            {
                audio.transform.position = other.transform.position;
                if (!audio.isPlaying)
                {
                   
                    audio.Play();
                }
            }
        }

        void Reset()
        {
            if (LayerMask.LayerToName(gameObject.layer) == "Default")
                gameObject.layer = LayerMask.NameToLayer("Environment");
            var c = GetComponent<Collider>();
            if (c != null)
                c.isTrigger = true;
        }

    }
}
