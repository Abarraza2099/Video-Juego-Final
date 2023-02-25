using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator playerAnim;
    public Rigidbody playerRigid;
    public float run, wb_speed;
    public bool running;
    public Transform playerTrans;
    public float RotationSpeed = 1.0f;
    public float JumpForce = 1.0f;
    public float TimePose = 4.0f;
    public float TimingPose = 0.0f;
    public bool ActivePose = true;
    
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            playerRigid.velocity = transform.forward * run * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerRigid.velocity = -transform.forward * wb_speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            playerRigid.AddForce(new Vector3(0, JumpForce, 0), ForceMode.Impulse);

        }

        float rotationY = Input.GetAxis("Mouse X");
        float rot = rotationY * Time.deltaTime * RotationSpeed;
        transform.Rotate(new Vector3(0, rot, 0));
        
    }


    // Update is called once per frame
    void Update()
    {
        if (ActivePose)
        {
            TimingPose += Time.deltaTime;
        }
        if (TimingPose > TimePose && ActivePose)
        {
            TimingPose = 0;
            playerAnim.SetBool("Pose", true);
            ActivePose = false;

        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            playerAnim.SetBool("Running",true);
            playerAnim.SetBool("Standing idle",false);
            playerAnim.SetBool("Pose",false);
            running = true;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            playerAnim.SetBool("Running",false);
            playerAnim.SetBool("Standing idle",true);
            ActivePose = true;
            TimingPose = 0;
            running = false;
        }
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerAnim.SetBool("Jumping", true);
            playerAnim.SetBool("Pose", false);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            playerAnim.SetBool("Jumping", false);
            ActivePose = true;
            TimingPose = 0;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            playerAnim.SetBool("Backwards", true);
            playerAnim.SetBool("Pose", false);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            playerAnim.SetBool("Backwards", false);
            playerAnim.SetBool("Standing Idle", true);
            ActivePose = true;
            TimingPose = 0;
        }
    }
}
