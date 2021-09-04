using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   private void Heal()
    {
        SliderHeal.instanse.Heal();
        SliderHeal.instanse.ChangeHealth();
    }
    
    private void Damage()
    {
        SliderHeal.instanse.TakeDamege();
        SliderHeal.instanse.ChangeHealth();
    }
}
