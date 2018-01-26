using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {

    private NavMeshAgent agent;
    private Transform player;//先获取到主角，因为之后需要获得主角的位置
    private Animator anim;
    void Awake()
    {
        agent = this.GetComponent<NavMeshAgent>();
        anim = this.GetComponent<Animator>();
    }


	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag(Tags.player).transform;//通过标签获取主角的位置
	}
	
	// Update is called once per frame
	void Update () {

        if (Vector3.Distance(transform.position, player.position) < 1.2f)
        {
            agent.Stop();
            anim.SetBool("Move", false);
        }
        else 
        {
            agent.SetDestination(player.position);
            anim.SetBool("Move", true);
        }
        
	}
}
