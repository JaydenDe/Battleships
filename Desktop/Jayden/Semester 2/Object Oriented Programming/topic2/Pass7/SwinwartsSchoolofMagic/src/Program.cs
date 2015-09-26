using System;

namespace SwinwartsSchoolofMagic
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Spell[] spells = new Spell[5];
			spells [0] = new Spell (SpellKind.Teleport, "Mitch's mighty mover");
			spells [1] = new Spell (SpellKind.Heal, "Paul's potent poultice");
			spells [2] = new Spell (SpellKind.Invisibility, "David's dashing disappearance");
			spells [3] = new Spell (SpellKind.Teleport, "Stan's stunning shifter");
			spells [4] = new Spell (SpellKind.Heal, "Lachlan's lavish longevity");
			CastAll (spells);
		}

		public static void CastAll(Spell[] spells)
		{
			for (int i = 0; i < spells.Length; i++)
			{
				Console.WriteLine (spells[i].Name);
				Console.WriteLine (spells [i].Cast());
			}
		}
	}
}
