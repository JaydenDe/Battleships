using System;

namespace SwinwartsSchoolofMagic
{
	public class Spell
	{
		private string _name;
		private SpellKind _kind;

		public Spell (SpellKind kind, string name)
		{
			_kind = kind;
			_name = name;
		}

		public string Cast()
		{
			switch (_kind)
			{
				case SpellKind.Teleport:
					return "Poof.. you appear somewhere else";
					break;
				case SpellKind.Heal:
					return "Ahh.. you feel better";
					break;
				case SpellKind.Invisibility:
					return "Zipp.. where am I?";
					break;
				default:
					return "Error: Casting of unknown kind";
					break;
			}

		}

		public string Name
		{
			get
			{
				return _name;	
			}
			set
			{
				_name = value;
			}
		}

		public SpellKind Kind
		{
			get
			{
				return _kind;
			}
		}
	}
}

