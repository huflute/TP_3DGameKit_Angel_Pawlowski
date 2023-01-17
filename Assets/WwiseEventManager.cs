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


    // GRENADIER EVENTS

    public void Grenadier_Breath()
    {
        AkSoundEngine.PostEvent("Play_Grenadier_Breath", this.gameObject);
    }
    public void Grenadier_CloseRangeAttack()
    {
        AkSoundEngine.PostEvent("Play_Grenadier_CloseRangeAttack", this.gameObject);
    }
    public void Grenadier_Death()
    {
        AkSoundEngine.PostEvent("Play_Grenadier_Death", this.gameObject);
    }
    public void Grenadier_FT_Heavy()
    {
        AkSoundEngine.PostEvent("Play_Grenadier_FT_Heavy", this.gameObject);
    }
    public void Grenadier_FT_Normal()
    {
        AkSoundEngine.PostEvent("Play_Grenadier_FT_Normal", this.gameObject);
    }
    public void Grenadier_Hit()
    {
        AkSoundEngine.PostEvent("Play_Grenadier_Hit", this.gameObject);
    }
    public void Grenadier_MeleeAttack()
    {
        AkSoundEngine.PostEvent("Play_Grenadier_MeleeAttack", this.gameObject);
    }
    public void Grenadier_Movement_Fast()
    {
        AkSoundEngine.PostEvent("Play_Grenadier_Movement_Fast", this.gameObject);
    }
    public void Grenadier_Movement_Slow()
    {
        AkSoundEngine.PostEvent("Play_Grenadier_Movement_Slow", this.gameObject);
    }
    public void Grenadier_RangeAttack01()
    {
        AkSoundEngine.PostEvent("Play_Grenadier_RangeAttack01", this.gameObject);
    }
    public void Grenadier_RangeAttack02()
    {
        AkSoundEngine.PostEvent("Play_Grenadier_RangeAttack02", this.gameObject);
    }
    public void Grenadier_Shoot()
    {
        AkSoundEngine.PostEvent("Play_Grenadier_Shoot", this.gameObject);
    }

    // BOX EVENTS
    public void DestructBox()
    {
        AkSoundEngine.PostEvent("Play_Box_Break", this.gameObject);
    }

    // SMALL MONSTER
    public void SmallMonsterHit()
    {
        AkSoundEngine.PostEvent("Play_Small_Monster_Hit", this.gameObject);
    }

    // CHANGING LEVELS

    public void LevelChange()
    {
        AkSoundEngine.PostEvent("Stop_All", this.gameObject);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
