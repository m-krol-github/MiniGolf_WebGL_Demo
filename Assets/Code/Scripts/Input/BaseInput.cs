using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseInput : MonoBehaviour
{
    
    public bool shoot;
    protected Inputs inputs;


    public virtual void OnEnable()
    {
        inputs = new Inputs();
        inputs.Enable();
    }

    public virtual void Awake()
    {
        
    }

    public virtual void OnDisable()
    {
        inputs.Disable();
    }
}
