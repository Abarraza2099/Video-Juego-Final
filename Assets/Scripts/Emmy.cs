using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emmy : MonoBehaviour
{
    public Animator playerAnim;
    public bool walking;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            playerAnim.SetTrigger("Pose");
            playerAnim.ResetTrigger("Runnning");
            walking = true;
        }
        if (Input.GetKeyUp(KeyCode.T))
        {
            playerAnim.ResetTrigger("Running");
            playerAnim.SetTrigger("Pose");
            walking = false;
        }

    }
}
