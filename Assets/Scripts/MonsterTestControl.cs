using Assets.FantasyMonsters.Common.Scripts;
using UnityEngine;

public class MonsterTestControl : MonoBehaviour
{
    float _speed = 1.0f;
    float _dir = 0;
    Monster monster;
    Animator animator;
    private void Awake()
    {
        monster = GetComponent<Monster>();
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
            monster.SetState(MonsterState.Walk);
        }
        else monster.SetState(MonsterState.Idle);
        transform.Translate(Vector3.right * _dir * _speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!animator.GetBool("Action"))
                monster.Attack();
        }


    }
}
