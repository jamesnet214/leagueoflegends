﻿using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.TeamFight.UI.Units
{
	public class LockButton : Button
    {
        static LockButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LockButton), new FrameworkPropertyMetadata(typeof(LockButton)));
        }
    }
}
