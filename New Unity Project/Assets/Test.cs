using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    // Use this for initialization



   // void SayHello()
    //{
    //    Debug.Log("Hello");
   // }

    //void Callname(string name)
    //{
    //    Debug.Log("Hello" + name);
    //}
    
    //int Add(int a, int b)
    //{
    //    int c = a + b;
    //    return c;
    //}

        public class Player
    {

        private int hp = 100;
        private int power = 50;

        public void Attack()
        {
            Debug.Log(this.power + "のダメージを与えた");
        }

        public void Damage(int damage)
        {
            this.hp -= damage;
            Debug.Log(damage + "のダメージを受けた");
        }
    }
    void Start () {
        //Helo,Worldをコンソールウィンドウに表示する
        //Debug.Log("Hello,World");
        //float height1 = 160.5f;
        //float height2;
        //height2 = height1;
        //Debug.Log(height2);
        //int answer;
        //answer = 1 + 2;
        //Debug.Log(answer);

        //int[] points = { 83, 99, 52, 93, 15 };

        //for(int i =0; i < points.Length; i++)
        //{
        //  if (points[i] >= 90)
        // {
        //      Debug.Log(points[i]);
        //  }
        //}

        //SayHello();

        //Callname("Tom");

        //int answer;
        //answer = Add(2, 3);
        //Debug.Log(answer);  ここまで３回までの内容とメソッドについて

        //ここから４回目の内容
        Player myPlayer = new Player();
        myPlayer.Attack();
        myPlayer.Damage(30);

        Vector2 playerPos = new Vector2(3.0f, 4.0f);
        playerPos.x += 8.0f;
        playerPos.y += 5.0f;
        Debug.Log(playerPos);

        Vector2 startPos = new Vector2(2.0f, 1.0f);
        Vector2 endPos = new Vector2(8.0f, 5.0f);
        Vector2 dir = endPos - startPos;
        Debug.Log(dir);

        float len = dir.magnitude;
        Debug.Log(len);
    }


    // Update is called once per frame
    void Update () {
		
	}
}
