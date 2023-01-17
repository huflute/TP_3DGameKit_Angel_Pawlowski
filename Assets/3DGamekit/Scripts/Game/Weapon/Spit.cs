using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gamekit3D
{
    public class Spit : GrenadierGrenade
    {
        protected override void OnCollisionEnter(Collision other)
        {
            base.OnCollisionEnter(other);

            if (explosionTimer < 0)
                AkSoundEngine.PostEvent("Play_Spitball_Explode", this.gameObject);
                Explosion();
        }
    }
}