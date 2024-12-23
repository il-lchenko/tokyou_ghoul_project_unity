using UnityEngine;
using UnityEngine.EventSystems;

public class KenRun : MonoBehaviour
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
        if (Input.GetKey(KeyCode.R))
        {
            PlayRunKenOn();
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            PlayRunKenOff();
        }
    }
    public void PlayRunKenOn()
    {
        KenAnimation.SetTrigger("Run");
    }

    public void PlayRunKenOff()
    {
        KenAnimation.ResetTrigger("Run");
        KenAnimation.SetTrigger("IdleBase");
        
    }
}
