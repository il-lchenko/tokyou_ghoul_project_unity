using UnityEngine;

public class JasonRun : MonoBehaviour
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
        if (Input.GetKey(KeyCode.W))
        {
            PlayAnimJasonRunOn();
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            PlayAnimJasonRunOff();
        }
    }

    public void PlayAnimJasonRunOn()
    {
        AttackKagune.SetTrigger("Run");
    }

    public void PlayAnimJasonRunOff()
    {
        AttackKagune.ResetTrigger("Run");
        AttackKagune.SetTrigger("IdleBase");
    }
}
