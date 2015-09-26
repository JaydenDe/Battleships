using NUnit.Framework;
using System;

namespace SwinwartsSchoolofMagic
{
	[TestFixture ()]
	public class TestSpellKinds
	{
		[Test ()]
		public void TestTeleport ()
		{
			Spell spell = new Spell (SpellKind.Teleport, "Mitch's mighty mover");
			Assert.IsTrue(spell.Cast() == "Poof.. you appear somewhere else");
		}

		[Test ()]
		public void TestHeal ()
		{
			Spell spell = new Spell (SpellKind.Heal, "Paul's potent poultice");
			Assert.IsTrue(spell.Cast() == "Ahh.. you feel better");
		}

		[Test ()]
		public void TestInvisibility ()
		{
			Spell spell = new Spell (SpellKind.Invisibility, "David's dashing disappearance");
			Assert.IsTrue(spell.Cast() == "Zipp.. where am I?");
		}
	}
}

