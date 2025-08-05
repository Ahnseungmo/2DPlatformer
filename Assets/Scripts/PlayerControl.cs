using Assets.FantasyMonsters.Common.Scripts;
using Assets.HeroEditor.Common.Scripts.CharacterScripts;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    float _speed = 1.0f;
    float _dir = 0;

    Animator animator;

    Character character;
    private void Awake()
    {
        character = GetComponent<Character>();
        animator = GetComponent<Animator>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _dir = 0;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _dir += -1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _dir += 1;
        }

        if (_dir != 0)
        {
            character.SetState(CharacterState.Walk);
        }
        else character.SetState(CharacterState.Idle);
        transform.Translate(Vector3.right * _dir * _speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //            if (!animator.GetBool("Action"))
            //                character.
//            animator.SetTrigger("Attack");
            character.Slash();
        }


    }
}
