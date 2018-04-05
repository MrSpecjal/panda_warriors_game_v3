using UnityEngine;

public class UnitsStats : MonoBehaviour
{
    public int health;
    public int damage;
    public int costInCrystals;
    public int costInScrap;
    public int costInAntimatter;
    public float spawnTime;
    public float speed;
    private bool isKilled;

    private void Update()
    {
        if (isKilled)//Jeżeli zabita
        {
            Destroy(gameObject);//Zniszcz
            //TODO:Spawnuj zezłomowaną wersje do wydobywania
        }
    }

    public void GiveDamage(int damage)
    {
        health -= damage;//zadaj obrażenia
        if(health <= 0)//jeśli hp < 0 
        {
            isKilled = true;//zabij
        }
        isKilled = false;
    }
}
