using UnityEngine;

public class TrocaAnimacao : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            anim.Play("Reza"); 
        if (Input.GetKeyDown(KeyCode.Alpha2))
            anim.Play("Rebolada");  
        if (Input.GetKeyDown(KeyCode.Alpha3))
            anim.Play("Pulo");  
    }
}

