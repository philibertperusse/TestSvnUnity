using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D Character;
    [SerializeField] public Collider2D Standing;
    [SerializeField] public Collider2D Crouching;
    [SerializeField] public Collider2D GroundChecker;
    [SerializeField] public Collider2D Tilemap;
    [SerializeField] public float _Speed;
    [SerializeField] public float _SCap;
    [SerializeField] public float _CSpeed;
    public float _CSpeedCalc;
    [SerializeField] public float _Direction;
    [SerializeField] public float _BuildUp;
    [SerializeField] public float _RBuildUpCalc;
    [SerializeField] public float _BuildUpA;
    [SerializeField] public float _RBuildUpA;
    [SerializeField] public float _JForce;
    [SerializeField] public bool _IsJumping;
    [SerializeField] public bool _IsCrouching;
    [SerializeField] public float _Limiter;
    [SerializeField] public bool _Ceiling;
    public Animator anim;



    void Start()
    {
        Rigidbody2D Character = GetComponent<Rigidbody2D>();
        Standing.isTrigger = false;
        Crouching.isTrigger = true;
    }


    void Update()
    {
        _Direction = Input.GetAxisRaw("Horizontal");
        Vector2 vel = Character.velocity;

        anim.SetFloat("Vspeed", vel.y);
        anim.SetFloat("Speed", vel.x);
        anim.SetBool("_IsJumping", _IsJumping);
        anim.SetBool("_IsCrouching", _IsCrouching);

        //Character.velocity = Vector2.ClampMagnitude( new Vector2 (_SCap, Character.velocity));

    }

    void FixedUpdate()
    {
        if (Character.velocity.x > _SCap)
        {
            Character.velocity = new Vector2(_SCap, Character.velocity.y);
        }

        if (Input.GetKey(KeyCode.Space) && !_IsJumping)
        {
            Character.AddForce(new Vector2(0f, _JForce), ForceMode2D.Impulse);
        }
        //Jump

        if (Input.GetKey(KeyCode.S))
        {
            _IsCrouching = true;
        }
        else
        {
            _IsCrouching = false;
        }
        //Crouch Detection (& speed calculation)

        if (_IsCrouching)
        {
            Standing.isTrigger = true;
            Crouching.isTrigger = false;
            _CSpeedCalc = _CSpeed;
        }
        else
        {
            Standing.isTrigger = false;
            Crouching.isTrigger = true;
            _CSpeedCalc = 1f;
        }
        //Crouch Deformation 

        if(Input.GetKey(KeyCode.LeftShift))
        {
            _RBuildUpCalc = _RBuildUpA;
        }
        else
        {
            _RBuildUpCalc = 1f;
        }
        //Run Detection

        if (_Direction > 0f && _BuildUp < _SCap|| _Direction < 0f && _BuildUp > -_SCap)
        {
            _BuildUp = _BuildUpA * _Direction + _RBuildUpCalc * _Direction + _BuildUp;
        }  
        //Build up for movement (walking and running)

        if(_Direction > 0f || _Direction < 0f)
        {
            Character.AddForce(new Vector2(_Speed * _CSpeedCalc * _BuildUp * _Limiter, 0f), ForceMode2D.Impulse);
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
        
        if(GroundChecker.IsTouching(Tilemap))
        {
            _IsJumping = false;
            Debug.Log("on ground");
            _Limiter = 1f;
        }
        else
        {
            _IsJumping = true;
            Debug.Log("not on ground");
            _Limiter = 0.75f;
        }
        //The character is on or not on ground.
        
        if (Standing.IsTouching(Tilemap))
        {
            _Ceiling = true;
            Debug.Log("is touching");
        }
        else
        {
            _Ceiling = false;
            Debug.Log("is not touching");
        }
    }
    

    
}
