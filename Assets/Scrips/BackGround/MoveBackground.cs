using UnityEngine;

public class MoveBackground : MonoBehaviour
{
	public float speed;
	private float x;
	public float PontoDeDestino;
	public float PontoOriginal;

	void Update () 
	{
		MoveGround();
        if (PlayerStat.instance != null)
        {
            if (PlayerStat.instance.Health == 0)
            {
                speed = 0;
            }
        }
    }
	void MoveGround()
	{
        x = transform.position.x;
        x += speed * Time.deltaTime;
        transform.position = new Vector3(x, transform.position.y, transform.position.z);

        if (x <= PontoDeDestino)
        {
            x = PontoOriginal;
            transform.position = new Vector3(x, transform.position.y, transform.position.z);
        }
    }
}
