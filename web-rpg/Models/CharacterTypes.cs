﻿using System.Text.Json.Serialization;

namespace web_rpg.Models;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum CharacterTypes
{
    Knight = 1,
    Mage = 2,
    Cleric = 3
}