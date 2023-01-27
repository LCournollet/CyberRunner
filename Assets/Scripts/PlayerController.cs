using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public TMP_Text LevelText;
    private CharacterController characterController;
    public  Animator animator;
    public GameObject bulletPrefab;
    public Transform firePoint;

    private float horizontal;

    public int playerLevel;
    public int playerHP = 100;
    public float playerSpeed = 13f;
    public float jumpingPower = 22f;
    private bool isFacingRight = true;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    // Start is called before the first frame update
    void Awake()
    {

        characterController = GetComponent<CharacterController>();
        playerLevel = Random.Range(1, 20);
        Enemy.GlobalLevel = playerLevel;
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.y == 0)
        {
            animator.SetBool ("IsJumping", false);
        }

        horizontal = Input.GetAxisRaw("Horizontal");

        animator.SetFloat("Speed", Mathf.Abs(horizontal));

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
            animator.SetBool("IsJumping", true);
        }

        if (Input.GetButtonDown("Fire1") && IsGrounded())
        {
            animator.SetBool("Shoot", true);
            Shoot();
        }
        // if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        // {
        //     rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        // }
        Flip();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * playerSpeed, rb.velocity.y);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
            firePoint.transform.Rotate(0, 180, 0);
        }
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
