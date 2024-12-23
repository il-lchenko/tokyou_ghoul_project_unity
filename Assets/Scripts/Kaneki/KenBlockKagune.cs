using UnityEngine;

public class KenBlockKagune : MonoBehaviour
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
         if (Input.GetKeyDown(KeyCode.B))
        {
            PlayAnimKenBlock();
        }
    }
    
    public void PlayAnimKenBlock()
    {
        KenAnimation.SetTrigger("Block Kagune");
        KenAnimation.SetTrigger("IdleBase");
    }
}
