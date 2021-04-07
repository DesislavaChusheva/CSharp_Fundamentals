using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._09.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> sideUser = new Dictionary<string, List<string>>();
            while (input != "Lumpawaroo")
            {
                string[] cmdArg = input.Split(" | ", StringSplitOptions.RemoveEmptyEntries );
                if (cmdArg.Length > 1)
                {
                    string side = cmdArg[0];
                    string user = cmdArg[1];
                    bool flag = false;
                    foreach (var kvp in sideUser)
                    {
                        if (kvp.Value.Contains(user))
                        {
                            flag = true;
                        }
                    }
                    if (!flag)
                    {
                        if (!sideUser.ContainsKey(side))
                        {
                            List<string> users = new List<string>();
                            users.Add(user);
                            sideUser.Add(side, users);
                        }
                        else
                        {
                            sideUser[side].Add(user);
                        }
                    }
                }

                else
                {
                    cmdArg = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries );
                    string user = cmdArg[0];
                    string side = cmdArg[1];
                    bool flag = false;
                    bool userExist = false;
                    string wrongKey = string.Empty;
                    foreach (var kvp in sideUser)
                    {
                        if (kvp.Value.Contains(user))
                        {
                            userExist = true;
                            if (kvp.Key != side)
                            {
                                wrongKey = kvp.Key;
                                break;
                            }
                            else
                            {
                                flag = true;
                            }
                        }
                    }
                    if (!flag)
                    {
                        if (!sideUser.ContainsKey(side))
                        {
                            if (userExist)
                            {
                                sideUser[wrongKey].Remove(user);
                            }
                            List<string> users = new List<string>();
                            users.Add(user);
                            sideUser.Add(side, users);
                        }
                        else
                        {
                            if (userExist)
                            {
                                sideUser[wrongKey].Remove(user);
                            }
                            sideUser[side].Add(user);
                        }
                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var sup in sideUser.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                if (sup.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {sup.Key}, Members: {sup.Value.Count}");
                    foreach (var user in sup.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"! {user}");
                    }
                }
            }
        }
    }
}
