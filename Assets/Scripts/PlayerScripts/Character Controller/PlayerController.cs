using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D Character;
    [SerializeField] public Collider2D Standing;
    [SerializeField] public Collider2D Crouching;
    [SerializeField] public Collider2D GC;
    [SerializeField] public float _Speed;
    [SerializeField] public float _SCap;
    [SerializeField] public float _CSpeed;
    [SerializeField] public float _Direction;
    [SerializeField] public float _BuildUp;
    [SerializeField] public float _BuildUpA;
    [SerializeField] public float _RBuildUp;
    [SerializeField] public float _RBuildUpA;
    [SerializeField] public float _JForce;
    [SerializeField] public bool _IsCrouching;
    [SerializeField] public float _Limiter;
    [SerializeField] public bool _Ceiling;
<<<<<<< .mine
    public Animator animator;
||||||| .r95
=======
    [SerializeField] public bool _IsJumping;
>>>>>>> .r105


    void Start()
    {
        Character = gameObject.GetComponent<Rigidbody2D>();
        GC = gameObject.GetComponent<Collider2D>();
        Standing.isTrigger = false;
        Crouching.isTrigger = true;
    }


    void Update()
    {
        _Direction = Input.GetAxisRaw("Horizontal");
        Vector2 vel = Character.velocity;

        animator.SetFloat("Speed", Mathf.Abs(_Direction));
        animator.SetBool("_IsJumping", _IsJumping);
        animator.SetFloat("Vspeed", vel.y);
        
        
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !_IsJumping)
        {
            Character.AddForce(new Vector2(0f, _JForce), ForceMode2D.Impulse);
        }
        //Jump $

        if (Input.GetKey(KeyCode.S))
        {
            _IsCrouching = true;
        }
        else
        {
            _IsCrouching = false;
        }
        //Crouch Detection $

        if (_IsCrouching)
        {
            Standing.isTrigger = true;
            Crouching.isTrigger = false;
        }
        else
        {
            Standing.isTrigger = false;
            Crouching.isTrigger = true;
        }
        //Crouch Deformation 

        if (Input.GetKey(KeyCode.D) && _BuildUp < _SCap / 2 || Input.GetKey(KeyCode.RightArrow) && _BuildUp < _SCap / 2)
        {
            _BuildUp = _BuildUpA + _BuildUp;
        }
        if(Input.GetKey(KeyCode.A) && _BuildUp > -_SCap / 2 || Input.GetKey(KeyCode.LeftArrow) && _BuildUp < _SCap / 2)
        {
            _BuildUp = _BuildUp -_BuildUpA;
        }
        //Build up for walking
        
        if(Input.GetKey(KeyCode.D) && (Input.GetKey(KeyCode.LeftShift)) && _RBuildUp < _SCap / 1.5 || Input.GetKey(KeyCode.RightArrow) && (Input.GetKey(KeyCode.LeftShift)) && _RBuildUp < _SCap / 1.5)
        {
            _RBuildUp = 0.75f + _RBuildUp;
        }
        if(Input.GetKey(KeyCode.A) && (Input.GetKey(KeyCode.LeftShift)) && _RBuildUp > -_SCap / 1.5 || Input.GetKey(KeyCode.RightArrow) && (Input.GetKey(KeyCode.LeftShift)) && _RBuildUp < _SCap / 1.5)
        {
            _RBuildUp = _RBuildUp -0.75f;
        }
        //Build up for running

        if(_Direction > 0.1f && _IsCrouching || _Direction < -0.1f && _IsCrouching)
        {
            Character.AddForce(new Vector2(_Speed * _Direction * _CSpeed * _Limiter + _BuildUp * _Limiter *_CSpeed, 0f), ForceMode2D.Impulse);
        }
        //Direction Calculations for crouching (sorry computer, you have a lot of work to do because of me :( )

        if(_Direction > 0.1f && !_IsCrouching || _Direction < -0.1f && !_IsCrouching)
        {
            Character.AddForce(new Vector2(_Speed * _Direction * _Limiter + _BuildUp * _Limiter * 1.5f + _RBuildUp * _Limiter, 0f), ForceMode2D.Impulse);
        }
        //Direction Calculations (sorry computer, you have a lot of work to do because of me :( )
        
        if(!Input.GetKey(KeyCode.D) && _BuildUp > 0)
        {
            _BuildUp = _BuildUp - 0.5f;
        }
        if(!Input.GetKey(KeyCode.A) && _BuildUp < 0)
        {
            _BuildUp = _BuildUp + 0.5f;
        }
        //Build down for walking

        if(!Input.GetKey(KeyCode.LeftShift) && _RBuildUp > 0)
        {
            _RBuildUp = _RBuildUp - 0.75f;
        }
        if(!Input.GetKey(KeyCode.LeftShift) && _RBuildUp < 0)
        {
            _RBuildUp = _RBuildUp + 0.75f;
        }
        //Build down for running
<<<<<<< .mine
        
        if(GroundChecker.IsTouching(Tilemap))
||||||| .r95
    }
    
    void OnTriggerEnter2D(Collider2D GroundChecker)
    {
        if(GroundChecker.gameObject.tag == "Ground")
=======
    }

    void OnTriggerEnter2D(Collider2D GC)
    {
        if (GC.gameObject.tag == "Ground")
>>>>>>> .r105
        {
            _IsJumping = false;
<<<<<<< .mine
            Debug.Log("on ground");
||||||| .r95
=======
            Debug.Log(false);
>>>>>>> .r105
        }
<<<<<<< .mine
        else
||||||| .r95
        //The character is on ground.
    }
    void OnTriggerExit2D(Collider2D GroundChecker)
    {
        if(GroundChecker.gameObject.tag == "Ground")
=======
    }
    void OnTriggerExit2D(Collider2D GC)
    {
        if (GC.gameObject.tag == "Ground")
>>>>>>> .r105
        {
            _IsJumping = true;
<<<<<<< .mine
            Debug.Log("not on ground");
||||||| .r95
=======
            Debug.Log(true);
>>>>>>> .r105
        }
<<<<<<< .mine
        //The character is on or not on ground.
||||||| .r95
        //The character is not on ground.
=======
>>>>>>> .r105
    }
<<<<<<< .mine
    

    
||||||| .r95
=======

>>>>>>> .r105
}
