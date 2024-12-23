using UnityEngine;

public class KenJumpBack : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Animator KenAnimation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        KenAnimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            PlayAnimation();
        }
    }

    public void PlayAnimation()
    {
        KenAnimation.SetTrigger("JumpBack");
        KenAnimation.SetTrigger("IdleBase");
    }
}
