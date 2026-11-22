using UnityEngine;

public class PokeballController : MonoBehaviour
{
    private bool isCaptured = false;

    public void Throw(Vector3 force)
    {
        GetComponent<Rigidbody>().AddForce(force);
    }

    void OnCollisionEnter(Collision other)
    {
        if (isCaptured) return;

        // 偵測撞到 Tag 為 Pokemon 的物件
        if (other.gameObject.CompareTag("Pokemon"))
        {
            isCaptured = true;

            // 讓精靈球停在原地
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.linearVelocity = Vector3.zero;
            rb.isKinematic = true;

            // 播放收服粒子特效並隱藏寶可夢
            ParticleSystem ps = GetComponent<ParticleSystem>();
            if (ps != null) ps.Play();

            other.gameObject.SetActive(false);
        }
    }
}