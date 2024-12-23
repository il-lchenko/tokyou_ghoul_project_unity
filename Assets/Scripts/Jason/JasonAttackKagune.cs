using System;
using UnityEngine;

public class JasonAttackKagune : MonoBehaviour
{
    public Animator AttackKagune;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AttackKagune = GetComponent<Animator>();
        if (AttackKagune == null)
        {
            Debug.LogError("Animator not found on the object");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            PlayAnimJasonAttKagune();
        }
    }
    public void PlayAnimJasonAttKagune()
    {
        AttackKagune.SetTrigger("AttKagune");
        AttackKagune.SetTrigger("IdleBase");
    }
}
