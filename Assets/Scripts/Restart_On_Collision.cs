using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart_On_Collision : MonoBehaviour

{
    [SerializeField]
    string strTag;

    bool active = true;
    int player_1_score = 0;
    int player_2_score = 0;

    public Text winner;
    public Text player_2;
    public Text player_1;

    private void OnCollisionEnter(Collision collision){
        if (active == true){
            
        if (collision.gameObject.tag == "Player1"){
            winner.text = "Player 2 Wins!";
            print("Player 2 Wins");
            Update_score(2);
            active = false;
            Invoke("Restart_Game",2);
               
        }
        else if (collision.gameObject.tag == "Player2"){
            winner.text = "Player 1 Wins!";
            print("Player 1 Wins");
            Update_score(1);
            active = false;
            Invoke("Restart_Game",2);
            
        }
        }
    }

     public void Restart_Game(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
     }

     public void Update_score(int winner) {
        
        if (winner == 1){
            player_1_score += 1;
        }else if (winner == 2){
            player_2_score += 1;
        }

        if (player_1 != null) {
        player_1.text = player_1_score.ToString() + " - Player 1";
        }
        if (player_2 != null) {
        player_2.text = "Player 2 - " + player_2_score.ToString();
        }
    }
}
