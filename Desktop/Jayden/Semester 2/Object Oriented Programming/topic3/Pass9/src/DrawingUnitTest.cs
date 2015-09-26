using NUnit.Framework;
using System;
using Color = System.Drawing.Color;
using SwinGameSDK;

namespace MyGame
{
	[TestFixture ()]
	public class ShapeTest
	{
		[Test ()]
		public void TestShapeAt ()
		{
			Shape s = new Shape ();

			s.X = 25;
			s.Y = 25;
			s.Width = 50;
			s.Height = 50;

			Assert.IsTrue(s.IsAt(SwinGame.PointAt(50,50)));
			Assert.IsTrue(s.IsAt(SwinGame.PointAt(25,25)));
			Assert.IsFalse(s.IsAt(SwinGame.PointAt(10,50)));
			Assert.IsFalse(s.IsAt(SwinGame.PointAt(50,10)));
		}

		[Test ()]
		public void TestShapeAtWhenMoved ()
		{
			Shape s = new Shape ();

			s.X = 25;
			s.Y = 25;
			s.Width = 50;
			s.Height = 50;

			Assert.IsTrue(s.IsAt(SwinGame.PointAt(60,60)));

			s.X = 0;
			s.Y = 0;

			Assert.IsFalse(s.IsAt(SwinGame.PointAt(60,60)));

			s.Width = 100;
			s.Height = 100;

			Assert.IsTrue (s.IsAt (SwinGame.PointAt (60, 60)));
		}

		[Test ()]
		public void TestShapeWhenResized()
		{
			Shape s = new Shape ();

			s.X = 25;
			s.Y = 25;
			s.Width = 50;
			s.Height = 50;

			Assert.IsTrue(s.IsAt(SwinGame.PointAt(50,50)));

			s.Width = 10;
			s.Height = 10;

			Assert.IsFalse (s.IsAt (SwinGame.PointAt (50, 50)));
		}
	}
}

