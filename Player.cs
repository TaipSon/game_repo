using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    private Vector2 targetPos;
    public float Yincrement;

    public float speed;
    public float maxHeight;
    public float minHeight;

    public int health = 5;

    public GameObject effect;
    [SerializeField] private TMP_Text healthDisplay;
    public GameObject panel;
    public GameObject sound;

    private void Start()
    {
        Instantiate(sound, transform.position, Quaternion.identity);
    }
    private void Update()
    {
        healthDisplay.text = health.ToString();

        if (health <= 0)
        {
            panel.SetActive(true);
            Destroy(gameObject);
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);


    }
    public void OnUpButtonDown()
    {
        if (transform.position.y < maxHeight)
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
        }
    }
    public void OnDownButtonDown() 
    {
        if (transform.position.y > minHeight)
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
        }
    }
}
