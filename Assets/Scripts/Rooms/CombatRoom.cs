using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatRoom : RoomBase {
    /*
    int timesSearched = 0;
    public static bool doesPlayerWon = false;
    bool userWantsToFight = false;
    string userAnswer = "";

    // Create Instances
    Combat combat = new Combat(); // combat Instance

    public override string roomName { get; } = "Combat Room";

    public override void OnRoomEntered() {
        userWantsToFight = false;

        // Call the base function OnRoomEntered
        base.OnRoomEntered();

        // Call function that display player's life
        GameManager.player.GetPlayerLife();

        // While loop that Start the Combat
        while (userWantsToFight != true) {
            Debug.Log("Do you want to fight? WRITE: YES | NO");
            /*
            userAnswer = (Console.ReadLine() ?? "").ToLower();
            */
    /*
            switch (userAnswer) {
                case "y":
                case "yes":
                    userWantsToFight = true;
                    // Create a variable enemy that is assign to the RandomEnemy() function
                    Enemy enemy = Enemy.RandomEnemy(); // get a random enemy class

                    // Display message of which enemy the player is fighting against
                    Debug.Log($"You are fighting against the {enemy.EnemyName}");
                    Debug.Log($"{enemy.EnemyName} has {enemy.EnemyLife} life points!");

                    // Combat Loop that runs while player and enemy are alive
                    while (GameManager.player.IsPlayerAlive && enemy.IsAlive()) {
                        // Call function PlayerTurn
                        combat.PlayerTurn(enemy);
                        // If enemy is not alive the loop stop
                        if (enemy.IsAlive() != true)
                            break;
                        // Call function EnemyTurn
                        combat.EnemyTurn(enemy);
                    }
                    // Call function WinLose that check if player won or lost
                    combat.CombatWinLose(enemy);
                    break;

                case "n":
                case "no":
                    Debug.Log("Okay, you don't want to fight");
                    userWantsToFight = true;
                    doesPlayerWon = false;
                    break;

                default:
                    Debug.Log("Wrong input. Write: YES | NO");
                    break;
            }
        }
    }

    public override void OnRoomSearched() {
        if (doesPlayerWon && timesSearched < 3) {
            // Call function AddItemToInventory
            GameManager.player.InventoryInstance.AddItemToInventory(ref itemFound);
            Debug.Log($"You found: {itemFound}");
            timesSearched++;
        }
        else if (doesPlayerWon && timesSearched >= 3) {
            Debug.Log($"{GameManager.player.PlayerName} you can't search more than 3 times on {roomName}");
        }
        else {
            Debug.Log("Nothing more on this room!");
        }
    }
*/
}