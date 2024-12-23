using UnityEngine;

public class KenAttKagune : MonoBehaviour
{
    
    public Animator KenAnimation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        KenAnimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.A))
        {
            PlayAnimAttKagune();
        }
    }
    public void PlayAnimAttKagune()
    {
        KenAnimation.SetTrigger("Attack");
        KenAnimation.SetTrigger("IdleBase");
    }
}   
