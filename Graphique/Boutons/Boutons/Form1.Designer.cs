namespace Boutons
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PremierClic = new System.Windows.Forms.Button();
            this.ClicMouvement = new System.Windows.Forms.Button();
            this.timerMouveRight = new System.Windows.Forms.Timer(this.components);
            this.timerMoveDown = new System.Windows.Forms.Timer(this.components);
            this.timerMoveLeft = new System.Windows.Forms.Timer(this.components);
            this.timerMoveUp = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PremierClic
            // 
            this.PremierClic.BackColor = System.Drawing.Color.DarkRed;
            this.PremierClic.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PremierClic.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PremierClic.Location = new System.Drawing.Point(12, 12);
            this.PremierClic.Name = "PremierClic";
            this.PremierClic.Size = new System.Drawing.Size(162, 23);
            this.PremierClic.TabIndex = 0;
            this.PremierClic.Text = "Clic";
            this.PremierClic.UseVisualStyleBackColor = false;
            this.PremierClic.Click += new System.EventHandler(this.PremierClic_Click);
            // 
            // ClicMouvement
            // 
            this.ClicMouvement.Location = new System.Drawing.Point(12, 52);
            this.ClicMouvement.Name = "ClicMouvement";
            this.ClicMouvement.Size = new System.Drawing.Size(162, 23);
            this.ClicMouvement.TabIndex = 1;
            this.ClicMouvement.Text = "Move";
            this.ClicMouvement.UseVisualStyleBackColor = true;
            this.ClicMouvement.Visible = false;
            // 
            // timerMouveRight
            // 
            this.timerMouveRight.Interval = 25;
            this.timerMouveRight.Tick += new System.EventHandler(this.timerMouve_Tick);
            // 
            // timerMoveDown
            // 
            this.timerMoveDown.Interval = 25;
            this.timerMoveDown.Tick += new System.EventHandler(this.timerMoveDown_Tick);
            // 
            // timerMoveLeft
            // 
            this.timerMoveLeft.Interval = 25;
            this.timerMoveLeft.Tick += new System.EventHandler(this.timerMoveLeft_Tick);
            // 
            // timerMoveUp
            // 
            this.timerMoveUp.Interval = 25;
            this.timerMoveUp.Tick += new System.EventHandler(this.timerMoveUp_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(784, 381);
            this.Controls.Add(this.ClicMouvement);
            this.Controls.Add(this.PremierClic);
            this.Name = "Form1";
            this.Text = "Jeux des boutons";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PremierClic;
        private System.Windows.Forms.Button ClicMouvement;
        private System.Windows.Forms.Timer timerMouveRight;
        private System.Windows.Forms.Timer timerMoveDown;
        private System.Windows.Forms.Timer timerMoveLeft;
        private System.Windows.Forms.Timer timerMoveUp;
    }
}

