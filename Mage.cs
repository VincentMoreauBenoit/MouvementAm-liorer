using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Personnage
{

    public Mage() : base(2, 4, 5)
    {
        
    }

  

    public void Update()
    {
       
        bouger(speed,deplacement);
    }
}
