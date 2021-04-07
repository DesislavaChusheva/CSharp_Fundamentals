using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Participant> participants = new Dictionary<string, Participant>();
            string command = Console.ReadLine();

            while (command != "Results")
            {
                string[] cmdArg = command.Split(':', StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArg[0];

                switch (action)
                {
                    case "Add":
                        string name = cmdArg[1];
                        int health = int.Parse(cmdArg[2]);
                        int energy = int.Parse(cmdArg[3]);
                        if (participants.ContainsKey(name))
                        {
                            participants[name].Health += health;
                        }
                        else
                        {
                            Participant participant = new Participant(health, energy);
                            participants.Add(name, participant);
                        }
                        break;

                    case "Attack":
                        string attackerName = cmdArg[1];
                        string defenderName = cmdArg[2];
                        int damage = int.Parse(cmdArg[3]);
                        if (participants.ContainsKey(attackerName) && participants.ContainsKey(defenderName))
                        {
                            participants[defenderName].Health -= damage;
                            if (participants[defenderName].Health <= 0)
                            {
                                participants.Remove(defenderName);
                                Console.WriteLine($"{defenderName} was disqualified!");
                            }
                            participants[attackerName].Energy -= 1;
                            if (participants[attackerName].Energy <= 0)
                            {
                                participants.Remove(attackerName);
                                Console.WriteLine($"{attackerName} was disqualified!");
                            }
                        }
                        break;

                    case "Delete":
                        string username = cmdArg[1];
                        if (participants.ContainsKey(username))
                        {
                            participants.Remove(username);
                        }
                        else if (username == "All")
                        {
                            participants.Clear();
                        }
                        break;

                    default:
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"People count: {participants.Count}");
            foreach (var participant in participants.OrderByDescending(x => x.Value.Health).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{participant.Key} - {participant.Value.Health} - {participant.Value.Energy}");
            }
        }

        class Participant
        {
            public Participant(int health, int energy)
            {
                Health = health;
                Energy = energy;
            }
            public int Health { get; set; }
            public int Energy { get; set; }
        }
    }
}
