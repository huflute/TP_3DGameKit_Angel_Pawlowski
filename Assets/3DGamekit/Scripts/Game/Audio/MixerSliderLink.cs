using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

namespace Gamekit3D
{
    [RequireComponent(typeof(Slider))]
    public class MixerSliderLink : MonoBehaviour
    {
        //public AudioMixer _mixer;
        //public string mixerParameter;
        public AK.Wwise.RTPC mixer;

        private float maxAttenuation = 100f;
        private float minAttenuation = 0.0f;

        protected Slider m_Slider;


        void Awake ()
        {
            m_Slider = GetComponent<Slider>();

            float value;
            value = mixer.GetGlobalValue();
            //_mixer.GetFloat(mixerParameter, out value);

            m_Slider.value = (value - minAttenuation) / (maxAttenuation - minAttenuation);

            m_Slider.onValueChanged.AddListener(SliderValueChange);
        }


        void SliderValueChange(float value)
        {
            mixer.SetGlobalValue(minAttenuation + value * (maxAttenuation - minAttenuation));
           // _mixer.SetFloat(mixerParameter, minAttenuation + value * (maxAttenuation - minAttenuation));
        }
    }
}