using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    [SerializeField] private float speed;

    private void OnEnable()
    {
        StartCoroutine(DisableBullet());
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * speed * Time.deltaTime;
    }

    IEnumerator DisableBullet()
    {
        yield return new WaitForSeconds(2f);
        gameObject.SetActive(false);
    }
}
