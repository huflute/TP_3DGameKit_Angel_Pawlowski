using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Gamekit3D.GameCommands
{
    public abstract class SimpleTransformer : GameCommandHandler
    {
        public enum LoopType
        {
            Once,
            PingPong,
            Repeat
        }

        public LoopType loopType;

        public float duration = 1;
        public AnimationCurve accelCurve;

        public bool activate = false;
        public SendGameCommand OnStartCommand, OnStopCommand;

        public AudioSource onStartAudio, onEndAudio;
        public AK.Wwise.Event onStartEvent, onEndEvent;
        public AK.Wwise.Event Jingle;
        public AK.Wwise.State DiscoveryOn;
        public AK.Wwise.State DiscoveryOff;

        [Range(0, 1)]
        public float previewPosition;
        float time = 0f;
        public float position = 0f;
        float direction = 1f;

        protected Platform m_Platform;

        [ContextMenu("Test Start Audio")]
        void TestPlayAudio()
        {
            if (onStartAudio != null) onStartAudio.Play();
            
        }

        protected override void Awake()
        {
            base.Awake();

            m_Platform = GetComponentInChildren<Platform>();
        }

        public override void PerformInteraction()
        {
            
            activate = true;
            if (OnStartCommand != null) OnStartCommand.Send();
            if (onStartAudio != null) onStartAudio.Play();
            if (Jingle !=null) Jingle.Post(this.gameObject);
          
                if (onStartEvent != null) onStartEvent.Post(this.gameObject);
                StartCoroutine(DoorOpening(duration));
               
            
        }

       
        public void FixedUpdate()
        {
            if (activate)
            {
                time = time + (direction * Time.deltaTime / duration);
                switch (loopType)
                {
                    case LoopType.Once:
                        LoopOnce();
                        break;
                    case LoopType.PingPong:
                        LoopPingPong();
                        break;
                    case LoopType.Repeat:
                        LoopRepeat();
                        break;
                }
                PerformTransform(position);
            }
        }

        public virtual void PerformTransform(float position)
        {
           // if (gameObject.CompareTag("Platform")) 
               // StartCoroutine(MovingPlatform(duration));
        }

        void LoopPingPong()
        {
            position = Mathf.PingPong(time, 1f);
        }

        void LoopRepeat()
        {
            position = Mathf.Repeat(time, 1f);
        }

        void LoopOnce()
        {
            position = Mathf.Clamp01(time);
            if (position >= 1)
            {
                enabled = false;
                if (OnStopCommand != null) OnStopCommand.Send();
              
                
                direction *= -1;
            }
        }
        IEnumerator DoorOpening(float duration)
        {
            
            yield return new WaitForSeconds(duration);
            onEndEvent.Post(this.gameObject);
            DiscoveryOff.SetValue();

            
        }
        /*IEnumerator MovingPlatform(float duration)
        {
            if (onStartEvent != null) onStartEvent.Post(this.gameObject);
            yield return new WaitForSeconds(duration);
            if (onEndEvent != null) onEndEvent.Post(this.gameObject);
        }*/
    }
}
