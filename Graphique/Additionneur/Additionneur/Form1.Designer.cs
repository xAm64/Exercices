namespace Additionneur
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.touche1 = new System.Windows.Forms.Button();
            this.touche2 = new System.Windows.Forms.Button();
            this.touche3 = new System.Windows.Forms.Button();
            this.touche4 = new System.Windows.Forms.Button();
            this.touche5 = new System.Windows.Forms.Button();
            this.touche6 = new System.Windows.Forms.Button();
            this.touche7 = new System.Windows.Forms.Button();
            this.touche8 = new System.Windows.Forms.Button();
            this.touche9 = new System.Windows.Forms.Button();
            this.touche0 = new System.Windows.Forms.Button();
            this.toucheC = new System.Windows.Forms.Button();
            this.touchePlus = new System.Windows.Forms.Button();
            this.Affichage = new System.Windows.Forms.TextBox();
            this.Compteur = new System.Windows.Forms.TextBox();
            this.AfficheTotal = new System.Windows.Forms.Label();
            this.buttonEgal = new System.Windows.Forms.Button();
            this.buttonVirgule = new System.Windows.Forms.Button();
            this.buttonMoins = new System.Windows.Forms.Button();
            this.buttonMultiplier = new System.Windows.Forms.Button();
            this.buttonDiviser = new System.Windows.Forms.Button();
            this.TextOperateur = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // touche1
            // 
            this.touche1.FlatAppearance.BorderColor = System.Drawing.Color.Cornsilk;
            this.touche1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.touche1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.touche1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.touche1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.touche1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.touche1.Location = new System.Drawing.Point(30, 275);
            this.touche1.Name = "touche1";
            this.touche1.Size = new System.Drawing.Size(42, 39);
            this.touche1.TabIndex = 0;
            this.touche1.Text = "1";
            this.touche1.UseVisualStyleBackColor = true;
            this.touche1.Click += new System.EventHandler(this.touche1_Click);
            // 
            // touche2
            // 
            this.touche2.FlatAppearance.BorderColor = System.Drawing.Color.Cornsilk;
            this.touche2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.touche2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.touche2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.touche2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.touche2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.touche2.Location = new System.Drawing.Point(89, 275);
            this.touche2.Name = "touche2";
            this.touche2.Size = new System.Drawing.Size(42, 39);
            this.touche2.TabIndex = 1;
            this.touche2.Text = "2";
            this.touche2.UseVisualStyleBackColor = true;
            this.touche2.Click += new System.EventHandler(this.touche1_Click);
            // 
            // touche3
            // 
            this.touche3.FlatAppearance.BorderColor = System.Drawing.Color.Cornsilk;
            this.touche3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.touche3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.touche3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.touche3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.touche3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.touche3.Location = new System.Drawing.Point(147, 275);
            this.touche3.Name = "touche3";
            this.touche3.Size = new System.Drawing.Size(42, 39);
            this.touche3.TabIndex = 2;
            this.touche3.Text = "3";
            this.touche3.UseVisualStyleBackColor = true;
            this.touche3.Click += new System.EventHandler(this.touche1_Click);
            // 
            // touche4
            // 
            this.touche4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.touche4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.touche4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.touche4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.touche4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.touche4.ForeColor = System.Drawing.Color.LightGreen;
            this.touche4.Location = new System.Drawing.Point(30, 215);
            this.touche4.Name = "touche4";
            this.touche4.Size = new System.Drawing.Size(42, 39);
            this.touche4.TabIndex = 3;
            this.touche4.Text = "4";
            this.touche4.UseVisualStyleBackColor = true;
            this.touche4.Click += new System.EventHandler(this.touche1_Click);
            // 
            // touche5
            // 
            this.touche5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.touche5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.touche5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.touche5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.touche5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.touche5.ForeColor = System.Drawing.Color.LightGreen;
            this.touche5.Location = new System.Drawing.Point(89, 215);
            this.touche5.Name = "touche5";
            this.touche5.Size = new System.Drawing.Size(42, 39);
            this.touche5.TabIndex = 4;
            this.touche5.Text = "5";
            this.touche5.UseVisualStyleBackColor = true;
            this.touche5.Click += new System.EventHandler(this.touche1_Click);
            // 
            // touche6
            // 
            this.touche6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.touche6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.touche6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.touche6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.touche6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.touche6.ForeColor = System.Drawing.Color.LightGreen;
            this.touche6.Location = new System.Drawing.Point(147, 215);
            this.touche6.Name = "touche6";
            this.touche6.Size = new System.Drawing.Size(42, 39);
            this.touche6.TabIndex = 5;
            this.touche6.Text = "6";
            this.touche6.UseVisualStyleBackColor = true;
            this.touche6.Click += new System.EventHandler(this.touche1_Click);
            // 
            // touche7
            // 
            this.touche7.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.touche7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.touche7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.touche7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.touche7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.touche7.ForeColor = System.Drawing.Color.Salmon;
            this.touche7.Location = new System.Drawing.Point(30, 155);
            this.touche7.Name = "touche7";
            this.touche7.Size = new System.Drawing.Size(42, 39);
            this.touche7.TabIndex = 6;
            this.touche7.Text = "7";
            this.touche7.UseVisualStyleBackColor = true;
            this.touche7.Click += new System.EventHandler(this.touche1_Click);
            // 
            // touche8
            // 
            this.touche8.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.touche8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.touche8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.touche8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.touche8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.touche8.ForeColor = System.Drawing.Color.Salmon;
            this.touche8.Location = new System.Drawing.Point(89, 155);
            this.touche8.Name = "touche8";
            this.touche8.Size = new System.Drawing.Size(42, 39);
            this.touche8.TabIndex = 7;
            this.touche8.Text = "8";
            this.touche8.UseVisualStyleBackColor = true;
            this.touche8.Click += new System.EventHandler(this.touche1_Click);
            // 
            // touche9
            // 
            this.touche9.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.touche9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.touche9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.touche9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.touche9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.touche9.ForeColor = System.Drawing.Color.Salmon;
            this.touche9.Location = new System.Drawing.Point(147, 155);
            this.touche9.Name = "touche9";
            this.touche9.Size = new System.Drawing.Size(42, 39);
            this.touche9.TabIndex = 8;
            this.touche9.Text = "9";
            this.touche9.UseVisualStyleBackColor = true;
            this.touche9.Click += new System.EventHandler(this.touche1_Click);
            // 
            // touche0
            // 
            this.touche0.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.touche0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.touche0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.touche0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.touche0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.touche0.ForeColor = System.Drawing.Color.SkyBlue;
            this.touche0.Location = new System.Drawing.Point(30, 335);
            this.touche0.Name = "touche0";
            this.touche0.Size = new System.Drawing.Size(101, 39);
            this.touche0.TabIndex = 9;
            this.touche0.Text = "0";
            this.touche0.UseVisualStyleBackColor = true;
            this.touche0.Click += new System.EventHandler(this.touche1_Click);
            // 
            // toucheC
            // 
            this.toucheC.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.toucheC.FlatAppearance.BorderSize = 2;
            this.toucheC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.toucheC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.toucheC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toucheC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toucheC.ForeColor = System.Drawing.Color.Red;
            this.toucheC.Location = new System.Drawing.Point(30, 104);
            this.toucheC.Name = "toucheC";
            this.toucheC.Size = new System.Drawing.Size(42, 39);
            this.toucheC.TabIndex = 10;
            this.toucheC.Text = "C";
            this.toucheC.UseVisualStyleBackColor = true;
            this.toucheC.Click += new System.EventHandler(this.Effacer);
            // 
            // touchePlus
            // 
            this.touchePlus.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.touchePlus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.touchePlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.touchePlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.touchePlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.touchePlus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.touchePlus.Location = new System.Drawing.Point(206, 155);
            this.touchePlus.Name = "touchePlus";
            this.touchePlus.Size = new System.Drawing.Size(42, 99);
            this.touchePlus.TabIndex = 11;
            this.touchePlus.Text = "+";
            this.touchePlus.UseVisualStyleBackColor = true;
            this.touchePlus.Click += new System.EventHandler(this.SymboleOperatoire);
            // 
            // Affichage
            // 
            this.Affichage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(0)))));
            this.Affichage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Affichage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Affichage.Location = new System.Drawing.Point(69, 12);
            this.Affichage.Name = "Affichage";
            this.Affichage.Size = new System.Drawing.Size(189, 23);
            this.Affichage.TabIndex = 0;
            // 
            // Compteur
            // 
            this.Compteur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(0)))));
            this.Compteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Compteur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Compteur.Location = new System.Drawing.Point(69, 66);
            this.Compteur.Name = "Compteur";
            this.Compteur.Size = new System.Drawing.Size(189, 26);
            this.Compteur.TabIndex = 12;
            // 
            // AfficheTotal
            // 
            this.AfficheTotal.AutoSize = true;
            this.AfficheTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AfficheTotal.Location = new System.Drawing.Point(12, 68);
            this.AfficheTotal.Name = "AfficheTotal";
            this.AfficheTotal.Size = new System.Drawing.Size(51, 22);
            this.AfficheTotal.TabIndex = 13;
            this.AfficheTotal.Text = "Total";
            // 
            // buttonEgal
            // 
            this.buttonEgal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonEgal.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.buttonEgal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonEgal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.buttonEgal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEgal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonEgal.Location = new System.Drawing.Point(202, 275);
            this.buttonEgal.Name = "buttonEgal";
            this.buttonEgal.Size = new System.Drawing.Size(46, 99);
            this.buttonEgal.TabIndex = 15;
            this.buttonEgal.Text = "=";
            this.buttonEgal.UseVisualStyleBackColor = false;
            this.buttonEgal.Click += new System.EventHandler(this.Egal);
            // 
            // buttonVirgule
            // 
            this.buttonVirgule.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.buttonVirgule.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonVirgule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.buttonVirgule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVirgule.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVirgule.ForeColor = System.Drawing.Color.SkyBlue;
            this.buttonVirgule.Location = new System.Drawing.Point(147, 335);
            this.buttonVirgule.Name = "buttonVirgule";
            this.buttonVirgule.Size = new System.Drawing.Size(42, 39);
            this.buttonVirgule.TabIndex = 16;
            this.buttonVirgule.Text = ",";
            this.buttonVirgule.UseVisualStyleBackColor = true;
            this.buttonVirgule.Click += new System.EventHandler(this.touche1_Click);
            // 
            // buttonMoins
            // 
            this.buttonMoins.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.buttonMoins.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonMoins.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.buttonMoins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonMoins.Location = new System.Drawing.Point(206, 104);
            this.buttonMoins.Name = "buttonMoins";
            this.buttonMoins.Size = new System.Drawing.Size(42, 39);
            this.buttonMoins.TabIndex = 17;
            this.buttonMoins.Text = "-";
            this.buttonMoins.UseVisualStyleBackColor = true;
            this.buttonMoins.Click += new System.EventHandler(this.SymboleOperatoire);
            // 
            // buttonMultiplier
            // 
            this.buttonMultiplier.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.buttonMultiplier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonMultiplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.buttonMultiplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMultiplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonMultiplier.Location = new System.Drawing.Point(147, 104);
            this.buttonMultiplier.Name = "buttonMultiplier";
            this.buttonMultiplier.Size = new System.Drawing.Size(42, 39);
            this.buttonMultiplier.TabIndex = 18;
            this.buttonMultiplier.Text = "×";
            this.buttonMultiplier.UseVisualStyleBackColor = true;
            this.buttonMultiplier.Click += new System.EventHandler(this.SymboleOperatoire);
            // 
            // buttonDiviser
            // 
            this.buttonDiviser.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.buttonDiviser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonDiviser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.buttonDiviser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiviser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDiviser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonDiviser.Location = new System.Drawing.Point(89, 104);
            this.buttonDiviser.Name = "buttonDiviser";
            this.buttonDiviser.Size = new System.Drawing.Size(42, 39);
            this.buttonDiviser.TabIndex = 19;
            this.buttonDiviser.Text = "÷";
            this.buttonDiviser.UseVisualStyleBackColor = true;
            this.buttonDiviser.Click += new System.EventHandler(this.SymboleOperatoire);
            // 
            // TextOperateur
            // 
            this.TextOperateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(0)))));
            this.TextOperateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextOperateur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TextOperateur.Location = new System.Drawing.Point(16, 12);
            this.TextOperateur.Name = "TextOperateur";
            this.TextOperateur.Size = new System.Drawing.Size(31, 32);
            this.TextOperateur.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(270, 385);
            this.Controls.Add(this.TextOperateur);
            this.Controls.Add(this.buttonDiviser);
            this.Controls.Add(this.buttonMultiplier);
            this.Controls.Add(this.buttonMoins);
            this.Controls.Add(this.buttonVirgule);
            this.Controls.Add(this.buttonEgal);
            this.Controls.Add(this.AfficheTotal);
            this.Controls.Add(this.Compteur);
            this.Controls.Add(this.Affichage);
            this.Controls.Add(this.touchePlus);
            this.Controls.Add(this.toucheC);
            this.Controls.Add(this.touche0);
            this.Controls.Add(this.touche9);
            this.Controls.Add(this.touche8);
            this.Controls.Add(this.touche7);
            this.Controls.Add(this.touche6);
            this.Controls.Add(this.touche5);
            this.Controls.Add(this.touche4);
            this.Controls.Add(this.touche3);
            this.Controls.Add(this.touche2);
            this.Controls.Add(this.touche1);
            this.Name = "Form1";
            this.Text = "Calculatrice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button touche1;
        private System.Windows.Forms.Button touche2;
        private System.Windows.Forms.Button touche3;
        private System.Windows.Forms.Button touche4;
        private System.Windows.Forms.Button touche5;
        private System.Windows.Forms.Button touche6;
        private System.Windows.Forms.Button touche7;
        private System.Windows.Forms.Button touche8;
        private System.Windows.Forms.Button touche9;
        private System.Windows.Forms.Button touche0;
        private System.Windows.Forms.Button toucheC;
        private System.Windows.Forms.Button touchePlus;
        private System.Windows.Forms.TextBox Affichage;
        private System.Windows.Forms.TextBox Compteur;
        private System.Windows.Forms.Label AfficheTotal;
        private System.Windows.Forms.Button buttonEgal;
        private System.Windows.Forms.Button buttonVirgule;
        private System.Windows.Forms.Button buttonMoins;
        private System.Windows.Forms.Button buttonMultiplier;
        private System.Windows.Forms.Button buttonDiviser;
        private System.Windows.Forms.TextBox TextOperateur;
    }
}

