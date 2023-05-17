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
    [SerializeField] public bool _IsJumping;


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
    }

    void OnTriggerEnter2D(Collider2D GC)
    {
        if (GC.gameObject.tag == "Ground")
        {
            _IsJumping = false;
            Debug.Log(false);
        }
    }
    void OnTriggerExit2D(Collider2D GC)
    {
        if (GC.gameObject.tag == "Ground")
        {
            _IsJumping = true;
            Debug.Log(true);
        }
    }

}
