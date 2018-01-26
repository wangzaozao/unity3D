using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

    public float hp = 100;
    private Animator anim;
    private NavMeshAgent agent;
    private EnemyMove move;
    private CapsuleCollider capsuleCollider;
    public AudioClip dealthClip;
    private ParticleSystem particleSystem;
    private EnemyAttack enemyAttack;

    void Awake()
    {
        anim = this.GetComponent<Animator>();
        agent = this.GetComponent<NavMeshAgent>();
        move = this.GetComponent<EnemyMove>();
        capsuleCollider = this.GetComponent<CapsuleCollider>();
        particleSystem = this.GetComponentInChildren<ParticleSystem>();
        enemyAttack = this.GetComponentInChildren<EnemyAttack>();
    }

    public void TakeDamage(float damage,Vector3 hitPoint)
    {
        if (this.hp <= 0) return;
        GetComponent<AudioSource>().Play();
        particleSystem.transform.position = hitPoint;
        particleSystem.Play();
        this.hp -= damage;
        if (this.hp <= 0)
        {
            Dead();
        }
    }

    //用这个方法来处理敌人死亡后的后事
    void Dead()
    {
        anim.SetBool("Dead", true);
        agent.enabled = false;
        move.enabled = false;
        capsuleCollider.enabled = false;
        AudioSource.PlayClipAtPoint(dealthClip, transform.position, 1);
        enemyAttack.enabled = false;

    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (this.hp <= 0)
        {
            transform.Translate(Vector3.down * Time.deltaTime * 0.5f);
            if (transform.position.y <= -5 )
            {
                Destroy(this.gameObject);
            }
        }
	}
}
