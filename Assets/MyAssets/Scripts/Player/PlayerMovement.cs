using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{    
    public PlayerHealth playerHealth;
    public float turnSpeed = 60f;
    float idleTimer = 0.1f;
    float timer = 0.0f;
    public float walkSpeed = 1f;
    public float smoothFactor = 0.05f; 
    float walkLerp = 0.0f;
    Vector3 m_Movement;
    Quaternion m_Rotation = Quaternion.identity;
    Animator m_Animator;
    Rigidbody m_Rigidbody;
    AudioSource m_AudioSource;

    void Start()
    {
        m_Animator = GetComponent<Animator>();
        m_Rigidbody = GetComponent<Rigidbody>();
        m_AudioSource = GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        m_Movement.Set(horizontal, 0f, vertical);
        m_Movement.Normalize();
        
        bool hasHorizontalInput = !Mathf.Approximately(horizontal, 0f);
        bool hasVerticalInput = !Mathf.Approximately(vertical, 0f);
        bool isWalking = hasHorizontalInput || hasVerticalInput;
        
        bool shiftPressed = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);
        bool isRunning = isWalking && shiftPressed && (playerHealth.currentHealth > 50);
        WalkLerpUpdate(isRunning);
        
        if (!isWalking)
        {
            timer += Time.deltaTime;
            if (timer >= idleTimer)
                m_Animator.SetBool("IsWalking", false);
        }
        else
        {
            m_Animator.SetBool("IsWalking", true);
            timer = 0f;
        }
        
        if(isWalking)
        {
            if(!m_AudioSource.isPlaying)
                m_AudioSource.Play();
        }
        else
            m_AudioSource.Stop();
        
        Vector3 desiredForward = Vector3.RotateTowards(transform.forward, m_Movement, turnSpeed * Time.deltaTime, 0f);
        m_Rotation = Quaternion.LookRotation(desiredForward);
    }
    
    void WalkLerpUpdate(bool isRunning)
    {
        walkLerp = Mathf.Clamp01(walkLerp + (isRunning ? smoothFactor : -smoothFactor));
        walkSpeed = Mathf.Lerp(1.0f, 2.0f, walkLerp);
    }
    
    void OnAnimatorMove()
    {
        m_Rigidbody.MovePosition(m_Rigidbody.position + m_Movement * walkSpeed * m_Animator.deltaPosition.magnitude);
        m_Rigidbody.MoveRotation(m_Rotation);
    }
}
