using UnityEngine;

public class JasonBackJump : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.M))
        {
            PlayAnimJasonBackJump();
        }
    }

    public void PlayAnimJasonBackJump()
    {
        AttackKagune.SetTrigger("BackJump");
        AttackKagune.SetTrigger("IdleBase");
    }
}
