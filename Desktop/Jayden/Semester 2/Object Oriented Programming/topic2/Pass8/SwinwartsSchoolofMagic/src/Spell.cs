using System;

namespace SwinwartsSchoolofMagic
{
	/// <summary>
	/// Spells which can be casted by the user, there is three types of spells and each has a different affect.
	/// </summary>
	public class Spell
	{
		private string _name;
		private SpellKind _kind;

		/// <summary>
		/// Initializes a new instance of the <see cref="SwinwartsSchoolofMagic.Spell"/> class.
		/// </summary>
		/// <param name="kind">Kind.</param>
		/// <param name="name">Name.</param>
		public Spell (SpellKind kind, string name)
		{
			_kind = kind;
			_name = name;
		}

		/// <summary>
		/// Returns a different string depending on the type of spell (Teleport, Heal, Invisibility)
		/// </summary>
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

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
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

		/// <summary>
		/// Gets the kind.
		/// </summary>
		/// <value>The kind.</value>
		public SpellKind Kind
		{
			get
			{
				return _kind;
			}
		}
	}
}

