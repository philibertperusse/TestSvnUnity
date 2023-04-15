using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D Character;
    [SerializeField] public float _Speed;
    [SerializeField] public float _SCap;
    [SerializeField] public float _CSpeed;
    [SerializeField] public float _Direction;
    [SerializeField] public float _BuildUp;
    [SerializeField] public float _RBuildUp;
    [SerializeField] public float _JForce;
    [SerializeField] public bool _IsJumping;
    [SerializeField] public float _Limiter;

    

    void Start()
    {
        Character = gameObject.GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        _Direction = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Space) && !_IsJumping)
        {
            Character.AddForce(new Vector2(0f, _JForce), ForceMode2D.Impulse);
        }
        //Jump
        if(Input.GetKey(KeyCode.D) && _BuildUp < _SCap / 2)
        {
            _BuildUp = 0.5f + _BuildUp;
        }
        if(Input.GetKey(KeyCode.A) && _BuildUp > -_SCap / 2)
        {
            _BuildUp = _BuildUp -0.5f;
        }
        //Build up for walking
        
        if(Input.GetKey(KeyCode.D) && (Input.GetKey(KeyCode.LeftShift)) && _RBuildUp < _SCap / 1.5)
        {
            _RBuildUp = 0.75f + _RBuildUp;
        }
        if(Input.GetKey(KeyCode.A) && (Input.GetKey(KeyCode.LeftShift)) && _RBuildUp > -_SCap / 1.5)
        {
            _RBuildUp = _RBuildUp -0.75f;
        }
        //Build up for running

        if(_Direction > 0.1f)
        {
            Character.AddForce(new Vector2(_Speed * _Direction * _CSpeed * _Limiter + _BuildUp * _Limiter * 1.5f + _RBuildUp * _Limiter, 0f), ForceMode2D.Impulse);
        }
        if(_Direction < -0.1f)
        {
            Character.AddForce(new Vector2(_Speed * _Direction * _CSpeed * _Limiter + _BuildUp * _Limiter * 1.5f + _RBuildUp * _Limiter, 0f), ForceMode2D.Impulse);
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
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            _IsJumping = false;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            _IsJumping = true;
        }
    }
        

}
