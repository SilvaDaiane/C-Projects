﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DublinBank
{
    [DefaultEvent("_Click")]
    public partial class DBTextBox : UserControl
    {
        //Fields
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private Color borderFocusColor = Color.HotPink;
        private bool isFocused = false;

        private int borderRadius = 0;
        private Color placeHolderColor = Color.DarkGray;
        private string placeHolderText = "";
        private bool isPlaceHolder = false;
        private bool isPasswordChar = false;

        //Constructor
        public DBTextBox()
        {
            InitializeComponent();
        }


        //Events
        public event EventHandler _Click;

        //Properties

        public Color BorderColor
        { 
            get { return borderColor; }
            set { borderColor = value; this.Invalidate(); }
        }
        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = value; this.Invalidate(); }

        }

        public bool UnderlinedStyle 
        {
            get { return underlinedStyle; }
            set { underlinedStyle = value; this.Invalidate(); }
        
        }
       
        public bool PasswordChar
        {
            get { return isPasswordChar; }
            set 
            { 
                isPasswordChar = value;
                textBox1.UseSystemPasswordChar = value;

            }
        
        }
        public bool Multiline
        { get { return textBox1.Multiline; } set { textBox1.Multiline = value;} }
        
        public override Color BackColor
        {
            get { return base.BackColor; }
            set { base.BackColor = value; textBox1.BackColor = value; }
        
        }
        
        public override Color ForeColor { get => base.ForeColor; set => base.ForeColor = value; }
        
        public override Font Font
        {
            get { return base.Font; }
            set { textBox1.Font = value; if (this.DesignMode) UpdateControlHeight(); }


        }
        public string Texts
        {
            get 
            {
                if (isPlaceHolder) return "";
                else
                return textBox1.Text; 
            }
            set { textBox1.Text = value; SetPlaceHolder(); }
        }
        public Color BorderFocusColor { get => borderFocusColor; set => borderFocusColor = value; }

        public int BorderRadius 
        { 
            get { return borderRadius; }
            set 
            { 
                if (value >= 0) 
                {
                    borderRadius = value; this.Invalidate(); //Redraw control
                } 
            }
        
        }

        public Color PlaceHolderColor 
        {
            get { return placeHolderColor; }
            set { placeHolderColor = value; if (isPasswordChar) textBox1.ForeColor = value; }
        
        
        
        }
        public string PlaceHolderText 
        {
            get { return placeHolderText; }
            set { placeHolderText = value; textBox1.Text = ""; SetPlaceHolder(); } 
            
            
        }

        private void SetPlaceHolder()
        {
            if(string.IsNullOrEmpty(textBox1.Text) && placeHolderText != "") 
            {
                isPlaceHolder = true;
                textBox1.Text = placeHolderText;
                textBox1.ForeColor = placeHolderColor;
                if(isPasswordChar)
                    textBox1.UseSystemPasswordChar = false;
            
            }
        }
        private void RemovePlaceHolder()
        {
            if (isPlaceHolder && placeHolderText != "")
            {
                isPlaceHolder = false;
                textBox1.Text = "";
                textBox1.ForeColor = this.ForeColor;
                if (isPasswordChar)
                    textBox1.UseSystemPasswordChar = true;

            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            if(borderRadius > 1) //Rounded text box
            {
                //-Fileds 
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;

                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor,smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    //-Drawing
                    this.Region = new Region(pathBorderSmooth);//Set the rounded region of using control
                    if (borderRadius > 15) SetTextBoxRoundedRegion();//Set the rounded region of text box
                    g.SmoothingMode = SmoothingMode.AntiAlias;

                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                    if (isFocused) penBorder.Color = borderFocusColor;


                    if (underlinedStyle) //Line style
                    {
                        //Draw border smooth
                        g.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        g.SmoothingMode = SmoothingMode.None;

                        g.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else //Normal Style
                    {   
                        //Draw border smooth
                        g.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        g.DrawPath(penBorder, pathBorder);


                    }


                }
            
            } else //Square/Normal text box
            {   //Draw border
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                    if (isFocused) penBorder.Color = borderFocusColor;
                    

                    if (underlinedStyle) //Line style
                       g.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else //Normal Style
                       g.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                    


                }


            
            }
        }

        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            if (Multiline) 
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderRadius-borderSize);
                textBox1.Region = new Region(pathTxt);
            
            }else
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderSize * 2);
                textBox1.Region = new Region(pathTxt);
            }
        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius) 
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;



        
        }


        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if(this.DesignMode)
                UpdateControlHeight();


        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        //private methods
        private void UpdateControlHeight()
        {
            if(textBox1.Multiline == false) 
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
            RemovePlaceHolder();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
            SetPlaceHolder();

        }
    }
}
