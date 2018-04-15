namespace Test1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFirstCoord_X = new System.Windows.Forms.TextBox();
            this.OutputTriangles = new System.Windows.Forms.TextBox();
            this.DisplayTriangles = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddTriangle = new System.Windows.Forms.Button();
            this.DisplayIsosceles = new System.Windows.Forms.Button();
            this.SimilarTriangles = new System.Windows.Forms.Button();
            this.OutputIsosceles = new System.Windows.Forms.TextBox();
            this.AddIsosceles = new System.Windows.Forms.Button();
            this.BiggestAreaIsosceles = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFirstCoord_Y = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSecondCoord_Y = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSecondCoord_X = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtThirdCoord_Y = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtThirdCoord_X = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtIsoscelesThirdCoord_Y = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtIsoscelesThirdCoord_X = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtIsoscelesSecondCoord_Y = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtIsoscelesSecondCoord_X = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtIsoscelesFirstCoord_Y = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtIsoscelesFirstCoord_X = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtFirstCoord_X
            // 
            this.txtFirstCoord_X.Location = new System.Drawing.Point(108, 50);
            this.txtFirstCoord_X.Name = "txtFirstCoord_X";
            this.txtFirstCoord_X.Size = new System.Drawing.Size(50, 22);
            this.txtFirstCoord_X.TabIndex = 0;
            // 
            // OutputTriangles
            // 
            this.OutputTriangles.Location = new System.Drawing.Point(30, 315);
            this.OutputTriangles.Multiline = true;
            this.OutputTriangles.Name = "OutputTriangles";
            this.OutputTriangles.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OutputTriangles.Size = new System.Drawing.Size(593, 295);
            this.OutputTriangles.TabIndex = 3;
            // 
            // DisplayTriangles
            // 
            this.DisplayTriangles.Location = new System.Drawing.Point(433, 105);
            this.DisplayTriangles.Name = "DisplayTriangles";
            this.DisplayTriangles.Size = new System.Drawing.Size(190, 85);
            this.DisplayTriangles.TabIndex = 4;
            this.DisplayTriangles.Text = "Display data for all triangles";
            this.DisplayTriangles.UseVisualStyleBackColor = true;
            this.DisplayTriangles.Click += new System.EventHandler(this.DisplayTriangles_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(68, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "x :";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(679, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(2, 670);
            this.label4.TabIndex = 8;
            // 
            // AddTriangle
            // 
            this.AddTriangle.Location = new System.Drawing.Point(433, 10);
            this.AddTriangle.Name = "AddTriangle";
            this.AddTriangle.Size = new System.Drawing.Size(190, 85);
            this.AddTriangle.TabIndex = 10;
            this.AddTriangle.Text = "Add a triangle";
            this.AddTriangle.UseVisualStyleBackColor = true;
            this.AddTriangle.Click += new System.EventHandler(this.AddTriangle_Click);
            // 
            // DisplayIsosceles
            // 
            this.DisplayIsosceles.Location = new System.Drawing.Point(1219, 105);
            this.DisplayIsosceles.Name = "DisplayIsosceles";
            this.DisplayIsosceles.Size = new System.Drawing.Size(190, 85);
            this.DisplayIsosceles.TabIndex = 11;
            this.DisplayIsosceles.Text = "Display data on all isosceles triangles";
            this.DisplayIsosceles.UseVisualStyleBackColor = true;
            this.DisplayIsosceles.Click += new System.EventHandler(this.DisplayIsosceles_Click);
            // 
            // SimilarTriangles
            // 
            this.SimilarTriangles.Location = new System.Drawing.Point(433, 200);
            this.SimilarTriangles.Name = "SimilarTriangles";
            this.SimilarTriangles.Size = new System.Drawing.Size(190, 85);
            this.SimilarTriangles.TabIndex = 12;
            this.SimilarTriangles.Text = "Find similar triangles";
            this.SimilarTriangles.UseVisualStyleBackColor = true;
            this.SimilarTriangles.Click += new System.EventHandler(this.TriangleSimilar_Click);
            // 
            // OutputIsosceles
            // 
            this.OutputIsosceles.Location = new System.Drawing.Point(726, 316);
            this.OutputIsosceles.Multiline = true;
            this.OutputIsosceles.Name = "OutputIsosceles";
            this.OutputIsosceles.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OutputIsosceles.Size = new System.Drawing.Size(621, 295);
            this.OutputIsosceles.TabIndex = 16;
            // 
            // AddIsosceles
            // 
            this.AddIsosceles.Location = new System.Drawing.Point(1219, 10);
            this.AddIsosceles.Name = "AddIsosceles";
            this.AddIsosceles.Size = new System.Drawing.Size(190, 85);
            this.AddIsosceles.TabIndex = 20;
            this.AddIsosceles.Text = "Add a Isosceles triangle";
            this.AddIsosceles.UseVisualStyleBackColor = true;
            this.AddIsosceles.Click += new System.EventHandler(this.AddIsosceles_Click);
            // 
            // BiggestAreaIsosceles
            // 
            this.BiggestAreaIsosceles.Location = new System.Drawing.Point(1219, 200);
            this.BiggestAreaIsosceles.Name = "BiggestAreaIsosceles";
            this.BiggestAreaIsosceles.Size = new System.Drawing.Size(190, 85);
            this.BiggestAreaIsosceles.TabIndex = 21;
            this.BiggestAreaIsosceles.Text = "Find an isosceles triangle with the largest area";
            this.BiggestAreaIsosceles.UseVisualStyleBackColor = true;
            this.BiggestAreaIsosceles.Click += new System.EventHandler(this.BiggestAreaIsosceles_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Output for a triangles :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(723, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(220, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Output for a isoscelesa triangles :";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(193, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "y :";
            // 
            // txtFirstCoord_Y
            // 
            this.txtFirstCoord_Y.Location = new System.Drawing.Point(233, 50);
            this.txtFirstCoord_Y.Name = "txtFirstCoord_Y";
            this.txtFirstCoord_Y.Size = new System.Drawing.Size(50, 22);
            this.txtFirstCoord_Y.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(193, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "y :";
            // 
            // txtSecondCoord_Y
            // 
            this.txtSecondCoord_Y.Location = new System.Drawing.Point(233, 136);
            this.txtSecondCoord_Y.Name = "txtSecondCoord_Y";
            this.txtSecondCoord_Y.Size = new System.Drawing.Size(50, 22);
            this.txtSecondCoord_Y.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(68, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "x :";
            // 
            // txtSecondCoord_X
            // 
            this.txtSecondCoord_X.Location = new System.Drawing.Point(108, 136);
            this.txtSecondCoord_X.Name = "txtSecondCoord_X";
            this.txtSecondCoord_X.Size = new System.Drawing.Size(50, 22);
            this.txtSecondCoord_X.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(193, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "y :";
            // 
            // txtThirdCoord_Y
            // 
            this.txtThirdCoord_Y.Location = new System.Drawing.Point(233, 231);
            this.txtThirdCoord_Y.Name = "txtThirdCoord_Y";
            this.txtThirdCoord_Y.Size = new System.Drawing.Size(50, 22);
            this.txtThirdCoord_Y.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(68, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 20);
            this.label12.TabIndex = 31;
            this.label12.Text = "x :";
            // 
            // txtThirdCoord_X
            // 
            this.txtThirdCoord_X.Location = new System.Drawing.Point(108, 231);
            this.txtThirdCoord_X.Name = "txtThirdCoord_X";
            this.txtThirdCoord_X.Size = new System.Drawing.Size(50, 22);
            this.txtThirdCoord_X.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(30, 190);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(332, 20);
            this.label13.TabIndex = 34;
            this.label13.Text = "Coordinates of the third point of the triangle";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(30, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(328, 20);
            this.label14.TabIndex = 35;
            this.label14.Text = "Coordinates of the first point of the triangle";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.Location = new System.Drawing.Point(30, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(353, 20);
            this.label15.TabIndex = 36;
            this.label15.Text = "Coordinates of the second point of the triangle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(720, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(429, 20);
            this.label6.TabIndex = 51;
            this.label6.Text = "Coordinates of the second point of isosceles the triangle";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(720, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(404, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "Coordinates of the first point of the isosceles triangle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(722, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(408, 20);
            this.label8.TabIndex = 49;
            this.label8.Text = "Coordinates of the third point of the isosceles triangle";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label16.Location = new System.Drawing.Point(906, 229);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 20);
            this.label16.TabIndex = 48;
            this.label16.Text = "y :";
            // 
            // txtIsoscelesThirdCoord_Y
            // 
            this.txtIsoscelesThirdCoord_Y.Location = new System.Drawing.Point(946, 229);
            this.txtIsoscelesThirdCoord_Y.Name = "txtIsoscelesThirdCoord_Y";
            this.txtIsoscelesThirdCoord_Y.Size = new System.Drawing.Size(50, 22);
            this.txtIsoscelesThirdCoord_Y.TabIndex = 47;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label17.Location = new System.Drawing.Point(781, 229);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 20);
            this.label17.TabIndex = 46;
            this.label17.Text = "x :";
            // 
            // txtIsoscelesThirdCoord_X
            // 
            this.txtIsoscelesThirdCoord_X.Location = new System.Drawing.Point(821, 229);
            this.txtIsoscelesThirdCoord_X.Name = "txtIsoscelesThirdCoord_X";
            this.txtIsoscelesThirdCoord_X.Size = new System.Drawing.Size(50, 22);
            this.txtIsoscelesThirdCoord_X.TabIndex = 45;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label18.Location = new System.Drawing.Point(906, 136);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 20);
            this.label18.TabIndex = 44;
            this.label18.Text = "y :";
            // 
            // txtIsoscelesSecondCoord_Y
            // 
            this.txtIsoscelesSecondCoord_Y.Location = new System.Drawing.Point(946, 136);
            this.txtIsoscelesSecondCoord_Y.Name = "txtIsoscelesSecondCoord_Y";
            this.txtIsoscelesSecondCoord_Y.Size = new System.Drawing.Size(50, 22);
            this.txtIsoscelesSecondCoord_Y.TabIndex = 43;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label19.Location = new System.Drawing.Point(781, 136);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 20);
            this.label19.TabIndex = 42;
            this.label19.Text = "x :";
            // 
            // txtIsoscelesSecondCoord_X
            // 
            this.txtIsoscelesSecondCoord_X.Location = new System.Drawing.Point(821, 136);
            this.txtIsoscelesSecondCoord_X.Name = "txtIsoscelesSecondCoord_X";
            this.txtIsoscelesSecondCoord_X.Size = new System.Drawing.Size(50, 22);
            this.txtIsoscelesSecondCoord_X.TabIndex = 41;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label20.Location = new System.Drawing.Point(906, 50);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 20);
            this.label20.TabIndex = 40;
            this.label20.Text = "y :";
            // 
            // txtIsoscelesFirstCoord_Y
            // 
            this.txtIsoscelesFirstCoord_Y.Location = new System.Drawing.Point(946, 50);
            this.txtIsoscelesFirstCoord_Y.Name = "txtIsoscelesFirstCoord_Y";
            this.txtIsoscelesFirstCoord_Y.Size = new System.Drawing.Size(50, 22);
            this.txtIsoscelesFirstCoord_Y.TabIndex = 39;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label21.Location = new System.Drawing.Point(781, 50);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 20);
            this.label21.TabIndex = 38;
            this.label21.Text = "x :";
            // 
            // txtIsoscelesFirstCoord_X
            // 
            this.txtIsoscelesFirstCoord_X.Location = new System.Drawing.Point(821, 50);
            this.txtIsoscelesFirstCoord_X.Name = "txtIsoscelesFirstCoord_X";
            this.txtIsoscelesFirstCoord_X.Size = new System.Drawing.Size(50, 22);
            this.txtIsoscelesFirstCoord_X.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 623);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtIsoscelesThirdCoord_Y);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtIsoscelesThirdCoord_X);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtIsoscelesSecondCoord_Y);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtIsoscelesSecondCoord_X);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtIsoscelesFirstCoord_Y);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtIsoscelesFirstCoord_X);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtThirdCoord_Y);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtThirdCoord_X);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSecondCoord_Y);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSecondCoord_X);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFirstCoord_Y);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BiggestAreaIsosceles);
            this.Controls.Add(this.AddIsosceles);
            this.Controls.Add(this.OutputIsosceles);
            this.Controls.Add(this.SimilarTriangles);
            this.Controls.Add(this.DisplayIsosceles);
            this.Controls.Add(this.AddTriangle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DisplayTriangles);
            this.Controls.Add(this.OutputTriangles);
            this.Controls.Add(this.txtFirstCoord_X);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstCoord_X;
        private System.Windows.Forms.TextBox OutputTriangles;
        private System.Windows.Forms.Button DisplayTriangles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddTriangle;
        private System.Windows.Forms.Button DisplayIsosceles;
        private System.Windows.Forms.Button SimilarTriangles;
        private System.Windows.Forms.TextBox OutputIsosceles;
        private System.Windows.Forms.Button AddIsosceles;
        private System.Windows.Forms.Button BiggestAreaIsosceles;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFirstCoord_Y;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSecondCoord_Y;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSecondCoord_X;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtThirdCoord_Y;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtThirdCoord_X;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtIsoscelesThirdCoord_Y;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtIsoscelesThirdCoord_X;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtIsoscelesSecondCoord_Y;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtIsoscelesSecondCoord_X;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtIsoscelesFirstCoord_Y;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtIsoscelesFirstCoord_X;
    }
}

