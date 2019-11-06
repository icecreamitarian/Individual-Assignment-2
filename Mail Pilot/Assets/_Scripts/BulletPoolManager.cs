using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: Bonus - make this class a Singleton!
// Josh: create something (list, array, queue, stack any other structure you want) to store around 50 bullets

[System.Serializable]
public class BulletPoolManager : MonoBehaviour
{
    public GameObject bullet;

    //TODO: create a structure to contain a collection of bullets
    ArrayList objectPoolList = new ArrayList();
    //public myQueue = new Queue<bullet>();

    // Start is called before the first frame update
    void Start()
    {
        // TODO: add a series of bullets to the Bullet Pool (for, while loop)
        while (objectPoolList.Count <= 50)
        {
            objectPoolList.Add(bullet);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //TODO: modify this function to return a bullet from the Pool
    public GameObject GetBullet()
    {
        return bullet;
    }

    //TODO: modify this function to reset/return a bullet back to the Pool (dont reference bullet prefab?) (could reset it off screen, or activate or deactivate it)
    public void ResetBullet(GameObject bullet)
    {
        //for (int i = 0; i < objectPool.Length; i++)
        //{
        //    // if bullet goes above the screen, set it beside the screen in the pool
        //    //objectPool[i].setPosition();
        //}
    }
}