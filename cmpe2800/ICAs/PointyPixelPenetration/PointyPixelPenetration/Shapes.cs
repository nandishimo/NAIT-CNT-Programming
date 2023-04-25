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
		public const int c_iSize = 100;
		public bool IsMarkedForDeath { get; private set; }
		public PointF Pos { get; private set; }

		protected List<PointF> GenModel(int iVertexCount, int fSizeVar)
		{
			// model generation
			double dangle = 0;
			List<PointF> pts = new List<PointF>();
			int variedSize = s_rnd.Next(c_iSize - fSizeVar, c_iSize);
			for (int i = 0; i < iVertexCount; ++i, dangle += (Math.PI * 2) / iVertexCount)
				pts.Add(new PointF
					(
						(float)Math.Cos(dangle) * variedSize,
						(float)Math.Sin(dangle) * variedSize
					));
			return pts;
		}
		public abstract GraphicsPath GetPath();
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
		public override GraphicsPath GetPath()
		{
			var pts = GenModel(3, 0);
			GraphicsPath gp = new GraphicsPath();
			gp.AddPolygon(pts.ToArray());
			gp.CloseAllFigures();
			return gp;
		}

	}
	public class Rock:ShapeBase
	{
		private GraphicsPath _model;
		public Rock(PointF Position): base(Position)
		{

		}
		public override GraphicsPath GetPath()
		{
			int iSides = s_rnd.Next(4, 12);
			var pts = GenModel(iSides, 20);
			GraphicsPath gp = new GraphicsPath();
			gp.AddPolygon(pts.ToArray());
			gp.CloseAllFigures();
			return gp;
		}
	}
}
