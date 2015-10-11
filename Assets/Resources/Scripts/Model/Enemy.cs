﻿using System;
using System.Collections.Generic;

public class Enemy 
{        
    public string Name { get; set; }
        
    public int Health { get; set; }
    public float MoveSpeed { get; set; }
    public int Damage { get; set; }
    public float AttackSpeed { get; set; }

    public int ScoreValue { get; set; }
    public int SpawnTime { get; set; }


	public Enemy()
	{
		SetDefaults();
	}

	private void SetDefaults()
	{
        Name = "";
        Health = 0;
        MoveSpeed = 0f;
        Damage = 0;
        AttackSpeed = 0f;
        ScoreValue = 0;
        SpawnTime = 0;
    }

}