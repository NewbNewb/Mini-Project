using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    private GameObject _player;
    private Animator _animator;
    public float speed;

    private void Start()
    {
        float x = 10f;
        float y = -4f;
        transform.position = new Vector3(x, y, 0);
        _player = GameObject.FindWithTag("Player");
        if (_player != null )
        {
            _animator = _player.GetComponentInChildren<Animator>();
        }
    }

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if(transform.position.x < -15)
        {
            Destroy(gameObject);
        }
        if(PlayerStat.instance != null)
        {
            if (PlayerStat.instance.Health == 0)
            {
                speed = 0;
            }
        }
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Attack")
        {
            
            Destroy(gameObject);
            Debug.Log("때렸다");


        }
        if (coll.gameObject.tag == "Player")
        {
            Hurt(1);
            _animator.SetTrigger("isHurt");
            Debug.Log("맞았다");
        }
    }
    public void Hurt(int dmg)
    {
        PlayerStat.instance.TakeDamage(dmg);
    }
}
