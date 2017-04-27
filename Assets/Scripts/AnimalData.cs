﻿using UnityEngine;
using System.Collections;

public class AnimalData  
{
	public AnimalSpecies Species { private set; get; }
	public string Description { private set; get; }
	public HabitatLevelType HabitatLevel { private set; get; }
	public float MinimumSize { private set; get; }
	public float MaximumSize { private set; get; }
	public float MinimumAge { private set; get; }
	public float MaximumAge { private set; get; }
	public string ColorMapFile { private set; get; }

	public AnimalData(AnimalSpecies species, string description, HabitatLevelType habitat, float min_size, float max_size, float min_age, float max_age, string colorFile)
	{
		Species = species;
		Description = description;
		HabitatLevel = habitat;
		MinimumSize = min_size;
		MaximumSize = max_size;
		MinimumAge = min_age;
		MaximumAge = max_age;
		ColorMapFile = colorFile;
	}
}