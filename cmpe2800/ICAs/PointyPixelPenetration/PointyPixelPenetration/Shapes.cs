using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PointyPixelPenetration
{
	public abstract class ShapeBase
	{
		private float m_fRot;
		private float m_fRotInc;
		private float m_fXSpeed;
		private float m_fYSpeed;
		public static Random s_rnd = new Random();
		public const int c_iSize = 5;
		public bool IsMarkedForDeath { get; private set; }
		public PointF Pos { get; private set; }

		private void GenModel()
		{

		}
		public abstract void GetPath();
		public void Render()
		{

		}
		protected ShapeBase(PointF position)
		{
			Pos = position;
			m_fRot = 0;
			m_fRotInc = (float)(6 * (s_rnd.NextDouble() - 0.5));
			m_fXSpeed = (float)(5 * (s_rnd.NextDouble() - 0.5));
			m_fYSpeed = (float)(5 * (s_rnd.NextDouble() - 0.5));
		}
		public void Tick(Point Size)
		{
			float xPos = Pos.X + m_fXSpeed;
			float yPos = Pos.Y + m_fYSpeed;
			Pos = new PointF(Pos.X+m_fXSpeed, Pos.Y+m_fYSpeed);

		}
	}
	public class Triangle:ShapeBase
	{
		private static GraphicsPath s_model;

		public Triangle(PointF Position): base(Position)
		{

		}
		public override void GetPath()
		{
			
		}

	}
	public class Rock:ShapeBase
	{
		private GraphicsPath _model;
		public Rock(PointF Position): base(Position)
		{

		}
		public override void GetPath()
		{

		}
	}
}
