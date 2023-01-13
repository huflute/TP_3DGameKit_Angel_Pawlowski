using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WwiseEventManager : MonoBehaviour
{
    
    // WEAPON EVENTS
    public void WeaponPickUp ()
    {
        AkSoundEngine.PostEvent("Play_Weapon_Pickup", this.gameObject);
    }
    public void Whoosh_Weapon_Combo_01()
    {
        AkSoundEngine.PostEvent("Play_Weapon_Whoosh_Combo01", this.gameObject);
    }
    public void Whoosh_Weapon_Combo_02()
    {
        AkSoundEngine.PostEvent("Play_Weapon_Whoosh_Combo02", this.gameObject);
    }
    public void Whoosh_Weapon_Combo_03()
    {
        AkSoundEngine.PostEvent("Play_Weapon_Whoosh_Combo03", this.gameObject);
    }
    public void Whoosh_Weapon_Combo_04()
    {
        AkSoundEngine.PostEvent("Play_Weapon_Whoosh_Combo04", this.gameObject);
    }

    public void AttackFoley()
    {
        AkSoundEngine.PostEvent("Play_MC_FOL_Attack", this.gameObject);
    }

    public void Roll()
    {
        Debug.Log("Roulade");
        AkSoundEngine.PostEvent("Play_MC_Roll", this.gameObject);
    }
    //UI EVENTS

    public void Whoosh_Text_Appear ()
    {
        AkSoundEngine.PostEvent("Play_Whoosh_Text_Appear", this.gameObject);
    }

    public void Whoosh_Text_Disappear()
    {
        AkSoundEngine.PostEvent("Play_Whoosh_Text_Disappear", this.gameObject);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
