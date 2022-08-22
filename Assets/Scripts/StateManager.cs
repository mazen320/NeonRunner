using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    public string state;
    public MapSpawner map;
    public Movement movement;
    public Score score;
    public SpriteRenderer sprite;
    public ParticleSystem ps;
    public SoundManager sound;
    public Menu menu;
    public AdManager ad;
    public int adwait;

    // Start is called before the first frame update
    void Start()
    {
        state = "Idle";
        movement.ResetGravity(0);
    }

    void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.CompareTag("Obstacle"))
        {
            Die();
        }
    }
    public void Die()
    {
        state = "Dead";
        movement.ResetGravity(0);
        score.End();
        sprite.enabled = false;
        ps.Play();
        sound.PlayDie();
        StartCoroutine(Delay());
    }
    public void Respawn()
    {
        menu.ChangeMenu(true);
        transform.position = new Vector3(-7.5f, -2.5f, 0);
    }

    public void StartGame()
    {
        state = "Playing";
        movement.ResetGravity(3);
        map.ClearStorage();
        sprite.enabled = true;
        menu.ChangeMenu(false);
    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(1);
        Respawn();
        adwait += 1;
        if(adwait >= 3)
        {
            adwait = 0;
            ad.ShowAd();
        }
    }
}
