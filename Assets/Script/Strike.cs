using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strike : MonoBehaviour
{
    public Animator MyAnimator;
  
    void Start()
    {
        MyAnimator = gameObject.GetComponent<Animator>();
    }

    public void strike()
    {
        Debug.Log("Attacking");
        MyAnimator.SetTrigger("IsAttack");
    }


}
