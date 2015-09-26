using System;
using System.Collections.Generic;
using Color = System.Drawing.Color;

namespace MyGame
{
	public class Drawing
	{
		private readonly List<Shape> _shapes;
		private Color _background;

		public Drawing (Color background)
		{
			_shapes = new List<Shape>();
			_background = background;


		}
		public Drawing () :this (Color.White)
		{
			
		}

		public int ShapeCount()
		{

		}

		public void AddShape ()
		{

		}

		public  Color Background
		{
			get {return _background;}
		}
	}
}